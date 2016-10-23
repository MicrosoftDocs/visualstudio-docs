---
title: "Persist Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: be8648dd-3eb9-4a50-8ec1-57a8be804692
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
# Persist Activity Designer
The **Persist** activity designer is used to create and configure a <xref:System.Activities.Statements.Persist?qualifyHint=False> activity.  
  
## The Persist Activity  
 The <xref:System.Activities.Statements.Persist?qualifyHint=False> activity saves a workflow to disk, if possible. The <xref:System.Activities.Statements.Persist?qualifyHint=False> activity cannot be executed in a non-persistence zone as, for example, within a <xref:System.Activities.Statements.TransactionScope?qualifyHint=False> activity. If you do use a <xref:System.Activities.Statements.Persist?qualifyHint=False> activity in a non-persistence scope, an exception is thrown at runtime.  
  
### Using the Persist Activity Designer  
 The **Persist** activity designer can be found in the **Runtime** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab (Alternatively, select **Toolbox** from the **View** menu or CTRL+ALT+X.)  
  
 The **Persist** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence?qualifyHint=False>. This creates a <xref:System.Activities.Statements.Persist?qualifyHint=False> activity with a default **DisplayName** of Persist. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> can be edited in the header of the **Persist** activity designer or in the **DisplayName** box of the property grid.  
  
### The Persist Properties  
 The following table shows the <xref:System.Activities.Statements.Persist?qualifyHint=False> properties and describes how they are used in the designer. These properties can be edited in property grid and some of them can be edited on Workflow Designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|The friendly name of the <xref:System.Activities.Statements.Persist?qualifyHint=False> activity. The default is Persist. Although the display name is not strictly required, it is a best practice to use a display name.|  
  
## See Also  
 [Runtime](../WF_Design/Runtime-Activity-Designers.md)   
 [TerminateWorkflow](../WF_Design/TerminateWorkflow-Activity-Designer.md)