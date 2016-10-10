---
title: "CorrelatesOn Definition Dialog Box"
ms.custom: na
ms.date: 10/04/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 8b2b627a-f236-4479-aa09-525df65e3413
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
# CorrelatesOn Definition Dialog Box
The **CorrelatesOn** dialog box is used in Windows Workflow Designer to edit the <xref:System.ServiceModel.Activities.Receive.CorrelatesOn?qualifyHint=False> property of a <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activity. For more information, see the [Receive](../WF_Design/Receive-Activity-Designer.md) topic.  
  
 The correlation between <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activities specifies how different service operations connect with each other in a workflow.  
  
 The following table describes the user interface (UI) elements of the **CorrelatesOn** dialog box.  
  
|UI Element|Description|  
|----------------|-----------------|  
|**CorrelatesWith**|The <xref:System.ServiceModel.Activities.CorrelationHandle?qualifyHint=False> that is used to route the message to the appropriate workflow instance.|  
|**XPath Queries**|A key/value pair that contains the queries used to extract correlation data from the incoming messages. This corresponds to the <xref:System.ServiceModel.Activities.Receive.CorrelatesOn?qualifyHint=False> property. The XPath queries are contained in a <xref:System.ServiceModel.MessageQuerySet?qualifyHint=False> object.|  
  
## To launch the CorrelatesOn dialog box  
 The **Receive** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed. This creates a <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activity with a default <xref:System.Activities.Activity.DisplayName?qualifyHint=False> of Receive. Select the **Receive** activity designer and click the ellipsis button next to the (Collection) text for the **CorrelatesOn** property in the property grid for the **CorrelatesOn Definition** dialog box to appear.  
  
## See Also  
 <xref:System.ServiceModel.Activities.Receive?qualifyHint=False>   
 [Add CorrelationInitializers Dialog Box](../WF_Design/Add-CorrelationInitializers-Dialog-Box.md)   
 [Add Correlation Dialog Box](assetId:///9e41a149-e8ab-41b1-8886-ea06a63041b6)   
 [Initialize Correlation Dialog Box](../WF_Design/Initialize-Correlation-Dialog-Box.md)