---
title: "Ribbon Overview | Microsoft Docs"
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
  - "customizing the Ribbon, multiple Ribbons"
  - "Ribbon [Office development in Visual Studio], about Ribbon"
  - "toolbars [Office development in Visual Studio], Ribbon"
  - "Ribbon [Office development in Visual Studio]"
  - "Ribbon [Office development in Visual Studio], multiple Ribbons"
  - "toolbars [Office development in Visual Studio]"
  - "custom Ribbon, multiple Ribbons"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Ribbon Overview
  The Ribbon is a way to organize related commands so that they are easier to find. Commands appear as controls on the Ribbon. Controls are organized into *groups* along a horizontal strip at the top edge of an application window. Related groups are organized on tabs.  
  
 Most of the features that were accessed by using menus and toolbars in earlier versions of the Microsoft Office system can now be accessed by using the Ribbon. For more information, see the technical article [Developer Overview of the User Interface for the 2007 Microsoft Office System](http://go.microsoft.com/fwlink/?LinkID=70860).  
  
 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]  
  
## Customizing the Microsoft Office Ribbon  
 To customize the Ribbon, add one of the following Ribbon items to your Office project:  
  
-   **Ribbon (Visual Designer)**  
  
-   **Ribbon (XML)**  
  
 For example, to customize the Excel Ribbon, add a Ribbon item to an Excel VSTO Add-in project.  
  
### Ribbon (Visual Designer) Item  
 The **Ribbon (Visual Designer)** item provides advanced tools that make it easier for you to design and develop a custom Ribbon. Use the **Ribbon (Visual Designer)** item to customize the Ribbon in the following ways:  
  
-   Add custom or built-in tabs to a Ribbon.  
  
-   Add custom groups to a custom or built-in tab.  
  
    > [!NOTE]  
    >  A built-in tab or group is one that already exists on the Ribbon of a Microsoft Office application. For example, the **Data** tab is a built-in tab in Excel. The **Connections** group is a built-in group on the **Data** tab.  
  
-   Add custom controls to a custom group.  
  
-   Add custom controls to the Backstage View.  
  
 For more information about how to customize a Ribbon by using the **Ribbon (Visual Designer)** item, see [Ribbon Designer](../vsto/ribbon-designer.md).  
  
### Ribbon (XML) Item  
 Use the **Ribbon (XML)** item if you want to customize the Ribbon in a way that is not supported by the **Ribbon (Visual Designer)** item. Use the **Ribbon (XML)** item to customize the Ribbon in the following ways:  
  
-   Add *built-in* groups to a custom tab or built-in tab.  
  
-   Add built-in controls to a custom group.  
  
-   Add custom code to override the event handlers of built-in controls.  
  
-   Customize the Quick Access Toolbar.  
  
-   Share a Ribbon customization between VSTO Add-in by using a qualified ID.  
  
 For more information about how to customize the Ribbon by using the **Ribbon (XML)** item, see [Ribbon XML](../vsto/ribbon-xml.md).  
  
## Exporting a Ribbon from the Ribbon Designer to Ribbon XML  
 If you create a Ribbon by using the Ribbon Designer, and then decide that you want to customize the Ribbon in ways that the **Ribbon (Visual Designer)** item does not support, you can export the Ribbon to XML.  
  
 Visual Studio automatically creates a **Ribbon (XML)** item and populates the Ribbon XML file with elements and attributes for each control on the Ribbon.  
  
 Not all of the properties that are in the **Properties** window of the Ribbon designer are transferred to the Ribbon XML file.  For example, Visual Studio does not export the value of the **Image** or **Text** property. That is because you must create a callback method in the Ribbon code file of the exported project to assign an image or set the text of a control. Visual Studio does not automatically generate callback methods as part of the export process.  
  
 In addition, any unchanged default property values do not appear in the resulting Ribbon XML file.  
  
 For more information about how to export the Ribbon to XML, see [How to: Export a Ribbon from the Ribbon Designer to Ribbon XML](../vsto/how-to-export-a-ribbon-from-the-ribbon-designer-to-ribbon-xml.md).  
  
### Updating the Code  
 A new Ribbon code file is added to **Solution Explorer**. This file contains the Ribbon XML class. You must create callback methods in the `Ribbon Callbacks` region of this class to handle user actions, such as clicking a button. Move your code from the event handlers to these callback methods and modify the code to work with the Ribbon extensibility (RibbonX) programming model. For more information, see [Ribbon XML](../vsto/ribbon-xml.md).  
  
 You must also add code to the `ThisAddIn`, `ThisWorkbook`, or `ThisDocument` class that overrides the CreateRibbonExtensibilityObject method and returns the Ribbon XML class to the Office application.  
  
 For more information, see [Ribbon XML](../vsto/ribbon-xml.md).  
  
## Adding Multiple Ribbon Items to a Project  
 You can add more than one Ribbon item to a single project. This is useful if you want to perform either of the following two tasks:  
  
