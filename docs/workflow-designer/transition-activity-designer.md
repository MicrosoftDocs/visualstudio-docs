---
title: Workflow Designer - Transition Activity Designer
description: Learn how you can use the Transition activity designer to configure a transition between two states.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- System.Activities.Statements.Transition.UI
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Transition Activity Designer

A <xref:System.Activities.Statements.Transition> represents the transition between two states.

## Using the Transition Activity Designer

The transition activity designer allows you to configure a transition between two states.

### Transition Properties in the Workflow Designer

The following table shows the <xref:System.Activities.Statements.Transition> properties that can be set using the workflow designer and describes how they are used in the designer.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Statements.Transition.DisplayName%2A>|False|Specifies the friendly name of the <xref:System.Activities.Statements.Transition> activity designer. The default value is **T1**. The value can be edited in the property grid, in the header of the expanded transition designer, and in the header of the action section within the expanded transition designer. The <xref:System.Activities.Activity.DisplayName%2A> is used in the breadcrumb navigation that is displayed at the top of the workflow designer.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it is a best practice to use one.|
|<xref:System.Activities.Statements.Transition.Condition%2A>|False|If present, specifies an expression that must evaluate to **True** before control is passed to the destination state. This condition can be edited in the property grid and in the expanded transition designer. Multiple conditions in a shared transition are evaluated in the order in which they appear in the transition designer. **Note:**  Note that if the <xref:System.Activities.Statements.Transition.Condition%2A> of a transition evaluates to **False** (or all of the conditions of a shared trigger transition evaluate to **False**), the transition will not occur and all triggers for all the transitions from the state will be rescheduled. In this tutorial, this situation cannot happen because of the way the conditions are configured (we have specific actions for whether the guess is correct or incorrect).|
|**Source**|True|Indicates the state from which this transition originates. Clicking the name of the source state switches the designer view to an expanded view of that state. This value is set when the transition is created and cannot be changed.|
|<xref:System.Activities.Statements.Transition.Trigger%2A>|False|Specifies the activity whose completion initiates the transition. To set this activity, drag an activity from the **Toolbox** and drop it onto the **Trigger** section of the transition.|
|<xref:System.Activities.Statements.Transition.Action%2A>|False|Specifies the activity that is executed when the trigger activity completed and the <xref:System.Activities.Statements.Transition.Condition%2A>, if present, evaluates to **true**. This activity is executed when transitioning to the destination state, after the <xref:System.Activities.Statements.State.Exit%2A> activity for the source state, if present, is executed. When the transition designer is expanded, this value can be set by dragging an activity from the **Toolbox** and dropping it onto the **Action** section of the transition. There can be multiple actions for a single transition. The individual actions can be expanded and contracted, and can be ordered by clicking the up or down arrow that appears on the action when there are multiple actions in a transition.|
|**Destination**|True|Indicates the state that the state machine transitions to after the transition completes. This corresponds to the <xref:System.Activities.Statements.Transition.To%2A> property of the transition in the object model. Clicking the name of the destination state switches the designer view to an expanded view of that state. This value is set when the transition is created and can be changed by dragging the arrow that connects the transition to the destination state in the designer.|

### Creating Transitions

Transitions are created by dragging a line from one state to another, or by dropping a state onto the triangles that appear when one state is dragged over another state. To create a transition by dragging, hover the mouse over the edge of the source state, and drag a line from the source state to the destination state. To create a transition by dropping, drag the destination state and hover it over the source state, and drop it onto one of the four triangles that appear around the source state. The destination state can be either a new state dragged from the **Toolbox**, or an existing state dragged from the workflow designer.

> [!NOTE]
> A single state in a state machine can have up to 76 transitions created using the workflow designer. The limit on transitions for a state for workflows created outside the designer is limited only by system resources.

Shared trigger transitions are the set of transitions which share the same trigger event. A shared trigger allows for the conditional progression to a destination state based on the evaluation of expressions configured for multiple transitions which share a common trigger event. To add additional actions to a transition and create a shared transition, click the circle that indicates the start of the desired transition and drag it to the desired state. The new transition will share a same trigger as the initial transition, but it will have a unique condition and action. Shared transitions can also be created from within the transition designer by clicking **Add shared trigger transition** at the bottom of the transition designer, and then selecting the desired target state from the **Available states to connect** drop-down.

## See also

- [StateMachine](../workflow-designer/statemachine-activity-designer.md)
- [FinalState](../workflow-designer/finalstate-activity-designer.md)
- [State](../workflow-designer/state-activity-designer.md)
