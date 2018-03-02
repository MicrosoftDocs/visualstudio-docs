---
title: "How to: Programmatically Add Comments to Text in Documents | Microsoft Docs"
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
  - "comments, adding to documents"
  - "documents [Office development in Visual Studio], adding comments"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Add Comments to Text in Documents
  The Comments property of the Document class adds a comment to a range of text in a Microsoft Office Word document.  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
 The following example adds a comment to the first paragraph in the document.  
  
### To add a new comment to text in a document-level customization  
  
1.  Call the <xref:Microsoft.Office.Interop.Word.Comments.Add%2A> method of the <xref:Microsoft.Office.Tools.Word.Document.Comments%2A> property and supply a range and the comment text. To use the following code example, run it from the `ThisDocument` class in your project.  
  
     [!code-vb[Trin_VstcoreWordAutomation#118](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#118)]
     [!code-csharp[Trin_VstcoreWordAutomation#118](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#118)]  
  
### To add a new comment to text in an VSTO Add-in  
  
1.  Call the <xref:Microsoft.Office.Interop.Word.Comments.Add%2A> method of the <xref:Microsoft.Office.Interop.Word._Document.Comments%2A> property and supply a range and the comment text.  
  
     The following code example adds a comment to the active document. To use this example, run it from the `ThisAddIn` class in your project.  
  
     [!code-vb[Trin_VstcoreWordAutomationAddIn#118](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#118)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#118](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#118)]  
  
## Robust Programming  
 To change the user initials that Word adds to comments, use the <xref:Microsoft.Office.Interop.Word._Application.UserInitials%2A> property.  
  
## See Also  
 [How to: Programmatically Remove All Comments from Documents](../vsto/how-to-programmatically-remove-all-comments-from-documents.md)   
 [Document Host Item](../vsto/document-host-item.md)  
  
  