---
title: "How to: Specify Additional Instrumentation Options"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.performance.property.advanced"
helpviewer_keywords: 
  - "instrumentation, options"
  - "profiling tools, session options"
  - "performance sessions, options"
ms.assetid: 639afe26-8335-4bd4-8aa5-f2c607b81f07
caps.latest.revision: 16
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# How to: Specify Additional Instrumentation Options
You can instrument binaries from the [!INCLUDE[vs_current_short](../codequality/includes/vs_current_short_md.md)] integrated development environment (IDE) or by using command line tools. If you instrument a binary from within the IDE, you can control the volume of data that is collected during instrumentation by specifying additional instrumentation options to the [VSInstr](../profiling/vsinstr.md) tool. These options are available at the session or the target level. For example, to include or exclude specific functions during the instrumentation process, use the additional instrumentation option at the target level.  
  
 **Requirements**  
  
-   [!INCLUDE[vsUltLong](../codequality/includes/vsultlong_md.md)], [!INCLUDE[vsPreLong](../codequality/includes/vsprelong_md.md)], [!INCLUDE[vsPro](../codequality/includes/vspro_md.md)]  
  
> [!IMPORTANT]
>  Every probe that is inserted modifies the behavior of the original program slightly. This modification causes overhead at analysis time. Even though an approximation of this overhead is subtracted, it still has subtle timing effects on multithreaded applications. The [VSInstr](../profiling/vsinstr.md) tool options help control data collection during profiling.  
  
### To specify additional instrumentation option  
  
1.  In **Performance Explorer**, select the **Performance Session** and then right-click and select **Properties**.  
  
2.  In the **Properties Pages**, click the **Advanced** properties.  
  
3.  Type options in the **Additional instrumentation options** box.  
  
     For example, use /CONTROL:THREAD to specify the profiling level. For a complete list of options, see [VSInstr](../profiling/vsinstr.md).  
  
4.  Click **OK**.  
  
## See Also  
 [Configuring Performance Sessions](../profiling/configuring-performance-sessions.md)   
 [Profiling from the Command-Line](../profiling/using-the-profiling-tools-from-the-command-line.md)