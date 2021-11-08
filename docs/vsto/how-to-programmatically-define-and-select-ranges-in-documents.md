---
title: "How to: Programmatically define and select ranges in documents"
description: Learn how you can programmatically define and select ranges in Microsoft Word documents by using the Range object.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], selecting sentences"
  - "documents [Office development in Visual Studio], ranges"
  - "sentences, selecting in documents"
  - "ranges, selecting in documents"
  - "ranges, defining in documents"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically define and select ranges in documents
  You can define a range in a Microsoft Office Word document by using a <xref:Microsoft.Office.Interop.Word.Range> object. You can select the entire document in a number of ways, for example, by using the <xref:Microsoft.Office.Interop.Word.Range.Select%2A> method of the <xref:Microsoft.Office.Interop.Word.Range> object, or by using the Content property of the <xref:Microsoft.Office.Tools.Word.Document> class (in a document-level customization) or the <xref:Microsoft.Office.Interop.Word.Document> class (in a VSTO Add-in).

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## Define a range
 The following example shows how to create a new <xref:Microsoft.Office.Interop.Word.Range> object that includes the first seven characters in the active document, including non-printing characters. It then selects the text within the range.

### To define a range in a document-level customization

1. Add the range to the document by passing a start and end character to the <xref:Microsoft.Office.Tools.Word.Document.Range%2A> method of the <xref:Microsoft.Office.Tools.Word.Document> class. To use this code example, run it from the `ThisDocument` class in your project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet18":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet18":::

### To define a range by using a VSTO Add-in

1. Add the range to the document by passing a start and end character to the <xref:Microsoft.Office.Interop.Word._Document.Range%2A> method of the <xref:Microsoft.Office.Interop.Word.Document> class. The following code example adds a range to the active document. To use this code example, run it from the `ThisAddIn` class in your project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet18":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet18":::

## Select a range in a document-level customization
 The following examples show how to select the entire document by using the <xref:Microsoft.Office.Interop.Word.Range.Select%2A> method of a <xref:Microsoft.Office.Interop.Word.Range> object, or by using the <xref:Microsoft.Office.Tools.Word.Document.Content%2A> property of the <xref:Microsoft.Office.Tools.Word.Document> class.

### To select the entire document as a range by using the Select method

1. Use the <xref:Microsoft.Office.Interop.Word.Range.Select%2A> method of a <xref:Microsoft.Office.Interop.Word.Range> that contains the entire document. To use the following code example, run it from the `ThisDocument` class in your project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet19":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet19":::

### To select the entire document as a range by using the Content property

1. Use the <xref:Microsoft.Office.Tools.Word.Document.Content%2A> property to define a range that encompasses the entire document.

    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet20":::
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet20":::

   You can also use the methods and properties of other objects to define a range.

### To select a sentence in the active document

1. Set the range by using the <xref:Microsoft.Office.Interop.Word.Sentences> collection. Use the index of the sentence you want to select.

    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet21":::
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet21":::

   Another way to select a sentence is to manually set the start and end values for the range.

### To select a sentence by manually setting the start and end values

1. Create a range variable.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet23":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet23":::

2. Check to see if there are at least two sentences in the document, set the *Start* and *End* arguments of the range, and then select the range.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet24":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet24":::

## Select a range by using a VSTO Add-in
 The following examples show how to select the entire document by using the <xref:Microsoft.Office.Interop.Word.Range.Select%2A> method of a <xref:Microsoft.Office.Interop.Word.Range> object, or by using the <xref:Microsoft.Office.Interop.Word._Document.Content%2A> property of the <xref:Microsoft.Office.Interop.Word.Document> class.

### To select the entire document as a range by using the Select method

1. Use the <xref:Microsoft.Office.Interop.Word.Range.Select%2A> method of a <xref:Microsoft.Office.Interop.Word.Range> that contains the entire document. The following code example selects the contents of the active document. To use this code example, run it from the `ThisAddIn` class in your project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet19":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet19":::

### To select the entire document as a range by using the Content property

1. Use the <xref:Microsoft.Office.Interop.Word._Document.Content%2A> property to define a range that encompasses the entire document.

    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet20":::
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet20":::

   You can also use the methods and properties of other objects to define a range.

### To select a sentence in the active document

1. Set the range by using the <xref:Microsoft.Office.Interop.Word.Sentences> collection. Use the index of the sentence you want to select.

    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet21":::
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet21":::

   Another way to select a sentence is to manually set the start and end values for the range.

### To select a sentence by manually setting the start and end values

1. Create a range variable.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet23":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet23":::

2. Check to see if there are at least two sentences in the document, set the *Start* and *End* arguments of the range, and then select the range.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet24":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet24":::

## See also
- [Word object model overview](../vsto/word-object-model-overview.md)
- [How to: Programmatically extend ranges in documents](../vsto/how-to-programmatically-extend-ranges-in-documents.md)
- [How to: Programmatically retrieve start and end characters in ranges](../vsto/how-to-programmatically-retrieve-start-and-end-characters-in-ranges.md)
- [How to: Programmatically extend ranges in documents](../vsto/how-to-programmatically-extend-ranges-in-documents.md)
- [How to: Programmatically reset ranges in Word documents](../vsto/how-to-programmatically-reset-ranges-in-word-documents.md)
- [How to: Programmatically collapse ranges or selections in documents](../vsto/how-to-programmatically-collapse-ranges-or-selections-in-documents.md)
- [How to: Programmatically exclude paragraph marks when creating ranges](../vsto/how-to-programmatically-exclude-paragraph-marks-when-creating-ranges.md)
