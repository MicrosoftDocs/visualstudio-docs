---
title: Property Pages, JavaScript
description: Learn how the Property Pages provides access to project settings and how to use the pages that appear in the Property Pages to change project properties.
ms.date: 06/21/2017
ms.subservice: javascript-typescript
ms.topic: reference
f1_keywords:
  - "javascript.project.property.debugging.debuggertype"
  - "javascript.project.property.debugging.requireauthentication"
  - "javascript.project.property.outputpath"
  - "javascript.project.property.debugging.launchapplication"
  - "javascript.project.property.defaultlanguage"
  - "javascript.project.property.debugging.machinename"
  - "javascript.project.property.debugging.allowlocalnetworkloopback"
ms.custom: "ide-ref"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
---
# Property pages, JavaScript

The **Property Pages** provides access to project settings. You can use the pages that appear in the **Property Pages** to change project properties.

To access the project properties, select a project node in **Solution Explorer**. On the **Project** menu, click **Properties**.

[!INCLUDE[note_settings_general](../../data-tools/includes/note_settings_general_md.md)]

The following pages and options appear in the **Property Pages**.

## Configuration and Platform Page

Use the following options to select the configuration and platform to display or modify.

 **Configuration**

Specifies the configuration settings to display or modify. The settings are **Debug** (default), **Release**, **All Configurations**, or a user-defined configuration. For more information, see [How to: Set debug and release configurations in Visual Studio](../../debugger/how-to-set-debug-and-release-configurations.md).

 **Platform**

Specifies the platform settings to display or modify. The settings are **Any CPU** (default for Windows 8.x Store apps), **x64**, **ARM**, **x86**, or a user-defined platform. For more information, see [How to: Set debug and release configurations in Visual Studio](../../debugger/how-to-set-debug-and-release-configurations.md).

## General Page

Use the following options to set general properties of the project.

> [!NOTE]
> Some options are only available in UWP apps.

 **Output Path**

Specifies the location of the output files for the project's configuration. The path is relative; if you enter an absolute path, the absolute path is saved in the project. The default path is bin\Debug.

When you use simplified build configurations, the project system determines whether to build a debug or release version. When you click  **Debug** > **Start Debugging** (or press **F5**), the build is put in the debug location regardless of the **Output path** you specify. However, the **Build Solution** command on the **Build** menu puts it in the location you specify. To enable advanced build configurations, on the menu bar, choose **Tools** > **Options**. In the **Options** dialog box, expand **Projects and Solutions**, select **General**, and then clear the **Show advanced build configurations** check box. This gives you manual control over all configuration values and whether a debug or release version is built.

 **Default Language**

Specifies the default language for the project. The language option selected in **Clock, Language, and Region** in Control Panel specifies the user's preferred language. By specifying a default language for the project, you make sure that the specified default language resources are used if the user's preferred language does not match the language resources provided in the application.

## Debug Page

Use the following options to set properties for debugging behavior in the project.

> [!NOTE]
> Some options are only available in UWP apps.

 **Debugger to Launch**

Specifies the default host for the debugger.

- Select **Local Machine** to start the application on the Visual Studio host computer. For more information, see [Running apps on the local machine](../../debugger/start-a-debugging-session-for-a-store-app-in-visual-studio-vb-csharp-cpp-and-xaml.md).

- Select **Simulator** to start the application in the Simulator. For more information, see [Running apps in the simulator](../../debugger/run-windows-store-apps-in-the-simulator.md).

- Select **Remote Machine** to start the application on a remote computer. For more information about remote debugging, see [Running apps on a remote machine](../../debugger/run-windows-store-apps-on-a-remote-machine.md).

**Launch Application**

Specifies whether to start the application when you press **F5** or click **Debug** > **Start Debugging**. Select **Yes** to start the application; otherwise, select **No**. If you select **No**, you can still debug the application if you use a different method to start it.

**Debugger Type**

Specifies the types of code to debug. Select **Script Only** to debug JavaScript code. Select **Managed Only** to debug code that is managed by the common language runtime. Select **Native Only** to debug C++ code. Select **Native with Script** to debug C++ and JavaScript. Select **Mixed (Managed and Native)** to debug both managed and C++ code.

**Allow Local Network Loopback**

Specifies whether access to the IP loopback address is allowed for app testing. Select **Yes** to allow use of the loopback address if the client app is on the same machine where the server application is running; otherwise, select **No**. This property is available only if the **Debugger to Launch** property is set to **Remote Machine**.

**Machine Name**

Specifies the name of the remote computer to host the debugger. This property is available only if **Debugger to Launch** is set to **Remote Machine**.

**Require Authentication**

Specifies whether the remote computer requires authentication. This property is available only if **Debugger to Launch** is set to **Remote Machine**.
