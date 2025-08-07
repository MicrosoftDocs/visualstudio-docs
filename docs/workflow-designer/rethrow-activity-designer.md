---
title: Workflow Designer - Rethrow Activity Designer
description: Learn about the Rethrow activity and how to use the Rethrow activity designer to create and configure a Rethrow activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- System.Activities.Statements.Rethrow.UI
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Rethrow Activity Designer

The **Rethrow** activity designer is used to create and configure a <xref:System.Activities.Statements.Rethrow> activity.

## The Rethrow activity

The <xref:System.Activities.Statements.Rethrow> activity throws a previously thrown exception. This activity can only be used in a <xref:System.Activities.Statements.Catch> handler in the <xref:System.Activities.Statements.TryCatch> activity.

### Use the ReThrow Activity Designer

Access the **Rethrow** activity designer in the **Error Handling** category of the **Toolbox**. The **Rethrow** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. Dropping the activity designer creates a <xref:System.Activities.Statements.Rethrow> activity with a default **DisplayName** of Throw. The <xref:System.Activities.Activity.DisplayName%2A> value can be edited in the header of the **Rethrow** activity designer, or in the **DisplayName** box of the property grid.

### The Rethrow properties

The following table shows the <xref:System.Activities.Statements.Rethrow> properties, and describes how they're used in the designer:

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|Specifies the optional friendly name of the <xref:System.Activities.Statements.Rethrow> activity. The default is Rethrow.|

## See also

- [Collection](../workflow-designer/collection-activity-designers.md)
- [Throw](../workflow-designer/throw-activity-designer.md)
- [TryCatch](../workflow-designer/trycatch-activity-designer.md)
