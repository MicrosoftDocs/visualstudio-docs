---
title: "How to: Create an Activity Designer Library | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
ms.assetid: 5b62e092-63b3-462d-9d77-fb112482f45d
caps.latest.revision: 8
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create an Activity Designer Library
Custom activity designers allow you to create a user interface for a standard or a custom activity. You control the complexity of the user interface and have the ability to create more than one activity designer for an activity. This scenario allows you to create designers that are tailored for multiple audiences.

### To create an Activity Designer Library

1. Start [!INCLUDE[vs2010](../includes/vs2010-md.md)].

2. On the **File** menu, point to **New**, and then select **Project…** to open the **New Project** dialog box.

3. In the **Project Types** pane, select **Workflow** from either the **Visual C#** or **Visual Basic** groupings depending on your preferred language.

4. In the **Templates** pane, select **Activity Designer Library**.

5. In the **Name** box, enter a descriptive name for your project to make it easy to identify.

6. In the **Location** box, enter the directory in which you want to save your project, or click **Browse** to navigate to it.

7. In the **Solution** box, type in a descriptive name for your solution, then click **OK**.

    > [!NOTE]
    > If you want to add a workflow console application to an existing solution, open that solution in [!INCLUDE[vs2010](../includes/vs2010-md.md)], right click on the solution in **Solution Explorer**, and select **Add**, then **New Project…** to open the **New Project** dialog box. Proceed as described above in this procedure.

8. The project template creates an activity designer definition in XAML and the code-behind implementation file in source code. The [!INCLUDE[wfd1](../includes/wfd1-md.md)] opens and displays the canvas for your activity designer.

9. Drag [!INCLUDE[avalon1](../includes/avalon1-md.md)] controls from the **Toolbox** to the design surface to use them in your custom activity designer.  For an example of how to implement a custom activity designer, see [How to: Create a Custom Activity Designer](https://msdn.microsoft.com/library/2f3aade6-facc-44ef-9657-a407ef8b9b31).

    > [!WARNING]
    > Custom activity designers can be used for custom activities as well as for default [!INCLUDE[netfx40_short](../includes/netfx40-short-md.md)]activities.

## See Also
 [Creating a Workflow Project](../workflow-designer/creating-a-workflow-project.md)