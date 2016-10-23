---
title: "MSBuild Error MSB4132"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4ac265a7-0f8d-4fec-ba6e-cd70cbd5d89e
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
# MSBuild Error MSB4132
**MSB4132: The tools version "'<version\>'" is unrecognized.**  
  
 MSBuild could find a Toolset that corresponds to the specified value of `ToolsVersion`.  
  
### To correct this error  
  
-   Specify a valid value for `ToolsVersion` in the project tag, or on the command line when you use the MSBuild **/ToolsVersion** switch.  
  
## See Also  
 <xref:Microsoft.Build.Tasks.MSBuild.ToolsVersion?qualifyHint=False>   
 [Additional Resources](../VS_IDE/Additional-MSBuild-Resources.md)