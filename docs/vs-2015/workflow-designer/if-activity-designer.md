---
title: "If Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords: 
  - "System.Activities.Statements.If.UI"
ms.assetid: 930a8fa2-db98-43e9-ad6d-a85cc7a6519a
caps.latest.revision: 4
author: gewarren
ms.author: gewarren
manager: jillfra
---
# If Activity Designer
The <xref:System.Activities.Statements.If> activity evaluates a condition and executes an activity depending on the results of that evaluation. This activity is most useful when using a procedural modeling style of programming. An <xref:System.Activities.Statements.If> activity can be nested inside a <xref:System.Activities.Statements.Sequence> activity or a <xref:System.Activities.Statements.Parallel> activity, for example. If you are using a <xref:System.Activities.Statements.Flowchart> activity, consider using a <xref:System.Activities.Statements.FlowDecision> activity instead.  
  
## If Properties in the Workflow Designer  
 The following table shows the most useful <xref:System.Activities.Statements.If> activity properties and describes how to use them in the designer.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Statements.If.Condition%2A>|True|The condition that determines which child activity to execute. To set the <xref:System.Activities.Statements.If.Condition%2A>, type a [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] expression in the **Condition** box on the **If** activity designer or in the property grid.|  
|<xref:System.Activities.Statements.If.Else%2A>|False|The activity to execute if the <xref:System.Activities.Statements.If.Condition%2A> is **false**. To add an activity that is executed by the <xref:System.Activities.Statements.If.Else%2A> branch, drop an activity from the **Toolbox** into the **Else** box on the **If** activity designer with hint text “Drop Activity Here”.|  
|<xref:System.Activities.Statements.If.Then%2A>|False|The activity to execute if the <xref:System.Activities.Statements.If.Condition%2A> is **true**. To add an activity that is executed by the <xref:System.Activities.Statements.If.Then%2A> branch, drop an activity from the **Toolbox** into the **Then** box on the **If** activity designer with hint text “Drop Activity Here”.|  
  
## See also  
 [Sequence](../workflow-designer/sequence-activity-designer.md)   
 [Parallel](../workflow-designer/parallel-activity-designer.md)   
 [Control Flow](../workflow-designer/control-flow-activity-designers.md)