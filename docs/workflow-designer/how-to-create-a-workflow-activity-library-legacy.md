---
title: "Workflow Designer - How to: Create a Workflow Activity Library (Legacy)"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
helpviewer_keywords:
  - "workflows, activity library projects"
  - "workflow activity libraries"
  - "projects, workflow activity libraries"
ms.assetid: fb5aa940-2ae8-4b52-b52c-51c20861a7b4
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Create a Workflow Activity Library (Legacy)

Follow these steps to create a Workflow Activity Library project using the legacy Windows Workflow Designer provided by Visual Studio 2010. Use the legacy Workflow Designer when you need to target either the .NET Framework version 3.5 or the WinFX.

## To create a workflow activity library project

1.  Start Visual Studio.

2.  On the **File** menu, point to **New**, and then select **Project**.

     The **New Project** dialog box opens.

3.  Select either the **.NET Framework 3.0** option or the **.NET Framework 3.5** option in the drop down list at the top of the **New Project** window to access the legacy designer.

    > [!NOTE]
    > The default option in Visual Studio 2010 is **.NET Framework 4**. This option is used to create Windows Workflow Foundation (WF) applications that target the .NET Framework 4 and it does not use the legacy designer.

4.  In the **Project Types** pane, select Visual C# or Visual Basic (under **Other Languages**) and then select **Workflow**.

5.  In the **Templates** pane, select **Workflow Activity Library**.

6.  In the **Name** box, enter a descriptive name for your project to make it easy to identify.

7.  In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.

     If you want a solution directory created for the project, select the **Create directory for solution** check box and enter a name in the **Solution Name** box.

8.  Click **OK**.

## See also

- [Creating Legacy Workflow Projects](../workflow-designer/creating-legacy-workflow-projects.md)
- [Using the Legacy Activity Designer](../workflow-designer/using-the-legacy-activity-designer.md)
- [Legacy Workflow Activities](../workflow-designer/legacy-workflow-activities.md)
- [Developing Workflow Activities](http://msdn.microsoft.com/en-us/19876dfc-dfa5-4d52-b1f5-1d087474cc52)
- [Windows Workflow Foundation Activities](http://msdn.microsoft.com/en-us/192c4c1e-afb6-4f58-ab11-2b5bbbc2d2c0)