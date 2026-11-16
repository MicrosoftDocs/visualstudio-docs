---
title: "Query the C#/VB Compiler workspace"
description: "Query the C# workspace from a VisualStudio.Extensibility extension using a C#/VB Compiler-hosted message handler."
ms.date: 11/10/2026
ms.topic: how-to
author: jasonchlus
ms.author: jasonc
ms.subservice: extensibility-integration
monikerRange: "visualstudio"
---

# Query the C#/VB Compiler workspace

Use the VisualStudio.Extensibility language APIs to send a query from an out-of-process extension to a handler hosted by the C#/VB Compiler. The handler can use compiler APIs to inspect the document and return a serializable response to the extension.

> [!NOTE]
> This guide uses the **VisualStudio.Extensibility** SDK. See [Choose the right extensibility model](../how-it-works/models/extensibility-models.md) for model comparison.

> [!IMPORTANT]
> C#/VB Compiler workspace queries are experimental and might change or be removed. The sample suppresses `VSEXTPREVIEW_LANGUAGES_QUERY` in files that use the experimental integration APIs and `RSEXPERIMENTAL008` in the handler. See [Experimental APIs](https://github.com/microsoft/VSExtensibility/blob/preview_18.13/docs/experimental_apis.md) for information about opting in.

This guide describes the C# query in the [compiler integration sample](https://github.com/microsoft/VSExtensibility/tree/preview_18.13/New_Extensibility_Model/Samples/RoslynIntegrationExtension). Its **Find Assembly from Symbol** command finds the type of the symbol at the caret and reports its containing assembly.

## Full example

The extension sends the query from its command:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/RoslynIntegrationExtension/RoslynIntegrationExtension/FindAssemblyCommand.cs":::

The C#/VB Compiler runs the handler in the separate handler project:

:::code language="csharp" source="~/../vs-extensibility-samples/New_Extensibility_Model/Samples/RoslynIntegrationExtension/RoslynMessageHandler/FindAssemblyHandler.cs":::

