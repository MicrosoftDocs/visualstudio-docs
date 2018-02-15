---
title: "How to: Programmatically Display Documents in Print Preview | Microsoft Docs"
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
  - "Word [Office development in Visual Studio], displaying documents in print preview"
  - "documents [Office development in Visual Studio], displaying in print preview"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Display Documents in Print Preview
  If your solution generates a report, you might want to display the report to the user in Print Preview mode.  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
## Procedures for Document-Level Customizations  
  
#### To display a document in Print Preview by calling the PrintPreview method  
  
1.  Call the <xref:Microsoft.Office.Tools.Word.Document.PrintPreview%2A> method of the <xref:Microsoft.Office.Tools.Word.Document> class. To use this code example, run it from the `ThisDocument` class in your project.  
  
     [!code-vb[Trin_VstcoreWordAutomation#13](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#13)]
     [!code-csharp[Trin_VstcoreWordAutomation#13](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#13)]  
  
#### To display a document in Print Preview by setting the PrintPreview property  
  
1.  Set the <xref:Microsoft.Office.Interop.Word._Application.PrintPreview%2A> property of the <xref:Microsoft.Office.Interop.Word.Application> object to **true**.  
  
     [!code-vb[Trin_VstcoreWordAutomation#14](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#14)]
     [!code-csharp[Trin_VstcoreWordAutomation#14](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#14)]  
  
## Procedures for VSTO Add-ins  
  
#### To display a document in Print Preview by calling the PrintPreview method  
  
1.  Call the <xref:Microsoft.Office.Interop.Word._Document.PrintPreview%2A> method of the <xref:Microsoft.Office.Interop.Word.Document> that you want to preview. To use this code example, run it from the `ThisAddIn` class in your project.  
  
     [!code-vb[Trin_VstcoreWordAutomationAddIn#13](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#13)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#13](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#13)]  
  
#### To display a document in Print Preview by setting the PrintPreview property  
  
1.  Set the <xref:Microsoft.Office.Interop.Word._Application.PrintPreview%2A> property of the <xref:Microsoft.Office.Interop.Word.Application> object to **true**.  
  
     [!code-vb[Trin_VstcoreWordAutomation#14](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#14)]
     [!code-csharp[Trin_VstcoreWordAutomation#14](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#14)]  
  
## See Also  
 [How to: Programmatically Print Documents](../vsto/how-to-programmatically-print-documents.md)   
 [How to: Programmatically Open Existing Documents](../vsto/how-to-programmatically-open-existing-documents.md)   
 [How to: Programmatically Create New Documents](../vsto/how-to-programmatically-create-new-documents.md)  
  
  