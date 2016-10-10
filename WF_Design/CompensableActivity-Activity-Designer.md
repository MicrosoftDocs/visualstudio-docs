---
title: "CompensableActivity Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: e0340d89-d39e-4a52-8557-13e27040d7b5
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
# CompensableActivity Activity Designer
The **CompensableActivity** activity designer is used to create and configure a <xref:System.Activities.Statements.CompensableActivity?qualifyHint=False> activity.  
  
## The CompensableActivity Activity  
 The <xref:System.Activities.Statements.CompensableActivity?qualifyHint=False> defines a unit of work that can be confirmed or compensated after successful completion.  
  
### Using the CompensableActivity Activity Designer  
 The **CompensableActivity** activity designer can be found in the **Transaction** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the left side of the Workflow Designer (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **CompensableActivity** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence?qualifyHint=False>. This creates a <xref:System.Activities.Statements.CompensableActivity?qualifyHint=False> activity with a default <xref:System.Activities.Activity.DisplayName?qualifyHint=False> of CompensableActivity. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> value can be edited in the header of the **CompensableActivity** activity designer or in the **DisplayName** box of the property grid.  
  
### The CompensableActivity Properties  
 The following table shows the <xref:System.Activities.Statements.CompensableActivity?qualifyHint=False> properties and describes how they are used in the designer. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> and <xref:System.Activities.Activity`1.Result?qualifyHint=False> property can be edited in property grid but the other properties must be edited on the Workflow Designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|The optional friendly name of the <xref:System.Activities.Statements.CompensableActivity?qualifyHint=False> activity. The default is CompensableActivity.|  
|<xref:System.Activities.Activity`1.Result?qualifyHint=False>|False|Specifies the return value of the <xref:System.Activities.Statements.CompensableActivity?qualifyHint=False>. This property must be edited in the property grid.|  
|<xref:System.Activities.Statements.CompensableActivity.Body?qualifyHint=False>|True|Specifies the activity for which the compensation, cancellation, and confirmation logic is provided. To add the <xref:System.Activities.Statements.CompensableActivity.Body?qualifyHint=False> activity, drop an activity from the **Toolbox** into the **Body** box on the **CompensableActivity** activity designer with hint text “Drop activity here”.|  
|<xref:System.Activities.Statements.CompensableActivity.CancellationHandler?qualifyHint=False>|False|Specifies the activity that is executed in the event of cancellation. To add the activity, drop its designer from the **Toolbox** into the **CancellationHandler** box on the **CompensableActivity** activity designer with hint text “Drop Activity Here”.|  
|<xref:System.Activities.Statements.CompensableActivity.CompensationHandler?qualifyHint=False>|False|Specifies the activity to be executed when compensating for the <xref:System.Activities.Statements.CompensableActivity.Body?qualifyHint=False> activity. This handler can be explicitly invoked using the <xref:System.Activities.Statements.Compensate?qualifyHint=False> activity.<br /><br /> To add the activity, drop its activity designer from the **Toolbox** into the **CompensationHandler** box on the **CompensableActivity** activity designer with hint text “Drop Activity Here”.|  
|<xref:System.Activities.Statements.CompensableActivity.ConfirmationHandler?qualifyHint=False>|False|Specifies the activity to be executed when confirming the <xref:System.Activities.Statements.CompensableActivity.Body?qualifyHint=False> activity. This handler can be explicitly invoked using the <xref:System.Activities.Statements.Confirm?qualifyHint=False> activity.<br /><br /> To add the activity, drop its activity designer from the **Toolbox** into the **ConfirmationHandler** box on the **CompensableActivity** activity designer with hint text “Drop Activity Here”.|  
  
## See Also  
 [Transaction](../WF_Design/Transaction-Activity-Designers.md)   
 [CancellationScope](../WF_Design/CancellationScope-Activity-Designer.md)   
 [Compensate](../WF_Design/Compensate-Activity-Designer.md)   
 [Confirm](../WF_Design/Confirm-Activity-Designer.md)   
 [TransactionScope](../WF_Design/TransactionScope-Activity-Designer.md)