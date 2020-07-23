---
title: "How to: Programmatically hide text in documents"
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], hiding text"
  - "text [Office development in Visual Studio], hiding in documents"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically hide text in documents
  You can hide text in a document by setting the <xref:Microsoft.Office.Interop.Word._Font.Hidden%2A> property of the <xref:Microsoft.Office.Interop.Word.Range.Font%2A> for a particular range of text.

 For example, you can temporarily hide the text within a <xref:Microsoft.Office.Tools.Word.Bookmark> (in a document-level customization) or a <xref:Microsoft.Office.Interop.Word.Bookmark> (in a VSTO Add-in) before sending a document to a printer.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## To hide text in a Bookmark control while printing the document

1. Create a procedure that hides all text that is in a specified range.

     [!code-vb[Trin_VstcoreWordAutomation#105](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#105)]
     [!code-csharp[Trin_VstcoreWordAutomation#105](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#105)]

2. Create a procedure that unhides all text that is in a specified range.

     [!code-vb[Trin_VstcoreWordAutomation#106](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#106)]
     [!code-csharp[Trin_VstcoreWordAutomation#106](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#106)]

3. Pass the range of a bookmark to the `HideText` method, print the document, and then pass the same range to the `UnhideText` method.

     The following code example can be used in a document-level customization. To use this example, run it from the `ThisDocument` class in your project.

     [!code-vb[Trin_VstcoreWordAutomation#107](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#107)]
     [!code-csharp[Trin_VstcoreWordAutomation#107](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#107)]

     The following code example can be used in a VSTO Add-in. This example uses the active document. To use the example, run it from the `ThisAddIn` class in your project.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#107](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#107)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#107](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#107)]

## Compile the code
 This code example assumes that the document contains a <xref:Microsoft.Office.Tools.Word.Bookmark> control (in a document-level customization) or <xref:Microsoft.Office.Interop.Word.Bookmark> control (in a VSTO Add-in) that is named `bookmark1`.

## See also
- [How to: Programmatically print documents](../vsto/how-to-programmatically-print-documents.md)
- [How to: Programmatically define and select ranges in documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)
- [How to: Programmatically reset ranges in Word documents](../vsto/how-to-programmatically-reset-ranges-in-word-documents.md)
- [How to: Programmatically update Bookmark text](../vsto/how-to-programmatically-update-bookmark-text.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
