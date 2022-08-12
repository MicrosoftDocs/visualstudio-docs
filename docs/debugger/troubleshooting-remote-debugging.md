---
title: "Troubleshoot remote debugging | Microsoft Docs"
description: Learn how to resolve some of the common issues with remote debugging.

ms.date: "08/03/2022"
ms.topic: "troubleshooting" 
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Troubleshoot remote debugging

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

The first step is to check your error message, if a message appeared, and investigate. The message may include a link that you can click.

Next, verify that the app is running correctly on the server before trying to debug it.

Otherwise, here are the most common issues and solutions:

## Incorrect version of the remote debugger installed

For scenarios where you manually install the remote debugger on a remote machine, make sure the installed version matches your version of Visual Studio. For current links to download the remote debugger, see [Remote Debuggger](../debugger/remote-debugging.md).

## A release build is deployed to the server instead of a debug build

The Publish tool and some other publishing options have a separate debug configuration setting that you need to set. (You may be choosing a debug build when you run the app in Visual Studio, but that doesn't mean you installed a debug build on the server.)

## You can attach to the remote application, but you can't hit breakpoints (or debugging symbols won't load)

For this issue, you may see a message **No symbols are loaded**.

Use the [Modules window](../debugger/how-to-use-the-modules-window.md) to find out the symbol loading status for your module, and which modules the debugger is treating as user code, or [My Code](../debugger/just-my-code.md).

- The **Symbol Status** column indicates whether symbols loaded correctly for the module.

- The **User code** column indicates whether the module you're trying to debug is classified as My Code. If it is showing incorrectly as My Code, you probably have a release build deployed to the server. Release binaries are optimized and are never considered as My Code, so either disable Just My Code or deploy a debug build to the server.

- If the **User code** setting is correct, but symbols aren't loaded, verify that the debugger is using the correct symbol files. The debugger only loads symbols (.pdb files) that exactly match the .pdb files created when an app was built (that is, the original .pdb files or copies). For remote Windows debugging, by default PDB files are read on the Visual Studio machine and not from the server. (However, msvsmon has a command line argument to enable falling back to remote .pdb files.)

For more information, see [Troubleshooting breakpoints](../debugger/troubleshooting-breakpoints.md).

## (ASP.NET) The version of ASP.NET running on the server is not the same as the version configured for your app

You may need to install the correct version of ASP.NET or ASP.NET Core on either the server or on your local machine. To check your app version of ASP.NET, right click the project in Solution Explorer and choose **Properties**. Check the Build tab. The configuration of ASP.NET on the server is specific to the scenario. For ASP.NET Framework apps, you may need to set the framework version in your *web.config* file.

## You don't see the process you need in the Attach to Process dialog box

Some scenarios require you to manually attach to the correct process. If you are using [Attach to Process](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md) for your scenario, and don't see the process you are expecting:

- If the search process filter was previously set, check if you need to clear it.

- Select **Show processes for all users** to show processes running under other user accounts.

- For slow connections, you might want to disable the **Automatic refresh**.

- If they are changed from defaults, the **Connection type** and **Attach to** fields may limit which processes appear in the list.

## You are not attaching to the correct process

If you are using attach to process, make sure you are attaching to the correct process. For more information, see [Common debugging scenarios](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md#common-debugging-scenarios).

## A required port is not open

In most ASP.NET setups, required ports are opened by the installation of ASP.NET and the remote debugger. However, you may need to verify that ports are open. For example, in Azure VM scenarios, you probably need to open the [remote debugger port](../debugger/remote-debugger-port-assignments.md) and the server port (for example, IIS uses port 80).

## Elevated privileges for the remote debugger may be required

In some scenarios, you may need to run the remote debugger as an Administrator. For more information, see [Run the remote debugger as an administrator](../debugger/remote-debugging-errors-and-troubleshooting.md#run-the-remote-debugger-as-an-administrator).