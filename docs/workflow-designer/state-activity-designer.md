---
title: Workflow Designer - State Activity Designer
description: Learn about the StateMachine activity and how you can use the State activity designer to add a state to a workflow.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- System.Activities.Statements.State.UI
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# State Activity Designer

A <xref:System.Activities.Statements.State> represents a state in which a state machine can be in.

## Using the State Activity Designer

To add a <xref:System.Activities.Statements.State> to a workflow, drag the **State** activity designer from the **State Machine** section of the **Toolbox** and drop it on to a <xref:System.Activities.Statements.StateMachine> activity on the Workflow Designer surface. A <xref:System.Activities.Statements.State> activity can be dropped onto a <xref:System.Activities.Statements.StateMachine> and transitions added later; or a transition can be created as the <xref:System.Activities.Statements.State> activity is dropped. To add a <xref:System.Activities.Statements.State> activity and create a transition in one step, drag a **State** activity from the **State Machine** section of the **Toolbox** and hover it over another state in the workflow designer. When the dragged <xref:System.Activities.Statements.State> is over another <xref:System.Activities.Statements.State>, four triangles will appear around the other <xref:System.Activities.Statements.State>. If the <xref:System.Activities.Statements.State> is dropped onto one of the four triangles, it is added to the state machine and a transition is created from the source <xref:System.Activities.Statements.State> to the dropped destination <xref:System.Activities.Statements.State>. For more information, see [Transition](../workflow-designer/transition-activity-designer.md).

### State Activity Properties in the Workflow Designer

The following table shows the <xref:System.Activities.Statements.State> properties that can be set using the workflow designer and describes how they are used in the designer. Some of these properties can be edited in the property grid and some can be edited on the designer surface.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Statements.State.DisplayName%2A>|False|Specifies the friendly name of the <xref:System.Activities.Statements.State> activity designer in the header. The default value is **State**. The value can be edited in the property grid or directly on the header of the activity designer. The <xref:System.Activities.Statements.State.DisplayName%2A> is used in the breadcrumb navigation that is displayed at the top of the workflow designer.<br /><br /> Although the <xref:System.Activities.Statements.State.DisplayName%2A> is not strictly required, it is a best practice to use one.|
|<xref:System.Activities.Statements.State.Entry%2A>|False|Specifies the action that occurs when this state is transitioned to. When the <xref:System.Activities.Statements.State> activity is expanded, this value can be set by dragging an activity from the **Toolbox** and dropping it onto the **Entry** section of the state.|
|<xref:System.Activities.Statements.State.Exit%2A>|False|Specifies the action that occurs when this state is transitioned away from. When the <xref:System.Activities.Statements.State> activity is expanded, this value can be set by dragging an activity from the **Toolbox** and dropping it onto the **Exit** section of the state.|
|<xref:System.Activities.Statements.State.Transitions%2A>|False|Lists the possible transitions that originate from the <xref:System.Activities.Statements.State>. Each item in the list has a link to the associated <xref:System.Activities.Statements.Transition> and the destination <xref:System.Activities.Statements.State>. Clicking the link will switch the designer to an expanded view of the <xref:System.Activities.Statements.Transition> or <xref:System.Activities.Statements.State>.|

## See also

- [StateMachine](../workflow-designer/statemachine-activity-designer.md)
- [FinalState](../workflow-designer/finalstate-activity-designer.md)
- [Transition](../workflow-designer/transition-activity-designer.md)
