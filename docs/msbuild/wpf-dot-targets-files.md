---
title: "WPF .Targets Files | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords:
  - "combining tasks into a .targets file to build an MSBuild project [WPF MSBuild]"
  - "WPF .targets files [WPF MSBuild], introduction"
  - "WPF .targets files [WPF MSBuild]"
ms.assetid: e85a3ff4-dedd-4ff4-9b22-3a1e94755362
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# WPF .targets files
[!INCLUDE[TLA#tla_winclient](../misc/includes/tlasharptla_winclient_md.md)] extends the [!INCLUDE[TLA#tla_msbuild](../msbuild/includes/tlasharptla_msbuild_md.md)] by adding a set of [!INCLUDE[TLA2#tla_wpf](../msbuild/includes/tla2sharptla_wpf_md.md)]-specific tasks that are combined into a special *.targets* file, *Microsoft.WinFX.targets*. This file combines the set of [!INCLUDE[TLA2#tla_msbuild](../msbuild/includes/tla2sharptla_msbuild_md.md)] tasks that are required to build an [!INCLUDE[TLA2#tla_msbuild](../msbuild/includes/tla2sharptla_msbuild_md.md)] project in [!INCLUDE[TLA#tla_winclient](../misc/includes/tlasharptla_winclient_md.md)].

## See also
- [MSBuild .targets files](../msbuild/msbuild-dot-targets-files.md)
- [MSBuild reference](../msbuild/msbuild-reference.md)
- [Building a WPF application (WPF)](/dotnet/framework/wpf/app-development/building-a-wpf-application-wpf)