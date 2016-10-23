---
title: "&#39;GoTo&#39; statements are not valid in the Immediate window"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e5901616-6aec-4718-b452-90b2143301b0
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
# &#39;GoTo&#39; statements are not valid in the Immediate window
The `GoTo` statement performs branching and is not permitted in a debugging context.  
  
 **Error ID:** BC30133  
  
### To correct this error  
  
-   Do not issue a `GoTo` statement in the **Immediate** window.  
  
## See Also  
 [Immediate Window](../VS_IDE/Immediate-Window.md)