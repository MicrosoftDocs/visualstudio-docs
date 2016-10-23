---
title: "Troubleshooting Exceptions: System.CannotUnloadAppDomainException"
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
ms.assetid: eeee07c3-fdbc-4c91-859b-a419d23be9ba
caps.latest.revision: 17
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
# Troubleshooting Exceptions: System.CannotUnloadAppDomainException
A <xref:System.CannotUnloadAppDomainException?qualifyHint=False> exception is thrown when there is an attempt to unload one of the following:  
  
-   The default application domain, which must remain loaded throughout the lifetime of the application  
  
-   An application domain with a running thread that cannot stop execution immediately  
  
-   An application domain that has already been unloaded  
  
## Associated Tips  
 **Make sure you are not trying to unload the application domain that is the default, has a running thread, or that has already been unloaded.**  
 Any of these conditions will cause this exception to be thrown. For more information, see <xref:System.AppDomain.Unload?qualifyHint=False>.  
  
## See Also  
 <xref:System.CannotUnloadAppDomainException?qualifyHint=False>   
 [Use the Exception Assistant](../Topic/How%20to:%20Use%20the%20Exception%20Assistant.md)