---
title: "How to: Programmatically Check Spelling in Documents | Microsoft Docs"
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
  - "documents [Office development in Visual Studio], checking spelling"
  - "spelling checker, documents"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Check Spelling in Documents
  To check the spelling in a document, use the <xref:Microsoft.Office.Interop.Word._Application.CheckSpelling%2A> method. This method returns a Boolean value that indicates whether the supplied parameter is spelled correctly.  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
### To check spelling and display results in a message box  
  
1.  Call the <xref:Microsoft.Office.Interop.Word._Application.CheckSpelling%2A> method and pass it a range of text to check for spelling errors. To use this code example, run it from the `ThisDocument` or `ThisAddIn` class in your project.  
  
     [!code-vb[Trin_VstcoreWordAutomation#113](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#113)]
     [!code-csharp[Trin_VstcoreWordAutomation#113](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#113)]  
  
## See Also  
 [How to: Programmatically Define and Select Ranges in Documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)   
 [Optional Parameters in Office Solutions](../vsto/optional-parameters-in-office-solutions.md)  
  
  