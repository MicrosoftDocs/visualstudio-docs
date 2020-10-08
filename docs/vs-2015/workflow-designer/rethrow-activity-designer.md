---
title: "Rethrow Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.Activities.Statements.Rethrow.UI"
ms.assetid: 9cfa2eda-395f-4cf3-9154-83fadd4f7452
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# Rethrow Activity Designer
The **Rethrow** activity designer is used to create and configure a <xref:System.Activities.Statements.Rethrow> activity.

## The Rethrow Activity
 The <xref:System.Activities.Statements.Rethrow> activity throws a previously thrown exception. This activity can only be used in a <xref:System.Activities.Statements.Catch> handler in the <xref:System.Activities.Statements.TryCatch> activity.

### Using the ReThrow Activity Designer
 The **Rethrow** activity designer can be found in the **Error Handling** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the left side of the [!INCLUDE[wfd2](../includes/wfd2-md.md)] (Alternatively, select **Toolbar** from the **View** menu or CTRL+ALT+X.)

 The **Rethrow** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates a <xref:System.Activities.Statements.Rethrow> activity with a default **DisplayName** of Throw. The <xref:System.Activities.Activity.DisplayName%2A> value can be edited in the header of the **Rethrow** activity designer or in the **DisplayName** box of the property grid.

### The Rethrow Properties
 The following table shows the <xref:System.Activities.Statements.Rethrow> properties and describes how they are used in the designer.

|Property Name|Required|Usage|
|-------------------|--------------|-----------|
|<xref:System.Activities.Activity.DisplayName%2A>|False|Specifies the optional friendly name of the <xref:System.Activities.Statements.Rethrow> activity. The default is Rethrow.|

## See Also
 [Collection](../workflow-designer/collection-activity-designers.md)
 [Throw](../workflow-designer/throw-activity-designer.md)
 [TryCatch](../workflow-designer/trycatch-activity-designer.md)