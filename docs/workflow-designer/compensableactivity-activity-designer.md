---
title: CompensableActivity Activity Designer
description: Learn how you can use the CompensableActivity activity designer in Workflow Designer to create and configure a CompensableActivity activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- System.Activities.Statements.CompensableActivity.UI
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# CompensableActivity Activity Designer

The **CompensableActivity** activity designer is used to create and configure a <xref:System.Activities.Statements.CompensableActivity> activity.

## The CompensableActivity Activity
 The <xref:System.Activities.Statements.CompensableActivity> defines a unit of work that can be confirmed or compensated after successful completion.

### Using the CompensableActivity Activity Designer
 The **CompensableActivity** activity designer can be found in the **Transaction** category of **Toolbox**. To open **Toolbox**, select the **Toolbox** tab on the left side of the Workflow Designer. Alternatively, select **Toolbox** from the **View** menu, or press **Ctrl**+**Alt**+**X**.

 The **CompensableActivity** activity designer can be dragged from **Toolbox** and dropped on to the Workflow Designer surface. You could drop the activity designer inside a <xref:System.Activities.Statements.Sequence>. Dropping the activity designer creates a <xref:System.Activities.Statements.CompensableActivity> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of CompensableActivity. Edit the <xref:System.Activities.Activity.DisplayName%2A> value in the header of the **CompensableActivity** activity designer. It can also be edited in the **DisplayName** box of the property grid.

### The CompensableActivity Properties
 The following table shows the <xref:System.Activities.Statements.CompensableActivity> properties and describes how they are used in the designer. The <xref:System.Activities.Activity.DisplayName%2A> and <xref:System.Activities.Activity%601.Result%2A> property can be edited in property grid but the other properties must be edited on the Workflow Designer surface.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The optional friendly name of the <xref:System.Activities.Statements.CompensableActivity> activity. The default is CompensableActivity.|
|<xref:System.Activities.Activity%601.Result%2A>|False|Specifies the return value of the <xref:System.Activities.Statements.CompensableActivity>. This property must be edited in the property grid.|
|<xref:System.Activities.Statements.CompensableActivity.Body%2A>|True|Specifies the activity for which the compensation, cancellation, and confirmation logic is provided. To add the <xref:System.Activities.Statements.CompensableActivity.Body%2A> activity, drop an activity from **Toolbox** into the **Body** box on the **CompensableActivity** activity designer. Add the hint text "Drop activity here".|
|<xref:System.Activities.Statements.CompensableActivity.CancellationHandler%2A>|False|Specifies the activity that is executed when there's a cancellation. To add the activity, drop its designer from **Toolbox** into the **CancellationHandler** box on the **CompensableActivity** activity designer. Add hint text "Drop Activity Here".|
|<xref:System.Activities.Statements.CompensableActivity.CompensationHandler%2A>|False|Specifies the activity to be executed when compensating for the <xref:System.Activities.Statements.CompensableActivity.Body%2A> activity. This handler can be explicitly invoked using the <xref:System.Activities.Statements.Compensate> activity.<br /><br /> To add the activity, drop its activity designer from **Toolbox** into the **CompensationHandler** box on the **CompensableActivity** activity designer. Add hint text "Drop Activity Here".|
|<xref:System.Activities.Statements.CompensableActivity.ConfirmationHandler%2A>|False|Specifies the activity to be executed when confirming the <xref:System.Activities.Statements.CompensableActivity.Body%2A> activity. This handler can be explicitly invoked using the <xref:System.Activities.Statements.Confirm> activity.<br /><br /> To add the activity, drop its activity designer from **Toolbox** into the **ConfirmationHandler** box on the **CompensableActivity** activity designer. Add hint text "Drop Activity Here".|

## See also

- [Transaction](../workflow-designer/transaction-activity-designers.md)
- [CancellationScope](../workflow-designer/cancellationscope-activity-designer.md)
- [Compensate](../workflow-designer/compensate-activity-designer.md)
- [Confirm](../workflow-designer/confirm-activity-designer.md)
- [TransactionScope](../workflow-designer/transactionscope-activity-designer.md)
