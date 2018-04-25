---
title: "Workflow Designer - Debug Stepping Options (Legacy)"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
helpviewer_keywords:
  - "branch stepping"
  - "stepping, options in workflow debugging"
  - "debugging, stepping options"
  - "debugging workflows, stepping options"
  - "instance stepping"
ms.assetid: 3e9e3041-68c7-4f16-9bd6-da5e5144744b
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Debug Stepping Options (Legacy)

This topic describes how to debug Windows Workflow Foundation (WF) applications that have concurrent activities in the legacy Windows Workflow Designer. Use the legacy Workflow Designer when you need to target either the .NET Framework version 3.5 or the WinFX.

When you are debugging legacy activities that have concurrent execution, such as **ParallelActivity** or **ConditionedActivityGroup**, you can use one of the following two options to step through your code.

-   **Branch stepping.** This mode of stepping enables you to step through and debug a particular branch of a composite activity, such as the **ParallelActivity** or the **ConditionalActivityGroup** activity. When you use this option to debug, you will not notice that a change in control occurs due to concurrent execution of other activities in the workflow. The debugger only steps through the activities in the currently selected branch while other activities in the workflow may be executing concurrently. For example, by default, the leftmost branch in a **ParallelActivity** activity and the first child activity of a **ConditionedActivityGroup** activity are used for stepping. If the user is interested in debugging any other branch or child activity, an explicit breakpoint must be placed on that branch or child activity. Stepping continues in that branch when the breakpoint is triggered.

-   **Instance stepping.** This mode of stepping enables you to step through and debug concurrently executing activities in the workflow. With this option, you will notice that a change in control occurs when concurrently executing activities run within the workflow.

By default, the branch stepping option is selected, and users can switch between the two options while debugging a legacy workflow.

You should select the instance stepping option when debugging legacy state machine workflows.

## See also

- [Debugging Legacy Workflows](../workflow-designer/debugging-legacy-workflows.md)
- [How to: Change the Debug Stepping Option (Legacy)](../workflow-designer/how-to-change-the-debug-stepping-option-legacy.md)