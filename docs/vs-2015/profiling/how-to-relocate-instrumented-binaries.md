---
title: "How to: Relocate Instrumented Binaries | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.performance.property.binaries"
helpviewer_keywords: 
  - "binaries, instrumented"
  - "instrumentation, instrumented binaries"
  - "instrumented binaries and relocating"
  - "profiling tools, instrumented binaries"
ms.assetid: 258f49e8-4b09-477e-a132-8fad685b66f4
caps.latest.revision: 23
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Relocate Instrumented Binaries
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

During instrumentation, probes are inserted into the binary to measure application performance. By choosing to relocate the instrumented binary, a copy of the original binary is instrumented and put in the specified location. This option is useful if you do not want the profiler to rename your original binary. If the binary is not relocated, the original version of the binary is overwritten.  
  
 **Requirements**  
  
- [!INCLUDE[vsUltLong](../includes/vsultlong-md.md)], [!INCLUDE[vsPreLong](../includes/vsprelong-md.md)], [!INCLUDE[vsPro](../includes/vspro-md.md)]  
  
### To relocate instrumented binary  
  
1. In **Performance Explorer**, right-click the performance session, and then click **Properties**.  
  
2. In the **Property Pages**, click the **Binary** properties.  
  
3. Select the **Relocate instrumented binaries** check box.  
  
4. Specify the location for the instrumented binary.  
  
## See Also  
 [Configuring Performance Sessions](../profiling/configuring-performance-sessions.md)   
 [VSInstr](../profiling/vsinstr.md)
