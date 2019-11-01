---
title: "How to: Add a Property to SharePoint Projects | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "projects [SharePoint development in Visual Studio], extending"
  - "SharePoint development in Visual Studio, extending projects"
  - "SharePoint projects, extending"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Add a property to SharePoint projects
  You can use a project extension to add a property to any SharePoint project. The property appears in the **Properties** window when the project is selected in **Solution Explorer**.

 The following steps assume that you have already created a project extension. For more information, see [How to: Create a SharePoint project extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md).

### To add a property to a SharePoint project

1. Define a class with a public property that represents the property you are adding to SharePoint projects. If you want to add multiple properties, you can define all the properties in the same class or in different classes.

2. In the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension.Initialize%2A> method of your <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> implementation, handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectPropertiesRequested> event of the *projectService* parameter.

3. In the event handler for the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectPropertiesRequested> event, add an instance of your properties class to the <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectPropertiesRequestedEventArgs.PropertySources%2A> collection of the event arguments parameter.

## Example
 The following code example demonstrates how to add two properties to SharePoint projects. One property persists its data in the project user option file (the *.csproj.user* file or *.vbproj.user* file). The other property persists its data in the project file (*.csproj* file or *.vbproj* file).

 [!code-vb[SpExt_SPCustomPrjProperty#1](../sharepoint/codesnippet/VisualBasic/customspproperty/customproperty.vb#1)]
 [!code-csharp[SpExt_SPCustomPrjProperty#1](../sharepoint/codesnippet/CSharp/customspproperty/customproperty.cs#1)]

### Understand the code
 To ensure that the same instance of the `CustomProjectProperties` class is used each time the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectEvents.ProjectPropertiesRequested> event occurs, the code example adds the properties object to the <xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject.Annotations%2A> property of the project the first time this event occurs. The code retrieves this object whenever this event occurs again. For more information about using the <xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject.Annotations%2A> property to associate data with projects, see [Associate custom data with SharePoint tools extensions](../sharepoint/associating-custom-data-with-sharepoint-tools-extensions.md).

 To persist changes to the property values, the **set** accessors for the properties use the following APIs:

- `CustomUserFileProperty` uses the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProject.ProjectUserFileData%2A> property to save its value to the project user option file.

- `CustomProjectFileProperty` uses the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetPropertyValue%2A> method to save its value to the project file.

  For more information about persisting data in these files, see [Save data in extensions of the SharePoint project system](../sharepoint/saving-data-in-extensions-of-the-sharepoint-project-system.md).

### Specify the behavior of custom properties
 You can define how a custom property appears and behaves in the **Properties** window by applying attributes from the <xref:System.ComponentModel> namespace to the property definition. The following attributes are useful in many scenarios:

- <xref:System.ComponentModel.DisplayNameAttribute>: Specifies the name of the property that appears in the **Properties** window.

- <xref:System.ComponentModel.DescriptionAttribute>: Specifies the description string that appears in the bottom of the **Properties** window when the property is selected.

- <xref:System.ComponentModel.DefaultValueAttribute>: Specifies the default value of the property.

- <xref:System.ComponentModel.TypeConverterAttribute>: Specifies a custom conversion between the string that is displayed in the **Properties** window and a non-string property value.

- <xref:System.ComponentModel.EditorAttribute>: Specifies a custom editor to use to modify the property.

## Compile the code
 This example requires references to the following assemblies:

- Microsoft.VisualStudio.SharePoint

- Microsoft.VisualStudio.Shell

- Microsoft.VisualStudio.Shell.Interop

- Microsoft.VisualStudio.Shell.Interop.8.0

- System.ComponentModel.Composition

## Deploy the extension
 To deploy the extension, create a [!include[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).

## See also
- [Extend SharePoint projects](../sharepoint/extending-sharepoint-projects.md)
- [How to: Create a SharePoint project extension](../sharepoint/how-to-create-a-sharepoint-project-extension.md)
- [How to: Add a shortcut menu item to SharePoint projects](../sharepoint/how-to-add-a-shortcut-menu-item-to-sharepoint-projects.md)
- [Extend the SharePoint project system](../sharepoint/extending-the-sharepoint-project-system.md)
