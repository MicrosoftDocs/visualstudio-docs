---
title: "WriteLine Activity Designer"
ms.custom: na
ms.date: "10/02/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "System.Activities.Statements.WriteLine.UI"
ms.assetid: 1b5f29a8-b7fd-477e-949e-2f689cae3c96
caps.latest.revision: 5
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
# WriteLine Activity Designer
The **WriteLine** activity designer is used to create and configure a \<xref:System.Activities.Statements.WriteLine> activity.  
  
## The WriteLine Activity  
 The \<xref:System.Activities.Statements.Writeline> activity writes text to a specified \<xref:System.IO.TextWriter> object. If no \<xref:System.IO.TextWriter> is specified, \<xref:System.Activities.Statements.Writeline> writes the text to the console.  
  
### Using the WriteLine Activity Designer  
 The **WriteLine** activity designer can be found in the **Primitives** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab of the [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **WriteLine** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] surface wherever activities are usually placed, such as inside a \<xref:System.Activities.Statements.Sequence>. This creates a \<xref:System.Activities.Statements.WriteLine> activity with a default \<xref:System.Activities.Activity.DisplayName*> of WriteLine. The \<xref:System.Activities.Activity.DisplayName*> can be edited in the header of the **WriteLine** activity designer or in the **DisplayName** box of the property grid.  
  
### The WriteLine Properties  
 The following table shows the \<xref:System.Activities.Statements.WriteLine> properties and describes how they are used in the designer. These properties can be edited in property grid and some of them can be edited on [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)]designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|\<xref:System.Activities.Activity.DisplayName*>|False|The friendly name of the \<xref:System.Activities.Statements.WriteLine> activity. The default is WriteLine. Although the \<xref:System.Activities.Activity.DisplayName*> is not strictly required, it is best practice to use a one.|  
|\<xref:System.Activities.Statements.WriteLine.Text*>|False|The text to write. To set the property, type a Visual Basic expression in the **Text** box on the **WriteLine** activity designer or in the property grid.|  
|\<xref:System.Activities.Statements.WriteLine.TextWriter*>|False|The \<xref:System.IO.TextWriter> to which the \<xref:System.Activities.Statements.WriteLine> writes the \<xref:System.Activities.Statements.WriteLine.Text*>. The default is the console.|  
  
## See Also  
 [Primitives](../workflowdesigner/primitives-activity-designers.md)   
 [Assign](../workflowdesigner/assign-activity-designer.md)   
 [Delay](../workflowdesigner/delay-activity-designer.md)   
 [InvokeMethod](../workflowdesigner/invokemethod-activity-designer.md)