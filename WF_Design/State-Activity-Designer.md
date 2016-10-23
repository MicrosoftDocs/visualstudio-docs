---
title: "State Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 9455ab37-93a0-4c46-9eb8-b6611ca23167
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
# State Activity Designer
A <xref:System.Activities.Statements.State?qualifyHint=False> represents a state in which a state machine can be in.  
  
## Using the State Activity Designer  
 To add a <xref:System.Activities.Statements.State?qualifyHint=False> to a workflow, drag the **State** activity designer from the **State Machine** section of the **Toolbox** and drop it on to a <xref:System.Activities.Statements.StateMachine?qualifyHint=False> activity on the Windows Workflow Designer surface. A <xref:System.Activities.Statements.State?qualifyHint=False> activity can be dropped onto a <xref:System.Activities.Statements.StateMachine?qualifyHint=False> and transitions added later; or a transition can be created as the <xref:System.Activities.Statements.State?qualifyHint=False> activity is dropped. To add a <xref:System.Activities.Statements.State?qualifyHint=False> activity and create a transition in one step, drag a **State** activity from the **State Machine** section of the **Toolbox** and hover it over another state in the workflow designer. When the dragged <xref:System.Activities.Statements.State?qualifyHint=False> is over another <xref:System.Activities.Statements.State?qualifyHint=False>, four triangles will appear around the other <xref:System.Activities.Statements.State?qualifyHint=False>. If the <xref:System.Activities.Statements.State?qualifyHint=False> is dropped onto one of the four triangles, it is added to the state machine and a transition is created from the source <xref:System.Activities.Statements.State?qualifyHint=False> to the dropped destination <xref:System.Activities.Statements.State?qualifyHint=False>. For more information, see [Transition](../WF_Design/Transition-Activity-Designer.md).  
  
### State Activity Properties in the Workflow Designer  
 The following table shows the <xref:System.Activities.Statements.State?qualifyHint=False> properties that can be set using the workflow designer and describes how they are used in the designer. Some of these properties can be edited in the property grid and some can be edited on the designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Statements.State.DisplayName?qualifyHint=False>|False|Specifies the friendly name of the <xref:System.Activities.Statements.State?qualifyHint=False> activity designer in the header. The default value is **State**. The value can be edited in the property grid or directly on the header of the activity designer. The <xref:System.Activities.Statements.State.DisplayName?qualifyHint=False> is used in the breadcrumb navigation that is displayed at the top of the workflow designer.<br /><br /> Although the <xref:System.Activities.Statements.State.DisplayName?qualifyHint=False> is not strictly required, it is a best practice to use one.|  
|<xref:System.Activities.Statements.State.Entry?qualifyHint=False>|False|Specifies the action that occurs when this state is transitioned to. When the <xref:System.Activities.Statements.State?qualifyHint=False> activity is expanded, this value can be set by dragging an activity from the **Toolbox** and dropping it onto the **Entry** section of the state.|  
|<xref:System.Activities.Statements.State.Exit?qualifyHint=False>|False|Specifies the action that occurs when this state is transitioned away from. When the <xref:System.Activities.Statements.State?qualifyHint=False> activity is expanded, this value can be set by dragging an activity from the **Toolbox** and dropping it onto the **Exit** section of the state.|  
|<xref:System.Activities.Statements.State.Transitions?qualifyHint=False>|False|Lists the possible transitions that originate from the <xref:System.Activities.Statements.State?qualifyHint=False>. Each item in the list has a link to the associated <xref:System.Activities.Statements.Transition?qualifyHint=False> and the destination <xref:System.Activities.Statements.State?qualifyHint=False>. Clicking the link will switch the designer to an expanded view of the <xref:System.Activities.Statements.Transition?qualifyHint=False> or <xref:System.Activities.Statements.State?qualifyHint=False>.|  
  
## See Also  
 [StateMachine](../WF_Design/StateMachine-Activity-Designer.md)   
 [FinalState](../WF_Design/FinalState-Activity-Designer.md)   
 [Transition](../WF_Design/Transition-Activity-Designer.md)