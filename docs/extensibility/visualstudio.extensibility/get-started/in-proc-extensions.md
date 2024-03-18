---
title: VSSDK-compatible VisualStudio.Extensibility extensions
description: A reference for creating your first in-proc VisualStudio.Extensibility extension
ms.topic: tutorial
ms.date: 3/31/2023
ms.author: maiak
monikerRange: ">=vs-2022"
author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---

# Using VisualStudio.Extensibility SDK and VSSDK together

While the VisualStudio.Extensibility model was created primarily to host extensions outside of the devenv.exe process, it's possible to use VisualStudio.Extensibility SDK APIs in an extension running in the Visual Studio process and utilizing traditional extensibility APIs provided by the [Microsoft.VisualStudio.Sdk](https://www.nuget.org/packages/Microsoft.VisualStudio.Sdk) packages.

The support of *in-proc* usage is meant to allow early adopters to the new VisualStudio.Extensibility APIs while relying on [Microsoft.VisualStudio.Sdk](https://www.nuget.org/packages/Microsoft.VisualStudio.Sdk) to cover any feature gap.

This document is a quick walkthrough on different options to utilize VisualStudio.Extensibility SDK in-proc.

* If you're developing a new extension, our recommended method is to create a VisualStudio.Extension that is hosted in-process following [this tutorial](#create-your-first-vssdk-compatible-visualstudioextensibility-extension). This method allows you to use full capabilities of VisualStudio.Extensibility SDK in addition to being able to inject VSSDK and MEF services.

* If you have an existing VSSDK extension, you can follow [these tips](#use-visualstudioextensibility-from-existing-vssdk-extensions) to use the new [VisualStudioExtensibility](/dotnet/api/microsoft.visualstudio.extensibility.visualstudioextensibility) instance in your extension.

* If you want to add commands, debug visualizers, tool windows to your existing VSSDK extension by using the VisualStudio.Extensibility SDK, you can refer to [these tips](#add-a-visualstudioextensibility-extension-to-an-existing-vssdk-extension-project) to host both a VSSDK extension and a VisualStudio.Extensibility extension in the same VS extension project.

## Create your first VSSDK-compatible VisualStudio.Extensibility extension

While the VisualStudio.Extensibility model was created primarily to host extensions outside of the devenv.exe process, starting with Visual Studio 2022 17.4 Preview 1 it's possible to build a VisualStudio.Extensibility extension that's hosted within devenv.exe and can use traditional extensibility APIs provided by the [Microsoft.VisualStudio.Sdk](https://www.nuget.org/packages/Microsoft.VisualStudio.Sdk) packages.

### Prerequisites

* Visual Studio 2022 version 17.9 Preview 1 or higher with the `Visual Studio extension development` workload.
* If you're updating from earlier builds, make sure to uninstall VisualStudio.Extensibility Project System to avoid potential conflicts.

### Create the extension project

* Use the *VisualStudio.Extensibility Extension with VS SDK Compatibility* template to create a new solution.

![Screenshot of the VisualStudio.Extensibility in-process extension project template.](./media/in-proc-project-template.png)

### Debug your extension

* Set the *Container* project as *Startup Project*, press `F5` to start debugging.

* Pressing `F5` builds your extension and deploys it to the experimental instance of Visual Studio version you're using. The debugger should attach once your extension is loaded.

* You can find the command in `Extensions` menu as shown in the following image:

  ![Screenshot showing sample extension command.](./media/extension-command-2.png)

## Consuming Visual Studio SDK services from a VisualStudio.Extensibility extension

A VS-SDK-compatible extension project references the [Microsoft.VisualStudio.Sdk](https://www.nuget.org/packages/Microsoft.VisualStudio.Sdk) package, which allows access to all Visual Studio SDK's services.

Traditionally, such services are consumed through either [MEF](/visualstudio/extensibility/managed-extensibility-framework-in-the-editor) or the [AsyncServiceProvider](/dotnet/api/microsoft.visualstudio.shell.asyncserviceprovider). A VisualStudio.Extensibility extender is instead encouraged to  [.NET dependency injection](/dotnet/core/extensions/dependency-injection).

The `MefInjection<TService>` and `AsyncServiceProviderInjection<TService, TInterface>` classes (both from the `Microsoft.VisualStudio.Extensibility.VSSdkCompatibility` namespace) allow you to consume the Visual Studio SDK's services by adding them to the constructor of a class that is instantiated through dependency injection (like a command, tool window or extension part).

The following example shows how the `DTE2` and `IBufferTagAggregatorFactoryService` services can be added to a command.

```CSharp
    [VisualStudioContribution]
    public class Command1 : Command
    {
        private TraceSource traceSource;
        private AsyncServiceProviderInjection<DTE, DTE2> dte;
        private MefInjection<IBufferTagAggregatorFactoryService> bufferTagAggregatorFactoryService;

        public Command1(
            VisualStudioExtensibility extensibility,
            TraceSource traceSource,
            AsyncServiceProviderInjection<DTE, DTE2> dte,
            MefInjection<IBufferTagAggregatorFactoryService> bufferTagAggregatorFactoryService)
            : base(extensibility)
        {
            this.dte = dte;
            this.bufferTagAggregatorFactoryService = bufferTagAggregatorFactoryService;
        }
    
        public override CommandConfiguration CommandConfiguration => new("Sample Remote Command")
        {
            Placements = new[] { CommandPlacement.KnownPlacements.ExtensionsMenu },
            Icon = new(ImageMoniker.KnownValues.Extension, IconSettings.IconAndText),
        };
```

## Anatomy of a VSSDK-compatible VisualStudio.Extensibility extension

While using the *VisualStudio.Extensibility Extension with VS SDK Compatibility* template takes care of setting up the entire solution, it's useful to know what are the basic components of a VS-SDK-compatible VisualStudio.Extensibility extension and how it differs from the common variant described in the ["create your first extension" guide](create-your-first-extension.md).

### Container project

A VS-SDK-compatible VisualStudio.Extensibility solution is composed of two projects:

1. a class library that references both the VisualStudio.Extensibility and Visual Studio SDK packages and contains all the code of the extension,
1. a container VSIX project that you use to deploy and debug the extension.

This separation is a temporary solution while the VisualStudio.Extensibility is in preview and the final packaging and deployment design is being finalized.

The extender shouldn't add code, content or resources to the container project. The only goal of the container project is to include the assets provided by the other project.

### TargetFramework

Both the extension project and the container project must target the .NET version used by the target Visual Studio version. For Visual Studio 2022, they must target .NET Framework 4.7.2.

### RequiresInProcessHosting property

The [`Extension`](/dotnet/api/microsoft.visualstudio.extensibility.extension) class must be configured with the `RequiresInProcessHosting = true` property that identifies the extension as being *in-process*.

```CSharp
[VisualStudioContribution]
internal class MyExtension : Extension
{
    public override ExtensionConfiguration? ExtensionConfiguration => new()
    {
        RequiresInProcessHosting = true,
    };

    ...
```

## Use VisualStudio.Extensibility from existing VSSDK extensions

For existing VSSDK extensions, another option is to query for the [VisualStudioExtensibility](/dotnet/api/microsoft.visualstudio.extensibility.visualstudioextensibility) instance via service provider and utilize its methods. This method allows you to use new the API surface area of VisualStudio.Extensibility SDK in your existing components. This option can be useful in situations where you like to use the new API to query project information, document management without creating a new VisualStudio.Extensibility-based extension. 

Here's an example code snippet that shows how one can utilize `VisualStudioExtensibility` within a VSSDK package:

* In your `.csproj` file, include a package reference to VisualStudio.Extensibility APIs:

```XML
  <ItemGroup>
    <PackageReference Include="Microsoft.VisualStudio.Extensibility" Version="17.9.23-preview-1" />
  </ItemGroup>
```

* You can now query for [VisualStudioExtensibility](/dotnet/api/microsoft.visualstudio.extensibility.visualstudioextensibility) instance via `GetServiceAsync` method in your package or other components:

```CSharp
...
using Microsoft.VisualStudio.Extensibility;
...

public class VSSDKPackage : AsyncPackage
{
    protected override async Task InitializeAsync(CancellationToken cancellationToken, IProgress<ServiceProgressData> progress)
    {
        VisualStudioExtensibility extensibility = await this.GetServiceAsync<VisualStudioExtensibility, VisualStudioExtensibility>();
        await extensibility.Shell().ShowPromptAsync("Hello from in-proc", PromptOptions.OK, cancellationToken);
        ...
    }
}
```

## Add a VisualStudio.Extensibility extension to an existing VSSDK extension project

If you also want to contribute components like tool windows, editor listeners using the VisualStudio.Extensibility SDK within your existing VSSDK extension, you will have to follow additional steps to create a VisualStudio.Extensibility [Extension](/dotnet/api/microsoft.visualstudio.extensibility.extension) instance in your project.

* You need an SDK style `.csproj` in order to utilize VisualStudio.Extensibility SDK packages. For existing projects, you might need to update your `.csproj` to an SDK style one.

* Remove package reference for `Microsoft.VSSDK.BuildTools` and instead add package references for VisualStudio.Extensibility.

```XML
    <PackageReference Include="Microsoft.VisualStudio.Extensibility.Sdk" Version="17.9.23-preview-1" />
    <PackageReference Include="Microsoft.VisualStudio.Extensibility.Build" Version="17.9.23-preview-1" />
```

* Add `VssdkCompatibleExtension` property to your project file, setting it to `true`. This property will enable some VSSDK features for compatibility.

```XML
<PropertyGroup>
    <VssdkCompatibleExtension>true</VssdkCompatibleExtension>
</PropertyGroup>    
```

* Create a new extension class inheriting from [`Extension`](/dotnet/api/microsoft.visualstudio.extensibility.extension) base class and set [RequiresInProcessHosting](#requiresinprocesshosting-property) property as shown previously.

You can now use all capabilities of VisualStudio.Extensibility together with your existing VSSDK extension.
