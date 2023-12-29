---
title: "Prepare to debug Windows Forms apps"
description: Take preparation steps to debug Windows Forms applications, which are created by the Windows Forms project template in Visual Studio.
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging Windows applications"
  - "Windows applications, debugging"
  - "debugging [Visual Studio], Windows applications"
  - "debugging [C#], Windows applications"
  - "debugging [Visual Basic], Windows applications"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
---
# Debugging Preparation: Windows Forms Applications

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

The Windows Forms App project template creates a Windows Forms application. Debugging this type of application in Visual Studio is straightforward. For information on creating a project of this type, see [Create a Windows Form App](../ide/create-csharp-winform-visual-studio.md).

 When you create a Windows Forms project with the project template, Visual Studio automatically creates required settings for the Debug and Release configurations. If necessary, you can change these settings. These settings can be changed in the **\<project name> Property Pages** dialog box (**My Project** in Visual Basic).

 For more information, see [Recommended Property Settings](../debugger/managed-debugging-recommended-property-settings.md).

 The following table displays one additional recommended property setting.

### Configuration Properties in Debug tab

|**Property Name**|**Setting**|
|-----------------------|-----------------|
|**Start Action**|-   Set to **Start project,** most of the time. Set to **Start external program** if you want to start another executable when you start debugging (usually for debugging DLLs).|

 You can debug Windows Forms applications from inside Visual Studio, or by attaching to an already running application. For more information about attaching, see [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md).

### To debug a C#, F#, or Visual Basic Windows Forms application

1. Open the project in Visual Studio.

2. Create breakpoints as needed.

    Because Windows Forms applications are event-driven, your breakpoints will go into event handler code, or into methods called by event handler code. Typical events in which to place breakpoints include:

   1. Events associated with a control, such as Click, Enter, etc.

   2. Events associated with application startup and shutdown, such as Load, Activated, etc.

   3. Focus and Validation Events.

      For more information, see [Creating Event Handlers in Windows Forms](/dotnet/framework/winforms/creating-event-handlers-in-windows-forms).

3. On the **Debug** menu, click **Start**.

4. Debug using the techniques discussed in [First look at the debugger](../debugger/debugger-feature-tour.md).

## Related content
- [Debugging Managed Code](../debugger/debugging-managed-code.md)
- [Managed debugging: Recommended project settings](../debugger/managed-debugging-recommended-property-settings.md)
- [How to: Set Debug and Release Configurations](../debugger/how-to-set-debug-and-release-configurations.md)
- [Project Settings for  C# Debug Configurations](../debugger/project-settings-for-csharp-debug-configurations.md)
- [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)
- [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)
- [Windows Forms](/dotnet/framework/winforms/index)