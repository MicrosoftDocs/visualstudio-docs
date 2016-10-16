---
title: "Delay Activity Designer"
ms.custom: na
ms.date: "10/02/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "System.Activities.Statements.Delay.UI"
ms.assetid: f51742a8-2c9a-47d1-8a23-18459d03ae19
caps.latest.revision: 8
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
# Delay Activity Designer
The **Delay** activity designer is used to create and configure a \<xref:System.Activities.Statements.Delay> activity.  
  
## The Delay Activity  
 The \<xref:System.Activities.Statements.Delay> activity delays the execution of a workflow for a specified amount of time.  
  
### Using the Delay Activity Designer  
 The **Delay** activity designer can be found in the **Primitives** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab of the [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **Delay** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] surface wherever activities are usually placed, such as inside a \<xref:System.Activities.Statements.Sequence>. This creates a \<xref:System.Activities.Statements.Delay> activity with a default \<xref:System.Activities.Activity.DisplayName*> of Delay. The \<xref:System.Activities.Activity.DisplayName*> can be edited in the header of the **Delay** activity designer or in the **DisplayName** box of the property grid.  
  
### The Delay Properties  
 The following table shows the \<xref:System.Activities.Statements.Delay> properties and describes how they are used in the designer. These properties can be edited in property grid and of them some can be edited on [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)]designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|\<xref:System.Activities.Activity.DisplayName*>|False|The friendly name of the \<xref:System.Activities.Statements.Delay> activity. The default is Delay. Although the \<xref:System.Activities.Activity.DisplayName*> value is not strictly required, it is a best practice to use one.|  
|\<xref:System.Activities.Statements.Delay.Duration*>|True|The amount of time to delay the workflow. This property is set in the property grid. Type in either a literal \<xref:System.TimeSpan> in the format 00:00:00 or a Visual Basic expression to specify the amount of time.|  
  
## See Also  
 [Primitives](../workflowdesigner/primitives-activity-designers.md)   
 [Assign](../workflowdesigner/assign-activity-designer.md)   
 [Delay Activity Designer](../workflowdesigner/delay-activity-designer.md)   
 [InvokeMethod](../workflowdesigner/invokemethod-activity-designer.md)   
 [WriteLine](../workflowdesigner/writeline-activity-designer.md)