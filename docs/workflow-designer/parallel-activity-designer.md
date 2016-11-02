---
title: "Parallel Activity Designer | Microsoft Docs"
ms.custom: ""
ms.date: "10/19/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "System.Activities.Statements.Parallel.UI"
ms.assetid: 0306dc3b-075a-4091-ac3a-96486fbabed5
caps.latest.revision: 10
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
# Parallel Activity Designer
The <xref:System.Activities.Statements.Parallel> activity executes a collection of child activities concurrently.  
  
## The Parallel Activity  
 The <xref:System.Activities.Statements.Parallel> activity stores its child activities in a  <xref:System.Activities.Statements.Parallel.Branches*> collection. Use the <xref:System.Activities.Statements.Parallel> activity instead of the <xref:System.Activities.Statements.Sequence> activity if some of the child activities may go idle.  
  
 The <xref:System.Activities.Statements.Parallel> activity has a <xref:System.Activities.Statements.Parallel.CompletionCondition*> property that contains a user specified [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] expression. The <xref:System.Activities.Statements.Parallel> activity evaluates this property after each branch completes. If it evaluates to **True**, then the <xref:System.Activities.Statements.Parallel> activity completes without executing the other branches. If the <xref:System.Activities.Statements.Parallel.CompletionCondition*> does not evaluate to **True**, then the <xref:System.Activities.Statements.Parallel> activity completes when all of its child activities have completed.  
  
### Using the Parallel Activity Designer  
 The **Parallel** activity designer can be found in the **Control Flow** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the left side of the [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **Parallel** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)] surface wherever activity designers are normally placed, for example, inside of a **Sequence** activity designer. After dropping it into the [!INCLUDE[wfd2](../workflow-designer/includes/wfd2_md.md)], it creates a <xref:System.Activities.Statements.Parallel> activity, which by default contains a <xref:System.Activities.Activity.DisplayName*> of **Parallel**  
  
 To add an activity to the <xref:System.Activities.Statements.Parallel.Branches*> collection of the parallel activity, drag some other activity designer from the **Toolbox** and drop it on the triangle inside the **Parallel** activity designer. The triangles flank the activities contained in the branches. Additional activities can be added by repeating this procedure. The activities can be reordered by dragging and dropping them within the **Parallel** activity designer.  
  
### Parallel Activity Properties in the Workflow Designer  
 The following table shows the Parallel activity properties and describes how they are used in the designer.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName*>|False|Specifies the friendly display name of the activity designer in the header. The default value is **Parallel**. The value can be optionally edited in the **Properties** grid or directly on the activity designer header.|  
|<xref:System.Activities.Statements.Parallel.Branches*>|True|Contains the collection of child activities to be executed.|  
|<xref:System.Activities.Statements.Parallel.CompletionCondition*>|False|Evaluated after a branch completes. If it evaluates to **True**, then the scheduled pending branches are canceled. If this property is not set or evaluates to **False**, the activity completes when all of its child activities have completed. The default value is **null**.|  
  
## See Also  
 [Sequence](../workflow-designer/sequence-activity-designer.md)   
 [ParallelForEach\<T>](../workflow-designer/parallelforeach-t-activity-designer.md)   
 [Control Flow](../workflow-designer/control-flow-activity-designers.md)