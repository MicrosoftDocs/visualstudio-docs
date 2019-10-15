---
title: "Add text & formatting to Word table cells programmatically"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "cells, adding text and formatting"
  - "text [Office development in Visual Studio], adding to Word tables"
  - "formatting [Office development in Visual Studio]"
  - "tables [Office development in Visual Studio], adding text and formatting"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically add text and formatting to cells in Word tables
  Each table consists of a collection of cells. Each individual <xref:Microsoft.Office.Interop.Word.Cell> object represents one cell in the table. You refer to each cell by its location in the table. This example refers to the cell located in the first row and the first column of the table; adds text to the cell; and applies formatting.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## To add text and formatting to cells

1. Refer to the cell by its location in the table, add text to the cell, and apply the formatting.

     The following code example can be used in a document-level customization. To use this example, run it from the `ThisDocument` class in your project.

     [!code-vb[Trin_VstcoreWordAutomation#97](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#97)]
     [!code-csharp[Trin_VstcoreWordAutomation#97](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#97)]

     The following code example can be used in a VSTO Add-in. This example uses the active document. To use the example, run it from the `ThisAddIn` class in your project.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#97](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#97)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#97](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#97)]

## See also
- [How to: Programmatically create Word tables](../vsto/how-to-programmatically-create-word-tables.md)
- [How to: Programmatically add rows and columns to Word tables](../vsto/how-to-programmatically-add-rows-and-columns-to-word-tables.md)
- [How to: Programmatically populate Word tables with document properties](../vsto/how-to-programmatically-populate-word-tables-with-document-properties.md)