> [!TIP]
> See the full working sample: [C#/VB Compiler integration sample](https://github.com/microsoft/VSExtensibility/tree/preview_18.13/New_Extensibility_Model/Samples/RoslynIntegrationExtension/)

## Prerequisites

To build and run the sample, you need:

- Visual Studio version 18.13 or later with the **Visual Studio extension development** workload and the .NET 10 SDK.
- `Microsoft.VisualStudio.Extensibility.Sdk`, `Microsoft.VisualStudio.Extensibility.Build`, and `Microsoft.VisualStudio.Extensibility.CodeAnalysis`.
- `Microsoft.VisualStudio.Extensibility.CodeAnalysis.Server`.

## Understand the example

### Set up the projects

The sample has two projects:

- `RoslynIntegrationExtension` is the Visual Studio extension. It references the SDK, Build, and CodeAnalysis client packages and has a project reference to `RoslynMessageHandler`.
- `RoslynMessageHandler` is a .NET Standard 2.0 class library. It contains the handler and the shared request and response types, and references the CodeAnalysis.Server package rather than the extension SDK or Build package.

The project reference makes the handler and its message types available to the extension and includes the handler assembly in the VSIX. The handler isn't a separately installed extension. The C#/VB Compiler loads it to process the query.

The extension project references the client packages and includes this reference to the handler project:

```xml
<ItemGroup>
  <ProjectReference Include="..\RoslynMessageHandler\RoslynMessageHandler.csproj" />
</ItemGroup>
```

### Define the message types

The request carries the caret position as a `DocumentPosition`. The response carries the type and assembly information. These types use `JsonPropertyName` attributes for serialization and are defined in the handler project:

```csharp
using System.Text.Json.Serialization;
using Microsoft.CodeAnalysis.Extensions;

#pragma warning disable VSEXTPREVIEW_LANGUAGES_QUERY

public sealed class FindAssemblyMessage(DocumentPosition position)
{
    [JsonPropertyName("position")]
    public DocumentPosition Position { get; } = position;
}

public class FindAssemblyResponse(string? symbolType, string? assemblyName, string? assemblyVersion, string? assemblyPath)
{
    [JsonPropertyName("symbolType")]
    public string? SymbolType { get; } = symbolType;

    [JsonPropertyName("assemblyName")]
    public string? AssemblyName { get; } = assemblyName;

    [JsonPropertyName("assemblyVersion")]
    public string? AssemblyVersion { get; } = assemblyVersion;

    [JsonPropertyName("assemblyPath")]
    public string? AssemblyPath { get; } = assemblyPath;
}
```

### Implement the handler

Implement `IExtensionDocumentMessageHandler<TMessage, TResponse>` in the handler project. The C#/VB Compiler calls `ExecuteAsync` with the request and a document context. The sample checks for a source document, converts the requested position, and finds the symbol:

```csharp
public async Task<FindAssemblyResponse> ExecuteAsync(
    FindAssemblyMessage message,
    ExtensionDocumentMessageContext context,
    CancellationToken cancellationToken)
{
    _ = message ?? throw new ArgumentNullException(nameof(message));
    var document = context.TextDocument as Document
        ?? throw new ArgumentException("A source document is required.", nameof(context));

    var semanticModel = await document.GetSemanticModelAsync(cancellationToken);
    var symbol = await GetSymbolAsync(document, message.Position, cancellationToken);
    var typeSymbol = GetTypeSymbol(symbol);
    var assembly = typeSymbol?.ContainingAssembly;
    var filePath = assembly is null
        ? null
        : (semanticModel?.Compilation.GetMetadataReference(assembly) as PortableExecutableReference)?.FilePath;

    return new(
        typeSymbol?.ToDisplayString(),
        assembly?.Identity.Name,
        assembly?.Identity.Version.ToString(),
        filePath);
}

internal static async Task<ISymbol?> GetSymbolAsync(
    Document document,
    DocumentPosition documentPosition,
    CancellationToken cancellationToken)
{
    var position = await documentPosition.ToPositionAsync(document, cancellationToken);
    return await SymbolFinder.FindSymbolAtPositionAsync(document, position, cancellationToken);
}
```

The sample's `GetTypeSymbol` helper maps types, locals, fields, properties, and parameters to an `ITypeSymbol`; other symbols return `null`. See the [complete handler](https://github.com/microsoft/VSExtensibility/blob/preview_18.13/New_Extensibility_Model/Samples/RoslynIntegrationExtension/RoslynMessageHandler/FindAssemblyHandler.cs) for the helper, imports, and experimental diagnostic suppressions.

The assembly path can be `null`, such as when the type is defined in the current project rather than a metadata reference. The C#/VB Compiler can unload and reload handlers, so don't depend on persistent in-memory handler state.

### Send a query

In the extension's command, get the active text view, convert the caret position, and pass the request and document snapshot to `QueryAsync`:

```csharp
using var textView = await context.GetActiveTextViewAsync(cancellationToken);
if (textView is null)
{
    await this.Extensibility.Shell().ShowPromptAsync(
        "No active text view is available.", PromptOptions.OK, cancellationToken);
    return;
}

FindAssemblyMessage message = new(textView.Selection.ActivePosition.ToDocumentPosition());
var response = await this.Extensibility.Languages().CSharp()
    .QueryAsync<FindAssemblyHandler, FindAssemblyMessage, FindAssemblyResponse>(
        message, textView.Document, cancellationToken);
```

The snapshot ties the request to that document version. `CodeAnalysisLanguageQueryOptions.ThrowIfDocumentVersionIsNotCurrent` defaults to `true`, so the query fails if the document changes before the C#/VB Compiler handles the message. Handle query failures explicitly and allow cancellation to propagate. The sample shows an error prompt and rethrows non-cancellation exceptions.

To allow the query to use the document version current when the message is delivered, pass `CodeAnalysisLanguageQueryOptions` with `ThrowIfDocumentVersionIsNotCurrent` set to `false`. Positions and ranges represented by `DocumentPosition` and `DocumentRange` in the message that refer to the supplied snapshot are automatically mapped to that version. The overload with options returns the handler response and the corresponding document snapshot, so you can interpret the results against the version used by the handler rather than the originally requested version.

The response can have a `null` symbol type when the caret isn't on a supported symbol. The sample shows a prompt in that case; otherwise, it displays the result in a Remote UI dialog. See the [complete command](https://github.com/microsoft/VSExtensibility/blob/preview_18.13/New_Extensibility_Model/Samples/RoslynIntegrationExtension/RoslynIntegrationExtension/FindAssemblyCommand.cs) for the command configuration and response handling.

### Query without a document

For a query that doesn't take a document as a parameter, implement `IExtensionWorkspaceMessageHandler<TMessage, TResponse>` instead. Its `ExecuteAsync` method receives the message, an `ExtensionWorkspaceMessageContext`, and a cancellation token. Use `context.Solution` to access the current solution state.

In the extension, use the `QueryAsync<THandler, TMessage, TResponse>` overload that takes a message and cancellation token, without a document snapshot.

The handler and its message types must be available to the extension as described in [Set up the projects](#set-up-the-projects). Messages and responses must be JSON serializable. The `CSharp()` and `VisualBasic()` entry points access the same C#/VB Compiler workspace; choose the language or projects to inspect in the handler. Workspace queries use the current solution state rather than a document snapshot, and the handler can be unloaded and reloaded.

### Specify a document's project context

A document can have multiple project contexts, for example when it is included in more than one project. To select a context for a document query, call `GetProjectContextsAsync` on the document snapshot and set `CodeAnalysisLanguageQueryOptions.ProjectContext` to one of the returned contexts. The following example assumes `textView` and `message` are the active view and request from [Send a query](#send-a-query), and `selectedContextId` is the ID of the context the extension wants to use:

```csharp
using System.Linq;

var contexts = await textView.Document.GetProjectContextsAsync(cancellationToken);
ProjectContext? selectedContext = contexts?.Contexts.Where(c => c.Id == selectedContextId).Select(c => (ProjectContext?)c).FirstOrDefault();

if (selectedContext is null)
{
    await this.Extensibility.Shell().ShowPromptAsync(
        "The requested project context isn't available.", PromptOptions.OK, cancellationToken);
    return;
}

var options = new CodeAnalysisLanguageQueryOptions
{
    ProjectContext = selectedContext.Value,
};
var result = await this.Extensibility.Languages().CSharp()
    .QueryAsync<FindAssemblyHandler, FindAssemblyMessage, FindAssemblyResponse>(
        message, textView.Document, options, cancellationToken);
```

Use the context IDs and labels returned by `GetProjectContextsAsync` to identify a context, such as one selected by the user. The call can return `null` if no valid context is available. If `ProjectContext` is `null`, the query uses the document's current project context. `ProjectContext` applies only to document queries; it is ignored for non-document queries. A workspace handler can instead select projects from `context.Solution.Projects`.

## Try the sample

1. Open `Samples.slnx` from the samples repository and set `RoslynIntegrationExtension` as the startup project.
2. Build and press **F5** to launch the experimental instance.
3. Open a C# project and a `.cs` file, and wait for the project to load.
4. Place the caret on a type, local variable, field, property, or parameter. Select **Extensions** > **Find Assembly from Symbol**, or use the editor context menu.
5. Inspect the type and assembly information. If a metadata assembly path is available, use the folder button to locate it in File Explorer.

For detailed setup and examples, see the [sample README](https://github.com/microsoft/VSExtensibility/blob/preview_18.13/New_Extensibility_Model/Samples/RoslynIntegrationExtension/README.md).

## See also

- [Read and edit text](editor/editor.md)
- [Query the project system](query-projects.md)
- [Dialogs](prompts/dialogs.md)
- [.NET Compiler Platform SDK](https://learn.microsoft.com/dotnet/csharp/roslyn-sdk/)
