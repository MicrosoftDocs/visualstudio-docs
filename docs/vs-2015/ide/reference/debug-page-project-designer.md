---
title: "Debug Page, Project Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "vb.ProjectPropertiesDebug"
helpviewer_keywords:
  - "Project Designer, Debug page"
  - "Debug page in Project Designer"
ms.assetid: ef11eae9-df96-4e20-aabd-2678ba317140
caps.latest.revision: 37
author: jillre
ms.author: jillfra
manager: jillfra
---
# Debug Page, Project Designer
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

> [!WARNING]
> This topic does not apply to Windows Store apps. See [Start a debug session (VB, C#, C++ and XAML)](../../debugger/start-a-debugging-session-for-a-store-app-in-visual-studio-vb-csharp-cpp-and-xaml.md) in the Windows Dev Center.

 Use the **Debug** page of the **Project Designer** to set properties for debugging behavior in a Visual Basic or C# project.

 To access the **Debug** page, select a project node in **Solution Explorer**. On the **Project** menu, choose _ProjectName_**Properties**. When the **Project Designer** appears, click the **Debug** tab.

## Configuration and Platform
 The following options allow you to select the configuration and platform to display or modify.

 **Configuration**
 Specifies which configuration settings to display or modify. The settings can be **Debug** (default), **Release**, or **All Configurations**. For more information, see [Debug and Release Project Configurations](https://msdn.microsoft.com/0440b300-0614-4511-901a-105b771b236e).

 **Platform**
 Specifies which platform settings to display or modify. The choices can include **Any CPU** (default), **x64**, and **x86**. For more information, see [Debug and Release Project Configurations](https://msdn.microsoft.com/0440b300-0614-4511-901a-105b771b236e).

## Start Action
 **Start Action** indicates the item to start when the application is debugged: the project, a custom program, a URL, or nothing. By default, this option is set to **Start project**. The **Start Action** setting on the **Debug** page determines the value of the `StartAction` property.

 **Start project**
 Choose this option to specify that the executable (for Windows Application and Console Application projects) should be started when the application is debugged. This option is selected by default.

 **Start external program**
 Choose this option to specify that a specific program should be started when the application is debugged.

 **Start browser with URL**
 Choose this option to specify that a particular URL should be accessed when the application is debugged.

## Start Options
 **Command line arguments**
 In this text box, enter the command-line arguments to use for debugging.

 **Working directory**
 In this text box, enter the directory from which the project will be launched. Or click the Browse button (**...**) to choose a directory.

 **Use remote machine**
 To debug the application from a remote computer, select this check box, and enter the path to the remote computer in the text box.

## Enable Debuggers
 **Enable unmanaged code debugging**
 This option specifies whether debugging of native code is supported. Select this check box if you are making calls to COM objects or if you start a custom program written in native code that calls your project and you must debug the native code. Clear this check box to disable debugging of unmanaged code. This check box is cleared by default.

 **Enable SQL Server debugging**
 Select or clear this check box to enable or disable debugging of SQL procedures from your Visual Basic application. This check box is cleared by default.

 **Enable the Visual Studio hosting process**
 Select this check box to enable the Visual Studio hosting process. This check box is selected by default. For more information, see [Hosting Process (vshost.exe)](../../ide/hosting-process-vshost-exe.md).

 To debug in a security zone, you must enable this option and **Debug this application with the selected permission set** in the [Advanced Security Settings Dialog Box](../../ide/reference/advanced-security-settings-dialog-box.md).

## See Also
 [Debugging in Visual Studio](../../debugger/debugging-in-visual-studio.md)
 [Project Settings for  C# Debug Configurations](../../debugger/project-settings-for-csharp-debug-configurations.md)
 [Project Settings for a Visual Basic Debug Configuration](../../debugger/project-settings-for-a-visual-basic-debug-configuration.md)
 [Managing Debugging Properties](https://msdn.microsoft.com/92474d16-e7fe-4fac-9287-6bd6b3a7eb68)
 [How to: Debug a ClickOnce Application with Restricted Permissions](../../deployment/how-to-debug-a-clickonce-application-with-restricted-permissions.md)
 [How to: Create and Edit Configurations](../../ide/how-to-create-and-edit-configurations.md)
