---
title: "How to: Add a Property to a SharePoint Project Item Extension | Microsoft Docs"
titleSuffix: ""
description: Use a SharePoint project item extension to add a property to any SharePoint project item that's already installed in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "project items [SharePoint development in Visual Studio], extending"
  - "SharePoint project items, extending"
  - "SharePoint development in Visual Studio, extending project items"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Add a property to a SharePoint project item extension
  You can use a project item extension to add a property to any SharePoint project item that is already installed in Visual Studio. The property appears in the **Properties** window when the project item is selected in **Solution Explorer**.

 The following steps assume that you have already created a project item extension. For more information, see [How to: Create a SharePoint Project Item Extension](../sharepoint/how-to-create-a-sharepoint-project-item-extension.md).

### To add a property to a project item extension

1. Define a class with a public property that represents the property you are adding to a project item type. If you want to add multiple properties to a project item type, you can define all the properties in the same class or in different classes.

2. In the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension.Initialize%2A> method of your <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension> implementation, handle the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemPropertiesRequested> event of the *projectItemType* parameter.

3. In the event handler for the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemPropertiesRequested> event, add an instance of your properties class to the <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemPropertiesRequestedEventArgs.PropertySources%2A> collection of the event arguments parameter.

## Example
 The following code example demonstrates how to add a property named **Example Property** to the Event Receiver project item.

:::code language="csharp" source="../sharepoint/codesnippet/CSharp/projectitemmenuandproperty/extension/projectitemextensionproperty.cs" id="Snippet8":::
:::code language="vb" source="../sharepoint/codesnippet/VisualBasic/projectitemmenuandproperty/extension/projectitemextensionproperty.vb" id="Snippet8":::

### Understand the code
 To ensure that the same instance of the `CustomProperties` class is used each time the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemPropertiesRequested> event occurs, the code example adds the properties object to the <xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject.Annotations%2A> property of the project item the first time this event occurs. The code retrieves this object whenever this event occurs again. For more information about using the <xref:Microsoft.VisualStudio.SharePoint.IAnnotatedObject.Annotations%2A> property to associate data with project items, see [Associate custom data with SharePoint tools extensions](../sharepoint/associating-custom-data-with-sharepoint-tools-extensions.md).

 To persist changes to the property value, the **set** accessor for `ExampleProperty` saves the new value to the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem.ExtensionData%2A> property of the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem> object that the property is associated with. For more information about using the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItem.ExtensionData%2A> property to persist data with project items, see [Save data in extensions of the SharePoint project system](../sharepoint/saving-data-in-extensions-of-the-sharepoint-project-system.md).

### Specify the behavior of custom properties
 You can define how a custom property appears and behaves in the **Properties** window by applying attributes from the <xref:System.ComponentModel> namespace to the property definition. The following attributes are useful in many scenarios:

- <xref:System.ComponentModel.DisplayNameAttribute>: Specifies the name of the property that appears in the **Properties** window.

- <xref:System.ComponentModel.DescriptionAttribute>: Specifies the description string that appears in the bottom of the **Properties** window when the property is selected.

- <xref:System.ComponentModel.DefaultValueAttribute>: Specifies the default value of the property.

- <xref:System.ComponentModel.TypeConverterAttribute>: Specifies a custom conversion between the string that is displayed in the **Properties** window and a non-string property value.

- <xref:System.ComponentModel.EditorAttribute>: Specifies a custom editor to use to modify the property.

## Compile the code
 These examples require a class library project with references to the following assemblies:

- Microsoft.VisualStudio.SharePoint

- System.ComponentModel.Composition

## Deploy the extension
 To deploy the extension, create a [!include[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension (VSIX) package for the assembly and any other files that you want to distribute with the extension. For more information, see [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).

## See also
- [How to: Create a SharePoint project item extension](../sharepoint/how-to-create-a-sharepoint-project-item-extension.md)
- [How to: Add a shortcut menu item to a SharePoint project item extension](../sharepoint/how-to-add-a-shortcut-menu-item-to-a-sharepoint-project-item-extension.md)
- [Extend SharePoint project items](../sharepoint/extending-sharepoint-project-items.md)
- [Walkthrough: Extend a SharePoint project item type](../sharepoint/walkthrough-extending-a-sharepoint-project-item-type.md)
