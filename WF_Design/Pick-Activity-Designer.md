---
title: "Pick Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 642c0a47-1b47-45de-a19a-ca0606cedd7a
caps.latest.revision: 9
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
# Pick Activity Designer
The <xref:System.Activities.Statements.Pick?qualifyHint=False> activity provides event-based control flow. The activity executes one of several branches in response to a triggering event.  
  
## The Pick Activity  
 A <xref:System.Activities.Statements.Pick?qualifyHint=False> activity contains a collection of <xref:System.Activities.Statements.PickBranch?qualifyHint=False> objects, one of which the <xref:System.Activities.Statements.Pick?qualifyHint=False> activity can execute due to some incoming event that serves as a trigger. In this way Windows Workflow Designer provides event-based control flow modeling. Each <xref:System.Activities.Statements.PickBranch?qualifyHint=False> contains a <xref:System.Activities.Statements.PickBranch.Trigger?qualifyHint=False> and an <xref:System.Activities.Statements.PickBranch.Action?qualifyHint=False>. At the beginning of a <xref:System.Activities.Statements.Pick?qualifyHint=False> activity’s execution, all the trigger activities of the <xref:System.Activities.Statements.PickBranch?qualifyHint=False> elements are scheduled. When the first activity completes, the corresponding action activity is scheduled, and all other trigger activities are canceled.  
  
### How to use the Pick Activity Designer  
 The **Pick** activity designer can be found in the **Control Flow** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on Workflow Designer (Alternatively, select **Toolbar** from the **View** menu or CTRL+ALT+X.)  
  
 The **Pick** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activity designers are normally placed, for example inside of a **Sequence** activity designer. After dropping it into Workflow Designer, it creates a <xref:System.Activities.Statements.Pick?qualifyHint=False> activity, which by default contains two empty <xref:System.Activities.Statements.PickBranch?qualifyHint=False> activities as elements with display names of Branch1 and Branch2. These respective <xref:System.Activities.Statements.PickBranch.DisplayName?qualifyHint=False> property values can be edited in the **PickBranch** activity designer header or within the **Properties** window for each branch.  
  
 There are two ways to add <xref:System.Activities.Statements.PickBranch?qualifyHint=False> activities to the collection of a <xref:System.Activities.Statements.Pick?qualifyHint=False> object: dragging and dropping the **PickBranch** designer from the **Toolbox** or by using the context menu from within the **Pick** design surface. For details, see the [PickBranch](../WF_Design/PickBranch-Activity-Designer.md) topic. Notice that the only item that can be placed inside a **Pick** activity designer is a **PickBranch** activity designer.  
  
### Pick Activity Properties in the Workflow Designer  
 The following table shows the <xref:System.Activities.Statements.Pick?qualifyHint=False> properties and describes how they are used in the designer. These properties can be edited in property grid or on the designer surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|Specifies the friendly name of the <xref:System.Activities.Statements.Pick?qualifyHint=False> activity designer in the header. The default value is Pick. The value can be edited in the property grid or directly on the header of the activity designer.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName?qualifyHint=False> is not strictly required, it is a best practice to use one.|  
  
## See Also  
 [Control Flow](../WF_Design/Control-Flow-Activity-Designers.md)   
 [Pick Activity](../Topic/Pick%20Activity.md)   
 [Using the Pick Activity](../Topic/Using%20the%20Pick%20Activity.md)