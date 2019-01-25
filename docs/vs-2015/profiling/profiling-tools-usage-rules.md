---
title: "Profiling Tools Usage Rules | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: afa7db3b-8c1d-473a-81ac-24ede112a17f
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Profiling Tools Usage Rules
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Performance rules in the Profiling Tools Usage category provide guidance for using the profiler to collect data most effectively.  
  
|||  
|-|-|  
|[DA0002: VSPerfCorProf.dll is missing](../profiling/da0002-vsperfcorprof-dll-is-missing.md)|Command line profiling might contain incomplete data for [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] binaries. This might be caused by not setting the correct environment variables.|  
|[DA0003: Many kernel samples](../profiling/da0003-many-kernel-samples.md)|Many profiling samples that occurred outside the execution of the target binary were recorded. To collect more accurate data, consider using the instrumentation method.|  
|[DA0004: High processor usage](../profiling/da0004-high-processor-usage.md)|Profiling data suggests that your processors were consistently busy during the profiling run. To collect more accurate data, consider using the sampling method.|  
|[DA0008: Few samples collected](../profiling/da0008-few-samples-collected.md)|The number of samples collected in the profiling run was not high enough to be statistically significant. Consider profiling again and running the application for a longer time. You can also consider using the instrumentation method to collect data.|  
|[DA0026: Excessive kernel CPU time processing](../profiling/da0026-excessive-kernel-cpu-time-processing.md)|A significant amount of time in the profiling run occurred in the processor kernel mode. Consider sampling by using system calls as the metric instead of using time as the metric.|  
|[DA0029: Unsupported CLR Version](../profiling/da0029-unsupported-clr-version.md)|The profiled binary is using a version of [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] that is not supported by the profiler. The profiler reports cannot resolve symbol names.|  
|[DA0030: Gather Tier Interaction measurements for database projects](../profiling/da0030-gather-tier-interaction-measurements-for-database-projects.md)|A significant number of calls to methods in the <xref:System.Data?displayProperty=fullName> namespace were collected. To include data about the database calls, consider collecting tier interaction data in your profile runs.|
