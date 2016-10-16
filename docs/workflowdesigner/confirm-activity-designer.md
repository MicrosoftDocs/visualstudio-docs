---
title: "Confirm Activity Designer"
ms.custom: na
ms.date: "10/02/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "System.Activities.Statements.Confirm.UI"
ms.assetid: c753b67b-b0e7-462a-bb4e-ba8db04a078d
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
# Confirm Activity Designer
The **Confirm** activity designer is used to create and configure a \<xref:System.Activities.Statements.Confirm> activity.  
  
## The Confirm Activity  
 The \<xref:System.Activities.Statements.Confirm> activity explicitly invokes the \<xref:System.Activities.Statements.CompensableActivity.ConfirmationHandler*> for an activity contained in a \<xref:System.Activities.Statements.CompensableActivity>. If the \<xref:System.Activities.Statements.Confirm> activity is not used within the \<xref:System.Activities.Statements.CompensableActivity.CancellationHandler*>, \<xref:System.Activities.Statements.CompensableActivity.CompensationHandler*>, or \<xref:System.Activities.Statements.CompensableActivity.ConfirmationHandler*> of a \<xref:System.Activities.Statements.CompensableActivity>, then you must specify the \<xref:System.Activities.Statements.Confirm.Target*> property.  
  
 The \<xref:System.Activities.Statements.CompensationToken> specified by the \<xref:System.Activities.Statements.Compensate.Target*> provides a means to explicitly confirm or compensate a \<xref:System.Activities.Statements.CompensableActivity> once the \<xref:System.Activities.Statements.CompensableActivity.Body*> of the \<xref:System.Activities.Statements.CompensableActivity> has successfully completed.  
  
### Using the Confirm Activity Designer  
 The **Confirm** activity designer can be found in the **Transaction** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the left side of the [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] (Alternatively, select **Toolbar** from the **View** menu or CTRL+ALT+X.)  
  
 The **Confirm** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] surface wherever activities are usually placed, such as inside a \<xref:System.Activities.Statements.Sequence>. This creates a \<xref:System.Activities.Statements.Confirm> activity with a default \<xref:System.Activities.Activity.DisplayName*> of Confirm. The \<xref:System.Activities.Activity.DisplayName*> value can be edited either in the header of the **Confirm** activity designer or in the **DisplayName** box of the property grid.  
  
### The Confirm Properties  
 The following table shows the \<xref:System.Activities.Statements.Confirm> properties and describes how they are used in the designer. The \<xref:System.Activities.Activity.DisplayName*> property can be edited in property grid or on [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] surface, but the \<xref:System.Activities.Statements.Confirm.Target*> property must be edited in property grid.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|\<xref:System.Activities.Activity.DisplayName*>|False|Specifies the optional friendly name of the \<xref:System.Activities.Statements.CancellationScope> activity. The default is Confirm.|  
|\<xref:System.Activities.Statements.Confirm.Target*>|True|Specifies the \<xref:System.Activities.InArgument`1> that contains the \<xref:System.Activities.Statements.CompensationToken> for this \<xref:System.Activities.Statements.Confirm> activity.|  
  
## See Also  
 [Transaction](../workflowdesigner/transaction-activity-designers.md)   
 [CancellationScope](../workflowdesigner/cancellationscope-activity-designer.md)   
 [CompensableActivity](../workflowdesigner/compensableactivity-activity-designer.md)   
 [Compensate](../workflowdesigner/compensate-activity-designer.md)   
 [TransactionScope](../workflowdesigner/transactionscope-activity-designer.md)