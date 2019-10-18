---
title: "CorrelatesOn Definition Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "CorrelatesOnDefinition.UI"
ms.assetid: 8b2b627a-f236-4479-aa09-525df65e3413
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# CorrelatesOn Definition Dialog Box
The **CorrelatesOn** dialog box is used in [!INCLUDE[wfd1](../includes/wfd1-md.md)] to edit the <xref:System.ServiceModel.Activities.Receive.CorrelatesOn%2A> property of a <xref:System.ServiceModel.Activities.Receive> activity. [!INCLUDE[crdefault](../includes/crdefault-md.md)] the [Receive](../workflow-designer/receive-activity-designer.md) topic.

 The correlation between <xref:System.ServiceModel.Activities.Receive> activities specifies how different service operations connect with each other in a workflow.

 The following table describes the user interface (UI) elements of the **CorrelatesOn** dialog box.

|UI Element|Description|
|----------------|-----------------|
|**CorrelatesWith**|The <xref:System.ServiceModel.Activities.CorrelationHandle> that is used to route the message to the appropriate workflow instance.|
|**XPath Queries**|A key/value pair that contains the queries used to extract correlation data from the incoming messages. This corresponds to the <xref:System.ServiceModel.Activities.Receive.CorrelatesOn%2A> property. The XPath queries are contained in a <xref:System.ServiceModel.MessageQuerySet> object.|

## To launch the CorrelatesOn dialog box
 The **Receive** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface wherever activities are usually placed. This creates a <xref:System.ServiceModel.Activities.Receive> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of Receive. Select the **Receive** activity designer and click the ellipsis button next to the (Collection) text for the **CorrelatesOn** property in the property grid for the **CorrelatesOn Definition** dialog box to appear.

## See Also
 <xref:System.ServiceModel.Activities.Receive>
 [Add CorrelationInitializers Dialog Box](../workflow-designer/add-correlationinitializers-dialog-box.md)
 [Initialize Correlation Dialog Box](../workflow-designer/initialize-correlation-dialog-box.md)