---
title: "Related Services and Interfaces (Source Control VSPackage) | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "source control packages, interfaces"
  - "interfaces, source control packages"
ms.assetid: 3e96e838-5675-46bb-99cf-40d420086038
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Related Services and Interfaces (Source Control VSPackage)
This section lists all the source control VSPackage-related interfaces in the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)]. The source control VSPackage implements some of these interfaces and uses others to accomplish source control tasks.

## Interfaces Implemented by and for Source Control VSPackages
 The following interfaces are described in the [!INCLUDE[vsipsdk](../../extensibility/includes/vsipsdk_md.md)], and the source control VSPackage implements a subset of them depending on its desired feature set. Some interfaces are marked as required and must be implemented by every source control VSPackage.

 For those interfaces that a package does not implement, [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] provides a default implementation. Note that the default implementation is designed for the case when no VSPackage is registered and no project is controlled. A properly written source control VSPackage implements all necessary interfaces rather than leaving it to the default implementation of those interfaces.

 A source control VSPackage must implement a private service that encapsulates some or all of the following interfaces.

 Interfaces are:

- Required: The appropriate entity (source control VSPackage, Source Control Stub, project) must implement the interface.

- Recommended: The entity should implement this interface; otherwise, source control functionality may be limited.

- Optional: the entity can implement this interface to provide a richer feature set.

| Interface | Purpose | Implemented by | Implement? |
| - | - |--------------------------|-------------|
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2> | Editors call this interface before modifying or saving a file. The source control VSPackage can check out the file or deny the operation if the checkout fails. | Source control VSPackage | Recommended |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccManager2> | This interface provides basic source control functionality for projects, such as registering and unregistering projects with source control and providing support for basic source control glyphs. | Source control VSPackage | Required |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProject2> | This interface is obtained from the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> using the <xref:System.Runtime.InteropServices.Marshal.QueryInterface%2A> function, or by simply casting the object implementing `IVsHierarchy` to `IVsSccProject2`. It is used for getting the files under source control in a project or for informing the project of the current source control status or location. | Project | Required |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProvider> | The integration module uses this interface to set the current active VSPackage. | Source control VSPackage | Required |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocuments2> | This interface is based on a subscription model. Any VSPackage can signal that it wants to receive document events and be advised by the shell on events that are about to happen. It is implemented and handled by [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], which in turn passes events implementing the `IVsTrackProjectDocumentsEvents2` to the VSPackage. | Source Control Stub | Required |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocuments3> | This interface provides batch processing, synchronized read/write operations, and an advanced `OnQueryAddFiles` method. | Source Control Stub | Required |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocumentsEvents2> | **Solution Explorer** and projects call this interface when new files are added to the projects, or when files and folders are renamed or deleted from projects. The source control VSPackage can check out the project file or cancel the operation. | Source control VSPackage | Recommended |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocumentsEvents3> | **Solution Explorer** and projects call this interface in response to calls made to the methods of the IVstrackProjectDocuments3 interface. The source control VSPackage can track batched operations, synchronized read/write operations, and work with a more advanced `OnQueryAddFiles` method. | Source control VSPackage | Recommended |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccEnlistmentPathTranslation> | This interface provides enlistment management support for Web projects. | Source control VSPackage | Recommended |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccManagerTooltip> | This interface is used to retrieve ToolTips for the source-controlled files in the projects. | Source control VSPackage | Optional |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccOpenFromSourceControl> | This interface provides namespace extension support. | Source control VSPackage | Optional |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccControlNewSolution> | The VSPackage uses this interface to integrate a namespace extension into the **New**, **Open**, or **Save** dialog boxes. Consequently, projects can be automatically added to source control on creation, or added to source control when a save operation is in effect. | Source control VSPackage | Optional |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccGlyphs> | The VSPackage uses this interface to define additional glyphs as source control glyphs for nodes in **Solution Explorer**. | Source control VSPackage | Optional |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccAddWebProjectFromSourceControl> | The **Add** dialog box for Web projects uses this interface. It provides methods for browsing for a source control location and for opening a Web project previously added in the source control repository at that location. | Source control VSPackage | Recommended |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsAsynchOpenFromScc> | This interface provides support for asynchronous (background) loading of projects from source control. | Source control VSPackage | Optional |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsAsynchOpenFromSccProjectEvents> | This interface allows projects to watch the progress of asynchronous loading initiated by <xref:Microsoft.VisualStudio.Shell.Interop.IVsAsynchOpenFromScc>. | Project | Optional |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsSccToolsOptions> | This interface allows the IDE to query the active source control VSPackage. The IDE queries the value of source control settings that have meaning even when there is no active source control VSPackage registered. This interface is implemented and handled by [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]. | Source Control Stub | Required |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsRegisterScciProvider> | This interface is used in registering the source control VSPackage. | Source Control Stub | Required |
| <xref:EnvDTE.SourceControl> | This interface is used in automation. As such, it exposes only functions that can be executed without displaying any UI. | Source control VSPackage | Optional |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionProps> | This interface is used to save the source control settings in the solution (.sln) file. The settings include the source control location and source control status flags. | Source control VSPackage | Recommended |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistSolutionOpts> | This interface is used to save the source control settings in the solution options (.suo) file. This may include user-specific source control settings such as the current user's enlistment location. | Source control VSPackage | Recommended |
| <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3> | This interface is used to monitor events in order to perform operations such as checking in project files before closing solutions, or getting new files from source control when opening a project. | Source control VSPackage | Recommended |

## See also
- [Design Elements](../../extensibility/internals/source-control-vspackage-design-elements.md)