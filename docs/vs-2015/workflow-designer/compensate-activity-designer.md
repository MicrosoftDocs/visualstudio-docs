---
title: "Compensate Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.Activities.Statements.Compensate.UI"
ms.assetid: 7347c947-bfff-4bad-becd-5cd23e7b24cd
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# Compensate Activity Designer
The **Compensate** activity designer is used to create and configure a <xref:System.Activities.Statements.Compensate> activity.

## The Compensate Activity
 The <xref:System.Activities.Statements.Compensate> activity explicitly invokes the <xref:System.Activities.Statements.CompensableActivity.CompensationHandler%2A> for an activity contained in a <xref:System.Activities.Statements.CompensableActivity>. If the <xref:System.Activities.Statements.Compensate> activity is not used within the <xref:System.Activities.Statements.CompensableActivity.CancellationHandler%2A>, <xref:System.Activities.Statements.CompensableActivity.CompensationHandler%2A>, or <xref:System.Activities.Statements.CompensableActivity.ConfirmationHandler%2A> of a <xref:System.Activities.Statements.CompensableActivity>, then you must specify the <xref:System.Activities.Statements.Compensate.Target%2A> property.

 The <xref:System.Activities.Statements.CompensationToken> specified by the <xref:System.Activities.Statements.Compensate.Target%2A> provides a means to explicitly confirm or compensate a <xref:System.Activities.Statements.CompensableActivity> once the <xref:System.Activities.Statements.CompensableActivity.Body%2A> of the <xref:System.Activities.Statements.CompensableActivity> has successfully completed.

### Using the Compensate Activity Designer
 The **Compensate** activity designer can be found in the **Transaction** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the left side of the [!INCLUDE[wfd2](../includes/wfd2-md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)

 The **Compensate** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates a <xref:System.Activities.Statements.Compensate> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of Compensate. The <xref:System.Activities.Activity.DisplayName%2A> value can be edited in the header of the **Compensate** activity designer or in the **DisplayName** box of the property grid.

### The Compensate Properties
 The following table shows the <xref:System.Activities.Statements.CancellationScope> properties and describes how they are used in the designer. The <xref:System.Activities.Activity.DisplayName%2A> property can be edited in property grid or on [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface, but the <xref:System.Activities.Statements.Compensate.Target%2A> property must be edited in property grid.

|Property Name|Required|Usage|
|-------------------|--------------|-----------|
|<xref:System.Activities.Activity.DisplayName%2A>|False|Specifies the optional friendly name of the <xref:System.Activities.Statements.Compensate> activity. The default is Compensate.|
|<xref:System.Activities.Statements.Compensate.Target%2A>|True|Specifies the <xref:System.Activities.InArgument%601> that contains the <xref:System.Activities.Statements.CompensationToken> for this <xref:System.Activities.Statements.Compensate> activity.|

## See Also
 [Transaction](../workflow-designer/transaction-activity-designers.md)
 [CompensableActivity](../workflow-designer/compensableactivity-activity-designer.md)
 [Compensate Activity Designer](../workflow-designer/compensate-activity-designer.md)
 [Confirm](../workflow-designer/confirm-activity-designer.md)
 [TransactionScope](../workflow-designer/transactionscope-activity-designer.md)