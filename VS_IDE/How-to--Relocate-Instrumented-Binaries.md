---
title: "How to: Relocate Instrumented Binaries"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 258f49e8-4b09-477e-a132-8fad685b66f4
caps.latest.revision: 18
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
# How to: Relocate Instrumented Binaries
During instrumentation, probes are inserted into the binary to measure application performance. By choosing to relocate the instrumented binary, a copy of the original binary is instrumented and put in the specified location. This option is useful if you do not want the profiler to rename your original binary. If the binary is not relocated, the original version of the binary is overwritten.  
  
 **Requirements**  
  
-   Visual Studio Ultimate, Visual Studio Premium, Visual Studio Professional  
  
### To relocate instrumented binary  
  
1.  In **Performance Explorer**, right-click the performance session, and then click **Properties**.  
  
2.  In the **Property Pages**, click the **Binary** properties.  
  
3.  Select the **Relocate instrumented binaries** check box.  
  
4.  Specify the location for the instrumented binary.  
  
## See Also  
 [Configuring Performance Sessions](../VS_IDE/Configuring-Performance-Sessions.md)   
 [VSInstr](../VS_IDE/VSInstr.md)