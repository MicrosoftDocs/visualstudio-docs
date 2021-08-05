---
title: "Exclude paragraph marks when creating ranges programmatically"
description: Learn how you can programmatically exclude paragraph marks when creating ranges in a Microsoft Word document.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
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
manager: jmartens
ms.technology: office-development
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

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet27":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet27":::

     The following code example can be used in an application-level VSTO Add-in. This code uses the active document.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet27":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet27":::

2. Assign the <xref:Microsoft.Office.Interop.Word.Range.Text%2A> property, swapping the text between the two paragraphs.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet28":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet28":::

3. Select each range in turn and pause to display the results in a message box.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet29":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet29":::

4. Adjust `firstRange` using the <xref:Microsoft.Office.Interop.Word.Range.MoveEnd%2A> method so that the paragraph marker is no longer a part of `firstRange`.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet30":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet30":::

5. Replace the rest of the text in the first paragraph, assigning a new string to the <xref:Microsoft.Office.Interop.Word.Range.Text%2A> property of the range.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet31":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet31":::

6. Replace the text in `secondRange`, including the paragraph mark.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet32":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet32":::

7. Select `firstRange` and pause to display the results in a message box, and then do the same with `secondRange`.

     Since `firstRange` was redefined to exclude the paragraph mark, the original formatting of the paragraph is preserved. However, a sentence was inserted over the paragraph mark in `secondRange`, removing the separate paragraph.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet33":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet33":::

     The original contents of both ranges were saved as strings, so you can restore the document to its original condition.

8. Readjust `firstRange` to include the paragraph mark by using the <xref:Microsoft.Office.Interop.Word.Range.MoveEnd%2A> method for one-character position.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet34":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet34":::

9. Delete `secondRange`. This restores paragraph three to its original position.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet35":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet35":::

10. Restore the original paragraph text in `firstRange`.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet36":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet36":::

11. Use the <xref:Microsoft.Office.Interop.Word.Range.InsertAfter%2A> method of the <xref:Microsoft.Office.Interop.Word.Range> object to insert the original paragraph-two content after `firstRange`, and then select `firstRange`.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet37":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet37":::

## Document-level customization example

### To control paragraph structure when inserting text in document-level customizations

1. The following example shows the complete method for a document-level customization. To use this code, run it from the `ThisDocument` class in your project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet26":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet26":::

## VSTO Add-in example

### To control paragraph structure when inserting text in a VSTO Add-in

1. The following example shows the complete method for a VSTO Add-in. To use this code, run it from the `ThisAddIn` class in your project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet26":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet26":::

## See also
- [How to: Programmatically extend ranges in documents](../vsto/how-to-programmatically-extend-ranges-in-documents.md)
- [How to: Programmatically collapse ranges or selections in documents](../vsto/how-to-programmatically-collapse-ranges-or-selections-in-documents.md)
- [How to: Programmatically insert text into Word documents](../vsto/how-to-programmatically-insert-text-into-word-documents.md)
- [How to: Programmatically reset ranges in Word documents](../vsto/how-to-programmatically-reset-ranges-in-word-documents.md)
- [How to: Programmatically define and select ranges in documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
