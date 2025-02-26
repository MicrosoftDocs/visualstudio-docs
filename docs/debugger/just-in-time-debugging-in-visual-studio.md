---
title: Disable the Just-In-Time (JIT) Debugger
description: Disable the Just-In-Time Debugger dialog in Visual Studio after errors occur in your application to enable app execution to continue.
ms.date: 12/16/2024
ms.topic: how-to
helpviewer_keywords:
  - debugging [Visual Studio], Just-In-Time
  - Just-In-Time debugging
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics

#customer intent: As a developer, I want to disable the Just-In-Time Debugger dialog in Visual Studio, so I can manually handle errors in my code as app execution continues.
---

# Disable the Just-In-Time Debugger

The Just-In-Time (JIT) Debugger dialog in Visual Studio might open when errors occur in a running application. The dialog can prevent the application from continuing execution.

The JIT Debugger gives you the option to launch Visual Studio to debug the error. To follow through with this action, you must have Visual Studio or another selected debugger installed. The debugger provides detailed information about the error and features to help you resolve the issue.

This article explains how you can prevent the JIT Debugger dialog from interrupting application execution.

## Disable or respond to JIT Debugger

There are different options for how to respond to the JIT Debugger dialog depending on your Visual Studio installation and task scenario.

The following table summarizes your options:

| Configuration | Scenario | Instructions |
| --- | --- | --- |
| Visual Studio installed | Try JIT Debugger | [Debug the error by using the Just-In-Time Debugger](../debugger/debug-using-the-just-in-time-debugger.md) |
| Visual Studio installed | Disable JIT Debugger | [Disable JIT debugging from Visual Studio](debug-using-the-just-in-time-debugger.md#BKMK_Enabling) |
| Visual Studio previously installed, but not currently | Disable JIT Debugger  | [Disable JIT debugging from the Windows registry](debug-using-the-just-in-time-debugger.md#disable-just-in-time-debugging-from-the-windows-registry) |
| Visual Studio never installed | Prevent JIT debugging | Prevent JIT debugging by [disabling script debugging](#disable-script-debugging-for-web-app), [disabling server-side debugging](#disable-server-side-debugging-for-web-app), or by [disabling debugging for ASP.NET applications](/troubleshoot/developer/webapps/aspnet/development/disable-debugging-application). |

## Disable script debugging or server-side debugging

The JIT Debugger dialog might open when your Web app encounters an error, even if your configuration doesn't include Visual Studio. This situation can occur if you never installed Visual Studio, or previously uninstalled Visual Studio. In these scenarios, you can try disabling script debugging or server-side debugging.

### Disable script debugging for Web app

Follow these steps to disable script debugging for a Web app:

1. Open Windows **Control Panel**, and browse to the **Network and Internet** > **Internet Options** page.

1. In the **Internet Properties** dialog, go to the **Advanced** tab.

1. Scroll to the **Browsing** group, and select the **Disable script debugging** option.

   > [!NOTE]
   > Depending on your version of Windows and your browser, you might need to select more than one option.
   
   The following example shows two relevant options selected:

   :::image type="content" source="../debugger/media/just-in-time-internet-options.png" border="false" alt-text="Screenshot that shows how to select 'Disable script debugging' options for Internet Properties in Windows Control Panel.":::

### Disable server-side debugging for Web app

If you're hosting an ASP.NET Web app in Internet Information Services (IIS), disable server-side debugging with these steps:

1. Open IIS Manager, and go to the **Features View**.

1. In the **ASP.NET** section, double-click or select **.NET Compilation**.

   The ASP.NET section option is only present if the .NET features were installed using Server Manager.

1. In the **Actions** pane, select **Open Feature**.

1. For the **Behavior** > **Debug** option, select **False**.

   > [!NOTE]
   > The specific steps are different in older versions of IIS.

## Related content

- [Debug errors with the Just-In-Time Debugger](../debugger/debug-using-the-just-in-time-debugger.md)
- [Disable Just-In-Time debugging from Visual Studio](debug-using-the-just-in-time-debugger.md#BKMK_Enabling)
- [Disable Just-In-Time debugging from the Windows registry](debug-using-the-just-in-time-debugger.md#disable-just-in-time-debugging-from-the-windows-registry)
