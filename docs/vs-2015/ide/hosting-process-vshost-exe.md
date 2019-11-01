---
title: "Hosting Process (vshost.exe) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "vshost.exe"
  - "hosting process"
ms.assetid: c6b9e2be-f18d-4d75-ac52-56d55784734b
caps.latest.revision: 12
author: jillre
ms.author: jillfra
manager: jillfra
---
# Hosting Process (vshost.exe)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The hosting process is a feature in Visual Studio that improves debugging performance, enables partial trust debugging, and enables design time expression evaluation. The hosting process files contain vshost in the file name and are placed in the output folder of your project. For more information, see [Debugging and the Hosting Process](../debugger/debugging-and-the-hosting-process.md).

> [!NOTE]
> Hosting process files (.vshost.exe) are for use by Visual Studio and should not be run directly or deployed with your application.

## Improved Debugging Performance
 The hosting process creates an application domain and associates the debugger with the application. Performing these tasks can introduce a noticeable delay between the time debugging is started and the time the application begins running. The hosting process helps increase performance by creating the application domain and associating the debugger in the background, and saving the application domain and debugger state between runs of the application. For more information on application domains, see [Application Domains](https://msdn.microsoft.com/library/113a8bbf-6875-4a72-a49d-ca2d92e19cc8).

## Partial Trust Debugging
 An application can be specified as a partial trust application in the [Security page](../ide/reference/security-page-project-designer.md) of the **Project Designer**. Debugging a partial trust application requires special initialization of the application domain. This initialization is handled by the hosting process.

## Design-Time Expression Evaluation
 Design-time expression evaluation enables you to test code from the **Immediate** window without having to run the application. The hosting process executes this code during design time expression evaluation. For more information, see [Immediate Window](../ide/reference/immediate-window.md).

## See Also
 [Debugging and the Hosting Process](../debugger/debugging-and-the-hosting-process.md)
 [How to: Disable the Hosting Process](../ide/how-to-disable-the-hosting-process.md)
 [Immediate Window](../ide/reference/immediate-window.md)
 [Application Domains](https://msdn.microsoft.com/library/113a8bbf-6875-4a72-a49d-ca2d92e19cc8)
