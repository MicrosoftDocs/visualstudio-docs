---
title: "Respond to the Just-In-Time Debugger | Microsoft Docs"
ms.custom: ""
ms.date: "05/23/18"
ms.technology: "vs-ide-debug"
ms.topic: "troubleshooting"
helpviewer_keywords:
  - "debugging [Visual Studio], Just-In-Time"
  - "Just-In-Time debugging"
ms.assetid: 14972d5f-69bc-479b-9529-03b8787b118f
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload:
  - "multiple"
---
# Respond to the Just-In-Time Debugger 

The Just-in-Time Debugger may appear when an error occurs in a running app, and prevent the app from continuing. 

The Just-in-Time Debugger tries to launch Visual Studio to debug the error. You must have [Visual Studio](http://visualstudio.microsoft.com) installed to view detailed information about the error or try to debug it. 

If you're a Visual Studio user and want to try to debug the error, see [Debug using the Just-In-Time Debugger](../debugger/debug-using-the-just-in-time-debugger.md) and [Debugger basics](../debugger/getting-started-with-the-debugger.md) for instructions. If you can't fix the error, you can try to ask the owner of the app to resolve the issue.

If you have Visual Studio installed or had it installed previously, but don't want the Just-in-Time debugger to appear, you can [disable Just-in-Time debugging](../debugger/debug-using-the-just-in-time-debugger.md) in Visual Studio and try to run the app again. The app may handle the error and let you run it normally.

> [!IMPORTANT]
> If you disable Just-in-Time debugging and the app encounters an unhandled exception (an error), you'll either see a standard error dialog box, or the app will crash or hang. The app won't run normally until the error is fixed.

If you don't have Visual Studio installed, you can stop the Just-In-Time Debugger from appearing. The app may then handle the error and let you run it normally. 

- If you're trying to run a web app, disable script debugging.
  
  1. To disable script debugging, select **Disable script debugging (Internet Explorer)** and **Disable script debugging (other)** in **Control Panel** > **Network and Internet** > **Internet Options**. The exact steps and settings depend on your version of Windows and your browser.
     
     ![JIT Internet Options](../debugger/media/jitinternetoptions.png "JIT internet options")
  
  1. Reopen the web page that had the error. If you still can't run the app, you can try to ask the owner of the app to fix the issue.

- If you're hosting an ASP.NET web app in IIS, disable server-side debugging.

  1. In IIS Manager **Features View**, under the **ASP.NET** section, double-click **.NET Compilation**, or select it and then select **Open Feature** in the **Actions** pane. 
  1. Under **Behavior** > **Debug**, select **False**. The steps are different in older versions of IIS.

