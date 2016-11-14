---
title: "WPF .Targets Files | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
caps.latest.revision: 5
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# WPF .Targets Files
[!INCLUDE[TLA#tla_winclient](../misc/includes/tlasharptla_winclient_md.md)] extends the [!INCLUDE[TLA#tla_msbuild](../msbuild/includes/tlasharptla_msbuild_md.md)] by adding a set of [!INCLUDE[TLA2#tla_wpf](../msbuild/includes/tla2sharptla_wpf_md.md)]-specific tasks that are combined into a special .targets file, **Microsoft.WinFX.targets**. This file combines the set of [!INCLUDE[TLA2#tla_msbuild](../msbuild/includes/tla2sharptla_msbuild_md.md)] tasks that are required to build an [!INCLUDE[TLA2#tla_msbuild](../msbuild/includes/tla2sharptla_msbuild_md.md)] project in [!INCLUDE[TLA#tla_winclient](../misc/includes/tlasharptla_winclient_md.md)].  
  
## See Also  
 [.Targets Files](../msbuild/msbuild-dot-targets-files.md)   
 [MSBuild Reference](../msbuild/msbuild-reference.md)   
 [Building a WPF Application (WPF)](../Topic/Building%20a%20WPF%20Application%20\(WPF\).md)