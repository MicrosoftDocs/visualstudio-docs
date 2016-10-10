---
title: "Throw Activity Designer"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 5e97c947-be39-4a1f-af04-000e2e09528a
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
# Throw Activity Designer
The **Throw** activity designer is used to create and configure a <xref:System.Activities.Statements.Throw?qualifyHint=False> activity.  
  
## The Throw Activity  
 The <xref:System.Activities.Statements.Throw?qualifyHint=False> activity throws an exception.  
  
### Using the Throw Activity Designer  
 The **Throw** activity designer can be found in the **Error Handling** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the left side of the Workflow Designer (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)  
  
 The **Throw** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence?qualifyHint=False>. This creates a <xref:System.Activities.Statements.Throw?qualifyHint=False> activity with a default **DisplayName** of Throw. The <xref:System.Activities.Activity.DisplayName?qualifyHint=False> value can be edited in the header of the **Throw** activity designer or in the **DisplayName** box of the property grid. The <xref:System.Activities.Statements.Throw.Exception?qualifyHint=False> property must be edited on the property grid.  
  
### The Throw Properties  
 The following table shows the <xref:System.Activities.Statements.Throw?qualifyHint=False> properties and describes how they are used in the designer.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName?qualifyHint=False>|False|Specifies the optional friendly name of the <xref:System.Activities.Statements.Throw?qualifyHint=False> activity. The default is Throw.|  
|<xref:System.Activities.Statements.Throw.Exception?qualifyHint=False>|True|The exception to throw. This exception must derive from <xref:System.Exception?qualifyHint=False>. To specify the exception, type a Visual Basic expression in the property grid.|  
  
## See Also  
 [Collection](../WF_Design/Collection-Activity-Designers.md)   
 [Rethrow](../WF_Design/Rethrow-Activity-Designer.md)   
 [Throw Activity Designer](../WF_Design/Throw-Activity-Designer.md)   
 [TryCatch](../WF_Design/TryCatch-Activity-Designer.md)