---
title: "Create and modify custom document properties"
description: Create and modify custom Microsoft Office Word document properties if there's additional information you want to store with the document.
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "custom document properties"
  - "documents [Office development in Visual Studio], properties"
  - "document properties [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Create and modify custom document properties

  The Microsoft Office applications listed above provide built-in properties that are stored with documents. In addition, you can create and modify custom document properties if there is additional information you want to store with the document.

 [!INCLUDE[appliesto_docprops](../vsto/includes/appliesto-docprops-md.md)]

 Use the CustomDocumentProperties property of a document to work with custom properties. For example, in a document-level project for Microsoft Office Excel, use the <xref:Microsoft.Office.Tools.Excel.Workbook.CustomDocumentProperties%2A> property of the `ThisWorkbook` class. In a VSTO Add-in project for Excel, use the <xref:Microsoft.Office.Interop.Excel._Workbook.CustomDocumentProperties%2A> property of a <xref:Microsoft.Office.Interop.Excel.Workbook> object. These properties return a <xref:Microsoft.Office.Core.DocumentProperties> object, which is a collection of <xref:Microsoft.Office.Core.DocumentProperty> objects. You can use the `Item` property of the collection to retrieve a particular property, either by name or by index within the collection.

 The following example demonstrates how to add a custom property in a document-level customization for Excel and assign it a value.

## Example

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingExcelCS/ThisWorkbook.cs" id="Snippet6":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreProgrammingExcelVB/ThisWorkbook.vb" id="Snippet6":::
 ---

## Robust programming
 Attempting to access the `Value` property for undefined properties raises an exception.

## Related content
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Program document-level customizations](../vsto/programming-document-level-customizations.md)
- [How to: Read from and write to document properties](../vsto/how-to-read-from-and-write-to-document-properties.md)
