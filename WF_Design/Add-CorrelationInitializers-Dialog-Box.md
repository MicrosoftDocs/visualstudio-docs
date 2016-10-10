---
title: "Add CorrelationInitializers Dialog Box"
ms.custom: na
ms.date: 10/04/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: c0517467-d54a-4ee6-aef0-c19b96b6f395
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
# Add CorrelationInitializers Dialog Box
The **Add Correlation Initializers** dialog box is used in Windows Workflow Designer to configure the **CorrelationInitializers** properties of the <xref:System.ServiceModel.Activities.Send?qualifyHint=False>, <xref:System.ServiceModel.Activities.Receive?qualifyHint=False>, <xref:System.ServiceModel.Activities.SendReply?qualifyHint=False>, and <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> activities. For more information about the activity designers that use this box, see the [Send](../WF_Design/Send-Activity-Designer.md), [Receive](../WF_Design/Receive-Activity-Designer.md), [ReceiveAndSendReply](../WF_Design/ReceiveAndSendReply-Template-Designer.md), and [SendAndReceiveReply](../WF_Design/SendAndReceiveReply-Template-Designer.md) topics.  
  
 The correlation initializers in the collection specified with this dialog box can initialize query-based, context, callback context, or request-reply correlations between the messaging activities.  
  
 The following table describes the user interface (UI) elements of the **Add Correlation Initializers** dialog box.  
  
|UI Element|Description|  
|----------------|-----------------|  
|**Add Initializer**|Click the **Add initialize** box to add an additional initializer to the collection.|  
|**Correlation Type**|Specifies the type of correlation initializer. There are four types to choose from:<br /><br /> 1.  A callback correlation initializer to specify a <xref:System.ServiceModel.Activities.CallbackCorrelationInitializer?qualifyHint=False>.<br />2.  A context correlation initializer to specify a <xref:System.ServiceModel.Activities.CorrelationInitializer?qualifyHint=False>.<br />3.  A request-reply correlation initializer to specify a <xref:System.ServiceModel.Activities.RequestReplyCorrelationInitializer?qualifyHint=False>.<br />4.  A query correlation initializer to specify a <xref:System.ServiceModel.Activities.QueryCorrelationInitializer?qualifyHint=False>.<br /><br /> To edit the **CorrelationType**<br /><br /> 1.  Tab to the specific row in the **Add Initializer** DataGrid.<br />2.  Press Ctrl+Tab to set focus to **CorrelationTypeComboBox**<br />3.  Press Alt+Down to pop up the **ComboBox** and edit it.|  
|**XPath Queries**|A key/value pair that contains the queries used to extract correlation data from incoming and outgoing messages. This list is only valid when using <xref:System.ServiceModel.Activities.QueryCorrelationInitializer?qualifyHint=False> types.|  
  
## To launch the Add Correlation Initializers dialog box  
 The **Add Correlation Initializers** dialog box is used by the **Send**, **Receive**, **ReceiveAndSendReply**, and **SendAndReceiveReply** designers. Accessing them is similar in each case and the case that involves the **Receive** designer is use here to illustrate the procedure.  
  
 The **Receive** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed. This creates a <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activity with a default <xref:System.Activities.Activity.DisplayName?qualifyHint=False> of Receive. Select the **Receive** activity designer and click the ellipsis button next to the (Collection) text for the **CorrelationInitializers** property in the property grid for the **Add Correlation Initializers** dialog box to appear.  
  
## See Also  
 [Add Correlation Dialog Box](assetId:///9e41a149-e8ab-41b1-8886-ea06a63041b6)   
 [Initialize Correlation Dialog Box](../WF_Design/Initialize-Correlation-Dialog-Box.md)