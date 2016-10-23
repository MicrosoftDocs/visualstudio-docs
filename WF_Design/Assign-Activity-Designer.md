---
title: "Assign Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: ba3feb3c-f144-47ea-926d-cf752b804153
caps.latest.revision: 6
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
# Assign Activity Designer
The **Assign** activity designer is used to create and configure an <xref:System.Activities.Statements.Assign?qualifyHint=False> activity.  
  
## The Assign Activity  
 The <xref:System.Activities.Statements.Assign?qualifyHint=False> activity assigns a value to a variable or argument.  
  
### Using the Assign Activity Designer  
 The **Assign** activity designer can be found in the **Primitives** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab (Alternatively, select **Toolbox** from the **View** menu or CTRL+ALT+X.)  
  
 The **Assign** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface where ever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence?qualifyHint=False>. This creates an <xref:System.Activities.Statements.Assign?qualifyHint=False> activity with a default **DisplayName** of Assign. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> can be edited in the header of the **Assign** activity designer or in the **DisplayName** box of the property grid.  
  
### The Assign Properties  
 The following table shows the <xref:System.Activities.Statements.Assign?qualifyHint=False> properties and describes how they are used in the designer. These properties can be edited in property grid and some of them can be edited on Workflow Designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|The friendly name of the <xref:System.Activities.Statements.Assign?qualifyHint=False> activity. The default is Assign. Although the <xref:System.Activities.Activity.DisplayName?qualifyHint=False> value is not strictly required, it is a best practice to use one.|  
|<xref:System.Activities.Statements.Assign.To?qualifyHint=False>|True|The variable or argument to which the <xref:System.Activities.Statements.Assign.Value?qualifyHint=False> is assigned. This must be a valid Visual Basic identifier. To set the property, type a Visual Basic expression in the **To** box on the **Assign** activity designer or in the property grid.|  
|<xref:System.Activities.Statements.Assign.Value?qualifyHint=False>|True|The value that is assigned to the variable. To set the <xref:System.Activities.Statements.Assign.Value?qualifyHint=False>, type a Visual Basic expression in the **Value** box on the **Assign** activity designer or in the property grid.|  
  
## See Also  
 [Primitives](../WF_Design/Primitives-Activity-Designers.md)   
 [Delay](../WF_Design/Delay-Activity-Designer.md)   
 [InvokeMethod](../WF_Design/InvokeMethod-Activity-Designer.md)   
 [WriteLine](../WF_Design/WriteLine-Activity-Designer.md)