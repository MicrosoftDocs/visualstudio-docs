---
title: "Confirm Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: c753b67b-b0e7-462a-bb4e-ba8db04a078d
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
# Confirm Activity Designer
The **Confirm** activity designer is used to create and configure a <xref:System.Activities.Statements.Confirm?qualifyHint=False> activity.  
  
## The Confirm Activity  
 The <xref:System.Activities.Statements.Confirm?qualifyHint=False> activity explicitly invokes the <xref:System.Activities.Statements.CompensableActivity.ConfirmationHandler?qualifyHint=False> for an activity contained in a <xref:System.Activities.Statements.CompensableActivity?qualifyHint=False>. If the <xref:System.Activities.Statements.Confirm?qualifyHint=False> activity is not used within the <xref:System.Activities.Statements.CompensableActivity.CancellationHandler?qualifyHint=False>, <xref:System.Activities.Statements.CompensableActivity.CompensationHandler?qualifyHint=False>, or <xref:System.Activities.Statements.CompensableActivity.ConfirmationHandler?qualifyHint=False> of a <xref:System.Activities.Statements.CompensableActivity?qualifyHint=False>, then you must specify the <xref:System.Activities.Statements.Confirm.Target?qualifyHint=False> property.  
  
 The <xref:System.Activities.Statements.CompensationToken?qualifyHint=False> specified by the <xref:System.Activities.Statements.Compensate.Target?qualifyHint=False> provides a means to explicitly confirm or compensate a <xref:System.Activities.Statements.CompensableActivity?qualifyHint=False> once the <xref:System.Activities.Statements.CompensableActivity.Body?qualifyHint=False> of the <xref:System.Activities.Statements.CompensableActivity?qualifyHint=False> has successfully completed.  
  
### Using the Confirm Activity Designer  
 The **Confirm** activity designer can be found in the **Transaction** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the left side of the Workflow Designer (Alternatively, select **Toolbar** from the **View** menu or CTRL+ALT+X.)  
  
 The **Confirm** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence?qualifyHint=False>. This creates a <xref:System.Activities.Statements.Confirm?qualifyHint=False> activity with a default <xref:System.Activities.Activity.DisplayName?qualifyHint=False> of Confirm. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> value can be edited either in the header of the **Confirm** activity designer or in the **DisplayName** box of the property grid.  
  
### The Confirm Properties  
 The following table shows the <xref:System.Activities.Statements.Confirm?qualifyHint=False> properties and describes how they are used in the designer. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> property can be edited in property grid or on Workflow Designer surface, but the <xref:System.Activities.Statements.Confirm.Target?qualifyHint=False> property must be edited in property grid.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|Specifies the optional friendly name of the <xref:System.Activities.Statements.CancellationScope?qualifyHint=False> activity. The default is Confirm.|  
|<xref:System.Activities.Statements.Confirm.Target?qualifyHint=False>|True|Specifies the <xref:System.Activities.InArgument`1?qualifyHint=False> that contains the <xref:System.Activities.Statements.CompensationToken?qualifyHint=False> for this <xref:System.Activities.Statements.Confirm?qualifyHint=False> activity.|  
  
## See Also  
 [Transaction](../WF_Design/Transaction-Activity-Designers.md)   
 [CancellationScope](../WF_Design/CancellationScope-Activity-Designer.md)   
 [CompensableActivity](../WF_Design/CompensableActivity-Activity-Designer.md)   
 [Compensate](../WF_Design/Compensate-Activity-Designer.md)   
 [TransactionScope](../WF_Design/TransactionScope-Activity-Designer.md)