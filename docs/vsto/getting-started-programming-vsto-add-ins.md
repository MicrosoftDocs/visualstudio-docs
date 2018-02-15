---
title: "Getting Started Programming VSTO Add-ins | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VST.ProjectItem.Outlook"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "application-level add-ins [Office development in Visual Studio], getting started"
  - "add-ins [Office development in Visual Studio], getting started"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Getting Started Programming VSTO Add-ins
  You can use VSTO Add-ins to automate Microsoft Office applications, extend features of the application, and customize the user interface (UI) of the application. For information about how VSTO Add-ins compare to other types of Office solutions you can create by using Visual Studio, see [Office Solutions Development Overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md).  
  
 [!INCLUDE[appliesto_allapp](../vsto/includes/appliesto-allapp-md.md)]  
  
## Creating VSTO Add-in Projects  
 Create VSTO Add-in projects by using one of the VSTO Add-in project templates in the **New Project** dialog box. These templates include required assembly references and project files. Visual Studio provides VSTO Add-in project templates for most applications in Office.  
  
 For more information about how to create a VSTO Add-in project, see [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md). For more information about the project templates, see [Office Project Templates Overview](../vsto/office-project-templates-overview.md).  
  
## Developing VSTO Add-in Projects  
 When you create an VSTO Add-in project, Visual Studio automatically creates a ThisAddIn.vb (in [!INCLUDE[vbprvb](../sharepoint/includes/vbprvb-md.md)]) or ThisAddIn.cs (in C#) code file. This file contains the `ThisAddIn` class, which provides the foundation for your VSTO Add-in. You can use members of this class to run code when the VSTO Add-in is loaded or unloaded, to access the object model of the host application, and to extend features of the application. For more information, see [Programming VSTO Add-Ins](../vsto/programming-vsto-add-ins.md).  
  
## Automating Applications by Using the Object Models  
 The object models of Microsoft Office applications expose many types that you can program against in a VSTO Add-in. You can use these types to automate the application. For example, you can programmatically create and send an e-mail message in Outlook, or you can open a document and add content in Word. For more information about how to access the object model of the host application in code, see [Programming VSTO Add-Ins](../vsto/programming-vsto-add-ins.md).  
  
 For more information about the object models of specific Microsoft Office applications, see the following topics:  
  
-   [Excel Object Model Overview](../vsto/excel-object-model-overview.md)  
  
-   [Word Object Model Overview](../vsto/word-object-model-overview.md)  
  
-   [Outlook Object Model Overview](../vsto/outlook-object-model-overview.md)  
  
-   [InfoPath Solutions](../vsto/infopath-solutions.md)  
  
-   [PowerPoint Solutions](../vsto/powerpoint-solutions.md)  
  
-   [Project Solutions](../vsto/project-solutions.md)  
  
-   [Visio Object Model Overview](../vsto/visio-object-model-overview.md)  
  
## Customizing the User Interface of Applications  
 There are several different ways to customize the UI of the host application by using an VSTO Add-in:  
  
-   For Excel and Word, you can add managed controls to documents. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
-   You can customize the Ribbon if the application supports it. For more information, see [Ribbon Overview](../vsto/ribbon-overview.md).  
  
-   You can create a custom task pane if the application supports it. For more information, see [Custom Task Panes](../vsto/custom-task-panes.md).  
  
-   For Outlook, you can create a custom form region. For more information, see [Creating Outlook Form Regions](../vsto/creating-outlook-form-regions.md).  
  
-   For all Microsoft Office applications, you can display Windows Forms in your VSTO Add-in.  
  
 For more information about how to customize the UI of Microsoft Office applications, see [Office UI Customization](../vsto/office-ui-customization.md).  
  
## Next Steps  
 To learn how to create VSTO Add-ins, see the following walkthroughs:  
  
-   [Walkthrough: Creating Your First VSTO Add-in for Excel](../vsto/walkthrough-creating-your-first-vsto-add-in-for-excel.md)  
  
-   [Walkthrough: Creating Your First VSTO Add-In for Outlook](../vsto/walkthrough-creating-your-first-vsto-add-in-for-outlook.md)  
  
-   [Walkthrough: Creating Your First VSTO Add-in for PowerPoint](../vsto/walkthrough-creating-your-first-vsto-add-in-for-powerpoint.md)  
  
-   [Walkthrough: Creating Your First VSTO Add-in for Project](../vsto/walkthrough-creating-your-first-vsto-add-in-for-project.md)  
  
-   [Walkthrough: Creating Your First VSTO Add-in for Word](../vsto/walkthrough-creating-your-first-vsto-add-in-for-word.md)  
  
 These walkthroughs introduce you to the Office development tools in Visual Studio and the programming model for VSTO Add-ins.  
  
 For a list of topics that walk you through some of the common tasks in Office projects, see [Common Tasks in Office Programming](../vsto/common-tasks-in-office-programming.md).  
  
## See Also  
 [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)   
 [Getting Started &#40;Office Development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md)   
 [Writing Code in Office Solutions](../vsto/writing-code-in-office-solutions.md)   
 [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)   
 [Programming VSTO Add-Ins](../vsto/programming-vsto-add-ins.md)  
  
  