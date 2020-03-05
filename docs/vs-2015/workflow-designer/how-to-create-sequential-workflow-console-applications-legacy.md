---
title: "How to: Create Sequential Workflow Console Applications (Legacy) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
helpviewer_keywords:
  - "workflows, console applications"
  - "sequential workflows, console applications"
  - "console applications, sequential workflow"
ms.assetid: 9f7be7fa-551f-42c6-a9bb-f5ae8ab83625
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create Sequential Workflow Console Applications (Legacy)
Follow these steps to create a Sequential Workflow Console Application project using the legacy [!INCLUDE[wfd1](../includes/wfd1-md.md)] provided by [!INCLUDE[vs2010](../includes/vs2010-md.md)]. Use the legacy [!INCLUDE[wfd2](../includes/wfd2-md.md)] when you need to target either the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)].

### To create a sequential workflow console application

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then select **Project**.

     The **New Project** dialog box opens.

3. Select either the **.NET Framework 3.0** option or the **.NET Framework 3.5** option in the drop down list at the top of the **New Project** window to access the legacy designer.

    > [!NOTE]
    > The default option in [!INCLUDE[vs2010](../includes/vs2010-md.md)] is **.NET Framework 4**. This option is used to create [!INCLUDE[wf](../includes/wf-md.md)] applications that target the [!INCLUDE[netfx40_short](../includes/netfx40-short-md.md)] and it does not use the legacy designer.

4. In the **Project Types** pane, select Visual C# projects or Visual Basic projects (under **Other Languages**), and then select **Workflow**.

5. In the **Templates** pane, select **Sequential Workflow Console Application**.

6. In the **Name** box, enter a descriptive name for your project to make it easy to identify.

7. In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.

     The Windows Forms Designer opens and displays Form1 of the project you created.

8. Click **OK**.

     The Workflow Designer opens and displays the workflow design surface of the sequential workflow you created.

9. Drag an activity from the **Toolbox** to the design surface in the **Drop activity** designated area.

## See Also
 [Creating Legacy Workflow Projects](../workflow-designer/creating-legacy-workflow-projects.md)
 [Developing Workflows](https://msdn.microsoft.com/557bcb1f-a7ab-49f6-8df7-2706b7001301)