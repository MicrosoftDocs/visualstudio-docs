---
title: "How to: Programmatically reset ranges in Word documents"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], resetting ranges"
  - "ranges, resetting in documents"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically reset ranges in Word documents
  Use the <xref:Microsoft.Office.Interop.Word.Range.SetRange%2A> method to resize an existing range in a Microsoft Office Word document.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## To reset an existing range

1. Set an initial range starting with the first seven characters in the document.

     The following code example can be used in a document-level customization.

     [!code-vb[Trin_VstcoreWordAutomation#43](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#43)]
     [!code-csharp[Trin_VstcoreWordAutomation#43](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#43)]

     The following code example can be used in a VSTO Add-in. This code uses the active document.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#43](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#43)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#43](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#43)]

2. Use <xref:Microsoft.Office.Interop.Word.Range.SetRange%2A> to start the range at the second sentence and end it at the end of the fifth sentence.

     [!code-vb[Trin_VstcoreWordAutomation#44](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#44)]
     [!code-csharp[Trin_VstcoreWordAutomation#44](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#44)]

## Document-Level Customization Example

### To reset an existing range in a document-level customization

1. The following example shows the complete example for a document-level customization. To use this code, run it from the `ThisDocument` class in your project.

     [!code-vb[Trin_VstcoreWordAutomation#42](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#42)]
     [!code-csharp[Trin_VstcoreWordAutomation#42](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#42)]

## VSTO Add-in example

### To reset an existing range in a VSTO Add-in

1. The following example shows the complete example for a VSTO Add-in. To use this code, run it from the `ThisAddIn` class in your project.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#42](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#42)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#42](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#42)]

## See also
- [How to: Programmatically extend ranges in documents](../vsto/how-to-programmatically-extend-ranges-in-documents.md)
- [How to: Programmatically define and select ranges in documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)
- [How to: Programmatically retrieve start and end characters in ranges](../vsto/how-to-programmatically-retrieve-start-and-end-characters-in-ranges.md)
- [How to: Programmatically collapse ranges or selections in documents](../vsto/how-to-programmatically-collapse-ranges-or-selections-in-documents.md)
