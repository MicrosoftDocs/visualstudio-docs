---
title: "How to: Programmatically restore selections after searches"
description: Learn how you can use Visual Studio to programmatically restore selections after searches in a Microsoft Word document.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "searches, restoring selection after"
  - "documents [Office development in Visual Studio], restoring selections"
  - "selections, restoring after a search"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically restore selections after searches
  If you find and replace text in a document, you might want to restore the user's original selection after the search is completed.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

 The code in the sample procedure makes use of two <xref:Microsoft.Office.Interop.Word.Range> objects. One stores the current <xref:Microsoft.Office.Interop.Word.Selection>, and one sets the entire document to use as a search range.

## To restore the user's original selection after a search

1. Create the <xref:Microsoft.Office.Interop.Word.Range> objects for the document and the current selection.

    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet83":::
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet83":::

2. Perform the search and replace operation.

    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet84":::
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet84":::

3. Select the start range to restore the user's original selection.

    :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet85":::
    :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet85":::

   The following example shows the complete method.

## Example
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet82":::
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet82":::

## See also
- [How to: Programmatically search for and replace text in documents](../vsto/how-to-programmatically-search-for-and-replace-text-in-documents.md)
- [How to: Programmatically set search options in Word](../vsto/how-to-programmatically-set-search-options-in-word.md)
- [How to: Programmatically loop through found items in documents](../vsto/how-to-programmatically-loop-through-found-items-in-documents.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
