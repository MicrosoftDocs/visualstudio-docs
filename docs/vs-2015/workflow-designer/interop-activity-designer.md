---
title: "Interop Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.Activities.Statements.Interop.UI"
ms.assetid: 800a3403-ba86-41c4-8de1-c4fee9703eb1
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# Interop Activity Designer
The **Interop** activity designer is used to create and configure an <xref:System.Activities.Statements.Interop> activity.

## The Interop Activity
 The <xref:System.Activities.Statements.Interop> activity manages the execution of types that derive from <xref:System.Workflow.ComponentModel.Activity?displayProperty=fullName> within a workflow.

### Using the Interop Activity Designer
 The **Interop** activity designer can be found in the **Migration** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab (Alternatively, select **Toolbox** from the **View** menu or CTRL+ALT+X.)

 The [Migration](../workflow-designer/migration-activity-designers.md) category that contains the <xref:System.Activities.Statements.Interop> activity only shows up in the **Toolbox** if your project is targeting the full [!INCLUDE[netfx40_long](../includes/netfx40-long-md.md)].

 For C# projects, you can re-target the project to use the full [!INCLUDE[netfx40_short](../includes/netfx40-short-md.md)] by right-clicking the project in the **Solution Explorer** and selecting **Properties**. On the **Application** tab, select the **NET Framework 4** option in the **Target framework**. Select the **Yes** button in the **Target Framework Change** dialog that displays asking you to confirm this change.

 For VB projects, you can re-target the project to use the full [!INCLUDE[netfx40_short](../includes/netfx40-short-md.md)] by right-clicking on the project in the **Solution Explorer** and selecting **Properties**. On the **Compile** tab, click the **Advanced Compile Options** button. Select **.Net Framework 4** from the **Target framework list** and then click **OK**. Click the **Yes** button in the **Target Framework Change** dialog that displays asking you to confirm this change.

 The **Interop** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates an <xref:System.Activities.Statements.Interop> activity with a default **DisplayName** of Interop. The <xref:System.Activities.Activity.DisplayName%2A> can be edited in the header of the **Interop** activity designer or in the **DisplayName** box of the property grid.

 Click the **Click to browse…** text in the **ActivityType** box, either on the **Interop**  activity designer or in the property grid, to bring up the **Browse and Select a .Net Type** dialog box. Only types for workflow 3.0 or workflow 3.5 activities are shown (that is, only types derived from <xref:System.Workflow.ComponentModel.Activity>). [!INCLUDE[crabout](../includes/crabout-md.md)] using this box to specify a type, see the [Browse and Select a .NET Type Dialog Box](../workflow-designer/browse-and-select-a-dotnet-type-dialog-box.md) topic.

### The Interop Properties
 The following table shows the <xref:System.Activities.Statements.Interop> properties and describes how they are used in the designer. These properties can be edited in property grid or on the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface.

|Property Name|Required|Usage|
|-------------------|--------------|-----------|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.Activities.Statements.Interop> activity. The default is Interop. Although the display name is not strictly required, it is a best practice to use a display name.|
|<xref:System.Activities.Statements.Interop.ActivityType%2A>|True|Specifies the type of the activity contained by the <xref:System.Activities.Statements.Interop> activity. This type specified must derive from <xref:System.Workflow.ComponentModel.Activity>.|

## See Also
 [Migration](../workflow-designer/migration-activity-designers.md)