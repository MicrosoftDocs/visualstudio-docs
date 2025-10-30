---
title: "Excel Object model overview"
description: Interact with the objects provided by the Excel object model and develop projects and solutions that use Microsoft Office Excel.
ms.date: "08/14/2019"
ms.topic: concept-article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Worksheet object"
  - "Range object"
  - "object models [Office development in Visual Studio], Excel"
  - "object models [Office development in Visual Studio], Office"
  - "Workbook class"
  - "objects [Office development in Visual Studio], Office object models"
  - "Excel object model"
  - "Office object models"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Excel object model overview

  To develop solutions that use Microsoft Office Excel, you can interact with the objects provided by the Excel object model. This topic introduces the most important objects:

- <xref:Microsoft.Office.Interop.Excel.Application>

- <xref:Microsoft.Office.Interop.Excel.Workbook>

- <xref:Microsoft.Office.Interop.Excel.Worksheet>

- <xref:Microsoft.Office.Interop.Excel.Range>

  [!INCLUDE[appliesto_xlalldocapp](../vsto/includes/appliesto-xlalldocapp-md.md)]

[!include[Add-ins note](includes/addinsnote.md)]

  The object model closely follows the user interface. The <xref:Microsoft.Office.Interop.Excel.Application> object represents the entire application, and each <xref:Microsoft.Office.Interop.Excel.Workbook> object contains a collection of `Worksheet` objects. From there, the major abstraction that represents cells is the <xref:Microsoft.Office.Interop.Excel.Range> object, which enables you to work with individual cells or groups of cells.

  In addition to the Excel object model, Office projects in Visual Studio provide *host items* and *host controls* that extend some objects in the Excel object model. Host items and host controls behave like the Excel objects they extend, but they also have additional functionality such as data-binding capabilities and extra events. For more information, see [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md) and [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md).

  This topic provides a brief overview of the Excel object model. For resources where you can learn more about the entire Excel object model, see [Use the Excel object model documentation](#ExcelOMDocumentation).

## Access objects in an Excel project
 When you create a new VSTO Add-in project for Excel, Visual Studio automatically creates a *ThisAddIn.vb* or *ThisAddIn.cs* code file. You can access the Application object by using `Me.Application` or `this.Application`.

 When you create a new document-level project for Excel, you have the option of creating a new Excel Workbook or Excel Template project. Visual Studio automatically creates the following code files in your new Excel project for both workbook and template projects.

|Visual Basic|C#|
|------------------|---------|
|ThisWorkbook.vb|ThisWorkbook.cs|
|Sheet1.vb|Sheet1.cs|
|Sheet2.vb|Sheet2.cs|
|Sheet3.vb|Sheet3.cs|

 You can use the `Globals` class in your project to access `ThisWorkbook`, `Sheet1`, `Sheet2`, or `Sheet3` from outside of the respective class. For more information, see [Global access to objects in Office projects](../vsto/global-access-to-objects-in-office-projects.md). The following example calls the <xref:Microsoft.Office.Interop.Excel._Worksheet.PrintPreview%2A> method of `Sheet1` regardless of whether the code is placed in one of the `Sheet`*n* classes or the `ThisWorkbook` class.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet82":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet82":::
 ---

 Because the data in an Excel document is highly structured, the object model is hierarchical and straightforward. Excel provides hundreds of objects with which you might want to interact, but you can get a good start on the object model by focusing on a small subset of the available objects. These objects include the following four:

- Application

- Workbook

- Worksheet

- Range

  Much of the work done with Excel centers around these four objects and their members.

### Application object
 The Excel <xref:Microsoft.Office.Interop.Excel.Application> object represents the Excel application itself. The <xref:Microsoft.Office.Interop.Excel.Application> object exposes a great deal of information about the running application, the options applied to that instance, and the current user objects open within the instance.

> [!NOTE]
> You should not set the <xref:Microsoft.Office.Interop.Excel.ApplicationClass.EnableEvents%2A> property of the <xref:Microsoft.Office.Interop.Excel.Application> object in Excel to **false**. Setting this property to false prevents Excel from raising any events, including the events of host controls.

### Workbook object
 The <xref:Microsoft.Office.Interop.Excel.Workbook> object represents a single workbook within the Excel application.

 The Office development tools in Visual Studio extend the <xref:Microsoft.Office.Interop.Excel.Workbook> object by providing the <xref:Microsoft.Office.Tools.Excel.Workbook> type. This type gives you access to all features of a <xref:Microsoft.Office.Interop.Excel.Workbook> object. For more information, see [Workbook host item](../vsto/workbook-host-item.md).

### Worksheet object
 The <xref:Microsoft.Office.Interop.Excel.Worksheet> object is a member of the <xref:Microsoft.Office.Interop.Excel.Worksheets> collection. Many of the properties, methods, and events of the <xref:Microsoft.Office.Interop.Excel.Worksheet> are identical or similar to members provided by the <xref:Microsoft.Office.Interop.Excel.Application> or <xref:Microsoft.Office.Interop.Excel.Workbook> objects.

 Excel provides a <xref:Microsoft.Office.Interop.Excel.Sheets> collection as a property of a <xref:Microsoft.Office.Interop.Excel.Workbook> object. Each member of the <xref:Microsoft.Office.Interop.Excel.Sheets> collection is either a <xref:Microsoft.Office.Interop.Excel.Worksheet> or a <xref:Microsoft.Office.Interop.Excel.Chart> object.

 The Office development tools in Visual Studio extend the <xref:Microsoft.Office.Interop.Excel.Worksheet> object by providing the <xref:Microsoft.Office.Tools.Excel.Worksheet> type. This type gives you access to all features of a <xref:Microsoft.Office.Interop.Excel.Worksheet> object, as well as new features such as the ability to host managed controls and handle new events. For more information, see [Worksheet host item](../vsto/worksheet-host-item.md).

### Range object
 The <xref:Microsoft.Office.Interop.Excel.Range> object is the object you will use most within your Excel applications. Before you can manipulate any region within Excel, you must express it as a <xref:Microsoft.Office.Interop.Excel.Range> object and work with methods and properties of that range. A <xref:Microsoft.Office.Interop.Excel.Range> object represents a cell, a row, a column, a selection of cells that contains one or more blocks of cells, which might or might not be contiguous, or even a group of cells on multiple sheets.

 Visual Studio extends the <xref:Microsoft.Office.Interop.Excel.Range> object by providing the <xref:Microsoft.Office.Tools.Excel.NamedRange> and <xref:Microsoft.Office.Tools.Excel.XmlMappedRange> types. These types have most of the same features as a <xref:Microsoft.Office.Interop.Excel.Range> object, as well as new features such as the data binding capability and new events. For more information, see [NamedRange control](../vsto/namedrange-control.md) and [XmlMappedRange control](../vsto/xmlmappedrange-control.md).

## <a name="ExcelOMDocumentation"></a> Use the Excel object model documentation
 For complete information about the Excel object model, you can refer to the Excel primary interop assembly (PIA) reference and the VBA object model reference.

### Primary interop assembly reference
 The Excel PIA reference documentation describes the types in the primary interop assembly for Excel. This documentation is available from the following location: [Excel 2010 primary interop assembly reference](office-primary-interop-assemblies.md).

 For more information about the design of the Excel PIA, such as the differences between classes and interfaces in the PIA and how events in the PIA are implemented, see [Overview of classes and interfaces in the Office primary interop assemblies](/previous-versions/office/office-12/ms247299(v=office.12)).

### VBA object model reference
 The VBA object model reference documents the Excel object model as it is exposed to Visual Basic for Applications (VBA) code. For more information, see [Excel 2010 object model reference](/office/vba/api/overview/Excel/object-model).

 All of the objects and members in the VBA object model reference correspond to types and members in the Excel PIA. For example, the Worksheet object in the VBA object model reference corresponds to the <xref:Microsoft.Office.Interop.Excel.Worksheet> object in the Excel PIA. Although the VBA object model reference provides code examples for most properties, methods, and events, you must translate the VBA code in this reference to Visual Basic or Visual C# if you want to use them in an Excel project that you create by using Visual Studio.

### Related topics

|Title|Description|
|-----------|-----------------|
|[Excel solutions](../vsto/excel-solutions.md)|Explains how you can create document-level customizations and VSTO Add-ins for Microsoft Office Excel.|
|[Work with ranges](../vsto/working-with-ranges.md)|Provides examples that show how to perform common tasks with ranges.|
|[Work with worksheets](../vsto/working-with-worksheets.md)|Provides examples that show how to perform common tasks with worksheets.|
|[Work with workbooks](../vsto/working-with-workbooks.md)|Provides examples that show how to perform common tasks with workbooks.|
