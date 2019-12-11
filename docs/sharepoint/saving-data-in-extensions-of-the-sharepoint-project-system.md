---
title: "Saving Data in Extensions of the SharePoint Project System | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
helpviewer_keywords:
  - "SharePoint project items, saving string data"
  - "project items [SharePoint development in Visual Studio], saving string data"
  - "projects [SharePoint development in Visual Studio], saving string data"
  - "SharePoint projects, saving string data"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Save data in extensions of the SharePoint project system
  When you extend the SharePoint project system, you can save string data that persists after a SharePoint project is closed. The data is typically associated with a particular project item or with the project itself.

 If you have data that does not need to persist, you can add the data to any object in the SharePoint tools object model that implements the <xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject> interface. For more information, see [Associate custom data with SharePoint tools extensions](../sharepoint/associating-custom-data-with-sharepoint-tools-extensions.md).

## Save data that is associated with a project item
 When you have data that is associated with a particular SharePoint project item, such as the value of a property that you add to a project item, you can save the data to the *.spdata* file for the project item. To do this, use the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem.ExtensionData%2A> property of an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem> object. Data that you add to this property is saved in the **ExtensionData** element in the *.spdata* file for the project item. For more information, see [ExtensionData Element](../sharepoint/extensiondata-element.md).

 The following code example demonstrates how to use the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem.ExtensionData%2A> property to save the value of a string property that is defined in a custom SharePoint project item type. To see this example in the context of a larger example, see [How to: Add a property to a custom SharePoint project item type](../sharepoint/how-to-add-a-property-to-a-custom-sharepoint-project-item-type.md).

 [!code-vb[SPExtensibility.ProjectItemExtension.MenuAndProperty#14](../sharepoint/codesnippet/VisualBasic/projectitemmenuandproperty/extension/projectitemtypeproperty.vb#14)]
 [!code-csharp[SPExtensibility.ProjectItemExtension.MenuAndProperty#14](../sharepoint/codesnippet/CSharp/projectitemmenuandproperty/extension/projectitemtypeproperty.cs#14)]

## Save data that is associated with a project
 When you have project-level data, such as the value of a property that you add to SharePoint projects, you can save the data to the project file (the *.csproj* file or *.vbproj* file) or the project user option file (the *.csproj.user* file or *.vbproj.user* file). The file you choose to save the data in depends on how you want the data to be used:

- If you want the data to be available to all developers who open the SharePoint project, save the data to the project file. This file is always checked in to source control databases, so the data in this file is available to other developers who check out the project.

- If you want the data to be available only to the current developer who has the SharePoint project open in Visual Studio, save the data to the project user option file. This file is not typically checked in to source control databases, so the data in this file is not available to other developers who check out the project.

### Save data to the project file
 To save data to the project file, convert an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> object to an <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage> object, and then use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetPropertyValue%2A> method. The following code example demonstrates how to use this method to save the value of a project property to the project file. To see this example in the context of a larger sample, see [How to: Add a property to SharePoint projects](../sharepoint/how-to-add-a-property-to-sharepoint-projects.md).

 [!code-vb[SpExt_SPCustomPrjProperty#3](../sharepoint/codesnippet/VisualBasic/customspproperty/customproperty.vb#3)]
 [!code-csharp[SpExt_SPCustomPrjProperty#3](../sharepoint/codesnippet/CSharp/customspproperty/customproperty.cs#3)]

 For more information about converting <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> objects to other types in the Visual Studio automation object model or integration object model, see [Convert between SharePoint project system types and other Visual Studio project types](../sharepoint/converting-between-sharepoint-project-system-types-and-other-visual-studio-project-types.md).

### Save data to the project user option file
 To save data to the project user option file, use the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject.ProjectUserFileData%2A> property of an <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject> object. The following code example demonstrates how to use this property to save the value of a project property to the project user option file. To see this example in the context of a larger sample, see [How to: Add a property to SharePoint projects](../sharepoint/how-to-add-a-property-to-sharepoint-projects.md).

 [!code-vb[SpExt_SPCustomPrjProperty#2](../sharepoint/codesnippet/VisualBasic/customspproperty/customproperty.vb#2)]
 [!code-csharp[SpExt_SPCustomPrjProperty#2](../sharepoint/codesnippet/CSharp/customspproperty/customproperty.cs#2)]

## See also
- [Extend the SharePoint project system](../sharepoint/extending-the-sharepoint-project-system.md)
- [Associate custom data with SharePoint tools extensions](../sharepoint/associating-custom-data-with-sharepoint-tools-extensions.md)
- [Convert between SharePoint project system types and other Visual Studio project types](../sharepoint/converting-between-sharepoint-project-system-types-and-other-visual-studio-project-types.md)
