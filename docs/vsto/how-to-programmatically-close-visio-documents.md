---
title: "How to: Programmatically Close Visio Documents | Microsoft Docs"
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
  - "documents [Office development in Visual Studio], closing Visio documents"
  - "Visio [Office development in Visual Studio], closing Visio documents"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Programmatically Close Visio Documents
  You can close the active Microsoft Office Visio document by using the Microsoft.Office.Interop.Visio.Document.Close method.  
  
 For details about this method, see the VBA reference documentation for the [Microsoft.Office.Interop.Visio.Document.Close](http://msdn.microsoft.com/library/office/ff767415.aspx) method.  
  
## Closing the Active Document  
  
#### To close the active document  
  
-   Call the Microsoft.Office.Interop.Visio.Document.Close method to close the active document.  
  
     To use the following code example, run it in the `ThisAddIn` class in an VSTO Add-in project for Visio.  
  
     [!code-csharp[Trin_VstcoreVisioAutomationAddIn#7](../vsto/codesnippet/CSharp/trin_vstcorevisioautomationaddin/ThisAddIn.cs#7)]
     [!code-vb[Trin_VstcoreVisioAutomationAddIn#7](../vsto/codesnippet/VisualBasic/trin_vstcorevisioautomationaddin/ThisAddIn.vb#7)]  
  
## See Also  
 [Visio Solutions](../vsto/visio-solutions.md)   
 [Visio Object Model Overview](../vsto/visio-object-model-overview.md)   
 [How to: Programmatically Create New Visio Documents](../vsto/how-to-programmatically-create-new-visio-documents.md)   
 [How to: Programmatically Open Visio Documents](../vsto/how-to-programmatically-open-visio-documents.md)   
 [How to: Programmatically Save Visio Documents](../vsto/how-to-programmatically-save-visio-documents.md)   
 [How to: Programmatically Print Visio Documents](../vsto/how-to-programmatically-print-visio-documents.md)  
  
  