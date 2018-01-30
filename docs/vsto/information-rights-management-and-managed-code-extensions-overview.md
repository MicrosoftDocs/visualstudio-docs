---
title: "Information Rights Management and Managed Code Extensions Overview | Microsoft Docs"
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
  - "Information Rights Management [Office development in Visual Studio]"
  - "workbooks [Office development in Visual Studio], restricted permissions"
  - "IRM [Office development in Visual Studio]"
  - "documents [Office development in Visual Studio], restricted permissions"
  - "rights management [Office development in Visual Studio]"
  - "Office documents [Office development in Visual Studio, restricted permissions"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Information Rights Management and Managed Code Extensions Overview
  Microsoft Office Word and Microsoft Office Excel provide Information Rights Management (IRM), a feature that can help you prevent unauthorized people from viewing or altering sensitive information. For details about how Information Rights Management works, see Help in the specific Office application.  
  
 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]  
  
## Running Code Behind Documents with Restricted Permissions  
 If your solution contains a document or workbook that uses IRM, by default, Word and Excel do not permit any code to run. If you are the author of the document or have Full Control access, you can change the default so that your solution works. For more information, see [How to: Permit Code to Run Behind Documents with Restricted Permissions](../vsto/how-to-permit-code-to-run-behind-documents-with-restricted-permissions.md).  
  
 IRM prevents use of <xref:Microsoft.VisualStudio.Tools.Applications.Runtime.ServerDocument> to retrieve or manipulate data that is cached in the document.  
  
## End Users Restricting Permissions to Documents That Use Managed Code Extensions  
 Anyone who has Full Control access to the document or workbook in your solution can use IRM to restrict permissions. For example, if an end user in the accounting department uses a solution that automatically populates a worksheet with data from a database, that user might want to allow Change access only to people in his or her department and Read access to others. When the user adds the restricted permissions, by default, the code behind the worksheet cannot run, and the worksheet will not be populated with data.  
  
 To fix the problem, someone with Full Control access to the document or workbook must change the default permission settings to allow programmatic access to the object model. For more information, see [How to: Permit Code to Run Behind Documents with Restricted Permissions](../vsto/how-to-permit-code-to-run-behind-documents-with-restricted-permissions.md).  
  
## See Also  
 [Document Protection in Document-Level Solutions](../vsto/document-protection-in-document-level-solutions.md)   
 [Password Protection on Office Documents](../vsto/password-protection-on-office-documents.md)   
 [Securing Office Solutions](../vsto/securing-office-solutions.md)   
 [Deploying an Office Solution](../vsto/deploying-an-office-solution.md)   
 [Designing and Creating Office Solutions](../vsto/designing-and-creating-office-solutions.md)  
  
  