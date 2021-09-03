---
title: "How to: Programmatically remove all comments from documents"
description: Learn how you can use Visual Studio to programmatically remove all comments from a Microsoft Word document.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "documents [Office development in Visual Studio], removing comments"
  - "comments, removing from documents"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically remove all comments from documents
  Use the `DeleteAllComments` method to remove all comments from a Microsoft Office Word document.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## To remove all comments from a document that is part of a document-level customization

1. Call the <xref:Microsoft.Office.Tools.Word.Document.DeleteAllComments%2A> method of the `ThisDocument` class in your project. To use this code example, run it from the `ThisDocument` class.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet119":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet119":::

## To remove all comments from a document by using a VSTO Add-in

1. Call the <xref:Microsoft.Office.Interop.Word._Document.DeleteAllComments%2A> method of the <xref:Microsoft.Office.Interop.Word.Document> from which you want to remove comments.

     The following code example removes all comments from the active document. To use this code example, run it from the `ThisAddIn` class in your project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet119":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet119":::

## See also
- [How to: Programmatically add comments to text in documents](../vsto/how-to-programmatically-add-comments-to-text-in-documents.md)
- [Document host item](../vsto/document-host-item.md)
