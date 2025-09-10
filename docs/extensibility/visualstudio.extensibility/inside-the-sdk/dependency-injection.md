---
title: Using dependency injection in a VisualStudio.Extensibility extension
description: Learn how to utilize dependency injection to build parts of your extension and share data between different parts of a VisualStudio.Extensibility extension.
ms.topic: conceptual
ms.date: 2/11/2025
ms.author: bertaygu
monikerRange: ">=vs-2022"
author: BertanAygun
manager: mijacobs
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---

# Dependency injection in VisualStudio.Extensibility extensions

Many components of the VisualStudio.Extensibility SDK, such as command handlers and tool window providers, are implemented as individual classes. To help share components between these classes, the SDK utilizes [.NET dependency injection](/dotnet/core/extensions/dependency-injection) to instantiate these classes as needed. To simplify data sharing between these components, we encourage extension developers to contribute their shared components to the dependency injection graph as well.

## Adding internal services to dependency injection graph

Each extension in the VisualStudio.Extensibility SDK has its own service graph that is created when the extension is first loaded. Extensions can override the [InitializeServices](/dotnet/api/microsoft.visualstudio.extensibility.extension.initializeservices) method to add their own services to the dependency injection graph. You can refer to [Markdown Linter](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/MarkdownLinter) for an example of using dependency injection to share a service.

> [!NOTE] 
> Unlike Visual Studio SDK's `IServiceProvider` pattern, these services are only visible to other components within the same extension and are not intended to be shared with other extensions.

## Services provided by VisualStudio.Extensibility SDK

In addition to services provided by the extension, VisualStudio.Extensibility SDK adds the following services to the graph when creating the extension instance:

* `TraceSource`: A shared instance of TraceSource is added to the graph that components can use to log warnings and errors. These logs can be useful to diagnose problems with the extension from customer reports.

* [VisualStudioExtensibility](/dotnet/api/microsoft.visualstudio.extensibility.visualstudioextensibility): Extensibility instance that exposes APIs to interact with Visual Studio such as documents, editor, workspace.

* `IServiceBroker`: The service broker can be used to access [brokered services](/visualstudio/extensibility/use-and-provide-brokered-services) offered by Visual Studio or other services that may not be part of the `VisualStudioExtensibility` surface area.

* `IServiceProvider`: The service provider can be used to query services within the extension's own dependency injection graph. This instance is not the same instance as the global service provider in the Visual Studio process for in-process extensions.

## Additional services for in-process extensions

For extensions running in-process, the following services are also available:

* `JoinableTaskFactory` and `JoinableTaskContext`: When running as an in-process extension utilizing other Visual Studio services, it may be necessary to utilize these instances to interact with the main thread without causing deadlocks. For more information, please see [Visual Studio Threading cookbook](https://github.com/microsoft/vs-threading/blob/main/docfx/docs/cookbook_vs.md).

* [AsyncServiceProviderInjection](/dotnet/api/microsoft.visualstudio.extensibility.vssdkcompatibility.asyncserviceproviderinjection-2) and [MefInjection](/dotnet/api/microsoft.visualstudio.extensibility.vssdkcompatibility.mefinjection-1): These classes can be used to retrieve in-process services offered by the `IServiceProvider` or `MEF` infrastructure in VisualStudio.Extensibility extension components. When available, we recommend utilizing services offered by the VisualStudio.Extensibility SDK first.

* `IAsyncServiceProvider2`: This class can be used as an alternative to `AsyncServiceProviderInjection` to query for in-process Visual Studio services using `GetServiceAsync` method.

## Extension methods provided by VisualStudio.Extensibility SDK

Extension methods to the `IServiceCollection` instance can also be used to help add services related to extensibility features:

* AddSettingsObservers: This method is generated when an extension contributes a [SettingsCategory](../settings/settings.md) and can be called in `InitializeServices` to inject observer services for the contributed settings category. You can refer to [SettingsSample](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model/Samples/SettingsSample) to see an example of this method being used.

## Service lifetimes

When adding a new service to the dependency injection graph in `InitializeServices` method, there are 3 different lifetime options. You can also refer to [example](#example-use-case) on how different lifetime options are used in an extension.

* `AddSingleton`: These services share the same lifetime as the extension instance. In most cases, using singleton services is the appropriate choice for a VisualStudio.Extensibility SDK extension.

* `AddTransient`: Transient services create a new instance of the implementation class or call the factory method each time a service queries it. As a result, each component gets its own instance of the service.

* `AddScoped`: This scope only applies to classes that have the `VisualStudioContribution` attribute and services queried by them. In the context of VisualStudio.Extensibility SDK, a scope is defined by the lifetime of a contributed component. In most cases, this lifetime is same as the extension lifetime so scoped vs singleton services will behave same. Documentation will make a special note if there are contributed components with different lifetimes.

## Example use case

This example demonstrates how to use a shared data source object between a tool window implementation and a command handler using dependency injection and `InitializeServices`.

* In `MyExtension.InitializeServices`, `MyDataSource` is added as a singleton service as it is shared across components. `MyToolWindowControl` is added as transient because every tool window instance should have its own unique instance of the hosted control.

* In `MyToolWindow`, we inject `IServiceProvider` in the constructor to avoid early initialization of `MyToolWindowControl` and instead query it via `GetRequiredService` when needed.


```csharp
[VisualStudioContribution]
public class MyExtension : Extension
{
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        // Always make sure to call the base method to add required services.
        base.InitializeServices(serviceCollection);

        serviceCollection.AddSingleton<MyDataSource>();
        serviceCollection.AddTransient<MyToolWindowControl>();
    }
}

[DataContract]
public class MyDataSource : NotifyPropertyChangedObject
{
}

public class MyToolWindowControl : RemoteUserControl
{
    public MyToolWindowControl(MyDataSource dataSource) : base(dataContext)
    {
    }
}

[VisualStudioContribution]
public class MyToolWindow : ToolWindow
{
    private readonly IServiceProvider serviceProvider;

    public MyToolWindow(IServiceProvider serviceProvider)
    {
    }

    public override Task<IRemoteUserControl> GetContentAsync(CancellationToken cancellationToken)
    {
        var control = this.serviceProvider.GetRequiredService<MyToolWindowControl>();
        return Task.FromResult<IRemoteUserControl>(control);
    }
}

[VisualStudioContribution]
public class MyCommand : Command
{
    public MyCommand(MyDataSource dataSource) { }
}
```





