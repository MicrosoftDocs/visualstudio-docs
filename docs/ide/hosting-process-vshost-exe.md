---
title: Hosting process (vshost.exe)
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: conceptual
helpviewer_keywords:
  - "vshost.exe"
  - "hosting process"
ms.assetid: c6b9e2be-f18d-4d75-ac52-56d55784734b
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Hosting process (vshost.exe)

The hosting process is a feature in Visual Studio that improves debugging performance, enables partial trust debugging, and enables design time expression evaluation. The hosting process files contain *vshost* in the file name and are placed in the output folder of your project. For more information, see [Debugging and the hosting process](../debugger/debugging-and-the-hosting-process.md).

> [!NOTE]
> Hosting process files (*.vshost.exe*) are for use by Visual Studio and should not be run directly or deployed with your application.

## Improved debugging performance
 The hosting process creates an application domain and associates the debugger with the application. Performing these tasks can introduce a noticeable delay between the time debugging is started and the time the application begins running. The hosting process helps increase performance by creating the application domain and associating the debugger in the background, and saving the application domain and debugger state between runs of the application. For more information on application domains, see [Application domains](/dotnet/framework/app-domains/application-domains).

## Partial trust debugging
 An application can be specified as a partial trust application in the [Security page](../ide/reference/security-page-project-designer.md) of the **Project Designer**. Debugging a partial trust application requires special initialization of the application domain. This initialization is handled by the hosting process.

## Design-time expression evaluation
 Design-time expression evaluation enables you to test code from the **Immediate** window without having to run the application. The hosting process executes this code during design time expression evaluation. For more information, see [Immediate window](../ide/reference/immediate-window.md).

## See also

- [Debugging and the hosting process](../debugger/debugging-and-the-hosting-process.md)
- [How to: Disable the hosting process](../ide/how-to-disable-the-hosting-process.md)
- [Immediate window](../ide/reference/immediate-window.md)
- [Application domains](/dotnet/framework/app-domains/application-domains)