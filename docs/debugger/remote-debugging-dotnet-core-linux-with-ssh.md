---
title: "Remote debug .NET Core on Linux | Microsoft Docs"
ms.date: "02/26/2020"
ms.topic: "conceptual"
helpviewer_keywords:
  - "remote debugging, linux"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Remote debug .NET Core on Linux using SSH

Starting in Visual Studio 2017, you can attach to .NET Core processes running on Linux over SSH. This article describes how to set up debugging and how to debug.

## Prerequisites

On the Visual Studio computer, you need to install either the **ASP.NET and web development** workload or the **.NET Core cross-platform development** workload.

On the Linux server, you need to install SSH server, unzip and install with either curl or wget. For example, on Ubuntu you can do that by running:

``` cmd
sudo apt-get install openssh-server unzip curl
```

## Build and deploy the application

To prepare your application for debugging:

- Consider using a Debug configuration when you build the application. It is much harder to debug retail-compiled code (a Release configuration) than debug-compiled code. If you need to use a Release configuration, first disable Just My Code. To disable this setting, choose **Tools** > **Options** > **Debugging**, and then deselect **Enable Just My Code**.

- Make sure your project is configured to produce [portable PDBs](https://github.com/OmniSharp/omnisharp-vscode/wiki/Portable-PDBs) (which is the default setting), and make sure the PBDs are in the same location as the DLL. To configure this in Visual Studio, right-click the project, then choose **Properties** > **Build** > **Advanced** > **Debugging Information**.

You can use several methods to deploy the app prior to debugging. For example, you can:

- Copy sources to the target computer and build with ```dotnet build``` on the Linux machine.

- Build the app on Windows, and the transfer the build artifacts to the Linux machine. (The build artifacts consist of the application itself, any runtime libraries it might depend on, and the *.deps.json* file.)

## Attach the debugger

After the computers are configured, start the application on the Linux machine, and then you are ready to attach the debugger.

1. In Visual Studio, choose **Debug** > **Attach to Process…**.

1. In the **Connection Type** list, select **SSH**.

1. Change the **Connection Target** to the IP address or host name of the target computer.

1. Find the process that you would like to debug.

   Your code runs either in a unique process name or a process named dotnet. To find the process that you're interested in, check the **Title** column, which shows the command line arguments for the process.

   In the following example, you see a list of processes from a remote Linux machine over an SSH transport displayed in the **Attach to Process** dialog box.

   ![Attach to Linux process](media/remote-debug-linux-over-ssh-attach.png)

1. Choose **Attach**.

1. In the dialog that appears, select the type of code you would like to debug. Choose **Managed (.NET Core for Unix)**.

1. Use Visual Studio debugging features to debug the app.

   In the following example, you see the Visual Studio debugger stopped at a breakpoint in code running on a remote Linux machine.

   ![Hit a breakpoint](media/remote-debug-linux-over-ssh-hit-breakpoint.png)