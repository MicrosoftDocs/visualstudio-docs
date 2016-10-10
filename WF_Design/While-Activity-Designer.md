---
title: "While Activity Designer"
ms.custom: na
ms.date: 10/10/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: ea008091-2e4c-4f64-bfa5-afb919552446
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
# While Activity Designer
The <xref:System.Activities.Statements.While?qualifyHint=False> activity executes the activity contained in its <xref:System.Activities.Statements.While.Body?qualifyHint=False> while the specified <xref:System.Activities.Statements.Condition?qualifyHint=False> evaluates to **true**. The contained activity may never execute. If you want the contained activity to be executed at least once, use the <xref:System.Activities.Statements.DoWhile?qualifyHint=False> activity instead.  
  
## While Properties in Workflow Designer  
 The following table shows the most useful <xref:System.Activities.Statements.While?qualifyHint=False> activity properties and describes how they are used in the designer.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|Specifies the friendly name of the <xref:System.Activities.Statements.While?qualifyHint=False> activity designer in the header. The default value is While. The value can be edited in the **Properties** window or directly on the activity designer header.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName?qualifyHint=False> is not strictly required, it is a best practice to use one.|  
|<xref:System.Activities.Statements.While.Body?qualifyHint=False>|False|Contains the activity to execute while the <xref:System.Activities.Statements.Condition?qualifyHint=False> evaluates to **true**.|  
|<xref:System.Activities.Statements.Condition?qualifyHint=False>|True|Contains the Visual Basic expression that is evaluated to determine whether the activity in the <xref:System.Activities.Statements.While.Body?qualifyHint=False> is to be executed.|  
  
## See Also  
 [Control Flow](../WF_Design/Control-Flow-Activity-Designers.md)   
 [DoWhile](../WF_Design/DoWhile-Activity-Designer.md)