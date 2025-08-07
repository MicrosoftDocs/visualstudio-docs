---
title: Workflow Designer - Parallel Activity Designer
description: Learn about the Parallel activity and how to use the Parallel activity designer to execute a collection of child activities concurrently.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- System.Activities.Statements.Parallel.UI
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Parallel Activity Designer

The <xref:System.Activities.Statements.Parallel> activity executes a collection of child activities concurrently.

## The Parallel Activity

The <xref:System.Activities.Statements.Parallel> activity stores its child activities in a  <xref:System.Activities.Statements.Parallel.Branches%2A> collection. Use the <xref:System.Activities.Statements.Parallel> activity instead of the <xref:System.Activities.Statements.Sequence> activity if some of the child activities may go idle.

The <xref:System.Activities.Statements.Parallel> activity has a <xref:System.Activities.Statements.Parallel.CompletionCondition%2A> property that contains a user specified Visual Basic expression. The <xref:System.Activities.Statements.Parallel> activity evaluates this property after each branch completes. If it evaluates to **True**, then the <xref:System.Activities.Statements.Parallel> activity completes without executing the other branches. If the <xref:System.Activities.Statements.Parallel.CompletionCondition%2A> does not evaluate to **True**, then the <xref:System.Activities.Statements.Parallel> activity completes when all of its child activities have completed.

### Using the Parallel Activity Designer

Access the **Parallel** activity designer in the **Control Flow** category of the **Toolbox**.

The **Parallel** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activity designers are normally placed, for example, inside of a **Sequence** activity designer. After dropping it into the Workflow Designer, it creates a <xref:System.Activities.Statements.Parallel> activity, which by default contains a <xref:System.Activities.Activity.DisplayName%2A> of **Parallel**

To add an activity to the <xref:System.Activities.Statements.Parallel.Branches%2A> collection of the parallel activity, drag some other activity designer from the **Toolbox** and drop it on the triangle inside the **Parallel** activity designer. The triangles flank the activities contained in the branches. Additional activities can be added by repeating this procedure. The activities can be reordered by dragging and dropping them within the **Parallel** activity designer.

### Parallel Activity Properties in the Workflow Designer

The following table shows the Parallel activity properties and describes how they are used in the designer.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|Specifies the friendly display name of the activity designer in the header. The default value is **Parallel**. The value can be optionally edited in the **Properties** grid or directly on the activity designer header.|
|<xref:System.Activities.Statements.Parallel.Branches%2A>|True|Contains the collection of child activities to be executed.|
|<xref:System.Activities.Statements.Parallel.CompletionCondition%2A>|False|Evaluated after a branch completes. If it evaluates to **True**, then the scheduled pending branches are canceled. If this property is not set or evaluates to **False**, the activity completes when all of its child activities have completed. The default value is **null**.|

## See also

- [Sequence](../workflow-designer/sequence-activity-designer.md)
- [ParallelForEach\<T>](../workflow-designer/parallelforeach-t-activity-designer.md)
- [Control Flow](../workflow-designer/control-flow-activity-designers.md)
