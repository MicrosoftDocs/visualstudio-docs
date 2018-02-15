---
title: "Getting Started Programming Document-Level Customizations for Excel | Microsoft Docs"
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
  - "Excel solutions in Visual Studio"
  - "Excel projects [Office development in Visual Studio], getting started"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Getting Started Programming Document-Level Customizations for Excel
  If you are just getting started creating document-level customizations for Microsoft Office Excel by using Visual Studio, here is what you need to know.  
  
 [!INCLUDE[appliesto_xlalldoc](../vsto/includes/appliesto-xlalldoc-md.md)]  
  
## Understanding How Document-Level Customizations for Excel Work  
 A document-level customization for Excel is based around a single workbook. To start using the customization, the end user opens the workbook or creates the workbook from an Excel template. Events in the workbook, for example typing in cells or clicking buttons and menu items, can call event-handling methods in the assembly. When the workbook is closed, the features provided by the customization are no longer available in Excel, only in the document that contained them.  
  
 For more information, see [Architecture of Document-Level Customizations](../vsto/architecture-of-document-level-customizations.md).  
  
## Creating Document-Level Projects for Excel  
 To create a document-level customization for Excel, use the Excel Workbook or Excel Template project template in the **New Project** dialog box. These templates include required assembly references and project files.  
  
 For more information about how to create a document-level project for Excel, see [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md). For more information about the project templates, see [Office Project Templates Overview](../vsto/office-project-templates-overview.md).  
  
## Programming Excel Workbooks by Using Host Items and Host Controls  
 *Host items* and *host controls* are classes that provide the programming model for document-level customizations created by using Visual Studio.  
  
 Host items provide an entry point for your code, and they can also act as containers for host controls and Windows Forms controls. In document-level projects for Excel, these host items are represented by the `ThisWorkbook`, `Sheet1`, `Sheet2`, and `Sheet3` classes.  
  
 Host controls are based on native Excel objects, such as list objects and ranges. Host controls provide similar functionality to the native Excel objects, but they also have new events, designer support, and data binding capability. They appear as first-class objects in your project code and in IntelliSense, which makes it easier to refer to specific objects directly in your code without having to navigate the Excel object model.  
  
 For more information, see the following topics:  
  
-   [Programming Document-Level Customizations](../vsto/programming-document-level-customizations.md)  
  
-   [Automating Excel by Using Extended Objects](../vsto/automating-excel-by-using-extended-objects.md)  
  
-   [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)  
  
## Customizing the User Interface of Excel  
 Most Microsoft Office solutions modify the user interface (UI) of the Office application to provide some way for users to interact with the solution. There are many ways in which you can modify the UI of Excel by using a document-level customization. For example, you can add controls to the ribbon, or you can display an actions pane. For more information, see [Office UI Customization](../vsto/office-ui-customization.md).  
  
 You can also open the workbook that is associated with your project directly in Visual Studio. When the workbook is open in Visual Studio, you can modify the workbook by using the Excel user interface. You can also use the workbook as a design surface, which enables you to drag controls onto worksheets. For more information, see [Office Projects in the Visual Studio Environment](../vsto/office-projects-in-the-visual-studio-environment.md).  
  
## Using Data Binding  
 The host controls are also in the list of controls that you can drag from the **Data Sources** window. Adding host controls in this way automatically binds them to the data source that you set up using the window. Without writing any code, you can display data from databases, web services, and business objects. For more information, see [Binding Data to Controls in Office Solutions](../vsto/binding-data-to-controls-in-office-solutions.md).  
  
## Next Steps  
 To learn how to create a document-level customization for Excel, see [Walkthrough: Creating Your First Document-Level Customization for Excel](../vsto/walkthrough-creating-your-first-document-level-customization-for-excel.md). This walkthrough introduces you to the Office development tools in Visual Studio and the programming model for Excel document-level customizations.  
  
 For a list of topics that walk you through some of the common tasks in Excel projects, see [Common Tasks in Office Programming](../vsto/common-tasks-in-office-programming.md).  
  
## See Also  
 [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)   
 [Programming Document-Level Customizations](../vsto/programming-document-level-customizations.md)   
 [Excel Solutions](../vsto/excel-solutions.md)   
 [Walkthrough: Creating Your First Document-Level Customization for Excel](../vsto/walkthrough-creating-your-first-document-level-customization-for-excel.md)   
 [Walkthroughs Using Excel](../vsto/walkthroughs-using-excel.md)   
 [Excel Object Model Overview](../vsto/excel-object-model-overview.md)   
 [Writing Code in Office Solutions](../vsto/writing-code-in-office-solutions.md)  
  
  