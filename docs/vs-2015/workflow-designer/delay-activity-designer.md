---
title: "Delay Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.Activities.Statements.Delay.UI"
ms.assetid: f51742a8-2c9a-47d1-8a23-18459d03ae19
caps.latest.revision: 8
author: jillre
ms.author: jillfra
manager: jillfra
---
# Delay Activity Designer
The **Delay** activity designer is used to create and configure a <xref:System.Activities.Statements.Delay> activity.

## The Delay Activity
 The <xref:System.Activities.Statements.Delay> activity delays the execution of a workflow for a specified amount of time.

### Using the Delay Activity Designer
 The **Delay** activity designer can be found in the **Primitives** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab of the [!INCLUDE[wfd2](../includes/wfd2-md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)

 The **Delay** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates a <xref:System.Activities.Statements.Delay> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of Delay. The <xref:System.Activities.Activity.DisplayName%2A> can be edited in the header of the **Delay** activity designer or in the **DisplayName** box of the property grid.

### The Delay Properties
 The following table shows the <xref:System.Activities.Statements.Delay> properties and describes how they are used in the designer. These properties can be edited in property grid and of them some can be edited on [!INCLUDE[wfd2](../includes/wfd2-md.md)]designer surface.

|Property Name|Required|Usage|
|-------------------|--------------|-----------|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.Activities.Statements.Delay> activity. The default is Delay. Although the <xref:System.Activities.Activity.DisplayName%2A> value is not strictly required, it is a best practice to use one.|
|<xref:System.Activities.Statements.Delay.Duration%2A>|True|The amount of time to delay the workflow. This property is set in the property grid. Type in either a literal <xref:System.TimeSpan> in the format 00:00:00 or a Visual Basic expression to specify the amount of time.|

## See Also
 [Primitives](../workflow-designer/primitives-activity-designers.md)
 [Assign](../workflow-designer/assign-activity-designer.md)
 [Delay Activity Designer](../workflow-designer/delay-activity-designer.md)
 [InvokeMethod](../workflow-designer/invokemethod-activity-designer.md)
 [WriteLine](../workflow-designer/writeline-activity-designer.md)