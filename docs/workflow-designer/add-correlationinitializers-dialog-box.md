---
title: Add CorrelationInitializers dialog box
description: Learn how you can use the Add Correlation Initializers dialog box in Workflow Designer to configure the CorrelationInitializers properties of the Send, Receive, and SendReply activities.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- AddCorrelationInitializers.UI
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Add CorrelationInitializers Dialog Box

The **Add Correlation Initializers** dialog box is used in Workflow Designer to configure the **CorrelationInitializers** properties of the <xref:System.ServiceModel.Activities.Send>, <xref:System.ServiceModel.Activities.Receive>, <xref:System.ServiceModel.Activities.SendReply>, and <xref:System.ServiceModel.Activities.ReceiveReply> activities. For more information about the activity designers that use this box, see the [Send](../workflow-designer/send-activity-designer.md), [Receive](../workflow-designer/receive-activity-designer.md), [ReceiveAndSendReply](../workflow-designer/receiveandsendreply-template-designer.md), and [SendAndReceiveReply](../workflow-designer/sendandreceivereply-template-designer.md) topics.

The correlation initializers in the collection specified with this dialog box can initialize the following correlations between the messaging activities:

- query-based
- context
- callback context
- request-reply

The following table describes the user interface (UI) elements of the **Add Correlation Initializers** dialog box:

|UI Element|Description|
|-|-----------------|
|**Add Initializer**|Click the **Add initialize** box to add an additional initializer to the collection.|
|**Correlation Type**|Specifies the type of correlation initializer. There are four types to choose from:<br /><br /> 1. A callback correlation initializer to specify a <xref:System.ServiceModel.Activities.CallbackCorrelationInitializer>.<br />2. A context correlation initializer to specify a <xref:System.ServiceModel.Activities.CorrelationInitializer>.<br />3. A request-reply correlation initializer to specify a <xref:System.ServiceModel.Activities.RequestReplyCorrelationInitializer>.<br />4. A query correlation initializer to specify a <xref:System.ServiceModel.Activities.QueryCorrelationInitializer>.<br /><br /> To edit the **CorrelationType**<br /><br /> 1. Tab to the specific row in the **Add Initializer** DataGrid.<br />2. To set focus to **CorrelationTypeComboBox**, press **Ctrl**+**Tab**.<br />3. Press Alt+Down to pop up the **ComboBox** and edit it.|
|**XPath Queries**|A key/value pair that contains the queries used to extract correlation data from incoming and outgoing messages. This list is only valid when using <xref:System.ServiceModel.Activities.QueryCorrelationInitializer> types.|

## To launch the Add Correlation Initializers dialog box

 The **Add Correlation Initializers** dialog box is used by the **Send**, **Receive**, **ReceiveAndSendReply**, and **SendAndReceiveReply** designers. Accessing them is similar in each case, and the case that involves the **Receive** designer is used here to illustrate the procedure.

 The **Receive** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are placed. Dropping the **Receive** activity designer creates a <xref:System.ServiceModel.Activities.Receive> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of Receive. Select the **Receive** activity designer and click the ellipsis button next to the (Collection) text for the **CorrelationInitializers** property in the property grid for the **Add Correlation Initializers** dialog box to appear.

## See also

- [Initialize Correlation Dialog Box](../workflow-designer/initialize-correlation-dialog-box.md)
