---
title: .NET Compatibility for VisualStudio.Extensibility Extensions
description: .NET runtime requirements for VisualStudio.Extensibility extensions
author: murphymcquet-msft
ms.author: murphymcquet
ms.manager:  tinali
ms.date: 09/29/2026
ms.topic: concept-article
ms.subservice: extensibility-integration
ms.update-cycle: 365-days
---
# .NET Compatibility for VisualStudio.Extensibility Extensions

The new VisualStudio.Extensibility model allows extensions to be run outside the main Visual Studio process in a separate .NET host process. Because .NET is used as the runtime to execute these out-of-process extensions, they must stay up-to-date with the publicly supported .NET long-term servicing (LTS) runtimes.

## .NET Runtime Support Model

The .NET runtime has its own lifetime and servicing timelines, independent of Visual Studio. The current cadence sees a new .NET release every year, with odd-numbered major releases receiving 18 months of support, and even-numbered releases receiving long-term support (LTS) of 36 months. At any given time, Visual Studio ships with .NET LTS versions still in public support. For the official list of .NET runtimes and their lifetimes, see [here ↗](/lifecycle/products/microsoft-net-and-net-core).

The following timeline illustrates an approximation of the different .NET versions shipped with Visual Studio.

![Screenshot of .NET runtime timeline.](./media/vs-dotnet-timeline.png "Screenshot of .NET runtime timeline.")

By default, VisualStudio.Extensibility extensions target whatever the oldest supported .NET LTS runtime is. However, extension developers can specify in their extension metadata which versions of .NET their extension is known to support. Given this information, Visual Studio chooses an appropriate target based on the extension's declared .NET runtime version and its known end-of-life dates.

It's important to note that developers using VisualStudio.Extensibility should target a current .NET SDK. If an extension is developed for a .NET version that is no longer publicly supported - and therefore no longer shipped with Visual Studio - then Visual Studio will choose the oldest publicly supported runtime available to run the extension. Although the likelihood of being affected by a breaking change between major .NET versions is low, it isn't guaranteed that an application running on a previous .NET version will work on a newer one, and so the extension isn't guaranteed to work.

## Experiences

### End-user Experience

Visual Studio will choose which .NET runtime to use for an extension based on its declared supported .NET version and the .NET versions available to Visual Studio. There are only two scenarios where users will see any departure from the current experience:

* If an extension is only supported up to a .NET version that is near end-of-life, an info icon will be displayed on the extension tile in the Extension Manager window to inform the user that the extension is in danger of being unsupported.
* If an extension is only supported up to a .NET version that is past end-of-life, a warning icon will be displayed on the extension tile in the Extension Manager window to inform the user that the extension is being run as best-effort on a version of .NET that hasn't declared support for, and may not work correctly.

![Screenshot of extensions with different .NET runtime configurations.](./media/installed-extensions-extension-manager.png "Screenshot of extensions with different .NET runtime configurations.")

In both scenarios, the user should contact the extension developer and ask them to ensure the extension works on a supported .NET LTS version and publish the updated extension.

### Developer Experience - Debugging

For developers of VisualStudio.Extensibility extensions, the F5 debugging experience has been updated to allow the selection of the .NET runtime to use when debugging or testing an extension. The objective of this experience is to facilitate compatibility testing of VisualStudio.Extensibility extensions on different .NET runtimes.

Now, when the selected startup project is a VisualStudio.Extensibility project, an additional menu item with a list of the .NET runtimes that are shipped with Visual Studio appears under the debug menu dropdown. Debugging the extension under the chosen runtime ensures that the debugged extension executes on the selected runtime. In the experimental instance, the extension tile in the Extension Manager tool window displays a lab icon and specify the .NET version that it's being evaluated for. In the  following screenshot, this is demonstrated with the `Command Sample` extension.

Note that the example is a contrived scenario where Visual Studio includes .NET 6 and .NET 8. In actual releases only supported LTS versions of .NET will be included with Visual Studio.

![Screenshot of setting F5 Debug runtime target.](./media/f5-runtime-target.png "Screenshot of setting F5 Debug runtime target.")
![Screenshot of extension manager during F5 debug.](./media/f5-extension-manager-tool-window.png "Screenshot of extension manager during F5 debug.")

### Developer Experience - Extension Configuration

`ExtensionConfiguration.Metadata.DotnetTargetVersions` is an optional list of `DotnetTarget` descriptors for the host runtimes an extension supports. The SDK supplies a default runtime target when the list is omitted. If you test an extension built for an older .NET target on a newer host runtime, declare support for that runtime in the metadata. This prevents compatibility warnings in Visual Studio's Extension Manager when the extension runs on the newer runtime.

The project's `<TargetFramework>` (or entries in `<TargetFrameworks>`) controls what it builds against. Declaring support for a newer host runtime doesn't change the build target or make incompatible binaries work. Test your extension on each runtime before declaring support for it. See the [Insert GUID sample project ↗](https://github.com/microsoft/VSExtensibility/blob/main/New_Extensibility_Model/Samples/InsertGuid/InsertGuid.csproj) for a project file.
