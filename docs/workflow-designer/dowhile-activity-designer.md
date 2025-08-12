---
title: "Workflow Designer - DoWhile Activity Designer"
description: Learn how the DoWhile activity executes the activity contained in its Body at least once, until a specified condition evaluates to false.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "System.Activities.Statements.DoWhile.UI"
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# DoWhile Activity Designer

The <xref:System.Activities.Statements.DoWhile> activity executes the activity contained in its <xref:System.Activities.Statements.DoWhile.Body%2A> at least once, until a specified condition evaluates to **false**. If you need the activity contained in a loop body to be executed zero or more times, use the <xref:System.Activities.Statements.While> activity instead.

## DoWhile Properties in the Workflow Designer

The following table shows the most useful <xref:System.Activities.Statements.DoWhile> activity properties, and describes how to use them in the designer:

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Statements.DoWhile.Body%2A>|False|The activity to execute while the condition is **true**. To add the <xref:System.Activities.Statements.DoWhile.Body%2A> activity, drop an activity from the toolbox into the **Body** box on the **DoWhile** activity designer with hint text "Drop Activity Here".|
|<xref:System.Activities.Statements.DoWhile.Condition%2A>|True|The condition to evaluate after each iteration of the loop. To set the <xref:System.Activities.Statements.DoWhile.Condition%2A>, type a Visual Basic expression in the **Condition** box on the **DoWhile** activity designer or in the property grid.|

## See also

- [While](../workflow-designer/while-activity-designer.md)
- [Control Flow](../workflow-designer/control-flow-activity-designers.md)