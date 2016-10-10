---
title: "Send Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: b514f2e4-767c-4b94-ac61-dd3a54d4b96d
caps.latest.revision: 7
manager: erikre
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Send Activity Designer
The **Send** activity designer is used to create and configure a <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity.  
  
## The Send Activity  
 A <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity is used to send a message to a service. A <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> activity can be bound to a <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity that receives a message as part of a request/response message exchange pattern on the client.  
  
### Using the Send Activity Designer  
 The **Send** activity designer can be found in the **Messaging** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab in Workflow Designer (Alternatively, select **Toolbar** from the **View** menu or CTRL+ALT+X.)  
  
 The **Send** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed. This creates a <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity with a default <xref:System.Activities.Activity.DisplayName?qualifyHint=False> of Send. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> can be edited in the header of the **Send** activity designer or in the **DisplayName** box of the property grid.  
  
 To create a <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> activity and bind it to the selected <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity, right-click the **Send** activity designer, click the **Create ReceiveReply** item in the context menu and the **ReceiveReplyForSend** designer appears below the **Send** designer. The <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> activity is an activity that receives a message as part of a request/response message exchange pattern on the client. It can be configured with the **ReceiveReplyForSend** designer.  
  
 Alternatively, the **SendAndReceiveReply** template designer in the **Messaging** category of the **Toolbox** can be used to create a pair of pre-configured <xref:System.ServiceModel.Activities.Send?qualifyHint=False> and <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> activities. For more information about the use of the **SendAndReceiveReply** and **ReceiveReplyForSend** templates, see the [SendAndReceiveReply](../WF_Design/SendAndReceiveReply-Template-Designer.md) topic.  
  
### The Send Activity Properties  
 The following table shows the <xref:System.ServiceModel.Activities.Send?qualifyHint=False> properties and describes how they are used in the designer. These properties can be edited in properties grid or on Workflow Designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|The friendly name of the <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity. The default is Send. Although the <xref:System.Activities.Activity.DisplayName?qualifyHint=False> is not strictly required, it is a best practice to use one.|  
