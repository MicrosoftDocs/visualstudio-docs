---
title: "Password Protection on Office Documents | Microsoft Docs"
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
  - "permissions [Office development in Visual Studio]"
  - "workbooks [Office development in Visual Studio], restricted permissions"
  - "passwords [Office development in Visual Studio], document protections"
  - "documents [Office development in Visual Studio], restricted permissions"
  - "Office documents [Office development in Visual Studio, restricted permissions"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Password Protection on Office Documents
  It is possible to set a password on your Microsoft Office Word documents and Microsoft Office Excel workbooks so that they cannot be opened by someone who does not know the password. This option is called **Password on Open**.  
  
 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]  
  
 You can create document-level projects using existing documents and workbooks that have **Password on Open** enabled. The behavior in Visual Studio is different for Word and Excel documents that have **Password on Open** enabled.  
  
 For information about enabling **Password on Open**, see Help in Word or Excel.  
  
## Behavior of Excel and Word  
 Every time you open an Excel workbook in Visual Studio that has **Password on Open** enabled, Excel prompts you for the password. When you build your solution you will be prompted for the password again, because the document is opened during build.  
  
 The first time you open a Word document in Visual Studio that has **Password on Open** enabled, Word prompts you for the password. After you successfully enter the password, **Password on Open** is removed from the document and opening the document will no longer require a password. If you want the document in your solution to require a password before it can be opened, you must enable **Password on Open** after your final build and before you deploy the solution.  
  
## See Also  
 [Document Protection in Document-Level Solutions](../vsto/document-protection-in-document-level-solutions.md)   
 [Information Rights Management and Managed Code Extensions Overview](../vsto/information-rights-management-and-managed-code-extensions-overview.md)   
 [How to: Permit Code to Run Behind Documents with Restricted Permissions](../vsto/how-to-permit-code-to-run-behind-documents-with-restricted-permissions.md)   
 [Designing and Creating Office Solutions](../vsto/designing-and-creating-office-solutions.md)  
  
  