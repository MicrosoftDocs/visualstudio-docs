---
title: "MSBuild Error MSB3072"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c8468e1c-d8c7-441c-b274-123ac856f147
caps.latest.revision: 6
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
# MSBuild Error MSB3072
**The "Exec" task needs a command to execute.**  
  
 The attribute `Command` is a required attribute for the `Exec` task.  
  
### To correct this error  
  
1.  In the project file, specify the attribute `Command` for the `Exec` task.  
  
## See Also  
 [Exec Task](../VS_IDE/Exec-Task.md)   
 [Tasks](../VS_IDE/MSBuild-Tasks.md)