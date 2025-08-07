---
title: Workflow Designer - Initialize Correlation Dialog Box
description: Learn how you can use the Initialize Correlation dialog box in the Workflow Designer to edit the CorrelationData property of an InitializeCorrelation activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- InitializeCorrelation.UI
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Initialize Correlation Dialog Box

The **Initialize Correlation** dialog box is used in Workflow Designer to edit the <xref:System.ServiceModel.Activities.InitializeCorrelation.CorrelationData%2A> property of an <xref:System.ServiceModel.Activities.InitializeCorrelation> activity. For more information, see [InitializeCorrelation](../workflow-designer/initializecorrelation-activity-designer.md).

The following table describes the user interface (UI) elements of the **Initialize Correlation** dialog box:

|UI Element|Description|
|-|-----------------|
|**Correlation**|The <xref:System.ServiceModel.Activities.CorrelationHandle> of the correlation to initialize.|
|**Initialize On**|A key/value pair that contains the data to initialize. This value corresponds to the <xref:System.ServiceModel.Activities.InitializeCorrelation.CorrelationData%2A> property. An example of a valid key/value pair is a key named "OrderID" paired with a variable named OrderID.|

## To launch the Initialize Correlation dialog box

Click **View** on the **InitializeCorrelation** activity designer or select an <xref:System.ServiceModel.Activities.InitializeCorrelation> activity in Workflow Designer. Then, click the ellipsis button next to the <xref:System.ServiceModel.Activities.InitializeCorrelation.CorrelationData%2A> property in the property grid.

## See also

- [InitializeCorrelation](../workflow-designer/initializecorrelation-activity-designer.md)