-   Create Ribbons for Outlook *Inspectors*. For more information, see [Customizing a Ribbon for Outlook](../vsto/customizing-a-ribbon-for-outlook.md).  
  
    > [!NOTE]  
    >  An Inspector is a window that opens when users perform certain tasks, such as creating an e-mail message.  
  
-   Select which Ribbon to display at run time.  
  
### Selecting Which Ribbons to Display at Run Time  
 Because a project can contain more than one Ribbon, you can select which Ribbon to display at run time.  
  
 To select a Ribbon to display at run time, override the CreateRibbonExtensibilityObject method in the `ThisAddin`, `ThisWorkbook`, or `ThisDocument` class of your project and return the Ribbon that you want to display. The following example checks the value of a field named `myCondition` and returns the appropriate Ribbon.  
  
> [!NOTE]  
>  The syntax used in this example returns a Ribbon that was created by using the **Ribbon (Visual Designer)** item. The syntax for returning a Ribbon that is created by using a **Ribbon (XML)** item is slightly different. For more information about returning a **Ribbon (XML)** item, see [Ribbon XML](../vsto/ribbon-xml.md).  
  
 Add the following code:  
  
 [!code-vb[Trin_Ribbon_Choose_Ribbon#1](../vsto/codesnippet/VisualBasic/trin_ribbon_choose_ribbon_4/ThisWorkbook.vb#1)]
 [!code-csharp[Trin_Ribbon_Choose_Ribbon#1](../vsto/codesnippet/CSharp/trin_ribbon_choose_ribbon_4/ThisWorkbook.cs#1)]  
  
### Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[How to: Get Started Customizing the Ribbon](../vsto/how-to-get-started-customizing-the-ribbon.md)|Shows you how to customize the Ribbon of a Microsoft Office application, add a **Ribbon (Visual Designer)** or **Ribbon (XML)** item to an Office project.|  
|[Ribbon Designer](../vsto/ribbon-designer.md)|Describes how you can use the Ribbon Designer to add custom tabs, groups, and controls to the Ribbon of a Microsoft Office application.|  
|[Walkthrough: Creating a Custom Tab by Using the Ribbon Designer](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md)|Shows you how to create a custom Ribbon tab by using the Ribbon Designer. You can use the Ribbon Designer to add and position controls on the custom tab.|  
|[Ribbon Object Model Overview](../vsto/ribbon-object-model-overview.md)|Provides an overview of the strongly typed object model that you can use to get and set the properties of Ribbon controls at run time.|  
|[Walkthrough: Updating the Controls on a Ribbon at Run Time](../vsto/walkthrough-updating-the-controls-on-a-ribbon-at-run-time.md)|Demonstrates how to use the Ribbon object model to update the controls on a Ribbon after the Ribbon is loaded into the Office application.|  
|[Customizing a Ribbon for Outlook](../vsto/customizing-a-ribbon-for-outlook.md)|Provides guidance for customizing the Ribbon in Microsoft Office Outlook.|  
|[Customizing a Ribbon for InfoPath](../vsto/customizing-a-ribbon-for-infopath.md)|Provides guidance for customizing the Ribbon in Microsoft Office InfoPath.|  
|[Accessing the Ribbon at Run Time](../vsto/accessing-the-ribbon-at-run-time.md)|Shows how to show, hide, and modify the Ribbon, and enable users to run the code from controls in a custom task pane, actions pane, or Outlook form region.|  
|[How to: Change the Position of a Tab on the Ribbon](../vsto/how-to-change-the-position-of-a-tab-on-the-ribbon.md)|Shows how to change the order of tabs on a Ribbon.|  
|[How to: Customize a Built-in Tab](../vsto/how-to-customize-a-built-in-tab.md)|Shows how to add groups and controls to a built-in tab.|  
|[How to: Add Controls to the Backstage View](../vsto/how-to-add-controls-to-the-backstage-view.md)|Shows how to add controls to the menu that opens when you click the **File**.|  
|[How to: Add a Dialog Box Launcher to a Ribbon Group](../vsto/how-to-add-a-dialog-box-launcher-to-a-ribbon-group.md)|Shows to add a dialog box launcher to any group on a Ribbon.|  
|[How to: Export a Ribbon from the Ribbon Designer to Ribbon XML](../vsto/how-to-export-a-ribbon-from-the-ribbon-designer-to-ribbon-xml.md)|Shows how to customize the Ribbon in advanced ways by exporting the Ribbon from the designer to Ribbon XML.|  
|[Ribbon XML](../vsto/ribbon-xml.md)|Explains how you can customize a Ribbon by using Ribbon XML.|  
|[Walkthrough: Creating a Custom Tab by Using the Ribbon Designer](../vsto/walkthrough-creating-a-custom-tab-by-using-the-ribbon-designer.md)|Demonstrates how to create a custom Ribbon tab by using the **Ribbon (XML)** item.|  
  
  