---
title: "Isolate a performance issue"
description: "Learn how to use .NET Counters and the Instrumentation tools to isolate performance issues."
ms.date: 06/13/2024
ms.topic: conceptual
dev_langs:
  - "CSharp"
helpviewer_keywords:
  - "isolate performance issues, profiling tools"
  - "profiling tools, .NET Counters"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
monikerRange: '>= vs-2022'
---

# Isolate a performance issue (C#, Visual Basic, F#)

In this article, we show how you can use profiling tools start to investigate performance issues and isolate problem areas. 

Rather than providing step-by-step instructions, the intent here is to show you how to use the profiling tools effectively and how to interpret the data. Like the CPU Usage tool, the .NET Counters tool is also a good starting point for an investigation. Once you identify interesting data, you can use other profiling tools to investigate more deeply. To compare tools, see [Which tool should I choose?](../profiling/choose-performance-tool.md)

## Start an investigation

- Start your investigation by watching .NET counters while collecting performance data. The .NET Counters tool is often helpful to begin performance investigations and to optimize code to reduce cost.
- Next, if you would like additional insights to help isolate issues or improve the performance, considering collecting a trace using one of the other profiling tools. For example:
  - If CPU Usage is high, try the CPU Usage tool.
  - If CPU Usage is low, try the Instrumentation tool. Since Instrumentation provides wall clock time and exact call counts, it can be helpful to identify performance issues when CPU Usage is low.



:::image type="content" source="./media/optimize-code-database.png" alt-text="Screenshot of Database queries in the Database tool.":::



## Next steps

The following articles and blog posts provide more information to help you learn to use the Visual Studio performance tools effectively.

- [Beginner's guide to optimizing code](../profiling/optimize-code-using-profiling-tools.md)
- [Improving Visual Studio performance with the new Instrumentation Tool](https://devblogs.microsoft.com/visualstudio/improving-visual-studio-performance-with-the-new-instrumentation-tool/)
- [Case Study: Double performance in under 30 minutes](https://devblogs.microsoft.com/visualstudio/case-study-double-performance-in-under-30-minutes/)

## Related content

- [First look at profiling](../profiling/choose-performance-tool.md)
- [Which tool should I use?](../profiling/choose-performance-tool.md)
