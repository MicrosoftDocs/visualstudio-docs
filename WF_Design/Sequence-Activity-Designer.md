---
title: "Sequence Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 51c8d3cb-4d43-458f-9631-b63755f9ac94
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
# Sequence Activity Designer
The <xref:System.Activities.Statements.Sequence?qualifyHint=False> activity contains an ordered collection of child activities that it executes in order.  
  
 Another way to execute a set of activities in order is to use a <xref:System.Activities.Statements.Flowchart?qualifyHint=False> activity. Consider using the [Flowchart](../WF_Design/Flowchart-Activity-Designer.md) when you have a simple branching or looping program flow that you want to model diagrammatically.  
  
## Using the Sequence Activity Designer  
 To add a <xref:System.Activities.Statements.Sequence?qualifyHint=False> activity, drag the **Sequence** activity designer from the **Toolbox** and drop it on to the Windows Workflow Designer surface. To add a child activity to this <xref:System.Activities.Statements.Sequence?qualifyHint=False> activity, drag some other activity from the **Toolbox** and drop it on the triangle in the box with the hint text “Drop activity here”.  
  
### Sequence Activity Properties in the Workflow Designer  
 The following table shows the <xref:System.Activities.Statements.Sequence?qualifyHint=False> properties and describes how they are used in the designer. These properties can be edited in property grid or on the designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|Specifies the friendly name of the <xref:System.Activities.Statements.Sequence?qualifyHint=False> activity designer in the header. The default value is Sequence. The value can be edited in the property grid or directly on the header of the activity designer.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName?qualifyHint=False> is not strictly required, it is a best practice to use one.|  
  
## See Also  
 [Flowchart](../WF_Design/Flowchart-Activity-Designer.md)   
 [Control Flow](../WF_Design/Control-Flow-Activity-Designers.md)