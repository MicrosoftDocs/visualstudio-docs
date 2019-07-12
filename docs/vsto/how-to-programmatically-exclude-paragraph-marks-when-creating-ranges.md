---
title: "Exclude paragraph marks when creating ranges programmatically"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], excluding paragraphs"
  - "ranges, excluding paragraph marks in Word"
  - "documents [Office development in Visual Studio], paragraph marks"
  - "paragraphs, controlling structure"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically exclude paragraph marks when creating ranges
  Whenever you create a <xref:Microsoft.Office.Interop.Word.Range> object based on a paragraph, all non-printing characters, such as paragraph marks, are included in the range. You may want to insert the text from a source paragraph into a destination paragraph. If you do not want to split the destination paragraph into separate paragraphs, then you must first remove the paragraph mark from the source paragraph. Additionally, since paragraph formatting information is stored within the paragraph mark, you might not want to include this when you insert the range into an existing paragraph.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

 The following example procedure declares two string variables, retrieves the contents of the first and second paragraphs in the active document, and then exchanges their contents. The example then demonstrates removing the paragraph marker from the range by using the <xref:Microsoft.Office.Interop.Word.Range.MoveEnd%2A> method and inserting text inside the paragraph.

## To control paragraph structure when inserting text

1. Create two range variables for the first and second paragraphs, and retrieve their contents using the <xref:Microsoft.Office.Interop.Word.Range.Text%2A> property.

     The following code example can be used in a document-level customization.

     [!code-vb[Trin_VstcoreWordAutomation#27](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#27)]
     [!code-csharp[Trin_VstcoreWordAutomation#27](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#27)]

     The following code example can be used in an application-level VSTO Add-in. This code uses the active document.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#27](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#27)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#27](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#27)]

2. Assign the <xref:Microsoft.Office.Interop.Word.Range.Text%2A> property, swapping the text between the two paragraphs.

     [!code-vb[Trin_VstcoreWordAutomation#28](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#28)]
     [!code-csharp[Trin_VstcoreWordAutomation#28](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#28)]

3. Select each range in turn and pause to display the results in a message box.

     [!code-vb[Trin_VstcoreWordAutomation#29](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#29)]
     [!code-csharp[Trin_VstcoreWordAutomation#29](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#29)]

4. Adjust `firstRange` using the <xref:Microsoft.Office.Interop.Word.Range.MoveEnd%2A> method so that the paragraph marker is no longer a part of `firstRange`.

     [!code-vb[Trin_VstcoreWordAutomation#30](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#30)]
     [!code-csharp[Trin_VstcoreWordAutomation#30](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#30)]

5. Replace the rest of the text in the first paragraph, assigning a new string to the <xref:Microsoft.Office.Interop.Word.Range.Text%2A> property of the range.

     [!code-vb[Trin_VstcoreWordAutomation#31](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#31)]
     [!code-csharp[Trin_VstcoreWordAutomation#31](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#31)]

6. Replace the text in `secondRange`, including the paragraph mark.

     [!code-vb[Trin_VstcoreWordAutomation#32](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#32)]
     [!code-csharp[Trin_VstcoreWordAutomation#32](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#32)]

7. Select `firstRange` and pause to display the results in a message box, and then do the same with `secondRange`.

     Since `firstRange` was redefined to exclude the paragraph mark, the original formatting of the paragraph is preserved. However, a sentence was inserted over the paragraph mark in `secondRange`, removing the separate paragraph.

     [!code-vb[Trin_VstcoreWordAutomation#33](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#33)]
     [!code-csharp[Trin_VstcoreWordAutomation#33](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#33)]

     The original contents of both ranges were saved as strings, so you can restore the document to its original condition.

8. Readjust `firstRange` to include the paragraph mark by using the <xref:Microsoft.Office.Interop.Word.Range.MoveEnd%2A> method for one-character position.

     [!code-vb[Trin_VstcoreWordAutomation#34](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#34)]
     [!code-csharp[Trin_VstcoreWordAutomation#34](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#34)]

9. Delete `secondRange`. This restores paragraph three to its original position.

     [!code-vb[Trin_VstcoreWordAutomation#35](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#35)]
     [!code-csharp[Trin_VstcoreWordAutomation#35](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#35)]

10. Restore the original paragraph text in `firstRange`.

     [!code-vb[Trin_VstcoreWordAutomation#36](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#36)]
     [!code-csharp[Trin_VstcoreWordAutomation#36](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#36)]

11. Use the <xref:Microsoft.Office.Interop.Word.Range.InsertAfter%2A> method of the <xref:Microsoft.Office.Interop.Word.Range> object to insert the original paragraph-two content after `firstRange`, and then select `firstRange`.

     [!code-vb[Trin_VstcoreWordAutomation#37](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#37)]
     [!code-csharp[Trin_VstcoreWordAutomation#37](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#37)]

## Document-level customization example

### To control paragraph structure when inserting text in document-level customizations

1. The following example shows the complete method for a document-level customization. To use this code, run it from the `ThisDocument` class in your project.

     [!code-vb[Trin_VstcoreWordAutomation#26](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#26)]
     [!code-csharp[Trin_VstcoreWordAutomation#26](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#26)]

## VSTO Add-in example

### To control paragraph structure when inserting text in a VSTO Add-in

1. The following example shows the complete method for a VSTO Add-in. To use this code, run it from the `ThisAddIn` class in your project.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#26](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#26)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#26](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#26)]

## See also
- [How to: Programmatically extend ranges in documents](../vsto/how-to-programmatically-extend-ranges-in-documents.md)
- [How to: Programmatically collapse ranges or selections in documents](../vsto/how-to-programmatically-collapse-ranges-or-selections-in-documents.md)
- [How to: Programmatically insert text into Word documents](../vsto/how-to-programmatically-insert-text-into-word-documents.md)
- [How to: Programmatically reset ranges in Word documents](../vsto/how-to-programmatically-reset-ranges-in-word-documents.md)
- [How to: Programmatically define and select ranges in documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
