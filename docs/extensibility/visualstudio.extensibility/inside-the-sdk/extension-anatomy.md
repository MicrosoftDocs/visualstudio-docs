---
title: Components of a VisualStudio.Extensibility extension
description: Learn the components of a Visual Studio extension created with the VisualStudio.Extensibility model, and how they interact with each other.
ms.topic: conceptual
ms.date: 3/31/2023
ms.author: maiak
monikerRange: ">=vs-2022"
author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---

# Components of a VisualStudio.Extensibility extension

An extension utilizing VisualStudio.Extensibility typically has several components that interact together and also with Visual Studio.

## Extension instance

Extensions must have a class that derives from [`Extension`](/dotnet/api/microsoft.visualstudio.extensibility.extension). For an example implementation, see [MarkdownLinter](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/MarkdownLinter).

An instance of the [`Extension`](/dotnet/api/microsoft.visualstudio.extensibility.extension) class is the starting point for the extension's execution. This instance contains the necessary methods for Visual Studio to query services provided by the extension. It also provides virtual methods for the extension to provide localized resources and extension-owned local services to be shared between the components of the extension.

The configuration for the `Extension` class also contains the [metadata](/dotnet/api/microsoft.visualstudio.extensibility.extensionconfiguration.metadata) for the extension which is shown in the Visual Studio [Manage Extensions window](/visualstudio/ide/finding-and-using-visual-studio-extensions#use-the-manage-extensions-dialog-box) and, for published extensions, on the [Visual Studio Marketplace](https://marketplace.visualstudio.com/).

```csharp
[VisualStudioContribution]
public class MarkdownLinterExtension : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
                id: "MarkdownLinter.0cf26ba2-edd5-4419-8646-a55d0a83f7d8",
                version: this.ExtensionAssemblyVersion,
                publisherName: "Microsoft",
                displayName: "Markdown Linter Sample Extension",
                description: "Sample markdown linter extension"),
    };
    ...
```

For extension developers who are familiar with the existing VSSDK APIs, the `Metadata` contained in [`ExtensionConfiguration`](/dotnet/api/microsoft.visualstudio.extensibility.extensionconfiguration) is used to generate the [`.vsixmanifest`](/visualstudio/extensibility/anatomy-of-a-vsix-package#the-vsix-manifest) file. Also, the [`Extension`](/dotnet/api/microsoft.visualstudio.extensibility.extension) class is similar to the [`AsyncPackage`](/dotnet/api/microsoft.visualstudio.shell.asyncpackage) class that is used in the VSSDK extensibility model.

## VisualStudioExtensibility object

The object [`VisualStudioExtensibility`](/dotnet/api/microsoft.visualstudio.extensibility.visualstudioextensibility) acts as the entry point for extensibility features exposed by Visual Studio. This class has various extension methods, properties to quickly enumerate through available features in extensibility SDK. See the API documentation for the available methods.

## Extension parts

For features where an extension contributes components to Visual Studio such as commands, editor listeners, extensions will utilize attributed classes. Build process will generate the correct metadata to ensure these components can be discovered by Visual Studio.

For features where an extension contributes components to Visual Studio such as commands, editor listeners, tool windows, etc., extensions utilize classes marked with the [`VisualStudioContribution`](/dotnet/api/microsoft.visualstudio.extensibility.visualstudiocontributionattribute) attribute. The build process generates the correct metadata to ensure these components can be discovered by Visual Studio.

Currently the SDK supports a limited set of components to be contributed:

* [Command handlers](../command/command.md)
* [Tool windows](../tool-window/tool-window.md)
* [Text view opened closed listeners](../editor/editor.md) for tracking text view created, closed events.
* [Text view change listeners](../editor/editor.md) for tracking changes to an open text view.
* [Margin providers](/dotnet/api/microsoft.visualstudio.extensibility.editor.itextviewmarginprovider)
* [Debugger visualizers](/dotnet/api/microsoft.visualstudio.extensibility.debuggervisualizers.debuggervisualizerprovider)

Instances for these classes are created as part of the extensibility framework provided by the SDK using a dependency injection library, and constructors can be used to retrieve instances of services provided by either the SDK or by the extension itself to share state across components.

### Lifetime of extension parts

The lifetime of each part is managed by the respective component that loads those parts inside Visual Studio IDE process.

* Command handlers are initialized when the corresponding command set is activated, which can be during the first execution of the command. Once activated, command handlers should only be disposed when IDE is shut down.

* Similarly text view event listeners are initialized when the first text view matching the content type specified is loaded in the IDE. Currently, such listeners are active until IDE is shut down but this behavior may change in future.

In general, for complex extensions we recommend that extensions provide local services that parts can import in their constructor and using those services to share state across parts and across instances of the same part. This practice ensures that extension state isn't affected by lifetime changes of extension parts.

### Services provided by SDK for injection and local extension services

VisualStudio.Extensibility SDK utilizes dependency injection to allow components to ingest both built-in services and also services offered by the extension locally to be shared between different components. Please refer to [dependency injection](./dependency-injection.md) section for more details on services offered by the SDK, service life times and example use cases of dependency injection.

For an example of how local services are used, see [MarkdownLinter extension](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/MarkdownLinter/).

## Client context

Since all extensions in the new SDK run out of process, we introduce the concept of client context for various extension parts to represent the state of the IDE at the time that the event or method is invoked. This context is represented by the [`IClientContext`](/dotnet/api/microsoft.visualstudio.extensibility.iclientcontext) instance in the SDK and is passed in to various operations such as command execution handlers. The SDK provides extension methods on `IClientContext` that can be utilized to retrieve objects from the context. For example, extensions can get the active text view or the URI for the selected items at the time of command execution utilizing the `IClientContext` instance.

Some components such as commands also allow you to declare which contexts they're interested in. This is done to optimize the amount of data transferred in each remote execution since client context can get large in the future. In the initial preview, there are only two available contexts, `Shell` and `Editor`, and both are included by default when declaring a command using `CommandAttribute`.
