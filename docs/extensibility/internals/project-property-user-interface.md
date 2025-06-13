---
title: Project Property User Interface
description: Learn how project subtypes can modify the project Property Pages dialog box as supplied by the base project.
ms.date: 03/22/2018
ms.topic: reference
helpviewer_keywords:
- project properties [Visual Studio], user interface
- projects [Visual Studio SDK], properties UI
- project properties UI
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Project Property User Interface

A project subtype can use the items in the project **Property Pages** dialog box as they are supplied by the base project, hide or make read-only controls and whole pages as supplied, or add project subtype-specific pages to the **Property Pages** dialog box.

## Extending the Project Property Dialog Box

A project subtype implements automation extenders and project configuration browse objects. These extenders implement the <xref:EnvDTE.IFilterProperties> interface to make particular properties hidden or read-only. The **Property Pages** dialog box of the base project, implemented by the base project, honors the filtering performed by the Automation Extenders.

The process of extending a **Project Property** dialog box is outlined below:

- The base project retrieves the extenders from the project subtype by implementing the <xref:EnvDTE80.IInternalExtenderProvider> interface. The browse, project automation, and project configuration browse objects of the base project all implement this interface.

- The implementation of <xref:EnvDTE80.IInternalExtenderProvider> for the project browse object and the project automation object delegate to the <xref:EnvDTE80.IInternalExtenderProvider> implementation of the project subtype aggregator (that is, they `QueryInterface` for <xref:EnvDTE80.IInternalExtenderProvider> on the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> project object).

- The base project configuration browse object also implements <xref:EnvDTE80.IInternalExtenderProvider> to directly wire in the Automation Extender from the project subtype configuration object. Its implementation delegates to the <xref:EnvDTE80.IInternalExtenderProvider> interface implemented by the project subtype aggregator.

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsCfgBrowseObject.GetProjectItem%2A>, implemented by the project configuration browse object, returns the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> object.

- <xref:Microsoft.VisualStudio.Shell.Interop.IVsCfgBrowseObject.GetCfg%2A>, also implemented by the project configuration browse object, returns the <xref:Microsoft.VisualStudio.Shell.Interop.IVsCfg> object.

- A project subtype can determine the appropriate CATIDs for the various extendable objects of the base project at run time by retrieving the following <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID2> values:

  - <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID2.VSHPROPID_ExtObjectCATID>

  - <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID2.VSHPROPID_BrowseObjectCATID>

  - <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID2.VSHPROPID_CfgBrowseObjectCATID>

To determine the CATIDs for the project scope, the project subtype retrieves the above properties for [VSITEMID.Root](<xref:Microsoft.VisualStudio.VSConstants.VSITEMID#Microsoft_VisualStudio_VSConstants_VSITEMID_Root>) from the `VSITEMID typedef`. A project subtype may also want to control which **Property Pages** dialog box pages are displayed for the project, both configuration dependent and configuration independent. Some project subtypes may need to remove built-in pages and add project subtype specific pages. In order to enable this, the managed client project calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty%2A> method for the following properties:

- `VSHPROPID_PropertyPagesCLSIDList` — a semicolon-delimited list of CLSIDs of configuration-independent property pages.

- `VSHPROPID_CfgPropertyPagesCLSIDList —` a semicolon-delimited list of CLSIDs of configuration-dependent property pages.

Because the project subtype aggregates the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> object, it can override the definition of these properties to control which **Property Pages** dialog boxes are displayed. The project subtype can retrieve these properties from the inner base project and then add or remove CLSIDs as necessary.

New property pages added by a project subtype are handed a project configuration browse object from the base project implementation. This project configuration browse object supports Automation Extenders. For more information on AutomationExtenders, see [Implementing and Using Automation Extenders](/previous-versions/0y92k2w2(v=vs.140)). The property pages implemented by the project subtype call <xref:EnvDTE.Project.Extender%2A> to retrieve their own project subtype configuration browse object that extends the configuration browse object of the base project.

## See also

- <xref:EnvDTE.IFilterProperties>
- [Property Pages Dialog Box](/previous-versions/visualstudio/visual-studio-2010/as5chysf(v=vs.100))