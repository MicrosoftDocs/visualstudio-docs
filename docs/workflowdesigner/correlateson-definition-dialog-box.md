---
title: "CorrelatesOn Definition Dialog Box"
ms.custom: na
ms.date: "10/04/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CorrelatesOnDefinition.UI"
ms.assetid: 8b2b627a-f236-4479-aa09-525df65e3413
caps.latest.revision: 6
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
# CorrelatesOn Definition Dialog Box
The **CorrelatesOn** dialog box is used in [!INCLUDE[wfd1](../workflowdesigner/includes/wfd1_md.md)] to edit the \<xref:System.ServiceModel.Activities.Receive.CorrelatesOn*> property of a \<xref:System.ServiceModel.Activities.Receive> activity. [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)] the [Receive](../workflowdesigner/receive-activity-designer.md) topic.  
  
 The correlation between \<xref:System.ServiceModel.Activities.Receive> activities specifies how different service operations connect with each other in a workflow.  
  
 The following table describes the user interface (UI) elements of the **CorrelatesOn** dialog box.  
  
|UI Element|Description|  
|----------------|-----------------|  
|**CorrelatesWith**|The \<xref:System.ServiceModel.Activities.CorrelationHandle> that is used to route the message to the appropriate workflow instance.|  
|**XPath Queries**|A key/value pair that contains the queries used to extract correlation data from the incoming messages. This corresponds to the \<xref:System.ServiceModel.Activities.Receive.CorrelatesOn*> property. The XPath queries are contained in a \<xref:System.ServiceModel.MessageQuerySet> object.|  
  
## To launch the CorrelatesOn dialog box  
 The **Receive** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] surface wherever activities are usually placed. This creates a \<xref:System.ServiceModel.Activities.Receive> activity with a default \<xref:System.Activities.Activity.DisplayName*> of Receive. Select the **Receive** activity designer and click the ellipsis button next to the (Collection) text for the **CorrelatesOn** property in the property grid for the **CorrelatesOn Definition** dialog box to appear.  
  
## See Also  
 \<xref:System.ServiceModel.Activities.Receive>   
 [Add CorrelationInitializers Dialog Box](../workflowdesigner/add-correlationinitializers-dialog-box.md)   
 [Add Correlation Dialog Box](assetId:///9e41a149-e8ab-41b1-8886-ea06a63041b6)   
 [Initialize Correlation Dialog Box](../workflowdesigner/initialize-correlation-dialog-box.md)