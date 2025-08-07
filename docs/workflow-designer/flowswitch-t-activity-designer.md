---
title: Workflow Designer - FlowSwitch&lt;T&gt; Activity Designer
description: Learn how the FlowSwitch <T> activity is a conditional node that provides branching for the flow of control based on match criterion.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- System.Activities.Core.Presentation.FlowSwitchLink.UI
- System.Activities.Statements.FlowSwitch`1.UI
- System.Activities.Core.Presentation.FlowSwitchLink`1.UI
- System.Activities.Core.Presentation.FlowSwitchLinkIdentifier.UI
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# FlowSwitch\<T> Activity Designer

The <xref:System.Activities.Statements.FlowSwitch%601> activity is a conditional node that provides branching for the flow of control based on match criterion when more than two alternative branches are required. If the flow branching requires only two paths, use the <xref:System.Activities.Statements.FlowDecision> activity instead.

## The FlowSwitch\<T> Activity

The <xref:System.Activities.Statements.FlowSwitch%601> activity contains an <xref:System.Activities.Statements.FlowSwitch%601.Expression%2A> that returns a value of type *T* (specified by the generic parameter) when evaluated. The activity also contains a set of <xref:System.Activities.Statements.FlowSwitch%601.Cases%2A>, which specifies a unique mapping from possible results of this evaluation to a set of <xref:System.Activities.Statements.FlowNode> objects. The <xref:System.Activities.Statements.FlowNode> executed is the one whose object of type *T* matches the value of the evaluated <xref:System.Activities.Statements.FlowSwitch%601.Expression%2A>. A <xref:System.Activities.Statements.FlowSwitch%601.Default%2A> case can (optionally) be provided for the case in which no match is obtained.

### Using the FlowSwitch\<T> Activity Designer

The **FlowSwitch\<T>** activity designer can be found in the **Flowchart** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the left side of the Workflow Designer. Alternatively, select **Toolbox** from the **View** menu, or press **Ctrl**+**Alt**+**X**.

The **FlowSwitch\<T>** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface within a **Flowchart** activity designer. Use the **Select Types** window that displays to specify the type (associated in code with the <xref:System.Activities.Statements.FlowSwitch%601> by its generic parameter) obtained from evaluating the <xref:System.Activities.Statements.FlowSwitch%601.Expression%2A>. This procedure creates a <xref:System.Activities.Statements.FlowSwitch%601> activity labeled **Switch** within the <xref:System.Activities.Statements.Flowchart> activity. The <xref:System.Activities.Statements.FlowSwitch%601.Expression%2A> can be typed in the **Expression** box of the **Properties** window by clicking where the hint text says "Enter a VB expression".

Mouse over the **FlowSwitch\<T>** activity designer to cause the square handles that are used to link up <xref:System.Activities.Statements.FlowSwitch%601.Cases%2A> to appear around its edges. After dragging the **FlowSwitch<T\>** activity designer and other activity designers onto the **Flowchart**, the <xref:System.Activities.Activity> objects they represent are ready to be linked together to specify the order of execution. To create one of the <xref:System.Activities.Statements.FlowSwitch%601.Cases%2A> associated with the <xref:System.Activities.Statements.FlowSwitch%601>, click one of the square case handles on the perimeter of the **FlowSwitch<T\>** and drag it (by holding down the mouse button) to one of the handles that appears in a similar manner around the destination activity when the mouse hovers over its designer. Release the mouse button and an arrow from the **FlowSwitch<T\>** to the destination designer appears representing this case. The default value for this case displays on the arrow and it can be edited in the **Case** box of the **Properties** window.

### The FlowSwitch\<T> Properties

The following table shows the <xref:System.Activities.Statements.FlowSwitch%601> properties and describes how they are used in the designer. These properties can be edited in the property grid or on designer surface.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Statements.FlowSwitch%601.Expression%2A>|True|Specifies the expression that is evaluated to determine which of the <xref:System.Activities.Statements.FlowSwitch%601.Cases%2A> to switch to in the path of execution.|
|<xref:System.Activities.Statements.FlowSwitch%601.Cases%2A>|False|Specifies a unique mapping from possible results obtained from evaluating the <xref:System.Activities.Statements.FlowSwitch%601.Expression%2A> to a set of <xref:System.Activities.Statements.FlowNode> objects.|
|<xref:System.Activities.Statements.FlowSwitch%601.Default%2A>|True|Specifies the mapping when the evaluation of the <xref:System.Activities.Statements.FlowSwitch%601.Expression%2A> does not match one of the values contained in the <xref:System.Activities.Statements.FlowSwitch%601.Cases%2A> object.|

## See also

- [Flowchart](../workflow-designer/flowchart-activity-designers.md)
- [Flowchart](../workflow-designer/flowchart-activity-designer.md)
- [FlowDecision](../workflow-designer/flowdecision-activity-designer.md)
