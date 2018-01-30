---
title: "The workbook used to create this project contains ActiveX controls that the designer cannot load | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VST.SelectDocWizard.ContainsActiveXControls"
dev_langs: 
  - "VB"
  - "CSharp"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# The workbook used to create this project contains ActiveX controls that the designer cannot load
  This error appears when you add a control to a Word document or an Excel worksheet programmatically, save the document or workbook, and then create a new document-level solution based on the document or workbook.  
  
 Information that describes the managed type of the control is not saved along with the document or workbook. When you create a new solution based on that document or workbook, Visual Studio does not have enough information to load the control in the host item designer.  
  
### To correct this error  
  
1.  Open the document or workbook.  
  
2.  Remove the controls that were added at run time. You can do this by selecting them in the document or workbook and pressing the DELETE key.  
  
3.  Create a document-level solution based on the document or workbook.  
  
## See Also  
 [How to: Create Office Projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)   
 [Adding Controls to Office Documents at Run Time](../vsto/adding-controls-to-office-documents-at-run-time.md)  
  
  