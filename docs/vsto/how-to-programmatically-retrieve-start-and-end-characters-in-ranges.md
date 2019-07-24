---
title: "Get start & end characters in ranges programmatically"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ranges, retrieving start and end characters"
  - "end characters"
  - "start characters"
  - "documents [Office development in Visual Studio], retrieving ranges"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically retrieve start and end characters in ranges
  This example demonstrates how you can retrieve the character positions of the start and end positions of a range.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## To retrieve start and end characters of a range in a document-level customization

1. Get the values of the <xref:Microsoft.Office.Interop.Word.Range.Start%2A> and <xref:Microsoft.Office.Interop.Word.Range.End%2A> properties of the <xref:Microsoft.Office.Interop.Word.Range> object. The following code example gets the start and end position of the second sentence in the document. To use this code example, run it from the `ThisDocument` class in your project.

     [!code-vb[Trin_VstcoreWordAutomation#25](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#25)]
     [!code-csharp[Trin_VstcoreWordAutomation#25](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#25)]

## To retrieve start and end characters of a range by using a VSTO Add-in

1. Get the values of the <xref:Microsoft.Office.Interop.Word.Range.Start%2A> and <xref:Microsoft.Office.Interop.Word.Range.End%2A> properties of the <xref:Microsoft.Office.Interop.Word.Range> object. The following code example gets the start and end position of the second sentence in the active document. To use this code example, run it from the `ThisAddIn` class in your project.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#25](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#25)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#25](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#25)]

## See also
- [How to: Programmatically define and select ranges in documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)
- [How to: Programmatically extend ranges in documents](../vsto/how-to-programmatically-extend-ranges-in-documents.md)
- [How to: Programmatically reset ranges in Word documents](../vsto/how-to-programmatically-reset-ranges-in-word-documents.md)
- [How to: Programmatically collapse ranges or selections in documents](../vsto/how-to-programmatically-collapse-ranges-or-selections-in-documents.md)
- [How to: Programmatically exclude paragraph marks when creating ranges](../vsto/how-to-programmatically-exclude-paragraph-marks-when-creating-ranges.md)
- [How to: Programmatically count characters in documents](../vsto/how-to-programmatically-count-characters-in-documents.md)
