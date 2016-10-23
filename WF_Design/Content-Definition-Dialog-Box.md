---
title: "Content Definition Dialog Box"
ms.custom: na
ms.date: 10/04/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 7e4237c3-90a1-4149-bd8a-3643d1dde0df
caps.latest.revision: 3
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
# Content Definition Dialog Box
The **Content Definition** dialog box is used in Windows Workflow Designer to configure the **Content** properties of the <xref:System.ServiceModel.Activities.Send?qualifyHint=False>, <xref:System.ServiceModel.Activities.Receive?qualifyHint=False>, <xref:System.ServiceModel.Activities.SendReply?qualifyHint=False>, and <xref:System.ServiceModel.Activities.ReceiveReply?qualifyHint=False> activities. For more information about the activity designers that use this box, see the [Send](../WF_Design/Send-Activity-Designer.md), [Receive](../WF_Design/Receive-Activity-Designer.md), [ReceiveAndSendReply](../WF_Design/ReceiveAndSendReply-Template-Designer.md), and [SendAndReceiveReply](../WF_Design/SendAndReceiveReply-Template-Designer.md) topics.  
  
 The following table describes the user interface (UI) elements of the **Initialize Correlation** dialog box.  
  
|UI Element|Description|  
|----------------|-----------------|  
|**Message**|Specifies the message content with the **Message data** expression text box and the type by using the **Message type** drop-down list box. By default, the **Content Definition** uses the <xref:System.ServiceModel.Activities.ReceiveMessageContent?qualifyHint=False>, which expects a <xref:System.ServiceModel.Channels.Message?qualifyHint=False> or a message contract type within the workflow service definition.|  
|**Parameters**|Click the **Parameters** radio button to use <xref:System.ServiceModel.Activities.ReceiveParametersContent?qualifyHint=False>, which expects a data contract. Use the data grid to set a generic collection of <xref:System.Activities.OutArgument?qualifyHint=False> key/value pairs whose values are assigned to variable parameters in the current workflow.|  
  
 The **Content Definition** dialog box is used by the **Send**, **Receive**, **ReceiveAndSendReply**, and **SendAndReceiveReply** designers. Accessing them is similar in each case and the Receive case is used here to illustrate the procedure.  
  
 The **Receive** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed. This creates a <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activity with a default <xref:System.Activities.Activity.DisplayName?qualifyHint=False> of Receive. Select the **Receive** activity designer and click the ellipsis button next to the (Content) text for the **Content** property in the property grid for the **Content Definition** dialog box to appear.  
  
 The content can be specified within the **Message** section for a <xref:System.ServiceModel.Activities.ReceiveMessageContent?qualifyHint=False> activity or within the **Parameter** section for a <xref:System.ServiceModel.Activities.ReceiveParametersContent?qualifyHint=False> activity.  
  
## See Also  
 [Workflow Designer UI Help](../WF_Design/Workflow-Designer-UI-Help.md)