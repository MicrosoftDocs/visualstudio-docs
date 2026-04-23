---
title: "Get started programming VSTO Add-ins"
description: Use VSTO add-ins to automate Microsoft Office applications, extend features of the application, and customize the application's user interface.
ms.date: "04/28/2021"
ms.topic: get-started
f1_keywords:
  - "VST.ProjectItem.Outlook"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application-level add-ins [Office development in Visual Studio], getting started"
  - "add-ins [Office development in Visual Studio], getting started"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Get started programming VSTO Add-ins

> [!IMPORTANT]
> VSTO relies on the [.NET Framework](/dotnet/framework/get-started/overview). COM add-ins can also be written with the .NET Framework. Office Add-ins cannot be created with [.NET Core and .NET 5+](/dotnet/core/dotnet-five), the latest versions of .NET. This is because .NET Core/.NET 5+ cannot work together with .NET Framework in the same process and may lead to add-in load failures. You can continue to use .NET Framework to write VSTO and COM add-ins for Office. Microsoft will not be updating VSTO or the COM add-in platform to use .NET Core or .NET 5+. You can take advantage of .NET Core and .NET 5+, including ASP.NET Core, to create the server side of [Office Web Add-ins](/office/dev/add-ins/overview/office-add-ins).

  You can use VSTO Add-ins to automate Microsoft Office applications, extend features of the application, and customize the user interface (UI) of the application. For information about how VSTO Add-ins compare to other types of Office solutions you can create by using Visual Studio, see [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md).

 [!INCLUDE[appliesto_allapp](../vsto/includes/appliesto-allapp-md.md)]

## Create VSTO Add-in projects
 Create VSTO Add-in projects by using one of the VSTO Add-in project templates in the **New Project** dialog box. These templates include required assembly references and project files. Visual Studio provides VSTO Add-in project templates for most applications in Office.

 For more information about how to create a VSTO Add-in project, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md). For more information about the project templates, see [Office project templates overview](../vsto/office-project-templates-overview.md).

## Develop VSTO Add-in projects
 When you create a VSTO Add-in project, Visual Studio automatically creates a *ThisAddIn.vb* (in Visual Basic) or *ThisAddIn.cs* (in C#) code file. This file contains the `ThisAddIn` class, which provides the foundation for your VSTO Add-in. You can use members of this class to run code when the VSTO Add-in is loaded or unloaded, to access the object model of the host application, and to extend features of the application. For more information, see [Program VSTO Add-Ins](../vsto/programming-vsto-add-ins.md).

## Automate applications by using the Object models
 The object models of Microsoft Office applications expose many types that you can program against in a VSTO Add-in. You can use these types to automate the application. For example, you can programmatically create and send an e-mail message in Outlook, or you can open a document and add content in Word. For more information about how to access the object model of the host application in code, see [Program VSTO Add-Ins](../vsto/programming-vsto-add-ins.md).

 For more information about the object models of specific Microsoft Office applications, see the following topics:

- [Excel object model overview](../vsto/excel-object-model-overview.md)

- [Word object model overview](../vsto/word-object-model-overview.md)

- [Outlook object model overview](../vsto/outlook-object-model-overview.md)

- [InfoPath solutions](../vsto/infopath-solutions.md)

- [PowerPoint solutions](../vsto/powerpoint-solutions.md)

- [Project solutions](../vsto/project-solutions.md)

- [Visio object model overview](../vsto/visio-object-model-overview.md)

## Customize the user interface of applications
 There are several different ways to customize the UI of the host application by using a VSTO Add-in:

- For Excel and Word, you can add managed controls to documents. For more information, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

- You can customize the Ribbon if the application supports it. For more information, see [Ribbon overview](../vsto/ribbon-overview.md).

- You can create a custom task pane if the application supports it. For more information, see [Custom task panes](../vsto/custom-task-panes.md).

- For Outlook, you can create a custom form region. For more information, see [Create Outlook form regions](../vsto/creating-outlook-form-regions.md).

- For all Microsoft Office applications, you can display Windows Forms in your VSTO Add-in.

  For more information about how to customize the UI of Microsoft Office applications, see [Office UI customization](../vsto/office-ui-customization.md).

## Related content

- [Walkthrough: Create your first VSTO Add-in for Excel](../vsto/walkthrough-creating-your-first-vsto-add-in-for-excel.md)
- [Walkthrough: Create your first VSTO Add-In for Outlook](../vsto/walkthrough-creating-your-first-vsto-add-in-for-outlook.md)
- [Walkthrough: Create your first VSTO Add-in for PowerPoint](../vsto/walkthrough-creating-your-first-vsto-add-in-for-powerpoint.md)
- [Walkthrough: Create your first VSTO Add-in for Project](../vsto/walkthrough-creating-your-first-vsto-add-in-for-project.md)
- [Walkthrough: Create your first VSTO Add-in for Word](../vsto/walkthrough-creating-your-first-vsto-add-in-for-word.md)
- [Common tasks in Office programming](../vsto/common-tasks-in-office-programming.md)
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Get started &#40;Office development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md)
- [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md)
- [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
