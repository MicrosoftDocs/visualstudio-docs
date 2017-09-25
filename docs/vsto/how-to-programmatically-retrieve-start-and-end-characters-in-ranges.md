---
title: "How to: Programmatically Retrieve Start and End Characters in Ranges | Microsoft Docs"
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
  - "ranges, retrieving start and end characters"
  - "end characters"
  - "start characters"
  - "documents [Office development in Visual Studio], retrieving ranges"
ms.assetid: 734c630c-abc9-491d-94b6-429d1fc7a4cc
caps.latest.revision: 37
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
---
# How to: Programmatically Retrieve Start and End Characters in Ranges
  This example demonstrates how you can retrieve the character positions of the start and end positions of a range.  
  
 [!INCLUDE[appliesto_wdalldocapp](../vsto/includes/appliesto-wdalldocapp-md.md)]  
  
### To retrieve start and end characters of a range in a document-level customization  
  
1.  Get the values of the <xref:Microsoft.Office.Interop.Word.Range.Start%2A> and <xref:Microsoft.Office.Interop.Word.Range.End%2A> properties of the <xref:Microsoft.Office.Interop.Word.Range> object. The following code example gets the start and end position of the second sentence in the document. To use this code example, run it from the `ThisDocument` class in your project.  
  
     [!code-vb[Trin_VstcoreWordAutomation#25](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb#25)]
     [!code-csharp[Trin_VstcoreWordAutomation#25](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs#25)]  
  
### To retrieve start and end characters of a range by using an VSTO Add-in  
  
1.  Get the values of the <xref:Microsoft.Office.Interop.Word.Range.Start%2A> and <xref:Microsoft.Office.Interop.Word.Range.End%2A> properties of the <xref:Microsoft.Office.Interop.Word.Range> object. The following code example gets the start and end position of the second sentence in the active document. To use this code example, run it from the `ThisAddIn` class in your project.  
  
     [!code-vb[Trin_VstcoreWordAutomationAddIn#25](../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationAddIn/ThisAddIn.vb#25)]
     [!code-csharp[Trin_VstcoreWordAutomationAddIn#25](../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationAddIn/ThisAddIn.cs#25)]  
  
## See Also  
 [How to: Programmatically Define and Select Ranges in Documents](../vsto/how-to-programmatically-define-and-select-ranges-in-documents.md)   
 [How to: Programmatically Extend Ranges in Documents](../vsto/how-to-programmatically-extend-ranges-in-documents.md)   
 [How to: Programmatically Reset Ranges in Word Documents](../vsto/how-to-programmatically-reset-ranges-in-word-documents.md)   
 [How to: Programmatically Collapse Ranges or Selections in Documents](../vsto/how-to-programmatically-collapse-ranges-or-selections-in-documents.md)   
 [How to: Programmatically Exclude Paragraph Marks When Creating Ranges](../vsto/how-to-programmatically-exclude-paragraph-marks-when-creating-ranges.md)   
 [How to: Programmatically Count Characters in Documents](../vsto/how-to-programmatically-count-characters-in-documents.md)  
  
  