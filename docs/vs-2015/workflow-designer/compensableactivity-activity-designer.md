---
title: "CompensableActivity Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.Activities.Statements.CompensableActivity.UI"
ms.assetid: e0340d89-d39e-4a52-8557-13e27040d7b5
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# CompensableActivity Activity Designer
The **CompensableActivity** activity designer is used to create and configure a <xref:System.Activities.Statements.CompensableActivity> activity.

## The CompensableActivity Activity
 The <xref:System.Activities.Statements.CompensableActivity> defines a unit of work that can be confirmed or compensated after successful completion.

### Using the CompensableActivity Activity Designer
 The **CompensableActivity** activity designer can be found in the **Transaction** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the left side of the [!INCLUDE[wfd2](../includes/wfd2-md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)

 The **CompensableActivity** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates a <xref:System.Activities.Statements.CompensableActivity> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of CompensableActivity. The <xref:System.Activities.Activity.DisplayName%2A> value can be edited in the header of the **CompensableActivity** activity designer or in the **DisplayName** box of the property grid.

### The CompensableActivity Properties
 The following table shows the <xref:System.Activities.Statements.CompensableActivity> properties and describes how they are used in the designer. The <xref:System.Activities.Activity.DisplayName%2A> and <xref:System.Activities.Activity%601.Result%2A> property can be edited in property grid but the other properties must be edited on the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface.

|Property Name|Required|Usage|
|-------------------|--------------|-----------|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The optional friendly name of the <xref:System.Activities.Statements.CompensableActivity> activity. The default is CompensableActivity.|
|<xref:System.Activities.Activity%601.Result%2A>|False|Specifies the return value of the <xref:System.Activities.Statements.CompensableActivity>. This property must be edited in the property grid.|
|<xref:System.Activities.Statements.CompensableActivity.Body%2A>|True|Specifies the activity for which the compensation, cancellation, and confirmation logic is provided. To add the <xref:System.Activities.Statements.CompensableActivity.Body%2A> activity, drop an activity from the **Toolbox** into the **Body** box on the **CompensableActivity** activity designer with hint text “Drop activity here”.|
|<xref:System.Activities.Statements.CompensableActivity.CancellationHandler%2A>|False|Specifies the activity that is executed in the event of cancellation. To add the activity, drop its designer from the **Toolbox** into the **CancellationHandler** box on the **CompensableActivity** activity designer with hint text “Drop Activity Here”.|
|<xref:System.Activities.Statements.CompensableActivity.CompensationHandler%2A>|False|Specifies the activity to be executed when compensating for the <xref:System.Activities.Statements.CompensableActivity.Body%2A> activity. This handler can be explicitly invoked using the <xref:System.Activities.Statements.Compensate> activity.<br /><br /> To add the activity, drop its activity designer from the **Toolbox** into the **CompensationHandler** box on the **CompensableActivity** activity designer with hint text “Drop Activity Here”.|
|<xref:System.Activities.Statements.CompensableActivity.ConfirmationHandler%2A>|False|Specifies the activity to be executed when confirming the <xref:System.Activities.Statements.CompensableActivity.Body%2A> activity. This handler can be explicitly invoked using the <xref:System.Activities.Statements.Confirm> activity.<br /><br /> To add the activity, drop its activity designer from the **Toolbox** into the **ConfirmationHandler** box on the **CompensableActivity** activity designer with hint text “Drop Activity Here”.|

## See Also
 [Transaction](../workflow-designer/transaction-activity-designers.md)
 [CancellationScope](../workflow-designer/cancellationscope-activity-designer.md)
 [Compensate](../workflow-designer/compensate-activity-designer.md)
 [Confirm](../workflow-designer/confirm-activity-designer.md)
 [TransactionScope](../workflow-designer/transactionscope-activity-designer.md)