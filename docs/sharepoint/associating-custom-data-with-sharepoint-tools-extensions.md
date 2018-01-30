---
title: "Associating Custom Data with SharePoint Tools Extensions | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "projects [SharePoint development in Visual Studio], associating custom data"
  - "project items [SharePoint development in Visual Studio], associating custom data"
  - "SharePoint project items, associating custom data"
  - "SharePoint projects, associating custom data"
  - "SharePoint development in Visual Studio, extensibility features"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Associating Custom Data with SharePoint Tools Extensions
  You can add custom data to certain objects in SharePoint tools extensions. This is useful when you have data in one part of your extension that you want to access later from other code in your extension. Instead of implementing a custom way to store and access data, you can associate the data with an object in your extension and then retrieve the data from the same object later.  
  
 Adding custom data to objects is also useful when you want to preserve data that is relevant to a specific item in Visual Studio. SharePoint tools extensions are loaded just once in Visual Studio, so your extension might work with several different items (such as projects, project items, or **Server Explorer** nodes) at any time. If you have custom data that is relevant only to a specific item, you can add the data to the object that represents that item.  
  
 When you add custom data to objects in SharePoint tools extensions, the data does not persist. The data is available only during the lifespan of the object. After the object is reclaimed by garbage collection, the data is lost.  
  
 In extensions of the SharePoint project system, you can also save string data that persists after an extension is unloaded. For more information, see [Saving Data in Extensions of the SharePoint Project System](../sharepoint/saving-data-in-extensions-of-the-sharepoint-project-system.md).  
  
## Objects that Can Contain Custom Data  
 You can add custom data to any object in the SharePoint tools object model that implements the <xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject> interface. This interface defines just one property, <xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject.Annotations%2A>, which is a collection of custom data objects. The following types implement <xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject>:  
  
-   <xref:Microsoft.VisualStudio.SharePoint.IMappedFolder>  
  
-   <xref:Microsoft.VisualStudio.SharePoint.IMenuItem>  
  
-   <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject>  
  
-   <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectFeature>  
  
-   <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectFeatureResourceFile>  
  
-   <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem>  
  
-   <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemFile>  
  
-   <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemType>  
  
-   <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeDefinition>  
  
-   <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectMember>  
  
-   <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectPackage>  
  
-   <xref:Microsoft.VisualStudio.SharePoint.Deployment.IDeploymentContext>  
  
-   <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNode>  
  
-   <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeType>  
  
-   <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeDefinition>  
  
## Adding and Retrieving Custom Data  
 To add custom data to an object in a SharePoint tools extension, get the <xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject.Annotations%2A> property of the object you want to add the data to, and then use the <xref:Microsoft.VisualStudio.SharePoint.IAnnotationDictionary.Add%2A> method to add the data to the object.  
  
 To retrieve custom data from an object in a SharePoint tools extension, get the <xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject.Annotations%2A> property of the object and then use one of the following methods:  
  
-   <xref:Microsoft.VisualStudio.SharePoint.IAnnotationDictionary.TryGetValue%2A>. This method returns **true** if the data object exists, or **false** if it does not exist. You can use this method to retrieve instances of value types or reference types.  
  
-   <xref:Microsoft.VisualStudio.SharePoint.IAnnotationDictionary.GetValue%2A>. This method returns the data object if it exits, or **null** if it does not exist. You can use this method only to retrieve instances of reference types.  
  
 The following code example determines whether a certain data object is already associated with a project item. If the data object is not already associated with the project item, then the code adds the object to the <xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject.Annotations%2A> property of the project item. To see this example in the context of a larger example, see [How to: Add a Property to a Custom SharePoint Project Item Type](../sharepoint/how-to-add-a-property-to-a-custom-sharepoint-project-item-type.md).  
  
 [!code-vb[SPExtensibility.ProjectItemExtension.MenuAndProperty#13](../sharepoint/codesnippet/VisualBasic/projectitemmenuandproperty/extension/projectitemtypeproperty.vb#13)]
 [!code-csharp[SPExtensibility.ProjectItemExtension.MenuAndProperty#13](../sharepoint/codesnippet/CSharp/projectitemmenuandproperty/extension/projectitemtypeproperty.cs#13)]  
  
## See Also  
 [Programming Concepts and Features for SharePoint Tools Extensions](../sharepoint/programming-concepts-and-features-for-sharepoint-tools-extensions.md)   
 [Walkthrough: Creating a Custom Action Project Item with an Item Template, Part 1](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-1.md)   
 [Walkthrough: Extending Server Explorer to Display Web Parts](../sharepoint/walkthrough-extending-server-explorer-to-display-web-parts.md)   
 [How to: Add a Property to SharePoint Projects](../sharepoint/how-to-add-a-property-to-sharepoint-projects.md)   
 [How to: Add a Property to a Custom SharePoint Project Item Type](../sharepoint/how-to-add-a-property-to-a-custom-sharepoint-project-item-type.md   
  