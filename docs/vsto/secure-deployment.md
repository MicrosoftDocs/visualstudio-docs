---
title: "Secure Deployment | Microsoft Docs"
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
  - "deploying applications [Office development in Visual Studio], security"
  - "Office development in Visual Studio, security"
  - "Office applications [Office development in Visual Studio], security"
  - "ClickOnce deployment [Office development in Visual Studio], security"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Secure Deployment
  When you create an Office solution, your development computer is updated automatically to allow the code in your project to run. However, when you deploy your solution, you must provide evidence on which to base a trust decision by signing the solution with a certificate, or using the [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] trust prompt key. For more information, see [Granting Trust to Office Solutions](../vsto/granting-trust-to-office-solutions.md).  
  
 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]  
  
 For document-level customizations, if you deploy the document to a network location, you must also add the document's location to the list of trusted locations in the Trust Center of the Office application. For more information about how to set document permissions on end user computers, see [Granting Trust to Documents](../vsto/granting-trust-to-documents.md).  
  
## Preventing Office Solutions from Running Code  
 Administrators can use the registry to prevent all Office solutions from running on a computer. When an Office solution that has managed code extensions is opened, the Visual Studio Tools for Office runtime checks whether an entry with the name `Disabled` exists under one of the following registry keys on the computer:  
  
-   `HKEY_CURRENT_USER\Software\Microsoft\VSTO`  
  
-   `HKEY_LOCAL_MACHINE\Software\Microsoft\VSTO`  
  
 To prevent Office solutions from running code, create a `Disabled` entry under one or both of these registry keys, and specify one of the following data types and values for `Disabled`:  
  
-   A REG_SZ or REG_EXPAND_SZ that is set to any string other than "0" (zero).  
  
-   A REG_DWORD that is set to any value other than 0 (zero).  
  
 To enable Office solutions to run code, set both of the `Disabled` entries to 0 (zero), or delete the registry entries.  
  
## See Also  
 [Deploying an Office Solution](../vsto/deploying-an-office-solution.md)   
 [Preparing Computers to Run or Host Office Solutions](http://msdn.microsoft.com/en-us/be1b173f-7261-4d74-aa4e-94ccd43db8d8)   
 [Securing Office Solutions](../vsto/securing-office-solutions.md)  
  
  