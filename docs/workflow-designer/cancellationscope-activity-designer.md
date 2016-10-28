---
title: "CancellationScope Activity Designer"
ms.custom: ""
ms.date: "10/19/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "System.Activities.Statements.CancellationScope.UI"
ms.assetid: 2c85d663-b219-4142-9866-7693ffd46379
caps.latest.revision: 8
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
# CancellationScope Activity Designer
The **CancellationScope** activity designer is used to create and configure a <xref:System.Activities.Statements.CancellationScope> activity.  
  
## The CancellationScope Activity  
 The <xref:System.Activities.Statements.CancellationScope> activity allows you to specify an activity for execution and cancellation logic for that activity.  
  
### Using the CancellationScope Activity Designer  
 The **CancellationScope** activity designer can be found in the **Transaction** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab of the [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **CancellationScope** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates a <xref:System.Activities.Statements.CancellationScope> activity with a default <xref:System.Activities.Activity.DisplayName*> of CancellationScope. The <xref:System.Activities.Activity.DisplayName*> value can be edited in the header of the **CancellationScope** activity designer or in the **DisplayName** box of the property grid.  
  
### The CancellationScope Properties  
 The following table shows the <xref:System.Activities.Statements.CancellationScope> properties and describes how they are used in the designer. The <xref:System.Activities.Activity.DisplayName*> property can be edited in property grid but the other properties must be edited on [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName*>|False|The optional friendly name of the <xref:System.Activities.Statements.CancellationScope> activity. The default is CancellationScope. Although the <xref:System.Activities.Activity.DisplayName*> value is not strictly required, it is a best practice to use one.|  
|<xref:System.Activities.Statements.CancellationScope.Body*>|True|Specifies the activity for which cancellation logic is provided. To add the <xref:System.Activities.Statements.CancellationScope.Body*> activity, drop an activity from the **Toolbox** into the **Body** box on the **CancellationScope** activity designer with hint text “Drop Activity Here”.|  
|<xref:System.Activities.Statements.CancellationScope.CancellationHandler*>|True|Specifies the activity that is executed in the event of cancellation. To add the <xref:System.Activities.Statements.CancellationScope.CancellationHandler*> activity, drop an activity from the **Toolbox** into the **CancellationHandler** box on the **CancellationScope** activity designer with hint text “Drop Activity Here”.|  
  
## See Also  
 [Transaction](../workflow-designer/transaction-activity-designers.md)   
 [CompensableActivity](../workflow-designer/compensableactivity-activity-designer.md)   
 [Compensate](../workflow-designer/compensate-activity-designer.md)   
 [Confirm](../workflow-designer/confirm-activity-designer.md)   
 [TransactionScope](../workflow-designer/transactionscope-activity-designer.md)