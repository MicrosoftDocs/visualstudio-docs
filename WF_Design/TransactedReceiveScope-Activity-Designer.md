---
title: "TransactedReceiveScope Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 7ca93aad-4e83-4d81-90f4-998ee114d9b6
caps.latest.revision: 4
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
# TransactedReceiveScope Activity Designer
The **TransactedReceiveScope** designer is used to create and configure a <xref:System.ServiceModel.Activities.TransactedReceiveScope?qualifyHint=False> activity.  
  
## The TransactedReceiveScope Activity  
 The <xref:System.ServiceModel.Activities.TransactedReceiveScope?qualifyHint=False> activity enables you to flow a transaction into server transactions created by a workflow or dispatcher.  
  
### Using the TransactedReceiveScope Activity Designer  
 The **TransactedReceiveScope** activity designer can be found in the **Messaging** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on Workflow Designer (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **TransactedReceiveScope** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed. This creates a <xref:System.ServiceModel.Activities.TransactedReceiveScope?qualifyHint=False> activity with a default **DisplayName** of TransactedReceiveScope. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> can be edited in the header of the **TransactedReceiveScope** activity designer or in the **DisplayName** box of the property grid.  
  
 The **TransactedReceiveScope** designer contains **Request** and **Body** boxes. These are used to configure the <xref:System.ServiceModel.Activities.TransactedReceiveScope.Request?qualifyHint=False> property, which specifies a <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activity and a <xref:System.ServiceModel.Activities.TransactedReceiveScope.Body?qualifyHint=False> property, which specifies some other <xref:System.Activities.Activity?qualifyHint=False>. The <xref:System.ServiceModel.Activities.TransactedReceiveScope.Request?qualifyHint=False> creates a transaction. The transaction then is made ambient for the scope of the <xref:System.ServiceModel.Activities.TransactedReceiveScope.Body?qualifyHint=False> so that any activity within this scope executes inside this transaction.  
  
### The TransactedReceiveScope Properties  
 The following table shows the <xref:System.ServiceModel.Activities.TransactedReceiveScope?qualifyHint=False> properties and describes how they are used in the designer. These <xref:System.Activities.Activity.DisplayName?qualifyHint=False> property can be edited in property grid or on the Workflow Designer surface, but the others must be edited on the design surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|The optional friendly name of the <xref:System.ServiceModel.Activities.TransactedReceiveScope?qualifyHint=False> activity. The default is TransactedReceiveScope.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName?qualifyHint=False> name is not strictly required, it is a best practice to use a display name.|  
|<xref:System.ServiceModel.Activities.TransactedReceiveScope.Request?qualifyHint=False>|True|Drops a <xref:System.ServiceModel.Activities.Receive?qualifyHint=False> activity into the **Request** block on the activity designer surface.|  
|<xref:System.ServiceModel.Activities.TransactedReceiveScope.Body?qualifyHint=False>|False|Drops an <xref:System.Activities.Activity?qualifyHint=False> into the **Body** block on the activity designer surface.|  
  
## See Also  
 [CorrelationScope](../WF_Design/CorrelationScope-Activity-Designer.md)   
 [InitializeCorrelation](../WF_Design/InitializeCorrelation-Activity-Designer.md)   
 [Receive](../WF_Design/Receive-Activity-Designer.md)   
 [ReceiveAndSendReply](../WF_Design/ReceiveAndSendReply-Template-Designer.md)   
 [Send](../WF_Design/Send-Activity-Designer.md)   
 [SendAndReceiveReply](../WF_Design/SendAndReceiveReply-Template-Designer.md)