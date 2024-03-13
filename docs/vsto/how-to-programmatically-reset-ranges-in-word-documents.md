---
title: "Programmatically reset ranges in Word documents"
description: Learn how you can use Visual Studio to programmatically resize an existing range in a Microsoft Word document.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], resetting ranges"
  - "ranges, resetting in documents"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Programmatically reset ranges in Word documents

  Use the <xref:Microsoft.Office.Interop.Word.Range.SetRange%2A> method to resize an existing range in a Microsoft Office Word document.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## To reset an existing range

1. Set an initial range starting with the first seven characters in the document.

     The following code example can be used in a document-level customization.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet43":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet43":::
     ---

     The following code example can be used in a VSTO Add-in. This code uses the active document.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet43":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet43":::
     ---

2. Use <xref:Microsoft.Office.Interop.Word.Range.SetRange%2A> to start the range at the second sentence and end it at the end of the fifth sentence.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet44":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet44":::
     ---

## Document-Level Customization Example

### To reset an existing range in a document-level customization

1. The following example shows the complete example for a document-level customization. To use this code, run it from the `ThisDocument` class in your project.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet42":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet42":::
     ---

## VSTO Add-in example

### To reset an existing range in a VSTO Add-in

1. The following example shows the complete example for a VSTO Add-in. To use this code, run it from the `ThisAddIn` class in your project.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet42":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet42":::
     ---

## Related content
- [How to: Programmatically extend ranges in documents](../vsto/how-to-programmatically-extend-ranges-in-documents.md)
- [How to: Programmatically define and select ranges in documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)
- [How to: Programmatically retrieve start and end characters in ranges](/previous-versions/visualstudio/visual-studio-2017/vsto/how-to-programmatically-retrieve-start-and-end-characters-in-ranges)
- [How to: Programmatically collapse ranges or selections in documents](../vsto/how-to-programmatically-collapse-ranges-or-selections-in-documents.md)
