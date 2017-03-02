---
title: "Debugging Preparation: Windows Services | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging [Visual Studio], Windows services"
  - "Windows Service applications, debugging"
ms.assetid: ac0a99f7-ec3d-4a20-b17f-698a817fdcc2
caps.latest.revision: 20
author: "mikejo5000"
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
A Windows service is a program that runs in the background under Microsoft Windows. Examples include the Telnet service and the Windows time service, which updates your computer's visible clock. A Windows service cannot be run from within [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]; it must run within the context of the Services Control Manager. For more information, see [Creating Windows Services](http://msdn.microsoft.com/Library/0f5e2cbb-d95d-477c-b2b5-4b990e6b86ff), [Debugging Windows Service Applications](http://msdn.microsoft.com/Library/63ab0800-0f05-4f1e-88e6-94c73fd920a2), and [Windows Service Applications](http://msdn.microsoft.com/Library/ba72d648-9553-4849-b829-069ad5ea014b).  
  
## See Also  
 [Debugging Managed Code](../debugger/debugging-managed-code.md)   
 [C#, F#, and Visual Basic Project Types](../debugger/debugging-preparation-csharp-f-hash-and-visual-basic-project-types.md)   
 [Project Settings for  C# Debug Configurations](../debugger/project-settings-for-csharp-debug-configurations.md)   
 [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)   
 [How to: Debug the OnStart Method](../debugger/how-to-debug-the-onstart-method.md)