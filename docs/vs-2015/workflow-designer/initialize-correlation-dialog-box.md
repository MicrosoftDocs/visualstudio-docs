---
title: "Initialize Correlation Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "InitializeCorrelation.UI"
ms.assetid: 2a0a1cd3-7b9e-493e-9264-fcf85289ffcf
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# Initialize Correlation Dialog Box
The **Initialize Correlation** dialog box is used in [!INCLUDE[wfd1](../includes/wfd1-md.md)] to edit the <xref:System.ServiceModel.Activities.InitializeCorrelation.CorrelationData%2A> property of an <xref:System.ServiceModel.Activities.InitializeCorrelation> activity. [!INCLUDE[crdefault](../includes/crdefault-md.md)] the [InitializeCorrelation](../workflow-designer/initializecorrelation-activity-designer.md) topic.

 The following table describes the user interface (UI) elements of the **Initialize Correlation** dialog box.

|UI Element|Description|
|----------------|-----------------|
|**Correlation**|The <xref:System.ServiceModel.Activities.CorrelationHandle> of the correlation to initialize.|
|**Initialize On**|A key/value pair that contains the data to initialize. This corresponds to the <xref:System.ServiceModel.Activities.InitializeCorrelation.CorrelationData%2A> property. An example of a valid key/value pair would be a key named “OrderID” paired with a variable named OrderID.|

## To launch the Initialize Correlation dialog box

- Click **View** on the **InitializeCorrelation** activity designer or select an <xref:System.ServiceModel.Activities.InitializeCorrelation> activity in [!INCLUDE[wfd2](../includes/wfd2-md.md)] and then click the ellipsis button next to the <xref:System.ServiceModel.Activities.InitializeCorrelation.CorrelationData%2A> property in the property grid.

## See Also
 [InitializeCorrelation](../workflow-designer/initializecorrelation-activity-designer.md)