---
title: "MSBuild Error MSB3252"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4e6982b8-84b3-4d21-94e1-05cc10bf1393
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
# MSBuild Error MSB3252
**MSB3252: The project has a reference to assembly <name\>. This assembly is not part of the .NET Framework Client Profile.  By not having this reference there may be compile or runtime errors.**  
  
 A call was made to a member in an assembly, or dependent assembly, that is not part of the .NET Framework Client Profile. Therefore, the call cannot be resolved and the application cannot be compiled.  
  
 For more information about the .NET Framework Client Profile, see [.NET Framework Client Profile](../Topic/.NET%20Framework%20Client%20Profile.md).  
  
### To correct this error  
  
-   Either remove the specified assembly reference from your project, or target the full .NET Framework instead of the .NET Framework Client Profile subset library. For information about how to target the full .NET Framework, see [How to: Target a Version of the .NET Framework](../VS_IDE/How-to--Target-a-Version-of-the-.NET-Framework.md).  
  
## See Also  
 [Target Framework and Target Platform](../VS_IDE/MSBuild-Target-Framework-and-Target-Platform.md)   
 [Project Element (MSBuild)](../VS_IDE/Project-Element--MSBuild-.md)   
 [Additional Resources](../VS_IDE/Additional-MSBuild-Resources.md)