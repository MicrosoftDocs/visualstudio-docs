---
title: "Programmatically display documents in Print Preview"
description: Learn how you can programmatically display documents in Print Preview in a Microsoft Word document.
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Word [Office development in Visual Studio], displaying documents in print preview"
  - "documents [Office development in Visual Studio], displaying in print preview"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Programmatically display documents in Print Preview

  If your solution generates a report, you might want to display the report to the user in Print Preview mode.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

## Procedures for document-level customizations

### To display a document in Print Preview by calling the PrintPreview method

1. Call the <xref:Microsoft.Office.Tools.Word.Document.PrintPreview%2A> method of the <xref:Microsoft.Office.Tools.Word.Document> class. To use this code example, run it from the `ThisDocument` class in your project.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet13":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet13":::
     ---

### To display a document in Print Preview by setting the PrintPreview property

1. Set the <xref:Microsoft.Office.Interop.Word._Application.PrintPreview%2A> property of the <xref:Microsoft.Office.Interop.Word.Application> object to **true**.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet14":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet14":::
     ---

## Procedures for VSTO Add-ins

### To display a document in Print Preview by calling the PrintPreview method

1. Call the <xref:Microsoft.Office.Interop.Word._Document.PrintPreview%2A> method of the <xref:Microsoft.Office.Interop.Word.Document> that you want to preview. To use this code example, run it from the `ThisAddIn` class in your project.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet13":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet13":::
     ---

### To display a document in Print Preview by setting the PrintPreview property

1. Set the <xref:Microsoft.Office.Interop.Word._Application.PrintPreview%2A> property of the <xref:Microsoft.Office.Interop.Word.Application> object to **true**.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet14":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet14":::
     ---

## Related content
- [How to: Programmatically print documents](../vsto/how-to-programmatically-print-documents.md)
- [How to: Programmatically open existing documents](../vsto/how-to-programmatically-open-existing-documents.md)
- [How to: Programmatically create new documents](../vsto/how-to-programmatically-create-new-documents.md)
