---
title: Unsupported debugging scenarios
description: Learn about unsupported debugging scenarios in the Workflow Designer, for example, "Execution cannot be continued after code has been edited."
ms.date: 11/04/2016
ms.topic: reference
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Unsupported debugging scenarios in the Workflow Designer

The Workflow Designer does not support the following debugging scenarios:

- Execution cannot be continued after code has been edited.

- Execution cannot be continued from an arbitrary point in the workflow (Set Next).

- Execution cannot be continued until the cursor is reached (Run to Cursor).

- The workflow designer cannot be used to debug workflows created in code without the use of the designer.

- Workflows created in earlier versions of Windows Workflow Foundation (WF) cannot be debugged in .NET Framework 4 or later.

- Breakpoints cannot be defined on links between activities or <xref:System.Activities.Statements.Flowchart> nodes.

- The clipboard is not available during debugging.

- Breakpoints are not retained when activities are copied or pasted.

- Workflow breakpoints cannot be set in the call stack window.

- When creating breakpoints in the designer, the **Line** and **Character** settings in the **New Breakpoint** dialog are not used.

- The Breakpoint window or shortcut menu does not support the following columns or options for workflow debugging:

  - Condition

  - Hit Count

  - When Hit

  - Function

  - Data

  - Process

  - Go to Disassembly
