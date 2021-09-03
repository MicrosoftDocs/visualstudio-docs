---
title: "Convert: SharePoint project system types to/from other types"
titleSuffix: ""
description: Convert between SharePoint project system types and other Visual Studio project types. See a list that details the types that can be converted.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint project service"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Convert between SharePoint project system types and other Visual Studio project types
  In some cases you might have an object in the SharePoint project system and you want to use features of a corresponding object in the Visual Studio automation object model or integration object model, or vice versa. In these cases, you can use the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.Convert%2A> method of the SharePoint project service to convert the object to a different object model.

 For example, you might have an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> object, but you want to use methods that are only available on an <xref:EnvDTE.Project> or <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject> object. In this case, you can use the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.Convert%2A> method to convert the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> to an <xref:EnvDTE.Project> or <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject>.

 For more information about the Visual Studio automation object model and the Visual Studio integration object model, see [Overview of the programming model of SharePoint tools extensions](../sharepoint/overview-of-the-programming-model-of-sharepoint-tools-extensions.md).

## Types of conversions
 The following table lists the types that this method can convert between the SharePoint project system and the other Visual Studio object models.

|SharePoint project system type|Corresponding types in the automation and integration object models|
|------------------------------------|-------------------------------------------------------------------------|
|<xref:Microsoft.VisualStudio.SharePoint.ISharePointProject>|<xref:EnvDTE.Project><br /><br /> or<br /><br /> Any interface in the Visual Studio integration object model that is implemented by the underlying COM object for the project. These interfaces include <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy>, <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject> (or a derived interface), and <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage>. For a list of the main interfaces that are implemented by projects, see [Project Model Core Components](../extensibility/internals/project-model-core-components.md).|
|<xref:Microsoft.VisualStudio.SharePoint.IMappedFolder><br /><br /> <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem><br /><br /> <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemFile><br /><br /> <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectFeature><br /><br /> <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectFeatureResourceFile><br /><br /> <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectPackage>|<xref:EnvDTE.ProjectItem><br /><br /> or<br /><br /> A<xref:System.UInt32> value (also called a VSITEMID) that identifies the project member in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> that contains it. This value can be passed to the *itemid* parameter of some <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> methods.|

## Example
 The following code example demonstrates how to use the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService.Convert%2A> method to convert an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> object to an <xref:EnvDTE.Project>.

:::code language="csharp" source="../sharepoint/codesnippet/CSharp/spprojectserviceaddin/connect.cs" id="Snippet2":::
:::code language="vb" source="../sharepoint/codesnippet/VisualBasic/spprojectserviceaddin/connect.vb" id="Snippet2":::

 This example requires:

- An extension of the SharePoint project system that has a reference to the *EnvDTE.dll* assembly. For more information, see [Extend the SharePoint project system](../sharepoint/extending-the-sharepoint-project-system.md).

- Code that registers the `projectService_ProjectAdded` method to handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectAdded> event of an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectService> object. For an example, see [How to: Create a SharePoint project extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md).

## See also

- [Use the SharePoint project service](../sharepoint/using-the-sharepoint-project-service.md)
- [How to: Retrieve the SharePoint project service](../sharepoint/how-to-retrieve-the-sharepoint-project-service.md)
- [Overview of the programming model of SharePoint tools extensions](../sharepoint/overview-of-the-programming-model-of-sharepoint-tools-extensions.md)
