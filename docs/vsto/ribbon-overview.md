---
title: Explore how to work with the ribbon
description: Explore how to work with the ribbon, organize related commands to make them easier to find, and configure how commands appear as controls on the ribbon. 
ms.date: "02/02/2017"
ms.topic: concept-article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "customizing the Ribbon, multiple Ribbons"
  - "Ribbon [Office development in Visual Studio], about Ribbon"
  - "toolbars [Office development in Visual Studio], Ribbon"
  - "Ribbon [Office development in Visual Studio]"
  - "Ribbon [Office development in Visual Studio], multiple Ribbons"
  - "toolbars [Office development in Visual Studio]"
  - "custom Ribbon, multiple Ribbons"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Ribbon overview

  The ribbon is a way to organize related commands so that they are easier to find. Commands appear as controls on the ribbon. Controls are organized into *groups* along a horizontal strip at the top edge of an application window. Related groups are organized on tabs.

 Most of the features that were accessed by using menus and toolbars in earlier versions of the Microsoft Office system can now be accessed by using the ribbon. For more information, see the technical article [Developer overview of the user interface for the 2007 Microsoft Office system](/previous-versions/office/developer/office-2007/aa338198(v=office.12)).

 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]

## Customize the Microsoft Office Ribbon
 To customize the ribbon, add one of the following Ribbon items to your Office project:

- **Ribbon (Visual Designer)**

- **Ribbon (XML)**

  For example, to customize the Excel Ribbon, add a Ribbon item to an Excel VSTO Add-in project.

### Ribbon (Visual Designer) item
 The **Ribbon (Visual Designer)** item provides advanced tools that make it easier for you to design and develop a custom ribbon. Use the **Ribbon (Visual Designer)** item to customize the ribbon in the following ways:

- Add custom or built-in tabs to a ribbon.

- Add custom groups to a custom or built-in tab.

  > [!NOTE]
  > A built-in tab or group is one that already exists on the ribbon of a Microsoft Office application. For example, the **Data** tab is a built-in tab in Excel. The **Connections** group is a built-in group on the **Data** tab.

- Add custom controls to a custom group.

- Add custom controls to the Backstage View.

  For more information about how to customize a ribbon by using the **Ribbon (Visual Designer)** item, see [Ribbon designer](../vsto/ribbon-designer.md).

### Ribbon (XML) item
 Use the **Ribbon (XML)** item if you want to customize the ribbon in a way that is not supported by the **Ribbon (Visual Designer)** item. Use the **Ribbon (XML)** item to customize the ribbon in the following ways:

- Add *built-in* groups to a custom tab or built-in tab.

- Add built-in controls to a custom group.

- Add custom code to override the event handlers of built-in controls.

- Customize the Quick Access Toolbar.

- Share a Ribbon customization between VSTO Add-in by using a qualified ID.

  For more information about how to customize the ribbon by using the **Ribbon (XML)** item, see [Ribbon XML](../vsto/ribbon-xml.md).

## Export a ribbon from the Ribbon Designer to Ribbon XML
 If you create a ribbon by using the Ribbon Designer, and then decide that you want to customize the ribbon in ways that the **Ribbon (Visual Designer)** item does not support, you can export the ribbon to XML.

 Visual Studio automatically creates a **Ribbon (XML)** item and populates the Ribbon XML file with elements and attributes for each control on the ribbon.

 Not all of the properties that are in the **Properties** window of the Ribbon Designer are transferred to the Ribbon XML file.  For example, Visual Studio does not export the value of the **Image** or **Text** property. That is because you must create a callback method in the Ribbon code file of the exported project to assign an image or set the text of a control. Visual Studio does not automatically generate callback methods as part of the export process.

 In addition, any unchanged default property values do not appear in the resulting Ribbon XML file.

 For more information about how to export the Ribbon to XML, see [How to: Export a ribbon from the Ribbon Designer to Ribbon XML](../vsto/how-to-export-a-ribbon-from-the-ribbon-designer-to-ribbon-xml.md).

### Update the code
 A new Ribbon code file is added to **Solution Explorer**. This file contains the Ribbon XML class. You must create callback methods in the `Ribbon Callbacks` region of this class to handle user actions, such as clicking a button. Move your code from the event handlers to these callback methods and modify the code to work with the Ribbon extensibility (RibbonX) programming model. For more information, see [Ribbon XML](../vsto/ribbon-xml.md).

 You must also add code to the `ThisAddIn`, `ThisWorkbook`, or `ThisDocument` class that overrides the `CreateRibbonExtensibilityObject` method and returns the Ribbon XML class to the Office application.

 For more information, see [Ribbon XML](../vsto/ribbon-xml.md).

