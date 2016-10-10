---
title: "Flowchart Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: d5af2276-5215-4138-880a-cf2b90bbf3a0
caps.latest.revision: 5
manager: erikre
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Flowchart Activity Designer
The <xref:System.Activities.Statements.Flowchart?qualifyHint=False> activity is used to create workflows that define and manage complex flow controls. A <xref:System.Activities.Statements.Flowchart?qualifyHint=False> can be authored either in code or by using Workflow Designer. This topic documents the Workflow Designer experience. The Windows Workflow Designer workflow activity designer enables developers to author workflows in a natural manner.  
  
## The Flowchart Activity  
 The <xref:System.Activities.Statements.Flowchart?qualifyHint=False> specifies a unique <xref:System.Activities.Statements.Flowchart.StartNode?qualifyHint=False> that is executed when the workflow starts and uses a network of linked <xref:System.Activities.Statements.Flowchart.Nodes?qualifyHint=False> to create arbitrary loops or to divert the flow of execution to anywhere else in the workflow at any given time.  
  
### Using the Flowchart Activity Designer  
 The **Flowchart** activity designer can be found in the **Flowchart** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the Workflow Designer (Alternatively, select **Toolbar** from the **View** menu or CTRL+ALT+X.)  
  
 The **Flowchart** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activity designers are normally placed, either as a root activity or as the child of another control flow activity. If the **Flowchart** activity designer is dropped onto a blank Workflow Designer surface, it creates a <xref:System.Activities.Statements.Flowchart?qualifyHint=False> activity, which by default presents itself in an expanded view in which the start node that initiates execution is represented as a green ball. If the **Flowchart** activity designer is dropped into another control flow activity, it presents itself in a minimized view that can be expanded by double-clicking the **Flowchart** activity designer. Any activity in the **Toolbox** can be dragged directly onto the **Flowchart** activity designer, including other control flow activities.  
  
 After dragging various activity designers onto the Workflow Designer canvas, the <xref:System.Activities.Activity?qualifyHint=False> objects they represent can be linked together to specify the order of execution. To create a link between a source activity and a destination activity, mouse over the designer of the source activity and square handles appear on each side of it. Click one of the square handles and drag it by holding down the mouse button to one of the handles that appears in a similar manner around the destination activity when hovering over it with the mouse. Release the mouse button and a link is created between these two activities that is represented as an arrow from the source designer to the destination designer.  
  
### Flowchart Activity Properties  
 The following table shows the <xref:System.Activities.Statements.Flowchart?qualifyHint=False> properties and describes how they are used in the designer. These properties can be edited in property grid or on the designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|Specifies the display name of the activity designer in the header. The default value is Flowchart. The value can be edited in the **Properties** window or directly on the activity designer header.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName?qualifyHint=False> is not strictly required, it is a best practice to use one.|  
|<xref:System.Activities.Statements.Flowchart.Variables?qualifyHint=False>|False|The collection of variables that are scoped within this <xref:System.Activities.Statements.Flowchart?qualifyHint=False> to share state across its child activities.|  
|<xref:System.Activities.Statements.Flowchart.StartNode?qualifyHint=False>|False|The <xref:System.Activities.Statements.FlowNode?qualifyHint=False> that is executed when the <xref:System.Activities.Statements.Flowchart?qualifyHint=False> starts.|  
|<xref:System.Activities.Statements.Flowchart.Nodes?qualifyHint=False>|False|Contains the collection of <xref:System.Activities.Statements.FlowNode?qualifyHint=False> objects in the <xref:System.Activities.Statements.Flowchart?qualifyHint=False>.|  
  
## See Also  
 [Flowchart](../WF_Design/Flowchart-Activity-Designers.md)   
 [FlowDecision](../WF_Design/FlowDecision-Activity-Designer.md)   
 [FlowSwitch<T\>](../WF_Design/FlowSwitch-T--Activity-Designer.md)