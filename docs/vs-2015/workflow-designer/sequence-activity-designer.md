---
title: "Sequence Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.Activities.Statements.Sequence.UI"
ms.assetid: 51c8d3cb-4d43-458f-9631-b63755f9ac94
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# Sequence Activity Designer
The <xref:System.Activities.Statements.Sequence> activity contains an ordered collection of child activities that it executes in order.

 Another way to execute a set of activities in order is to use a <xref:System.Activities.Statements.Flowchart> activity. Consider using the [Flowchart](../workflow-designer/flowchart-activity-designer.md) when you have a simple branching or looping program flow that you want to model diagrammatically.

## Using the Sequence Activity Designer
 To add a <xref:System.Activities.Statements.Sequence> activity, drag the **Sequence** activity designer from the **Toolbox** and drop it on to the [!INCLUDE[wfd1](../includes/wfd1-md.md)] surface. To add a child activity to this <xref:System.Activities.Statements.Sequence> activity, drag some other activity from the **Toolbox** and drop it on the triangle in the box with the hint text “Drop activity here”.

### Sequence Activity Properties in the Workflow Designer
 The following table shows the <xref:System.Activities.Statements.Sequence> properties and describes how they are used in the designer. These properties can be edited in property grid or on the designer surface.

|Property Name|Required|Usage|
|-------------------|--------------|-----------|
|<xref:System.Activities.Activity.DisplayName%2A>|False|Specifies the friendly name of the <xref:System.Activities.Statements.Sequence> activity designer in the header. The default value is Sequence. The value can be edited in the property grid or directly on the header of the activity designer.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it is a best practice to use one.|

## See Also
 [Flowchart](../workflow-designer/flowchart-activity-designer.md)
 [Control Flow](../workflow-designer/control-flow-activity-designers.md)