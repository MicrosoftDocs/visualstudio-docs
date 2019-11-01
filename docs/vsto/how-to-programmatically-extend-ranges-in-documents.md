---
title: "How to: Programmatically extend ranges in documents"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "ranges, extending"
  - "documents [Office development in Visual Studio], extending ranges"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically Extend ranges in documents
  After you define a <xref:Microsoft.Office.Interop.Word.Range> object in a Microsoft Office Word document, you change its start and end points by using the <xref:Microsoft.Office.Interop.Word.Range.MoveStart%2A> and <xref:Microsoft.Office.Interop.Word.Range.MoveEnd%2A> methods. The <xref:Microsoft.Office.Interop.Word.Range.MoveStart%2A> and <xref:Microsoft.Office.Interop.Word.Range.MoveEnd%2A> methods take the same two arguments, *Unit* and *Count*. The *Count* argument is the number of units to move, and the *Unit* argument can be one of the following <xref:Microsoft.Office.Interop.Word.WdUnits> values:

- <xref:Microsoft.Office.Interop.Word.WdUnits.wdCharacter>

- <xref:Microsoft.Office.Interop.Word.WdUnits.wdWord>

- <xref:Microsoft.Office.Interop.Word.WdUnits.wdSentence>

- <xref:Microsoft.Office.Interop.Word.WdUnits.wdParagraph>

- <xref:Microsoft.Office.Interop.Word.WdUnits.wdSection>

- <xref:Microsoft.Office.Interop.Word.WdUnits.wdStory>

- <xref:Microsoft.Office.Interop.Word.WdUnits.wdCell>

- <xref:Microsoft.Office.Interop.Word.WdUnits.wdColumn>

- <xref:Microsoft.Office.Interop.Word.WdUnits.wdRow>

- <xref:Microsoft.Office.Interop.Word.WdUnits.wdTable>

  [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

  The following example defines a seven-character range. It then moves the start position of the range seven characters after the original start position. Because the end position of the range was also seven characters after the start position, the result is a range that consists of zero characters. The code then moves the end position seven characters after the current end position.

## To extend a range

1. Define a range of characters. For more information, see [How to: Programmatically define and select ranges in documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md).

     The following code example can be used in a document-level customization.

     [!code-vb[Trin_VstcoreWordAutomation#39](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#39)]
     [!code-csharp[Trin_VstcoreWordAutomation#39](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#39)]

     The following code example can be used in a VSTO Add-in. This example uses the active document.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#39](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#39)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#39](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#39)]

2. Use the <xref:Microsoft.Office.Interop.Word.Range.MoveStart%2A> method of the <xref:Microsoft.Office.Interop.Word.Range> object to move the start position of the range.

     [!code-vb[Trin_VstcoreWordAutomation#40](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#40)]
     [!code-csharp[Trin_VstcoreWordAutomation#40](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#40)]

3. Use the <xref:Microsoft.Office.Interop.Word.Range.MoveEnd%2A> method of the <xref:Microsoft.Office.Interop.Word.Range> object to move the end position of the range.

     [!code-vb[Trin_VstcoreWordAutomation#41](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#41)]
     [!code-csharp[Trin_VstcoreWordAutomation#41](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#41)]

## Document-level customization code

### To extend a range in a document-level customization

1. The following example shows the complete code for a document-level customization. To use this code, run it from the `ThisDocument` class in your project.

     [!code-vb[Trin_VstcoreWordAutomation#38](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#38)]
     [!code-csharp[Trin_VstcoreWordAutomation#38](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#38)]

## VSTO Add-in Code

### To extend a range in an application-level VSTO Add-in

1. The following example shows the complete code for a VSTO Add-in. To use this code, run it from the `ThisAddIn` class in your project.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#38](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#38)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#38](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#38)]

## See also
- [How to: Programmatically reset ranges in Word documents](../vsto/how-to-programmatically-reset-ranges-in-word-documents.md)
- [How to: Programmatically collapse ranges or selections in documents](../vsto/how-to-programmatically-collapse-ranges-or-selections-in-documents.md)
- [How to: Programmatically define and select ranges in documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)
- [How to: Programmatically retrieve start and end characters in ranges](../vsto/how-to-programmatically-retrieve-start-and-end-characters-in-ranges.md)
- [How to: Programmatically exclude paragraph marks when creating ranges](../vsto/how-to-programmatically-exclude-paragraph-marks-when-creating-ranges.md)
