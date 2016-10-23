---
title: "DoWhile Activity Designer"
ms.custom: na
ms.date: 10/10/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 948deb35-d72f-462b-bea6-4b119c10a148
caps.latest.revision: 7
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
# DoWhile Activity Designer
The <xref:System.Activities.Statements.DoWhile?qualifyHint=False> activity executes the activity contained in its <xref:System.Activities.Statements.DoWhile.Body?qualifyHint=False> at least once, until a specified condition evaluates to **false**. If you need the activity contained in a loop body to be executed zero or more times, use the <xref:System.Activities.Statements.While?qualifyHint=False> activity instead.  
  
## DoWhile Properties in the Workflow Designer  
 The following table shows the most useful <xref:System.Activities.Statements.DoWhile?qualifyHint=False> activity properties and describes how to use them in the designer.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Statements.DoWhile.Body?qualifyHint=False>|False|The activity to execute while the condition is **true**. To add the <xref:System.Activities.Statements.DoWhile.Body?qualifyHint=False> activity, drop an activity from the toolbox into the **Body** box on the **DoWhile** activity designer with hint text “Drop Activity Here”.|  
|<xref:System.Activities.Statements.DoWhile.Condition?qualifyHint=False>|True|The condition to evaluate after each iteration of the loop. To set the <xref:System.Activities.Statements.DoWhile.Condition?qualifyHint=False>, type a Visual Basic expression in the **Condition** box on the **DoWhile** activity designer or in the property grid.|  
  
## See Also  
 [While](../WF_Design/While-Activity-Designer.md)   
 [Control Flow](../WF_Design/Control-Flow-Activity-Designers.md)