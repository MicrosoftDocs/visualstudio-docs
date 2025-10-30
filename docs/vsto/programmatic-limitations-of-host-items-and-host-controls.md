---
title: "Programmatic limitations of host items and host controls"
description: Learn about the fundamental differences between the behavior of host items and host controls and native Office objects at run time.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office documents [Office development in Visual Studio, host controls"
  - "application development [Office development in Visual Studio], host items"
  - "Office applications [Office development in Visual Studio], host items"
  - "host items [Office development in Visual Studio], programmatic limitations"
  - "Excel [Office development in Visual Studio], host items"
  - "host controls [Office development in Visual Studio], creating"
  - "document-level customizations [Office development in Visual Studio], host controls"
  - "Office applications [Office development in Visual Studio], host controls"
  - "documents [Office development in Visual Studio], host controls"
  - "controls [Office development in Visual Studio], host controls"
  - "host controls [Office development in Visual Studio], passing to methods and properties"
  - "application development [Office development in Visual Studio], host controls"
  - "Excel [Office development in Visual Studio], host controls"
  - "host controls [Office development in Visual Studio], programmatic limitations"
  - "documents [Office development in Visual Studio], host items"
  - "Office documents [Office development in Visual Studio, host items"
  - "Word [Office development in Visual Studio], host items"
  - "document-level customizations [Office development in Visual Studio], host items"
  - "Word [Office development in Visual Studio], host controls"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Programmatic limitations of host items and host controls

  Each host item and host control is designed to behave like a corresponding native Microsoft Office Word or Microsoft Office Excel object, with additional functionality. However, there are some fundamental differences between the behavior of host items and host controls and native Office objects at run time.

 For general information about host items and host controls, see [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md).

 [!INCLUDE[appliesto_controls](../vsto/includes/appliesto-controls-md.md)]

## Programmatically create host items
 When you programmatically create or open a document, workbook, or worksheet at run time by using the Word or Excel object model, the item is not a host item. Instead, the new object is a native Office object. For example, if you use the <xref:Microsoft.Office.Interop.Word.Documents.Add%2A> method to create a new Word document at run time, it will be a native <xref:Microsoft.Office.Interop.Word.Document> object rather than a <xref:Microsoft.Office.Tools.Word.Document> host item. Similarly, when you create a new worksheet at run time using the <xref:Microsoft.Office.Interop.Excel.Worksheets.Add%2A> method, you get a native <xref:Microsoft.Office.Interop.Excel.Worksheet> object rather than a <xref:Microsoft.Office.Tools.Excel.Worksheet> host item.

 In document-level projects, you cannot create host items at run time. Host items can be created only at design time in document-level projects. For more information, see [Document host item](../vsto/document-host-item.md), [Workbook host item](../vsto/workbook-host-item.md), and [Worksheet host item](../vsto/worksheet-host-item.md).

 In VSTO Add-in projects, you can create <xref:Microsoft.Office.Tools.Word.Document>, <xref:Microsoft.Office.Tools.Excel.Workbook>, or <xref:Microsoft.Office.Tools.Excel.Worksheet> host items at run time. For more information, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

## Programmatically create host controls
 You can programmatically add host controls to a <xref:Microsoft.Office.Tools.Word.Document> or <xref:Microsoft.Office.Tools.Excel.Worksheet> host item at run time. For more information, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

 You cannot add host controls to a native <xref:Microsoft.Office.Interop.Word.Document> or <xref:Microsoft.Office.Interop.Excel.Worksheet>.

> [!NOTE]
> The following host controls cannot be added programmatically to worksheets or documents: <xref:Microsoft.Office.Tools.Excel.XmlMappedRange>, <xref:Microsoft.Office.Tools.Word.XMLNode>, and <xref:Microsoft.Office.Tools.Word.XMLNodes>.

## Understand type differences between host items, host controls, and native Office objects
 For each host item and host control, there is an underlying native Microsoft Office Word or Microsoft Office Excel object. You can access the underlying object by using the InnerObject property of the host item or host control. However, there is no way to cast a native Office object to its corresponding host item or host control. If you try to cast a native Office object into the type of a host item or host control, an <xref:System.InvalidCastException> is thrown.

 There are several scenarios where the differences between the types of host items and host controls and the underlying native Office objects can affect your code.

### Pass host controls to methods and properties
 In Word, you cannot pass a host control to a method or property that requires a native Word object as a parameter. You must use the InnerObject property of the host control to return the underlying native Word object. For example, you can pass a <xref:Microsoft.Office.Interop.Word.Bookmark> object to a method by passing the <xref:Microsoft.Office.Tools.Word.Bookmark.InnerObject%2A> property of the <xref:Microsoft.Office.Tools.Word.Bookmark> host control to the method.

 In Excel, you must use the InnerObject property of the host control to pass the host control to a method or property when the method or property expects the underlying Excel object.

 The following example creates a <xref:Microsoft.Office.Tools.Excel.NamedRange> control and passes it to the <xref:Microsoft.Office.Interop.Excel.Range.AutoFill%2A> method. The code uses the <xref:Microsoft.Office.Tools.Excel.NamedRange.InnerObject%2A> property of the named range to return the underlying Office <xref:Microsoft.Office.Interop.Excel.Range> that is required by the <xref:Microsoft.Office.Interop.Excel.Range.AutoFill%2A> method.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreHostControlsExcelCS/Sheet1.cs" id="Snippet28":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsExcelVB/Sheet1.vb" id="Snippet28":::
 ---

### Return types of native Office methods and properties
 Most methods and properties of host items return the underlying native Office object upon which the host item is based. For example, the <xref:Microsoft.Office.Tools.Excel.NamedRange.Parent%2A> property of a <xref:Microsoft.Office.Tools.Excel.NamedRange> host control in Excel returns a <xref:Microsoft.Office.Interop.Excel.Worksheet> object rather than a <xref:Microsoft.Office.Tools.Excel.Worksheet> host item. Similarly, the <xref:Microsoft.Office.Tools.Word.RichTextContentControl.Parent%2A> property of a <xref:Microsoft.Office.Tools.Word.RichTextContentControl> host control in Word returns a <xref:Microsoft.Office.Interop.Word.Document> object rather than a <xref:Microsoft.Office.Tools.Word.Document> host item.

### Access collections of host controls
 The  Visual Studio Tools for Office runtime  does not provide individual collections for each type of host control. Instead, use the Controls property of a host item to iterate through all managed controls (both host controls and Windows Forms controls) on the document or worksheet, and then look for items that match the type of the host control you are interested in. The following code example examines each control on a Word document and determines whether the control is a <xref:Microsoft.Office.Tools.Word.Bookmark>.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/trin_vstcorehostcontrolsword/ThisDocument.cs" id="Snippet10":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreHostControlsWordVB/ThisDocument.vb" id="Snippet10":::
 ---

 For more information about the Controls property of host items, see [Add controls to Office documents at run time](../vsto/adding-controls-to-office-documents-at-run-time.md).

 The Word and Excel object models include properties that expose collections of native controls on documents and worksheets. You cannot access managed controls by using these properties. For example, it is not possible to enumerate each <xref:Microsoft.Office.Tools.Word.Bookmark> host control in a document by using the <xref:Microsoft.Office.Interop.Word._Document.Bookmarks%2A> property of a <xref:Microsoft.Office.Interop.Word.Document> or the <xref:Microsoft.Office.Tools.Word.Document.Bookmarks%2A> property of a <xref:Microsoft.Office.Tools.Word.Document>. These properties include only the <xref:Microsoft.Office.Interop.Word.Bookmark> controls in the document; they do not contain the <xref:Microsoft.Office.Tools.Word.Bookmark> host controls in the document.

## Related content
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Automate Word by using extended objects](../vsto/automating-word-by-using-extended-objects.md)
- [Automate Excel by using extended objects](../vsto/automating-excel-by-using-extended-objects.md)
- [Worksheet host item](../vsto/worksheet-host-item.md)
- [Workbook host item](../vsto/workbook-host-item.md)
- [Document host item](../vsto/document-host-item.md)
