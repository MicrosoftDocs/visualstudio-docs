---
title: "SendAndReceiveReply Template Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.ServiceModel.Activities.SendAndReceiveReply.UI"
  - "System.ServiceModel.Activities.ReceiveReply.UI"
ms.assetid: 818a8c84-6593-416d-b016-1d91b85ffb68
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# SendAndReceiveReply Template Designer
The **SendAndReceiveReply** template is used to create a pair of pre-configured <xref:System.ServiceModel.Activities.Send> and <xref:System.ServiceModel.Activities.ReceiveReply> activities within a <xref:System.Activities.Statements.Sequence> activity that are correlated as part of a request/response message exchange pattern on the client.

## The SendAndReceiveReply Template
 Adding **SendAndReceiveReply** template does three things besides creating the <xref:System.ServiceModel.Activities.Send> and <xref:System.ServiceModel.Activities.ReceiveReply> activities within a <xref:System.Activities.Statements.Sequence> activity:

1. Configures the <xref:System.ServiceModel.Activities.Send.OperationName%2A>, <xref:System.ServiceModel.Activities.Send.ServiceContractName%2A> properties of the <xref:System.ServiceModel.Activities.Send> activity.

2. Binds the <xref:System.ServiceModel.Activities.ReceiveReply.Request%2A> property of the <xref:System.ServiceModel.Activities.ReceiveReply> activity to the <xref:System.ServiceModel.Activities.Send> activity.

3. Creates a <xref:System.ServiceModel.Activities.CorrelationHandle> as a variable in the parent activity.

### Using the SendAndReceiveReply Template Designer
 The **SendAndReceiveReply** activity designer can be found in the **Messaging** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on [!INCLUDE[wfd2](../includes/wfd2-md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)

 The **SendAndReceiveReply** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface wherever activities are usually placed. This creates a <xref:System.ServiceModel.Activities.Send> activity that can be configured with the **Send** activity designer and a correlated <xref:System.ServiceModel.Activities.ReceiveReply> that can be configured with the **ReceiveReplyForSend** designer.

 [!INCLUDE[crabout](../includes/crabout-md.md)] using the **Send** designer to configure the <xref:System.ServiceModel.Activities.Send> activity, see the [Send](../workflow-designer/send-activity-designer.md) topic.

 [!INCLUDE[crabout](../includes/crabout-md.md)] using the **ReceiveReplyForSend** designer to configure the <xref:System.ServiceModel.Activities.ReceiveReply> activity, see the following section.

### Properties of ReceiveReply
 The following table shows the <xref:System.ServiceModel.Activities.ReceiveReply> properties and describes how they are used in the designer. These properties can be edited in properties grid and some can be edited on [!INCLUDE[wfd2](../includes/wfd2-md.md)]designer surface.

|                                 Property Name                                 | Required |                                                                                                                                                                                                                                                                                                                                                        Usage                                                                                                                                                                                                                                                                                                                                                        |
|-------------------------------------------------------------------------------|----------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|               <xref:System.Activities.Activity.DisplayName%2A>                |  False   |                                                                                                                                                                                            The optional friendly name of the <xref:System.ServiceModel.Activities.ReceiveReply> activity. The default is ReceiveReplyForSend.<br /><br /> Although the use of a non-default value for the friendly <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it is a best practice to use such a value.                                                                                                                                                                                            |
|         <xref:System.ServiceModel.Activities.ReceiveReply.Request%2A>         |   True   | Reference to the <xref:System.ServiceModel.Activities.Send> activity paired with this <xref:System.ServiceModel.Activities.ReceiveReply> activity. This property must not be **null**. <xref:System.ServiceModel.Activities.Send> and <xref:System.ServiceModel.Activities.ReceiveReply> activities are used together on the client to model a request/response messaging pattern. This property specifies which <xref:System.ServiceModel.Activities.Send> activity is paired. In the designer, you cannot edit this property because it is automatically bound to the <xref:System.ServiceModel.Activities.Send> activity from which you created the <xref:System.ServiceModel.Activities.ReceiveReply> activity. |
|         <xref:System.ServiceModel.Activities.ReceiveReply.Content%2A>         |  False   |                        Specifies the message or parameter content to receive. It can be either a <xref:System.ServiceModel.Activities.ReceiveMessageContent> activity or a <xref:System.ServiceModel.Activities.ReceiveParametersContent> activity. Edit this property by clicking the ellipse button beside the **Content** field in property grid or clicking the **Define…** button beside the **Content** label on the **Receive** activity designer surface. Both display the **Content Definition** dialog. [!INCLUDE[crabout](../includes/crabout-md.md)] how to use this box, see the [Content Definition Dialog Box](../workflow-designer/content-definition-dialog-box.md) topic.                         |
| <xref:System.ServiceModel.Activities.ReceiveReply.CorrelationInitializers%2A> |  False   |              Specifies the collection of <xref:System.ServiceModel.Activities.CorrelationInitializer> objects that initialize multiple <xref:System.ServiceModel.Activities.CorrelationHandle> objects that configure this <xref:System.ServiceModel.Activities.Receive> activity within the workflow. Click the ellipsis button next to the <xref:System.ServiceModel.Activities.Receive.CorrelationInitializers%2A> property in the properties grid to open the **Add Correlation Initializers** dialog box. [!INCLUDE[crabout](../includes/crabout-md.md)] using this box, see the [Add CorrelationInitializers Dialog Box](../workflow-designer/add-correlationinitializers-dialog-box.md) topic.               |
|         <xref:System.ServiceModel.Activities.ReceiveReply.Action%2A>          |  False   |                                                                                                                                                                                                                                               Specifies the action header of the message. If it is not explicitly set, its value defaults to:<br /><br /> <strong>https://tempuri.org/{service contract namespace}/{service contract name}/{operation name}.</strong>                                                                                                                                                                                                                                               |

## See Also
 [CorrelationScope](../workflow-designer/correlationscope-activity-designer.md)
 [InitializeCorrelation](../workflow-designer/initializecorrelation-activity-designer.md)
 [Receive](../workflow-designer/receive-activity-designer.md)
 [ReceiveAndSendReply](../workflow-designer/receiveandsendreply-template-designer.md)
 [Send](../workflow-designer/send-activity-designer.md)
 [TransactedReceiveScope](../workflow-designer/transactedreceivescope-activity-designer.md)