---
title: "ReceiveAndSendReply Template Designer"
ms.custom: na
ms.date: "10/02/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "System.ServiceModel.Activities.ReceiveAndSendReply.UI"
  - "System.ServiceModel.Activities.SendReply.UI"
ms.assetid: d1d9a058-df7e-48f5-a2e7-3caeeba7eaa6
caps.latest.revision: 5
ms.author: "erikre"
manager: "erikre"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# ReceiveAndSendReply Template Designer
The **ReceiveAndSendReply** template is used to create a pair of pre-configured \<xref:System.ServiceModel.Activities.Receive> and \<xref:System.ServiceModel.Activities.SendReply> activities within a \<xref:System.Activities.Statements.Sequence> activity that are correlated as part of a request/response message exchange pattern on the server.  
  
## The ReceiveAndSendReply Template  
 Adding **ReceiveAndSendReply** template does three things besides creating the \<xref:System.ServiceModel.Activities.Receive> and \<xref:System.ServiceModel.Activities.SendReply> activities with a \<xref:System.Activities.Statements.Sequence> activity:  
  
1.  Configures the \<xref:System.ServiceModel.Activities.Receive.OperationName*>, \<xref:System.ServiceModel.Activities.Receive.ServiceContractName*> properties of the \<xref:System.ServiceModel.Activities.Receive> activity.  
  
2.  Binds the \<xref:System.ServiceModel.Activities.SendReply.Request*> property of the \<xref:System.ServiceModel.Activities.Receive> activity to the \<xref:System.ServiceModel.Activities.Send> activity.  
  
3.  Creates a \<xref:System.ServiceModel.Activities.CorrelationHandle> as a variable in the parent activity.  
  
### Using the ReceiveAndSendReply Template Designer  
 The **ReceiveAndSendReply** activity designer can be found in the **Messaging** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab in [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **ReceiveAndSendReply** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] surface wherever activities are usually placed. This creates a \<xref:System.ServiceModel.Activities.Receive> activity that can be configured with the **Send** activity designer and a correlated \<xref:System.ServiceModel.Activities.SendReply> that can be configured with the SendReplyToReceive designer.  
  
 [!INCLUDE[crabout](../codequality/includes/crabout_md.md)] using the **Receive** designer to configure the \<xref:System.ServiceModel.Activities.Receive> activity, see the [Receive](../workflowdesigner/receive-activity-designer.md) topic.  
  
 [!INCLUDE[crabout](../codequality/includes/crabout_md.md)] using the **SendReplyToReceive** designer to configure the \<xref:System.ServiceModel.Activities.SendReply> activity, see the following section.  
  
### Properties of SendReply  
 The following table shows the \<xref:System.ServiceModel.Activities.SendReply> properties and describes how they are used in the designer. These properties can be edited in properties grid and some can be edited on [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|\<xref:System.Activities.Activity.DisplayName*>|False|The optional friendly name of the \<xref:System.ServiceModel.Activities.SendReply> activity. The default is SendReplyToReceive.<br /><br /> Although the use of a non-default value for the friendly \<xref:System.Activities.Activity.DisplayName*> is not strictly required, it is a best practice to use such a value.|  
|\<xref:System.ServiceModel.Activities.SendReply.Request*>|True|Reference to the \<xref:System.ServiceModel.Activities.Receive> activity paired with this \<xref:System.ServiceModel.Activities.SendReply> activity. This property must not be **null**. \<xref:System.ServiceModel.Activities.Receive> and \<xref:System.ServiceModel.Activities.SendReply> activities are used together on the server to model a request/response messaging pattern. This property specifies which \<xref:System.ServiceModel.Activities.Send> activity is paired. In the designer, you cannot edit this property because it is automatically bound to the \<xref:System.ServiceModel.Activities.Send> activity from which you created the \<xref:System.ServiceModel.Activities.SendReply> activity.|  
|\<xref:System.ServiceModel.Activities.SendReply.Content*>|False|Specifies the message or parameter content to receive. It can be either a \<xref:System.ServiceModel.Activities.ReceiveMessageContent> activity or a \<xref:System.ServiceModel.Activities.ReceiveParametersContent> activity. Edit this property by clicking the ellipse button beside the **Content** field in property grid or clicking the **Define…** button beside the **Content** label on the **Receive** activity designer surface. Both display the **Content Definition** dialog. [!INCLUDE[crabout](../codequality/includes/crabout_md.md)] how to use this box, see the [Content Definition Dialog Box](../workflowdesigner/content-definition-dialog-box.md) topic.|  
|\<xref:System.ServiceModel.Activities.SendReply.CorrelationInitializers*>|False|Specifies the collection of \<xref:System.ServiceModel.Activities.CorrelationInitializer> objects that initialize multiple \<xref:System.ServiceModel.Activities.CorrelationHandle> objects that configure this \<xref:System.ServiceModel.Activities.Receive> activity within the workflow. Click the ellipsis button next to the \<xref:System.ServiceModel.Activities.SendReply.CorrelationInitializers*> property in the properties grid to open the **Add Correlation Initializers** dialog box. [!INCLUDE[crabout](../codequality/includes/crabout_md.md)] using this box, see the [Add CorrelationInitializers Dialog Box](../workflowdesigner/add-correlationinitializers-dialog-box.md) topic.|  
|\<xref:System.ServiceModel.Activities.SendReply.Action*>|False|Specifies the action header of the message. If it is not explicitly set, its value defaults to:<br /><br /> **https://tempuri.org/{service contract namespace}/{service contract name}/{operation name}**|  
|\<xref:System.ServiceModel.Activities.SendReply.PersistBeforeSend*>|False|Specifies whether the workflow instance should be persisted before the reply message is sent. The default value is **false**.|  
  
## See Also  
 [CorrelationScope](../workflowdesigner/correlationscope-activity-designer.md)   
 [InitializeCorrelation](../workflowdesigner/initializecorrelation-activity-designer.md)   
 [Receive](../workflowdesigner/receive-activity-designer.md)   
 [Send](../workflowdesigner/send-activity-designer.md)   
 [SendAndReceiveReply](../workflowdesigner/sendandreceivereply-template-designer.md)   
 [TransactedReceiveScope](../workflowdesigner/transactedreceivescope-activity-designer.md)