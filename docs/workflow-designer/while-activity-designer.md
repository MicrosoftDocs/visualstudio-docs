---
title: "While Activity Designer | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "System.Activities.Statements.While.UI"
ms.assetid: ea008091-2e4c-4f64-bfa5-afb919552446
caps.latest.revision: 5
author: "ErikRe"
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
# While Activity Designer
The <xref:System.Activities.Statements.While> activity executes the activity contained in its <xref:System.Activities.Statements.While.Body%2A> while the specified <xref:System.Activities.Statements.Condition%2A> evaluates to **true**. The contained activity may never execute. If you want the contained activity to be executed at least once, use the <xref:System.Activities.Statements.DoWhile> activity instead.  
  
## While Properties in Workflow Designer  
 The following table shows the most useful <xref:System.Activities.Statements.While> activity properties and describes how they are used in the designer.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName%2A>|False|Specifies the friendly name of the <xref:System.Activities.Statements.While> activity designer in the header. The default value is While. The value can be edited in the **Properties** window or directly on the activity designer header.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it is a best practice to use one.|  
|<xref:System.Activities.Statements.While.Body%2A>|False|Contains the activity to execute while the <xref:System.Activities.Statements.Condition%2A> evaluates to **true**.|  
|<xref:System.Activities.Statements.Condition%2A>|True|Contains the [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] expression that is evaluated to determine whether the activity in the <xref:System.Activities.Statements.While.Body%2A> is to be executed.|  
  
## See Also  
 [Control Flow](../workflow-designer/control-flow-activity-designers.md)   
 [DoWhile](../workflow-designer/dowhile-activity-designer.md)