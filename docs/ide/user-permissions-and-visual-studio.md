---
title: Run as administrator
description: Learn how to run Visual Studio as an administrator.
ms.date: 10/26/2021
ms.topic: conceptual
helpviewer_keywords:
- Visual Studio, user permissions
- user permissions
- administrative privileges
- permissions
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# User permissions and Visual Studio

For reasons of security, you should run Visual Studio as a typical user whenever possible.

> [!WARNING]
> You should also make sure not to compile, launch, or debug any Visual Studio solution that does not come from a trusted person or a trusted location.

You can do nearly everything in the Visual Studio IDE as a typical user. You need administrator permissions to complete the following tasks:

|Area|Task|For more information|
|----------|----------| - |
|Installation|Install or modify Visual Studio.|[Install Visual Studio](../install/install-visual-studio.md), [Modify Visual Studio](../install/modify-visual-studio.md)|
||Install, update, or remove local Help content.|[Install and manage local Help content](../help-viewer/install-manage-local-content.md)|
|Toolbox|Add classic COM controls to **Toolbox**.|[Toolbox](../ide/reference/toolbox.md)|
|Building|Use post-build events that register a component.|[Understand custom build steps and build events](/cpp/build/understanding-custom-build-steps-and-build-events)|
||Include a registration step when you build C++ projects.||
|Debugging|Debug applications that run with elevated permissions.|[Debugger settings and preparation](../debugger/debugger-settings-and-preparation.md)|
||Debug applications that a run under a different user account, such as ASP.NET websites.|[Debug ASP.NET and AJAX applications](../debugger/how-to-enable-debugging-for-aspnet-applications.md)|
||Debug in Zone for XAML Browser Applications (XBAP).|[WPF host (PresentationHost.exe)](/dotnet/framework/wpf/app-development/wpf-host-presentationhost-exe)|
||Use the emulator to debug cloud service projects for Microsoft Azure.|[Debug a cloud service in Visual Studio](/azure/vs-azure-tools-debug-cloud-services-virtual-machines)|
||Configure a firewall for remote debugging.|[Remote debugging](../debugger/remote-debugging.md)|
|Performance tools|Attaching to an elevated application.|[Beginners guide to performance profiling](../profiling/beginners-guide-to-performance-profiling.md)|
||Use the GPU Profiler.|[GPU profiling](../profiling/gpu-usage.md)|
|Deployment|Deploy a web application to Internet Information Services (IIS) on a local computer.|[Deploy an ASP.NET web app using Visual Studio](/aspnet/web-forms/overview/older-versions-getting-started/deployment-to-a-hosting-provider/)|

## Run Visual Studio as an administrator

If you need to run Visual Studio as an administrator, follow these steps to open the IDE:

> [!NOTE]
> These instructions are for Windows 10. They are similar for other versions of Windows.

::: moniker range="vs-2017"

1. Open the **Start** menu, and scroll to Visual Studio 2017.

1. From the right-click or context menu of **Visual Studio 2017**, select **More** > **Run as administrator**.

   When Visual Studio starts, **(Administrator)** appears after the product name in the title bar.

::: moniker-end

::: moniker range=">=vs-2019"

1. Open the **Start** menu, and scroll to Visual Studio.

1. From the right-click or context menu of **Visual Studio 2019** or **Visual Studio 2022**, select **More** > **Run as administrator**.

   When Visual Studio starts, **(Administrator)** appears after the product name in the title bar.

::: moniker-end

You can also modify the application shortcut to always run with administrative permissions:

1. Open the **Start** menu, scroll to the version of Visual Studio that you're using, and then select **More** > **Open file location**.

1. In **File Explorer**, locate the **Visual Studio** shortcut for the version that you're using. Then, right-click the shortcut and select **Send to** > **Desktop (create shortcut)**.

1. On the **Windows** desktop, right-click the **Visual Studio** shortcut, and then select **Properties**.

1. Select the **Advanced** button, and then select the **Run as administrator** check box.

1. Select **OK**, and then select **OK** again.

## See also

- [Port, migrate, and upgrade Visual Studio projects](../porting/port-migrate-and-upgrade-visual-studio-projects.md)
- [Install Visual Studio](../install/install-visual-studio.md)
