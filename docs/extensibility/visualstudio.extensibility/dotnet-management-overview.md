# .NET Companatibilty for VisualStudio.Extensibility Extensions

## Overview

The new VisualStudio.Extensibilty model allows extensions to be run outside the main Visual Studio process in a seperate .NET host process. Because .NET is used as the runtime to execute VisualStudio.Extensibility extensions, extensions built using the VisualStudio.Extensibility framework must stay up-to-date with the publicly supported .NET long-term servicing (LTS) runtimes.

## .NET Runtime Support Model

The .NET runtime has its own lifetime and servicing timelines, independent of Visual Studio. The current cadence sees a new .NET release every year, with odd-numbered major releases receiving 18 months of support, and even-numbered releases receiving long-term support (LTS) of 36 months. At any given time, Visual Studio will ship with .NET LTS versions still in public support. For the official list of .NET runtimes and their liftimes, please see https://learn.microsoft.com/en-us/lifecycle/products/microsoft-net-and-net-core.

For Visual Studio, the versions shipped will be according to the below timeline.

![image info](../media/vs-dotnet-timeline.png)

By default, Visual Studio will build VisualStudio.Extensibility extensions to target whatever the oldest supported .NET LTS runtime is. However, extension developers can specify in their extension metadata which versions of .NET their extension is known to support. Given this information, Visual Studio will choose an appropriate target based on the runtimes the extension has declared support for and their known end-of-life dates.

It's important to note that developers using VisualStudio.Extensibility should target a current .NET SDK. If an extension is developed for .NET version that is no longer publicly supported - and therefore no longer shipped with Visual Studio - then it will be run on the oldest publicly supported runtime that is available with Visual Studio. Although the likelihood of being affected by a breaking change between major .NET versions is low, it is not guaranteed that an application running on a previous .NET version will work on a newer one, and so the extension is not guaranteed to work.

## Experiences

### End-user Experience

Visual Studio will choose which .NET runtime to use for an extension based on its declared supported .NET version and the .NET versions available to Visual Studio. There are only two scenarios where users will see any departure from the curerent experience:

* If an extension is only supported up to a .NET version that is near end-of-life, an info icon will be displayed on the extension tile in the Extension Manager window to inform the user that the extension is in danger of being unsupported.
* If an extension is only supported up to a .NET version that is past end-of-life, a warning icon will be displayed on the extension tile in the Extension Manager window to inform the user that the extension is being run as best-effort on a version of .NET that has not declared support for, and may not work correctly.

![image info](../media/installed-extensions-extensionManager.png)

In both scenarios, the user should contact the extension developer and ask them to ensure the extension works on a supported .NET LTS version and publish the updated extension.

### Developer Experience - Debugging

For developers of VisualStudio.Extensibility extensions, the F5 debugging experience has been updated to allow the selection of the .NET runtime to use when debugging or testing an extension. The objective of this experience is to facilitate compatability testing of VisualStudio.Extensibility extensions on different .NET runtimes.

Now, when the selected startup project is a VisualStudio.Extensibility project, an additional menu item with a list of the .NET runtimes that are shipped with Visual Studio will appear under the debug menu dropdown. Debugging the extension under the chosen runtime will ensure that the debugged extension will be executed using the selected runtime. In the experimental instance, the extension tile in the Extension Manager tool window will display a lab icon and specify the .NET version that it's being evaluated for. In the images below this icon appears alongside the `Command Sample` extension.

Please note that the below example is a contrived scenario where Visual Studio includes .NET 6 and .NET 8. In actual releases only supported LTS versions of .NET will be included with Visual Studio.

![image info](../media/f5-runtime-target.png)
![image info](../media/f5-extensionManager-toolwindow.png)

### Developer Experience - Extension Configuration

An optional `DotnetTargetVersions` field is available on the `ExtensionConfiguration` for developers to specify the .NET runtime(s) that their extension is able to target. This field takes a list of target framework monikers such as `net8.0` or `netstandard2.0`. If provided, this information allows Visual Studio to determine which runtime should be used to run the extension. If the field is left empty, then the older of the publicly supported runtimes that come with Visual Studio will be set as a default.

The VisualStudio.Extensibility analyzer will raise warnings if the target framework monikers specified in the extension project file `<TargetFrameworks>` property are inconsistent with the target framework monikers declared or omitted in the `ExtensionConfiguration`. If no targets are given in the `ExtensionConfiguration`, then a warning will be raised if any of the monikers in `<TargetFrameworks>` are not compatible with the chosen default. If targets are given in the `ExtensionConfiguration`, then a warning will be raised if any of the monikers specified in `<TargetFrameworks>` are not compatible with the provided values.

For example, if an extension builds targeting `netstandard2.0`, then it will be compatible with any .NET version. However, if a developer leaves the `DotnetTargetVersions` empty and `net8.0` is chosen as the default, if the extension builds targeting `net6.0` a warning will be raised.

The below picutres show an example of an extension which is built targeting .NET 8, but specified .NET 6 in the `DotnetTargetVersions`.

![image info](../media/extension-configuration.png)
![image info](../media/invalid-extension-configuration-warning.png)

## Testing & Early-Access

If you would like to try managing your extension with multiple .NET runtimes, please see the scripts included in the [VSExtensibility repo](https://github.com/microsoft/VSExtensibility/tree/main/New_Extensibility_Model). The included scripts enable you to update any of your Visual Studio instances with .NET 9. Please note that .NET 9 is *not* an LTS version of .NET and that this is *not* a supported scenario, but will provide a sample of the future experience of developing VisualStudio.Extensibility extensions with multiple .NET runtimes available.