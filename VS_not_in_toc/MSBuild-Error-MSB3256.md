---
title: "MSBuild Error MSB3256"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 809ccd0a-78cd-4bf5-83a8-2fb51815ea27
caps.latest.revision: 11
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
# MSBuild Error MSB3256
**MSB3256: No assemblies were read in from the redist lists. A TargetFramework subset exclusion list could not be generated.**  
  
 A list of redistributable items (redist list) could not be found.  
  
 To generate a list of assemblies to exclude from the .NET Framework subset, two files are required: a "redist list" named FrameworkList.xml, which contains the names of redistributable items in the .NET Framework, and a "subset list" named client.xml, which contains the names of items in the .NET Framework. Because the subset definition requires both lists, if the redist list is missing, then the .NET Framework subset cannot be targeted.  
  
 The .NET Framework Client Profile is a subset of the full .NET Framework 3.5 run-time library. For more information about the .NET Framework Client Profile, see [.NET Framework Client Profile](../Topic/.NET%20Framework%20Client%20Profile.md).  
  
### To correct this error  
  
-   Either provide a valid redist list named FrameworkList.xml, or target the full .NET Framework 3.5 redistributable library. For information about how to target the full .NET Framework, see [How to: Target a Version of the .NET Framework](../VS_IDE/How-to--Target-a-Version-of-the-.NET-Framework.md).  
  
## See Also  
 [Target Framework and Target Platform](../VS_IDE/MSBuild-Target-Framework-and-Target-Platform.md)   
 [Project Element (MSBuild)](../VS_IDE/Project-Element--MSBuild-.md)   
 [Additional Resources](../VS_IDE/Additional-MSBuild-Resources.md)