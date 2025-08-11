---
title: "Workflow Designer - Receive Activity Designer"
description: Learn about the Receive activity and how to use the Receive activity designer to create and configure a Receive activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "System.ServiceModel.Activities.Receive.UI"
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Receive Activity Designer

The **Receive** activity designer is used to create and configure a <xref:System.ServiceModel.Activities.Receive> activity. A <xref:System.ServiceModel.Activities.Receive> activity is an activity that receives a message that can be either a built-in type such as <xref:System.ServiceModel.Channels.Message>, <xref:System.IO.Stream> or <xref:System.Xml.Linq.XElement>, or an application-defined data contract, message contract, or XML class that can be serialized.

## The Receive Activity

The <xref:System.ServiceModel.Activities.Receive> activity can receive a single item or multiple items depending on the type of receive content used. A <xref:System.ServiceModel.Activities.SendReply> activity can be bound to a <xref:System.ServiceModel.Activities.Receive> activity that receives a message as part of a request/response message exchange pattern on the service.

### Using the Receive Activity Designer

Access the **Receive** activity designer in the **Messaging** category of the **Toolbox**. The **Receive** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed. This creates a <xref:System.ServiceModel.Activities.Receive> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of Receive. The <xref:System.Activities.Activity.DisplayName%2A> can be edited in the header of the **Receive** activity designer or in the **DisplayName** box of the property grid.

To create a <xref:System.ServiceModel.Activities.SendReply> activity and bind it to the selected <xref:System.ServiceModel.Activities.Receive> activity, right-click the **Receive** activity designer, click the **Create SendReply** item in the context menu and the **SendReplyToReceive** designer appears below the **Receive** designer. The <xref:System.ServiceModel.Activities.SendReply> activity is an activity that sends the reply message as part of a request/response message exchange pattern on the service. It can be configured with the **SendReplyToReceive** designer.

Alternatively, the **ReceiveAndSendReply** template designer in the **Messaging** category of the **Toolbox** can be used to create a pair of pre-configured <xref:System.ServiceModel.Activities.Receive> and <xref:System.ServiceModel.Activities.SendReply> activity. For more information about the use of the **ReceiveAndSendReply** and **SendReplyToReceive** template, see the [ReceiveAndSendReply](../workflow-designer/receiveandsendreply-template-designer.md) topic.

### The Receive Activity Properties

The following table shows the <xref:System.ServiceModel.Activities.Receive> properties and describes how they are used in the designer. These properties can be edited in properties grid or on the Workflow Designer surface. The only required property is the <xref:System.ServiceModel.Activities.Receive.OperationName%2A> property.

