---
title: "DA0002: VSPerfCorProf.dll is missing | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.performance.DA0002"
  - "vs.performance.2"
  - "vs.performance.rules.DAVsPerfCorProfMissing"
  - "vs.performance.rules.DA0002"
ms.assetid: 76e614b3-ad7e-4b92-b7be-88dc1329be1d
caps.latest.revision: 14
author: "mikejo5000"
ms.author: "mikejo"
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
# DA0002: VSPerfCorProf.dll is missing
|||  
|-|-|  
|Rule Id|DA0002|  
|Category|Profiling Tools Usage|  
|Profiling methods|Profiling using the VSPerfCmd and VSPerfASPNETCmd command line tools|  
|Message|It appears that the file was collected without properly setting the environment variables with VSPerfCLREnv.cmd. Symbols for managed binaries may not resolve.|  
|Rule type|Information|  
  
## Cause  
 The profiler could not find VSPerfCorProf.dll during the profiling run. This warning occurs when command-line tools for the collection of profiler data are used without using the VSPerfCLREnv.cmd tool to initialize the necessary environment variables. The warning can also fire if another profiler is running when the Profiling Tools start.  
  
## Rule Description  
 Specific environment variables must be set before a profiling run for the profiler to resolve the symbols in .NET Framework binaries. This warning suggests that the VSPerfCLREnv.cmd tool was not run before the profiling data was collected. Symbols for managed binaries might not resolve. For more information about using the Profiling Tools from the command line, see [Profiling from the Command-Line](../profiling/using-the-profiling-tools-from-the-command-line.md)  
  
## How to Fix Violations  
 When you are profiling managed applications by using the command-line tools in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools, run the [VSPerfCLREnv](../profiling/vsperfclrenv.md) command-line tool before you start collecting data.