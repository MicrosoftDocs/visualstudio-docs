---
title: Debugging Workflows with the Workflow Designer
description: Learn how the Workflow Designer provides the ability to debug workflows and custom activities with a process similar to that of the default Visual Studio debugger.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- Visual Studio Workflow Designer [WFD], debugging workflows
- Workflow Designer [WFD], debugging workflows
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Debug workflows with the Workflow Designer

The **Workflow Designer** provides the ability to debug workflows and custom activities. The process and behavior are similar to that of the default Visual Studio debugger.

## Invoke the workflow debugger

Generally, you debug workflows just like you debug programs written in other Visual Studio programming languages. You can start the workflow debugger in the following ways:

- Select **Attach to Process** on the **Debug** menu to select the running host process for your workflow instance. This procedure is the same as attaching to a host process in managed code.

- Press **F5** to start running an instance of the workflow, or to continue to run after a breakpoint has been hit.

- Use remote debugging. For information on using remote debugging, see [How to: Enable remote debugging](/previous-versions/visualstudio/visual-studio-2010/febz73k0(v=vs.100)).

   > [!NOTE]
   > If the workflow application targets the x86 architecture and is hosted on a machine running a 64 bit operating system, then remote debugging won't work unless Visual Studio is installed on the remote machine or the target for the workflow application is changed to **Any CPU**.

## Step through code

- **Step In**: Step into an activity by pressing **F11**. The debugger steps into any handler that is defined. If no handler is defined, you step over the activity, or with composite activities, which contain other activities, you step into the first executing activity.

- **Step Out:** Step out of an activity by pressing **Shift**+**F11**. Stepping out of an activity runs the current activity and all its sibling activities to completion. The debugger then breaks on the current activity's parent. When stepping out from a code handler, the debugger breaks on the activity with which the handler is associated.

- **Step Over**: Step over an activity by pressing **F10**. When stepping over a composite activity, the debugger breaks on the first executable child of the composite activity. When stepping over a non-composite, such as an <xref:System.Activities.Statements.Assign> activity, the debugger executes the activity and its associated handlers and breaks on the next activity. If the activity that is executed is the last child activity in a composite activity, then, after execution, the debugger breaks on the parent activity.

## Debug with F5

If you're building a Workflow console app, simply press **F5** to begin debugging into your application and workflow. If you are building an activity library on its own, you must specify an executable host application as the startup project. To set a startup project in **Solution Explorer**, right-click the project name of the host and select **Set as StartUp Project**.
