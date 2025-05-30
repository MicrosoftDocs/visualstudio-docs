---
title: Debug the OnStart Method of a Windows service
description: Learn how to debug the OnStart method of a Windows service in Visual Studio—by launching the debugger from inside the method. 
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - OnStart method
  - debugging [Visual Studio], Windows services
  - debugging managed code, OnStart method
  - debugging Windows Services applications, OnStart method
  - Windows Service applications, debugging
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debug the OnStart Method

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

    ![Screenshot of a Visual Studio Just-In-Time Debugger dialog box that shows an unhandled .NET Framework exception occurred in WindowsService-Asis.exe.](../debugger/media/onstartdebug.png)

3. Select **Yes, debug \<service name>.**

4. In the Just-In-Time Debugger window, select the version of Visual Studio you want to use for debugging.

    ![Screenshot of a Visual Studio Just-In-Time Debugger window with 'New instance of Microsoft Visual Studio' selected in the list of Possible Debuggers.](../debugger/media/justintimedebugger.png)

5. A new instance of Visual Studio starts, and execution is stopped at the `Debugger.Launch()` method.

## Related content
- [Debugger Security](../debugger/debugger-security.md)
- [Debugging Managed Code](/visualstudio/debugger/)