|<xref:System.ServiceModel.Activities.Send.OperationName?qualifyHint=False>|True|The name of the service operation called by this <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity. This property is used to construct the default value for the **Action** property if the **Action** property is not explicitly set.|  
|<xref:System.ServiceModel.Activities.Send.ServiceContractName?qualifyHint=False>|True|The name of the service contract that the service to be called implements.|  
|<xref:System.ServiceModel.Activities.Send.Content?qualifyHint=False>|False|Specifies the message or parameter content to receive. It can be either a <xref:System.ServiceModel.Activities.ReceiveMessageContent?qualifyHint=False> activity or a <xref:System.ServiceModel.Activities.ReceiveParametersContent?qualifyHint=False> activity. Edit this property by clicking the ellipse button beside the **Content** field in property grid or clicking the **Define…** button beside the **Content** label on the **Receive** activity designer surface. Both display the **Content Definition** dialog. For more information about how to use this box, see the [Content Definition Dialog Box](../WF_Design/Content-Definition-Dialog-Box.md) topic.|  
|<xref:System.ServiceModel.Activities.Send.CorrelatesWith?qualifyHint=False>|False|Specifies the <xref:System.ServiceModel.Activities.CorrelationHandle?qualifyHint=False> used to route the message to the appropriate workflow instance.<br /><br /> Click the ellipsis button next to the <xref:System.ServiceModel.Activities.Send.CorrelatesWith?qualifyHint=False> property in the properties grid to open the **Expression Editor** dialog box. For more information about the use of this dialog box, see the [How to: Use the Expression Editor](../WF_Design/How-to--Use-the-Expression-Editor.md) topic.|  
|<xref:System.ServiceModel.Activities.Send.CorrelationInitializers?qualifyHint=False>|False|Specifies the collection of <xref:System.ServiceModel.Activities.CorrelationInitializer?qualifyHint=False> objects that initialize multiple <xref:System.ServiceModel.Activities.CorrelationHandle?qualifyHint=False> objects that configure this <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity within the workflow. Click the ellipsis button next to the <xref:System.ServiceModel.Activities.Send.CorrelationInitializers?qualifyHint=False> property in the properties grid to open the **Add Correlation Initializers** dialog box. For more information about using this box, see the [Add CorrelationInitializers Dialog Box](../WF_Design/Add-CorrelationInitializers-Dialog-Box.md) topic.|  
|<xref:System.ServiceModel.Activities.Send.KnownTypes?qualifyHint=False>|False|A collection of known types for the service operation to be called by this <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity. This property should be used in conjunction with <xref:System.ServiceModel.Activities.Receive.SerializerOption?qualifyHint=False> property set to <xref:System.Runtime.Serialization.DataContractSerializer?qualifyHint=False>. It is ignored if <xref:System.Xml.Serialization.XmlSerializer?qualifyHint=False> is used.<br /><br /> Click the ellipse button beside the **KnownTypes** field in property grid to display the **Type Collection Editor** dialog with which you can add relevant types.<br /><br /> Click the ellipse button beside the **KnownTypes** field in property grid to display the **Type Collection Editor** dialog box with which you can add relevant types. For more information about using this box, see the [Type Collection Editor Dialog Box](../WF_Design/Type-Collection-Editor-Dialog-Box.md) topic.|  
|<xref:System.ServiceModel.Activities.Send.ProtectionLevel?qualifyHint=False>|True|Specifies the <xref:System.Net.Security.ProtectionLevel?qualifyHint=False> for the message.<br /><br /> 1.  <xref:System.Net.Security.ProtectionLevel?qualifyHint=False> means authentication only.<br />2.  <xref:System.Net.Security.ProtectionLevel?qualifyHint=False> means sign data to help ensure the integrity of transmitted data.<br />3.  <xref:System.Net.Security.ProtectionLevel?qualifyHint=False> means encrypt and sign data to help ensure the confidentiality and integrity of transmitted data.|  
|<xref:System.ServiceModel.Activities.Send.SerializerOption?qualifyHint=False>|True|The serializer to use for the service operation to be called by the <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity. The default value is <xref:System.Runtime.Serialization.DataContractSerializer?qualifyHint=False>, which serializes and deserializes an instance of a type into an XML stream or document using a supplied data contract.|  
|<xref:System.ServiceModel.Activities.Send.Action?qualifyHint=False>|False|Specifies the action header of the message. If it is not explicitly set, its value defaults to: https://tempuri.org/{service contract namespace}/{service contract name}/{operation name}. If specified on a <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity, the <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activity that receives the message must have the same value for the message to be delivered correctly.|  
|<xref:System.ServiceModel.Activities.Send.TokenImpersonationLevel?qualifyHint=False>||The <xref:System.Security.Principal.TokenImpersonationLevel?qualifyHint=False> allowed for the receiver of the message. It defines security impersonation levels which govern the degree to which a server process can act on behalf of a client process.<xref:System.Security.Principal.TokenImpersonationLevel?qualifyHint=False> indicates that an impersonation level is not assigned. <xref:System.Security.Principal.TokenImpersonationLevel?qualifyHint=False> indicates that the server process cannot obtain identification information about the client and it cannot impersonate the client. <xref:System.Security.Principal.TokenImpersonationLevel?qualifyHint=False> indicates that the server process can obtain information about the client, such as security identifiers and privileges, but that it cannot impersonate the client. This is useful for servers that export their own objects, for example, database products that export tables and views. Using the retrieved client-security information, the server can make access-validation decisions without being able to use other services that are using the client's security context. <xref:System.Security.Principal.TokenImpersonationLevel?qualifyHint=False> indicates that the server process can impersonate the client's security context on its local system. The server cannot impersonate the client on remote systems. <xref:System.Security.Principal.TokenImpersonationLevel?qualifyHint=False> indicates that the server process can impersonate the client's security context on remote systems.|  
|<xref:System.ServiceModel.Activities.Send.Endpoint?qualifyHint=False>||The <xref:System.ServiceModel.Endpoint?qualifyHint=False> that the <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity sends the message to. If this property is set the <xref:System.ServiceModel.Activities.Send.EndpointConfigurationName?qualifyHint=False> property should be **null**.|  
|<xref:System.ServiceModel.Activities.Send.EndpointAddress?qualifyHint=False>||The <xref:System.ServiceModel.EndpointAddress?qualifyHint=False> to which the message is sent.|  
|<xref:System.ServiceModel.Activities.Send.EndpointConfigurationName?qualifyHint=False>||The name of the endpoint configuration. This property is set when you are configuring an endpoint in a configuration file. This property should be set to the name given in the **<endpoint\>** element in your configuration file. If this property is set, the <xref:System.ServiceModel.Activities.Send.Endpoint?qualifyHint=False> property should be **null**.|  
  
## See Also  
 [InitializeCorrelation](../WF_Design/InitializeCorrelation-Activity-Designer.md)   
 [CorrelationScope](../WF_Design/CorrelationScope-Activity-Designer.md)   
 [ReceiveAndSendReply](../WF_Design/ReceiveAndSendReply-Template-Designer.md)   
 [Receive](../WF_Design/Receive-Activity-Designer.md)   
 [SendAndReceiveReply](../WF_Design/SendAndReceiveReply-Template-Designer.md)   
 [TransactedReceiveScope](../WF_Design/TransactedReceiveScope-Activity-Designer.md)