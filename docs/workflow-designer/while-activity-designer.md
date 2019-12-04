---
title: "Workflow Designer - While Activity Designer"
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "System.Activities.Statements.While.UI"
ms.assetid: ea008091-2e4c-4f64-bfa5-afb919552446
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# While Activity Designer

The <xref:System.Activities.Statements.While> activity executes the activity contained in its <xref:System.Activities.Statements.While.Body%2A> while the specified <xref:System.Activities.Statements.While.Condition%2A> evaluates to **true**. The contained activity may never execute. If you want the contained activity to be executed at least once, use the <xref:System.Activities.Statements.DoWhile> activity instead.

## While Properties in Workflow Designer

The following table shows the most useful <xref:System.Activities.Statements.While> activity properties and describes how they are used in the designer.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|Specifies the friendly name of the <xref:System.Activities.Statements.While> activity designer in the header. The default value is While. The value can be edited in the **Properties** window or directly on the activity designer header.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it is a best practice to use one.|
|<xref:System.Activities.Statements.While.Body%2A>|False|Contains the activity to execute while the <xref:System.Activities.Statements.While.Condition%2A> evaluates to **true**.|
|<xref:System.Activities.Statements.While.Condition%2A>|True|Contains the Visual Basic expression that is evaluated to determine whether the activity in the <xref:System.Activities.Statements.While.Body%2A> is to be executed.|

## See also

- [Control Flow](../workflow-designer/control-flow-activity-designers.md)
- [DoWhile](../workflow-designer/dowhile-activity-designer.md)