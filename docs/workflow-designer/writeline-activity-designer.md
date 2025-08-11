---
title: Workflow Designer - WriteLine Activity Designer
description: Learn about the WriteLine activity and how you can use the WriteLine activity designer to create and configure a WriteLine activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- System.Activities.Statements.WriteLine.UI
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# WriteLine Activity Designer

The **WriteLine** activity designer is used to create and configure a <xref:System.Activities.Statements.WriteLine> activity.

## The WriteLine Activity

The <xref:System.Activities.Statements.WriteLine> activity writes text to a specified <xref:System.IO.TextWriter> object. If no <xref:System.IO.TextWriter> is specified, <xref:System.Activities.Statements.WriteLine> writes the text to the console.

### Using the WriteLine Activity Designer

Access the **WriteLine** activity designer in the **Primitives** category of the **Toolbox**. The **WriteLine** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates a <xref:System.Activities.Statements.WriteLine> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of WriteLine. The <xref:System.Activities.Activity.DisplayName%2A> can be edited in the header of the **WriteLine** activity designer or in the **DisplayName** box of the property grid.

### The WriteLine Properties

The following table shows the <xref:System.Activities.Statements.WriteLine> properties and describes how they are used in the designer. These properties can be edited in property grid and some of them can be edited on Workflow Designer surface.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.Activities.Statements.WriteLine> activity. The default is WriteLine. Although the <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it is best practice to use a one.|
|<xref:System.Activities.Statements.WriteLine.Text%2A>|False|The text to write. To set the property, type a Visual Basic expression in the **Text** box on the **WriteLine** activity designer or in the property grid.|
|<xref:System.Activities.Statements.WriteLine.TextWriter%2A>|False|The <xref:System.IO.TextWriter> to which the <xref:System.Activities.Statements.WriteLine> writes the <xref:System.Activities.Statements.WriteLine.Text%2A>. The default is the console.|

## See also

- [Primitives](../workflow-designer/primitives-activity-designers.md)
- [Assign](../workflow-designer/assign-activity-designer.md)
- [Delay](../workflow-designer/delay-activity-designer.md)
- [InvokeMethod](../workflow-designer/invokemethod-activity-designer.md)
