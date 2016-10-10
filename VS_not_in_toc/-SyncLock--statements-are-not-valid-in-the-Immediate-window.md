---
title: "&#39;SyncLock&#39; statements are not valid in the Immediate window"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 099771a1-5bf4-4c16-8fc3-262926c771df
caps.latest.revision: 9
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
# &#39;SyncLock&#39; statements are not valid in the Immediate window
The `SyncLock` statement synchronizes threads and is not permitted in a debugging context.  
  
 **Error ID:** BC30135  
  
### To correct this error  
  
-   Do not issue a `SyncLock` statement in the **Immediate** window.  
  
## See Also  
 [Immediate Window](../VS_IDE/Immediate-Window.md)   
 [SyncLock Statement](../Topic/SyncLock%20Statement.md)