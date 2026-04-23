---
title: Loading VSPackages
description: Learn about loading VSPackages in Visual Studio, including delayed loading, which is used whenever possible to improve performance.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- VSPackages, autoloading
- VSPackages, loading
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Load VSPackages

VSPackages are loaded into Visual Studio only when their functionality is required. For example, a VSPackage is loaded when Visual Studio uses a project factory or a service that the VSPackage implements. This feature is called delayed loading, which is used whenever possible to improve performance.

> [!NOTE]
> Visual Studio can determine certain VSPackage information, such as the commands that a VSPackage offers, without loading the VSPackage.

 VSPackages can be set to autoload in a particular user interface (UI) context, for example, when a solution is open. The <xref:Microsoft.VisualStudio.Shell.ProvideAutoLoadAttribute> attribute sets this context.

### Autoload a VSPackage in a specific context

- Add the `ProvideAutoLoad` attribute to the VSPackage attributes:

    ```csharp
    [DefaultRegistryRoot(@"Software\Microsoft\VisualStudio\14.0")]
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [ProvideAutoLoad(UIContextGuids80.SolutionExists)]
    [Guid("00000000-0000-0000-0000-000000000000")] // your specific package GUID
    public class MyAutoloadedPackage : Package
    {. . .}
    ```

     See the enumerated fields of <xref:Microsoft.VisualStudio.Shell.Interop.UIContextGuids80> for a list of the UI contexts and their GUID values.

- Set a breakpoint in the <xref:Microsoft.VisualStudio.Shell.Package.Initialize%2A> method.

- Build the VSPackage and start debugging.

- Load a solution or create one.

     The VSPackage loads and stops at the breakpoint.

## Force a VSPackage to load
 Under some circumstances a VSPackage may have to force another VSPackage to be loaded. For example, a lightweight VSPackage might load a larger VSPackage in a context that is not available as a CMDUIContext.

 You can use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsShell.LoadPackage%2A> method to force a VSPackage to load.

- Insert this code into the <xref:Microsoft.VisualStudio.Shell.Package.Initialize%2A> method of the VSPackage that forces another VSPackage to load:

    ```csharp
    IVsShell shell = GetService(typeof(SVsShell)) as IVsShell;
    if (shell == null) return;

    IVsPackage package = null;
    Guid PackageToBeLoadedGuid =
        new Guid(Microsoft.PackageToBeLoaded.GuidList.guidPackageToBeLoadedPkgString);
    shell.LoadPackage(ref PackageToBeLoadedGuid, out package);

    ```

     When the VSPackage is initialized, it will force `PackageToBeLoaded` to load.

     Force loading should not be used for VSPackage communication. Use [Use and provide services](../extensibility/using-and-providing-services.md) instead.

## Related content
- [VSPackages](../extensibility/internals/vspackages.md)
