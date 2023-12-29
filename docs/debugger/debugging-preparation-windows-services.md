---
title: "Prepare to debug Windows services"
description: Prepare to debug Windows services, which are programs that run in the background under Windows, in Visual Studio.
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
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
---
# Debugging Preparation: Windows Services

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
A Windows service is a program that runs in the background under Microsoft Windows. Examples include the Telnet service and the Windows time service, which updates your computer's visible clock. A Windows service cannot be run from within Visual Studio; it must run within the context of the Services Control Manager. For more information, see [Creating Windows Services](/dotnet/framework/windows-services/how-to-create-windows-services), [Debugging Windows Service Applications](/dotnet/framework/windows-services/how-to-debug-windows-service-applications), and [Windows Service Applications](/dotnet/framework/windows-services/index).

## Related content
- [Debugging Managed Code](../debugger/debugging-managed-code.md)
- [Managed debugging: Recommended project settings](../debugger/managed-debugging-recommended-property-settings.md)
- [Project Settings for  C# Debug Configurations](../debugger/project-settings-for-csharp-debug-configurations.md)
- [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)
- [How to: Debug the OnStart Method](../debugger/how-to-debug-the-onstart-method.md)