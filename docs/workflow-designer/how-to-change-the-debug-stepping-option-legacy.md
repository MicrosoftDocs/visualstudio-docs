---
title: "Workflow Designer - How to: Change the Debug Stepping Option (Legacy)"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
helpviewer_keywords:
  - "branch stepping"
  - "debugging, stepping options"
  - "debugging workflows, stepping options"
  - "stepping, changing options"
  - "instance stepping"
ms.assetid: aedc06af-d58a-44d6-aee4-f397f1f923a0
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Change the Debug Stepping Option (Legacy)

This topic describes how to change the debug stepping option for Windows Workflow Foundation (WF) applications in the legacy Windows Workflow Designer that have concurrent actions. Use the legacy Workflow Designer when you need to target either the .NET Framework version 3.5 or the WinFX.

When you are debugging legacy activities that have concurrent execution, such as **ParallelActivity** or **ConditionedActivityGroup**, you can use one of two options to step through your code.

Follow these steps to change the debug stepping option in your legacy workflow project.

## Procedures

### To change the debug stepping option

1.  Start Visual Studio.

2.  Open an existing legacy workflow project or create a new project that employs concurrent activities and that targets either the .NET Framework version 3.5 or the WinFX.

3.  On the **Workflow** menu in the legacy Workflow Designer, point to **Debug**, and then point to **Stepping Options**.

4.  Select either **Instance** or **Branch**.

## See also

- [Debugging Legacy Workflows](../workflow-designer/debugging-legacy-workflows.md)
- [Debug Stepping Options (Legacy)](../workflow-designer/debug-stepping-options-legacy.md)