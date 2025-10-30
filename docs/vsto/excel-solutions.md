---
title: Automate and extend your Office Excel solutions
description: Use project templates to automate Microsoft Office Excel, extend Excel features, and customize the Excel user interface.
ms.date: "08/14/2019"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application-level add-ins [Office development in Visual Studio], Excel"
  - "Excel [Office development in Visual Studio], application-level add-ins"
  - "Office solutions [Office development in Visual Studio], Excel"
  - "solutions [Office development in Visual Studio], Excel"
  - "add-ins [Office development in Visual Studio], Excel"
  - "Excel [Office development in Visual Studio], about Excel solutions"
  - "Excel [Office development in Visual Studio]"
  - "documents [Office development in Visual Studio], Excel"
  - "Office documents [Office development in Visual Studio, Excel"
  - "projects [Office development in Visual Studio], Excel"
  - "Excel [Office development in Visual Studio], document-level customizations"
  - "user interfaces [Office development in Visual Studio], Excel"
  - "Office development in Visual Studio, Excel solutions"
  - "document-level customizations [Office development in Visual Studio], Excel"
  - "Office projects [Office development in Visual Studio], Excel"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Excel solutions

  Visual Studio provides project templates you can use to create document-level customizations and VSTO Add-ins for Microsoft Office Excel. You can use these solutions to automate Excel, extend Excel features, and customize the Excel user interface (UI). For more information about the differences between document-level customizations and VSTO Add-ins, see [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md).

 [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

[!include[Add-ins note](includes/addinsnote.md)]

 This topic provides the following information:

- [Automate Excel](#automating).

- [Develop document-level customizations for Excel](#doclevel).

- [Develop VSTO Add-ins for Excel](#applevel).

- [Customize the user interface of Excel](#UI).

## <a name="automating"></a> Automate Excel
 The Excel object model exposes many types that you can use to automate Excel. For example, you can programmatically create charts, format worksheets, and set the values of ranges and cells. For more information, see [Excel object model overview](../vsto/excel-object-model-overview.md).

 When developing Excel solutions in Visual Studio, you can also use *host items* and *host controls* in your solutions. These are objects that extend certain commonly used objects in the Excel object model, such as the <xref:Microsoft.Office.Interop.Excel.Worksheet> and <xref:Microsoft.Office.Interop.Excel.Range> objects. The extended objects behave like the Excel objects they are based on, but they add additional events and data binding capabilities to the objects. For more information, see [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md).

## <a name="doclevel"></a> Develop document-level customizations for Excel
 A document-level customization for Microsoft Office Excel consists of an assembly that is associated with a specific workbook. The assembly typically extends the workbook by customizing the UI and by automating Excel. Unlike a VSTO Add-in, which is associated with Excel itself, functionality that you implement in a customization is available only when the associated workbook is open in Excel.

 To create a document-level customization project for Excel, use the Excel workbook or Excel template project templates in the **New Project** dialog box of Visual Studio. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

 For more information about how document-level customizations work, see [Architecture of document-level customizations](../vsto/architecture-of-document-level-customizations.md).

### Excel customization programming model
 When you create a document-level project for Excel, Visual Studio generates several classes that are the foundation of your solution: `ThisWorkbook`, `Sheet1`, `Sheet2`, and `Sheet3`. These classes represent the workbook and worksheets that are associated with your solution, and they provide a starting point for writing your code.

 For more information about these generated classes and other features you can use in a document-level project, see [Program document-level customizations](../vsto/programming-document-level-customizations.md).

## <a name="applevel"></a> Develop VSTO Add-ins for Excel
 A VSTO Add-in for Microsoft Office Excel consists of an assembly that is loaded by Excel. The assembly typically extends Excel by customizing the UI and by automating Excel. Unlike a document-level customization, which is associated with a specific workbook, functionality that you implement in a VSTO Add-in is not restricted to any single workbook.

 To create a VSTO Add-in project for Excel, use the Excel workbook or Excel template project templates in the **New Project** dialog box of Visual Studio. For more information, see [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md).

 For general information about how VSTO Add-ins work, see [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md).

### Excel Add-in programming model
 When you create an Excel VSTO Add-in project, Visual Studio generates a class, called `ThisAddIn`, which is the foundation of your solution. This class provides a starting point for writing your code, and it also exposes the object model of Excel to your VSTO Add-in.

 For more information about the `ThisAddIn` class and other Visual Studio features you can use in a VSTO Add-in, see [Program VSTO Add-Ins](../vsto/programming-vsto-add-ins.md).

## <a name="UI"></a> Customize the user interface of Excel
 There are several different ways to customize the user interface of Excel. Some options are available to all project types, and other options are available only to VSTO Add-ins or document-level customizations.

### Options for all project types
 The following table lists customization options that are available to both document-level customizations and VSTO Add-ins.

|Task|For more information|
|----------|--------------------------|
|Customize the Ribbon.|[Ribbon overview](../vsto/ribbon-overview.md)|
|Add Windows Forms controls or extended Excel controls to a worksheet in the customized workbook for a document-level customization, or in any open workbook for a VSTO Add-in.|[How to: Add Windows forms controls to Office documents](../vsto/how-to-add-windows-forms-controls-to-office-documents.md)<br /><br /> [How to: Add Chart controls to worksheets](../vsto/how-to-add-chart-controls-to-worksheets.md)<br /><br /> [How to: Add ListObject controls to worksheets](../vsto/how-to-add-listobject-controls-to-worksheets.md)<br /><br /> [How to: Add NamedRange controls to worksheets](../vsto/how-to-add-namedrange-controls-to-worksheets.md)|

### Options for document-level customizations
 The following table lists customization options that are available only to document-level customizations.

|Task|For more information|
|----------|--------------------------|
|Add an actions pane to the workbook.|[Actions pane overview](../vsto/actions-pane-overview.md)<br /><br /> [How to: Add an actions pane to Word documents or Excel workbooks](../vsto/how-to-add-an-actions-pane-to-word-documents-or-excel-workbooks.md)|
|Add extended range controls that are mapped to XML nodes to a worksheet.|[How to: Add XMLMappedRange controls to worksheets](../vsto/how-to-add-xmlmappedrange-controls-to-worksheets.md)|

### Options for VSTO Add-ins
 The following table lists customization options that are available only to VSTO Add-ins.

|Task|For more information|
|----------|--------------------------|
|Create a custom task pane.|[Custom task panes](../vsto/custom-task-panes.md)|

### Related topics

| Title | Description |
| - | - |
| [Excel object model overview](../vsto/excel-object-model-overview.md) | Provides an overview of the main types provided by the Excel object model. |
| [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md) | Provides information about extended objects (provided by the Visual Studio Tools for Office runtime) that you can use in Excel solutions. |
| [Globalization and localization of Excel solutions](../vsto/globalization-and-localization-of-excel-solutions.md) | Contains information about special considerations for Excel solutions that will be run on computers that have non-English settings for Windows. |
| [Windows Forms controls on Office documents overview](../vsto/windows-forms-controls-on-office-documents-overview.md) | Describes how you can add Windows Forms controls to Excel worksheets. |
| [Walkthrough: Create your first document-level customization for Excel](../vsto/walkthrough-creating-your-first-document-level-customization-for-excel.md) | Demonstrates how to create a basic document-level customization for Excel. |
| [Walkthrough: Create your first VSTO Add-in for Excel](../vsto/walkthrough-creating-your-first-vsto-add-in-for-excel.md) | Demonstrates how to create a basic VSTO Add-in for Excel. |
| [Walkthrough: Add controls to a worksheet at run time in VSTO Add-in project](../vsto/walkthrough-adding-controls-to-a-worksheet-at-run-time-in-vsto-add-in-project.md) | Demonstrates how to add a Windows Forms button, a <xref:Microsoft.Office.Tools.Excel.NamedRange>, and a <xref:Microsoft.Office.Tools.Excel.ListObject> to a worksheet at run time by using a VSTO Add-in. |
| [Understand co-authoring and Add-ins](./understanding-coauthoring-and-addins.md) | Describes adjustments you might need to make to your solutions to accommodate coauthoring. |
| [Excel 2010 in Office development](/previous-versions/office/developer/office-2010/ee658205(v=office.14)) | Provides links to articles and reference documentation about developing Excel solutions. These are not specific to Office development using Visual Studio. |
