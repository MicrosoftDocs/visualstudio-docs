---
title: "Debugging Preparation: Windows Services | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
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
caps.latest.revision: 23
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Debugging Preparation: Windows Services
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

A Windows service is a program that runs in the background under Microsoft Windows. Examples include the Telnet service and the Windows time service, which updates your computer's visible clock. A Windows service cannot be run from within [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]; it must run within the context of the Services Control Manager. For more information, see [Creating Windows Services](https://msdn.microsoft.com/library/0f5e2cbb-d95d-477c-b2b5-4b990e6b86ff), [Debugging Windows Service Applications](https://msdn.microsoft.com/library/63ab0800-0f05-4f1e-88e6-94c73fd920a2), and [Windows Service Applications](https://msdn.microsoft.com/library/ba72d648-9553-4849-b829-069ad5ea014b).  
  
## See Also  
 [Debugging Managed Code](../debugger/debugging-managed-code.md)   
 [C#, F#, and Visual Basic Project Types](../debugger/debugging-preparation-csharp-f-hash-and-visual-basic-project-types.md)   
 [Project Settings for  C# Debug Configurations](../debugger/project-settings-for-csharp-debug-configurations.md)   
 [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)   
 [How to: Debug the OnStart Method](../debugger/how-to-debug-the-onstart-method.md)
