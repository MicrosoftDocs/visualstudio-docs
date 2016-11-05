---
title: "InvokeDelegate | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "InvokeDelegate Designer"
  - "System.Activities.Statements.InvokeDelegate.UI"
ms.assetid: 289a7498-5127-453f-beb5-05f05b80d26f
caps.latest.revision: 3
ms.author: "sdanie"
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
# InvokeDelegate
The **InvokeDelegate** designer is used to create and configure an <xref:System.Activities.Statements.InvokeDelegate> activity.  
  
## The InvokeDelegate Activity  
 The <xref:System.Activities.Statements.InvokeDelegate> calls a public delegate.  
  
### Using the InvokeDelegate Activity Designer  
 The **InvokeDelegate** activity designer can be found in the **Primitives** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CRTL+ALT+X.)  
  
 The **InvokeDelegate** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] surface where ever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates an <xref:System.Activities.Statements.InvokeDelegate> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of InvokeDelegate. The <xref:System.Activities.Activity.DisplayName%2A> can be edited in the header of the **InvokeDelegate** activity designer or in the **DisplayName** box of the property grid.  
  
### The InvokeDelegate Properties  
 The following table shows the <xref:System.Activities.Statements.InvokeDelegate> properties and describes how they are used in the designer. These properties can be edited in property grid and some can be edited on [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)]designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.Activities.Statements.InvokeDelegate> activity. The default value is InvokeDelegate.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it is a best practice to use one.|  
|<xref:System.Activities.Statements.InvokeDelegate.Delegate%2A>|True|The name of the <xref:System.Activities.Statements.ActivityDelegate> to be called when the activity executes. This property can be edited on designer surface. This is a mandatory property.|  
|<xref:System.Activities.Statements.InvokeMethod.DelegateArguments%2A>|False|The argument collection of the called delegate. The keys are the names of the <xref:System.Activities.Statements.ActivityDelegateParameter> objects on the <xref:System.Activities.Statements.ActivityDelegate> and the values are the arguments whose expressions are evaluated and assigned to the corresponding <xref:System.Activities.Statements.ActivityDelegateParameter> objects. In the property grid, click the ellipses button in the **DelegateArguments** field, it displays the **DelegateArguments** dialog to let you set this property. Click the **Create Argument** field to add the arguments.|  
  
## See Also  
 [How to: Define and consume activity delegates in the Workflow Designer](../workflow-designer/how-to-define-and-consume-activity-delegates-in-the-workflow-designer.md)