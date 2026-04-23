---
title: Start programming Word doc-level customizations (Visual Studio)
description: Get started creating customizations for Microsoft Office Word with features to specific documents by using Visual Studio.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: get-started
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Word solutions in Visual Studio"
  - "Word projects [Office development in Visual Studio], getting started"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Get started programming document-level customizations for Word

  If you are just getting started creating document-level customizations for Microsoft Office Word by using Visual Studio, here is what you need to know.

 [!INCLUDE[appliesto_wdalldoc](../vsto/includes/appliesto-wdalldoc-md.md)]

## Understand how document-level customizations for Word work
 Each Word customization you create is based around a single document. To start using the customization, the end user opens the document or creates the document from a Word template. Events in the document, for example moving the cursor into specific areas or clicking buttons and menu items, can call event-handling methods in the assembly. When the document is closed, the features provided by the customization are no longer available in Word.

 For more information, see [Architecture of document-level customizations](../vsto/architecture-of-document-level-customizations.md).

## Create document-level projects for Word
 To create a document-level customization for Word, use the Word Document or Word Template project template in the **New Project** dialog box. These templates include required assembly references and project files.

 For more information about how to create a document-level project for Word, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md). For more information about the project templates, see [Office project templates overview](../vsto/office-project-templates-overview.md).

## Program Word documents by using host items host controls
 *Host items* and *host controls* are classes that provide the programming model for document-level customizations.

 Host items provide an entry point for your code, and they can also act as containers for host controls and Windows Forms controls. In document-level projects for Word, the host item is represented by the `ThisDocument` class.

 Host controls are based on native Word objects, such as content controls, bookmarks, and XML nodes. Host controls provide similar functionality to the native Word objects, but they also have new events, designer support, and data-binding capability. They appear as first-class objects in your project code and in IntelliSense, which makes it easier to refer to specific objects directly in your code without having to navigate the Word object model.

 For more information, see the following topics:

- [Program document-level customizations](../vsto/programming-document-level-customizations.md)

- [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md)

- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)

## Customize the user interface of Word
 Most Microsoft Office solutions modify the user interface (UI) of the Office application to provide some way for users to interact with the solution. There are many ways in which you can modify the UI of Word by using a document-level customization. For example, you can add controls to the ribbon, and you can display an actions pane. For more information, see [Office UI customization](../vsto/office-ui-customization.md).

 You can also open the document that is associated with your project directly in Visual Studio. When the document is open in Visual Studio, you can modify the document by using the Word user interface. You can also use the document as a design surface, which enables you to drag controls onto it. For more information, see [Office projects in the Visual Studio environment](../vsto/office-projects-in-the-visual-studio-environment.md).

## Bind controls to data
 The content controls and the <xref:Microsoft.Office.Tools.Word.Bookmark> control are in the list of controls that you can drag from the **Data Sources** window. Adding content controls and bookmarks in this way automatically binds them to the data source that you set up by using the window. Without writing any code, you can display data from databases, services, and business objects. For more information, see [Bind data to controls in Office solutions](../vsto/binding-data-to-controls-in-office-solutions.md).

## Next steps
 To learn how to create a document-level customization for Word, see [Walkthrough: Create your first document-level customization for Word](../vsto/walkthrough-creating-your-first-document-level-customization-for-word.md). This walkthrough introduces you to the Office development tools in Visual Studio and the programming model for Word document-level customizations.

 For a list of topics that walk you through some of the common tasks in Word projects, see [Common tasks in Office programming](../vsto/common-tasks-in-office-programming.md).

## See also
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Program document-level customizations](../vsto/programming-document-level-customizations.md)
- [Word solutions](../vsto/word-solutions.md)
- [Walkthrough: Create your first document-level customization for Word](../vsto/walkthrough-creating-your-first-document-level-customization-for-word.md)
- [Walkthroughs using Word](../vsto/walkthroughs-using-word.md)
- [Word object model overview](../vsto/word-object-model-overview.md)
- [Write code in Office solutions](../vsto/writing-code-in-office-solutions.md)
