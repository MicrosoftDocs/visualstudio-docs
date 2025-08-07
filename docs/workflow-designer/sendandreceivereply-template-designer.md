---
title: SendAndReceiveReply Template Designer
description: Learn how you can use the SendAndReceiveReply template in Workflow Designer to create a pair of pre-configured Send and ReceiveReply activities.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "System.ServiceModel.Activities.SendAndReceiveReply.UI"
  - "System.ServiceModel.Activities.ReceiveReply.UI"
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# SendAndReceiveReply Template Designer

The **SendAndReceiveReply** template is used to create a pair of pre-configured <xref:System.ServiceModel.Activities.Send> and <xref:System.ServiceModel.Activities.ReceiveReply> activities. The activities are part of a <xref:System.Activities.Statements.Sequence> activity, and are correlated as part of a request/response message exchange pattern on the client.

## The SendAndReceiveReply template

Adding the **SendAndReceiveReply** template does three things besides creating the <xref:System.ServiceModel.Activities.Send> and <xref:System.ServiceModel.Activities.ReceiveReply> activities within a <xref:System.Activities.Statements.Sequence> activity:

- Configures the <xref:System.ServiceModel.Activities.Send.OperationName%2A> and <xref:System.ServiceModel.Activities.Send.ServiceContractName%2A> properties of the <xref:System.ServiceModel.Activities.Send> activity.

- Binds the <xref:System.ServiceModel.Activities.ReceiveReply.Request%2A> property of the <xref:System.ServiceModel.Activities.ReceiveReply> activity to the <xref:System.ServiceModel.Activities.Send> activity.

- Creates a <xref:System.ServiceModel.Activities.CorrelationHandle> as a variable in the parent activity.

### Use the SendAndReceiveReply Template Designer

Access the **SendAndReceiveReply** activity designer in the **Messaging** category of the **Toolbox**. The **SendAndReceiveReply** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed. Dropping the activity designer creates a <xref:System.ServiceModel.Activities.Send> activity that can be configured with the **Send** activity designer and a correlated <xref:System.ServiceModel.Activities.ReceiveReply> that can be configured with the **ReceiveReplyForSend** designer.

For more information about using the **Send** designer to configure the <xref:System.ServiceModel.Activities.Send> activity, see [Send](../workflow-designer/send-activity-designer.md).

### Properties of ReceiveReply

The following table shows the <xref:System.ServiceModel.Activities.ReceiveReply> properties and describes how they're used in the designer. These properties can be edited in properties grid, and some can be edited on the Workflow Designer surface.

| Property Name | Required | Usage |
|-|----------|-|
| <xref:System.Activities.Activity.DisplayName%2A> | False | The optional friendly name of the <xref:System.ServiceModel.Activities.ReceiveReply> activity. The default is ReceiveReplyForSend.<br /><br /> Although the use of a non-default value for the friendly <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it's best to use such a value. |
| <xref:System.ServiceModel.Activities.ReceiveReply.Request%2A> | True | Reference to the <xref:System.ServiceModel.Activities.Send> activity paired with this <xref:System.ServiceModel.Activities.ReceiveReply> activity. This property must not be **null**. <xref:System.ServiceModel.Activities.Send> and <xref:System.ServiceModel.Activities.ReceiveReply> activities are used together on the client to model a request/response messaging pattern. This property specifies which <xref:System.ServiceModel.Activities.Send> activity is paired. In the designer, you can't edit this property because it's automatically bound to the <xref:System.ServiceModel.Activities.Send> activity from which you created the <xref:System.ServiceModel.Activities.ReceiveReply> activity. |
| <xref:System.ServiceModel.Activities.ReceiveReply.Content%2A> | False | Specifies the message or parameter content to receive. It can be either a <xref:System.ServiceModel.Activities.ReceiveMessageContent> activity or a <xref:System.ServiceModel.Activities.ReceiveParametersContent> activity. Edit this property by clicking the ellipsis button next to the **Content** field in the property grid, or by clicking the **Define** button next to the **Content** label on the **Receive** activity designer surface. Both display the **Content Definition** dialog. For more information about how to use this box, see [Content Definition Dialog Box](../workflow-designer/content-definition-dialog-box.md). |
| <xref:System.ServiceModel.Activities.ReceiveReply.CorrelationInitializers%2A> | False | Specifies the collection of <xref:System.ServiceModel.Activities.CorrelationInitializer> objects that initialize multiple <xref:System.ServiceModel.Activities.CorrelationHandle> objects that configure this <xref:System.ServiceModel.Activities.Receive> activity within the workflow. Click the ellipsis button next to the <xref:System.ServiceModel.Activities.Receive.CorrelationInitializers%2A> property in the properties grid to open the **Add Correlation Initializers** dialog box. For more information about using this box, see [Add CorrelationInitializers Dialog Box](../workflow-designer/add-correlationinitializers-dialog-box.md). |
| <xref:System.ServiceModel.Activities.ReceiveReply.Action%2A> | False | Specifies the action header of the message. If it's not explicitly set, its value defaults to:<br /><br /> `https://tempuri.org/{service contract namespace}/{service contract name}/{operation name}`. |

## See also

- [CorrelationScope](../workflow-designer/correlationscope-activity-designer.md)
- [InitializeCorrelation](../workflow-designer/initializecorrelation-activity-designer.md)
- [Receive](../workflow-designer/receive-activity-designer.md)
- [ReceiveAndSendReply](../workflow-designer/receiveandsendreply-template-designer.md)
- [Send](../workflow-designer/send-activity-designer.md)
- [TransactedReceiveScope](../workflow-designer/transactedreceivescope-activity-designer.md)