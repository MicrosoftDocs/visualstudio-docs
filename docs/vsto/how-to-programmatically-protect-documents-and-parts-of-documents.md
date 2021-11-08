---
title: "Protect documents and parts of documents programmatically"
description: Learn how you can add protection to Microsoft Word documents to prevent users from making any edits to the document.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "document protection"
  - "documents [Office development in Visual Studio], document protection"
  - "Word documents, protection"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Programmatically protect documents and parts of documents
  You can add protection to Microsoft Office Word documents to prevent users from making any edits to the document.

 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]

 You can also mark certain areas of the document as exceptions so that specified users can edit only those areas of the document. For example, you might want to protect an entire document except for a particular bookmark. You can optionally add a password so that users cannot remove the document protection unless they know the password.

> [!NOTE]
> The following example does not use password protection; however, you might want to consider using a password when adding document protection. For more information, see the Document Protector Sample at [Office development samples and walkthroughs](../vsto/office-development-samples-and-walkthroughs.md).

 You can also use content controls to protect parts of documents. For more information, see [How to: Protect parts of documents by using content controls](../vsto/how-to-protect-parts-of-documents-by-using-content-controls.md).

## Protect a document that is part of a document-level customization

### To protect a document that is part of a document-level customization

1. Call the <xref:Microsoft.Office.Tools.Word.Document.Protect%2A> method of the `ThisDocument` class in your project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet111":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet111":::

### To exclude a bookmark control from document protection

1. Protect the entire document using the <xref:Microsoft.Office.Tools.Word.Document.Protect%2A> method.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet111":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet111":::

2. Exclude `Bookmark1` from the document protection.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet112":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet112":::

### Compile the code
 To use these code examples, run them from the `ThisDocument` class in your project. These code examples assume you have an existing <xref:Microsoft.Office.Tools.Word.Bookmark> control named `Bookmark1` on the document in which this code appears.

## Protect a document by using a VSTO Add-in

### To protect a document by using an application-level VSTO Add-in

1. Call the <xref:Microsoft.Office.Interop.Word._Document.Protect%2A> method of the <xref:Microsoft.Office.Interop.Word.Document> that you want to protect.

     The following code example protects the active document. To use this code example, run it from the `ThisAddIn` class in your project.

     :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb" id="Snippet111":::
     :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs" id="Snippet111":::

## See also
- [Document protection in document-level solutions](../vsto/document-protection-in-document-level-solutions.md)
- [Password protection on Office documents](../vsto/password-protection-on-office-documents.md)
- [How to: Permit code to run behind documents with restricted permissions](../vsto/how-to-permit-code-to-run-behind-documents-with-restricted-permissions.md)
- [How to: Add Bookmark controls to Word documents](../vsto/how-to-add-bookmark-controls-to-word-documents.md)
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)
