---
title: "How to: Read from and write to document properties"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Word [Office development in Visual Studio], document properties"
  - "documents [Office development in Visual Studio], properties"
  - "document properties [Office development in Visual Studio]"
  - "Excel [Office development in Visual Studio], document properties"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Read from and write to document properties
  You can store document properties along with a document. Office applications provide a number of built-in properties, such as author, title, and subject. This topic shows how to set document properties in Microsoft Office Excel and Microsoft Office Word.

 [!INCLUDE[appliesto_docprops](../vsto/includes/appliesto-docprops-md.md)]

## Set document properties in Excel
 To work with built-in properties in Excel, use the following properties:

- In a document-level project, use the <xref:Microsoft.Office.Tools.Excel.Workbook.BuiltinDocumentProperties%2A> property of the `ThisWorkbook` class.

- In a VSTO Add-in project, use the <xref:Microsoft.Office.Interop.Excel._Workbook.BuiltinDocumentProperties%2A> property of a <xref:Microsoft.Office.Interop.Excel.Workbook> object.

  These properties return a <xref:Microsoft.Office.Core.DocumentProperties> object, which is a collection of <xref:Microsoft.Office.Core.DocumentProperty> objects. You can use the `Item` property of the collection to retrieve a particular property, either by name or by index within the collection.

  The following code example shows how to change the built-in **Revision Number** property in a document-level project.

### To change the Revision Number property in Excel

1. Assign the built-in document properties to a variable.

     [!code-vb[Trin_VstcoreProgramming#7](../vsto/codesnippet/VisualBasic/Trin_VstcoreProgrammingExcelVB/ThisWorkbook.vb#7)]
     [!code-csharp[Trin_VstcoreProgramming#7](../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingExcelCS/ThisWorkbook.cs#7)]

2. Increment the `Revision Number` property by one.

     [!code-vb[Trin_VstcoreProgramming#8](../vsto/codesnippet/VisualBasic/Trin_VstcoreProgrammingExcelVB/ThisWorkbook.vb#8)]
     [!code-csharp[Trin_VstcoreProgramming#8](../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingExcelCS/ThisWorkbook.cs#8)]

## Set document properties in Word
 To work with built-in properties in Word, use the following properties:

- In a document-level project, use the <xref:Microsoft.Office.Tools.Word.Document.BuiltInDocumentProperties%2A> property of the `ThisDocument` class.

- In a VSTO Add-in project, use the <xref:Microsoft.Office.Interop.Word._Document.BuiltInDocumentProperties%2A> property of a <xref:Microsoft.Office.Interop.Word.Document> object.

  These properties return a <xref:Microsoft.Office.Core.DocumentProperties> object, which is a collection of <xref:Microsoft.Office.Core.DocumentProperty> objects. You can use the `Item` property of the collection to retrieve a particular property, either by name or by index within the collection.

  The following code example shows how to change the built-in **Subject** property in a document-level project.

### To change the Subject property

1. Assign the built-in document properties to a variable.

     [!code-csharp[Trin_VstcoreProgrammingWord#1](../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingWordCS/ThisDocument.cs#1)]
     [!code-vb[Trin_VstcoreProgrammingWord#1](../vsto/codesnippet/VisualBasic/Trin_VstcoreProgrammingWordVB/ThisDocument.vb#1)]

2. Change the `Subject` property to "Whitepaper".

     [!code-csharp[Trin_VstcoreProgrammingWord#2](../vsto/codesnippet/CSharp/Trin_VstcoreProgrammingWordCS/ThisDocument.cs#2)]
     [!code-vb[Trin_VstcoreProgrammingWord#2](../vsto/codesnippet/VisualBasic/Trin_VstcoreProgrammingWordVB/ThisDocument.vb#2)]

## Robust programming
 The examples assume that you have written the code in the `ThisWorkbook` class in a document-level project for Excel, and the `ThisDocument` class in a document-level project for Word.

 Although you are working with Word and Excel and their objects, Microsoft Office supplies the list of available built-in document properties. Attempting to access an undefined property raises an exception.

## See also
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Program document-level customizations](../vsto/programming-document-level-customizations.md)
- [How to: Create and modify custom document properties](../vsto/how-to-create-and-modify-custom-document-properties.md)
