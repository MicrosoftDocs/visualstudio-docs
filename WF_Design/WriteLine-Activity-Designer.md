---
title: "WriteLine Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 1b5f29a8-b7fd-477e-949e-2f689cae3c96
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
# WriteLine Activity Designer
The **WriteLine** activity designer is used to create and configure a <xref:System.Activities.Statements.WriteLine?qualifyHint=False> activity.  
  
## The WriteLine Activity  
 The <xref:System.Activities.Statements.Writeline?qualifyHint=False> activity writes text to a specified <xref:System.IO.TextWriter?qualifyHint=False> object. If no <xref:System.IO.TextWriter?qualifyHint=False> is specified, <xref:System.Activities.Statements.Writeline?qualifyHint=False> writes the text to the console.  
  
### Using the WriteLine Activity Designer  
 The **WriteLine** activity designer can be found in the **Primitives** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab of the Workflow Designer (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **WriteLine** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence?qualifyHint=False>. This creates a <xref:System.Activities.Statements.WriteLine?qualifyHint=False> activity with a default <xref:System.Activities.Activity.DisplayName?qualifyHint=False> of WriteLine. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> can be edited in the header of the **WriteLine** activity designer or in the **DisplayName** box of the property grid.  
  
### The WriteLine Properties  
 The following table shows the <xref:System.Activities.Statements.WriteLine?qualifyHint=False> properties and describes how they are used in the designer. These properties can be edited in property grid and some of them can be edited on Workflow Designerdesigner surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|The friendly name of the <xref:System.Activities.Statements.WriteLine?qualifyHint=False> activity. The default is WriteLine. Although the <xref:System.Activities.Activity.DisplayName?qualifyHint=False> is not strictly required, it is best practice to use a one.|  
|<xref:System.Activities.Statements.WriteLine.Text?qualifyHint=False>|False|The text to write. To set the property, type a Visual Basic expression in the **Text** box on the **WriteLine** activity designer or in the property grid.|  
|<xref:System.Activities.Statements.WriteLine.TextWriter?qualifyHint=False>|False|The <xref:System.IO.TextWriter?qualifyHint=False> to which the <xref:System.Activities.Statements.WriteLine?qualifyHint=False> writes the <xref:System.Activities.Statements.WriteLine.Text?qualifyHint=False>. The default is the console.|  
  
## See Also  
 [Primitives](../WF_Design/Primitives-Activity-Designers.md)   
 [Assign](../WF_Design/Assign-Activity-Designer.md)   
 [Delay](../WF_Design/Delay-Activity-Designer.md)   
 [InvokeMethod](../WF_Design/InvokeMethod-Activity-Designer.md)