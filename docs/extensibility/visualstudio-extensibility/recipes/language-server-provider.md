---
title: "Language Server Provider"
description: "Add language support to Visual Studio using the Language Server Protocol (LSP) with VisualStudio.Extensibility."
ms.date: 05/04/2026
ms.topic: how-to
author: jasonchlus
ms.author: jasonc
monikerRange: ">=vs-2022"
manager: mijacobs
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Language Server Provider

Add IntelliSense, diagnostics, formatting, and other language features to Visual Studio by implementing a Language Server Protocol (LSP) provider with VisualStudio.Extensibility.

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../how-it-works/models/extensibility-models.md) for model comparison.

## Full example

The complete implementation:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/RustLanguageServerProvider/RustLanguageServerProvider.cs":::

> [!TIP]
> See the full working sample: [RustLanguageServerProvider ↗](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/RustLanguageServerProvider/)

**Related concepts:** [Contributions and configurations](../how-it-works/contributions-and-configurations.md) — how `[VisualStudioContribution]` and document type configurations work

## Understand the example

### What you'll build

A `LanguageServerProvider` extension that connects an LSP-compliant language server to Visual Studio, enabling rich language support for custom file types.

### Implementation

#### Step 1: Define custom document types

Register file extensions your language server handles:

```csharp
[VisualStudioContribution]
internal static DocumentTypeConfiguration RustDocumentType => new("rust")
{
    FileExtensions = new[] { ".rs", ".rust" },
    BaseDocumentType = LanguageServerBaseDocumentType,
};
```

#### Step 2: Create the language server provider

Extend `LanguageServerProvider` and apply the `[VisualStudioContribution]` attribute:

```csharp
[VisualStudioContribution]
public class RustLanguageServerProvider : LanguageServerProvider
{
    public RustLanguageServerProvider(
        ExtensionCore container,
        VisualStudioExtensibility extensibilityObject,
        TraceSource traceSource)
        : base(container, extensibilityObject)
    {
    }

    public override LanguageServerProviderConfiguration LanguageServerProviderConfiguration =>
        new("Rust Language Server",
            new[]
            {
                DocumentFilter.FromDocumentType(RustDocumentType),
            });
}
```

#### Step 3: Start the language server connection

Override `CreateServerConnectionAsync` to launch your server and return a duplex pipe:

```csharp
public override Task<IDuplexPipe?> CreateServerConnectionAsync(CancellationToken cancellationToken)
{
    (Stream PipeToServer, Stream PipeToVS) = FullDuplexStream.CreatePair();

    // Launch or connect your language server process using PipeToServer

    return Task.FromResult<IDuplexPipe?>(
        new DuplexPipe(PipeToVS.UsePipeReader(), PipeToVS.UsePipeWriter()));
}
```

#### Step 4: Handle initialization results

Override `OnServerInitializationResultAsync` to respond to startup success or failure:

```csharp
public override Task OnServerInitializationResultAsync(
    ServerInitializationResult startState,
    LanguageServerInitializationFailureInfo? initializationFailureInfo,
    CancellationToken cancellationToken)
{
    if (startState == ServerInitializationResult.Failed)
    {
        // Disable the server to prevent further activation attempts
        this.Enabled = false;
    }

    return Task.CompletedTask;
}
```

#### Step 5: Send initialization options (optional)

Pass custom data to the server with the LSP `initialize` message:

```csharp
public RustLanguageServerProvider(
    ExtensionCore container,
    VisualStudioExtensibility extensibilityObject,
    TraceSource traceSource)
    : base(container, extensibilityObject)
{
    this.LanguageServerOptions.InitializationOptions =
        JToken.Parse(@"[{""server"":""initialize""}]");
}
```

#### Step 6: Publish diagnostics

Your language server sends `textDocument/publishDiagnostics` notifications to surface errors in the Visual Studio **Error List**:

```json
{
  "method": "textDocument/publishDiagnostics",
  "params": {
    "uri": "file:///c:/project/main.rs",
    "diagnostics": [
      {
        "range": { "start": { "line": 2, "character": 0 }, "end": { "line": 2, "character": 10 } },
        "severity": 1,
        "code": "E0425",
        "source": "rustc",
        "message": "cannot find value `foo` in this scope"
      }
    ]
  }
}
```

Severity values: `1` = Error, `2` = Warning, `3` = Information, `4` = Hint.

## Tips

### ✅ DO

- Use `LanguageServerBaseDocumentType` as the base for custom document types.
- Return a valid `IDuplexPipe` from `CreateServerConnectionAsync` — Visual Studio communicates with your server exclusively through this pipe.
- Set `this.Enabled = false` in `OnServerInitializationResultAsync` when the server fails to start, to prevent repeated activation attempts.
- Use `DocumentFilter.FromDocumentType()` to scope activation to specific file types.

### ❌ DON'T

- Don't use LSP for languages already supported by Visual Studio (C#, VB, C++) — use Roslyn analyzers instead.
- Don't block `CreateServerConnectionAsync` — launch your server process asynchronously and return the pipe.
- Don't forget to declare capabilities in your server's `InitializeResult` — missing capabilities cause the client to disconnect.
- Don't use `ErrorListProvider` (VSSDK) when you have an LSP server — diagnostics flow automatically through `textDocument/publishDiagnostics`.

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| Language server doesn't start | Verify `CreateServerConnectionAsync` returns a valid connection. Check the **Output** window for errors. |
| Diagnostics don't appear in Error List | Ensure your server sends `textDocument/publishDiagnostics`. Verify file URIs use the `file:///c:/...` format. |
| Server crashes on startup | Check that all required capabilities are declared in `InitializeResult`. |
| Custom file types not recognized | Confirm `DocumentTypeConfiguration` file extensions match (include the leading `.`). |
| Server keeps restarting | Check that `OnServerInitializationResultAsync` sets `this.Enabled = false` on failure. |

## Next steps

- [Create your first extension](../get-started/create-your-first-extension.md)
- [Language Server Protocol specification ↗](https://microsoft.github.io/language-server-protocol/)
- [Output window](observability/output-window.md)