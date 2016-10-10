---
title: "CorrelationScope Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 75f20664-9042-464d-8e2b-148d365a2286
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
# CorrelationScope Activity Designer
The **CorrelationScope** activity designer is used to create and configure a <xref:System.ServiceModel.Activities.CorrelationScope?qualifyHint=False> activity that provides implicit management of child messaging activities using a <xref:System.ServiceModel.Activities.CorrelationHandle?qualifyHint=False> object.  
  
## The CorrelationScope Activity  
 The <xref:System.ServiceModel.Activities.CorrelationScope.CorrelatesWith?qualifyHint=False> property specifies the <xref:System.ServiceModel.Activities.CorrelationHandle?qualifyHint=False> used to manage child messaging activities. The <xref:System.ServiceModel.Activities.Send?qualifyHint=False> and <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activities contained in the <xref:System.ServiceModel.Activities.CorrelationScope.Body?qualifyHint=False> are configured to use the <xref:System.ServiceModel.Activities.CorrelationScope.CorrelatesWith?qualifyHint=False> property of the containing <xref:System.ServiceModel.Activities.CorrelationScope?qualifyHint=False> activity to perform correlation.  
  
### Using the CorrelationScope Activity Designer  
 The **CorrelationScope** activity designer can be found in the **Messaging** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the left side of the Workflow Designer (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **CorrelationScope** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface. This creates a <xref:System.ServiceModel.Activities.CorrelationScope?qualifyHint=False> activity with a default **DisplayName** of CorrelationScope. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> can be edited in the header of the **CorrelationScope** activity designer or in the **DisplayName** box of the **Properties** window.  
  
 To specify the <xref:System.ServiceModel.Activities.CorrelationHandle?qualifyHint=False> used by child messaging activities, click the ellipse button beside the **CorrelatesWith** field in **Properties** window to display the **Expression Editor** dialog box. This property can also be set on the activity designer surface.  
  
 The activities scoped within the correlation are specified by dropping their designers within the **Body** box within the **CorrelationScope** designer.  
  
### The CorrelationScope Properties  
 The following table shows the <xref:System.ServiceModel.Activities.CorrelationScope?qualifyHint=False> properties and describes how they are used in the designer. These properties can be edited either in **Properties** window or on Workflow Designer designer surface, and often in both.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|The optional friendly name of the <xref:System.ServiceModel.Activities.InitializeCorrelation?qualifyHint=False> activity.|  
|<xref:System.ServiceModel.Activities.CorrelationScope.CorrelatesWith?qualifyHint=False>|False|Specifies the <xref:System.ServiceModel.Activities.CorrelationHandle?qualifyHint=False> used to manage child messaging activities. If you do not set this property, <xref:System.ServiceModel.Activities.CorrelationScope?qualifyHint=False> creates an implicit <xref:System.ServiceModel.Activities.CorrelationHandle?qualifyHint=False> automatically.|  
|<xref:System.ServiceModel.Activities.CorrelationScope.Body?qualifyHint=False>|False|Specifies the activities within the scope of the correlation.|  
  
## See Also  
 [InitializeCorrelation](../WF_Design/InitializeCorrelation-Activity-Designer.md)   
 [Receive](../WF_Design/Receive-Activity-Designer.md)   
 [ReceiveAndSendReply](../WF_Design/ReceiveAndSendReply-Template-Designer.md)   
 [Send](../WF_Design/Send-Activity-Designer.md)   
 [SendAndReceiveReply](../WF_Design/SendAndReceiveReply-Template-Designer.md)   
 [TransactedReceiveScope](../WF_Design/TransactedReceiveScope-Activity-Designer.md)