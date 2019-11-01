---
title: "How to: Create a State Machine Workflow Library (Legacy) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
helpviewer_keywords:
  - "projects, state machine workflow library"
  - "state machine workflow libraries"
  - "workflows, state machine workflow library"
ms.assetid: 5bd68c6e-6a98-47d9-826d-9bb7a4fd72f8
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create a State Machine Workflow Library (Legacy)
Follow these steps to create a State Machine Workflow Library project using the legacy [!INCLUDE[wfd1](../includes/wfd1-md.md)] provided by [!INCLUDE[vs2010](../includes/vs2010-md.md)]. Use the legacy [!INCLUDE[wfd2](../includes/wfd2-md.md)] when you need to target either the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)].

### To create a state machine workflow library project

1. Start Visual Studio.

2. On the **File** menu, point to **New**, and then select **Project**.

     The **New Project** dialog box opens.

3. Select either the **.NET Framework 3.0** option or the **.NET Framework 3.5** option in the drop down list at the top of the **New Project** window to access the legacy designer.

    > [!NOTE]
    > The default option in [!INCLUDE[vs2010](../includes/vs2010-md.md)] is **.NET Framework 4**. This option is used to create [!INCLUDE[wf](../includes/wf-md.md)] applications that target the [!INCLUDE[netfx40_short](../includes/netfx40-short-md.md)] and it does not use the legacy designer.

4. In the **Project Types** pane, select Visual C# or Visual Basic (under **Other Languages**) and then select **Workflow**.

5. In the **Templates** pane, select **State Machine Workflow Library**.

6. In the **Name** box, enter a descriptive name for your project to make it easy to identify.

7. In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.

     If you want a solution directory created for the project, select the **Create directory for solution** check box and enter a name in the **Solution Name** box.

8. Click **OK**.

## See Also
 [Creating Legacy Workflow Projects](../workflow-designer/creating-legacy-workflow-projects.md)
 [State Machine Workflows](https://msdn.microsoft.com/library/344caacd-bf3b-4716-bd5a-eca74fc5a61d)