---
title: "Edit UML models and diagrams | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
f1_keywords:
  - "vs.teamarch.modelingproject"
  - "vs.teamarch.UMLModelExplorer"
  - "vs.teamarch.UMLModelExplorer.rootnode"
helpviewer_keywords:
  - "diagrams - modeling"
  - "UML, copy and paste"
  - "UML, models"
  - "UML model"
  - "UML, element properties"
  - "UML"
  - "UML, diagrams"
ms.assetid: 87affd40-8127-4ee9-9d3a-ad977abe2ed6
caps.latest.revision: 86
author: jillre
ms.author: jillfra
manager: jillfra
---
# Edit UML models and diagrams
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can create and edit a UML model through the views provided by several different types of diagram. By providing different perspectives on your system, these diagrams help you understand and discuss different aspects of its design and requirements. Visual Studio provides templates for five of the most frequently used types of UML diagram.

 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

 This topic describes techniques for editing the model that are common among the different diagram types. For more information that is specific to particular types of diagrams, see [Create models for your app](../modeling/create-models-for-your-app.md).

## In this Topic

- [UML Diagrams are Views of a UML Model](#Views)

- [Creating UML Modeling Diagrams](#Creating)

- [Drawing UML Modeling Diagrams](#Drawing)

- [Editing Shapes and Connectors](#Editing)

- [Undoing Changes to the Model](#Undo)

- [Sharing Elements between Diagrams](#Sharing)

- [Copying Elements and Groups of Related Elements](#Copying)

- [Deleting a Model Element or its Views](#Deleting)

- [Searching text in a diagram](#Searching)

- [Preparing a Diagram for Presentation](#presentation)

- [Extending the UML Designers](#extensions)

## <a name="Views"></a> UML Diagrams are Views of a UML Model
 You can create and use UML diagrams only in modeling projects. For more information about how to create diagrams and projects, see [Create UML modeling projects and diagrams](../modeling/create-uml-modeling-projects-and-diagrams.md).

- A modeling project contains a single UML model. Every UML diagram in the project is a view of the UML model.

- You can see the model in **UML Model Explorer**. On the **Architecture** menu, point to **Windows**, and then click **UML Model Explorer**.

- Each shape on a diagram is a view of an element in the model. When you place a new shape on a diagram, you are creating a new element in the model.

- When you save any diagram, Visual Studio saves the whole model, all its diagrams, and the modeling project file.

## <a name="Creating"></a> Creating UML Modeling Diagrams

1. On the **Architecture** menu in Visual Studio, click **New UML or Layer Diagram**.

2. Select and name your diagram.

3. In **Add to modeling project**, select an existing modeling project, or select **Create a new modeling project**.

   > [!NOTE]
   > A modeling diagram must exist inside a modeling project.

   You can also add a diagram to an existing modeling project in Solution Explorer. Right-click the modeling project, point to **Add**, and then click **New Item**.

#### To create an empty UML modeling project

- On the **File** menu, point to **New**, click **Project**, and in the **New Project** dialog box, double-click **Modeling Projects**.

  For more information about how to manage modeling projects, see [Create UML modeling projects and diagrams](../modeling/create-uml-modeling-projects-and-diagrams.md).

## <a name="Drawing"></a> Drawing UML Modeling Diagrams
 A modeling diagram displays a collection of model elements linked by relationships. Each element is displayed as a shape and each relationship is displayed as a connector between two shapes.

 There are two kinds of tools, one for elements and one for relationships. For example, in the UML class diagram Toolbox, **Class** is an element tool, and **Association** is a relationship tool.

> [!NOTE]
> If you want information that is specific to particular diagram types, see [Create models for your app](../modeling/create-models-for-your-app.md).

#### To create elements and relationships in a UML modeling diagram

1. To create a model element, click an element tool in the Toolbox, and then click the diagram where you want it to appear. After you have created the element, adjust its size and shape by dragging its handles.

    In some cases, you can place a new element inside another element. For example, on a UML class diagram, you can place a class inside a Package.

   > [!NOTE]
   > If you cannot see the toolbox, click **Toolbox** on the **View** menu.

2. To create a relationship, click a relationship tool, click the element where you want the relationship to start, and then click the element where you want it to end.

    Different types of relationships can start or end on different types of elements. For example, on a UML class diagram, an Association relationship cannot start or end on a Comment element.

   > [!NOTE]
   > To use the same tool several times, double-click the tool. When you have finished, click the **Pointer** tool.

   On some kinds of diagrams, you can also draw simple shapes. These shapes are not part of the model, but you can use them to draw attention to parts of the diagram or to divide it into different areas.

## <a name="Editing"></a> Editing Shapes and Connectors
 When you resize or color a shape, or reroute a connector, there is no effect on the underlying model. However, when you rename a shape on the diagram or in the UML Model Explorer, the corresponding element is renamed in UML Model Explorer and in any other diagrams that present that element.

> [!NOTE]
> There is a simple way to make new toolbox items from which you can create groups of elements, or elements with your own choice of properties. For more information, see [Define a custom modeling toolbox item](../modeling/define-a-custom-modeling-toolbox-item.md).

 The following figure shows how to change the size of a shape or its name.

 ![Adjusting a model element](../modeling/media/uml-drawadjust1.png "UML_DrawAdjust1")

> [!TIP]
> The built-in commands do not include a command for neatly aligning shapes. However, you can easily create your own alignment command by copying the code in the example in [Display a UML model on diagrams](../modeling/display-a-uml-model-on-diagrams.md).

 The following figure shows how to adjust the route and position of a connector or its labels.

 ![Adjusting a connector](../modeling/media/uml-drawadjust2.png "UML_DrawAdjust2")

#### To move one end of a connector to another shape

1. Do one of the following:

   - Press **CTRL** and move the end.

     \- or -

   - Right-click the connector and then click **Reconnect**.

2. Click the end of the connector you want to move.

3. Click the shape that you want the connector to move to.

#### To change color or other properties of an element, relationship, or diagram

- Click the element and set the fields in the **Properties** window.

     If you cannot see the **Properties** window, right-click the element, and then click **Properties.**

#### To zoom in and out on a modeling diagram

- Press and hold the **CTRL** key while you rotate the mouse wheel.

     \- or -

- Press and hold **CTRL+SHIFT**, and then click the left or right mouse button.

     \- or -

- On the **Architecture Designers** toolbar, click the plus sign (**+**) or minus sign (**-**), or choose a zoom level.

## <a name="Searching"></a> Searching in a Diagram
 The Quick Find function will find items on a diagram. You must set **Look in:** to **Current Document**.

#### To search for text in a modeling diagram

1. Press **CTRL+F**.

     \- or -

     On the **Edit** menu, point to **Find and Replace**, and then click **Quick Find**.

    > [!NOTE]
    > In the **Find and Replace** dialog box, you must leave the **Look in** field set to **Current Document**. The other options are not supported.

2. Type the text that you want to find, and then click **Find Next**.

    > [!NOTE]
    > If the text you want to find is inside a collapsed shape, the shape will be highlighted. Expand the shape, and then click **Find Next** again.

## <a name="Undo"></a> Undoing Changes to the Model
 You can undo and redo changes that you have made to the model and diagrams by using the **Undo** and **Redo** commands on the **Edit** menu.

 **Each modeling project has a single stack of changes.** All changes that you make to the model and the diagrams are kept on this stack. The stack also includes changes of focus from one diagram to another. The Undo command reverses the changes on this stack.

 For example, let's say that you perform these operations: Make a change to Diagram1; change focus to Diagram 2; change Diagram2. When you undo changes, the first undo will reverse the last change; the next undo will shift focus back to Diagram 1; and the third undo will reverse the change to Diagram 1.

 **Closing a diagram truncates the stack of changes.** If you close a diagram, you cannot undo the changes that you performed in that diagram, and you cannot undo earlier changes to the model or any of its diagrams.

 **You cannot undo while you are editing a property.** While you are editing a property in the Properties window, or in a label on a diagram, you can only undo changes that you have made in that property. Complete your change in the property by pressing ENTER, or cancel it by pressing ESC. You will then be able to undo changes in the model and diagrams.

 **Closing a diagram without saving might not have the effect you expect.** If you make some changes, and then close a diagram without saving it, your changes will still be preserved in the model. It is recommended to close the whole model if you want to do so without saving it.

## <a name="Sharing"></a> Sharing Elements between Diagrams
 You can make a specific instance of a model element appear more than once in your diagrams. This applies to classes, interfaces, components, use cases, and actors.

 This is useful if you want to show different groups of relationships in different diagrams. For example, on one diagram, you could show the associations between the Customer and Address classes. On another diagram, you could show the Address class again, with its association to Postal Area.

 You can change the properties of a model element, such as its name, by selecting any of its views on any diagram, or by selecting it in UML Model Explorer.

 Each kind of diagram can only show some kinds of model element. For example, you cannot show a use case on a component diagram. Therefore, the following procedures will work only for some combinations of model element and diagram.

#### To add a new view of a model element by using UML Model Explorer

1. To open **UML Model Explorer**, on the **Architecture** menu, point to **Windows**, and then click **UML Model Explorer**.

2. Drag the model element from **UML Model Explorer** to a compatible diagram in the same project.

     A shape providing a view of the model element appears, which may be in addition to the views on other diagrams or on the same diagram.

    > [!NOTE]
    > The effect is different when you drag a class or component onto a sequence diagram. In that case, a new lifeline is created whose type is that class or component. For more information, see [UML Sequence Diagrams: Guidelines](../modeling/uml-sequence-diagrams-guidelines.md).

#### To add a new view of a model element by using Paste Reference

1. Right-click an existing element, and then click **Copy**.

    - You can copy several elements at the same time. Hold down the CTRL key while you click each element, right-click one of them, and then click **Copy**.

2. Right-click an empty part of a compatible diagram, and then click **Paste Reference**.

     Another view of the same element appears.

    > [!NOTE]
    > This differs from the **Paste** command, which creates a new element in the model. For more information, see [Copying Elements and Groups of Related Elements](#Copying).

> [!NOTE]
> If you add to a diagram views of two model elements that are already connected by a relationship, a view of the relationship will also appear on the diagram. You can delete this view only by removing one of the elements from the diagram, or by deleting the relationship from the model.

## <a name="Copying"></a> Copying Elements and Groups of Related Elements
 You can copy and paste model elements, and you can copy and paste groups of elements together with the relationships between them.

> [!NOTE]
> The **Paste** and **Paste Reference** commands have different effects. **Paste** creates new elements whose properties are like those of the copied elements. **Paste Reference** creates new views of the same elements.

#### To copy elements and their relationships

1. In the diagram with the elements that you want to copy, select one or more elements.

    > [!NOTE]
    > You cannot copy relationships except as part of a group of elements.

2. On the **Edit** menu, click **Copy**.

3. If you want to copy the elements to another diagram, create the new diagram or open the existing diagram.

4. On the **Edit** menu, click **Paste**.

    - Copies of the elements appear, together with copies of any relationships that link between them.

    - Each new element will have a new automatically generated name.

5. Adjust the positions, names, and other properties of the new elements and relationships.

> [!NOTE]
> You cannot copy a model element from one model to another, for example if you have two models in the same solution. But you can copy elements from one diagram to another.

#### To copy an entire diagram

1. Create a new diagram.

2. Select all the elements in an existing diagram, copy them, and paste them into the new one.

   You cannot replicate a diagram by copying and pasting in Solution Explorer.

## <a name="Deleting"></a> Deleting a Model Element or its Views
 Some kinds of elements, specifically classifiers, can be removed from a diagram without deleting them from the model. Classifiers are the major elements that are displayed on class diagrams, component diagrams, and use case diagrams. They can appear on more than one diagram. For these types of elements, there are two separate commands: **Remove from Diagram** and **Delete from Model**.

 By contrast, when you delete a relationship from a diagram, you are always deleting it from the model.

> [!NOTE]
> Certain kinds of elements on a UML diagram have labels. When you select such elements by drawing a rectangle around them, it is possible to select the labels but not the elements that own those labels. Deleting a subset of elements that are selected in this way is not supported. To select a subset of these elements, press and hold the **CTRL** key while you click each element.

#### To remove a classifier's view from a diagram

- Right-click the element on the diagram, and then click **Remove from Diagram**.

  \- or -

- Click the element on the diagram and then press the **DELETE** key.

  - This view of the element vanishes. However, the element remains in the model, and you can still find it in **UML Model Explorer**. Any other views of the same element also remain.

  - Every connector that terminates at this shape is removed from the diagram, but the relationship it represents remains in the model. You can see the relationship in **UML Model Explorer** under **Relationships**, under each element that it connects.

#### To delete an element from the model

- Right-click the element either in **UML Model Explorer** or on a diagram, and then click **Delete from Model**.

  - The element is deleted from every diagram on which it appears.

  - Every relationship that terminates at this element is also deleted from the model.

#### To delete a relationship from the model

- Right-click the relationship on a diagram or in **UML Model Explorer**, and then click **Delete from Model**.

    > [!CAUTION]
    > You cannot remove a relationship from a diagram without removing it from the model.

     The relationship is deleted from the model and is deleted from every diagram on which it appears.

## <a name="presentation"></a> Preparing a Diagram for Presentation
 The following features help you to draw attention to particular parts of your diagram, add explanations, or divide a diagram into different areas of interest.

- You can copy any part of a diagram into a Word, PowerPoint, or other document. Select the shapes and connectors you want, right-click and then click **Copy**.

- The color of any shape or connector can be changed. Select one or more shapes and change the **Color** property. If you cannot see the **Properties** window, press **F4**.

- On diagrams of some kinds, you can draw lines, rectangles and ellipses from the **Simple Shapes** section of the Toolbox. These shapes do not form part of the UML model.

- To label an area, you can drag a Comment from the Toolbox and then set its **Transparent** property to **True**. Like Simple Shapes, comments do not form part of the UML model and do not appear in UML Model Explorer.

- To add notes and explanations to model elements, you can create comments and then link them to the elements.

### To export a diagram as an image
 For more information, see [Export diagrams as images](../modeling/export-diagrams-as-images.md).

## <a name="extensions"></a> Extending the UML Designers
 You can add new functionality to the UML tools and adapt the diagram notation to your own needs. For more information, see [Extend UML models and diagrams](../modeling/extend-uml-models-and-diagrams.md).

## See Also
 [Create UML modeling projects and diagrams](../modeling/create-uml-modeling-projects-and-diagrams.md)
 [Analyzing and Modeling Architecture](../modeling/analyze-and-model-your-architecture.md)
 [Create models for your app](../modeling/create-models-for-your-app.md)
