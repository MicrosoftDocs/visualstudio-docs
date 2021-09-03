---
title: "How to: Programmatically count characters in documents"
description: Learn how you can determine the number of characters in a document by using the Count property of the Characters collection.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "characters, counting in documents"
  - "counting characters in documents"
  - "documents [Office development in Visual Studio], counting characters"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically count characters in documents
  The first character in a document is at character position 0, which represents the insertion point. The last character position is equal to the total number of characters in the document. You can determine the number of characters in a document by using the <xref:Microsoft.Office.Interop.Word.Characters.Count%2A> property of the <xref:Microsoft.Office.Interop.Word.Characters> collection.

 All characters in the document are counted, including spaces, paragraph marks, and other characters that are normally hidden. Even a new, blank document returns a count of one character because it contains a paragraph mark.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## To display the number of characters in a document-level customization

1. Select the entire document.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet98":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet98":::

2. Display the number of characters in the document in a message box.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet99":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet99":::

## To display the number of characters in a VSTO Add-in

1. Select the entire document. The following example selects the active document.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet98":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet98":::

2. Display the number of characters in the document in a message box.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet99":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet99":::

## See also
- [How to: Programmatically retrieve start and end characters in ranges](../vsto/how-to-programmatically-retrieve-start-and-end-characters-in-ranges.md)
- [How to: Programmatically define and select ranges in documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)
