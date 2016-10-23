---
title: "Events cannot have a return type"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4cd3bffc-b5b2-4000-bfb9-7d6968e6fc62
caps.latest.revision: 8
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
# Events cannot have a return type
Events can accept arguments but cannot directly return values.  
  
 **Error ID:** BC30032  
  
### To correct this error  
  
-   Remove the return type from the `Event` statement.  
  
## See Also  
 [Event Statement](../Topic/Event%20Statement.md)