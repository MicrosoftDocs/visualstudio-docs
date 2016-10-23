---
title: "Rethrow Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 9cfa2eda-395f-4cf3-9154-83fadd4f7452
caps.latest.revision: 5
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
# Rethrow Activity Designer
The **Rethrow** activity designer is used to create and configure a <xref:System.Activities.Statements.Rethrow?qualifyHint=False> activity.  
  
## The Rethrow Activity  
 The <xref:System.Activities.Statements.Rethrow?qualifyHint=False> activity throws a previously thrown exception. This activity can only be used in a <xref:System.Activities.Statements.Catch?qualifyHint=False> handler in the <xref:System.Activities.Statements.TryCatch?qualifyHint=False> activity.  
  
### Using the ReThrow Activity Designer  
 The **Rethrow** activity designer can be found in the **Error Handling** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the left side of the Workflow Designer (Alternatively, select **Toolbar** from the **View** menu or CTRL+ALT+X.)  
  
 The **Rethrow** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence?qualifyHint=False>. This creates a <xref:System.Activities.Statements.Rethrow?qualifyHint=False> activity with a default **DisplayName** of Throw. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> value can be edited in the header of the **Rethrow** activity designer or in the **DisplayName** box of the property grid.  
  
### The Rethrow Properties  
 The following table shows the <xref:System.Activities.Statements.Rethrow?qualifyHint=False> properties and describes how they are used in the designer.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|Specifies the optional friendly name of the <xref:System.Activities.Statements.ReThrow?qualifyHint=False> activity. The default is Rethrow.|  
  
## See Also  
 [Collection](../WF_Design/Collection-Activity-Designers.md)   
 [Throw](../WF_Design/Throw-Activity-Designer.md)   
 [TryCatch](../WF_Design/TryCatch-Activity-Designer.md)