---
title: "Output window"
description: "Write status messages, logs, and diagnostics to the Visual Studio Output window using the VisualStudio.Extensibility SDK."
ms.date: 05/04/2026
ms.topic: how-to
author: jasonchlus
ms.author: jasonc
monikerRange: ">=vs-2022"
manager: mijacobs
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Write to the Output window

Write status, diagnostic, and informational messages to a custom channel in the Visual Studio Output window.

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../../how-it-works/models/extensibility-models.md) for model comparison.

## Full example

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/OutputWindowSample/TestOutputWindowCommand.cs":::

> [!TIP]
> See the full working sample: [OutputWindowSample ↗](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/OutputWindowSample/)

**Related concepts:** [Contributions and configurations](../../how-it-works/contributions-and-configurations.md) — how output window channels are registered

## Understand the example

### Create a channel and write to it

```csharp
[VisualStudioContribution]
internal class MyCommand : Command
{
    private OutputChannel? outputChannel;

    public override async Task InitializeAsync(CancellationToken ct)
    {
        this.outputChannel = await this.Extensibility.Views().Output
            .CreateOutputChannelAsync("My Extension", ct);
    }

    public override async Task ExecuteCommandAsync(IClientContext context, CancellationToken ct)
    {
        if (this.outputChannel != null)
        {
            await this.outputChannel.Writer.WriteLineAsync("Operation started...");
            // ... do work ...
            await this.outputChannel.Writer.WriteLineAsync("Operation complete.");
        }
    }
}
```

### Writing options

The `OutputChannel` provides three ways to write:

| Method | Use when |
|--------|----------|
| `outputChannel.Writer.WriteLineAsync()` | Standard text output (most common) |
| `outputChannel.WriteLineAsync()` | Direct channel write (convenience) |
| `outputChannel.PipeWriter.WriteAsync()` | High-performance binary/bulk output |

The `Writer` property is a standard [`System.IO.TextWriter` ↗](/dotnet/api/system.io.textwriter) that supports `Write()`, `WriteAsync()`, `WriteLine()`, and `WriteLineAsync()`.

For high-performance scenarios, use the `PipeWriter` property ([`System.IO.Pipelines.PipeWriter` ↗](/dotnet/api/system.io.pipelines.pipewriter)):

```csharp
var bytes = new ReadOnlyMemory<byte>(Encoding.UTF8.GetBytes("Binary output message"));
await this.outputChannel.PipeWriter.WriteAsync(bytes, cancellationToken);
```

## Tips

### ✅ DO

- Call `CreateOutputChannelAsync()` once during initialization (e.g., `InitializeAsync`)
- Store the `OutputChannel` as a field for reuse across methods
- Use descriptive channel names that match your extension name

### ❌ DON'T

- Don't call `CreateOutputChannelAsync()` multiple times with the same name — it throws an exception
- Don't assume the Output window is visible — users must open it via **View > Output**
- Don't write high-frequency messages (floods the UI and hurts performance)

### 🔧 Troubleshooting

| Symptom | Fix |
|---------|-----|
| Exception on channel creation | You called `CreateOutputChannelAsync` twice with same name; create once in `InitializeAsync` |
| Messages not visible | User must select your channel from the "Show output from" dropdown |
| Null reference on channel | Ensure `InitializeAsync` completed before using the channel |

## Next steps

- [Status bar](status-bar.md) — show brief notifications inline
- [User prompts](../prompts/user-prompts.md) — interactive message dialogs
- [Add a command](../commands/commands.md) — trigger output from a command
- [Logging and diagnostics](../../how-it-works/logging.md) — extension-level logging

