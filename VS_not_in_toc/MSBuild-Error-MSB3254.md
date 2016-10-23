---
title: "MSBuild Error MSB3254"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: cb9636b2-d9b3-466d-959c-14c7c8017a78
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
# MSBuild Error MSB3254
**MSB3254: The file <name\> will be ignored because it cannot be read. This file was either passed in to InstalledAssemblySubsetTables or was found by searching the <name\> folder in the TargetFrameworkDirectories.**  
  
 This error occurs when the .NET Framework Client Profile XML file, client.xml, cannot be read. The file is unreadable because of corruption, locking, or some other problem.  
  
 The .NET Framework Client Profile is a subset of the full .NET Framework 3.5 run-time library. For more information about the .NET Framework Client Profile, see [.NET Framework Client Profile](../Topic/.NET%20Framework%20Client%20Profile.md).  
  
 Procedures  
  
### To correct this error  
  
-   Ensure that you have full permissions and full access to the file, or reinstall the .NET Framework Client Profile redistributable run-time library to replace the corrupted file.  
  
## See Also  
 [Project Element (MSBuild)](../VS_IDE/Project-Element--MSBuild-.md)   
 [Additional Resources](../VS_IDE/Additional-MSBuild-Resources.md)