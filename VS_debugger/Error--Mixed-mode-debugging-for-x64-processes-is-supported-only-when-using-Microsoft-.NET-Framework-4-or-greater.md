---
title: "Error: Mixed-mode debugging for x64 processes is supported only when using Microsoft .NET Framework 4 or greater"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e4b0216c-7006-4832-883f-08e982ba8d3f
caps.latest.revision: 8
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Error: Mixed-mode debugging for x64 processes is supported only when using Microsoft .NET Framework 4 or greater
To debug mixed native and managed code in a 64-bit process, you must have .NET Framework version 4. Mixed-mode debugging of 64-bit processes with .NET Framework versions earlier than 4 is not supported.  
  
### To correct this error  
  
-   Perform one of the following steps:  
  
    -   Upgrade your .NET Framework to version 4.  
  
    -   Build a 32-bit version of your application for debugging.  
  
## See Also  
 [Set Up the Remote Tools on the Device](../Topic/Set%20Up%20the%20Remote%20Tools%20on%20the%20Device.md)