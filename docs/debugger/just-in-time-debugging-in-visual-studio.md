---
title: "Disable the Just-In-Time Debugger | Microsoft Docs"
description: The Just-In-Time Debugger dialog box may open when an error occurs in an app. Learn what you can do when this happens, and ways to prevent it.
ms.custom: SEO-VS-2020
ms.date: "08/24/2021"
ms.topic: "how-to"
helpviewer_keywords:
  - "debugging [Visual Studio], Just-In-Time"
  - "Just-In-Time debugging"
ms.assetid: 14972d5f-69bc-479b-9529-03b8787b118f
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Disable the Just-In-Time Debugger

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

The Just-In-Time Debugger dialog box may open when an error occurs in a running app, and prevent the app from continuing.

The Just-In-Time Debugger gives you the option to launch Visual Studio to debug the error. You must have Visual Studio or another selected debugger installed to view detailed information about the error or try to debug it.

If you're already a Visual Studio user and want to try to debug the error, see [Debug using the Just-In-Time Debugger](../debugger/debug-using-the-just-in-time-debugger.md). If you can't fix the error, or want to keep the Just-In-Time Debugger from opening, you can [disable Just-In-Time debugging from Visual Studio](debug-using-the-just-in-time-debugger.md#BKMK_Enabling).

If you had Visual Studio installed but no longer do, you may need to [disable Just-In-Time debugging from the Windows registry](debug-using-the-just-in-time-debugger.md#disable-just-in-time-debugging-from-the-windows-registry).

If you don't have Visual Studio installed, you can prevent Just-In-Time debugging by disabling script debugging or server-side debugging.

- If you're trying to run a web app, disable script debugging:

  In Windows **Control Panel** > **Network and Internet** > **Internet Options**, select **Disable script debugging (Internet Explorer)** and **Disable script debugging (other)**. The exact steps and settings depend on your version of Windows and your browser.

  ![JIT Internet Options](../debugger/media/jitinternetoptions.png "JIT internet options")

- If you're hosting an ASP.NET web app in IIS, disable server-side debugging:

  1. In IIS Manager **Features View**, under the **ASP.NET** section, double-click **.NET Compilation**, or select it and then select **Open Feature** in the **Actions** pane.
  1. Under **Behavior** > **Debug**, select **False**. The steps are different in older versions of IIS.

After you disable Just-In-Time debugging, the app may be able to handle the error and run normally.

If the app still has an unhandled error, you may see an error message, or the app may crash or stop responding. The app won't run normally until the error is fixed. You can try to contact the owner of the app and ask them to fix it.
