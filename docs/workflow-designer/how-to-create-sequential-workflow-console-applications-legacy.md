---
title: "Workflow Designer - How to: Create Sequential Workflow Console Applications (Legacy)"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
helpviewer_keywords:
  - "workflows, console applications"
  - "sequential workflows, console applications"
  - "console applications, sequential workflow"
ms.assetid: 9f7be7fa-551f-42c6-a9bb-f5ae8ab83625
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Create Sequential Workflow Console Applications (Legacy)

Follow these steps to create a Sequential Workflow Console Application project using the legacy Windows Workflow Designer provided by Visual Studio 2010. Use the legacy Workflow Designer when you need to target either the .NET Framework version 3.5 or the WinFX.

## To create a sequential workflow console application

1.  Start Visual Studio.

2.  On the **File** menu, point to **New**, and then select **Project**.

     The **New Project** dialog box opens.

3.  Select either the **.NET Framework 3.0** option or the **.NET Framework 3.5** option in the drop down list at the top of the **New Project** window to access the legacy designer.

    > [!NOTE]
    > The default option in Visual Studio 2010 is **.NET Framework 4**. This option is used to create Windows Workflow Foundation (WF) applications that target the .NET Framework 4 and it does not use the legacy designer.

4.  In the **Project Types** pane, select Visual C# projects or Visual Basic projects (under **Other Languages**), and then select **Workflow**.

5.  In the **Templates** pane, select **Sequential Workflow Console Application**.

6.  In the **Name** box, enter a descriptive name for your project to make it easy to identify.

7.  In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.

     The Windows Forms Designer opens and displays Form1 of the project you created.

8.  Click **OK**.

     The Workflow Designer opens and displays the workflow design surface of the sequential workflow you created.

9. Drag an activity from the **Toolbox** to the design surface in the **Drop activity** designated area.

## See also

- [Creating Legacy Workflow Projects](../workflow-designer/creating-legacy-workflow-projects.md)
- [Developing Workflows](http://msdn.microsoft.com/en-us/557bcb1f-a7ab-49f6-8df7-2706b7001301)