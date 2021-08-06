---
title: Specify Additional Instrumentation Options | Microsoft Docs
description: Learn how you can instrument binaries from using the Visual Studio IDE or by using command line tools.
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords: 
  - vs.performance.property.advanced
helpviewer_keywords: 
  - instrumentation, options
  - profiling tools, session options
  - performance sessions, options
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - multiple
---
# How to: Specify additional instrumentation options

You can instrument binaries from using the Visual Studio IDE or by using command line tools. If you instrument a binary from within the IDE, you can control the volume of data that is collected during instrumentation by specifying additional instrumentation options to the [VSInstr](../profiling/vsinstr.md) tool. These options are available at the session or the target level. For example, to include or exclude specific functions during the instrumentation process, use the additional instrumentation option at the target level.

> [!IMPORTANT]
> Every probe that is inserted modifies the behavior of the original program slightly. This modification causes overhead at analysis time. Even though an approximation of this overhead is subtracted, it still has subtle timing effects on multithreaded applications. The [VSInstr](../profiling/vsinstr.md) tool options help control data collection during profiling.

## To specify additional instrumentation option

1. In **Performance Explorer**, select the **Performance Session** and then right-click and select **Properties**.

2. In the **Properties Pages**, click the **Advanced** properties.

3. Type options in the **Additional instrumentation options** box.

     For example, use /CONTROL:THREAD to specify the profiling level. For a complete list of options, see [VSInstr](../profiling/vsinstr.md).

4. Click **OK**.

## See also

[Configure performance sessions](../profiling/configuring-performance-sessions.md)
[Profile from the command-line](../profiling/using-the-profiling-tools-from-the-command-line.md)
