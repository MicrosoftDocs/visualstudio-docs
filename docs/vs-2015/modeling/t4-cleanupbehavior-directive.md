---
title: "T4 CleanUpBehavior directive | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9e5a211f-a3bf-4229-bff0-7d2e45b71c64
caps.latest.revision: 4
author: gewarren
ms.author: gewarren
manager: "douge"
---
# T4 CleanUpBehavior directive
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To delete the appDomain after processing a text template, include the following line:  
  
```  
<#@ CleanupBehavior processor="T4VSHost" CleanupAfterProcessingtemplate="true" #>  
```  
  
 Text templates are processed in an appDomain that is separate from the host process. In most cases, when one text template has been processed, the appdomain is used again to process the next template. But if you specify CleanupBehavior, the appDomain is deleted and the next template will be processed in a new appDomain.  
  
 This slows text processing, but can be useful to make sure that resources are disposed.  
  
 This directive works only in the Visual Studio host.



