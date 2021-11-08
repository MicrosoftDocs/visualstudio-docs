---
title: "ASP.NET Debugging: System Requirements | Microsoft Docs"
description: Review the software and security requirements for ASP.NET local debugging, in which Visual Studio and the web app run on the same computer, and remote debugging.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging ASP.NET Web applications, system requirements"
  - "debugging ASP.NET Web applications, security requirements"
ms.assetid: 7810b9b2-debf-4271-8fc7-1df031123255
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "aspnet"
---
# ASP.NET Debugging: System Requirements
This topic describes the software and security requirements for [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] debugging scenarios:

- Local debugging, in which [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and the Web application run on the same computer. There are two versions of this scenario:

  - The [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] code resides on the file system.

  - The [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] code resides in an IIS Web site.

- Remote debugging, in which [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] runs on a client computer and debugs a Web application that is running on a remote server computer.

## Security Requirements
 For remote debugging, local and remote computers must be on a domain setup or a workgroup setup.

 To debug the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process (hosted by an Application Pool), you must have permission to debug that process. By default, [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] applications prior to IIS 6.0 run as the **ASPNET** user. In IIS 6.0 and IIS 7.0, the **NETWORK SERVICE** account is the default. If the worker process is running as **ASPNET**, or as **NETWORK SERVICE**, you must have Administrator privileges to debug it.

 > [!IMPORTANT]
 > Starting with Windows Server 2008 R2, we recommend the use of the [ApplicationPoolIdentity](/iis/manage/configuring-security/application-pool-identities) as the identity for each application pool.

 The name of the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process varies by debugging scenario and by version of IIS. For more information, see [How to: Find the Name of the ASP.NET Process](../debugger/how-to-find-the-name-of-the-aspnet-process.md).

 You can change the user account that the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process runs under by editing the machine.config file on the server that is running IIS. The best way to do this is to use the **Internet Information Services (IIS) Manager**. For more information, see [How to: Run the Worker Process Under a User Account](../debugger/how-to-run-the-worker-process-under-a-user-account.md).

 If you change the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process to run under your own user account, you do not have to be an Administrator on the server that is running IIS.

> [!CAUTION]
> Before you change the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process to run under a different account, consider the possible consequences if the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process should be hacked while running under that account. The ASPNET and NETWORK SERVICE user accounts run with minimal permissions, reducing the possible damage if the process is hacked. If you must change the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process to run under an account that has greater permissions, the potential damage is greater.

## See also

- [Debug ASP.NET Applications](../debugger/how-to-enable-debugging-for-aspnet-applications.md)
- [How to: Run the Worker Process Under a User Account](../debugger/how-to-run-the-worker-process-under-a-user-account.md)