---
title: "FlowDecision Activity Designer"
ms.custom: na
ms.date: "10/02/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "System.Activities.Statements.FlowDecision.UI"
ms.assetid: 4a49edc3-3662-4b7b-812e-0a5ba00d6c94
caps.latest.revision: 4
ms.author: "erikre"
manager: "erikre"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# FlowDecision Activity Designer
The \<xref:System.Activities.Statements.FlowDecision> node is a conditional node that provides a branch for the flow of control into one of two alternatives based on whether a specified condition is satisfied. If the flow requires more than two branches, use \<xref:System.Activities.Statements.FlowSwitch`1> instead.  
  
## The FlowDecision Node  
 Use \<xref:System.Activities.Statements.FlowDecision> when the flow can be branched into two paths. A \<xref:System.Activities.Statements.FlowDecision> node has a \<xref:System.Activities.Statements.FlowDecision.Condition*> and a \<xref:System.Activities.Statements.FlowNode> associated with each of two possible outcomes: \<xref:System.Activities.Statements.FlowDecision.True*> or \<xref:System.Activities.Statements.FlowDecision.False*>. The \<xref:System.Activities.Statements.FlowDecision.Condition*> is evaluated and the value of this evaluation determines the next \<xref:System.Activities.Statements.FlowNode> to be processed within the \<xref:System.Activities.Statements.Flowchart>.  
  
### Using the FlowDecision Designer  
 The **FlowDecision** designer can be found in the **Flowchart** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **FlowDecision** designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] surface within a **Flowchart** activity designer. This creates a \<xref:System.Activities.Statements.FlowDecision> labeled **Decision** within the \<xref:System.Activities.Statements.Flowchart> activity. Mouse over the designer and the **True** and **False** square handles for the two branches appear.  
  
 After dragging the **FlowDecision** designer and other designers onto the **Flowchart**, the nodes can be linked together to specify the order of execution. To create a link between a source node (including the **True** and **False** branches of the **FlowDecision**) and a destination node, mouse over the designer of the source node and square handles appear on each side of it. Click one of the square handles and drag it by holding down the mouse button to one of the handles that appears in a similar manner around the destination node when you mouse over it. Release the mouse button and a link is between created these two nodes that is represented as an arrow from the source designer to the destination designer.  
  
 The expression that states the \<xref:System.Activities.Statements.FlowDecision.Condition*> can be typed in the **Condition** box of the **Properties** window by clicking where the hint text says “Enter a VB expression”.  
  
### The FlowDecision Properties  
 The following table shows the \<xref:System.Activities.Statements.FlowDecision> properties and describes how they are used in the designer. These properties can be edited in the property grid or on the designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|\<xref:System.Activities.Statements.FlowDecision.Condition*>|True|The condition that determines which path the flow control takes.|  
|\<xref:System.Activities.Statements.FlowDecision.True*>|False|The path taken by the flow control if the \<xref:System.Activities.Statements.FlowDecision.Condition*> is satisfied.|  
|\<xref:System.Activities.Statements.FlowDecision.False*>|False|The path taken by the flow control if the \<xref:System.Activities.Statements.FlowDecision.Condition*> is not satisfied.|  
  
## See Also  
 [Flowchart](../workflowdesigner/flowchart-activity-designers.md)   
 [Flowchart](../workflowdesigner/flowchart-activity-designer.md)   
 [FlowSwitch\<T>](../workflowdesigner/flowswitch-t--activity-designer.md)