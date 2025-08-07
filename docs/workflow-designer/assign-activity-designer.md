---
title: "Workflow Designer - Assign Activity Designer"
description: Learn how you can use the Assign activity designer to create and configure an Assign activity, and how the Assign activity assigns a value to a variable or argument.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "System.Activities.Statements.Assign.UI"
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Assign Activity Designer

The **Assign** activity designer is used to create and configure an <xref:System.Activities.Statements.Assign> activity.

## The Assign Activity

The <xref:System.Activities.Statements.Assign> activity assigns a value to a variable or argument.

### Using the Assign Activity Designer

The **Assign** activity designer can be found in the **Primitives** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab (Alternatively, select **Toolbox** from the **View** menu or CTRL+ALT+X.)

The **Assign** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface where ever activities are placed, such as inside a <xref:System.Activities.Statements.Sequence>. Dropping the **Assign** activity designer creates an <xref:System.Activities.Statements.Assign> activity with a default **DisplayName** of Assign. The <xref:System.Activities.Activity.DisplayName%2A> can be edited in the header of the **Assign** activity designer or in the **DisplayName** box of the property grid.

### The Assign Properties

The following table shows the <xref:System.Activities.Statements.Assign> properties and describes how they are used in the designer. These properties can be edited in property grid and some of them can be edited on Workflow Designer surface.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.Activities.Statements.Assign> activity. The default is Assign. Although the <xref:System.Activities.Activity.DisplayName%2A> value is not strictly required, it is a best practice to use one.|
|<xref:System.Activities.Statements.Assign.To%2A>|True|The variable or argument to which the <xref:System.Activities.Statements.Assign.Value%2A> is assigned. The value must be a valid Visual Basic identifier. To set the property, type a Visual Basic expression in the **To** box on the **Assign** activity designer or in the property grid.|
|<xref:System.Activities.Statements.Assign.Value%2A>|True|The value that is assigned to the variable. To set the <xref:System.Activities.Statements.Assign.Value%2A>, type a Visual Basic expression in the **Value** box on the **Assign** activity designer or in the property grid.|

## See also

- [Primitives](../workflow-designer/primitives-activity-designers.md)
- [Delay](../workflow-designer/delay-activity-designer.md)
- [InvokeMethod](../workflow-designer/invokemethod-activity-designer.md)
- [WriteLine](../workflow-designer/writeline-activity-designer.md)