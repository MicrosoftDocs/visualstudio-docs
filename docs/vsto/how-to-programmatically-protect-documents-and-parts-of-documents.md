---
title: "How to: Programmatically Protect Documents and Parts of Documents | Microsoft Docs"
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
  - "document protection"
  - "documents [Office development in Visual Studio], document protection"
  - "Word documents, protection"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Protect Documents and Parts of Documents
  You can add protection to Microsoft Office Word documents to prevent users from making any edits to the document.  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
 You can also mark certain areas of the document as exceptions so that specified users can edit only those areas of the document. For example, you might want to protect an entire document except for a particular bookmark. You can optionally add a password so that users cannot remove the document protection unless they know the password.  
  
> [!NOTE]  
>  The following example does not use password protection; however, you might want to consider using a password when adding document protection. For more information, see the Document Protector Sample at [Office Development Samples and Walkthroughs](../vsto/office-development-samples-and-walkthroughs.md).  
  
 You can also use content controls to protect parts of documents. For more information, see [How to: Protect Parts of Documents by Using Content Controls](../vsto/how-to-protect-parts-of-documents-by-using-content-controls.md).  
  
## Protecting a Document That Is Part of a Document-Level Customization  
  
#### To protect a document that is part of a document-level customization  
  
1.  Call the <xref:Microsoft.Office.Tools.Word.Document.Protect%2A> method of the `ThisDocument` class in your project.  
  
     [!code-vb[Trin_VstcoreWordAutomation#111](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#111)]
     [!code-csharp[Trin_VstcoreWordAutomation#111](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#111)]  
  
#### To exclude a bookmark control from document protection  
  
1.  Protect the entire document using the <xref:Microsoft.Office.Tools.Word.Document.Protect%2A> method.  
  
     [!code-vb[Trin_VstcoreWordAutomation#111](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#111)]
     [!code-csharp[Trin_VstcoreWordAutomation#111](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#111)]  
  
2.  Exclude `Bookmark1` from the document protection.  
  
     [!code-vb[Trin_VstcoreWordAutomation#112](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#112)]
     [!code-csharp[Trin_VstcoreWordAutomation#112](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#112)]  
  
### Compiling the Code  
 To use these code examples, run them from the `ThisDocument` class in your project. These code examples assume you have an existing <xref:Microsoft.Office.Tools.Word.Bookmark> control named `Bookmark1` on the document in which this code appears.  
  
## Protecting a Document by Using an VSTO Add-in  
  
#### To protect a document by using an application-level VSTO Add-in  
  
1.  Call the <xref:Microsoft.Office.Interop.Word._Document.Protect%2A> method of the <xref:Microsoft.Office.Interop.Word.Document> that you want to protect.  
  
     The following code example protects the active document. To use this code example, run it from the `ThisAddIn` class in your project.  
  
     [!code-vb[Trin_VstcoreWordAutomationAddIn#111](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#111)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#111](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#111)]  
  
## See Also  
 [Document Protection in Document-Level Solutions](../vsto/document-protection-in-document-level-solutions.md)   
 [Password Protection on Office Documents](../vsto/password-protection-on-office-documents.md)   
 [How to: Permit Code to Run Behind Documents with Restricted Permissions](../vsto/how-to-permit-code-to-run-behind-documents-with-restricted-permissions.md)   
 [How to: Add Bookmark Controls to Word Documents](../vsto/how-to-add-bookmark-controls-to-word-documents.md)   
 [Designing and Creating Office Solutions](../vsto/designing-and-creating-office-solutions.md)  
  
  