---
title: 'Workflow Designer: Add a new item to workflow project'
description: Learn how you can add workflow activities, designers, and other familiar Visual Studio items to your project after you've created a workflow project.
ms.date: 06/25/2018
ms.topic: how-to
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Add a new item to a workflow project

After you've created a workflow project, you can add workflow activities, designers, and other familiar Visual Studio items to your project.

The following table lists the Windows Workflow Foundation (WF) items that you can add to a workflow project:

| Name | Description |
|-| - |
| Activity | An activity to be composed of other activities. Selecting this item adds the same XAML file to the project as you would obtain when selecting the **Activity Library** template for a new project. For more information about on this procedure, see [Create a workflow project](creating-a-workflow-project.md). |
| Activity Designer | A designer to customize the design-time experience of an activity. Selecting this item adds the same files to the project as you would obtain when selecting the **Activity Designer Library** template for a new project. |
| Code Activity | An activity with execution logic written in code. A source code file with an override of the <xref:System.Activities.CodeActivity.Execute%2A> method is already generated for you. |
| WCF Workflow Service | A WCF service built using workflow activities. Selecting this item adds the same files to the project as you would obtain when selecting the **WCF Workflow Service Application** template for a new project. For more information about this procedure, see [How to: Create a WCF Workflow Service Application](creating-a-workflow-project.md). |

## To add a new item to a workflow project

1. On the **Project** menu, select **Add New Item**.

   The **Add New Item** dialog box opens.

1. In the left-hand pane, select the **Workflow** category, and then select a workflow item template.

   > [!NOTE]
   > If you don't see the **Workflow** category, first install the **Windows Workflow Foundation** component of Visual Studio. For detailed instructions, see [Install Windows Workflow Foundation](developing-applications-with-the-workflow-designer.md#install-windows-workflow-foundation).

1. Enter a name for the item in the **Name** box at the bottom of the dialog box.

1. Select **Add** to add the item to the project.

## Related content

- [Create a workflow project](../workflow-designer/creating-a-workflow-project.md)
