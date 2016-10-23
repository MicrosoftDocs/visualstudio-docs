---
title: "ReceiveAndSendReply Template Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: d1d9a058-df7e-48f5-a2e7-3caeeba7eaa6
caps.latest.revision: 5
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
# ReceiveAndSendReply Template Designer
The **ReceiveAndSendReply** template is used to create a pair of pre-configured <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> and <xref:System.ServiceModel.Activities.SendReply?qualifyHint=False> activities within a <xref:System.Activities.Statements.Sequence?qualifyHint=False> activity that are correlated as part of a request/response message exchange pattern on the server.  
  
## The ReceiveAndSendReply Template  
 Adding **ReceiveAndSendReply** template does three things besides creating the <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> and <xref:System.ServiceModel.Activities.SendReply?qualifyHint=False> activities with a <xref:System.Activities.Statements.Sequence?qualifyHint=False> activity:  
  
1.  Configures the <xref:System.ServiceModel.Activities.Receive.OperationName?qualifyHint=False>, <xref:System.ServiceModel.Activities.Receive.ServiceContractName?qualifyHint=False> properties of the <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activity.  
  
2.  Binds the <xref:System.ServiceModel.Activities.SendReply.Request?qualifyHint=False> property of the <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activity to the <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity.  
  
3.  Creates a <xref:System.ServiceModel.Activities.CorrelationHandle?qualifyHint=False> as a variable in the parent activity.  
  
### Using the ReceiveAndSendReply Template Designer  
 The **ReceiveAndSendReply** activity designer can be found in the **Messaging** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab in Workflow Designer (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **ReceiveAndSendReply** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed. This creates a <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activity that can be configured with the **Send** activity designer and a correlated <xref:System.ServiceModel.Activities.SendReply?qualifyHint=False> that can be configured with the SendReplyToReceive designer.  
  
 For more information about using the **Receive** designer to configure the <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activity, see the [Receive](../WF_Design/Receive-Activity-Designer.md) topic.  
  
 For more information about using the **SendReplyToReceive** designer to configure the <xref:System.ServiceModel.Activities.SendReply?qualifyHint=False> activity, see the following section.  
  
### Properties of SendReply  
 The following table shows the <xref:System.ServiceModel.Activities.SendReply?qualifyHint=False> properties and describes how they are used in the designer. These properties can be edited in properties grid and some can be edited on Workflow Designer designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|The optional friendly name of the <xref:System.ServiceModel.Activities.SendReply?qualifyHint=False> activity. The default is SendReplyToReceive.<br /><br /> Although the use of a non-default value for the friendly <xref:System.Activities.Activity.DisplayName?qualifyHint=False> is not strictly required, it is a best practice to use such a value.|  
|<xref:System.ServiceModel.Activities.SendReply.Request?qualifyHint=False>|True|Reference to the <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activity paired with this <xref:System.ServiceModel.Activities.SendReply?qualifyHint=False> activity. This property must not be **null**. <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> and <xref:System.ServiceModel.Activities.SendReply?qualifyHint=False> activities are used together on the server to model a request/response messaging pattern. This property specifies which <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity is paired. In the designer, you cannot edit this property because it is automatically bound to the <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity from which you created the <xref:System.ServiceModel.Activities.SendReply?qualifyHint=False> activity.|  
|<xref:System.ServiceModel.Activities.SendReply.Content?qualifyHint=False>|False|Specifies the message or parameter content to receive. It can be either a <xref:System.ServiceModel.Activities.ReceiveMessageContent?qualifyHint=False> activity or a <xref:System.ServiceModel.Activities.ReceiveParametersContent?qualifyHint=False> activity. Edit this property by clicking the ellipse button beside the **Content** field in property grid or clicking the **Define…** button beside the **Content** label on the **Receive** activity designer surface. Both display the **Content Definition** dialog. For more information about how to use this box, see the [Content Definition Dialog Box](../WF_Design/Content-Definition-Dialog-Box.md) topic.|  
|<xref:System.ServiceModel.Activities.SendReply.CorrelationInitializers?qualifyHint=False>|False|Specifies the collection of <xref:System.ServiceModel.Activities.CorrelationInitializer?qualifyHint=False> objects that initialize multiple <xref:System.ServiceModel.Activities.CorrelationHandle?qualifyHint=False> objects that configure this <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activity within the workflow. Click the ellipsis button next to the <xref:System.ServiceModel.Activities.SendReply.CorrelationInitializers?qualifyHint=False> property in the properties grid to open the **Add Correlation Initializers** dialog box. For more information about using this box, see the [Add CorrelationInitializers Dialog Box](../WF_Design/Add-CorrelationInitializers-Dialog-Box.md) topic.|  
|<xref:System.ServiceModel.Activities.SendReply.Action?qualifyHint=False>|False|Specifies the action header of the message. If it is not explicitly set, its value defaults to:<br /><br /> **https://tempuri.org/{service contract namespace}/{service contract name}/{operation name}**|  
|<xref:System.ServiceModel.Activities.SendReply.PersistBeforeSend?qualifyHint=False>|False|Specifies whether the workflow instance should be persisted before the reply message is sent. The default value is **false**.|  
  
## See Also  
 [CorrelationScope](../WF_Design/CorrelationScope-Activity-Designer.md)   
 [InitializeCorrelation](../WF_Design/InitializeCorrelation-Activity-Designer.md)   
 [Receive](../WF_Design/Receive-Activity-Designer.md)   
 [Send](../WF_Design/Send-Activity-Designer.md)   
 [SendAndReceiveReply](../WF_Design/SendAndReceiveReply-Template-Designer.md)   
 [TransactedReceiveScope](../WF_Design/TransactedReceiveScope-Activity-Designer.md)