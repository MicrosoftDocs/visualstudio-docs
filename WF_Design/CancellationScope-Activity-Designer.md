---
title: "CancellationScope Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 2c85d663-b219-4142-9866-7693ffd46379
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
# CancellationScope Activity Designer
The **CancellationScope** activity designer is used to create and configure a <xref:System.Activities.Statements.CancellationScope?qualifyHint=False> activity.  
  
## The CancellationScope Activity  
 The <xref:System.Activities.Statements.CancellationScope?qualifyHint=False> activity allows you to specify an activity for execution and cancellation logic for that activity.  
  
### Using the CancellationScope Activity Designer  
 The **CancellationScope** activity designer can be found in the **Transaction** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab of the Workflow Designer (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **CancellationScope** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence?qualifyHint=False>. This creates a <xref:System.Activities.Statements.CancellationScope?qualifyHint=False> activity with a default <xref:System.Activities.Activity.DisplayName?qualifyHint=False> of CancellationScope. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> value can be edited in the header of the **CancellationScope** activity designer or in the **DisplayName** box of the property grid.  
  
### The CancellationScope Properties  
 The following table shows the <xref:System.Activities.Statements.CancellationScope?qualifyHint=False> properties and describes how they are used in the designer. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> property can be edited in property grid but the other properties must be edited on Workflow Designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|The optional friendly name of the <xref:System.Activities.Statements.CancellationScope?qualifyHint=False> activity. The default is CancellationScope. Although the <xref:System.Activities.Activity.DisplayName?qualifyHint=False> value is not strictly required, it is a best practice to use one.|  
|<xref:System.Activities.Statements.CancellationScope.Body?qualifyHint=False>|True|Specifies the activity for which cancellation logic is provided. To add the <xref:System.Activities.Statements.CancellationScope.Body?qualifyHint=False> activity, drop an activity from the **Toolbox** into the **Body** box on the **CancellationScope** activity designer with hint text “Drop Activity Here”.|  
|<xref:System.Activities.Statements.CancellationScope.CancellationHandler?qualifyHint=False>|True|Specifies the activity that is executed in the event of cancellation. To add the <xref:System.Activities.Statements.CancellationScope.CancellationHandler?qualifyHint=False> activity, drop an activity from the **Toolbox** into the **CancellationHandler** box on the **CancellationScope** activity designer with hint text “Drop Activity Here”.|  
  
## See Also  
 [Transaction](../WF_Design/Transaction-Activity-Designers.md)   
 [CompensableActivity](../WF_Design/CompensableActivity-Activity-Designer.md)   
 [Compensate](../WF_Design/Compensate-Activity-Designer.md)   
 [Confirm](../WF_Design/Confirm-Activity-Designer.md)   
 [TransactionScope](../WF_Design/TransactionScope-Activity-Designer.md)