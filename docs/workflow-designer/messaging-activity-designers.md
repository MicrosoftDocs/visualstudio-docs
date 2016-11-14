---
title: "Messaging Activity Designers | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 897e63cf-a42f-4edd-876f-c4ccfffaf6d6
caps.latest.revision: 7
author: "ErikRe"
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
# Messaging Activity Designers
Messaging activity designers are used to create and configure messaging activities that send and receive [!INCLUDE[indigo1](../workflow-designer/includes/indigo1_md.md)] messages from within a [!INCLUDE[wf](../workflow-designer/includes/wf_md.md)] application. The [!INCLUDE[netfx40_long](../workflow-designer/includes/netfx40_long_md.md)] introduces five messaging activities and the [!INCLUDE[wfd1](../workflow-designer/includes/wfd1_md.md)] provides two new template designers that enable you to manage messaging within a workflow. The topics contained in this section and listed in the following table provide guidance on how to use the [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] activity and template designers.  
  
## In This Section  
  
|Message Activity|Description|  
|----------------------|-----------------|  
|[CorrelationScope](../workflow-designer/correlationscope-activity-designer.md)|Creates and configures a <xref:System.ServiceModel.Activities.CorrelationScope> activity that provides implicit management of child messaging activities with a <xref:System.ServiceModel.Activities.CorrelationHandle> object.|  
|[InitializeCorrelation](../workflow-designer/initializecorrelation-activity-designer.md)|Creates and configures an <xref:System.ServiceModel.Activities.InitializeCorrelation> activity that is used to initialize correlation without sending or receiving a message.|  
|[Receive](../workflow-designer/receive-activity-designer.md)|Creates and configures a <xref:System.ServiceModel.Activities.Receive> activity that receives a message from a service.|  
|[ReceiveAndSendReply](../workflow-designer/receiveandsendreply-template-designer.md)|Creates a pre-configured pair of <xref:System.ServiceModel.Activities.Send> and <xref:System.ServiceModel.Activities.ReceiveReply> activities within a <xref:System.Activities.Statements.Sequence> activity.|  
|[Send](../workflow-designer/send-activity-designer.md)|Creates and configures a <xref:System.ServiceModel.Activities.Send> activity that sends a message to a service.|  
|[SendAndReceiveReply](../workflow-designer/sendandreceivereply-template-designer.md)|Creates a pre-configured pair of <xref:System.ServiceModel.Activities.Receive> and <xref:System.ServiceModel.Activities.SendReply> activities within a <xref:System.Activities.Statements.Sequence> activity.|  
|[TransactedReceiveScope](../workflow-designer/transactedreceivescope-activity-designer.md)|Creates and configures a <xref:System.ServiceModel.Activities.TransactedReceiveScope> activity which enables the flow of transactions into a workflow.|  
  
## Reference  
 <xref:System.Activities.Activity>  
  
 <xref:System.ServiceModel.Activities.CorrelationScope>  
  
 <xref:System.ServiceModel.Activities.Receive>  
  
 <xref:System.ServiceModel.Activities.Send>  
  
 <xref:System.ServiceModel.Activities.ReceiveReply>  
  
 <xref:System.ServiceModel.Activities.SendReply>  
  
 <xref:System.ServiceModel.Activities.TransactedReceiveScope>  
  
## Related Sections  
 For other types of activity designers, see the following topics.  
  
 [Control Flow](../workflow-designer/control-flow-activity-designers.md)  
  
 [Using the Activity Designers](../workflow-designer/using-the-activity-designers.md)  
  
 [Flowchart](../workflow-designer/flowchart-activity-designers.md)  
  
 [Runtime](../workflow-designer/runtime-activity-designers.md)  
  
 [Primitives](../workflow-designer/primitives-activity-designers.md)  
  
 [Transaction](../workflow-designer/transaction-activity-designers.md)  
  
 [Collection](../workflow-designer/collection-activity-designers.md)  
  
 [Error Handling](../workflow-designer/error-handling-activity-designers.md)  
  
## External Resources  
 [Using the Activity Designers](../workflow-designer/using-the-activity-designers.md)