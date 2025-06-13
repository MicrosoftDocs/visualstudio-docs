---
title: Properties and Methods Extended by Project Subtypes
description: Learn about features that project subtypes can enhanced or modified, which lets you customize the behavior of the project systems of Visual Studio.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- project subtypes, extended methods
- project subtypes, extended properties
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Properties and Methods Extended by Project Subtypes

A project subtype has a lot of power to influence the behavior of the project because it is constructed as an aggregator of a base project. This section summarizes some of the features that can be enhanced or modified by project subtypes.

## Features Gained by Aggregation
 The following table summarizes many of the methods that aggregation enables project subtypes to override in base projects.

|Methods Overridden by Aggregation|Project Subtype|
|---------------------------------------|---------------------|
|From <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy>:<br /><br /> <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty%2A><br /><br /> <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.SetProperty%2A><br /><br /> <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetGuidProperty%2A><br /><br /> <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.SetGuidProperty%2A>|Enables a project subtype to<br /><br /> -   Change caption and icon of project node.<br />-   Completely override project `Browse` object.<br />-   Control whether project can be renamed.<br />-   Control sort order.<br />-   Control user context for dynamic help.|
|From <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject>:<br /><br /> <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject.GetItemContext%2A>|Enables a project subtype to control what contextual services are provided to designers and editors.|
|From <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget>:<br /><br /> <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus%2A><br /><br /> <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec%2A><br /><br /> <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy.QueryStatusCommand%2A><br /><br /> <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy.ExecCommand%2A>|Enables a project subtype to<br /><br /> -   Participate in the command routing for project commands.<br />-   Add, remove, or disable both project ambient commands and Solution Explorer active commands.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsFilterAddProjectItemDlg2>|Enables the project subtype to filter what the user sees in the **Add New Item** dialog box.|
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsSingleFileGeneratorFactory>|Enables a project subtype to<br /><br /> -   Determine the default generator given a file extension.<br />-   Map a human readable generator name to a COM object.|

## Properties Used by Project Subtypes
 The environment and base project system can use the properties from <xref:Microsoft.VisualStudio.Shell.Interop.__VSSPROPID> and <xref:Microsoft.VisualStudio.Shell.Interop.__VSSPROPID2> enumerations detailed in the following table to enable a project subtype to control various features of the project system.

|VSHPROPID property|Project Subtype|
|------------------------|---------------------|
|`AddItemTemplatesGuid`|Allows a project subtype to control the contents of the **Add Item** dialog box. The project subtype can provide a new specification of template directories, add new kinds of items, remove existing items, and reorganize a subset of the items in the base project's **Add Item** dialog box.|
|`PropertyPagesCLSIDList`|Allows a project subtype to add or remove configuration-independent property pages.|
|`CfgPropertyPagesCLSIDList`|Allows a project subtype to add or remove configuration-dependent property pages.|
|`ExtObjectCATID`|Allows a project subtype to provide an Automation Extender for the project or project item objects by knowing the Extender CATID. For example, a project subtype can provide a custom `Project.Extender("<subtype>")` object.|
|`BrowseObjectCATID`|Allows a project subtype to provide an Automation Extender for the `Browse` object by knowing the Extender CATID. For example, a project subtype can add extra properties to the <xref:EnvDTE.Project.Properties%2A> collection.|
|`CfgBrowseObjectCATID`|Allows a project subtype to provide an Automation Extender for the project configuration browse object. For example, a project subtype can add extra properties to the <xref:EnvDTE.Configuration.Properties%2A> collection.|
|`CfgExtObjectCATID`|Allows a project subtype to provide an Automation Extender for the configuration object.|
|`DefaultPlatformName`|Allows a project subtype to determine the platform name for the project's configuration objects.|

 The base project provides a default implementation of the above properties. The base project gets these by calling `QueryInterface` for <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> on the outermost project subtype, thus allowing the project subtype to override the implementation of the properties.

## See also
- [Project Subtypes Design](../../extensibility/internals/project-subtypes-design.md)
