---
title: Extending the Object Model of the Base Project
description: Learn how to extend the automation object model of the base project in Visual Studio by using a project subtype. 
ms.date: 03/22/2018
ms.topic: reference
helpviewer_keywords:
- automation object model, extending
- project subtypes, extending automation object model
- automation object model
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Extend the object model of the base project

A project subtype may extend the automation object model of the base project in the following places:

- Project.Extender("\<ProjectSubtypeName>"): This allows a project subtype to offer an object with custom methods from the <xref:EnvDTE.Project> object. A project subtype can use Automation Extenders to expose the `Project` object. The <xref:EnvDTE80.IInternalExtenderProvider> interface implemented on the main project subtype aggregator should offer its object for the `VSHPROPID_ExtObjectCATID` from <xref:Microsoft.VisualStudio.Shell.Interop.__VSSPROPID2> (corresponding to an `itemid` value of [VSITEMID.Root](<xref:Microsoft.VisualStudio.VSConstants.VSITEMID.Root>)) CATID.

- ProjectItem.Extender("\<ProjectSubtypeName>"): This allows a project subtype to offer an object with custom methods from a particular <xref:EnvDTE.ProjectItem> object within the project. A project subtype can use automation extenders to expose this object. The <xref:EnvDTE80.IInternalExtenderProvider> interface implemented on the main project subtype aggregator needs to offer its object for the `VSHPROPID_ExtObjectCATID` from <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID2> (corresponding to a desired <xref:Microsoft.VisualStudio.VSConstants.VSITEMID>) CATID.

- Project.Properties: This collection exposes the configuration-independent properties of the `Project` object. For more information on `Project` properties, see <xref:EnvDTE.Project.Properties%2A>. A project subtype can use Automation Extenders to add its properties to this collection. The <xref:EnvDTE80.IInternalExtenderProvider> interface implemented on the main project subtype aggregator needs to offer its object for the `VSHPROPID_BrowseObjectCATID` from <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID2> (corresponding to an `itemid` value of [VSITEMID.Root](<xref:Microsoft.VisualStudio.VSConstants.VSITEMID.Root>)) CATID.

- Configuration.Properties: This collection exposes the configuration-dependent properties of the project for a particular configuration (for example, Debug). For more information, see <xref:EnvDTE.Configuration>. A project subtype can use Automation Extenders to add its properties to this collection. The <xref:EnvDTE80.IInternalExtenderProvider> interface implemented on the main project subtype aggregator offers its object for the CATID `VSHPROPID_CfgBrowseObjectCATID` (corresponding to an `itemid` value of [VSITEMID.Root](<xref:Microsoft.VisualStudio.VSConstants.VSITEMID.Root>)). The <xref:Microsoft.VisualStudio.Shell.Interop.IVsCfgBrowseObject> interface is used to distinguish one configuration browse object from another.

## See also

- <xref:Microsoft.VisualStudio.Shell.Interop.__VSFPROPID>
