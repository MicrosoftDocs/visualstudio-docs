---
title: Workflow Designer - TransactionScope Activity Designer
description: Learn how you can use the TransactionScope activity designer to create and configure a TransactionScope activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- System.Activities.Statements.TransactionScope.UI
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# TransactionScope Activity Designer

The **TransactionScope** activity designer is used to create and configure a <xref:System.Activities.Statements.TransactionScope> activity.

## The TransactionScope Activity

The <xref:System.Activities.Statements.TransactionScope> activity executes the contained activity in a single transaction. The transaction commits when the <xref:System.Activities.Statements.TransactionScope.Body%2A> activity and all other participants in the transaction have completed successfully.

### Using the TransactionScope Activity Designer

Access the **TransactionScope** activity designer in the **Transaction** category of the **Toolbox**. The **TransactionScope** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates a <xref:System.Activities.Statements.TransactionScope> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of TransactionScope. The <xref:System.Activities.Activity.DisplayName%2A> value can be edited in the header of the **TransactionScope** activity designer or in the **DisplayName** box of the property grid.

### The TransactionScope Properties

The following table shows the <xref:System.Activities.Statements.TransactionScope> properties and describes how they are used in the designer. The <xref:System.Activities.Activity.DisplayName%2A> and <xref:System.Activities.Statements.TransactionScope.Body%2A> properties can be edited on Workflow Designer surface. But the other properties must be edited on the property grid.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The optional friendly name of the <xref:System.Activities.Statements.TransactionScope> activity. The default is TransactionScope. Although the <xref:System.Activities.Activity.DisplayName%2A> value is not strictly required, it is a best practice to use one.|
|<xref:System.Activities.Statements.TransactionScope.Body%2A>|True|Specifies the activity to execute in a single transaction. To add the <xref:System.Activities.Statements.TransactionScope.Body%2A> activity, drop an activity from the **Toolbox** into the **Body** box on the **TransactionScope** activity designer with hint text "Drop activity here".|
|<xref:System.Activities.Statements.TransactionScope.IsolationLevel%2A>|True|Specifies the <xref:System.Transactions.IsolationLevel> for this <xref:System.Activities.Statements.TransactionScope>.|
|<xref:System.Activities.Statements.TransactionScope.Timeout%2A>|False|Specifies the interval of time (formatted as 00:00:00, which indicates hours:minutes:seconds) that the transaction has to complete. The default value is 1 minute (00:01:00).|
|<xref:System.Activities.Statements.TransactionScope.AbortInstanceOnTransactionFailure*>|True|Specifies the value that indicates whether the workflow should be aborted if the transaction aborts.|

## See also

- [Transaction](../workflow-designer/transaction-activity-designers.md)
- [TerminateWorkflow](../workflow-designer/terminateworkflow-activity-designer.md)
- [CompensableActivity](../workflow-designer/compensableactivity-activity-designer.md)
- [Compensate](../workflow-designer/compensate-activity-designer.md)
- [Confirm](../workflow-designer/confirm-activity-designer.md)
