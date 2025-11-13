---
title: Project Model Core Components
description: This article contains descriptions of the interfaces and services identified in the project model core, and the interfaces and services associated with objects.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- project models, objects and interfaces
- project models, services
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Project Model Core Components

The following tables expand on the project model. The tables present brief descriptions of the interfaces and services identified in the model, and the interfaces and services associated with specific objects. Additionally, the tables detail other interfaces that are optional in project creation and maintenance depending on the requirements of your specific project type.

 For more information, see [Supporting Symbol-Browsing Tools](../../extensibility/internals/supporting-symbol-browsing-tools.md).

### Package object

|Interface|Comments|
|---------------|--------------|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage>|Initializes a VSPackage in the IDE and makes its services available to the IDE.|

### Project Factory object

|Interface|Comments|
|---------------|--------------|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory>|Manages creating new projects and opening existing projects.|

### Project objects

|Interfaces|Comments|
|----------------|--------------|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3>|Manages the addition and removal of project items, opens editors, and maintains mapping between each document moniker and the `VSITEMID`. Inherits from `IVsProject` and `IVsProject2`.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy>|Manages navigation and display properties and provides events.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy>|Enables command execution similar to that of `IOleCommandTarget` for commands such as Cut and Rename that apply only when the focus is in Solution Explorer.|
|<xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget>|Serves as the primary command target interface for a project hierarchy. It is the standard interface for querying objects for their command status or state and running commands. Available when you are not focused in the Project window.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IPersistFileFormat>|Coordinates the persistence of the project state. Typically, the project state is stored as a project file but can be adapted to storage systems that are not file-based.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistHierarchyItem2>|Enables the project to manage all aspects of persistence for its project items, either as files on disk or objects in other storage systems. The `IVsPersistHierarchyItem2` interface is used for items that do not implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistDocData2> interface.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsSccProject2>|Coordinates interactions with source code control.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFlavorCfgProvider>|Enables projects to manage configuration information.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsCfgProvider2>|Manages project configuration objects, such as Debug/Release configurations. Build, deploy, and debug operations are coordinated through project configuration objects.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyDeleteHandler>|Implemented by hierarchies to control the delete (destructive) or remove (non-destructive) options for hierarchy items. Call Query Interface on the `IVsHierarchyDeleteHandler` interface from the `IVsHierarchy` interface.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsGetCfgProvider>|Provides the implementation option of having the object that supports the `IVsCfgProvider2` interface on a different COM identity than the project object that implements the `IVsHierarchy` interface.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectStartupServices>|Optional interface implemented to make your project extensible by other developers. The `IVsProjectStartupServices` interface enables a third-party VSPackage to register a GUID that you persist into your project file so that every time your project loads, you load the third-party service GUID into your project file and call `QueryService` for that GUID.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierWinClipboardHelperEvents>|Implemented by source hierarchies in a `UIHierarchy` window to coordinate clipboard operations such as cut, copy, and paste. Use the `AdviseClipboardHelperEvents` interface to register clipboard events.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyDropDataSource2>|Provides information about a dragged item relative to its data source during a drag-and-drop operation in a UI hierarchy window. Called from the `IVsHierarchy` interface.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyDropDataTarget>|Provides information about a dragged item relative to its drop target during a drag-and-drop operation in a UI hierarchy window. Called from the `IVsHierarchy` interface.|

### Configuration object

|Interfaces|Comments|
|----------------|--------------|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsCfg>|Provides information about a configuration.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectCfg2>|Enables projects to manage configuration information.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsDebuggableProjectCfg>|Enables a project to be run under the control of the debugger.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg>|Implemented by deployment projects that perform deployment operations for other projects.|

### Configuration Builder object

|Interfaces|Comments|
|----------------|--------------|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildableProjectCfg>|Manages a project configuration's build operation.|

### Additional Project objects

|Interfaces|Comments|
|----------------|--------------|
|`IDispatch`<br /><br /> <xref:Microsoft.VisualStudio.OLE.Interop.ISpecifyPropertyPages>|Displays item properties in the **Properties** window.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsOutput2><br /><br /> <xref:Microsoft.VisualStudio.Shell.Interop.IVsEnumOutputs>|Displays outputs for deployment.|

 The following table presents brief descriptions of the services identified in the project model.

### Services

|Service|Comments|
|-------------|--------------|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsRegisterProjectTypes>|Used by VSPackages that implement project types to register that their project factory exists with the IDE. Your VSPackage must call `QueryService` for this service and register its project factory when `IVsPackage::SetSite` method is called. If the `SetSite` method is not called, your project is not instantiated.|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsSolution>|Provides access to the IDE's internal, built-in notion of the current solution, such as the ability to enumerate projects, create new projects, take notice of project changes, and so on.|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsSccManager>|Called by projects that wish to participate in source control.|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsRunningDocumentTable>|Maintains a table of open documents to determine whether one or more of your project items are already opened.|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShellOpenDocument>|Contains the interfaces and methods called to actually open a project item using the standard editor or a specific editor.|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsTrackProjectDocuments>|Required to be called by all projects when they add, remove or rename their items.|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsFileChangeEx>|Manages changes to a file or directory and notifies clients when selected files have been changed on disk.|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsQueryEditQuerySave>|Required to be called by all projects and editors before they dirty items or save them.|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsSolutionBuildManager>|Manages the order of build and deployment operations for project configurations.|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsShellDebugger>|Provides access to low-level debugger services used for most debugging controls.|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsShellMonitorSelection>|Enables VSPackages access to information about current selections and enables communication with the **Properties** window.|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell>|Provides basic UI-related IDE functionality, such as the ability to create and enumerate tool windows or document windows or to report an error to the user.|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsStatusbar>|Provides access to the IDE's status bar.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsExtensibility3>|Used to implement the automation model. In your project model, you will return a properties object that lets you creates an instance of that object.|
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsUIHierWinClipboardHelper>|Used to implement clipboard events on the project object in the hierarchy. `SVsUIHierWinClipboardHelper` lets you correctly handle cut, copy, and paste operations.|

## See also
- <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget>
- [Checklist: Creating New Project Types](../../extensibility/internals/checklist-creating-new-project-types.md)
- [Not in Build: Using HierUtil7 Project Classes to Implement a Project Type (C++)](/previous-versions/bb166212(v=vs.100))
- [Supporting Symbol-Browsing Tools](../../extensibility/internals/supporting-symbol-browsing-tools.md)
- [Elements of a Project Model](../../extensibility/internals/elements-of-a-project-model.md)