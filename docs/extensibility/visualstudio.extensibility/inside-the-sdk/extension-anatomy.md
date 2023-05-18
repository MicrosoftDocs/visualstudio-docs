---
title: Components of a VisualStudio.Extensibility extension
description: Learn the components of a Visual Studio extension created with the VisualStudio.Extensibility model, and how they interact with each other.
ms.topic: conceptual
ms.date: 3/31/2023
ms.author: maiak
monikerRange: ">=vs-2022"
author: maiak
manager: jmartens
ms.technology: vs-ide-sdk
---

# Components of a VisualStudio.Extensibility extension

An extension utilizing VisualStudio.Extensibility typically has several components that interact together and also with Visual Studio.

## Extension instance

The starting point for each extension is an instance of `Microsoft.VisualStudio.Extensibility.Extension`. This instance contains the necessary methods for Visual Studio to query services provided by the extension. It also provides virtual methods for the extension to provide localized resources and extension-owned local services to be shared between the components of the extension.

Extension projects have their own class that derives from `Microsoft.VisualStudio.Extensibility.Extension` to customize certain aspects of the extension.

Extensions must have a class that derives from `Microsoft.VisualStudio.Extensibility.Extension`. For an example implementation, see [MarkdownLinter](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/MarkdownLinter).

For extension developers that are familiar with the existing VS SDK APIs, this class is similar to `AsyncPackage` class that is used in the VS SDK extensibility model.

## VisualStudioExtensibility object

The object `Microsoft.VisualStudio.Extensibility.VisualStudioExtensibility` acts as the entry point for extensibility features exposed by Visual Studio. This class has various extension methods, properties to quickly enumerate through available features in extensibility SDK. See the API documentation for the available methods.

## Extension parts

For features where an extension contributes components to Visual Studio such as commands, editor listeners, extensions will utilize attributed classes. Build process will generate the correct metadata to ensure these components can be discovered by Visual Studio.

For features where an extension contributes components to Visual Studio such as commands, editor listeners, tool windows, etc., extensions utilize classes marked with the `VisualStudioContribution` attribute. The build process generates the correct metadata to ensure these components can be discovered by Visual Studio.

Currently the SDK supports a limited set of components to be contributed:

* [Command handlers](../extension-guides/command/command.md)
* [Tool windows](../extension-guides/tool-window/tool-window.md)
* [Text view opened closed listeners](../extension-guides/editor/editor.md) for tracking text view created, closed events.
* [Text view change listeners](../extension-guides/editor/editor.md) for tracking changes to an open text view.
* [Margin providers](https://github.com/microsoft/VSExtensibility/tree/main/docs/new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.Editor.md#T-Microsoft-VisualStudio-Extensibility-Editor-ITextViewMarginProvider)
* [Debugger visualizers](https://github.com/microsoft/VSExtensibility/tree/main/docs/new-extensibility-model/api/Microsoft.VisualStudio.Extensibility.md#T-Microsoft-VisualStudio-Extensibility-DebuggerVisualizers-DebuggerVisualizerProvider)

Instances for these classes are created as part of the extensibility framework provided by the SDK using a dependency injection library, and constructors can be used to retrieve instances of services provided by either the SDK or by the extension itself to share state across components.

### Lifetime of extension parts

The lifetime of each part is managed by the respective component that loads those parts inside Visual Studio IDE process.

* Command handlers are initialized when the corresponding command set is activated, which can be during the first execution of the command. Once activated, command handlers should only be disposed when IDE is shut down.

* Similarly text view event listeners are initialized when the first text view matching the content type specified is loaded in the IDE. Currently, such listeners are active until IDE is shut down but this behavior may change in future.

In general, for complex extensions we recommend that extensions provide local services that parts can import in their constructor and using those services to share state across parts and across instances of the same part. This practice ensures that extension state isn't affected by lifetime changes of extension parts.

### Services provided by SDK for injection

The following services are provided by the SDK that can be used in constructor for any extension part:

* `VisualStudioExtensibility`: Every extension part can inject an instance of `VisualStudioExtensibility` to interact with Visual Studio IDE.

* `Extension`: Parts can inject `Microsoft.VisualStudio.Extensibility.Extension` type or the extensions own type inheriting from it to extension parts.

* `TraceSource`: A trace source instance is created on demand for each extension that can be used to record diagnostic information. These instances are registered with Visual Studio diagnostics provider which can be used to merge logs from multiple services and utilize future tooling to access real time logging. See [Logging](logging.md).

* Local services: Any local services provided by the extension itself will also be available for dependency injection.

* `MefInjection<TService>` and `AsyncServiceProviderInjection<TService, TInterface>`: In-proc extensions can inject [Visual Studio SDK](https://www.nuget.org/packages/Microsoft.VisualStudio.SDK) services that would be traditionally consumed through either [MEF](/visualstudio/extensibility/managed-extensibility-framework-in-the-editor) or the [AsyncServiceProvider](/dotnet/api/microsoft.visualstudio.shell.asyncserviceprovider).

## Local extension services

In certain scenarios, an extension might want to share state between different components, such as a command handler and a text view change listener, as can be seen in `MarkdownLinter` example. These services can be added to in-process service collection by overriding `Extension.InitializeServices` method and as instances of extension parts are created, the services are injected based on the constructor arguments.

There are three options for adding a service:

* `AddTransient`: A new instance of the service is created for each part that ingests it.
* `AddScoped`: A new instance of the service is created within a certain scope. In context of Visual Studio extensibility, scope refers to a single extension part.
* `AddSingleton`: There's a single shared instance of service that is created on first ingestion.

Due to lifetime of `VisualStudioExtensibility` object being bound to the scope of a single extension part, any local service that ingests it has to be a scoped or transient service. Trying to create a singleton service that injects `VisualStudioExtensibility` will result in failure.

For an example of how local services are used, see [MarkdownLinter extension](https://github.com/Microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/MarkdownLinter/).

## Client context

Since all extensions in the new SDK run out of process, we introduce the concept of client context for various extension parts to represent the state of the IDE at the time that the event or method is invoked. This context is represented by the `IClientContext` instance in the SDK and is passed in to various operations such as command execution handlers. The SDK provides extension methods on `IClientContext` that can be utilized to retrieve objects from the context. For example, extensions can get the active text view or the URI for the selected items at the time of command execution utilizing the `IClientContext` instance.

Some components such as commands also allow you to declare which contexts they're interested in. This is done to optimize the amount of data transferred in each remote execution since client context can get large in the future. In the initial preview, there are only two available contexts, `Shell` and `Editor`, and both are included by default when declaring a command using `CommandAttribute`.
