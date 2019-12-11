---
title: "Confirm Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.Activities.Statements.Confirm.UI"
ms.assetid: c753b67b-b0e7-462a-bb4e-ba8db04a078d
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# Confirm Activity Designer
The **Confirm** activity designer is used to create and configure a <xref:System.Activities.Statements.Confirm> activity.

## The Confirm Activity
 The <xref:System.Activities.Statements.Confirm> activity explicitly invokes the <xref:System.Activities.Statements.CompensableActivity.ConfirmationHandler%2A> for an activity contained in a <xref:System.Activities.Statements.CompensableActivity>. If the <xref:System.Activities.Statements.Confirm> activity is not used within the <xref:System.Activities.Statements.CompensableActivity.CancellationHandler%2A>, <xref:System.Activities.Statements.CompensableActivity.CompensationHandler%2A>, or <xref:System.Activities.Statements.CompensableActivity.ConfirmationHandler%2A> of a <xref:System.Activities.Statements.CompensableActivity>, then you must specify the <xref:System.Activities.Statements.Confirm.Target%2A> property.

 The <xref:System.Activities.Statements.CompensationToken> specified by the <xref:System.Activities.Statements.Compensate.Target%2A> provides a means to explicitly confirm or compensate a <xref:System.Activities.Statements.CompensableActivity> once the <xref:System.Activities.Statements.CompensableActivity.Body%2A> of the <xref:System.Activities.Statements.CompensableActivity> has successfully completed.

### Using the Confirm Activity Designer
 The **Confirm** activity designer can be found in the **Transaction** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the left side of the [!INCLUDE[wfd2](../includes/wfd2-md.md)] (Alternatively, select **Toolbar** from the **View** menu or CTRL+ALT+X.)

 The **Confirm** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates a <xref:System.Activities.Statements.Confirm> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of Confirm. The <xref:System.Activities.Activity.DisplayName%2A> value can be edited either in the header of the **Confirm** activity designer or in the **DisplayName** box of the property grid.

### The Confirm Properties
 The following table shows the <xref:System.Activities.Statements.Confirm> properties and describes how they are used in the designer. The <xref:System.Activities.Activity.DisplayName%2A> property can be edited in property grid or on [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface, but the <xref:System.Activities.Statements.Confirm.Target%2A> property must be edited in property grid.

|Property Name|Required|Usage|
|-------------------|--------------|-----------|
|<xref:System.Activities.Activity.DisplayName%2A>|False|Specifies the optional friendly name of the <xref:System.Activities.Statements.CancellationScope> activity. The default is Confirm.|
|<xref:System.Activities.Statements.Confirm.Target%2A>|True|Specifies the <xref:System.Activities.InArgument%601> that contains the <xref:System.Activities.Statements.CompensationToken> for this <xref:System.Activities.Statements.Confirm> activity.|

## See Also
 [Transaction](../workflow-designer/transaction-activity-designers.md)
 [CancellationScope](../workflow-designer/cancellationscope-activity-designer.md)
 [CompensableActivity](../workflow-designer/compensableactivity-activity-designer.md)
 [Compensate](../workflow-designer/compensate-activity-designer.md)
 [TransactionScope](../workflow-designer/transactionscope-activity-designer.md)