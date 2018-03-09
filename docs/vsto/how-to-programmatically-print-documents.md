---
title: "How to: Programmatically Print Documents | Microsoft Docs"
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
  - "Word [Office development in Visual Studio], printing documents"
  - "documents [Office development in Visual Studio], printing"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Print Documents
  You can print an entire Microsoft Office Word document, or part of a document, to your default printer.  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
## Printing a Document That Is Part of a Document-Level Customization  
  
#### To print the entire document  
  
1.  Call the <xref:Microsoft.Office.Tools.Word.Document.PrintOut%2A> method of the `ThisDocument` class in your project to print the entire document. To use this example, run the code from the `ThisDocument` class.  
  
     [!code-vb[Trin_VstcoreWordAutomation#11](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#11)]
     [!code-csharp[Trin_VstcoreWordAutomation#11](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#11)]  
  
#### To print the current page of the document  
  
1.  Call the <xref:Microsoft.Office.Tools.Word.Document.PrintOut%2A> method of the `ThisDocument` class in your project and specify that one copy of the current page be printed. To use this example, run the code from the `ThisDocument` class.  
  
     [!code-vb[Trin_VstcoreWordAutomation#12](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#12)]
     [!code-csharp[Trin_VstcoreWordAutomation#12](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#12)]  
  
## Printing a Document By Using an VSTO Add-in  
  
#### To print an entire document  
  
1.  Call the <xref:Microsoft.Office.Interop.Word._Document.PrintOut%2A> method of the <xref:Microsoft.Office.Interop.Word.Document> object that you want to print. The following code example prints the active document. To use this example, run the code from the `ThisAddIn` class in your project.  
  
     [!code-vb[Trin_VstcoreWordAutomationAddIn#11](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#11)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#11](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#11)]  
  
#### To print the current page of a document  
  
1.  Call the <xref:Microsoft.Office.Interop.Word._Document.PrintOut%2A> method of the <xref:Microsoft.Office.Interop.Word.Document> object that you want to print, and specify that one copy of the current page be printed. The following code example prints the active document. To use this example, run the code from the `ThisAddIn` class in your project.  
  
     [!code-vb[Trin_VstcoreWordAutomationAddIn#12](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#12)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#12](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#12)]  
  
## See Also  
 [Optional Parameters in Office Solutions](../vsto/optional-parameters-in-office-solutions.md)  
  
  