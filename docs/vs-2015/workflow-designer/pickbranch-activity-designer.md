---
title: "PickBranch Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "System.Activities.Statements.PickBranch.UI"
ms.assetid: f523ad47-bbc0-4cda-a35c-41e67c4ba081
caps.latest.revision: 10
author: jillre
ms.author: jillfra
manager: jillfra
---
# PickBranch Activity Designer
The <xref:System.Activities.Statements.PickBranch> provides an event-based path of execution within a <xref:System.Activities.Statements.Pick> activity that can be triggered by an incoming event.

## PickBranch
 <xref:System.Activities.Statements.PickBranch> objects are contained in the <xref:System.Activities.Statements.Pick.Branches%2A> collection of a <xref:System.Activities.Statements.Pick> activity. Each <xref:System.Activities.Statements.PickBranch> is contained in a branch of the <xref:System.Activities.Statements.Pick> activity and can be executed due to some incoming event that serves as a trigger. In this way the [!INCLUDE[wfd1](../includes/wfd1-md.md)] provides event-based control flow modeling. Each <xref:System.Activities.Statements.PickBranch> contains a <xref:System.Activities.Statements.PickBranch.Trigger%2A> and an <xref:System.Activities.Statements.PickBranch.Action%2A>.

### How to use the Pick Activity Designer
 The **PickBranch** designer can be found in the **Control Flow** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on [!INCLUDE[wfd2](../includes/wfd2-md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTRL+ALT+X).

 Two empty <xref:System.Activities.Statements.PickBranch> objects with display names of **Branch1** and **Branch2** are created by default as elements of a <xref:System.Activities.Statements.Pick> activity when the **Pick** activity designer is initially dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)]. These respective <xref:System.Activities.Statements.PickBranch.DisplayName%2A> property values can be edited in the **PickBranch** designer header or within the **Properties** window for each branch.

 There are two ways to add <xref:System.Activities.Statements.PickBranch> objects to the collection of a <xref:System.Activities.Statements.Pick> object: dragging and dropping the **PickBranch** designer from the **Toolbox** or by using the context menu from within the **Pick** design surface:

1. The **PickBranch** designer creates a <xref:System.Activities.Statements.PickBranch> when it is dragged from the **Toolbox** and dropped into one of the branches of a **Pick** activity designer on the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface. The new <xref:System.Activities.Statements.PickBranch> objects can be placed inside the <xref:System.Activities.Statements.Pick> designer to the left or right of any existing <xref:System.Activities.Statements.PickBranch> elements already contained in the collection. When dragging a **PickBranch** designer onto the **Pick** designer with a mouse, the **Pick** designer uses a vertical blue-gray band to indicate where the <xref:System.Activities.Statements.PickBranch> is added for a given mouse placement.

2. Right click **Pick** activity designer (but not inside **PickBranch** designer) to obtain a context menu and select **Create Branch** to add a new <xref:System.Activities.Statements.PickBranch>. Notice that the new <xref:System.Activities.Statements.PickBranch> is added to the right of the existing <xref:System.Activities.Statements.PickBranch> objects in the **Pick** designer.

   The **PickBranch** designer can be expanded to reveal the **Trigger** and **Action** boxes or collapsed by clicking the double carets on the right side of their headers. Edit the <xref:System.Activities.Statements.PickBranch.Trigger%2A> and <xref:System.Activities.Statements.PickBranch.Action%2A> of each <xref:System.Activities.Statements.PickBranch> by dropping activities into the **Trigger** and **Action** boxes of their designers.

   The <xref:System.Activities.Statements.PickBranch> objects in the <xref:System.Activities.Statements.Pick.Branches%2A> collection of a <xref:System.Activities.Statements.Pick> object, can be reordered by dragging and dropping them to a new location within the **Pick** designer. The **Pick** designer uses a vertical blue-gray band to indicate where the <xref:System.Activities.Statements.PickBranch> is added for a given mouse placement.

   There are two ways to delete a <xref:System.Activities.Statements.PickBranch>:

3. Select the **PickBranch** designer and delete it.

4. Select the **PickBranch** designer, right-click to obtain the context menu and select **Delete**.

   Be sure to select the **PickBranch** designer, as selecting one of the activities inside its **Trigger** or **Action** boxes by mistake deletes one of those activities and not the <xref:System.Activities.Statements.PickBranch> object.

### PickBranch Properties in the Workflow Designer
 The following table shows the most useful <xref:System.Activities.Statements.PickBranch> properties and describes how to use them in the [!INCLUDE[wfd2](../includes/wfd2-md.md)].

|Property Name|Required|Usage|
|-------------------|--------------|-----------|
|<xref:System.Activities.Statements.PickBranch.DisplayName%2A>|False|The friendly name displayed on the header of the **PickBranch** designer. The default value is Branch.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it is a best practice to use one.|
|<xref:System.Activities.Statements.PickBranch.Trigger%2A>|True|Each <xref:System.Activities.Statements.PickBranch> contains a <xref:System.Activities.Statements.PickBranch.Trigger%2A> action that can invoke the <xref:System.Activities.Statements.PickBranch.Action%2A>.|
|<xref:System.Activities.Statements.PickBranch.Action%2A>|False|Each <xref:System.Activities.Statements.PickBranch> contains an <xref:System.Activities.Statements.PickBranch.Action%2A> that is executed if triggered.|

## See Also
 [Control Flow](../workflow-designer/control-flow-activity-designers.md)
 [Pick Activity](https://msdn.microsoft.com/library/b3e49b7f-0285-4720-8c09-11ae18f0d53e)
 [Using the Pick Activity](https://msdn.microsoft.com/library/b89be812-a247-4025-b0e3-ffb20db027a6)