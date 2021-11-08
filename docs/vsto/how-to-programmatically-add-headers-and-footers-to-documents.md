---
title: "How to: Programmatically add headers and footers to documents"
description:  Learn how you can add text to headers and footers in your document by using the Headers property and Footers property of the Section.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "headers, adding to Office documents"
  - "documents [Office development in Visual Studio], adding headers"
  - "documents [Office development in Visual Studio], adding footers"
  - "footers, adding to documents"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically add headers and footers to documents
  You can add text to headers and footers in your document by using the <xref:Microsoft.Office.Interop.Word.Section.Headers%2A> property and <xref:Microsoft.Office.Interop.Word.Section.Footers%2A> property of the <xref:Microsoft.Office.Interop.Word.Section>. Each section of a document contains three headers and footers:

- <xref:Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary>

- <xref:Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterEvenPages>

- <xref:Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterFirstPage>

  The procedures are different for document-level customizations and VSTO Add-ins.

  [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## Document-level customizations
 To use the following code examples, run them from the `ThisDocument` class in your project.

### To add text to footers in the document

1. The following code example sets the font of the text to be inserted into the primary footer of each section of the document, and then inserts text into the footer.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet114":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet114":::

### To add text to headers in the document

1. The following code example adds a field to show the page number in each header in the document, and then sets the paragraph alignment so that the text aligns to the right of the header.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet116":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet116":::

## VSTO Add-ins
 To use the following code examples, run them from the `ThisAddIn` class in your project.

### To add text to footers in a document

1. The following code example sets the font of the text to be inserted into the primary footer of each section of the document, and then inserts text into the footer. This code example uses the active document.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet114":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet114":::

### To add text to headers in the document

1. The following code example adds a field to show the page number in each header in the document, and then sets the paragraph alignment so that the text aligns to the right of the header. This code example uses the active document.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet116":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet116":::

## See also
- [How to: Programmatically create new documents](../vsto/how-to-programmatically-create-new-documents.md)
- [How to: Programmatically extend ranges in documents](../vsto/how-to-programmatically-extend-ranges-in-documents.md)
- [How to: Programmatically loop through found items in documents](../vsto/how-to-programmatically-loop-through-found-items-in-documents.md)
