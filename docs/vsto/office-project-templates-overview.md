---
title: "Office project templates overview"
description: Explore how the Microsoft Office developer tools in Visual Studio include project templates for creating different types of Office solutions.
ms.date: "02/02/2017"
ms.topic: concept-article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "templates [Office development in Visual Studio], about project templates"
  - "Excel Workbook project template"
  - "Word Template project template"
  - "Excel [Office development in Visual Studio], project templates"
  - "Project [Office development in Visual Studio], project templates"
  - "project templates [Office development in Visual Studio]"
  - "project templates, Word"
  - "InfoPath [Office development in Visual Studio], project templates"
  - "Excel Template project template"
  - "project templates, 2007 Microsoft Office system"
  - "project templates, Excel"
  - "PowerPoint [Office development in Visual Studio], project templates"
  - "Word [Office development in Visual Studio], Word project templates"
  - "Office projects [Office development in Visual Studio], templates"
  - "Excel projects in Visual Studio"
  - "Word Document project template"
  - "Visio [Office development in Visual Studio], project templates"
  - "Word projects in Visual Studio"
  - "Outlook [Office development in Visual Studio], project templates"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Office project templates overview

  The Microsoft Office developer tools in Visual Studio include project templates for creating the following types of Office solutions:

- [Document-level customizations](#DocLevel)

- [VSTO Add-ins](#AppLevel)

  For a detailed comparison of these types of Office solutions, see [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md).

  The Office project templates are available in the **New Project** dialog box, under the **Office** node of the **Visual C#** and **Visual Basic** language nodes. Each template generates a project with the appropriate configuration for the target application, including assembly references and debugging settings.

  Each project provides files and code to get you started on a specific kind of solution. The generated code for each project includes startup and shutdown event handlers. You can add code to these event handlers to initialize your solution when it is loaded and to clean up your solution when it is unloaded. For more information, see [Office projects in the Visual Studio environment](../vsto/office-projects-in-the-visual-studio-environment.md) and [Events in Office projects](../vsto/events-in-office-projects.md).

> [!NOTE]
> The Office development tools are included with certain editions of Visual Studio. For more information, see [Configure a computer to develop Office solutions](../vsto/how-to-configure-a-computer-to-develop-office-solutions.md).

## <a name="DocLevel"></a> Document-level customizations
 The **Office** node in the **New Project** dialog box provides the following project templates to get you started creating document-level customizations for Word and Excel:

- **Word 2013 and 2016 VSTO Document**

- **Word 2013 and 2016 VSTO Template**

- **Excel 2013 and 2016 VSTO Workbook**

- **Excel 2013 and 2016 VSTO Template**

- **Word 2010 VSTO Document**

- **Word 2010 VSTO Template**

- **Excel 2010 VSTO Workbook**

- **Excel 2010 VSTO Template**

  The Word Document and Excel Workbook project templates provide code to get you started creating a solution that is based on a specific document or workbook. In these types of solutions, your code runs only when the associated document is open in Word or Excel.

  The Word Template and Excel Template project templates behave identically to the Word Document and Excel Workbook project templates. However, the Word Template and Excel Template project templates makes it easy for users to create new local document or workbook copies of the customized template in your solution. The features in your solution are available from the new document that the user creates from the template.

> [!NOTE]
> Word templates that reference managed code extensions cannot be used as global VSTO Add-ins. The assembly is not called if the template is loaded from the Startup directory of Word. For more information, see [Limitations of global templates and Excel Add-ins (.xla files)](#Limitations).

 For information about getting started with these project types, see the following topics:

- [Program document-level customizations](../vsto/programming-document-level-customizations.md)

- [Word solutions](../vsto/word-solutions.md)

- [Excel solutions](../vsto/excel-solutions.md)

- [Walkthrough: Create your first document-level customization for Word](../vsto/walkthrough-creating-your-first-document-level-customization-for-word.md)

- [Walkthrough: Create your first document-level customization for Excel](../vsto/walkthrough-creating-your-first-document-level-customization-for-excel.md)

## <a name="AppLevel"></a> VSTO Add-ins
 The **Office/SharePoint** node in the **New Project** dialog box provides the following project templates to get you started creating VSTO Add-ins.

- **Excel 2013 and 2016 VSTO Add-in**

- **InfoPath 2013 VSTO Add-in**

- **Outlook 2013 and 2016 VSTO Add-in**

- **PowerPoint 2013 and 2016 Add-in**

- **Project 2013 and 2016 Add-in**

- **Visio 2013 and 2016 Add-in**

- **Word 2013 and 2016 Add-in**

- **Excel 2010 Add-in**

- **InfoPath 2010 Add-in**

- **Outlook 2010 Add-in**

- **PowerPoint 2010 Add-in**

- **Project 2010 Add-in**

- **Visio 2010 Add-in**

- **Word 2010 Add-in**

  When you create a project that is based on one of these project templates, the code in your solution runs when the associated application is open. Unlike document-level projects, your code is not associated with a single document.

  For more information about getting started with these project types, see the following topics:

- [Get started programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md)

- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)

- [Walkthrough: Create your first VSTO Add-in for Excel](../vsto/walkthrough-creating-your-first-vsto-add-in-for-excel.md)

- [Walkthrough: Create your first VSTO Add-in for Outlook](../vsto/walkthrough-creating-your-first-vsto-add-in-for-outlook.md)

- [Walkthrough: Create your first VSTO Add-in for PowerPoint](../vsto/walkthrough-creating-your-first-vsto-add-in-for-powerpoint.md)

- [Walkthrough: Create your first VSTO Add-in for Project](../vsto/walkthrough-creating-your-first-vsto-add-in-for-project.md)

- [Walkthrough: Create your first VSTO Add-in for Word](../vsto/walkthrough-creating-your-first-vsto-add-in-for-word.md)

## Document vs. template solutions
 When you design a solution around a Word document or Excel workbook, you must decide the best way to make that document available to your users.

 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]

 In some situations, you might want to give a copy of a document to each user. In this case, create your solution by using an Excel or Word document project.

 In other situations you might want to make a template available on a server, so that each user can open the template and save a local copy as a document. In this case, create your solution by using an Excel or Word template project.

## Comparison
 The following table outlines the differences between documents and templates.

|Documents|Templates|
|---------------|---------------|
|Users can open and modify a document, unless it is set to be read-only. Any saved changes are kept in the original.|Users can open a template to create a local copy as a new document. They cannot modify the original unless they are given special permissions.|
|When opened, the document raises the <xref:Microsoft.Office.Tools.Word.Document.Open> event.|When opened, the template raises the <xref:Microsoft.Office.Tools.Word.Document.New> event.|

## <a name="Limitations"></a> Limitations of global templates and Excel Add-ins (.xla Files)
 Documents, workbooks, and templates might not work correctly as global templates or Excel VSTO Add-ins (.xla files).

## Word templates
 If a Microsoft Office Word template has managed code extensions, the project assembly is not called if the template is attached as a global template or loaded from the startup directory of Word. In addition, the document does not recognize the format of a template that is part of an Office solution.

## Excel Add-ins (.xla Files)
 There is no Office project for creating an Excel VSTO Add-in (*.xla* file). It is possible to save a workbook as an .xla file, but it is not a supported operation and is not recommended. If you save a workbook that has managed code extensions as a **Microsoft Office Excel Add-In (\*.xla)** file, you can select it in the **Add-Ins** dialog box to apply to another workbook. In some cases, your code will run in the target workbook after the VSTO Add-in is applied, but such use of the Office solution is not supported.

## Related content
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)
- [Develop Office solutions](../vsto/developing-office-solutions.md)
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Get started programming document-level customizations for Excel](../vsto/getting-started-programming-document-level-customizations-for-excel.md)
- [Get started programming document-level customizations for Word](../vsto/getting-started-programming-document-level-customizations-for-word.md)
- [Get started programming VSTO Add-ins](../vsto/getting-started-programming-vsto-add-ins.md)
