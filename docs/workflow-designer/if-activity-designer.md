---
title: "If Activity Designer"
ms.custom: ""
ms.date: "10/19/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "System.Activities.Statements.If.UI"
ms.assetid: 930a8fa2-db98-43e9-ad6d-a85cc7a6519a
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
# If Activity Designer
The <xref:System.Activities.Statements.If> activity evaluates a condition and executes an activity depending on the results of that evaluation. This activity is most useful when using a procedural modeling style of programming. An <xref:System.Activities.Statements.If> activity can be nested inside a <xref:System.Activities.Statements.Sequence> activity or a <xref:System.Activities.Statements.Parallel> activity, for example. If you are using a <xref:System.Activities.Statements.Flowchart> activity, consider using a <xref:System.Activities.Statements.FlowDecision> activity instead.  
  
## If Properties in the Workflow Designer  
 The following table shows the most useful <xref:System.Activities.Statements.If> activity properties and describes how to use them in the designer.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Statements.If.Condition*>|True|The condition that determines which child activity to execute. To set the <xref:System.Activities.Statements.If.Condition*>, type a [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] expression in the **Condition** box on the **If** activity designer or in the property grid.|  
|<xref:System.Activities.Statements.If.Else*>|False|The activity to execute if the <xref:System.Activities.Statements.If.Condition*> is **false**. To add an activity that is executed by the <xref:System.Activities.Statements.If.Else*> branch, drop an activity from the **Toolbox** into the **Else** box on the **If** activity designer with hint text “Drop Activity Here”.|  
|<xref:System.Activities.Statements.If.Then*>|False|The activity to execute if the <xref:System.Activities.Statements.If.Condition*> is **true**. To add an activity that is executed by the <xref:System.Activities.Statements.If.Then*> branch, drop an activity from the **Toolbox** into the **Then** box on the **If** activity designer with hint text “Drop Activity Here”.|  
  
## See Also  
 [Sequence](../workflow-designer/sequence-activity-designer.md)   
 [Parallel](../workflow-designer/parallel-activity-designer.md)   
 [Control Flow](../workflow-designer/control-flow-activity-designers.md)