---
title: "InitializeCorrelation Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.ServiceModel.Activities.InitializeCorrelation.UI"
ms.assetid: 4c54f34c-ee84-42a6-abb0-ec260c1ccb76
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# InitializeCorrelation Activity Designer
The **InitializeCorrelation** activity designer is used to create and configure an <xref:System.ServiceModel.Activities.InitializeCorrelation> activity that is used to establish a correlation between messages prior to sending or receiving them.

## The InitializeCorrelation Activity
 An <xref:System.ServiceModel.Activities.InitializeCorrelation> activity is used to initialize correlations without sending or receiving a message. Typically correlation is initialized when sending or receiving a message. If correlation must be established before a message is sent or received, use <xref:System.ServiceModel.Activities.InitializeCorrelation> to initialize the correlation.

### Using the InitializeCorrelation Activity Designer
 The **InitializeCorrelation** activity designer can be found in the **Messaging** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the [!INCLUDE[wfd2](../includes/wfd2-md.md)] (Alternatively, select **Toolbar** from the **View** menu or CTRL+ALT+X.)

 The **InitializeCorrelation** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface. This creates a <xref:System.ServiceModel.Activities.InitializeCorrelation> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of InitializeCorrelation.The <xref:System.Activities.Activity.DisplayName%2A> can be edited in the header of the **InitializeCorrelation** activity designer or in the **DisplayName** box of the **Properties** window.

 The <xref:System.ServiceModel.Activities.CorrelationHandle> can be specifies in the **Correlation** field in **Properties** window on the **InitializeCorrelation** activity designer surface.

 Clicking the ellipse button besides the **CorrelationData** field in **Properties** window or the “View …” hint text on **InitializeCorrelation** activity designer surface displays the **Initialize Correlation** dialog box in which you can specify the correlation handle and the key-value pairs used to initialize it. [!INCLUDE[crabout](../includes/crabout-md.md)] using this dialog box, see the [Type Collection Editor Dialog Box](../workflow-designer/type-collection-editor-dialog-box.md) topic.

### The InitializeCorrelation Properties
 The following table shows the <xref:System.ServiceModel.Activities.InitializeCorrelation> properties and describes how they are used in the designer. These properties can be edited in **Properties** window or on [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface.

|Property Name|Required|Usage|
|-------------------|--------------|-----------|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.ServiceModel.Activities.InitializeCorrelation> activity. The default value is InitializeCorrelation.<br /><br /> Although the use of a non-default value for the friendly <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it is a best practice to use such a value.|
|<xref:System.ServiceModel.Activities.InitializeCorrelation.Correlation%2A>|False|The <xref:System.ServiceModel.Activities.CorrelationHandle> used to associate workflow activities in the correlation.|
|<xref:System.ServiceModel.Activities.InitializeCorrelation.CorrelationData%2A>|False|A dictionary of correlation data that relates messages to the workflow instance.<br /><br /> Use the **Initialize Correlation** dialog box to configure the <xref:System.ServiceModel.Activities.InitializeCorrelation.CorrelationData%2A>. [!INCLUDE[crabout](../includes/crabout-md.md)] the use this dialog box, see the [Type Collection Editor Dialog Box](../workflow-designer/type-collection-editor-dialog-box.md) topic.|

## See Also
 [CorrelationScope](../workflow-designer/correlationscope-activity-designer.md)
 [Receive](../workflow-designer/receive-activity-designer.md)
 [ReceiveAndSendReply](../workflow-designer/receiveandsendreply-template-designer.md)
 [Send](../workflow-designer/send-activity-designer.md)
 [SendAndReceiveReply](../workflow-designer/sendandreceivereply-template-designer.md)
 [TransactedReceiveScope](../workflow-designer/transactedreceivescope-activity-designer.md)