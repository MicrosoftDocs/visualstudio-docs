---
title: "DoWhile Activity Designer | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "System.Activities.Statements.DoWhile.UI"
ms.assetid: 948deb35-d72f-462b-bea6-4b119c10a148
caps.latest.revision: 7
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
# DoWhile Activity Designer
The <xref:System.Activities.Statements.DoWhile> activity executes the activity contained in its <xref:System.Activities.Statements.DoWhile.Body%2A> at least once, until a specified condition evaluates to **false**. If you need the activity contained in a loop body to be executed zero or more times, use the <xref:System.Activities.Statements.While> activity instead.  
  
## DoWhile Properties in the Workflow Designer  
 The following table shows the most useful <xref:System.Activities.Statements.DoWhile> activity properties and describes how to use them in the designer.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Statements.DoWhile.Body%2A>|False|The activity to execute while the condition is **true**. To add the <xref:System.Activities.Statements.DoWhile.Body%2A> activity, drop an activity from the toolbox into the **Body** box on the **DoWhile** activity designer with hint text “Drop Activity Here”.|  
|<xref:System.Activities.Statements.DoWhile.Condition%2A>|True|The condition to evaluate after each iteration of the loop. To set the <xref:System.Activities.Statements.DoWhile.Condition%2A>, type a [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] expression in the **Condition** box on the **DoWhile** activity designer or in the property grid.|  
  
## See Also  
 [While](../workflow-designer/while-activity-designer.md)   
 [Control Flow](../workflow-designer/control-flow-activity-designers.md)