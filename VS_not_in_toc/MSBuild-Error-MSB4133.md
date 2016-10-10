---
title: "MSBuild Error MSB4133"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5f18937a-fda1-4315-81f9-7cee02802a6d
caps.latest.revision: 7
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
# MSBuild Error MSB4133
**MSB4133: A default tools version "<x.x.>" was specified, but its definition could not be found.**  
  
 MSBuild cannot find the Toolset that is defined in the project file as the `DefaultToolsVersion`.  
  
### To correct this error  
  
-   Make sure that `DefaultToolsVersion` is specified correctly, and that this Toolset is defined either in the registry or in the MSBuild configuration file.  
  
## See Also  
 <xref:Microsoft.Build.BuildEngine.Toolset?qualifyHint=False>   
 [Project Element (MSBuild)](../VS_IDE/Project-Element--MSBuild-.md)   
 [Additional Resources](../VS_IDE/Additional-MSBuild-Resources.md)