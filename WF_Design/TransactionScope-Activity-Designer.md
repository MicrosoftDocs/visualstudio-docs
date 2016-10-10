---
title: "TransactionScope Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 8d7ebfc6-7478-4888-b3b0-b14f296096af
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
# TransactionScope Activity Designer
The **TransactionScope** activity designer is used to create and configure a <xref:System.Activities.Statements.TransactionScope?qualifyHint=False> activity.  
  
## The TransactionScope Activity  
 The <xref:System.Activities.Statements.TransactionScope?qualifyHint=False> activity executes the contained activity in a single transaction. The transaction commits when the <xref:System.Activities.Statements.TransactionScope.Body?qualifyHint=False> activity and all other participants in the transaction have completed successfully.  
  
### Using the TransactionScope Activity Designer  
 The **TransactionScope** activity designer can be found in the **Transaction** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab of Workflow Designer (Alternatively, select **Toolbar** from the **View** menu or CTRL+ALT+X.)  
  
 The **TransactionScope** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence?qualifyHint=False>. This creates a <xref:System.Activities.Statements.TransactionScope?qualifyHint=False> activity with a default <xref:System.Activities.Activity.DisplayName?qualifyHint=False> of TransactionScope. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> value can be edited in the header of the **TransactionScope** activity designer or in the **DisplayName** box of the property grid.  
  
### The TransactionScope Properties  
 The following table shows the <xref:System.Activities.Statements.TransactionScope?qualifyHint=False> properties and describes how they are used in the designer. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> and <xref:System.Activities.Statements.TransactionScope.Body?qualifyHint=False> properties can be edited on Workflow Designer surface. But the other properties must be edited on the property grid.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|The optional friendly name of the <xref:System.Activities.Statements.TransactionScope?qualifyHint=False> activity. The default is TransactionScope. Although the <xref:System.Activities.Activity.DisplayName?qualifyHint=False> value is not strictly required, it is a best practice to use one.|  
|<xref:System.Activities.Statements.TransactionScope.Body?qualifyHint=False>|True|Specifies the activity to execute in a single transaction. To add the <xref:System.Activities.Statements.TransactionScope.Body?qualifyHint=False> activity, drop an activity from the **Toolbox** into the **Body** box on the **TransactionScope** activity designer with hint text “Drop activity here”.|  
|<xref:System.Activities.Statements.TransactionScope.IsolationLevel?qualifyHint=False>|True|Specifies the <xref:System.Transactions.IsolationLevel?qualifyHint=False> for this <xref:System.Activities.Statements.TransactionScope?qualifyHint=False>.|  
|<xref:System.Activities.Statements.TransactionScope.Timeout?qualifyHint=False>|False|Specifies the interval of time (formatted as 00:00:00, which indicates hours:minutes:seconds) that the transaction has to complete. The default value is 1 minute (00:01:00).|  
|<xref:System.Activities.Statements.TransactionScope.?qualifyHint=False> AbortInstanceOnTransactionFailure?qualifyHint=False&autoUpgrade=True|True|Specifies the value that indicates whether the workflow should be aborted if the transaction aborts.|  
  
## See Also  
 [Transaction](../WF_Design/Transaction-Activity-Designers.md)   
 [TerminateWorkflow](../WF_Design/TerminateWorkflow-Activity-Designer.md)   
 [CompensableActivity](../WF_Design/CompensableActivity-Activity-Designer.md)   
 [Compensate](../WF_Design/Compensate-Activity-Designer.md)   
 [Confirm](../WF_Design/Confirm-Activity-Designer.md)