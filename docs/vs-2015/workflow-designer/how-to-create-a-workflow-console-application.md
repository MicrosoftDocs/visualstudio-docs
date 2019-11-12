---
title: "How to: Create a Workflow Console Application | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
ms.assetid: 51a2eea7-921c-49f1-b358-68afc27f1ee9
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create a Workflow Console Application
[!INCLUDE[wf](../includes/wf-md.md)] allows you to create workflows for executing system or human processes. The [!INCLUDE[wfd1](../includes/wfd1-md.md)] provides the design surface for creating these workflows. The [!INCLUDE[wfd2](../includes/wfd2-md.md)] can be used to create workflows from within [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] or it can be integrated into other applications that rehost the designer.

 This topic describes how to use the [!INCLUDE[wfd2](../includes/wfd2-md.md)] in [!INCLUDE[vs2010](../includes/vs2010-md.md)] to create a workflow in a console application.

### To create a workflow console application

1. Start [!INCLUDE[vs2010](../includes/vs2010-md.md)].

2. On the **File** menu, point to **New**, and then select **Project…**.

     The **New Project** dialog box opens.

3. In the **Installed Templates** pane, select **Workflow** from either the **Visual C#** or **Visual Basic** groupings, depending on your language of preference.

4. In the middle pane, select **Workflow Console Application**.

5. In the **Name** box, enter a descriptive name for your project to make it easy to identify.

6. In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.

7. In the **Solution** box, enter the name for the new solution. Click **OK** to create the application.

    > [!NOTE]
    > If you want to add a workflow console application to an existing solution, open that solution in [!INCLUDE[vs2010](../includes/vs2010-md.md)], right click the solution in **Solution Explorer**, and select **Add**, then **New Project…** to open the **New Project** dialog box. Proceed as described above in this procedure.

8. The project template creates a workflow definition in XAML and the console application definition is in source code. The [!INCLUDE[wfd2](../includes/wfd2-md.md)] opens and displays the canvas for the workflow you created.

9. To compose a workflow, drag activities or other workflow items from the **Toolbox** to the design surface in your workflow.

## See Also
 [Creating a Workflow Project](../workflow-designer/creating-a-workflow-project.md)