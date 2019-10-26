---
title: "How to: Programmatically add rows and columns to Word tables"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "rows [Office development in Visual Studio], adding to Word tables"
  - "tables [Office development in Visual Studio], adding rows and columns"
  - "columns [Office development in Visual Studio], adding to Word tables"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically add rows and columns to Word tables
  In a Microsoft Office Word table, the cells are organized into rows and columns. You can use the <xref:Microsoft.Office.Interop.Word.Rows.Add%2A> method of the <xref:Microsoft.Office.Interop.Word.Rows> object to add rows to the table and the <xref:Microsoft.Office.Interop.Word.Columns.Add%2A> method of the <xref:Microsoft.Office.Interop.Word.Columns> object to add columns.

 [!INCLUDE[appliesto_wdalldocapp](includes/appliesto-wdalldocapp-md.md)]

## Document-level customization examples
 The following code examples can be used in a document-level customization. To use these examples, run them from the `ThisDocument` class in your project. These examples assume that the document associated with your customization already has at least one table.

> [!IMPORTANT]
> This code runs only in projects that you create by using any of the following project templates:
>
> - Word 2013 Document
> - Word 2013 Template
> - Word 2010 Document
> - Word 2010 Template
>
>   If you want to perform this task in any other type of project, you must add a reference to the **Microsoft.Office.Interop.Word** assembly, and then you must use classes from that assembly to add rows and columns to tables. For more information, see [How to: Target Office applications through primary interop assemblies](how-to-target-office-applications-through-primary-interop-assemblies.md) and [Word 2010 primary interop assembly reference](office-primary-interop-assemblies.md).

### To add a row to a table

1. Use the <xref:Microsoft.Office.Interop.Word.Rows.Add%2A> method to add a row to the table.

     [!code-vb[Trin_VstcoreWordAutomation#95](codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#95)]
     [!code-csharp[Trin_VstcoreWordAutomation#95](codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#95)]

### To add a column to a table

1. Use the <xref:Microsoft.Office.Interop.Word.Columns.Add%2A> method, and then use the <xref:Microsoft.Office.Interop.Word.Columns.DistributeWidth%2A> method to make all the columns the same width.

     [!code-vb[Trin_VstcoreWordAutomation#96](codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#96)]
     [!code-csharp[Trin_VstcoreWordAutomation#96](codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#96)]

## VSTO Add-in examples
 The following code examples can be used in a VSTO Add-in. To use the examples, run them from the `ThisAddIn` class in your project. These examples assume that the active document already has at least one table.

> [!IMPORTANT]
> This code runs only in projects that you create by using Word VSTO Add-in templates.
>
> If you want to perform this task in any other type of project, you must add a reference to the **Microsoft.Office.Interop.Word** assembly, and then you must use classes from that assembly to add rows and columns to tables. For more information, see [How to: Target Office applications through primary interop assemblies](how-to-target-office-applications-through-primary-interop-assemblies.md) and [Word 2010 primary interop assembly reference](office-primary-interop-assemblies.md).

### To add a row to a table

1. Use the <xref:Microsoft.Office.Interop.Word.Rows.Add%2A> method to add a row to the table.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#95](codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#95)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#95](codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#95)]

### To add a column to a table

1. Use the <xref:Microsoft.Office.Interop.Word.Columns.Add%2A> method, and then use the <xref:Microsoft.Office.Interop.Word.Columns.DistributeWidth%2A> method to make all the columns the same width.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#96](codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#96)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#96](codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#96)]

## See also
- [How to: Programmatically create Word tables](how-to-programmatically-create-word-tables.md)
- [How to: Programmatically add text and formatting to cells in Word tables](how-to-programmatically-add-text-and-formatting-to-cells-in-word-tables.md)
- [How to: Programmatically populate Word tables with document properties](how-to-programmatically-populate-word-tables-with-document-properties.md)