## Add multiple Ribbon items to a project
 You can add more than one Ribbon item to a single project. This is useful if you want to perform either of the following two tasks:

- Create ribbons for Outlook *Inspectors*. For more information, see [Customize a ribbon for Outlook](../vsto/customizing-a-ribbon-for-outlook.md).

    > [!NOTE]
    > An Inspector is a window that opens when users perform certain tasks, such as creating an e-mail message.

- Select which ribbon to display at run time.

### Select which ribbons to display at run time
 Because a project can contain more than one ribbon, you can select which ribbon to display at run time.

 To select a ribbon to display at run time, override the `CreateRibbonExtensibilityObject` method in the `ThisAddin`, `ThisWorkbook`, or `ThisDocument` class of your project and return the ribbon that you want to display. The following example checks the value of a field named `myCondition` and returns the appropriate ribbon.

> [!NOTE]
> The syntax used in this example returns a ribbon that was created by using the **Ribbon (Visual Designer)** item. The syntax for returning a ribbon that is created by using a **Ribbon (XML)** item is slightly different. For more information about returning a **Ribbon (XML)** item, see [Ribbon XML](../vsto/ribbon-xml.md).

 Add the following code:

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_Ribbon_choose_Ribbon_4/ThisWorkbook.cs" id="Snippet1":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/trin_Ribbon_choose_Ribbon_4/ThisWorkbook.vb" id="Snippet1":::
 ---

### Related topics

|Title|Description|
|-----------|-----------------|
|[How to: Get started customizing the ribbon](../vsto/how-to-get-started-customizing-the-ribbon.md)|Shows you how to customize the ribbon of a Microsoft Office application, add a **Ribbon (Visual Designer)** or **Ribbon (XML)** item to an Office project.|
|[Ribbon designer](../vsto/ribbon-designer.md)|Describes how you can use the Ribbon Designer to add custom tabs, groups, and controls to the ribbon of a Microsoft Office application.|
|[Walkthrough: Create a custom tab by using the Ribbon Designer](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md)|Shows you how to create a custom Ribbon tab by using the Ribbon Designer. You can use the Ribbon Designer to add and position controls on the custom tab.|
|[Ribbon object model overview](../vsto/ribbon-object-model-overview.md)|Provides an overview of the strongly typed object model that you can use to get and set the properties of Ribbon controls at run time.|
|[Walkthrough: Update the controls on a ribbon at run time](../vsto/walkthrough-updating-the-controls-on-a-ribbon-at-run-time.md)|Demonstrates how to use the Ribbon object model to update the controls on a ribbon after the ribbon is loaded into the Office application.|
|[Customize a ribbon for Outlook](../vsto/customizing-a-ribbon-for-outlook.md)|Provides guidance for customizing the ribbon in Microsoft Office Outlook.|
|[Customize a ribbon for InfoPath](../vsto/customizing-a-ribbon-for-infopath.md)|Provides guidance for customizing the ribbon in Microsoft Office InfoPath.|
|[Access the ribbon at run time](../vsto/accessing-the-ribbon-at-run-time.md)|Shows how to show, hide, and modify the ribbon, and enable users to run the code from controls in a custom task pane, actions pane, or Outlook form region.|
|[How to: Change the position of a tab on the ribbon](../vsto/how-to-change-the-position-of-a-tab-on-the-ribbon.md)|Shows how to change the order of tabs on a ribbon.|
|[How to: Customize a built-in tab](../vsto/how-to-customize-a-built-in-tab.md)|Shows how to add groups and controls to a built-in tab.|
|[How to: Add controls to the Backstage View](../vsto/how-to-add-controls-to-the-backstage-view.md)|Shows how to add controls to the menu that opens when you click the **File**.|
|[How to: Add a dialog box launcher to a Ribbon group](../vsto/how-to-add-a-dialog-box-launcher-to-a-ribbon-group.md)|Shows to add a dialog box launcher to any group on a ribbon.|
|[How to: Export a ribbon from the Ribbon Designer to Ribbon XML](../vsto/how-to-export-a-ribbon-from-the-ribbon-designer-to-ribbon-xml.md)|Shows how to customize the ribbon in advanced ways by exporting the ribbon from the designer to Ribbon XML.|
|[Ribbon XML](../vsto/ribbon-xml.md)|Explains how you can customize a ribbon by using Ribbon XML.|
|[Walkthrough: Create a custom tab by using the Ribbon Designer](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md)|Demonstrates how to create a custom Ribbon tab by using the **Ribbon (XML)** item.|
