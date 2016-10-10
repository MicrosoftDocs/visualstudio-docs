---
title: "Profiling Tools Usage Rules"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: afa7db3b-8c1d-473a-81ac-24ede112a17f
caps.latest.revision: 9
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Profiling Tools Usage Rules
Performance rules in the Profiling Tools Usage category provide guidance for using the profiler to collect data most effectively.  
  
|||  
|-|-|  
|[DA0002: VSPerfCorProf.dll is missing](../VS_IDE/DA0002--VSPerfCorProf.dll-is-missing.md)|Command line profiling might contain incomplete data for .NET Framework binaries. This might be caused by not setting the correct environment variables.|  
|[DA0003: Many kernel samples](../VS_IDE/DA0003--Many-kernel-samples.md)|Many profiling samples that occurred outside the execution of the target binary were recorded. To collect more accurate data, consider using the instrumentation method.|  
|[DA0004: High processor usage](../VS_IDE/DA0004--High-processor-usage.md)|Profiling data suggests that your processors were consistently busy during the profiling run. To collect more accurate data, consider using the sampling method.|  
|[DA0008: Few samples collected](../VS_IDE/DA0008--Few-samples-collected.md)|The number of samples collected in the profiling run was not high enough to be statistically significant. Consider profiling again and running the application for a longer time. You can also consider using the instrumentation method to collect data.|  
|[DA0026: Excessive kernel CPU time processing](../VS_IDE/DA0026--Excessive-kernel-CPU-time-processing.md)|A significant amount of time in the profiling run occurred in the processor kernel mode. Consider sampling by using system calls as the metric instead of using time as the metric.|  
|[DA0029: Unsupported CLR Version](../VS_IDE/DA0029--Unsupported-CLR-Version.md)|The profiled binary is using a version of .NET Framework that is not supported by the profiler. The profiler reports cannot resolve symbol names.|  
|[DA0030: Gather Tier Interaction measurements for database projects](../VS_IDE/DA0030--Gather-Tier-Interaction-measurements-for-database-projects.md)|A significant number of calls to methods in the <xref:System.Data?qualifyHint=True> namespace were collected. To include data about the database calls, consider collecting tier interaction data in your profile runs.|