---
title: "MSBuild Error MSB3253"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d4b5eb5b-703b-4b80-aa5d-6c70ff9fe84d
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
# MSBuild Error MSB3253
**MSB3254: The assembly <name\> referenced in the project depends on <name2\> which is not contained in the .NET Framework Client Profile.**  
  
 One of the assemblies, or dependent assemblies, referenced in the project depends on another assembly that is not contained in the .NET Framework Client Profile.  
  
 This message typically occurs when a project references a third-party control or DLL that itself references an external assembly. For example, a project uses a control that in turn uses functionality that is contained in the full .NET Framework. If the application is re-targeted to .NET Framework Client Profile and is installed on a system that does not have .NET Framework 3.5, the application may not work correctly if it tries to access functionality that is not contained in the .NET Framework Client Profile subset.  
  
 This "error" message is actually only a warning; the application will still compile. However, it may fail later if the control or DLL refers to functionality that is located in a missing assembly.  
  
 The .NET Framework Client Profile is a subset of the full .NET Framework 3.5 run-time library. For more information about the .NET Framework Client Profile, see [.NET Framework Client Profile](../Topic/.NET%20Framework%20Client%20Profile.md).  
  
### To correct this error  
  
-   Either remove the specified assembly reference from the project, or target the full .NET Framework instead of the .NET Framework Client Profile subset library. For information about how to target the full .NET Framework, see [How to: Target a Version of the .NET Framework](../VS_IDE/How-to--Target-a-Version-of-the-.NET-Framework.md).  
  
## See Also  
 [Target Framework and Target Platform](../VS_IDE/MSBuild-Target-Framework-and-Target-Platform.md)   
 [Project Element (MSBuild)](../VS_IDE/Project-Element--MSBuild-.md)   
 [Additional Resources](../VS_IDE/Additional-MSBuild-Resources.md)