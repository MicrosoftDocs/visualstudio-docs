---
title: Automate, extend, and customize Microsoft Word
description: Use Visual Studio solutions to automate Microsoft Office Word, extend Word features, and customize the Word user interface (UI).
ms.date: "08/14/2019"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "solutions [Office development in Visual Studio], Word"
  - "Office projects [Office development in Visual Studio], Word"
  - "application-level add-ins [Office development in Visual Studio], Word"
  - "Word [Office development in Visual Studio]"
  - "projects [Office development in Visual Studio], Word"
  - "Word [Office development in Visual Studio], about Word solutions"
  - "Office solutions [Office development in Visual Studio], Word"
  - "Word [Office development in Visual Studio], application-level add-ins"
  - "documents [Office development in Visual Studio], Word"
  - "Office development in Visual Studio, Word solutions"
  - "add-ins [Office development in Visual Studio], Word"
  - "Word [Office development in Visual Studio], document-level customizations"
  - "user interfaces [Office development in Visual Studio], Word"
  - "Office documents [Office development in Visual Studio, Word"
  - "document-level customizations [Office development in Visual Studio], Word"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Word solutions

  Visual Studio provides project templates you can use to create document-level customizations and VSTO Add-ins for Microsoft Office Word. You can use these solutions to automate Word, extend Word features, and customize the Word user interface (UI). For more information about the differences between document-level customizations and VSTO Add-ins, see [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md).

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

[!include[Add-ins note](includes/addinsnote.md)]

 This topic provides the following information:

- [Automate Word](#automating).

- [Develop document-level customizations for Word](#doclevel).

- [Develop VSTO Add-ins for Word](#applevel).

- [Customize the user interface of Word](#UI).

## <a name="automating"></a> Automate Word
 The Word object model exposes many types that you can use to automate Word. For example, you can programmatically create tables, format documents, and set the text in ranges and paragraphs. For more information, see [Word object model overview](../vsto/word-object-model-overview.md).

 When developing Word solutions in Visual Studio, you can also use *host items* and *host controls* in your solutions. These are objects that extend certain commonly used objects in the Word object model, such as the <xref:Microsoft.Office.Interop.Word.Document> and <xref:Microsoft.Office.Interop.Word.ContentControl> objects. The extended objects behave like the Word objects they are based on, but they add additional events and data binding capabilities to the objects. For more information, see [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md).

## <a name="doclevel"></a> Develop document-level customizations for Word
 A document-level customization for Microsoft Office Word consists of an assembly that is associated with a specific document. The assembly typically extends the document by customizing the UI and by automating Word. Unlike a VSTO Add-in, which is associated with Word itself, functionality that you implement in a customization is available only when the associated document is open in Word.

 To create a document-level customization project for Word, use the Word Document or Word Template project templates in the **New Project** dialog box of Visual Studio. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

 For more information about how document-level customizations work, [Architecture of document-level customizations](../vsto/architecture-of-document-level-customizations.md).

### Word customization programming model
 When you create a document-level project for Word, Visual Studio generates a class, called `ThisDocument`, which is the foundation of your solution. This class represents the document that is associated with your solution, and it provides a starting point for writing your code.

 For more information about the `ThisDocument` class and other features you can use in a document-level project, see [Program document-level customizations](../vsto/programming-document-level-customizations.md).

## <a name="applevel"></a> Develop VSTO Add-ins for Word
 A VSTO Add-in for Microsoft Office Word consists of an assembly that is loaded by Word. The assembly typically extends Word by customizing the UI and by automating Word. Unlike a document-level customization, which is associated with a specific document, functionality that you implement in a VSTO Add-in is not restricted to any single document.

 To create a VSTO Add-in project for Word, use the Word Add-in project templates in the **New Project** dialog box of Visual Studio. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

 For general information about how VSTO Add-ins work, see [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md).

### Word Add-in programming model
 When you create a Word VSTO Add-in project, Visual Studio generates a class, called `ThisAddIn`, which is the foundation of your solution. This class provides a starting point for writing your code, and it also exposes the object model of Word to your VSTO Add-in.

 For more information about the `ThisAddIn` class and other features you can use in a VSTO Add-in, see [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md).

## <a name="UI"></a> Customize the user interface of Word
 There are several different ways to customize the user interface of Word. Some options are available to all project types, and other options are available only to VSTO Add-ins or document-level customizations.

### Options for all project types
 The following table lists customization options that are available to both document-level customizations and VSTO Add-ins.

|Task|For more information|
|----------|--------------------------|
|Customize the Ribbon.|[Ribbon overview](../vsto/ribbon-overview.md)|
|Add Windows Forms controls or extended Word controls to the customized document (for a document-level customization) or to any open document (for a VSTO Add-in).|[How to: Add Windows Forms controls to Office documents](../vsto/how-to-add-windows-forms-controls-to-office-documents.md)<br /><br /> [How to: Add content controls to Word documents](../vsto/how-to-add-content-controls-to-word-documents.md)<br /><br /> [How to: Add bookmark controls to Word documents](../vsto/how-to-add-bookmark-controls-to-word-documents.md)|

### Options for document-level customizations
 The following table lists customization options that are available only to document-level customizations.

|Task|For more information|
|----------|--------------------------|
|Add an actions pane to the document.|[Actions pane overview](../vsto/actions-pane-overview.md)<br /><br /> [How to: Add an actions pane to Word documents or Excel workbooks](../vsto/how-to-add-an-actions-pane-to-word-documents-or-excel-workbooks.md)|
|Add extended XMLNode and XMLNodes controls to the document surface.|[How to: Add XMLNode controls to Word documents](../vsto/how-to-add-xmlnode-controls-to-word-documents.md)<br /><br /> [How to: Add XMLNodes controls to Word documents](../vsto/how-to-add-xmlnodes-controls-to-word-documents.md)|

### Options for VSTO Add-ins
 The following table lists customization options that are available only to VSTO Add-ins.

|Task|For more information|
|----------|--------------------------|
|Create a custom task pane.|[Custom task panes](../vsto/custom-task-panes.md)|

### Related topics

|Title|Description|
|-----------|-----------------|
|[Word object model overview](../vsto/word-object-model-overview.md)|Provides an overview of the main types provided by the Word object model.|
|[Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md)|Provides information about extended objects (provided by the Visual Studio Tools for Office runtime) that you can use in Word solutions.|
|[Windows Forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md)|Describes how you can add Windows Forms controls to Word documents.|
|[Walkthrough: Create your first document-level customization for Word](../vsto/walkthrough-creating-your-first-document-level-customization-for-word.md)|Demonstrates how to create a basic document-level customization for Word.|
|[Walkthrough: Create your first VSTO Add-in for Word](../vsto/walkthrough-creating-your-first-vsto-add-in-for-word.md)|Demonstrates how to create a basic VSTO Add-in for Word.|
|[Walkthrough: Add controls to a document at run time in a VSTO Add-in](../vsto/walkthrough-adding-controls-to-a-document-at-run-time-in-a-vsto-add-in.md)|Demonstrates how to add a Windows Forms button and a <xref:Microsoft.Office.Tools.Word.RichTextContentControl> to a document at run time by using a VSTO Add-in.|
|[Word 2010 in Office development](/previous-versions/office/developer/office-2010/ff601860(v=office.14))|Provides links to articles and reference documentation about developing Word solutions (not specific to Office development using Visual Studio).|
