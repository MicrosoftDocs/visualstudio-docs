---
title: InitializeCorrelation Activity Designer
description: In Workflow Designer, learn how you can use the InitializeCorrelation activity designer to create and configure an InitializeCorrelation activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "System.ServiceModel.Activities.InitializeCorrelation.UI"
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# InitializeCorrelation Activity Designer

The **InitializeCorrelation** activity designer is used to create and configure an <xref:System.ServiceModel.Activities.InitializeCorrelation> activity. The <xref:System.ServiceModel.Activities.InitializeCorrelation> activity establishes a correlation between messages before sending or receiving them.

## The InitializeCorrelation Activity

An <xref:System.ServiceModel.Activities.InitializeCorrelation> activity is used to initialize correlations without sending or receiving a message. Typically correlation is initialized when sending or receiving a message. If correlation must be established before a message is sent or received, use <xref:System.ServiceModel.Activities.InitializeCorrelation> to initialize the correlation.

### Using the InitializeCorrelation Activity Designer

Access the **InitializeCorrelation** activity designer in the **Messaging** category of the **Toolbox**.

The **InitializeCorrelation** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface. Dropping the activity designer creates a <xref:System.ServiceModel.Activities.InitializeCorrelation> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of InitializeCorrelation. The <xref:System.Activities.Activity.DisplayName%2A> can be edited in the header of the **InitializeCorrelation** activity designer or in the **DisplayName** box of the **Properties** window.

The <xref:System.ServiceModel.Activities.CorrelationHandle> can be specifies in the **Correlation** field in **Properties** window on the **InitializeCorrelation** activity designer surface.

To display the **Initialize Correlation** dialog box where you can specify the correlation handle and the key-value pairs used to initialize it, select the ellipsis button next to the **CorrelationData** field in **Properties** window. Or, select the "View ..." hint text on  the **InitializeCorrelation** activity designer surface. For more information about using this dialog box, see the [Type Collection Editor Dialog Box](../workflow-designer/type-collection-editor-dialog-box.md) article.

### The InitializeCorrelation Properties

The following table shows the <xref:System.ServiceModel.Activities.InitializeCorrelation> properties and describes how they're used in the designer. These properties can be edited in **Properties** window or on Workflow Designer surface.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.ServiceModel.Activities.InitializeCorrelation> activity. The default value is InitializeCorrelation.<br /><br /> Although the use of a non-default value for the friendly <xref:System.Activities.Activity.DisplayName%2A> isn't strictly required, it is recommended.|
|<xref:System.ServiceModel.Activities.InitializeCorrelation.Correlation%2A>|False|The <xref:System.ServiceModel.Activities.CorrelationHandle> used to associate workflow activities in the correlation.|
|<xref:System.ServiceModel.Activities.InitializeCorrelation.CorrelationData%2A>|False|A dictionary of correlation data that relates messages to the workflow instance.<br /><br /> Use the **Initialize Correlation** dialog box to configure the <xref:System.ServiceModel.Activities.InitializeCorrelation.CorrelationData%2A>. For more information about the use this dialog box, see the [Type Collection Editor Dialog Box](../workflow-designer/type-collection-editor-dialog-box.md) article.|

## See also

- [CorrelationScope](../workflow-designer/correlationscope-activity-designer.md)
- [Receive](../workflow-designer/receive-activity-designer.md)
- [ReceiveAndSendReply](../workflow-designer/receiveandsendreply-template-designer.md)
- [Send](../workflow-designer/send-activity-designer.md)
- [SendAndReceiveReply](../workflow-designer/sendandreceivereply-template-designer.md)
- [TransactedReceiveScope](../workflow-designer/transactedreceivescope-activity-designer.md)