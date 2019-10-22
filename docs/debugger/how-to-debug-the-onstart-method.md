---
title: "How to: Debug the OnStart Method | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "OnStart method"
  - "debugging [Visual Studio], Windows services"
  - "debugging managed code, OnStart method"
  - "debugging Windows Services applications, OnStart method"
  - "Windows Service applications, debugging"
ms.assetid: b06b5d65-424b-490f-bf58-97583cd7006a
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Debug the OnStart Method
You can debug a Windows service by starting the service and attaching the debugger to the service process. For more information, see [How to: Debug Windows Service Applications](/dotnet/framework/windows-services/how-to-debug-windows-service-applications). However, to debug the <xref:System.ServiceProcess.ServiceBase.OnStart%2A?displayProperty=fullName> method of a Windows service, you must launch the debugger from inside the method.

1. Add a call to <xref:System.Diagnostics.Debugger.Launch%2A> at the beginning of the `OnStart()`method.

    ```csharp
    protected override void OnStart(string[] args)
    {
        System.Diagnostics.Debugger.Launch();
    }
    ```

2. Start the service (you can use `net start`, or start it in the **Services** window).

    You should see a dialog box like the following:

    ![OnStartDebug](../debugger/media/onstartdebug.png "OnStartDebug")

3. Select **Yes, debug \<service name>.**

4. In the Just-In-Time Debugger window, select the version of Visual Studio you want to use for debugging.

    ![JustInTimeDebugger](../debugger/media/justintimedebugger.png "JustInTimeDebugger")

5. A new instance of Visual Studio starts, and execution is stopped at the `Debugger.Launch()` method.

## See also
- [Debugger Security](../debugger/debugger-security.md)
- [Debugging Managed Code](../debugger/debugging-managed-code.md)
