---
title: Debug Page, Project Designer
description: Use the Debug page of Project Designer to set debugging properties in a Visual Basic or C# project. See this article for descriptions of the settings.
ms.date: 06/27/2018
ms.subservice: debug-diagnostics
ms.topic: reference
f1_keywords:
- vb.ProjectPropertiesDebug
helpviewer_keywords:
- Project Designer, Debug page
- Debug page in Project Designer
ms.custom: "ide-ref"
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
monikerRange: 'vs-2019'
---
# Debug Page, Project Designer

Use the **Debug** page of the **Project Designer** to set properties for debugging behavior in a Visual Basic or C# project.

To access the **Debug** page, select a project node in **Solution Explorer**. On the **Project** menu, choose **\<ProjectName> Properties**. When the **Project Designer** appears, click the **Debug** tab.

> [!NOTE]
> This topic does not apply to UWP apps. See [Start a debug session (VB, C#, C++ and XAML)](../../debugger/start-a-debugging-session-for-a-store-app-in-visual-studio-vb-csharp-cpp-and-xaml.md) for UWP apps.

## Configuration and Platform

The following options allow you to select the configuration and platform to display or modify.

**Configuration**

Specifies which configuration settings to display or modify. The settings can be **Debug** (default), **Release**, or **All Configurations**.

**Platform**

Specifies which platform settings to display or modify. The choices can include **Any CPU** (default), **x64**, and **x86**.

## Start action

**Start action** indicates the item to start when the application is debugged: the project, a custom program, a URL, or nothing. By default, this option is set to **Start project**. The **Start Action** setting on the **Debug** page determines the value of the `StartAction` property.

**Start project**

Choose this option to specify that the executable (for Windows Application and Console Application projects) should be started when the application is debugged. This option is selected by default.

**Start external program**

Choose this option to specify that a specific program should be started when the application is debugged.

**Start browser with URL**

Choose this option to specify that a particular URL should be accessed when the application is debugged.

## Start options

**Command line arguments**

In this text box, enter the command-line arguments to use for debugging.

**Working directory**

In this text box, enter the directory from which the project will be launched. Or click the Browse button (**...**) to choose a directory.

**Use remote machine**

To debug the application from a remote computer, select this check box, and enter the path to the remote computer in the text box.

## Debugger engines

**Enable native code debugging**

This option specifies whether debugging of native code is supported. Select this check box if you are making calls to COM objects or if you start a custom program written in native code that calls your project and you must debug the native code. Clear this check box to disable debugging of unmanaged code. This check box is cleared by default.

**Enable SQL Server debugging**

Select or clear this check box to enable or disable debugging of SQL procedures from your Visual Basic application. This check box is cleared by default.

## See also

- [First look at the debugger](../../debugger/debugger-feature-tour.md)
- [Project Settings for  C# Debug Configurations](../../debugger/project-settings-for-csharp-debug-configurations.md)
- [Project Settings for a Visual Basic Debug Configuration](../../debugger/project-settings-for-a-visual-basic-debug-configuration.md)
- [Secure ClickOnce apps](../../deployment/securing-clickonce-applications.md)
- [How to: Create and Edit Configurations](../../ide/how-to-create-and-edit-configurations.md)
