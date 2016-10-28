---
title: "CorrelationScope Activity Designer"
ms.custom: ""
ms.date: "10/19/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "System.ServiceModel.Activities.CorrelationScope.UI"
ms.assetid: 75f20664-9042-464d-8e2b-148d365a2286
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
# CorrelationScope Activity Designer
The **CorrelationScope** activity designer is used to create and configure a <xref:System.ServiceModel.Activities.CorrelationScope> activity that provides implicit management of child messaging activities using a <xref:System.ServiceModel.Activities.CorrelationHandle> object.  
  
## The CorrelationScope Activity  
 The <xref:System.ServiceModel.Activities.CorrelationScope.CorrelatesWith*> property specifies the <xref:System.ServiceModel.Activities.CorrelationHandle> used to manage child messaging activities. The <xref:System.ServiceModel.Activities.Send> and <xref:System.ServiceModel.Activities.Receive> activities contained in the <xref:System.ServiceModel.Activities.CorrelationScope.Body*> are configured to use the <xref:System.ServiceModel.Activities.CorrelationScope.CorrelatesWith*> property of the containing <xref:System.ServiceModel.Activities.CorrelationScope> activity to perform correlation.  
  
### Using the CorrelationScope Activity Designer  
 The **CorrelationScope** activity designer can be found in the **Messaging** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the left side of the [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **CorrelationScope** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] surface. This creates a <xref:System.ServiceModel.Activities.CorrelationScope> activity with a default **DisplayName** of CorrelationScope. The <xref:System.Activities.Activity.DisplayName*> can be edited in the header of the **CorrelationScope** activity designer or in the **DisplayName** box of the **Properties** window.  
  
 To specify the <xref:System.ServiceModel.Activities.CorrelationHandle> used by child messaging activities, click the ellipse button beside the **CorrelatesWith** field in **Properties** window to display the **Expression Editor** dialog box. This property can also be set on the activity designer surface.  
  
 The activities scoped within the correlation are specified by dropping their designers within the **Body** box within the **CorrelationScope** designer.  
  
### The CorrelationScope Properties  
 The following table shows the <xref:System.ServiceModel.Activities.CorrelationScope> properties and describes how they are used in the designer. These properties can be edited either in **Properties** window or on [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] designer surface, and often in both.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName*>|False|The optional friendly name of the <xref:System.ServiceModel.Activities.InitializeCorrelation> activity.|  
|<xref:System.ServiceModel.Activities.CorrelationScope.CorrelatesWith*>|False|Specifies the <xref:System.ServiceModel.Activities.CorrelationHandle> used to manage child messaging activities. If you do not set this property, <xref:System.ServiceModel.Activities.CorrelationScope> creates an implicit <xref:System.ServiceModel.Activities.CorrelationHandle> automatically.|  
|<xref:System.ServiceModel.Activities.CorrelationScope.Body*>|False|Specifies the activities within the scope of the correlation.|  
  
## See Also  
 [InitializeCorrelation](../workflow-designer/initializecorrelation-activity-designer.md)   
 [Receive](../workflow-designer/receive-activity-designer.md)   
 [ReceiveAndSendReply](../workflow-designer/receiveandsendreply-template-designer.md)   
 [Send](../workflow-designer/send-activity-designer.md)   
 [SendAndReceiveReply](../workflow-designer/sendandreceivereply-template-designer.md)   
 [TransactedReceiveScope](../workflow-designer/transactedreceivescope-activity-designer.md)