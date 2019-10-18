---
title: "Persist Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords: 
  - "System.Activities.Statements.Persist.UI"
ms.assetid: be8648dd-3eb9-4a50-8ec1-57a8be804692
caps.latest.revision: 6
author: gewarren
ms.author: gewarren
manager: jillfra
---
# Persist Activity Designer
The **Persist** activity designer is used to create and configure a <xref:System.Activities.Statements.Persist> activity.  
  
## The Persist Activity  
 The <xref:System.Activities.Statements.Persist> activity saves a workflow to disk, if possible. The <xref:System.Activities.Statements.Persist> activity cannot be executed in a non-persistence zone as, for example, within a <xref:System.Activities.Statements.TransactionScope> activity. If you do use a <xref:System.Activities.Statements.Persist> activity in a non-persistence scope, an exception is thrown at runtime.  
  
### Using the Persist Activity Designer  
 The **Persist** activity designer can be found in the **Runtime** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab (Alternatively, select **Toolbox** from the **View** menu or CTRL+ALT+X.)  
  
 The **Persist** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates a <xref:System.Activities.Statements.Persist> activity with a default **DisplayName** of Persist. The <xref:System.Activities.Activity.DisplayName%2A> can be edited in the header of the **Persist** activity designer or in the **DisplayName** box of the property grid.  
  
### The Persist Properties  
 The following table shows the <xref:System.Activities.Statements.Persist> properties and describes how they are used in the designer. These properties can be edited in property grid and some of them can be edited on [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.Activities.Statements.Persist> activity. The default is Persist. Although the display name is not strictly required, it is a best practice to use a display name.|  
  
## See also  
 [Runtime](../workflow-designer/runtime-activity-designers.md)   
 [TerminateWorkflow](../workflow-designer/terminateworkflow-activity-designer.md)