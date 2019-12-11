---
title: "How to: Create a Workflow Activity Library (Legacy) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
helpviewer_keywords:
  - "workflows, activity library projects"
  - "workflow activity libraries"
  - "projects, workflow activity libraries"
ms.assetid: fb5aa940-2ae8-4b52-b52c-51c20861a7b4
caps.latest.revision: 8
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create a Workflow Activity Library (Legacy)
Follow these steps to create a Workflow Activity Library project using the legacy [!INCLUDE[wfd1](../includes/wfd1-md.md)] provided by [!INCLUDE[vs2010](../includes/vs2010-md.md)]. Use the legacy [!INCLUDE[wfd2](../includes/wfd2-md.md)] when you need to target either the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)].

### To create a workflow activity library project

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then select **Project**.

     The **New Project** dialog box opens.

3. Select either the **.NET Framework 3.0** option or the **.NET Framework 3.5** option in the drop down list at the top of the **New Project** window to access the legacy designer.

    > [!NOTE]
    > The default option in [!INCLUDE[vs2010](../includes/vs2010-md.md)] is **.NET Framework 4**. This option is used to create [!INCLUDE[wf](../includes/wf-md.md)] applications that target the [!INCLUDE[netfx40_short](../includes/netfx40-short-md.md)] and it does not use the legacy designer.

4. In the **Project Types** pane, select Visual C# or Visual Basic (under **Other Languages**) and then select **Workflow**.

5. In the **Templates** pane, select **Workflow Activity Library**.

6. In the **Name** box, enter a descriptive name for your project to make it easy to identify.

7. In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.

     If you want a solution directory created for the project, select the **Create directory for solution** check box and enter a name in the **Solution Name** box.

8. Click **OK**.

## See Also
 [Creating Legacy Workflow Projects](../workflow-designer/creating-legacy-workflow-projects.md)
 [Using the Legacy Activity Designer](../workflow-designer/using-the-legacy-activity-designer.md)
 [Legacy Workflow Activities](../workflow-designer/legacy-workflow-activities.md)
 [Developing Workflow Activities](https://msdn.microsoft.com/19876dfc-dfa5-4d52-b1f5-1d087474cc52)
 [Windows Workflow Foundation Activities](https://msdn.microsoft.com/192c4c1e-afb6-4f58-ab11-2b5bbbc2d2c0)