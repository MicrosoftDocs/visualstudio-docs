---
title: "How to: Change the Debug Stepping Option (Legacy) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
helpviewer_keywords:
  - "branch stepping"
  - "debugging, stepping options"
  - "debugging workflows, stepping options"
  - "stepping, changing options"
  - "instance stepping"
ms.assetid: aedc06af-d58a-44d6-aee4-f397f1f923a0
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Change the Debug Stepping Option (Legacy)
This topic describes how to change the debug stepping option for [!INCLUDE[wf](../includes/wf-md.md)] applications in the legacy [!INCLUDE[wfd1](../includes/wfd1-md.md)] that have concurrent actions. Use the legacy [!INCLUDE[wfd2](../includes/wfd2-md.md)] when you need to target either the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)].

 When you are debugging legacy activities that have concurrent execution, such as **ParallelActivity** or **ConditionedActivityGroup**, you can use one of two options to step through your code.

 Follow these steps to change the debug stepping option in your legacy workflow project.

## Procedures

#### To change the debug stepping option

1. Start Visual Studio.

2. Open an existing legacy workflow project or create a new project that employs concurrent activities and that targets either the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)].

3. On the **Workflow** menu in the legacy [!INCLUDE[wfd2](../includes/wfd2-md.md)], point to **Debug**, and then point to **Stepping Options**.

4. Select either **Instance** or **Branch**.

## See Also
 [Debugging Legacy Workflows](../workflow-designer/debugging-legacy-workflows.md)
 [Debug Stepping Options (Legacy)](../workflow-designer/debug-stepping-options-legacy.md)