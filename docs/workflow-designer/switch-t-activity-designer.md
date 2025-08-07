---
title: Workflow Designer - Switch&lt;T&gt; Activity Designer
description: Learn how to use the Switch <T> activity designer to create and configure a Switch <T> activity in the Workflow Designer.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- System.Activities.Presentation.ModelItemKeyValuePair.UI
- System.Activities.Statements.Switch`1.UI
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Switch\<T> Activity Designer

The <xref:System.Activities.Statements.Switch%601> activity evaluates a specified expression and executes the activity from a collection of activities whose associated key matches the value obtained from the evaluation.

The **Switch<T\>** activity designer is used to create and configure a <xref:System.Activities.Statements.Switch%601> activity in the Workflow Designer.

## The Switch\<T>Activity

A <xref:System.Activities.Statements.Switch%601> activity contains an <xref:System.Activities.Statements.Switch%601.Expression%2A> and a dictionary of <xref:System.Activities.Statements.Switch%601.Cases%2A>. Each case in the dictionary consists of a pair that contains a *key* and an activity that serves as its corresponding *value*. The <xref:System.Activities.Statements.Switch%601> activity evaluates the <xref:System.Activities.Statements.Switch%601.Expression%2A> and compares it against each of the keys. If a match is found, the corresponding activity is executed. Only one match is possible because dictionary keys must be unique according to the type of equality defined by the equality comparer of the dictionary. If no match is found, the <xref:System.Activities.Statements.Switch%601.Default%2A> activity is executed.

## How to use the Switch\<T> Activity Designer

Access the **Switch\<T>** activity designer in the **Control Flow** category of the **Toolbox**. After dropping it into the Workflow Designer, it displays the **Select Types** dialog to let the user specify the generic type *T* used in <xref:System.Activities.Statements.Switch%601> activity. The default value is **Int32**. Once the generic type *T* has been selected, a **Switch<T\>** designer is added into the workflow designer.

Following are the properties of **Switch<T\>** designer. All of these properties can be edited in property grid. Some of them can also be edited on designer surface.

The following table shows the most useful <xref:System.Activities.Statements.Switch%601> properties and describes how they are used in the designer.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|Specifies the friendly name of the <xref:System.Activities.Statements.Switch%601> activity designer. The default value is Switch<Int32\>. The value can be edited in the **Properties** window or directly on the designer header.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it is a best practice to use one.|
|<xref:System.Activities.Statements.Switch%601.Expression%2A>|True|Specifies the expression used to compare to the keys in the cases collection to determine which case to execute.|
|<xref:System.Activities.Statements.Switch%601.Default%2A>||Specifies the activity executed if no match is found. Click the **Add an activity** button on the designer to open the **Default** box where the activity can be dropped.|
|<xref:System.Activities.Statements.Switch%601.Cases%2A>||Specifies the cases to be evaluated. To add a case, click the **Add new case** button at the bottom of **Switch\<T>** designer. The button changes to a textbox (combo box if the generic type selected when adding the Switch\<T> is String or Enum). After adding a key in the **Case value** box, the case area expands and an activity can be dropped where the hint text "Drop activity here" to define the execution logic for the case.|

Multiple cases can be added as long as the case keys are not duplicated. Otherwise, an error dialog displays reporting the specified case key already exists and that you must choose a different key. In the **Switch\<T>** designer, only one case area can be in expanded view at a time. If a case area is in collapsed view, clicking the case area expands it. Notice that for a collapsed case, the designer shows the display name of the activity inside the case on the right side if there is any. Otherwise, it shows the **Add an activity** button that expands the case if you click it and lets you add an activity.

Clicking the key of existing case changes the key from a label into a textbox so that you can edit the case key.

There are 2 ways to delete a case:

- Select the case and delete it.

- Select the case, right-click to display the context menu and select **Delete**.

Note that you must select the case itself to delete it. Selecting and deleting the activity inside a case only deletes the activity not the case.

## See also

- [Control Flow](../workflow-designer/control-flow-activity-designers.md)
