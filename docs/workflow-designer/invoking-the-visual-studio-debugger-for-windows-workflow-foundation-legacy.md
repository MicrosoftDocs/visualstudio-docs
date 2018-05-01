---
title: "Workflow Designer - Invoking the Visual Studio Debugger for Windows Workflow Foundation (Legacy)"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
helpviewer_keywords:
  - "stepping"
  - "Step Over command"
  - "stepping, commands"
  - "debugging, using workflow debugger"
  - "workflows, debugger"
  - "workflow debugger, starting"
  - "Step In command"
  - "debugger, workflow"
  - "Step Out command"
  - "debugging workflows, starting the debugger"
ms.assetid: d6f58e35-5cce-4ff2-9afc-b2d9d0f819cf
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Invoking the Visual Studio Debugger for Windows Workflow Foundation (Legacy)

This topic describes how use the Visual Studio Debugger to debug Windows Workflow Foundation (WF) applications in the legacy Windows Workflow Designer. Use the legacy Workflow Designer when you need to target either the .NET Framework version 3.5 or the WinFX.

Generally, you debug legacy workflows just like you debug programs written in other Visual Studio programming languages. You can start the Visual Studio Debugger for Windows Workflow Foundation in the following ways:

-   Select **Attach to Process** on the **Debug** menu to select a running workflow instance from the available processes.

-   Press **F5** to start running an instance of the workflow, or to continue to run after a breakpoint has been hit.

## Stepping Through Code

The debugger supports one of the most common debugging procedures, stepping, which is executing code one line at a time. There are three commands for stepping through code:

-   **Step In**: You can step into an activity using **F11**. The debugger steps into any handler that is defined. If no handler is defined, you step over the activity, or with composite activities, which contain other activities, you step into the first executing activity. Stepping into code handlers from the designer is not supported for the following activities: **IfElseActivity**, **WhileActivity**, **ConditionedActivityGroup**, or the **ReplicatorActivity**. To debug the handlers associated with these activities, you must put explicit breakpoints in the code.

-   **Step Out**: You can step out of an activity using **Shift-F11**. Stepping out of an activity runs the current activity and all its sibling activities to completion. The debugger then breaks on the current activity's parent. When stepping out from a code handler, the debugger breaks on the activity with which the handler is associated.

-   **Step Over**: You can step over an activity using **F10**. When stepping over a composite activity. the debugger breaks on the first executable child of the composite activity. When stepping over a non-composite, such as a **CodeActivity** activity, the debugger executes the activity and its associated handlers and breaks on the next activity. If the activity that is executed is the last child activity in a composite activity, then after execution, the debugger breaks on the parent activity.

## Attaching to a Process
 To debug a workflow by attaching to a process, select the available process from the **Available Processes** list box in the **Attach to Process** dialog box. If **Automatic: Workflow Code** is not displayed in the **Attach to** text box, then click **Select**. In the **Select Code Type** dialog box, click **Debug these code types** and select **Workflow**. Then click **OK** and click **Attach**.

## Debugging with F5
 If a workflow host application and workflow DLL are located in different Visual Studio projects, for example, when you are using a workflow activity library, you must set the workflow DLL project as the Visual Studio solution startup project to debug the workflow using **F5**. You must also set the path to the host application in the workflow DLL project's **Start external program** property.

 To set a startup project in Solution Explorer, right-click the project name and select **Set as StartUp Project**. To set the path to the host in the **Start external program** property, double-click the workflow project's **Properties** node in Solution Explorer and select the **Debug** tab. Under **Start Action**, select **Start external program** and enter the path to the .exe file that is hosting the workflow you want to debug.

 If the host application is set as the startup project, only the Visual Studio debugger is invoked for debugging; the Visual Studio Debugger for Windows Workflow Foundation is not invoked. If the Visual Studio debugger is used, only C# or Visual Basic code breakpoints are hit; breakpoints set in the workflow designer are not hit. For example, a breakpoint that you set on a <xref:System.Workflow.Activities.ParallelActivity> activity in the designer is hit if the Visual Studio Debugger for Windows Workflow Foundation is used, but not when you use the Visual Studio debugger.

## See also

- [How to: Set Breakpoints in Workflows (Legacy)](../workflow-designer/how-to-set-breakpoints-in-workflows-legacy.md)
- [Debugging Legacy Workflows](../workflow-designer/debugging-legacy-workflows.md)