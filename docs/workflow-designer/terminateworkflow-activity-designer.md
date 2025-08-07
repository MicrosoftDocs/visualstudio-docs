---
title: TerminateWorkflow activity designer
description: In Workflow Designer, learn how you can use the TerminateWorkflow activity designer to create and configure a TerminateWorkflow activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- System.Activities.Statements.TerminateWorkflow.UI
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# TerminateWorkflow Activity Designer

The **TerminateWorkflow** activity designer is used to create and configure a <xref:System.Activities.Statements.TerminateWorkflow> activity.

## The TerminateWorkflow Activity

The <xref:System.Activities.Statements.TerminateWorkflow> activity terminates the execution of a workflow.

### Using the TerminateWorkflow Activity Designer

The **TerminateWorkflow** activity designer can be found in the **Runtime** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab (Alternatively, select **Toolbox** from the **View** menu or CTRL+ALT+X.)

The **TerminateWorkflow** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates a <xref:System.Activities.Statements.TerminateWorkflow> activity with a default **DisplayName** of TerminateWorkflow. The <xref:System.Activities.Activity.DisplayName%2A> can be edited in the header of the **TerminateWorkflow** activity designer or in the **DisplayName** box of the property grid.

### The TerminateWorkflow Properties

The following table shows the <xref:System.Activities.Statements.TerminateWorkflow> properties and describes how they are used in the designer. These properties can be edited in property grid and some of them can be edited on Workflow Designer surface.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.Activities.Statements.TerminateWorkflow> activity. The default is TerminateWorkflow. Although the display name is not strictly required, it is a best practice to use a display name.|
|<xref:System.Activities.Statements.TerminateWorkflow.Exception%2A>|False|The exception to throw when the workflow is terminated. Set this property in the property grid.|
|<xref:System.Activities.Statements.TerminateWorkflow.Reason%2A>|False|The reason that explains why the workflow was terminated. Set this property in the property grid.|

## See also

- [Runtime](../workflow-designer/runtime-activity-designers.md)
- [Persist](../workflow-designer/persist-activity-designer.md)
