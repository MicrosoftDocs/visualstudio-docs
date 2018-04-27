---
title: "Workflow Designer - How to: Create a State Machine Workflow Library (Legacy)"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
helpviewer_keywords:
  - "projects, state machine workflow library"
  - "state machine workflow libraries"
  - "workflows, state machine workflow library"
ms.assetid: 5bd68c6e-6a98-47d9-826d-9bb7a4fd72f8
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Create a State Machine Workflow Library (Legacy)

Follow these steps to create a State Machine Workflow Library project using the legacy Windows Workflow Designer provided by Visual Studio 2010. Use the legacy Workflow Designer when you need to target either the .NET Framework version 3.5 or the WinFX.

## To create a state machine workflow library project

1.  Start Visual Studio.

2.  On the **File** menu, point to **New**, and then select **Project**.

     The **New Project** dialog box opens.

3.  Select either the **.NET Framework 3.0** option or the **.NET Framework 3.5** option in the drop down list at the top of the **New Project** window to access the legacy designer.

    > [!NOTE]
    > The default option in Visual Studio 2010 is **.NET Framework 4**. This option is used to create Windows Workflow Foundation (WF) applications that target the .NET Framework 4 and it does not use the legacy designer.

4.  In the **Project Types** pane, select Visual C# or Visual Basic (under **Other Languages**) and then select **Workflow**.

5.  In the **Templates** pane, select **State Machine Workflow Library**.

6.  In the **Name** box, enter a descriptive name for your project to make it easy to identify.

7.  In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.

     If you want a solution directory created for the project, select the **Create directory for solution** check box and enter a name in the **Solution Name** box.

8.  Click **OK**.

## See also

- [Creating Legacy Workflow Projects](../workflow-designer/creating-legacy-workflow-projects.md)
- [State Machine Workflows](/dotnet/framework/windows-workflow-foundation/state-machine-workflows)