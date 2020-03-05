---
title: "How to: Create Workflow Projects (Legacy) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
helpviewer_keywords:
  - "workflow projects, creating"
  - "projects, workflow"
ms.assetid: 32299555-662c-469d-a90d-89f4700dc78c
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create Workflow Projects (Legacy)
Follow these steps to create a [!INCLUDE[wf](../includes/wf-md.md)] project that targets the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)]. This procedure uses the legacy [!INCLUDE[wfd1](../includes/wfd1-md.md)] provided by [!INCLUDE[vs2010](../includes/vs2010-md.md)].

### To create a workflow project

1. Start [!INCLUDE[vs_current_long](../includes/vs-current-long-md.md)].

2. On the **File** menu, point to **New**, and then select **Project**.

     The **New Project** dialog box opens.

3. Select either the **.NET Framework 3.0** option or the **.NET Framework 3.5** option in the drop down list at the top of the **New Project** window to access the legacy designer.

    > [!NOTE]
    > The default option in [!INCLUDE[vs2010](../includes/vs2010-md.md)] is **.NET Framework 4**. This option is used to create [!INCLUDE[wf](../includes/wf-md.md)] applications that target the [!INCLUDE[netfx40_short](../includes/netfx40-short-md.md)] and it does not use the legacy designer.

4. In the **Project Types** pane, select Visual C# projects or Visual Basic projects, and then select **Workflow**.

5. In the **Templates** pane, select one of the installed project templates:

    - Sequential Workflow Console Application

    - Sequential Workflow Library

    - Workflow Activity Library

    - State Machine Workflow Console Application

    - State Machine Workflow Library

    - Empty Workflow Project

6. In the **Name** box, enter a descriptive name for your project to make it easy to identify.

7. In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to the directory.

     If you want a solution directory created for the project, select the **Create directory for solution** check box and enter a name in the **Solution Name** box.

8. Click **OK**.

## See Also
 [Creating Legacy Workflow Projects](../workflow-designer/creating-legacy-workflow-projects.md)