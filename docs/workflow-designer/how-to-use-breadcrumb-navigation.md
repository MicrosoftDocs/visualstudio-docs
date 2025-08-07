---
title: 'Workflow Designer - Use Breadcrumb Navigation'
description: Learn how use breadcrumb navigation to access a child activity, navigate to an ancestor activity, or expand or collapse activities in place.
ms.date: 11/04/2016
ms.topic: how-to
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Use Breadcrumb Navigation

There are three main ways to change the set of activities that are displayed in Workflow Designer:

1. Double-click to drill in to a child activity.

2. Click a button on the breadcrumb bar to navigate to an ancestor activity.

3. Expand or collapse activities in place.

## Using breadcrumb navigation

1. Double-click an activity of Workflow Designer to change the root activity to the clicked activity. The clicked activity is then fully expanded at the root and its ancestors are shown in the breadcrumb bar. This is sometimes called drilling in or out of an activity.

2. To navigate to an ancestor of the current root activity, click the activity in the breadcrumb bar.

## Expanding or collapsing an activity in place

1. Clicking the chevrons on an activity expands or collapses the activity in place.

2. When the state of the expansion state is changed by clicking the button, the new state of expansion is saved in XAML.

    > [!WARNING]
    > Not all activities can be expanded in place. There are two cases when an activity cannot be expanded in place: either the parent of the activity does not allow its children to be expanded in place, (for example, activities in a flowchart cannot be expanded in place), or the activity designer does not allow itself to be expanded in place. Although none of the activity designers included in Workflow Designer have the latter behavior, some custom activities may exhibit this behavior.

## Expanding all or collapsing all activities

1. Use the **Expand All** and **Collapse All** buttons in the user interface to expand or collapse all of the activities under the current breadcrumb root. Note that expand all and collapse all are global states. This means that when you change the root activity using breadcrumb navigation, the expand all or collapse all state persists until you click **Restore**.

2. After you have applied an expand all or collapse all state, you can click the **Restore** button that appears to go back to looking at the state previously applied to each activity.

    > [!WARNING]
    > If an activity, such as <xref:System.Activities.Statements.Flowchart>, has opted out of expand in place, the functionality associated with the **Expand All** and **Collapse All** buttons is disabled on the **Flowchart** designer. For more information about the **Flowchart** designer, see the [Flowchart](../workflow-designer/flowchart-activity-designer.md) topic.

    > [!WARNING]
    > Expand all also has a special effect in **Switch** and **TryCatch** activity designers. When you click **Expand All**, all of the switch cases and all of the try/catch/finally blocks are displayed. Clicking **Restore** or **Collapse All** returns these designers to their default state, from which you can click an individual case/block to view its contents.
