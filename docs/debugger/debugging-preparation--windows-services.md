---
title: "Debugging Preparation: Windows Services"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "debugging [Visual Studio], Windows services"
  - "Windows Service applications, debugging"
ms.assetid: ac0a99f7-ec3d-4a20-b17f-698a817fdcc2
caps.latest.revision: 20
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Debugging Preparation: Windows Services
A Windows service is a program that runs in the background under Microsoft Windows. Examples include the Telnet service and the Windows time service, which updates your computer's visible clock. A Windows service cannot be run from within [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)]; it must run within the context of the Services Control Manager. For more information, see [Creating Windows Services](../Topic/How%20to:%20Create%20Windows%20Services.md), [Debugging Windows Service Applications](../Topic/How%20to:%20Debug%20Windows%20Service%20Applications.md), and [Windows Service Applications](../Topic/Developing%20Windows%20Service%20Applications.md).  
  
## See Also  
 [Debugging Managed Code](../debugger/debugging-managed-code.md)   
 [C#, F#, and Visual Basic Project Types](../debugger/debugging-preparation--csharp--fsharp--and-visual-basic-project-types.md)   
 [Project Settings for  C# Debug Configurations](../debugger/project-settings-for--csharp-debug-configurations.md)   
 [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)   
 [How to: Debug the OnStart Method](../debugger/how-to--debug-the-onstart-method.md)