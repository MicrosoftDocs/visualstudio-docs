---
title: Add Activities to the Toolbox
description: In Workflow Designer, learn how to add activities to the Toolbox in your solution by adding them from within your current project or referencing them from a different project.
ms.date: 11/04/2016
ms.topic: how-to
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Add Activities to the Toolbox

Activities can be added to the **Toolbox** in your solution in several different ways. You can add them from within your current project, reference them from a different project, or reference them from a different assembly.

## To add an activity from within your current project

1. Add a new custom activity to your current workflow project. For more information about adding a new custom activity to your project, see [How to: Add a New Item to a Workflow Project](../workflow-designer/how-to-add-a-new-item-to-a-workflow-project.md).

2. Add custom logic to your activity.

3. Build the project. If the build was successful, a new category in the **Toolbox** named "\<*project name*>" with the custom activity included in that category is displayed.

    > [!NOTE]
    > If the toolbox is reset, custom activities will be removed, even if the solution is built again. To repopulate the toolbox with custom activities after it has been reset, restart Visual Studio.

    > [!NOTE]
    > The toolbox can only show one activity of a given name. If two activities from different assemblies have the same class name, only one will display.

    > [!NOTE]
    > The application domain is shared among editor instances; if static variables are used, they will be shared among editor instances as well. If this is not the desired behavior, a service should be used to track variable instances. See [Using the ModelItem Editing Context](/dotnet/framework/windows-workflow-foundation/using-the-modelitem-editing-context) for information on using services within the designer.

## To add an activity from within a different project

1. Open a solution that contains at least one workflow project and either a custom activity library project or another workflow project that defines a custom activity.

2. Build both projects. If the builds were successful, a new category in the **Toolbox** named "\<*project name*>" with the custom activity included in that category is displayed.

## To add an activity to the Toolbox from an assembly

1. Open a workflow solution.

2. From the **Tools** menu, select **Choose Toolbox Items**.

3. In the **Choose Toolbox Items** dialog box, select the **System.Activities Components** tab then click **Browse** to navigate to the assembly that contains the custom activity you want to add.

4. Select the assembly and click **OK**. The custom activity component is added to the list of components and is automatically selected.

    1. Click **OK** to close the dialog.

5. To display the toolbox, select **Toolbox** from the **View** menu.

6. The custom activity appears in the **Toolbox** under the category that was in focus before the item was added. For example, if the **General** category was selected in the **Toolbox** before adding the toolbox item, the activity appears under the **General** category.

## Related content

- [Using the Workflow Designer](developing-applications-with-the-workflow-designer.md)
