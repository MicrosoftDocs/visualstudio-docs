---
title: "StateMachine Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 474d5fb3-1049-4b3f-bc6b-7524dbbe1672
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
# StateMachine Activity Designer
The <xref:System.Activities.Statements.StateMachine?qualifyHint=False> activity contains a collection of states and models workflows using the familiar state machine paradigm.  
  
## Using the StateMachine Activity Designer  
 To add a <xref:System.Activities.Statements.StateMachine?qualifyHint=False> activity, drag the **StateMachine** activity designer from the **State Machine** section of the **Toolbox** and drop it on to the Windows Workflow Designer surface. To add a child state to this <xref:System.Activities.Statements.StateMachine?qualifyHint=False> activity, drag a <xref:System.Activities.Statements.State?qualifyHint=False> or <xref:System.Activities.Core.Presentation.FinalState?qualifyHint=False> from the **Toolbox** and drop it onto the **StateMachine**.  
  
### StateMachine Activity Properties in the Workflow Designer  
 The following table shows the <xref:System.Activities.Statements.StateMachine?qualifyHint=False> properties that can be set using the workflow designer and describes how they are used in the designer. These properties can be edited in the property grid and some can be edited on the designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|Specifies the friendly name of the <xref:System.Activities.Statements.StateMachine?qualifyHint=False> activity designer in the header. The default value is **StateMachine**. The value can be edited in the property grid or directly on the header of the activity designer. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> is used in the breadcrumb navigation that is displayed at the top of the workflow designer.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName?qualifyHint=False> is not strictly required, it is a best practice to use one.|  
  
## See Also  
 [Flowchart](../WF_Design/Flowchart-Activity-Designer.md)   
 [Control Flow](../WF_Design/Control-Flow-Activity-Designers.md)