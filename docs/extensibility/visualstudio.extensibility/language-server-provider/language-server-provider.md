---
title: Create an Extensible Language Server Provider
description: An overview of VisualStudio.Extensibility Language Server Provider and how to create an LSP server
author: javierdlg
ms.author: jadelaga
monikerRange: ">=vs-2022"
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
ms.topic: overview
ms.date: 10/23/2023
---

# Extensibility Language Server Provider

A Language Server Provider involves a process that is hosted outside of Visual Studio, and that provides language features not present in Visual Studio. 

These servers must adhere to the [Language Server Protocol](/visualstudio/extensibility/language-server-protocol), authored by an [extension project](./../get-started/create-your-first-extension.md), and implement `LanguageServerProvider`.

## Work with language server Providers

This overview covers these top scenarios for working with language server providers:

- [Create a language server provider](#create-a-language-server-provider)
- [Send additional data when starting a language server](#send-additional-data-when-starting-a-language-server)
- [Define custom document types](#define-custom-document-types)
- [Enable or disable a language server](#enable-or-disable-a-language-server)
- [Use localized resources](#use-localized-resources)

## Create a language server provider

Creating a language server provider involves adding a new class that extends [`Microsoft.VisualStudio.Extensibility.LanguageServer.LanguageServerProvider`](/dotnet/api/microsoft.visualstudio.extensibility.languageserver.languageserverprovider) and applying the [`VisualStudioContribution`](/dotnet/api/microsoft.visualstudio.extensibility.visualstudiocontributionattribute) attribute to it.

```csharp
[VisualStudioContribution]
public class MyLanguageServerProvider : LanguageServerProvider
{
    public MyLanguageServerProvider(ExtensionCore container, VisualStudioExtensibility extensibilityObject, TraceSource traceSource)
        : base(container, extensibilityObject)
    {
    }
}
```

After you've defined your provider, you need to:

1. Configure your provider by overriding the `LanguageServerProviderConfiguration` property. This configuration property defines the server display name and applicable document types. `LanguageServerBaseDocumentType` is available for all servers and triggers on all document types. See [Define a custom Document Type](#define-custom-document-types).

    ```csharp
    public override LanguageServerProviderConfiguration LanguageServerProviderConfiguration => new("My Language Server",
        new[]
        {
           DocumentFilter.FromDocumentType(LanguageServerBaseDocumentType),
        });
    ```
1. Override the `CreateServerConnectionAsync` method, which is called by Visual Studio to notify the extension that the LSP server should be started.

    ```csharp
    // Activate the language server and return a duplex pipe that communicates with the server. 
    public override Task<IDuplexPipe?> CreateServerConnectionAsync(CancellationToken cancellationToken)
    {
        (Stream PipeToServer, Stream PipeToVS) = FullDuplexStream.CreatePair();
    
        // Connect "PipeToServer" to the language server
    
        return Task.FromResult<IDuplexPipe?>(new DuplexPipe(PipeToVS.UsePipeReader(), PipeToVS.UsePipeWriter()));
    }
    ```

1. Override the `OnServerInitializationResultAsync` method, which is called by Visual Studio after the LSP server has completed its start-up and configuration steps. `ServerInitializationResult` provides the resulting state of the server, and `LanguageServerInitializationFailureInfo` provides an exception if any.

    ```csharp
    public override Task OnServerInitializationResultAsync(ServerInitializationResult startState,LanguageServerInitializationFailureInfo?     initializationFailureInfo, CancellationToken cancellationToken)
    {
        // Method called when server activation was completed successfully or failed, denoted by "startState".
        return Task.CompletedTask;
    }
    ```

Here's what our sample language server provider looks like after completing all of the steps:

```csharp
[VisualStudioContribution]
public class MyLanguageServerProvider : LanguageServerProvider
{
    public MyLanguageServerProvider(ExtensionCore container, VisualStudioExtensibility extensibilityObject, TraceSource traceSource)
        : base(container, extensibilityObject)
    {
    }

    public override LanguageServerProviderConfiguration LanguageServerProviderConfiguration =>
        new("My Language Server",
            new[]
            {
               DocumentFilter.FromDocumentType(LanguageServerBaseDocumentType),
            });

    // Activate the language server and return a duplex pipe that communicates with the server. 
    public override Task<IDuplexPipe?> CreateServerConnectionAsync(CancellationToken cancellationToken)
    {
        (Stream PipeToServer, Stream PipeToVS) = FullDuplexStream.CreatePair();

        // Connect "PipeToServer" to the language server

        return Task.FromResult<IDuplexPipe?>(new DuplexPipe(PipeToVS.UsePipeReader(), PipeToVS.UsePipeWriter()));
    }

    public override Task OnServerInitializationResultAsync(ServerInitializationResult startState, LanguageServerInitializationFailureInfo? initializationFailureInfo, CancellationToken cancellationToken)
    {
        // Method called when server activation was completed successfully or failed, denoted by "startState".
        return Task.CompletedTask;
    }
}
```

## Send additional data when starting a language server

`LanguageServerOptions.InitializationOptions` can be set in the constructor for `LanguageServerProvider` to send additional data to the server with the "initialize" protocol message.

```csharp
public MyLanguageServerProvider(ExtensionCore container, VisualStudioExtensibility extensibilityObject, TraceSource traceSource)
    : base(container, extensibilityObject)
{
    this.LanguageServerOptions.InitializationOptions = JToken.Parse(@"[{""server"":""initialize""}]");
}
```

## Define custom document types

When an extension supports file types that are not natively supported by Visual Studio, extension authors can implement custom document types. These types can be used when defining `LanguageServerProviderConfiguration` to specify the supported document types.

```csharp
[VisualStudioContribution]
internal static DocumentTypeConfiguration RustDocumentType => new("rust")
{
    FileExtensions = new[] { ".rs", ".rust" },
    BaseDocumentType = LanguageServerBaseDocumentType,
};

[VisualStudioContribution]
internal static DocumentTypeConfiguration MarkdownDocumentType => new("markdown")
{
    FileExtensions = new[] { ".md" },
    BaseDocumentType = LanguageServerBaseDocumentType,
};
```

This snippet defines two new document types: `rust` and `markdown`. These types contain a list of file extensions and a base type, which can be `LanguageServerBaseDocumentType` to cover all types. 

Use these types in `LanguageServerProviderConfiguration` to activate your server when these document types are opened:

```csharp
public override LanguageServerProviderConfiguration LanguageServerProviderConfiguration =>
    new("My Language Server",
        new[]
        {
            DocumentFilter.FromDocumentType(RustDocumentType),
            DocumentFilter.FromDocumentType(MarkdownDocumentType),
        });
```

## Enable or disable a language server

An enabled language server is allowed to "activate" once an applicable document type is opened. When disabled, a stop message is sent to any applicable active language server and prevent further activations.

```csharp
[VisualStudioContribution]
public class MyLanguageServerProvider : LanguageServerProvider
{
    ...

    public override Task OnServerInitializationResultAsync(ServerInitializationResult startState, LanguageServerInitializationException? initializationFailureInfo, CancellationToken cancellationToken)
    {
        if (startState == ServerInitializationResult.Failed)
        {
            Telemetry.LogEvent(initializationFailureInfo.StatusMessage, initializationFailureInfo.Exception)

            // Disable the language server.
            this.Enabled = false;
        }
    }
}
```

This code snippet disables the language server by setting `this.Enabled` to `false` if `ServerInitializationResult` gets set to `Failed` after failing to initialize.

> [!NOTE]
> This flag is public and if set to false, any running servers are stopped.

## Use localized resources
We support using localization by defining a `string-resources.json` file and using `%tokens%` to specify localized content.

### string-resources.json

```JSON
{
  { "LocalizedResource": "LangaugeServerLocalized" }
}
```

### Access a localized resource

```csharp
[VisualStudioContribution]
public class MyLanguageServer : LanguageServerProvider
{
    ...

    /// <inheritdoc/>
    public override LanguageServerProviderConfiguration LanguageServerProviderConfiguration =>
        new("%LocalizedResource%",
            new[]
            {
                DocumentFilter.FromDocumentType(LanguageServerBaseDocumentType)
            });
}
```

## Next steps

- Follow the [create your first extension](../get-started/create-your-first-extension.md) tutorial to get started with creating an extension.
- See the [Rust Language Server Provider](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/RustLanguageServerProvider) sample for a full example of creating an extension with a language server provider.