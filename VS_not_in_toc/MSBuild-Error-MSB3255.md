---
title: "MSBuild Error MSB3255"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: baac844e-a662-4421-bed1-2bc98f2e1cdf
caps.latest.revision: 10
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
# MSBuild Error MSB3255
**MSB3255: Could not find any Target Framework Subset files in the Target Framework Directories or at the locations specified in the InstalledAssemblySubsetTables.**  
  
 This error occurs when a name is passed into the <xref:Microsoft.Build.Tasks.ResolveAssemblyReference.FullTargetFrameworkSubsetNames?qualifyHint=False> property, but a subset with that name cannot be found.  
  
 The .NET Framework Client Profile is a subset of the full .NET Framework 3.5 run-time library. For more information about the .NET Framework Client Profile, see [.NET Framework Client Profile](../Topic/.NET%20Framework%20Client%20Profile.md).  
  
 Procedures  
  
### To correct this error  
  
-   Put a copy of the subset file in the target framework folder or in one of the locations specified in <xref:Microsoft.Build.Tasks.ResolveAssemblyReference.InstalledAssemblySubsetTables?qualifyHint=False>.  
  
## See Also  
 [Project Element (MSBuild)](../VS_IDE/Project-Element--MSBuild-.md)   
 [Additional Resources](../VS_IDE/Additional-MSBuild-Resources.md)