---
title: "Draw shapes and paths | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
ms.assetid: d5378c59-e2e5-49f0-91f1-aa82d984a33c
caps.latest.revision: 12
author: jillre
ms.author: jillfra
manager: jillfra
---
# Draw shapes and paths
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In XAML Designer, a *shape* is exactly what you’d expect. For example: a rectangle, circle, or ellipse. A *path* is a more flexible version of a shape. You can do things like reshape them or combine them together to form new shapes.

 Shapes and paths use vector graphics so they scale well to high resolution displays. If you want to learn more about vector graphics, see [What are Vector Graphics](https://www.youtube.com/watch?v=MoCSwF0n-io) or [vector graphics](https://www.webopedia.com/TERM/V/vector_graphics.html).

 **In this topic:**

- [Draw a shape](#Shape)

- [Draw a path](#Path)

- [Convert a shape to a path](#Convert)

- [Combine paths](#Combine)

- [Create a compound path](#Compound)

- [Create a clipping path](#Clipping)

## <a name="Shape"></a> Draw a shape
 You can find shapes in the **Assets** panel.

 ![Shapes category on the Assets panel](../designers/media/b4-shapes-assetspanel.png "b4_Shapes_AssetsPanel")

 Drag any shape that you want to the artboard. Then, you can use handles on the shape to scale, rotate, move, or skew the shape.

 ![](../designers/media/84261e83-3091-4490-ab58-4218b188439e.png "84261e83-3091-4490-ab58-4218b188439e")

## <a name="Path"></a> Draw a path
 A path is a series of connected lines and curves. Use a path to create interesting shapes that are not available in the **Assets** panel.

 You can draw a path by using a line, pen or pencil. You can find these tools in the **Tools** panel.

 ![](../designers/media/717956a8-b6a5-4e37-8af3-70bcfc78c82a.png "717956a8-b6a5-4e37-8af3-70bcfc78c82a") ![](../designers/media/8fbbbb21-be83-4cf6-903b-3a49f00c9860.png "8fbbbb21-be83-4cf6-903b-3a49f00c9860")

### Draw a straight line
 Use the **Pen** tool ![](../designers/media/894f8612-e0ed-4e00-84cf-a9bc8f38fc54.png "894f8612-e0ed-4e00-84cf-a9bc8f38fc54"), or the **Line** tool ![](../designers/media/eb618397-5283-48be-8396-3449be7b6fbf.png "eb618397-5283-48be-8396-3449be7b6fbf").

 **Using the Pen tool** ![](../designers/media/894f8612-e0ed-4e00-84cf-a9bc8f38fc54.png "894f8612-e0ed-4e00-84cf-a9bc8f38fc54")

 On the artboard, click once to define the start point, and then click again to define the end of the line.

 **Using the Line tool** ![](../designers/media/eb618397-5283-48be-8396-3449be7b6fbf.png "eb618397-5283-48be-8396-3449be7b6fbf")

 On the artboard, drag from where you want the line to start, and then release at the point where you want the line to end.

### Draw a curve
 Use the **Pen** tool ![](../designers/media/894f8612-e0ed-4e00-84cf-a9bc8f38fc54.png "894f8612-e0ed-4e00-84cf-a9bc8f38fc54").

 On the artboard, click once to define the start point of a line, and then click and drag your pointer to create the desired curve.

 If you want to close the path, click the first point on the line.

### Change the shape of a curve
 Use the **Direct selection** tool ![](../designers/media/6dd6571f-c116-451d-8dd2-1f88b8406362.png "6dd6571f-c116-451d-8dd2-1f88b8406362").

 Click the shape, and then drag any point on the shape to change curve shapes.

### Draw a free-form path
 Use the **Pencil** tool ![](../designers/media/509dc167-734f-46c9-b012-987ee63450cd.png "509dc167-734f-46c9-b012-987ee63450cd").

 On the artboard, draw a free-form path just as you would by using a real pencil.

### Remove part of a path
 Use the **Direct selection** tool ![](../designers/media/6dd6571f-c116-451d-8dd2-1f88b8406362.png "6dd6571f-c116-451d-8dd2-1f88b8406362").

 Select the path that contains the segment you want to delete, and then click the **Delete** button.

### Remove a point in a path
 Use the **Selection** tool  ![](../designers/media/2ff91340-477e-4efa-a0f7-af20851e4daa.png "2ff91340-477e-4efa-a0f7-af20851e4daa"), and the **Pen** tool ![](../designers/media/894f8612-e0ed-4e00-84cf-a9bc8f38fc54.png "894f8612-e0ed-4e00-84cf-a9bc8f38fc54").

 Use the **Selection** tool  ![](../designers/media/2ff91340-477e-4efa-a0f7-af20851e4daa.png "2ff91340-477e-4efa-a0f7-af20851e4daa") to select the path. Then, use the **Pen** tool ![](../designers/media/894f8612-e0ed-4e00-84cf-a9bc8f38fc54.png "894f8612-e0ed-4e00-84cf-a9bc8f38fc54") to click the point that you want to remove.

### Add a point to a path
 Use the **Selection** tool  ![](../designers/media/2ff91340-477e-4efa-a0f7-af20851e4daa.png "2ff91340-477e-4efa-a0f7-af20851e4daa"), and the **Pen** tool ![](../designers/media/894f8612-e0ed-4e00-84cf-a9bc8f38fc54.png "894f8612-e0ed-4e00-84cf-a9bc8f38fc54").

 Use the **Selection** tool  ![](../designers/media/2ff91340-477e-4efa-a0f7-af20851e4daa.png "2ff91340-477e-4efa-a0f7-af20851e4daa") to select the path. Use the **Pen** tool ![](../designers/media/894f8612-e0ed-4e00-84cf-a9bc8f38fc54.png "894f8612-e0ed-4e00-84cf-a9bc8f38fc54") to click anywhere on the path where you want to add the point.

## <a name="Convert"></a> Convert a shape to a path
 To modify a shape in the same ways that you modify a path, convert the shape to a path.

 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [Working with paths: Convert a shape to a path](https://www.youtube.com/watch?v=Io5bC0-nH6Q#t=147).

## <a name="Combine"></a> Combine paths
 You can combine paths and shapes into a single path.

 ![](../designers/media/2df17a5d-a338-4ef4-96c5-dae51cc1ca8a.png "2df17a5d-a338-4ef4-96c5-dae51cc1ca8a")

|||||
|-|-|-|-|
|![](../designers/media/b1-1.png "B1_1")|Two shapes before combining|![](../designers/media/b1-4.png "B1_4")|Intersect|
|![](../designers/media/b1-2.png "B1_2")|Unite|![](../designers/media/b1-5.png "B1_5")|Exclude Overlap|
|![](../designers/media/b1-3.png "B1_3")|Divide|![](../designers/media/b1-6.png "B1_6")|Subtract|

 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [Working with paths: Combine paths](https://www.youtube.com/watch?v=Io5bC0-nH6Q#t=195).

## <a name="Compound"></a> Create a compound path
 When you create a compound path, any intersecting parts of the paths are subtracted from the result, and the resulting path takes on the visual properties of the bottommost path.

 You can break apart a compound path any time after you create it.

 ![](../designers/media/2157a8aa-d9a7-4de4-8de5-b10d28f08a84.png "2157a8aa-d9a7-4de4-8de5-b10d28f08a84")

 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [Working with paths: Create a compound path](https://www.youtube.com/watch?v=Io5bC0-nH6Q).

## <a name="Clipping"></a> Create a clipping path
 A clipping path is a path or shape that is applied to another object, hiding the parts of the masked object that fall outside the clipping path.

 ![](../designers/media/22471e98-a841-4f39-a3ef-36090cf5a625.png "22471e98-a841-4f39-a3ef-36090cf5a625")

 **Watch a short video:** ![Configure Installed Features](../designers/media/bldadminconsoleinitialconfigicon.PNG "BldAdminConsoleInitialConfigIcon") [Working with paths: Create a clipping path](https://www.youtube.com/watch?v=Io5bC0-nH6Q#t=232).

## See Also
 [Creating a UI by using Blend for Visual Studio](../designers/creating-a-ui-by-using-blend-for-visual-studio.md)
