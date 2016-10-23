---
title: "SendAndReceiveReply Template Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 818a8c84-6593-416d-b016-1d91b85ffb68
caps.latest.revision: 6
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
# SendAndReceiveReply Template Designer
The **SendAndReceiveReply** template is used to create a pair of pre-configured <xref:System.ServiceModel.Activities.Send?qualifyHint=False> and <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> activities within a <xref:System.Activities.Statements.Sequence?qualifyHint=False> activity that are correlated as part of a request/response message exchange pattern on the client.  
  
## The SendAndReceiveReply Template  
 Adding **SendAndReceiveReply** template does three things besides creating the <xref:System.ServiceModel.Activities.Send?qualifyHint=False> and <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> activities within a <xref:System.Activities.Statements.Sequence?qualifyHint=False> activity:  
  
1.  Configures the <xref:System.ServiceModel.Activities.Send.OperationName?qualifyHint=False>, <xref:System.ServiceModel.Activities.Send.ServiceContractName?qualifyHint=False> properties of the <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity.  
  
2.  Binds the <xref:System.ServiceModel.Activities.ReceiveReply.Request?qualifyHint=False> property of the <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> activity to the <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity.  
  
3.  Creates a <xref:System.ServiceModel.Activities.CorrelationHandle?qualifyHint=False> as a variable in the parent activity.  
  
### Using the SendAndReceiveReply Template Designer  
 The **SendAndReceiveReply** activity designer can be found in the **Messaging** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on Workflow Designer (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **SendAndReceiveReply** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed. This creates a <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity that can be configured with the **Send** activity designer and a correlated <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> that can be configured with the **ReceiveReplyForSend** designer.  
  
 For more information about using the **Send** designer to configure the <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity, see the [Send](../WF_Design/Send-Activity-Designer.md) topic.  
  
 For more information about using the **ReceiveReplyForSend** designer to configure the <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> activity, see the following section.  
  
### Properties of ReceiveReply  
 The following table shows the <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> properties and describes how they are used in the designer. These properties can be edited in properties grid and some can be edited on Workflow Designerdesigner surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|The optional friendly name of the <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> activity. The default is ReceiveReplyForSend.<br /><br /> Although the use of a non-default value for the friendly <xref:System.Activities.Activity.DisplayName?qualifyHint=False> is not strictly required, it is a best practice to use such a value.|  
|<xref:System.ServiceModel.Activities.ReceiveReply.Request?qualifyHint=False>|True|Reference to the <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity paired with this <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> activity. This property must not be **null**. <xref:System.ServiceModel.Activities.Send?qualifyHint=False> and <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> activities are used together on the client to model a request/response messaging pattern. This property specifies which <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity is paired. In the designer, you cannot edit this property because it is automatically bound to the <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity from which you created the <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> activity.|  
|<xref:System.ServiceModel.Activities.ReceiveReply.Content?qualifyHint=False>|False|Specifies the message or parameter content to receive. It can be either a <xref:System.ServiceModel.Activities.ReceiveMessageContent?qualifyHint=False> activity or a <xref:System.ServiceModel.Activities.ReceiveParametersContent?qualifyHint=False> activity. Edit this property by clicking the ellipse button beside the **Content** field in property grid or clicking the **Define…** button beside the **Content** label on the **Receive** activity designer surface. Both display the **Content Definition** dialog. For more information about how to use this box, see the [Content Definition Dialog Box](../WF_Design/Content-Definition-Dialog-Box.md) topic.|  
|<xref:System.ServiceModel.Activities.ReceiveReply.CorrelationInitializers?qualifyHint=False>|False|Specifies the collection of <xref:System.ServiceModel.Activities.CorrelationInitializer?qualifyHint=False> objects that initialize multiple <xref:System.ServiceModel.Activities.CorrelationHandle?qualifyHint=False> objects that configure this <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activity within the workflow. Click the ellipsis button next to the <xref:System.ServiceModel.Activities.Receive.CorrelationInitializers?qualifyHint=False> property in the properties grid to open the **Add Correlation Initializers** dialog box. For more information about using this box, see the [Add CorrelationInitializers Dialog Box](../WF_Design/Add-CorrelationInitializers-Dialog-Box.md) topic.|  
|<xref:System.ServiceModel.Activities.ReceiveReply.Action?qualifyHint=False>|False|Specifies the action header of the message. If it is not explicitly set, its value defaults to:<br /><br /> **https://tempuri.org/{service contract namespace}/{service contract name}/{operation name}.**|  
  
## See Also  
 [CorrelationScope](../WF_Design/CorrelationScope-Activity-Designer.md)   
 [InitializeCorrelation](../WF_Design/InitializeCorrelation-Activity-Designer.md)   
 [Receive](../WF_Design/Receive-Activity-Designer.md)   
 [ReceiveAndSendReply](../WF_Design/ReceiveAndSendReply-Template-Designer.md)   
 [Send](../WF_Design/Send-Activity-Designer.md)   
 [TransactedReceiveScope](../WF_Design/TransactedReceiveScope-Activity-Designer.md)