---
title: "How to: Programmatically print documents"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Word [Office development in Visual Studio], printing documents"
  - "documents [Office development in Visual Studio], printing"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically print documents
  You can print an entire Microsoft Office Word document, or part of a document, to your default printer.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## Print a document that is part of a document-level customization

### To print the entire document

1. Call the <xref:Microsoft.Office.Tools.Word.Document.PrintOut%2A> method of the `ThisDocument` class in your project to print the entire document. To use this example, run the code from the `ThisDocument` class.

     [!code-vb[Trin_VstcoreWordAutomation#11](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#11)]
     [!code-csharp[Trin_VstcoreWordAutomation#11](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#11)]

### To print the current page of the document

1. Call the <xref:Microsoft.Office.Tools.Word.Document.PrintOut%2A> method of the `ThisDocument` class in your project and specify that one copy of the current page be printed. To use this example, run the code from the `ThisDocument` class.

     [!code-vb[Trin_VstcoreWordAutomation#12](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#12)]
     [!code-csharp[Trin_VstcoreWordAutomation#12](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#12)]

## Print a document by using a VSTO Add-in

### To print an entire document

1. Call the <xref:Microsoft.Office.Interop.Word._Document.PrintOut%2A> method of the <xref:Microsoft.Office.Interop.Word.Document> object that you want to print. The following code example prints the active document. To use this example, run the code from the `ThisAddIn` class in your project.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#11](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#11)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#11](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#11)]

### To print the current page of a document

1. Call the <xref:Microsoft.Office.Interop.Word._Document.PrintOut%2A> method of the <xref:Microsoft.Office.Interop.Word.Document> object that you want to print, and specify that one copy of the current page be printed. The following code example prints the active document. To use this example, run the code from the `ThisAddIn` class in your project.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#12](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#12)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#12](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#12)]

## See also
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
