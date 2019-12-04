---
title: "Activity Views (Legacy) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
helpviewer_keywords:
  - "activities, activity views"
  - "views, activity"
  - "activity views"
ms.assetid: 83dc68cd-2cb2-45c2-9a6e-10d82053171a
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# Activity Views (Legacy)
Many of the activities provided by [!INCLUDE[wf](../includes/wf-md.md)], from which workflows are composed, have several design views available in the legacy [!INCLUDE[wfd1](../includes/wfd1-md.md)]. When you drag an activity designer from the **Toolbox** onto the design surface, and thereafter whenever you select the activity, you can switch between the different design views by using either the **Workflow** menu or by right-clicking the selected activity. Also, when you move the pointer over the name of a selected activity, a drop-down set of tabs appears that you can use to switch between the different views.

 Every activity has at least one view; this is the default view shown when you drag an activity designer from the **Toolbox** onto the design surface. This activity default view is available as the **View [activity type]** option on the menus and tab, for example, **View Parallel**. Most of the activities have additional views and different activities can have different views. For example, the [TransactionScopeActivity](https://go.microsoft.com/fwlink?LinkID=65093) activity has the compensation view and the [EventHandlingScopeActivity](https://go.microsoft.com/fwlink?LinkID=65030) activity has an events view. Many of the activities that come with Windows Workflow Foundation have **View Cancel Handler** and **View Faults** design views to view the [CancellationHandlerActivity](https://go.microsoft.com/fwlink?LinkID=65050) and a [FaultHandlersActivity](https://go.microsoft.com/fwlink?LinkID=65055) associated with them.

 The following table lists the name and description of each view.

|Menu/Tab Option|Description|
|----------------------|-----------------|
|**View [activity type]**|Select this menu or tab option to view the default graphical representation of the selected activity.|
|**View Cancel Handler**|Select this menu or tab option view to view the [CancellationHandlerActivity](https://go.microsoft.com/fwlink?LinkID=65050) associated with the selected activity.|
|**View Fault Handler**|Select this menu or tab option view to view the [FaultHandlersActivity](https://go.microsoft.com/fwlink?LinkID=65055) associated with the selected activity.|
|**View Compensation Handler**|Select this menu or tab option view to view the [CompensationHandlerActivity](https://go.microsoft.com/fwlink?LinkID=65053) associated with the selected [TransactionScopeActivity](https://go.microsoft.com/fwlink?LinkID=65093).|
|**View Events Handler**|Select this menu or tab option view to view the [EventHandlersActivity](https://go.microsoft.com/fwlink?LinkID=65018) associated with the selected the [EventHandlingScopeActivity](https://go.microsoft.com/fwlink?LinkID=65030).|

 For information about similar views, see [Sequential Workflow Views (Legacy)](../workflow-designer/sequential-workflow-views-legacy.md).

## See Also
 [Legacy Workflow Activities](../workflow-designer/legacy-workflow-activities.md)
 [Sequential Workflow Views (Legacy)](../workflow-designer/sequential-workflow-views-legacy.md)