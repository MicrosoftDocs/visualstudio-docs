---
title: "CancellationScope Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.Activities.Statements.CancellationScope.UI"
ms.assetid: 2c85d663-b219-4142-9866-7693ffd46379
caps.latest.revision: 8
author: jillre
ms.author: jillfra
manager: jillfra
---
# CancellationScope Activity Designer
The **CancellationScope** activity designer is used to create and configure a <xref:System.Activities.Statements.CancellationScope> activity.

## The CancellationScope Activity
 The <xref:System.Activities.Statements.CancellationScope> activity allows you to specify an activity for execution and cancellation logic for that activity.

### Using the CancellationScope Activity Designer
 The **CancellationScope** activity designer can be found in the **Transaction** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab of the [!INCLUDE[wfd2](../includes/wfd2-md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)

 The **CancellationScope** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates a <xref:System.Activities.Statements.CancellationScope> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of CancellationScope. The <xref:System.Activities.Activity.DisplayName%2A> value can be edited in the header of the **CancellationScope** activity designer or in the **DisplayName** box of the property grid.

### The CancellationScope Properties
 The following table shows the <xref:System.Activities.Statements.CancellationScope> properties and describes how they are used in the designer. The <xref:System.Activities.Activity.DisplayName%2A> property can be edited in property grid but the other properties must be edited on [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface.

|Property Name|Required|Usage|
|-------------------|--------------|-----------|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The optional friendly name of the <xref:System.Activities.Statements.CancellationScope> activity. The default is CancellationScope. Although the <xref:System.Activities.Activity.DisplayName%2A> value is not strictly required, it is a best practice to use one.|
|<xref:System.Activities.Statements.CancellationScope.Body%2A>|True|Specifies the activity for which cancellation logic is provided. To add the <xref:System.Activities.Statements.CancellationScope.Body%2A> activity, drop an activity from the **Toolbox** into the **Body** box on the **CancellationScope** activity designer with hint text “Drop Activity Here”.|
|<xref:System.Activities.Statements.CancellationScope.CancellationHandler%2A>|True|Specifies the activity that is executed in the event of cancellation. To add the <xref:System.Activities.Statements.CancellationScope.CancellationHandler%2A> activity, drop an activity from the **Toolbox** into the **CancellationHandler** box on the **CancellationScope** activity designer with hint text “Drop Activity Here”.|

## See Also
 [Transaction](../workflow-designer/transaction-activity-designers.md)
 [CompensableActivity](../workflow-designer/compensableactivity-activity-designer.md)
 [Compensate](../workflow-designer/compensate-activity-designer.md)
 [Confirm](../workflow-designer/confirm-activity-designer.md)
 [TransactionScope](../workflow-designer/transactionscope-activity-designer.md)