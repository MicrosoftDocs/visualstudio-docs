---
title: "If Activity Designer"
ms.custom: na
ms.date: 10/10/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 930a8fa2-db98-43e9-ad6d-a85cc7a6519a
caps.latest.revision: 4
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
# If Activity Designer
The <xref:System.Activities.Statements.If?qualifyHint=False> activity evaluates a condition and executes an activity depending on the results of that evaluation. This activity is most useful when using a procedural modeling style of programming. An <xref:System.Activities.Statements.If?qualifyHint=False> activity can be nested inside a <xref:System.Activities.Statements.Sequence?qualifyHint=False> activity or a <xref:System.Activities.Statements.Parallel?qualifyHint=False> activity, for example. If you are using a <xref:System.Activities.Statements.Flowchart?qualifyHint=False> activity, consider using a <xref:System.Activities.Statements.FlowDecision?qualifyHint=False> activity instead.  
  
## If Properties in the Workflow Designer  
 The following table shows the most useful <xref:System.Activities.Statements.If?qualifyHint=False> activity properties and describes how to use them in the designer.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Statements.If.Condition?qualifyHint=False>|True|The condition that determines which child activity to execute. To set the <xref:System.Activities.Statements.If.Condition?qualifyHint=False>, type a Visual Basic expression in the **Condition** box on the **If** activity designer or in the property grid.|  
|<xref:System.Activities.Statements.If.Else?qualifyHint=False>|False|The activity to execute if the <xref:System.Activities.Statements.If.Condition?qualifyHint=False> is **false**. To add an activity that is executed by the <xref:System.Activities.Statements.If.Else?qualifyHint=False> branch, drop an activity from the **Toolbox** into the **Else** box on the **If** activity designer with hint text “Drop Activity Here”.|  
|<xref:System.Activities.Statements.If.Then?qualifyHint=False>|False|The activity to execute if the <xref:System.Activities.Statements.If.Condition?qualifyHint=False> is **true**. To add an activity that is executed by the <xref:System.Activities.Statements.If.Then?qualifyHint=False> branch, drop an activity from the **Toolbox** into the **Then** box on the **If** activity designer with hint text “Drop Activity Here”.|  
  
## See Also  
 [Sequence](../WF_Design/Sequence-Activity-Designer.md)   
 [Parallel](../WF_Design/Parallel-Activity-Designer.md)   
 [Control Flow](../WF_Design/Control-Flow-Activity-Designers.md)