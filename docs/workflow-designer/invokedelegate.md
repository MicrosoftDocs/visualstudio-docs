---
title: "Workflow Designer - InvokeDelegate"
description: Learn about the InvokeDelegate designer and how you can use the InvokeDelegate designer to create and configure an InvokeDelegate activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "InvokeDelegate Designer"
  - "System.Activities.Statements.InvokeDelegate.UI"
author: sayedihashimi
author: sayedha
---
# InvokeDelegate

The **InvokeDelegate** designer is used to create and configure an <xref:System.Activities.Statements.InvokeDelegate> activity.

## The InvokeDelegate activity

The <xref:System.Activities.Statements.InvokeDelegate> calls a public delegate.

### Use the InvokeDelegate Activity Designer

Access the **InvokeDelegate** activity designer in the **Primitives** category of the **Toolbox**. The **InvokeDelegate** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface where ever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. Dropping the activity designer creates an <xref:System.Activities.Statements.InvokeDelegate> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of InvokeDelegate. The <xref:System.Activities.Activity.DisplayName%2A> can be edited in the header of the **InvokeDelegate** activity designer or in the **DisplayName** box of the property grid.

### The InvokeDelegate properties

The following table shows the <xref:System.Activities.Statements.InvokeDelegate> properties and describes how they are used in the designer. These properties can be edited in property grid, and some can be edited on Workflow Designer surface.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.Activities.Statements.InvokeDelegate> activity. The default value is InvokeDelegate.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it's best to use one.|
|<xref:System.Activities.Statements.InvokeDelegate.Delegate%2A>|True|The name of the <xref:System.Activities.ActivityDelegate> to be called when the activity executes. This property can be edited on designer surface, and is mandatory.|
|<xref:System.Activities.Statements.InvokeDelegate.DelegateArguments%2A>|False|The argument collection of the called delegate. The keys are the names of the parameter objects on the <xref:System.Activities.ActivityDelegate>, and the values are the arguments whose expressions are evaluated and assigned to the corresponding parameter objects. To display the **DelegateArguments** dialog where you can set this property, click the ellipsis button in the **DelegateArguments** field of the property grid. Click the **Create Argument** field to add the arguments.|

## See also

- [How to: Define and consume activity delegates in the Workflow Designer](../workflow-designer/how-to-define-and-consume-activity-delegates-in-the-workflow-designer.md)