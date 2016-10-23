---
title: "Messaging Activity Designers"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 897e63cf-a42f-4edd-876f-c4ccfffaf6d6
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
# Messaging Activity Designers
Messaging activity designers are used to create and configure messaging activities that send and receive Windows Communication Foundation (WCF) messages from within a Windows Workflow Foundation (WF) application. The .NET Framework version 4 introduces five messaging activities and the Windows Workflow Designer provides two new template designers that enable you to manage messaging within a workflow. The topics contained in this section and listed in the following table provide guidance on how to use the Workflow Designer activity and template designers.  
  
## In This Section  
  
|Message Activity|Description|  
|----------------------|-----------------|  
|[CorrelationScope](../WF_Design/CorrelationScope-Activity-Designer.md)|Creates and configures a <xref:System.ServiceModel.Activities.CorrelationScope?qualifyHint=False> activity that provides implicit management of child messaging activities with a <xref:System.ServiceModel.Activities.CorrelationHandle?qualifyHint=False> object.|  
|[InitializeCorrelation](../WF_Design/InitializeCorrelation-Activity-Designer.md)|Creates and configures an <xref:System.ServiceModel.Activities.InitializeCorrelation?qualifyHint=False> activity that is used to initialize correlation without sending or receiving a message.|  
|[Receive](../WF_Design/Receive-Activity-Designer.md)|Creates and configures a <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activity that receives a message from a service.|  
|[ReceiveAndSendReply](../WF_Design/ReceiveAndSendReply-Template-Designer.md)|Creates a pre-configured pair of <xref:System.ServiceModel.Activities.Send?qualifyHint=False> and <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> activities within a <xref:System.Activities.Statements.Sequence?qualifyHint=False> activity.|  
|[Send](../WF_Design/Send-Activity-Designer.md)|Creates and configures a <xref:System.ServiceModel.Activities.Send?qualifyHint=False> activity that sends a message to a service.|  
|[SendAndReceiveReply](../WF_Design/SendAndReceiveReply-Template-Designer.md)|Creates a pre-configured pair of <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> and <xref:System.ServiceModel.Activities.SendReply?qualifyHint=False> activities within a <xref:System.Activities.Statements.Sequence?qualifyHint=False> activity.|  
|[TransactedReceiveScope](../WF_Design/TransactedReceiveScope-Activity-Designer.md)|Creates and configures a <xref:System.ServiceModel.Activities.TransactedReceiveScope?qualifyHint=False> activity which enables the flow of transactions into a workflow.|  
  
## Reference  
 <xref:System.Activities.Activity?qualifyHint=False>  
  
 <xref:System.ServiceModel.Activities.CorrelationScope?qualifyHint=False>  
  
 <xref:System.ServiceModel.Activities.Receive?qualifyHint=False>  
  
 <xref:System.ServiceModel.Activities.Send?qualifyHint=False>  
  
 <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False>  
  
 <xref:System.ServiceModel.Activities.SendReply?qualifyHint=False>  
  
 <xref:System.ServiceModel.Activities.TransactedReceiveScope?qualifyHint=False>  
  
## Related Sections  
 For other types of activity designers, see the following topics.  
  
 [Control Flow](../WF_Design/Control-Flow-Activity-Designers.md)  
  
 [Using the Activity Designers](../WF_Design/Using-the-Activity-Designers.md)  
  
 [Flowchart](../WF_Design/Flowchart-Activity-Designers.md)  
  
 [Runtime](../WF_Design/Runtime-Activity-Designers.md)  
  
 [Primitives](../WF_Design/Primitives-Activity-Designers.md)  
  
 [Transaction](../WF_Design/Transaction-Activity-Designers.md)  
  
 [Collection](../WF_Design/Collection-Activity-Designers.md)  
  
 [Error Handling](../WF_Design/Error-Handling-Activity-Designers.md)  
  
## External Resources  
 [Using the Activity Designers](../WF_Design/Using-the-Activity-Designers.md)