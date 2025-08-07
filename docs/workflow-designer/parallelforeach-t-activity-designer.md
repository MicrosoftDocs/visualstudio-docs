---
title: ParallelForEach&lt;T&gt; Activity Designer
description: In Workflow Designer, learn how the ParallelForEach <T> activity enumerates the elements of a collection and executes an embedded statement for each element of the collection in parallel.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "System.Activities.Statements.ParallelForEach`1.UI"
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# ParallelForEach Activity Designer

The <xref:System.Activities.Statements.ParallelForEach%601> activity enumerates the elements of a collection and executes an embedded statement for each element of the collection in parallel, which is asynchronously on the same thread. Use this flow control activity instead of the <xref:System.Activities.Statements.Sequence> activity if the child activities of this activity are expected to go idle.

The <xref:System.Activities.Statements.ParallelForEach%601> activity has a <xref:System.Activities.Statements.ParallelForEach%601.CompletionCondition%2A> property that contains a user specified Visual Basic expression. The <xref:System.Activities.Statements.ParallelForEach%601> activity evaluates this property after each branch completes. If it evaluates to **true**, then the <xref:System.Activities.Statements.ParallelForEach%601> activity completes without executing the other branches. If the <xref:System.Activities.Statements.ParallelForEach%601.CompletionCondition%2A> does not evaluate to **true**, then the <xref:System.Activities.Statements.ParallelForEach%601> activity completes when all of its child activities have completed.

## The ParallelForEach<T\> Activity

<xref:System.Activities.Statements.ParallelForEach%601> enumerates its values and schedules the <xref:System.Activities.Statements.ParallelForEach%601.Body%2A> for every value it enumerates on. It only schedules the <xref:System.Activities.Statements.ParallelForEach%601.Body%2A>. How the body executes depends on whether the <xref:System.Activities.Statements.ParallelForEach%601.Body%2A> goes idle.

If the <xref:System.Activities.Statements.ParallelForEach%601.Body%2A> does not go idle, it executes in a reverse order because the scheduled activities are handled as a stack, the last scheduled activity executes first. For example, if you have a collection of {1,2,3,4}in <xref:System.Activities.Statements.ParallelForEach%601> and use a **WriteLine** as the body to write the value out. You have 4, 3, 2, 1 printed out in the console. This is because **WriteLine** does not go idle so after 4 **WriteLine** activities got scheduled, they executed using a stack behavior (first in last out).

But if you have activities in the <xref:System.Activities.Statements.ParallelForEach%601.Body%2A> that can go idle, like a <xref:System.ServiceModel.Activities.Receive> activity or <xref:System.Activities.Statements.Delay> activity. Then there is no need to wait for them to complete. <xref:System.Activities.Statements.ParallelForEach%601> goes to the next scheduled body activity and try to execute it. If that activity goes idle too, <xref:System.Activities.Statements.ParallelForEach%601> moves on again the next body activity.

### Using the ParallelForEach\<T> Activity Designer

Access the **ParallelForEach\<T>** activity designer in the **Control Flow** category of the **Toolbox**.

The **ParallelForEach\<T>** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activity designers are normally placed, for example, inside of a **Sequence** activity designer. After dropping it into the Workflow Designer, it creates a <xref:System.Activities.Statements.ParallelForEach%601> activity, which by default contains a <xref:System.Activities.Activity.DisplayName%2A> of **ParallelForEach<Int32\>.**

### ParallelForEach<T\> Properties in the Workflow Designer

The following table shows the most useful <xref:System.Activities.Statements.ParallelForEach%601> activity properties and describes how they are used in the designer.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|Specifies the friendly display name of the activity designer in the header. The default value is **ParallelForEach\<Int32>**. The value can be optionally edited in the **Properties** grid or directly on the activity designer header.|
|<xref:System.Activities.Statements.ParallelForEach%601.Body%2A>|False|The activity to execute for each item in the collection. To add the <xref:System.Activities.Statements.ParallelForEach%601.Body%2A> activity, drop an activity from the toolbox into the **Body** box on the **ParallelForEach\<T>** activity designer with hint text "Drop Activity Here".|
|**TypeArgument**|True|The type of the items in the <xref:System.Activities.Statements.ParallelForEach%601.Values%2A> collection specified by the generic parameter *T*. By default, **TypeArgument** is set to **Int32**. To change the type T in the **ParallelForEach<T\>** activity designer, change the value of the **TypeArgument** combo box in the Property Grid.|
|<xref:System.Activities.Statements.ParallelForEach%601.Values%2A>|True|The collection of items to iterate over. To set the <xref:System.Activities.Statements.ParallelForEach%601.Values%2A>, type a Visual Basic expression in the **Values** box on the **ForEach<T\>** activity designer in the box with the hint text "Enter a VB expression" or in **Values** box on the **Properties** window.|
|<xref:System.Activities.Statements.ParallelForEach%601.CompletionCondition%2A>||Evaluated after each iteration completes. If it evaluates to true, then the scheduled pending iterations are canceled. If this property is not set, all scheduled statements execute until completion.|

By default, the loop iterator is named item. You can change the name of the iterator variable in the **ForEach** box in **ParallelForEach\<T>** activity designer. The loop iterator can be used in expressions in the children of the <xref:System.Activities.Statements.ParallelForEach%601> activity.

## See also

- [Sequence](../workflow-designer/sequence-activity-designer.md)
- [Parallel](../workflow-designer/parallel-activity-designer.md)
- [Control Flow](../workflow-designer/control-flow-activity-designers.md)