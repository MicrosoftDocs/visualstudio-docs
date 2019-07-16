---
title: "How to: Specify Additional Instrumentation Options | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.performance.property.advanced"
helpviewer_keywords: 
  - "instrumentation, options"
  - "profiling tools, session options"
  - "performance sessions, options"
ms.assetid: 639afe26-8335-4bd4-8aa5-f2c607b81f07
caps.latest.revision: 21
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Specify Additional Instrumentation Options
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can instrument binaries from the [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] integrated development environment (IDE) or by using command line tools. If you instrument a binary from within the IDE, you can control the volume of data that is collected during instrumentation by specifying additional instrumentation options to the [VSInstr](../profiling/vsinstr.md) tool. These options are available at the session or the target level. For example, to include or exclude specific functions during the instrumentation process, use the additional instrumentation option at the target level.  
  
 **Requirements**  
  
- [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], [!INCLUDE[vsPro](../includes/vspro-md.md)]  
  
> [!IMPORTANT]
> Every probe that is inserted modifies the behavior of the original program slightly. This modification causes overhead at analysis time. Even though an approximation of this overhead is subtracted, it still has subtle timing effects on multithreaded applications. The [VSInstr](../profiling/vsinstr.md) tool options help control data collection during profiling.  
  
### To specify additional instrumentation option  
  
1. In **Performance Explorer**, select the **Performance Session** and then right-click and select **Properties**.  
  
2. In the **Properties Pages**, click the **Advanced** properties.  
  
3. Type options in the **Additional instrumentation options** box.  
  
     For example, use /CONTROL:THREAD to specify the profiling level. For a complete list of options, see [VSInstr](../profiling/vsinstr.md).  
  
4. Click **OK**.  
  
## See Also  
 [Configuring Performance Sessions](../profiling/configuring-performance-sessions.md)   
 [Profiling from the Command-Line](../profiling/using-the-profiling-tools-from-the-command-line.md)
