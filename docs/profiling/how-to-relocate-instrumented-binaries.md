---
title: "How to: Relocate Instrumented Binaries | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.property.binaries"
helpviewer_keywords:
  - "binaries, instrumented"
  - "instrumentation, instrumented binaries"
  - "instrumented binaries and relocating"
  - "profiling tools, instrumented binaries"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# How to: Relocate instrumented binaries

During instrumentation, probes are inserted into the binary to measure application performance. By choosing to relocate the instrumented binary, a copy of the original binary is instrumented and put in the specified location. This option is useful if you do not want the profiler to rename your original binary. If the binary is not relocated, the original version of the binary is overwritten.

## To relocate instrumented binary

1. In **Performance Explorer**, right-click the performance session, and then click **Properties**.

2. In the **Property Pages**, click the **Binary** properties.

3. Select the **Relocate instrumented binaries** check box.

4. Specify the location for the instrumented binary.

## See also

[Configure performance sessions](../profiling/configuring-performance-sessions.md)
[VSInstr](../profiling/vsinstr.md)
