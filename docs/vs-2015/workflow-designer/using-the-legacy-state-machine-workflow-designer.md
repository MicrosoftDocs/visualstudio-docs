---
title: "Using the Legacy State Machine Workflow Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
helpviewer_keywords:
  - "StateFinalizationActivity activity"
  - "StateActivity activity"
  - "SetStateActivity activity"
  - "EventDrivenActivity activity"
  - "state machine workflow designer"
  - "state machine workflows, designer"
  - "state machine workflows, activities"
  - "StateInitializationActivity activity"
ms.assetid: 2cd21123-35c2-4eaf-82f6-86fce7a8f04d
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# Using the Legacy State Machine Workflow Designer
When you are creating a new state machine workflow project in [!INCLUDE[vs2010](../includes/vs2010-md.md)] that targets either the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)], you can choose to use either the **State Machine Workflow Console Application** or the **State Machine Workflow Library** legacy project template. If you choose one of these state machine project templates, the state machine designer is presented as the legacy workflow designer user interface. For information about the legacy state machine project templates, see [How to: Create State Machine Workflow Console Applications (Legacy)](../workflow-designer/how-to-create-state-machine-workflow-console-applications-legacy.md) and [How to: Create a State Machine Workflow Library (Legacy)](../workflow-designer/how-to-create-a-state-machine-workflow-library-legacy.md).

 A state machine workflow consists of a set of states. One state is denoted as an initial state. Each state can receive a certain set of events. Based on an event, a transition can be made to another state. The state machine workflow can have a final state. When a transition is made to the final state, the workflow finishes.

## State Machine Designer Views
 The state machine designer is a freeform designer, which means that the activities can be moved around freely on the design surface. The state machine designer has two views: *state* view and *event-driven* view.

 The state view shows the state activities and the event-driven activities that can be contained within a state activity. In this view, the transitions from one state to another are represented by lines that extend from the event-driven activity in one state to another state. You can also create transitions by drawing the line yourself. To draw the transition, select the event-driven activity, and then select one of the handles on the activity and drag it. This action draws a line. This line is then attached to the target state, indicating a transition between states.

 To access the event driven view, double-click an event-driven activity. The designer that appears is much like the sequential workflow designer. At the top of the designer, a navigation bar shows the hierarchy of the activities up to the event-driven activity that is displayed. You can navigate back to the state view by clicking any element in the displayed hierarchy. If you have drawn a transition from one state to another in the state view, and if you are displaying the event driven view of that activity, a set state activity is added to the event-driven activity for you. If you change the properties of the set state activity, it is reflected back in the state view.

## State Machine Workflow Activities
 The following table describes the key activities that are used in a state machine workflow designer.

|Toolbox Name|Activity|Description|
|------------------|--------------|-----------------|
|**State**|[StateActivity](https://go.microsoft.com/fwlink?LinkID=65042)|Represents a state in a state machine; may contain additional **StateActivity** activities. For more information, see [Using the StateActivity Activity](https://go.microsoft.com/fwlink?LinkID=65083).|
|**SetState**|[SetStateActivity](https://go.microsoft.com/fwlink?LinkID=65041)|Specifies a transition to a new state. For more information, see [Using the SetStateActivity Activity](https://go.microsoft.com/fwlink?LinkID=65082).|
|**StateInitialization**|[StateInitializationActivity](https://go.microsoft.com/fwlink?LinkID=65044)|Executes when a state is entered; may contain other activities. For more information, see [Using the StateInitialization Activity](https://go.microsoft.com/fwlink?LinkID=65006).|
|**StateFinalization**|[StateFinalizationActivity](https://go.microsoft.com/fwlink?LinkID=65043)|Executes contained activities when leaving a [StateActivity](https://go.microsoft.com/fwlink?LinkID=65042) activity. For more information, see [Using the StateFinalizationActivity Activity](https://go.microsoft.com/fwlink?LinkID=65008).|
|**EventDriven**|[EventDrivenActivity](https://go.microsoft.com/fwlink?LinkID=65029)|Used for states that rely on an external event to start executing. The **EventDrivenActivity** activity must have an activity that implements the [IEventActivity](https://go.microsoft.com/fwlink?LinkID=65032) interface as the first child activity. For more information, see [Using the EventDrivenActivity Activity](https://go.microsoft.com/fwlink?LinkID=65068).|

 The main component in a state machine workflow is the [StateActivity](https://go.microsoft.com/fwlink?LinkID=65042) activity. As events are captured at various points in a state machine workflow, different states are entered to handle the tasks that are associated with the events. During the workflow lifetime, the workflow may leave and enter several different states. These states connect to each other by using the [SetStateActivity](https://go.microsoft.com/fwlink?LinkID=65041) activity.

 When you drag a new **StateActivity** onto the workflow design surface, you can add [EventDrivenActivity](https://go.microsoft.com/fwlink?LinkID=65029), [StateInitializationActivity](https://go.microsoft.com/fwlink?LinkID=65044), [StateFinalizationActivity](https://go.microsoft.com/fwlink?LinkID=65043), or additional **StateActivity** activities as child activities.

> [!CAUTION]
> When you use the state machine workflow designer to create workflows, you must monitor the structure of the workflow you are designing with the **Document Outline** view window. The view of the structure of the state machine workflow in the **Document Outline** view window mirrors the logical layout of the activities in the workflow markup file. The physical layout of the workflow activities as they appear on the design surface might not mirror the logical layout of the activities in the workflow markup file.
>
> To open the **Document Outline** window, on the **View** menu, point to **Other Windows**, and then select **Document Outline**.

## See Also
 [How to: Create State Machine Workflow Console Applications (Legacy)](../workflow-designer/how-to-create-state-machine-workflow-console-applications-legacy.md)
 [How to: Create a State Machine Workflow Library (Legacy)](../workflow-designer/how-to-create-a-state-machine-workflow-library-legacy.md)
 [State Machine Workflows](https://go.microsoft.com/fwlink?LinkID=65016)
 [Using the StateActivity Activity](https://go.microsoft.com/fwlink?LinkID=65083)
 [Using the StateInitializationActivity Activity](https://go.microsoft.com/fwlink?LinkID=65006)
 [Using the StateFinalizationActivity Activity](https://go.microsoft.com/fwlink?LinkID=65008)
 [Using the SetStateActivity Activity](https://go.microsoft.com/fwlink?LinkID=65082)
 [Using the EventDrivenActivity Activity](https://go.microsoft.com/fwlink?LinkID=65068)