---
title: "How to: Programmatically Hide Text in Documents | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "documents [Office development in Visual Studio], hiding text"
  - "text [Office development in Visual Studio], hiding in documents"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Hide Text in Documents
  You can hide text in a document by setting the <xref:Microsoft.Office.Interop.Word._Font.Hidden%2A> property of the <xref:Microsoft.Office.Interop.Word.Range.Font%2A> for a particular range of text.  
  
 For example, you can temporarily hide the text within a <xref:Microsoft.Office.Tools.Word.Bookmark> (in a document-level customization) or a <xref:Microsoft.Office.Interop.Word.Bookmark> (in an VSTO Add-in) before sending a document to a printer.  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
### To hide text in a Bookmark control while printing the document  
  
1.  Create a procedure that hides all text that is in a specified range.  
  
     [!code-vb[Trin_VstcoreWordAutomation#105](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#105)]
     [!code-csharp[Trin_VstcoreWordAutomation#105](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#105)]  
  
2.  Create a procedure that unhides all text that is in a specified range.  
  
     [!code-vb[Trin_VstcoreWordAutomation#106](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#106)]
     [!code-csharp[Trin_VstcoreWordAutomation#106](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#106)]  
  
3.  Pass the range of a bookmark to the `HideText` method, print the document, and then pass the same range to the `UnhideText` method.  
  
     The following code example can be used in a document-level customization. To use this example, run it from the `ThisDocument` class in your project.  
  
     [!code-vb[Trin_VstcoreWordAutomation#107](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#107)]
     [!code-csharp[Trin_VstcoreWordAutomation#107](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#107)]  
  
     The following code example can be used in an VSTO Add-in. This example uses the active document. To use the example, run it from the `ThisAddIn` class in your project.  
  
     [!code-vb[Trin_VstcoreWordAutomationAddIn#107](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#107)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#107](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#107)]  
  
## Compiling the Code  
 This code example assumes that the document contains a <xref:Microsoft.Office.Tools.Word.Bookmark> control (in a document-level customization) or <xref:Microsoft.Office.Interop.Word.Bookmark> control (in an VSTO Add-in) that is named `bookmark1`.  
  
## See Also  
 [How to: Programmatically Print Documents](../vsto/how-to-programmatically-print-documents.md)   
 [How to: Programmatically Define and Select Ranges in Documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)   
 [How to: Programmatically Reset Ranges in Word Documents](../vsto/how-to-programmatically-reset-ranges-in-word-documents.md)   
 [How to: Programmatically Update Bookmark Text](../vsto/how-to-programmatically-update-bookmark-text.md)   
 [Optional Parameters in Office Solutions](../vsto/optional-parameters-in-office-solutions.md)  
  
  