---
title: "Troubleshooting Exceptions: System.Security.VerificationException"
ms.custom: na
ms.date: 10/01/2016
ms.devlang: 
  - JScript
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b7b1a4c2-6769-46bd-8912-ebbfe226bfb3
caps.latest.revision: 15
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Troubleshooting Exceptions: System.Security.VerificationException
A <xref:System.Security.VerificationException?qualifyHint=False> exception is thrown when the security policy requires code to be type-safe and the verification process is unable to verify that the code is type-safe.  
  
## Associated Tips  
 Make sure your application is not loading two conflicting versions of a class library.  
 As part of the verification process, MSIL (Microsoft intermediate language) is checked for type safety to ensure that objects are safely isolated from each other and are therefore safe from accidental or malicious corruption. For more information, see [Type Safety and Security](assetId:///095cd1f6-d8db-4c0e-bce2-83ccb34dd5dc).  
  
## See Also  
 <xref:System.Security.VerificationException?qualifyHint=False>   
 <xref:System.Security.Permissions.SecurityPermissionAttribute.SkipVerification?qualifyHint=False>   
 [Use the Exception Assistant](../Topic/How%20to:%20Use%20the%20Exception%20Assistant.md)