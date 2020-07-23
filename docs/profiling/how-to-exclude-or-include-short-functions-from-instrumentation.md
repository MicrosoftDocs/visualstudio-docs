---
title: Exclude or include short functions from instrumentation
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords: 
  - profiling tools, instrument events
  - profiling tools, include short functions
  - profiling tools, exclude short functions
ms.assetid: eaeead79-aafe-4490-86ff-6ed4cad9c15f
author: mikejo5000
ms.author: mikejo
manager: jillfra
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# How to: Exclude or include short functions from instrumentation
By default, the Profiling tools exclude *small functions* from instrumentation. Small functions are short functions that do not make any function calls. Excluding these small functions provides for less instrumentation overhead, and therefore improved instrumentation speed. The exclusion of small functions also reduces the performance profiling data file (.*vsp*) size and the time that is required for analysis. If small functions are excluded, the time that is spent in the small functions counts against the exclusive and inclusive time of their parent functions. Small functions can be excluded or included in instrumentation, as described in the following procedure.

### To exclude or include short functions from instrumentation

1. In **Performance Explorer**, select **Performance Session** and then right-click and select **Properties**.

     The **Property Pages** dialog box is displayed.

2. In the **Property Pages**, click the **Instrumentation** properties.

3. To exclude short functions from instrumentation, select **Exclude short functions from Instrumentation**. This is the default setting.

     -or-

     To include short functions in instrumentation, clear **Exclude short functions from Instrumentation**.

4. Click **OK**.

## See also
- [Control data collection](../profiling/controlling-data-collection.md)
- [Performance session properties](../profiling/performance-session-properties.md)
