---
title: "How to: Programmatically open existing documents"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], opening"
  - "Word [Office development in Visual Studio], opening documents"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically open existing documents
  The <xref:Microsoft.Office.Interop.Word.Documents.Open%2A> method opens the existing Microsoft Office Word document specified by a fully qualified path and file name. This method returns a <xref:Microsoft.Office.Interop.Word.Document> that represents the opened document.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## To open a document

- Call the <xref:Microsoft.Office.Interop.Word.Documents.Open%2A> method of the <xref:Microsoft.Office.Interop.Word.Documents> collection and supply a path to the document.

     [!code-vb[Trin_VstcoreWordAutomation#5](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#5)]
     [!code-csharp[Trin_VstcoreWordAutomation#5](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#5)]

## To open a document as read-only

- Call the <xref:Microsoft.Office.Interop.Word.Documents.Open%2A> method, supply a path to the document, and set the *ReadOnly* argument to **True** in the method call.

     [!code-vb[Trin_VstcoreWordAutomation#6](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#6)]
     [!code-csharp[Trin_VstcoreWordAutomation#6](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#6)]

## Compile the code
 This code example requires the following:

- A document named *NewDocument.doc* must exist in a directory named *Test* on drive C.

## See also
- [How to: Programmatically create new documents](../vsto/how-to-programmatically-create-new-documents.md)
- [How to: Programmatically close documents](../vsto/how-to-programmatically-close-documents.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
