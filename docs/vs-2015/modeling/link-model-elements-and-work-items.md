---
title: "Link model elements and work items | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
f1_keywords:
  - "vs.teamarch.common.removeworkitemsdialog"
  - "vs.teamarch.common.linkworkitemsdialog"
helpviewer_keywords:
  - "UML - extending, linking to TFS work items"
  - "UML - extending, linking work items"
  - "work items, creating from UML models"
  - "UML model, creating work items"
  - "work items, linking to UML models"
  - "UML model, linking work items"
ms.assetid: e687a490-0f93-412c-a1ff-eea83cf7ba07
caps.latest.revision: 49
author: jillre
ms.author: jillfra
manager: jillfra
---
# Link model elements and work items
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Track tasks, test cases, bugs, requirements, issues, and other work related to your model by linking model elements in Visual Studio and work items in Team Foundation Server or Visual Studio Team Services. Attach documents to linked work items to associate them with model elements.

 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

> [!NOTE]
> You must use Team Explorer to create and open links. Make sure your modeling project and diagrams are checked into version control so that others can open linked diagrams.

 For example, you can link:

- A user story work item and an activity diagram to show how to realize the story as a sequence of operations

- A use case on a use case diagram and test case work items to make sure the use case is implemented correctly

- An attribute in a class on a UML class diagram and a bug work item to show an error in the implementation of the attribute

- A component on a component diagram and a task work item to track the component's development. Such a task is usually broken into smaller tasks

  You can link work items to any element that you can select on modeling diagrams or in UML Model Explorer, like these items:

- All elements in UML models, such as UML classes, lifelines, use cases, subsystems, activities, object nodes, components, interfaces

- All relations in UML models, such as associations, generalizations, dependencies, flows, messages

- Parts of elements, such as the attributes and operations of classes, the execution occurrences of lifelines, the input and output pins of activities, and the parts and ports of components

- Layers and layer dependencies

- Comments and comment links

- Diagrams. To select a diagram, choose a blank part of the diagram.

> [!WARNING]
> You must already be connected to TFS Source Code Control (SCC) to create or link to a work item. If you try to open a connection to a different TFS SCC, Visual Studio closes the current solution automatically. Ensure that you are already connected to the appropriate SCC before attempting to create or link to a work item. In later releases of Visual Studio, the menu commands are not available if you are not connected to an SCC.

