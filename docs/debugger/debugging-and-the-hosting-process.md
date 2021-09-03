---
title: "Debugging and the Hosting Process | Microsoft Docs"
description: For Visual Studio versions prior to 2017, use the hosting process to improve debugger performance and to access some debugger features. 
ms.custom: SEO-VS-2020
ms.date: "08/01/2018"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging [Visual Studio], hosting process"
  - "hosting process"
ms.assetid: d0f0b9a6-2a6e-463d-b6ea-9518ee727933
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Debugging and the Hosting Process
The Visual Studio hosting process improves debugger performance and enables new debugger features, such as partial-trust debugging and design-time expression evaluation. You can disable the hosting process if you need to. The following sections describe some differences between debugging with and without the hosting process.

> [!NOTE]
> Starting in Visual Studio 2017, the option to debug using the hosting process is no longer needed and has been removed. For more information, see [Debugging: Visual Studio 2017 Aims To Speed Up Your Least Favorite Job](https://vslive.com/Blogs/News-and-Tips/2017/02/Debugging-Visual-Studio-2017-aims-to-speed-up-your-least-favorite-job.aspx).

## Partial-Trust Debugging and Click-Once Security
 Partial-trust debugging requires the hosting process. If you disable the hosting process, partial-trust debugging will not work even if partial-trust security is enabled on the **Security** page of **Project Properties**. For more information, see [How to: Debug a Partial Trust Application](debugger-security.md).

## Design-Time Expression Evaluation
 Design-time expression always uses the hosting process. Disabling the hosting process in the **Project Properties** disables design-time expression evaluation for Class Library projects. For other project types, design-time expression evaluation is not disabled. Instead, Visual Studio starts the actual executable and uses it for design-time evaluation without the hosting process. This difference could produce different results.

## AppDomain.CurrentDomain.FriendlyName Differences
 `AppDomain.CurrentDomain.FriendlyName` returns different results depending on whether the hosting process is enabled. If you call `AppDomain.CurrentDomain.FriendlyName` with the hosting process enabled, it returns *app_name*`.vhost.exe`. If you call it the hosting process disabled, it returns *app_name*`.exe`.

## Assembly.GetCallingAssembly().FullName Differences
 `Assembly.GetCallingAssembly().FullName` returns different results depending on whether the hosting process is enabled. If you call `Assembly.GetCallingAssembly().FullName` with the hosting process enabled, it returns `mscorlib`. If you call `Assembly.GetCallingAssembly().FullName` with the hosting process disabled, it returns the application name.

## See also

- [How to: Debug a Partial Trust Application](debugger-security.md)