| Property Name | Required | Usage |
|-|----------|-|
| <xref:System.Activities.Activity.DisplayName%2A> | False | Specifies the friendly name of the <xref:System.ServiceModel.Activities.Receive> activity. The default value is Receive.<br /><br /> Although the use of a non-default value for the friendly <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it is a best practice to use such a value. |
| <xref:System.ServiceModel.Activities.Receive.OperationName%2A> | True | Specifies the name of the service operation implemented by this <xref:System.ServiceModel.Activities.Receive> activity. This property is used to construct the default value for the **Action** property if the **Action** property is not explicitly set. |
| <xref:System.ServiceModel.Activities.Receive.ServiceContractName%2A> | False | Specifies the name of the service contract. This property is used to group service operations into individual service contracts. All <xref:System.ServiceModel.Activities.Receive> activities that have the same <xref:System.ServiceModel.Activities.Receive.ServiceContractName%2A> are grouped into the same service contract (WSDL Port Type). The default value is the fully qualified CLR name of the top level (root) activity. |
| <xref:System.ServiceModel.Activities.Receive.Content%2A> | False | Specifies the message or parameter content to receive. It can be either a <xref:System.ServiceModel.Activities.ReceiveMessageContent> activity or a <xref:System.ServiceModel.Activities.ReceiveParametersContent> activity. Edit this property by selecting the ellipsis button beside the **Content** field in property grid or clicking the **Define...** button beside the **Content** label on the **Receive** activity designer surface. Both display the **Content Definition** dialog. For more information about how to use this box, see the [Content Definition Dialog Box](../workflow-designer/content-definition-dialog-box.md) topic. |
| <xref:System.ServiceModel.Activities.Receive.CorrelatesOn%2A> | False | Specifies the correlations between <xref:System.ServiceModel.Activities.Receive> activities in service operations of a workflow with a <xref:System.ServiceModel.MessageQuerySet> object. Click the ellipsis button next to the <xref:System.ServiceModel.Activities.Receive.CorrelatesOn%2A> property in the properties grid to open the **CorrelatesOn Definition** dialog box. For more information about the use of this dialog box, see the [Content Definition Dialog Box](../workflow-designer/content-definition-dialog-box.md) topic. |
| <xref:System.ServiceModel.Activities.Receive.CorrelatesWith%2A> | False | Specifies the <xref:System.ServiceModel.Activities.CorrelationHandle> used to route the message to the appropriate workflow instance.<br /><br /> Click the ellipsis button next to the <xref:System.ServiceModel.Activities.Receive.CorrelatesWith%2A> property in the properties grid to open the **Expression Editor** dialog box. For more information about the use of this dialog box, see the [How to: Use the Expression Editor](../workflow-designer/how-to-use-the-expression-editor.md) topic. |
| <xref:System.ServiceModel.Activities.Receive.CorrelationInitializers%2A> | False | Specifies the collection of <xref:System.ServiceModel.Activities.CorrelationInitializer> objects that initialize multiple <xref:System.ServiceModel.Activities.CorrelationHandle> objects that configure this <xref:System.ServiceModel.Activities.Receive> activity within the workflow. Click the ellipsis button next to the <xref:System.ServiceModel.Activities.Receive.CorrelationInitializers%2A> property in the properties grid to open the **Add Correlation Initializers** dialog box. For more information about using this box, see the [Add CorrelationInitializers Dialog Box](../workflow-designer/add-correlationinitializers-dialog-box.md) topic. |
| <xref:System.ServiceModel.Activities.Receive.CanCreateInstance%2A> | False | Specifies a value that determines whether a new workflow instance is created to process the message if the message does not correlate to an existing workflow instance. If the value is set to **true**, a new workflow instance is created to process the message when the message is not correlated with an existing workflow instance. |
| <xref:System.ServiceModel.Activities.Receive.KnownTypes%2A> | False | Specifies a collection of known types for the service operation implemented by this <xref:System.ServiceModel.Activities.Receive> activity. This property should be used in conjunction with the <xref:System.ServiceModel.Activities.Receive.SerializerOption%2A> property set to <xref:System.Runtime.Serialization.DataContractSerializer>. It is ignored if <xref:System.Xml.Serialization.XmlSerializer> is used.<br /><br /> Select the ellipsis button beside the **KnownTypes** field in property grid to display the **Type Collection Editor** dialog box with which you can add relevant types. For more information about using this box, see the [Type Collection Editor Dialog Box](../workflow-designer/type-collection-editor-dialog-box.md) topic. |
| <xref:System.ServiceModel.Activities.Receive.ProtectionLevel%2A> | False | Specifies the <xref:System.Net.Security.ProtectionLevel> for the message.<br /><br /> 1.  <xref:System.Net.Security.ProtectionLevel> means authentication only.<br />2.  <xref:System.Net.Security.ProtectionLevel> means sign data to help ensure the integrity of transmitted data.<br />3.  <xref:System.Net.Security.ProtectionLevel> means encrypt and sign data to help ensure the confidentiality and integrity of transmitted data. |
| <xref:System.ServiceModel.Activities.Receive.SerializerOption%2A> | False | Specifies the type of serializer to use for the service operation implemented by the <xref:System.ServiceModel.Activities.Receive> activity. The default value is <xref:System.Runtime.Serialization.DataContractSerializer>, which serializes and deserializes an instance of a type into an XML stream or document that uses a supplied data contract. The <xref:System.Xml.Serialization.XmlSerializer> can also be used if more control is required over the XML. |
| <xref:System.ServiceModel.Activities.Receive.Action%2A> | False | Specifies the action header of the message. If it is not explicitly set, its value defaults to: `https://tempuri.org/{service contract namespace}/{service contract name}/{operation name}`. |

## See also

- [InitializeCorrelation](../workflow-designer/initializecorrelation-activity-designer.md)
- [CorrelationScope](../workflow-designer/correlationscope-activity-designer.md)
- [ReceiveAndSendReply](../workflow-designer/receiveandsendreply-template-designer.md)
- [Send](../workflow-designer/send-activity-designer.md)
- [SendAndReceiveReply](../workflow-designer/sendandreceivereply-template-designer.md)
- [TransactedReceiveScope](../workflow-designer/transactedreceivescope-activity-designer.md)
