---
title: "Using Office Functionality Inside of Visual Studio | Microsoft Docs"
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
  - "security [Office development in Visual Studio], document protection"
  - "Office applications [Office development in Visual Studio]"
  - "Office functionality inside Visual Studio"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Using Office Functionality Inside of Visual Studio
  When you create a document-level project, the document and the associated application are hosted inside Visual Studio so you can design and work directly with the document. When you have a Microsoft Office application open in Visual Studio, it generally works as expected. However, some of the application's functionality is different or inaccessible.  
  
 [!INCLUDE[appliesto_alldoc](../vsto/includes/appliesto-alldoc-md.md)]  
  
## Document Protection  
 Microsoft Office Word and Microsoft Office Excel offer document protection features that you can use in your projects. However, if document protection is enabled while the document is open in Visual Studio, it can prevent you from making some design changes. For more information, see [Document Protection in Document-Level Solutions](../vsto/document-protection-in-document-level-solutions.md).  
  
## Information Rights Management  
 Information Rights Management (IRM) is available in Microsoft Office Word and Microsoft Office Excel. IRM can help you prevent unauthorized people from viewing or altering sensitive information. However, IRM can also prevent your code from running. For more information, see [Information Rights Management and Managed Code Extensions Overview](../vsto/information-rights-management-and-managed-code-extensions-overview.md).  
  
## Password Protection  
 Microsoft Office Word documents and Microsoft Office Excel workbooks can be set so that they cannot be opened by someone who does not know the password. Password protection is handled differently in Word and Excel, and can affect your development process. For more information, see [Password Protection on Office Documents](../vsto/password-protection-on-office-documents.md).  
  
## See Also  
 [Document Protection in Document-Level Solutions](../vsto/document-protection-in-document-level-solutions.md)   
 [Information Rights Management and Managed Code Extensions Overview](../vsto/information-rights-management-and-managed-code-extensions-overview.md)   
 [Password Protection on Office Documents](../vsto/password-protection-on-office-documents.md)   
 [How to: Open Office Solutions without Running Code](../vsto/how-to-open-office-solutions-without-running-code.md)  
  
  