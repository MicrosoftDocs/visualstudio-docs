---
title: Registration and Selection (Source Control VSPackage)
description: Learn how to register a source control VSPackage with Visual Studio and how to select which package to load from multiple registered source control packages.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- registration, source control packages
- source control packages, registration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Registration and Selection (Source Control VSPackage)

A source control VSPackage must be registered to expose it to the Visual Studio. If more than one source control VSPackage is registered, the user can select which VSPackage to load at appropriate times. See [VSPackages](../../extensibility/internals/vspackages.md) for more details on VSPackages and how to register them.

## Registering a Source Control Package
 The source control package is registered so that the Visual Studio environment can find it and query for its supported features. This is in accordance with a delay-loading scheme in which an instance of a package is created only when its features or commands are required or are requested explicitly.

 VSPackages place information in a version-specific registry key, HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*X.Y*, where *X* is the major version number and *Y* is the minor version number. This practice provides the ability to support side-by-side installation of multiple versions of Visual Studio.

 The Visual Studio user interface (UI) supports selection from among multiple installed source control plug-ins (via the Source Control Adapter Package) as well as source control VSPackages. There can be only one active source control plug-in or VSPackage at a time. However, as described below, the IDE allows switching between source control plug-ins and VSPackages through an automatic solution-based package-swapping mechanism. There are some requirements on the part of the source control VSPackage to enable this selection mechanism.

### Registry Entries
 A source control package needs three private GUIDs:

- Package GUID: This is the main GUID for the package that contains the source control implementation (called ID_Package in this section).

- Source Control GUID: This is a GUID for the source control VSPackage used to register with the Visual Studio Source Control Stub and is also used as a command UI context GUID. The source control service GUID is registered under the source control GUID. In the example, the source control GUID is called ID_SccProvider.

- Source control service GUID: This is the private service GUID used by Visual Studio (called SID_SccPkgService in this section). In addition to this, the source control package needs to define other GUIDs for VSPackages, tool windows, and so on.

  The following registry entries must be made by a source control VSPackage:

| Key name | Entries |
| - | - |
| `HKEY_LOCAL_MACHINE\   SOFTWARE\     Microsoft\       VisualStudio\         X.Y\           SourceControlProviders\` | (default) = rg_sz:{ID_SccProvider} |
| `HKEY_LOCAL_MACHINE\   SOFTWARE\     Microsoft\       VisualStudio\         X.Y\           SourceControlProviders\             {ID_SccProvider}\` | (default) = rg_sz:\<Friendly name of Package><br /><br /> Service = rg_sz:{SID_SccPkgService} |
| `HKEY_LOCAL_MACHINE\   SOFTWARE\     Microsoft\       VisualStudio\         X.Y\           SourceControlProviders\             {ID_SccProvider}\               Name\` | (default) = rg_sz:#\<Resource ID for localized name><br /><br /> Package = rg_sz:{ID_Package} |
| `HKEY_LOCAL_MACHINE\   SOFTWARE\     Microsoft\       VisualStudio\         X.Y\           SolutionPersistence\             <PackageName>\`<br /><br /> (Note that the key name, `SourceCodeControl`, is already used by Visual Studio and is not available as a choice for \<PackageName>.) | (default) = rg_sz:{ID_Package} |

## Selecting a Source Control Package
 Several Source Control Plug-in API-based plug-ins and source control VSPackages may be concurrently registered. The process of selecting a source control plug-in or VSPackage must ensure that Visual Studio loads the plug-in or VSPackage at the appropriate time, and can defer loading unnecessary components until they are required. Additionally, Visual Studio must remove all UI from other inactive VSPackages, including menu items, dialog boxes, and toolbars, and display the UI for the active VSPackage.

 Visual Studio loads a source control VSPackage when any one of the following operations is performed:

- Solution is opened (when the solution is under source control).

   When a solution or project under source control is opened, the IDE causes the source control VSPackage that was designated for that solution to be loaded.

- Any of the menu commands of the source control VSPackage are executed.

  A source control VSPackage should load any components it needs only when they are actually going to be used (otherwise known as delayed loading).

### Automatic Solution-based VSPackage Swapping
 You can manually swap source control VSPackages through the Visual Studio **Options** dialog box under the **Source Control** category. Automatic solution-based package swapping means that a source control package that has been designated for a particular solution is automatically set to active when that solution is opened. Every source control package should implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProvider.SetActive%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProvider.SetInactive%2A>. Visual Studio handles the switch between both source control plug-ins (implementing the Source Control Plug-in API) and source control VSPackages.

 The Source Control Adapter Package is used to switch to any Source Control Plug-in API-based plug-in. The process of switching to the intermediate Source Control Adapter Package and determining which source control plug-in must be set to active or inactive is transparent to the user. The Adapter Package is always active when any source control plug-in is active. Switching between two source control plug-ins amounts to simply loading and unloading the plug-in DLL. Switching to a source control VSPackage, however, involves interacting with the IDE to load the appropriate VSPackage.

 A source control VSPackage is called when any solution is opened and the registry key for the VSPackage is in the solution file. When the solution is opened, Visual Studio finds the registry value and loads the appropriate source control VSPackage. All source control VSPackages must have the registry entries described above. A solution that is under source control is marked as being associated with a particular source control VSPackage. Source control VSPackages must implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionPersistence> to enable automatic solution-based VSPackage swapping.

### Visual Studio UI for Package Selection and Switching
 Visual Studio provides a UI for source control VSPackage and plug-in selection in the **Options** dialog box under the **Source Control** category. It allows the user to select the active source control plug-in or VSPackage. A drop-down list includes:

- All installed source control packages

- All installed source control plug-ins

- A "none" option, which disables source code control

  Only the UI for the active source control choice is visible. The VSPackage selection hides the UI for the previous VSPackage and shows the UI for the new one. The active VSPackage is selected on a per-user basis. If a user has multiple copies of Visual Studio open concurrently, each one can potentially use a different active VSPackage. If multiple users are logged on to the same computer, each user can have separate instances of Visual Studio open, each with a different active VSPackage. When multiple instances of Visual Studio are closed by a user, the source control VSPackage that was active for the last open solution becomes the default source control VSPackage, to be set active on restart.

  Unlike previous versions of Visual Studio, an IDE restart is no longer the only way to switch source control VSPackages. VSPackage selection is automatic. Switching packages requires Windows User privileges (not Administrator or Power User).

## Related content
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionPersistence>
- [Features](../../extensibility/internals/source-control-vspackage-features.md)
- [Creating a Source Control Plug-in](../../extensibility/internals/creating-a-source-control-plug-in.md)
- [VSPackages](../../extensibility/internals/vspackages.md)
