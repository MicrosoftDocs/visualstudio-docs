---
title: "Flowchart Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords: 
  - "System.Activities.Statements.Flowchart.UI"
  - "System.Activities.Statements.FlowStep.UI"
  - "System.Activities.Core.Presentation.FlowStart.UI"
ms.assetid: d5af2276-5215-4138-880a-cf2b90bbf3a0
caps.latest.revision: 5
author: gewarren
ms.author: gewarren
manager: jillfra
---
# Flowchart Activity Designer
The <xref:System.Activities.Statements.Flowchart> activity is used to create workflows that define and manage complex flow controls. A <xref:System.Activities.Statements.Flowchart> can be authored either in code or by using [!INCLUDE[wfd2](../includes/wfd2-md.md)]. This topic documents the [!INCLUDE[wfd2](../includes/wfd2-md.md)] experience. The [!INCLUDE[wfd1](../includes/wfd1-md.md)] workflow activity designer enables developers to author workflows in a natural manner.  
  
## The Flowchart Activity  
 The <xref:System.Activities.Statements.Flowchart> specifies a unique <xref:System.Activities.Statements.Flowchart.StartNode%2A> that is executed when the workflow starts and uses a network of linked <xref:System.Activities.Statements.Flowchart.Nodes%2A> to create arbitrary loops or to divert the flow of execution to anywhere else in the workflow at any given time.  
  
### Using the Flowchart Activity Designer  
 The **Flowchart** activity designer can be found in the **Flowchart** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the [!INCLUDE[wfd2](../includes/wfd2-md.md)] (Alternatively, select **Toolbar** from the **View** menu or CTRL+ALT+X.)  
  
 The **Flowchart** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface wherever activity designers are normally placed, either as a root activity or as the child of another control flow activity. If the **Flowchart** activity designer is dropped onto a blank [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface, it creates a <xref:System.Activities.Statements.Flowchart> activity, which by default presents itself in an expanded view in which the start node that initiates execution is represented as a green ball. If the **Flowchart** activity designer is dropped into another control flow activity, it presents itself in a minimized view that can be expanded by double-clicking the **Flowchart** activity designer. Any activity in the **Toolbox** can be dragged directly onto the **Flowchart** activity designer, including other control flow activities.  
  
 After dragging various activity designers onto the [!INCLUDE[wfd2](../includes/wfd2-md.md)] canvas, the <xref:System.Activities.Activity> objects they represent can be linked together to specify the order of execution. To create a link between a source activity and a destination activity, mouse over the designer of the source activity and square handles appear on each side of it. Click one of the square handles and drag it by holding down the mouse button to one of the handles that appears in a similar manner around the destination activity when hovering over it with the mouse. Release the mouse button and a link is created between these two activities that is represented as an arrow from the source designer to the destination designer.  
  
### Flowchart Activity Properties  
 The following table shows the <xref:System.Activities.Statements.Flowchart> properties and describes how they are used in the designer. These properties can be edited in property grid or on the designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName%2A>|False|Specifies the display name of the activity designer in the header. The default value is Flowchart. The value can be edited in the **Properties** window or directly on the activity designer header.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it is a best practice to use one.|  
|<xref:System.Activities.Statements.Flowchart.Variables%2A>|False|The collection of variables that are scoped within this <xref:System.Activities.Statements.Flowchart> to share state across its child activities.|  
|<xref:System.Activities.Statements.Flowchart.StartNode%2A>|False|The <xref:System.Activities.Statements.FlowNode> that is executed when the <xref:System.Activities.Statements.Flowchart> starts.|  
|<xref:System.Activities.Statements.Flowchart.Nodes%2A>|False|Contains the collection of <xref:System.Activities.Statements.FlowNode> objects in the <xref:System.Activities.Statements.Flowchart>.|  
  
## See also  
 [Flowchart](../workflow-designer/flowchart-activity-designers.md)   
 [FlowDecision](../workflow-designer/flowdecision-activity-designer.md)   
 [FlowSwitch\<T>](../workflow-designer/flowswitch-t-activity-designer.md)