---
title: APIs removed in Visual Studio 2022
description: Learn about VSSDK APIs removed in Visual Studio 2022, for extension authors updating their extensions to work with Visual Studio 2022.
ms.date: 06/08/2021
ms.topic: reference
author: maiak
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
monikerRange: "vs-2022"

---
# Visual Studio 2022 SDK removed APIs

The APIs below have been removed from the Visual Studio SDK and can no longer be used, please see each section for details on how to update your code.

* [`IVsImageService`](#ivsimageservice)
* [`IBlockContextProvider`](#iblockcontextprovider)
* [`IToolTipProvider`](#itooltipprovider)
* [`IVsTextScanner` and `IVsFullTextScanner`](#ivstextscanner-and-ivsfulltextscanner)
* [Asynchronous solution load and lightweight solution load](#asynchronous-solution-load-and-lightweight-solution-load)
* [`IVsDummy`](#ivsdummy)
* [`Microsoft.VisualStudio.Shell.Task`](#microsoftvisualstudioshelltask)
* [Open from source safe](#open-from-source-safe)
* [New WPF XAML Designer for .NET Framework](#new-wpf-xaml-designer-for-net-framework)

## IVsImageService

The `IVsImageService` is being removed in Visual Studio 2022. All users of `IVsImageService` should move to `IVsImageService2` instead.

### Recommended updates

If you use `IVsImageService`, replace calls to its methods with calls to equivalent methods on `IVsImageService2`:

| **IVsImageService Method** | **Equivalent IVsImageService2 Method** |
|----------------------------|----------------------------------------|
| Add                        | AddCustomImage                         |
| Get                        | GetImage                               |
| GetIconForFile             | GetImageMonikerForFile                 |
| GetIconForFileEx           | GetImageMonikerForFile                 |

`IVsImageService`’s Add and Get methods referred to custom images by name (a string), rather than a moniker.  It is preferable that you switch your code to use only monikers to refer to custom images, but if this proves impractical `IVsImageService2` has a couple of methods that will allow you to associate a name with a moniker:

* `TryAssociateNameWithMoniker`
* `GetImageMonikerForName`

Using those two methods, you can continue to reference images by name.

## IBlockContextProvider

The `IBlockContextProvider` and related types are being removed in Visual Studio 2022. All users of `IBlockContextProvider` should move to `IStructureContextSourceProvider` instead.

### Recommended updates

Users of `IBlockContextProvider` should use `IStructureContextSourceProvider` instead ([documentation](/dotnet/api/microsoft.visualstudio.text.adornments.istructurecontextsourceprovider)).

## IToolTipProvider

The `IToolTipProvider` and related types are being removed in Visual Studio 2022. All users of `IToolTipProvider` should move to `IToolTipService` instead.

### Recommended updates

Users of `IToolTipProvider` should use `IToolTipService` instead ([documentation](/dotnet/api/microsoft.visualstudio.text.adornments.itooltipservice)).

## IVsTextScanner and IVsFullTextScanner

The `IVsTextScanner` and `IVsFullTextScanner` are being removed in Visual Studio 2022. All users of `IVsTextScanner` or `IVsFullTextScanner` should move to `IVsTextLines` instead.

### Recommended updates

Users of `IVsTextScanner` or `IVsFullTextScanner` should use `IVsTextLines` instead ([documentation](/dotnet/api/microsoft.visualstudio.textmanager.interop.ivstextlines.getlinetext).

## Asynchronous solution load and lightweight solution load

The Asynchronous solution load (ASL) and lightweight solution load (LSL) features are being removed in Visual Studio 2022, as such the following methods are being removed:

### Interfaces

* `IVsSolution4` - Methods: `IsBackgroundSolutionLoadEnabled`, `EnsureProjectsAreLoaded`, `EnsureProjectIsLoaded`, `EnsureSolutionIsLoaded`
* `IVsSolutionLoadEvents` - Methods: `OnBeforeBackgroundSolutionLoadBegins`, `OnQueryBackgroundLoadProjectBatch`, `OnBeforeLoadProjectBatch`, `OnAfterLoadProjectBatch`
* `IVsSolutionLoadManagerSupport` - Entire interface
* `IVsSolutionLoadManager` - Entire interface
* `IVsSccManager3`  - Entire interface
* `IVsAsynchronousProjectCreate` - Entire interface
* `IVsAsynchronousProjectCreateUI` - Entire interface

### Enums, properties, and UI contexts

* `VSHPROPID_ProjectUnloadStatus` - Enum: `UNLOADSTATUS_LoadPendingIfNeeded`
* `VSHPROPID_DemandLoadDependencies`
* `VSHPROPID_IsProjectProvisioned`
* `VSPROPID_IsInBackgroundIdleLoadProjectBatch`
* `VSPROPID_IsInSyncDemandLoadProjectBatch`
* `VSPROPID_ActiveSolutionLoadManager`
* `UICONTEXT_BackgroundProjectLoad`

### Recommended updates

None.

## IVsDummy

The `IVsDummy` is being removed in Visual Studio 2022 and will not be replaced. 

### Recommended updates

None. But, it should have no impact as the API did nothing.

## Microsoft.VisualStudio.Shell.Task

The `Microsoft.VisualStudio.Shell.Task` class has been renamed to `Microsoft.VisualStudio.Shell.TaskListItem`
so as to not conflict with the very popular `System.Threading.Tasks.Task` class.

## Open from source safe

Support for opening a solution from source safe is being removed, as such the following methods, events, and, constants are being removed.

## Interfaces

* `IVsSCCProvider3` - Entire interface

### Recommended updates

None.

## New WPF XAML Designer for .NET Framework

The current WPF XAML Designer for .NET Framework has been deprecated and will be replaced with a new WPF XAML Designer for .NET Framework, based on the same architecture used for the WPF XAML Designer for .NET (.NET Core). This also means that the WPF .NET Framework control extensibility model based on .design.dll and Microsoft.Windows.Design.Extensibility is no longer supported. The new WPF XAML Designer for .NET Framework will provide the same extensibility model as the WPF XAML Designer for .NET (.NET Core). If you already created a .designtools.dll extension for .NET (.NET Core), that same extension will work for the new WPF XAML Designer for .NET Framework. Please refer to the migration link below for further information about how to migrate to the new extensibility model for WPF platforms (.NET Framework and .NET Core) and UWP platforms moving forward. 

### Recommended updates

See [XAML designer extensibility migration](https://github.com/microsoft/xaml-designer-extensibility/blob/main/documents/xaml-designer-extensibility-migration.md).
