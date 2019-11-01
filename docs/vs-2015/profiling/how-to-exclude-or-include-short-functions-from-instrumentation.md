---
title: "How to: Exclude or Include Short Functions from Instrumentation | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "profiling tools, instrument events"
  - "profiling tools, include short functions"
  - "profiling tools, exclude short functions"
ms.assetid: eaeead79-aafe-4490-86ff-6ed4cad9c15f
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Exclude or Include Short Functions from Instrumentation
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By default, the Profiling tools exclude *small functions* from instrumentation. Small functions are short functions that do not make any function calls. Excluding these small functions provides for less instrumentation overhead, and therefore improved instrumentation speed. The exclusion of small functions also reduces the performance profiling data file (.vsp) size and the time that is required for analysis. If small functions are excluded, the time that is spent in the small functions counts against the exclusive and inclusive time of their parent functions. Small functions can be excluded or included in instrumentation, as described in the following procedure.  
  
### To exclude or include short functions from instrumentation  
  
1. In **Performance Explorer**, select **Performance Session** and then right-click and select **Properties**.  
  
     The **Property Pages** dialog box is displayed.  
  
2. In the **Property Pages**, click the **Instrumentation** properties.  
  
3. To exclude short functions from instrumentation, select **Exclude short functions from Instrumentation**. This is the default setting.  
  
     -or-  
  
     To include short functions in instrumentation, clear **Exclude short functions from Instrumentation**.  
  
4. Click **OK**.  
  
## See Also  
 [Controlling Data Collection](../profiling/controlling-data-collection.md)   
 [Performance Session Properties](../profiling/performance-session-properties.md)
