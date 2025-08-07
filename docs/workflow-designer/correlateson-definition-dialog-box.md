---
title: "Workflow Designer - CorrelatesOn Definition Dialog Box"
description: Learn how you can use the CorrelatesOn dialog box in Workflow Designer to edit the CorrelatesOn property of a Receive activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "CorrelatesOnDefinition.UI"
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# CorrelatesOn Definition Dialog Box

The **CorrelatesOn** dialog box is used in Workflow Designer to edit the <xref:System.ServiceModel.Activities.Receive.CorrelatesOn%2A> property of a <xref:System.ServiceModel.Activities.Receive> activity. For more information, see [Receive Activity Designer](../workflow-designer/receive-activity-designer.md).

The correlation between <xref:System.ServiceModel.Activities.Receive> activities specifies how different service operations connect with each other in a workflow.

The following table describes the user interface (UI) elements of the **CorrelatesOn** dialog box.

|UI Element|Description|
|-|-----------------|
|**CorrelatesWith**|The <xref:System.ServiceModel.Activities.CorrelationHandle> that is used to route the message to the appropriate workflow instance.|
|**XPath Queries**|A key/value pair that contains the queries used to extract correlation data from the incoming messages. This value corresponds to the <xref:System.ServiceModel.Activities.Receive.CorrelatesOn%2A> property. The XPath queries are contained in a <xref:System.ServiceModel.MessageQuerySet> object.|

## To launch the CorrelatesOn dialog box

The **Receive** activity designer can be dragged from **Toolbox** and dropped on to the Workflow Designer surface, wherever activities are usually placed. Dropping the activity designer creates a <xref:System.ServiceModel.Activities.Receive> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of Receive. To open the **CorrelatesOn Definition** dialog box, select the **Receive** activity designer and then in the property grid, select the ellipsis button next to the Collection text for the **CorrelatesOn** property.

## See also

- <xref:System.ServiceModel.Activities.Receive>
- [Add CorrelationInitializers Dialog Box](../workflow-designer/add-correlationinitializers-dialog-box.md)
- [Initialize Correlation Dialog Box](../workflow-designer/initialize-correlation-dialog-box.md)