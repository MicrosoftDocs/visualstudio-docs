---
title: "How to: Programmatically remove all comments from documents"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], removing comments"
  - "comments, removing from documents"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Programmatically remove all comments from documents
  Use the `DeleteAllComments` method to remove all comments from a Microsoft Office Word document.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## To remove all comments from a document that is part of a document-level customization

1. Call the <xref:Microsoft.Office.Tools.Word.Document.DeleteAllComments%2A> method of the `ThisDocument` class in your project. To use this code example, run it from the `ThisDocument` class.

     [!code-vb[Trin_VstcoreWordAutomation#119](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#119)]
     [!code-csharp[Trin_VstcoreWordAutomation#119](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#119)]

## To remove all comments from a document by using a VSTO Add-in

1. Call the <xref:Microsoft.Office.Interop.Word._Document.DeleteAllComments%2A> method of the <xref:Microsoft.Office.Interop.Word.Document> from which you want to remove comments.

     The following code example removes all comments from the active document. To use this code example, run it from the `ThisAddIn` class in your project.

     [!code-vb[Trin_VstcoreWordAutomationAddIn#119](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#119)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#119](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#119)]

## See also
- [How to: Programmatically add comments to text in documents](../vsto/how-to-programmatically-add-comments-to-text-in-documents.md)
- [Document host item](../vsto/document-host-item.md)
