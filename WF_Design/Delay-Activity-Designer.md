---
title: "Delay Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: f51742a8-2c9a-47d1-8a23-18459d03ae19
caps.latest.revision: 8
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
# Delay Activity Designer
The **Delay** activity designer is used to create and configure a <xref:System.Activities.Statements.Delay?qualifyHint=False> activity.  
  
## The Delay Activity  
 The <xref:System.Activities.Statements.Delay?qualifyHint=False> activity delays the execution of a workflow for a specified amount of time.  
  
### Using the Delay Activity Designer  
 The **Delay** activity designer can be found in the **Primitives** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab of the Workflow Designer (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **Delay** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence?qualifyHint=False>. This creates a <xref:System.Activities.Statements.Delay?qualifyHint=False> activity with a default <xref:System.Activities.Activity.DisplayName?qualifyHint=False> of Delay. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> can be edited in the header of the **Delay** activity designer or in the **DisplayName** box of the property grid.  
  
### The Delay Properties  
 The following table shows the <xref:System.Activities.Statements.Delay?qualifyHint=False> properties and describes how they are used in the designer. These properties can be edited in property grid and of them some can be edited on Workflow Designerdesigner surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|The friendly name of the <xref:System.Activities.Statements.Delay?qualifyHint=False> activity. The default is Delay. Although the <xref:System.Activities.Activity.DisplayName?qualifyHint=False> value is not strictly required, it is a best practice to use one.|  
|<xref:System.Activities.Statements.Delay.Duration?qualifyHint=False>|True|The amount of time to delay the workflow. This property is set in the property grid. Type in either a literal <xref:System.TimeSpan?qualifyHint=False> in the format 00:00:00 or a Visual Basic expression to specify the amount of time.|  
  
## See Also  
 [Primitives](../WF_Design/Primitives-Activity-Designers.md)   
 [Assign](../WF_Design/Assign-Activity-Designer.md)   
 [Delay Activity Designer](../WF_Design/Delay-Activity-Designer.md)   
 [InvokeMethod](../WF_Design/InvokeMethod-Activity-Designer.md)   
 [WriteLine](../WF_Design/WriteLine-Activity-Designer.md)