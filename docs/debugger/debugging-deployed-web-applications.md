---
title: "Debugging Deployed ASP.NET Applications | Microsoft Docs"
ms.date: "06/30/2018"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "ASP.NET Web applications"
  - "Web services, debugging"
  - "XML, debugging Web services"
  - "debugging Web services"
  - "ASP.NET, debugging Web applications"
  - "XML Web services, debugging"
ms.assetid: b938a91b-be96-416f-83bc-4177e7f3929a
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "aspnet"
---
# Debugging Deployed ASP.NET Applications
To use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] to debug a deployed application, you must attach to the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process and make sure that the debugger has access to symbols for the application. You must also locate and open the source files for the application. For more information, see [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md), [How to: Find the Name of the ASP.NET Process](../debugger/how-to-find-the-name-of-the-aspnet-process.md), and [System Requirements](../debugger/aspnet-debugging-system-requirements.md).

> [!WARNING]
> If you attach to the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process for debugging and hit a breakpoint, all managed code in the worker process halts. Halting all managed code in the worker process can cause a work stoppage for all users on the server. Before you debug on a production server, consider the potential impact on production work.

The process for attaching to the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process is the same as attaching to any other remote process. When you are attached, if you do not have the correct project open, a dialog box appears when the application breaks. This dialog box asks for the location of the source files for the application. The file name that you specify in the dialog box must match the file name specified in the debug symbols on the Web server. For more information, see [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md). To set up remote debugging on IIS, see [Remote Debugging ASP.NET on a Remote IIS Computer](../debugger/remote-debugging-aspnet-on-a-remote-iis-computer.md).

> [!NOTE]
> Many [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web applications reference DLLs that contain business logic or other useful code. Such a reference copies the DLL from your local computer to the \bin folder of the Web application's virtual directory when you deploy your app. When you are debugging, remember that your Web application is referencing that copy of the DLL and not the copy on your local computer.

## See also
- [Debug ASP.NET Applications](../debugger/how-to-enable-debugging-for-aspnet-applications.md)
- [How to: Enable Debugging for ASP.NET Applications](../debugger/how-to-enable-debugging-for-aspnet-applications.md)
- [How to: Find the Name of the ASP.NET Process](../debugger/how-to-find-the-name-of-the-aspnet-process.md)
- [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)