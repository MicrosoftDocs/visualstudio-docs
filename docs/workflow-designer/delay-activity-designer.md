---
title: "Workflow Designer - Delay Activity Designer"
description: Learn about Delay activities and how you can use the Delay activity designer to create and configure a Delay activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "System.Activities.Statements.Delay.UI"
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Delay Activity Designer

The **Delay** activity designer is used to create and configure a <xref:System.Activities.Statements.Delay> activity.

## The Delay activity

The <xref:System.Activities.Statements.Delay> activity delays the execution of a workflow for a specified amount of time.

### Use the Delay Activity Designer

The **Delay** activity designer can be found in the **Primitives** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab of the Workflow Designer. Alternatively, select **Toolbox** from the **View** menu, or press **Ctrl**+**Alt**+**X**.

The **Delay** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. Dropping the activity designer creates a <xref:System.Activities.Statements.Delay> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of Delay. The <xref:System.Activities.Activity.DisplayName%2A> can be edited in the header of the **Delay** activity designer or in the **DisplayName** box of the property grid.

### The Delay properties

The following table shows the <xref:System.Activities.Statements.Delay> properties and describes how they're used in the designer. These properties can be edited in the property grid and some of them can be edited on the Workflow Designer surface.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.Activities.Statements.Delay> activity. The default is Delay. Although the <xref:System.Activities.Activity.DisplayName%2A> value isn't strictly required, it's a best practice to use one.|
|<xref:System.Activities.Statements.Delay.Duration%2A>|True|The amount of time to delay the workflow. This property is set in the property grid. Type in either a literal <xref:System.TimeSpan> in the format 00:00:00 or a Visual Basic expression to specify the amount of time.|

## See also

- [Primitives](../workflow-designer/primitives-activity-designers.md)
- [Assign](../workflow-designer/assign-activity-designer.md)
- [Delay Activity Designer](../workflow-designer/delay-activity-designer.md)
- [InvokeMethod](../workflow-designer/invokemethod-activity-designer.md)
- [WriteLine](../workflow-designer/writeline-activity-designer.md)