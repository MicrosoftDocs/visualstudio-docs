---
title:  CancellationScope activity designer
description: Learn how you can use the CancellationScope activity designer in Workflow Designer to create and configure a CancellationScope activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- System.Activities.Statements.CancellationScope.UI
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# CancellationScope Activity Designer

The **CancellationScope** activity designer is used to create and configure a <xref:System.Activities.Statements.CancellationScope> activity.

## The CancellationScope Activity

The <xref:System.Activities.Statements.CancellationScope> activity allows you to specify an activity for execution and cancellation logic for that activity.

### Using the CancellationScope Activity Designer

The **CancellationScope** activity designer can be found in the **Transaction** category of **Toolbox**. To open **Toolbox**, select the **Toolbox** tab of the Workflow Designer. Alternatively, select **Toolbox** from the **View** menu, or press **Ctrl**+**Alt**+**X**.

The **CancellationScope** activity designer can be dragged from **Toolbox** and dropped on to the Workflow Designer surface wherever activities are placed, such as inside a <xref:System.Activities.Statements.Sequence>. Dropping the **CancellationScope** activity designer creates a <xref:System.Activities.Statements.CancellationScope> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of CancellationScope. Edit the <xref:System.Activities.Activity.DisplayName%2A> value in the header of the **CancellationScope** activity designer. You can also edit it in the **DisplayName** box of the property grid.

### The CancellationScope Properties

The following table shows the <xref:System.Activities.Statements.CancellationScope> properties and describes how they are used in the designer. The <xref:System.Activities.Activity.DisplayName%2A> property can be edited in property grid but the other properties must be edited on Workflow Designer surface.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The optional friendly name of the <xref:System.Activities.Statements.CancellationScope> activity. The default is CancellationScope. Although the <xref:System.Activities.Activity.DisplayName%2A> value is not strictly required, it is a best practice to use one.|
|<xref:System.Activities.Statements.CancellationScope.Body%2A>|True|Specifies the activity for which cancellation logic is provided. To add the <xref:System.Activities.Statements.CancellationScope.Body%2A> activity, drop an activity from **Toolbox** into the **Body** box on the **CancellationScope** activity designer. Add the hint text "Drop Activity Here".|
|<xref:System.Activities.Statements.CancellationScope.CancellationHandler%2A>|True|Specifies the activity that is executed if there's a cancellation. To add the <xref:System.Activities.Statements.CancellationScope.CancellationHandler%2A> activity, drop an activity from **Toolbox** into the **CancellationHandler** box on the **CancellationScope** activity designer. Add the hint text "Drop Activity Here".|

## See also

- [Transaction](../workflow-designer/transaction-activity-designers.md)
- [CompensableActivity](../workflow-designer/compensableactivity-activity-designer.md)
- [Compensate](../workflow-designer/compensate-activity-designer.md)
- [Confirm](../workflow-designer/confirm-activity-designer.md)
- [TransactionScope](../workflow-designer/transactionscope-activity-designer.md)
