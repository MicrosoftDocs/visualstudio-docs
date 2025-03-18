---
title: Debug in Mixed Mode (managed and native code)
description: Enable mixed-mode debugging (managed and native code together) in Visual Studio with the property pages of the calling app's project.
ms.date: 3/17/2025
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
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
zone_pivot_groups: programming-languages-set-two

#customer intent: As a developer, I want to enable mixed-mode debugging in Visual Studio, so I can use managed and native code together for C#, C++, or Visual Basic.
---

# Debug in mixed mode (C#, C++, Visual Basic)

This article describes how to enable debugging for managed and native code together, known as *mixed-mode* debugging. There are two mixed-mode debugging scenarios:

- The app that calls a DLL is written in native code, and the DLL is managed.

- The app that calls a DLL is written in managed code, and the DLL is in native code. For a tutorial that walks you through this scenario, see [Debug managed and native code](../debugger/how-to-debug-managed-and-native-code.md).

You can enable both managed and native debuggers in the calling app project's **Property** pages. The settings are different for native and managed apps.

If you don't have access to a calling app's project, you can debug the DLL from the DLL project. You don't need mixed mode to debug. You need only the DLL project. For more information, see [How to debug from a DLL project](../debugger/how-to-debug-from-a-dll-project.md).

> [!NOTE]
> The dialogs and commands described in this article might differ from your experience, depending on your Visual Studio settings or edition. To change your settings, select **Tools** > **Import and Export Settings**. For more information, see [Reset all settings](../ide/personalizing-the-visual-studio-ide.md#reset-all-settings).

::: zone pivot="programming-language-cpp"
## Enable mixed-mode for native calling app (C++)

To enable mixed-mode debugging for a native calling app in C++, follow these steps:

1. In Visual Studio **Solution Explorer**, right-click the C++ project and select **Properties**, or use the Alt + Enter keyboard shortcut. The **\<Project> Property Pages** dialog opens.

1. In the dialog, expand the **Configuration Properties** section and select the **Debugging** tab.

1. In the **Debugging** tab, select the **Debugger Type** property and use the dropdown list to select the **Auto** or **Mixed** option. If there are multiple options for **Mixed**, such as .NET Core and .NET Framework, choose the best option for your configuration.

   :::image type="content" source="../debugger/media/dbg-mixed-mode-from-native.png" border="false" alt-text="Screenshot that shows how to enable mixed mode debugging for a C++ project in Visual Studio.":::

1. To apply the property change, select **OK**.
::: zone-end

::: zone pivot="programming-language-dotnet"
## Enable mixed-mode for managed calling app (.NET)

To enable mixed-mode debugging for a .NET calling app in C# or Visual Basic, follow these steps:

1. In Visual Studio **Solution Explorer**, right-click the C# or Visual Basic project and select **Properties**, or use the Alt + Enter keyboard shortcut. The **Properties** pane opens.

1. In the **Properties** pane, enable mixed-mode debugging by setting the following property:

   ::: moniker range=">=vs-2022"

   **.NET code**
   
   1. On the left menu, select **Debug**.
   
   1. In the **General** section, select the **Open debug launch profiles UI** link. The **Launch Profiles** dialog opens.
   
   1. In the dialog, scroll to locate the **Enable native code debugging** section.
   
   1. Select the **Enable debugging for managed and native code together, also known as mixed-mode debugging** property:

      :::image type="content" source="../debugger/media/vs-2022/mixed-mode-enable-native-code-debugging.png" border="false" alt-text="Screenshot that shows how to enable mixed mode debugging for a C# or Visual Basic project in Visual Studio.":::

   1. To apply the property change, close the **Launch Profiles** dialog and the **Properties** pane.

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   1. On the left menu, select **Debug**.
   
   1. In the **Debugger engines** section, select the **Enable native code debugging** property: 
   
      :::image type="content" source="../debugger/media/mixed-mode-enable-native-code-debugging.png" border="false" alt-text="Screenshot that shows how to enable mixed mode debugging for a C# or Visual Basic project in Visual Studio 2019.":::

   1. To apply the property change, close the **Properties** pane.

   > [!NOTE]
   > For a .NET Core app in Visual Studio 2017 and Visual Studio 2019, you must use the *launchSettings.json* file instead of the project properties to enable mixed-mode debugging.

   ::: moniker-end
::: zone-end

::: zone pivot="programming-language-dotnetf"
## Enable mixed-mode for managed calling app (.NET Framework)

To enable mixed-mode debugging for a .NET Framework calling app in C# or Visual Basic, follow these steps:

1. In Visual Studio **Solution Explorer**, right-click the C# or Visual Basic project and select **Properties**, or use the Alt + Enter keyboard shortcut. The **Properties** pane opens.

1. In the **Properties** pane, enable mixed-mode debugging by setting the following property:

   1. On the left menu, select **Debug**.
   
   1. In the **Debugger engines** section, select the **Enable native code debugging** property: 
   
      :::image type="content" source="../debugger/media/mixed-mode-enable-native-code-debugging.png" border="false" alt-text="Screenshot that shows how to enable mixed mode debugging for a C# or Visual Basic project in Visual Studio 2019.":::

   1. To apply the property change, close the **Properties** pane.

   ::: moniker-end
::: zone-end

## Related content

- [Debug from a DLL project](../debugger/how-to-debug-from-a-dll-project.md)
- [Debug managed and native code](../debugger/how-to-debug-managed-and-native-code.md)
- [Reset all settings](../ide/personalizing-the-visual-studio-ide.md#reset-all-settings)
