---
title: "Saving Data in Extensions of the SharePoint Project System | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "SharePoint project items, saving string data"
  - "project items [SharePoint development in Visual Studio], saving string data"
  - "projects [SharePoint development in Visual Studio], saving string data"
  - "SharePoint projects, saving string data"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Saving Data in Extensions of the SharePoint Project System
  When you extend the SharePoint project system, you can save string data that persists after a SharePoint project is closed. The data is typically associated with a particular project item or with the project itself.  
  
 If you have data that does not need to persist, you can add the data to any object in the SharePoint tools object model that implements the <xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject> interface. For more information, see [Associating Custom Data with SharePoint Tools Extensions](../sharepoint/associating-custom-data-with-sharepoint-tools-extensions.md).  
  
## Saving Data That is Associated with a Project Item  
 When you have data that is associated with a particular SharePoint project item, such as the value of a property that you add to a project item, you can save the data to the .spdata file for the project item. To do this, use the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem.ExtensionData%2A> property of an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem> object. Data that you add to this property is saved in the **ExtensionData** element in the .spdata file for the project item. For more information, see [ExtensionData Element](../sharepoint/extensiondata-element.md).  
  
 The following code example demonstrates how to use the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem.ExtensionData%2A> property to save the value of a string property that is defined in a custom SharePoint project item type. To see this example in the context of a larger example, see [How to: Add a Property to a Custom SharePoint Project Item Type](../sharepoint/how-to-add-a-property-to-a-custom-sharepoint-project-item-type.md).  
  
 [!code-vb[SPExtensibility.ProjectItemExtension.MenuAndProperty#14](../sharepoint/codesnippet/VisualBasic/projectitemmenuandproperty/extension/projectitemtypeproperty.vb#14)]
 [!code-csharp[SPExtensibility.ProjectItemExtension.MenuAndProperty#14](../sharepoint/codesnippet/CSharp/projectitemmenuandproperty/extension/projectitemtypeproperty.cs#14)]  
  
## Saving Data That is Associated with a Project  
 When you have project-level data, such as the value of a property that you add to SharePoint projects, you can save the data to the project file (the .csproj file or .vbproj file) or the project user option file (the .csproj.user file or .vbproj.user file). The file you choose to save the data in depends on how you want the data to be used:  
  
-   If you want the data to be available to all developers who open the SharePoint project, save the data to the project file. This file is always checked in to source control databases, so the data in this file is available to other developers who check out the project.  
  
-   If you want the data to be available only to the current developer who has the SharePoint project open in Visual Studio, save the data to the project user option file. This file is not typically checked in to source control databases, so the data in this file is not available to other developers who check out the project.  
  
### Saving Data to the Project File  
 To save data to the project file, convert an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> object to an <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage> object, and then use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetPropertyValue%2A> method. The following code example demonstrates how to use this method to save the value of a project property to the project file. To see this example in the context of a larger sample, see [How to: Add a Property to SharePoint Projects](../sharepoint/how-to-add-a-property-to-sharepoint-projects.md).  
  
 [!code-vb[SpExt_SPCustomPrjProperty#3](../sharepoint/codesnippet/VisualBasic/customspproperty/customproperty.vb#3)]
 [!code-csharp[SpExt_SPCustomPrjProperty#3](../sharepoint/codesnippet/CSharp/customspproperty/customproperty.cs#3)]  
  
 For more information about converting <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> objects to other types in the Visual Studio automation object model or integration object model, see [Converting Between SharePoint Project System Types and Other Visual Studio Project Types](../sharepoint/converting-between-sharepoint-project-system-types-and-other-visual-studio-project-types.md).  
  
### Saving Data to the Project User Option File  
 To save data to the project user option file, use the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject.ProjectUserFileData%2A> property of an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> object. The following code example demonstrates how to use this property to save the value of a project property to the project user option file. To see this example in the context of a larger sample, see [How to: Add a Property to SharePoint Projects](../sharepoint/how-to-add-a-property-to-sharepoint-projects.md).  
  
 [!code-vb[SpExt_SPCustomPrjProperty#2](../sharepoint/codesnippet/VisualBasic/customspproperty/customproperty.vb#2)]
 [!code-csharp[SpExt_SPCustomPrjProperty#2](../sharepoint/codesnippet/CSharp/customspproperty/customproperty.cs#2)]  
  
## See Also  
 [Extending the SharePoint Project System](../sharepoint/extending-the-sharepoint-project-system.md)   
 [Associating Custom Data with SharePoint Tools Extensions](../sharepoint/associating-custom-data-with-sharepoint-tools-extensions.md)   
 [Converting Between SharePoint Project System Types and Other Visual Studio Project Types](../sharepoint/converting-between-sharepoint-project-system-types-and-other-visual-studio-project-types.md)  
  
  