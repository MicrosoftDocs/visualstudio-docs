---
title: "TransactedReceiveScope Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.ServiceModel.Activities.TransactedReceiveScope.UI"
ms.assetid: 7ca93aad-4e83-4d81-90f4-998ee114d9b6
caps.latest.revision: 4
author: jillre
ms.author: jillfra
manager: jillfra
---
# TransactedReceiveScope Activity Designer
The **TransactedReceiveScope** designer is used to create and configure a <xref:System.ServiceModel.Activities.TransactedReceiveScope> activity.

## The TransactedReceiveScope Activity
 The <xref:System.ServiceModel.Activities.TransactedReceiveScope> activity enables you to flow a transaction into server transactions created by a workflow or dispatcher.

### Using the TransactedReceiveScope Activity Designer
 The **TransactedReceiveScope** activity designer can be found in the **Messaging** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on [!INCLUDE[wfd2](../includes/wfd2-md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)

 The **TransactedReceiveScope** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface wherever activities are usually placed. This creates a <xref:System.ServiceModel.Activities.TransactedReceiveScope> activity with a default **DisplayName** of TransactedReceiveScope. The <xref:System.Activities.Activity.DisplayName%2A> can be edited in the header of the **TransactedReceiveScope** activity designer or in the **DisplayName** box of the property grid.

 The **TransactedReceiveScope** designer contains **Request** and **Body** boxes. These are used to configure the <xref:System.ServiceModel.Activities.TransactedReceiveScope.Request%2A> property, which specifies a <xref:System.ServiceModel.Activities.Receive> activity and a <xref:System.ServiceModel.Activities.TransactedReceiveScope.Body%2A> property, which specifies some other <xref:System.Activities.Activity>. The <xref:System.ServiceModel.Activities.TransactedReceiveScope.Request%2A> creates a transaction. The transaction then is made ambient for the scope of the <xref:System.ServiceModel.Activities.TransactedReceiveScope.Body%2A> so that any activity within this scope executes inside this transaction.

### The TransactedReceiveScope Properties
 The following table shows the <xref:System.ServiceModel.Activities.TransactedReceiveScope> properties and describes how they are used in the designer. These <xref:System.Activities.Activity.DisplayName%2A> property can be edited in property grid or on the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface, but the others must be edited on the design surface.

|Property Name|Required|Usage|
|-------------------|--------------|-----------|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The optional friendly name of the <xref:System.ServiceModel.Activities.TransactedReceiveScope> activity. The default is TransactedReceiveScope.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName%2A> name is not strictly required, it is a best practice to use a display name.|
|<xref:System.ServiceModel.Activities.TransactedReceiveScope.Request%2A>|True|Drops a <xref:System.ServiceModel.Activities.Receive> activity into the **Request** block on the activity designer surface.|
|<xref:System.ServiceModel.Activities.TransactedReceiveScope.Body%2A>|False|Drops an <xref:System.Activities.Activity> into the **Body** block on the activity designer surface.|

## See Also
 [CorrelationScope](../workflow-designer/correlationscope-activity-designer.md)
 [InitializeCorrelation](../workflow-designer/initializecorrelation-activity-designer.md)
 [Receive](../workflow-designer/receive-activity-designer.md)
 [ReceiveAndSendReply](../workflow-designer/receiveandsendreply-template-designer.md)
 [Send](../workflow-designer/send-activity-designer.md)
 [SendAndReceiveReply](../workflow-designer/sendandreceivereply-template-designer.md)