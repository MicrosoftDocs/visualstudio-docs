---
title: "WriteLine Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.Activities.Statements.WriteLine.UI"
ms.assetid: 1b5f29a8-b7fd-477e-949e-2f689cae3c96
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# WriteLine Activity Designer
The **WriteLine** activity designer is used to create and configure a <xref:System.Activities.Statements.WriteLine> activity.

## The WriteLine Activity
 The <xref:System.Activities.Statements.WriteLine> activity writes text to a specified <xref:System.IO.TextWriter> object. If no <xref:System.IO.TextWriter> is specified, <xref:System.Activities.Statements.WriteLine> writes the text to the console.

### Using the WriteLine Activity Designer
 The **WriteLine** activity designer can be found in the **Primitives** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab of the [!INCLUDE[wfd2](../includes/wfd2-md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)

 The **WriteLine** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates a <xref:System.Activities.Statements.WriteLine> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of WriteLine. The <xref:System.Activities.Activity.DisplayName%2A> can be edited in the header of the **WriteLine** activity designer or in the **DisplayName** box of the property grid.

### The WriteLine Properties
 The following table shows the <xref:System.Activities.Statements.WriteLine> properties and describes how they are used in the designer. These properties can be edited in property grid and some of them can be edited on [!INCLUDE[wfd2](../includes/wfd2-md.md)]designer surface.

|Property Name|Required|Usage|
|-------------------|--------------|-----------|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.Activities.Statements.WriteLine> activity. The default is WriteLine. Although the <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it is best practice to use a one.|
|<xref:System.Activities.Statements.WriteLine.Text%2A>|False|The text to write. To set the property, type a Visual Basic expression in the **Text** box on the **WriteLine** activity designer or in the property grid.|
|<xref:System.Activities.Statements.WriteLine.TextWriter%2A>|False|The <xref:System.IO.TextWriter> to which the <xref:System.Activities.Statements.WriteLine> writes the <xref:System.Activities.Statements.WriteLine.Text%2A>. The default is the console.|

## See Also
 [Primitives](../workflow-designer/primitives-activity-designers.md)
 [Assign](../workflow-designer/assign-activity-designer.md)
 [Delay](../workflow-designer/delay-activity-designer.md)
 [InvokeMethod](../workflow-designer/invokemethod-activity-designer.md)