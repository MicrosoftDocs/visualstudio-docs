---
title: Debug in Mixed Mode | Microsoft Docs
description: See how to enable mixed-mode debugging (managed and native code together) in the property pages of the calling app's project.
ms.date: 04/15/2022
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - debugging DLLs
  - debugging [Visual Studio], mixed-mode
  - mixed-mode debugging
ms.assetid: 2859067d-7fcc-46b0-a4df-8c2101500977
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# How to: Debug in mixed mode (C#, C++, Visual Basic)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

The following procedures describe how to enable debugging for managed and native code together, also known as mixed-mode debugging. There are two mixed-mode debugging scenarios:

- The app that calls a DLL is written in native code, and the DLL is managed.

- The app that calls a DLL is written in managed code, and the DLL is in native code. For a tutorial that walks you through this scenario in more detail, see [Debug managed and native code](../debugger/how-to-debug-managed-and-native-code.md).

You can enable both managed and native debuggers in the calling app project's **Property** pages. The settings differ between native and managed apps.

If you don't have access to a calling app's project, you can debug the DLL from the DLL project. You don't need mixed mode to debug just the DLL project. For more information, see [How to: Debug from a DLL project](../debugger/how-to-debug-from-a-dll-project.md).

> [!NOTE]
> The dialog boxes and commands you see might differ from the ones in this article, depending on your Visual Studio settings or edition. To change your settings, choose **Tools** > **Import and Export Settings**. For more information, see [Reset settings](../ide/environment-settings.md#reset-settings).

## Enable mixed-mode debugging for a native calling app

1. Select the C++ project in **Solution Explorer** and click the **Properties** icon, press **Alt**+**Enter**, or right-click and choose **Properties**.

1. In the **\<Project> Property Pages** dialog box, expand **Configuration Properties**, and then select **Debugging**.

1. Set **Debugger Type** to **Mixed** or **Auto**.

1. Select **OK**.

   ![Enable mixed mode debugging in C++](../debugger/media/dbg-mixed-mode-from-native.png "Enable mixed mode debugging")

## Enable mixed-mode debugging for a managed calling app

1. Select the C# or Visual Basic project in **Solution Explorer** and select the **Properties** icon, press **Alt**+**Enter**, or right-click and choose **Properties**.

1. In **Solution Explorer**, select the C# or Visual Basic project node and select the **Properties** icon, or right-click the project node and select **Properties**.

1. Enable native code debugging in the properties.

    ::: moniker range=">=vs-2022"
    For C#, select **Debug** in the left pane, select **Open debug launch profiles UI**, then select the **Enable native code debugging** check box, and then close the properties page to save the changes.
    ![Enable mixed mode debugging in C#](../debugger/media/vs-2022/mixed-mode-enable-native-code-debugging.png)

    For Visual Basic, select **Debug** in the left pane, select the **Enable native code debugging** check box, and then close the properties page to save the changes.

    ![Enable mixed mode debugging in Visual Basic](../debugger/media/mixed-mode-enable-native-code-debugging.png)
    ::: moniker-end
    ::: moniker range="<=vs-2019"
    Select **Debug** in the left pane, select the **Enable native code debugging** check box, and then close the properties page to save the changes.

    ![Enable mixed mode debugging](../debugger/media/mixed-mode-enable-native-code-debugging.png)

    > [!NOTE]
    > For a .NET Core app in Visual Studio 2017 and Visual Studio 2019, you must use the *launchSettings.json* file instead of the project properties to enable mixed-mode debugging.
    ::: moniker-end

## See also

- [How to: Debug from a DLL project](../debugger/how-to-debug-from-a-dll-project.md)