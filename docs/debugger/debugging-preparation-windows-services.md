---
title: "Prepare to debug Windows services | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging [Visual Studio], Windows services"
  - "Windows Service applications, debugging"
ms.assetid: ac0a99f7-ec3d-4a20-b17f-698a817fdcc2
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Debugging Preparation: Windows Services
A Windows service is a program that runs in the background under Microsoft Windows. Examples include the Telnet service and the Windows time service, which updates your computer's visible clock. A Windows service cannot be run from within [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]; it must run within the context of the Services Control Manager. For more information, see [Creating Windows Services](/dotnet/framework/windows-services/how-to-create-windows-services), [Debugging Windows Service Applications](/dotnet/framework/windows-services/how-to-debug-windows-service-applications), and [Windows Service Applications](/dotnet/framework/windows-services/index).

## See also
- [Debugging Managed Code](../debugger/debugging-managed-code.md)
- [C#, F#, and Visual Basic Project Types](../debugger/debugging-preparation-csharp-f-hash-and-visual-basic-project-types.md)
- [Project Settings for  C# Debug Configurations](../debugger/project-settings-for-csharp-debug-configurations.md)
- [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)
- [How to: Debug the OnStart Method](../debugger/how-to-debug-the-onstart-method.md)