---
title: "How to: Programmatically Create New Documents | Microsoft Docs"
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
  - "templates [Office development in Visual Studio], custom document"
  - "Word [Office development in Visual Studio], creating documents"
  - "documents [Office development in Visual Studio], creating"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Create New Documents
  When you create a document programmatically, the new document is a native <xref:Microsoft.Office.Interop.Word.Document> object. This object does not have the additional events and data binding capabilities of a <xref:Microsoft.Office.Tools.Word.Document> host item. For more information, see [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md).  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
 When you develop a document-level project, you cannot programmatically add <xref:Microsoft.Office.Tools.Word.Document> host items to your project. In a VSTO Add-in project, you can convert any <xref:Microsoft.Office.Interop.Word.Document> object to a <xref:Microsoft.Office.Tools.Word.Document> host item at run time. For more information, see [Extending Word Documents and Excel Workbooks in VSTO Add-ins at Run Time](../vsto/extending-word-documents-and-excel-workbooks-in-vsto-add-ins-at-run-time.md).  
  
### To create a new document based on the Normal template  
  
-   Use the <xref:Microsoft.Office.Interop.Word.Documents.Add%2A> method of the <xref:Microsoft.Office.Interop.Word.Documents> collection to create a new document based on the Normal template. To use this code example, run it from the `ThisDocument` or `ThisAddIn` class in your project.  
  
     [!code-vb[Trin_VstcoreWordAutomation#1](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#1)]
     [!code-csharp[Trin_VstcoreWordAutomation#1](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#1)]  
  
## Using Custom Templates  
 The <xref:Microsoft.Office.Interop.Word.Documents.Add%2A> method has an optional *Template* argument to create a new document based on a template other than the Normal template. You must supply the file name and fully qualified path of the template.  
  
#### To create a new document based on a custom template  
  
-   Call the <xref:Microsoft.Office.Interop.Word.Documents.Add%2A> method of the <xref:Microsoft.Office.Interop.Word.Documents> collection and specify the path to the template. To use this code example, run it from the `ThisDocument` or `ThisAddIn` class in your project.  
  
     [!code-vb[Trin_VstcoreWordAutomation#2](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#2)]
     [!code-csharp[Trin_VstcoreWordAutomation#2](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#2)]  
  
## See Also  
 [How to: Programmatically Open Existing Documents](../vsto/how-to-programmatically-open-existing-documents.md)   
 [Host Items and Host Controls Overview](../vsto/host-items-and-host-controls-overview.md)   
 [Programmatic Limitations of Host Items and Host Controls](../vsto/programmatic-limitations-of-host-items-and-host-controls.md)   
 [Optional Parameters in Office Solutions](../vsto/optional-parameters-in-office-solutions.md)  
  
  