- [Connect to a team project](#ConnectTFS)

- [Link a model element to a new work item](#LinkNew)

- [Link a model element to an existing work item](#LinkExisting)

- [View work items linked to a model element](#OpenWorkItem)

- [View model elements linked to a work item](#ViewLinkedModels)

- [Delete links between model elements and work items](#RemoveLinks)

- [Troubleshooting](#Troubleshooting)

## <a name="ConnectTFS"></a> Connect to a team project
 You must first connect to your team project to create, view, or remove links.

1. On the **Team** menu, choose **Manage Connections** to show the Team Explorer window.

2. If the correct project doesn't appear, in Team Explorer, choose **Manage Connections** and then choose **Connect to Team Project**. Then choose the correct projects, or server if necessary.

3. In **Team Explorer**, choose the project where you want to create, link, or view work items.

## <a name="LinkNew"></a> Link a model element to a new work item

1. Make sure you are connected to the TFS instance you want to use.

2. On the modeling diagram or in **UML Model Explorer**, open the shortcut menu for the model element.

3. Choose **Create Work Item** and the kind of work item that you want to create.

4. In the work item form, fill in the fields. Choose **Save Work Item**.

     Visual Studio links the model element to the new work item. An icon appears on or near the model element.

> [!WARNING]
> You must already be connected to TFS Source Code Control (SCC) to create or link to a work item. If you try to open a connection to a different TFS SCC, Visual Studio closes the current solution automatically. Ensure that you are already connected to the appropriate SCC before attempting to create or link to a work item. In later releases of Visual Studio, the menu commands are not available if you are not connected to an SCC.

## <a name="LinkExisting"></a> Link a model element to an existing work item
 When you link model elements to work items, start from the model element, not from the work item.

1. Make sure you are connected to the TFS instance you want to use.

2. On the modeling diagram or in **UML Model Explorer**, open the shortcut menu for the model element. Choose **Link to Work Item**. Then select your project in the **Project** field.

3. Choose one or more work items to link to the model element by following one of these steps:

    - Choose a query in **Saved Query**.

    - Type the IDs of one or more work items, separated by spaces, in **IDs**.

    - Type a word or phrase in **Title Contains**.

4. Choose **Find**.

5. In the work item list, select the work item or work items that you want to link.

     When you're done, the **Work Items** property of the model element shows a larger number than before. An icon also appears on or near the model element.

> [!WARNING]
> You must already be connected to TFS Source Code Control (SCC) to create or link to a work item. If you try to open a connection to a different TFS SCC, Visual Studio closes the current solution automatically. Ensure that you are already connected to the appropriate SCC before attempting to create or link to a work item. In later releases of Visual Studio, the menu commands are not available if you are not connected to an SCC.

## <a name="OpenWorkItem"></a> View work items linked to a model element

1. In **Team Explorer**, make sure you're connected to the team project where the work items are linked to the model element.

2. On the modeling diagram or in **UML Model Explorer**, open the shortcut menu for the model element. Choose **View Work Items** to view the list of linked work items.

    > [!NOTE]
    > Only work items from the currently connected server appear. If you don't see any work items, make sure you're connected to the correct server in **Team Explorer**.

## <a name="ViewLinkedModels"></a> View model elements linked to a work item
 You can view modeling diagrams and elements that are linked to a work item in Visual Studio Team Services and in Team Foundation Server 2012 or later. For example, a work item might be linked to class models that show the design of new classes to be implemented.

1. In **Team Explorer**, make sure you're connected to the team project where the model elements are linked to the work item.

    > [!NOTE]
    > You can only use Team Explorer, not Team Web Access, to view linked model elements. Make sure your workspace is mapped to the modeling project that contains the modeling diagrams or elements. If you don't have a workspace, you must create it. See [Troubleshooting](#Troubleshooting) and [Create and work with workspaces](https://msdn.microsoft.com/library/1d7f6ed8-ec7c-48f8-86da-9aea55a90d5a).

2. Open the work item, choose **Links**. Under **Model Link**, open the shortcut menu for the linked model element. Choose **Open Linked Item**.

     ![Open linked model element from a work item](../modeling/media/workitem-openlinkedmodelelement.png "WorkItem_OpenLinkedModelElement")

## <a name="RemoveLinks"></a> Delete links between model elements and work items
 Remove a linked work item by starting from the model element. This correctly removes the reciprocal link to that model element from the work item. Otherwise, if you start with the work item, the reciprocal link from the model element to the work item won't be deleted.

1. On the modeling diagram or in **UML Model Explorer**, open the shortcut menu for the model element.

2. Choose **Remove Work Items**.

     \- or -

    1. Choose **Properties**, then **Work Items** where the number of linked work items appears.

    2. In the **Work Items** property, choose the ellipsis button **[…]**.

        > [!NOTE]
        > Only work items on the current server appear. If the list is empty, but the number of work items is not zero, make sure you are connected to the correct server in **Team Explorer**.

3. Under **Remove Links to Work Items**, clear the selected items that you want to unlink. Choose **OK**.

## <a name="Troubleshooting"></a> Troubleshooting

|**Issue**|**Possible cause**|**Resolution**|
|---------------|------------------------|--------------------|
|Can't find the model element that you want to link.|The element might be on a diagram in a modeling project that is in [!INCLUDE[esprscc](../includes/esprscc-md.md)]. You might not have a workspace that maps to the diagram.|Map your workspace to the modeling project and diagram. If you do not have a workspace, then you must create it.<br /><br /> The error message that appears for this issue contains the path that you can use to map your workspace.<br /><br /> See [Create and work with workspaces](https://msdn.microsoft.com/library/1d7f6ed8-ec7c-48f8-86da-9aea55a90d5a).|
|Can't find the linked model element.|The linked element might be on a diagram that has been moved, renamed, or deleted.|1.  In the work item, delete the link to the model element.<br />2.  Create a new link from the work item to the model element.|
|The work item doesn't have the linked model elements that you expect.|A work item shows a linked layer element only if the link was created from the work item. If your team does not use [!INCLUDE[esprscc](../includes/esprscc-md.md)], the local path of the diagrams will be used to create the links. If the modeling project and its diagrams are in [!INCLUDE[esprscc](../includes/esprscc-md.md)], all team members who can access the project can view linked elements in work items.|Try refreshing the work item.|
|Deleting a link to a model element from a work item doesn't delete the link from the model element to the work item.||Delete the link to the work item starting from the model element.|

## See Also
 [Edit UML models and diagrams](../modeling/edit-uml-models-and-diagrams.md)
 [Create models for your app](../modeling/create-models-for-your-app.md)
