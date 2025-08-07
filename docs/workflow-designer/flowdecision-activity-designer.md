---
title: Workflow Designer - FlowDecision Activity Designer
description: Learn how the FlowDecision node is a conditional node that provides a branch for the flow of control into one of two alternatives.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- System.Activities.Statements.FlowDecision.UI
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# FlowDecision Activity Designer

The <xref:System.Activities.Statements.FlowDecision> node is a conditional node that provides a branch for the flow of control into one of two alternatives based on whether a specified condition is satisfied. If the flow requires more than two branches, use <xref:System.Activities.Statements.FlowSwitch%601> instead.

## The FlowDecision Node

Use <xref:System.Activities.Statements.FlowDecision> when the flow can be branched into two paths. A <xref:System.Activities.Statements.FlowDecision> node has a <xref:System.Activities.Statements.FlowDecision.Condition%2A> and a <xref:System.Activities.Statements.FlowNode> associated with each of two possible outcomes: <xref:System.Activities.Statements.FlowDecision.True%2A> or <xref:System.Activities.Statements.FlowDecision.False%2A>. The <xref:System.Activities.Statements.FlowDecision.Condition%2A> is evaluated and the value of this evaluation determines the next <xref:System.Activities.Statements.FlowNode> to be processed within the <xref:System.Activities.Statements.Flowchart>.

### Using the FlowDecision Designer

The **FlowDecision** designer can be found in the **Flowchart** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the Workflow Designer. Alternatively, select **Toolbox** from the **View** menu, or press **Ctrl**+**Alt**+**X**.

The **FlowDecision** designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface within a **Flowchart** activity designer. This creates a <xref:System.Activities.Statements.FlowDecision> labeled **Decision** within the <xref:System.Activities.Statements.Flowchart> activity. Mouse over the designer and the **True** and **False** square handles for the two branches appear.

After dragging the **FlowDecision** designer and other designers onto the **Flowchart**, the nodes can be linked together to specify the order of execution. To create a link between a source node (including the **True** and **False** branches of the **FlowDecision**) and a destination node, mouse over the designer of the source node and square handles appear on each side of it. Click one of the square handles and drag it by holding down the mouse button to one of the handles that appears in a similar manner around the destination node when you mouse over it. Release the mouse button and a link is between created these two nodes that is represented as an arrow from the source designer to the destination designer.

The expression that states the <xref:System.Activities.Statements.FlowDecision.Condition%2A> can be typed in the **Condition** box of the **Properties** window by clicking where the hint text says "Enter a VB expression".

### The FlowDecision Properties

The following table shows the <xref:System.Activities.Statements.FlowDecision> properties and describes how they are used in the designer. These properties can be edited in the property grid or on the designer surface.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Statements.FlowDecision.Condition%2A>|True|The condition that determines which path the flow control takes.|
|<xref:System.Activities.Statements.FlowDecision.True%2A>|False|The path taken by the flow control if the <xref:System.Activities.Statements.FlowDecision.Condition%2A> is satisfied.|
|<xref:System.Activities.Statements.FlowDecision.False%2A>|False|The path taken by the flow control if the <xref:System.Activities.Statements.FlowDecision.Condition%2A> is not satisfied.|

## See also

- [Flowchart](../workflow-designer/flowchart-activity-designers.md)
- [Flowchart](../workflow-designer/flowchart-activity-designer.md)
- [FlowSwitch\<T>](../workflow-designer/flowswitch-t-activity-designer.md)
