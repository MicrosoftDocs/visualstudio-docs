---
title: "Workflow Designer - How to: Add a New Item to a Workflow Project"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
ms.assetid: 5c6180ca-af10-4513-b0cb-7d478fd84eab
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# How to: Add a New Item to a Workflow Project

After you have created a workflow project, you can add workflow activities, designers, and other familiar Visual Studio items to your project.

The following table lists the Windows Workflow Foundation (WF) items that you can add to a workflow project.

|Name|Description|
|----------|-----------------|
|Activity|An activity to be composed of other activities. Selecting this item adds the same XAML file to the project as you would obtain when selecting the **Activity Library** template for a new project. For more information about on this procedure, see [How to: Create an Activity Library](../workflow-designer/how-to-create-an-activity-library.md).|
|Activity Designer|A designer to customize the design-time experience of an activity. Selecting this item adds the same files to the project as you would obtain when selecting the **Activity Designer Library** template for a new project. For more information about on this procedure, see [How to: Create an Activity Designer Library](../workflow-designer/how-to-create-an-activity-designer-library.md).|
|Code Activity|An activity with execution logic written in code. A source code file with an override of the <xref:System.Activities.CodeActivity.Execute%2A> method is already generated for you.|
|WCF Workflow Service|A [!INCLUDE[indigo2](../workflow-designer/includes/indigo2_md.md)] service built using workflow activities. Selecting this item adds the same files to the project as you would obtain when selecting the **WCF Workflow Service Application** template for a new project. For more information about this procedure, see [How to: Create a WCF Workflow Service Application](../workflow-designer/how-to-create-a-wcf-workflow-service-application.md).|

## To add a new item to a workflow project

1.  On the **Project** menu, click **Add New Item...**.

     The **Add a New Item** dialog box opens.

2.  In the **Installed Templates** pane, select **Workflow** group.

3.  Select one of the four items. The previous table lists the selections available.

4.  Type an appropriate name for the item in the **Name** box at the bottom of the dialog box.

5.  Click **Add** to add the item to the current workflow project.

## See also

- [Creating a Workflow Project](../workflow-designer/creating-a-workflow-project.md)