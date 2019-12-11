---
title: "How to: Invoke the Workflow Debugger | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
ms.assetid: 34c592af-f4f6-4d02-99f6-63a94698e48b
caps.latest.revision: 9
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Invoke the Workflow Debugger
Generally, you debug workflows just like you debug programs written in other Visual Studio programming languages. You can start the workflow debugger in the following ways:

- Select **Attach to Process** on the **Debug** menu to select the running host process for your workflow instance. This procedure is the same as attaching to a host process in managed code.

- Press **F5** to start running an instance of the workflow, or to continue to run after a breakpoint has been hit.

- Use remote debugging. For information on using remote debugging, see [How to: Enable Remote Debugging](https://go.microsoft.com/fwlink/?LinkId=196257).

    > [!NOTE]
    > If the workflow application targets the x86 architecture and is hosted on a machine running a 64 bit operating system, then remote debugging will not work unless [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] is installed on the remote machine or the target for the workflow application is changed to **Any CPU**.

### Stepping through Code

- **Step In**: You can step into an activity using **F11**. The debugger steps into any handler that is defined. If no handler is defined, you step over the activity, or with composite activities, which contain other activities, you step into the first executing activity.

- **Step Out:** You can step out of an activity using **Shift-F11**. Stepping out of an activity runs the current activity and all its sibling activities to completion. The debugger then breaks on the current activity's parent. When stepping out from a code handler, the debugger breaks on the activity with which the handler is associated.

- **Step Over**: You can step over an activity using **F10**. When stepping over a composite activity, the debugger breaks on the first executable child of the composite activity. When stepping over a non-composite, such as an <xref:System.Activities.Statements.Assign> activity, the debugger executes the activity and its associated handlers and breaks on the next activity. If the activity that is executed is the last child activity in a composite activity, then, after execution, the debugger breaks on the parent activity.

### Debugging with F5

- If you are building a Workflow Console Application project, simply press **F5** to begin debugging into your application and workflow. If you are building an activity library on its own, you must have an executable host application as a startup project. To set a startup project in **Solution Explorer**, right-click the project name of the host and select **Set as StartUp Project**.

## See Also
 [How to: Set Breakpoints in Workflows](../workflow-designer/how-to-set-breakpoints-in-workflows.md)
 [Debugging Workflows with the Workflow Designer](../workflow-designer/debugging-workflows-with-the-workflow-designer.md)