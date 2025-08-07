---
title: "Workflow Designer - Interop Activity Designer"
description: Learn about the Interop activity designer and how you can use the Interop activity designer to create and configure an Interop activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "System.Activities.Statements.Interop.UI"
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Interop Activity Designer

The **Interop** activity designer is used to create and configure an <xref:System.Activities.Statements.Interop> activity.

## The Interop Activity

The <xref:System.Activities.Statements.Interop> activity manages the execution of types that derive from <xref:System.Workflow.ComponentModel.Activity?displayProperty=fullName> within a workflow.

### Use the Interop Activity Designer

The **Interop** activity designer can be found in the **Migration** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab. Alternatively, select **Toolbox** from the **View** menu, or press **Ctrl**+**Alt**+**X**.

The [Migration](../workflow-designer/migration-activity-designers.md) category that contains the <xref:System.Activities.Statements.Interop> activity only appears in **Toolbox** if your project targets .NET Framework 4 (full) or later. If necessary, you can change the framework version that your project targets.

The **Interop** activity designer can be dragged from **Toolbox** and dropped onto the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. Dropping the **Interop** activity designer creates an <xref:System.Activities.Statements.Interop> activity with a default **DisplayName** of Interop. You can edit the <xref:System.Activities.Activity.DisplayName%2A> in the header of the **Interop** activity designer, or in the **DisplayName** box of the property grid.

Click the **Click to browse** text in the **ActivityType** box, either on the **Interop**  activity designer or in the property grid, to open the **Browse and Select a .NET Type** dialog box. Only types for workflow 3.0 or workflow 3.5 activities are shown. That is, only types derived from <xref:System.Workflow.ComponentModel.Activity> are shown. For more information about using this box to specify a type, see [Browse and Select a .NET Type Dialog Box](../workflow-designer/browse-and-select-a-dotnet-type-dialog-box.md).

### The Interop Properties

The following table shows the <xref:System.Activities.Statements.Interop> properties, and describes how they are used in the designer. These properties can be edited in property grid or on the Workflow Designer surface.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.Activities.Statements.Interop> activity. The default value is **Interop**. Although the display name is not required, it's recommended to provide one.|
|<xref:System.Activities.Statements.Interop.ActivityType%2A>|True|Specifies the type of the activity contained by the <xref:System.Activities.Statements.Interop> activity. This type specified must derive from <xref:System.Workflow.ComponentModel.Activity>.|

## See also

- [Migration](../workflow-designer/migration-activity-designers.md)