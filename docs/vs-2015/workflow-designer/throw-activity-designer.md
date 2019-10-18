---
title: "Throw Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.Activities.Statements.Throw.UI"
ms.assetid: 5e97c947-be39-4a1f-af04-000e2e09528a
caps.latest.revision: 4
author: jillre
ms.author: jillfra
manager: jillfra
---
# Throw Activity Designer
The **Throw** activity designer is used to create and configure a <xref:System.Activities.Statements.Throw> activity.

## The Throw Activity
 The <xref:System.Activities.Statements.Throw> activity throws an exception.

### Using the Throw Activity Designer
 The **Throw** activity designer can be found in the **Error Handling** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the left side of the [!INCLUDE[wfd2](../includes/wfd2-md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X.)

 The **Throw** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates a <xref:System.Activities.Statements.Throw> activity with a default **DisplayName** of Throw. The <xref:System.Activities.Activity.DisplayName%2A> value can be edited in the header of the **Throw** activity designer or in the **DisplayName** box of the property grid. The <xref:System.Activities.Statements.Throw.Exception%2A> property must be edited on the property grid.

### The Throw Properties
 The following table shows the <xref:System.Activities.Statements.Throw> properties and describes how they are used in the designer.

|Property Name|Required|Usage|
|-------------------|--------------|-----------|
|<xref:System.Activities.Activity.DisplayName%2A>|False|Specifies the optional friendly name of the <xref:System.Activities.Statements.Throw> activity. The default is Throw.|
|<xref:System.Activities.Statements.Throw.Exception%2A>|True|The exception to throw. This exception must derive from <xref:System.Exception>. To specify the exception, type a Visual Basic expression in the property grid.|

## See Also
 [Collection](../workflow-designer/collection-activity-designers.md)
 [Rethrow](../workflow-designer/rethrow-activity-designer.md)
 [Throw Activity Designer](../workflow-designer/throw-activity-designer.md)
 [TryCatch](../workflow-designer/trycatch-activity-designer.md)