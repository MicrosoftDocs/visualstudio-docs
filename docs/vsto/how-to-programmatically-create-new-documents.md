---
title: "How to: Programmatically create new documents"
description: Learn how you can programmatically create new documents in Microsoft Word by using Visual Studio.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "templates [Office development in Visual Studio], custom document"
  - "Word [Office development in Visual Studio], creating documents"
  - "documents [Office development in Visual Studio], creating"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically create new documents
  When you create a document programmatically, the new document is a native <xref:Microsoft.Office.Interop.Word.Document> object. This object does not have the additional events and data binding capabilities of a <xref:Microsoft.Office.Tools.Word.Document> host item. For more information, see [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md).

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

 When you develop a document-level project, you cannot programmatically add <xref:Microsoft.Office.Tools.Word.Document> host items to your project. In a VSTO Add-in project, you can convert any <xref:Microsoft.Office.Interop.Word.Document> object to a <xref:Microsoft.Office.Tools.Word.Document> host item at run time. For more information, see [Extend Word documents and Excel workbooks in VSTO Add-ins at run time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).

## To create a new document based on the Normal template

- Use the <xref:Microsoft.Office.Interop.Word.Documents.Add%2A> method of the <xref:Microsoft.Office.Interop.Word.Documents> collection to create a new document based on the Normal template. To use this code example, run it from the `ThisDocument` or `ThisAddIn` class in your project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet1":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet1":::

## Use custom templates
 The <xref:Microsoft.Office.Interop.Word.Documents.Add%2A> method has an optional *Template* argument to create a new document based on a template other than the Normal template. You must supply the file name and fully qualified path of the template.

### To create a new document based on a custom template

- Call the <xref:Microsoft.Office.Interop.Word.Documents.Add%2A> method of the <xref:Microsoft.Office.Interop.Word.Documents> collection and specify the path to the template. To use this code example, run it from the `ThisDocument` or `ThisAddIn` class in your project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet2":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet2":::

## See also
- [How to: Programmatically open existing documents](../vsto/how-to-programmatically-open-existing-documents.md)
- [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md)
- [Programmatic limitations of host items and host controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)
- [Optional parameters in Office solutions](../vsto/optional-parameters-in-office-solutions.md)
