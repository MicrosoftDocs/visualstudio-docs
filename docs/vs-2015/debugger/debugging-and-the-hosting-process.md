---
title: "Debugging and the Hosting Process | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging [Visual Studio], hosting process"
  - "hosting process"
ms.assetid: d0f0b9a6-2a6e-463d-b6ea-9518ee727933
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Debugging and the Hosting Process
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Visual Studio hosting process improves debugger performance and enables new debugger features, such as partial-trust debugging and design-time expression evaluation. You can disable the hosting process if you need to. For more information, see [How to: Disable the Hosting Process](../ide/how-to-disable-the-hosting-process.md). The following sections describe some differences between debugging with and without the hosting process.  
  
## Partial-Trust Debugging and Click-Once Security  
 Partial-trust debugging requires the hosting process. If you disable the hosting process, partial-trust debugging will not work even if partial-trust security is enabled on the **Security** page of **Project Properties**. For more information, see [How to: Disable the Hosting Process](../ide/how-to-disable-the-hosting-process.md) and [How to: Debug a Partial Trust Application](../debugger/how-to-debug-a-partial-trust-application.md).  
  
## Design-Time Expression Evaluation  
 Design-time expression always uses the hosting process. Disabling the hosting process in the **Project Properties** disables design-time expression evaluation for Class Library projects. For other project types, design-time expression evaluation is not disabled. Instead, Visual Studio starts the actual executable and uses it for design-time evaluation without the hosting process. This difference could produce different results.  
  
## AppDomain.CurrentDomain.FriendlyName Differences  
 `AppDomain.CurrentDomain.FriendlyName` returns different results depending on whether the hosting process is enabled. If you call `AppDomain.CurrentDomain.FriendlyName` with the hosting process enabled, it returns *app_name*`.vhost.exe`. If you call it the hosting process disabled, it returns *app_name*`.exe`.  
  
## Assembly.GetCallingAssembly().FullName Differences  
 `Assembly.GetCallingAssembly().FullName` returns different results depending on whether the hosting process is enabled. If you call `Assembly.GetCallingAssembly().FullName` with the hosting process enabled, it returns `mscorlib`. If you call `Assembly.GetCallingAssembly().FullName` with the hosting process disabled, it returns the application name.  
  
## See also  
 [Hosting Process (vshost.exe)](../ide/hosting-process-vshost-exe.md)   
 [How to: Debug a Partial Trust Application](../debugger/how-to-debug-a-partial-trust-application.md)   
 [How to: Disable the Hosting Process](../ide/how-to-disable-the-hosting-process.md)
