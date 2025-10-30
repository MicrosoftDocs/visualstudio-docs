---
title: Draw & edit shapes and paths with XAML Designer in Blend
description: Draw paths and shapes and modify or combine the shapes and paths by using the features of the XAML Designer in Blend for Visual Studio.
titleSuffix: Blend for Visual Studio
ms.date: 07/11/2022
ms.topic: article
author: maddymontaquila
ms.author: maleger
manager: mijacobs
ms.subservice: xaml-tools
---
# Draw shapes and paths

In XAML Designer, a *shape* is exactly what you'd expect. For example: a rectangle, circle, or ellipse. A *path* is a more flexible version of a shape. You can do things like reshape them or combine them together to form new shapes.

Shapes and paths use vector graphics, so they scale well to high resolution displays.

## Draw a shape

Find shapes in the **Assets** window.

:::image type="content" source="media/blend-shapes.png" alt-text="Screenshot of the Shapes category of the Assets window in Blend for Visual Studio":::

Drag any shape that you want to the artboard. Then, use handles on the shape to scale, rotate, move, or skew the shape.

![Handles](../designers/media/84261e83-3091-4490-ab58-4218b188439e.png)

## Draw a path

A path is a series of connected lines and curves. Use a path to create interesting shapes that aren't available in the **Assets** window.

You can draw a path by using a line, pen or pencil. You can find these tools in the **Tools** window.

### Draw a straight line

Use the **Pen** tool or the **Line** tool.

**Using the Pen tool**

On the artboard, click once to define the start point, and then click again to define the end of the line.

**Using the Line tool**

On the artboard, drag from where you want the line to start, and then release at the point where you want the line to end.

### Draw a curve

Use the **Pen** tool.

On the artboard, click once to define the start point of a line, and then click and drag your pointer to create the desired curve.

If you want to close the path, click the first point on the line.

### Change the shape of a curve

Use the **Direct selection** tool.

Click the shape, and then drag any point on the shape to change curve shapes.

### Draw a free-form path

Use the **Pencil** tool.

On the artboard, draw a free-form path just as you would by using a real pencil.

### Remove part of a path

Use the **Direct selection** tool.

Select the path that contains the segment you want to delete, and then click the **Delete** button.

### Remove a point in a path

Use the **Selection** tool to select the path. Then, use the **Pen** tool to click the point that you want to remove.

### Add a point to a path

Use the **Selection** tool to select the path. Use the **Pen** tool to click anywhere on the path where you want to add the point.

## Convert a shape to a path

To modify a shape in the same ways that you modify a path, convert the shape to a path. Select the shape, and then select **Format** > **Path** > **Convert to Path**.

> [!NOTE]
> **Convert to Path** is not currently available for UWP apps that have a minimum `TargetPlatformVersion` of 10.0.16299.0 or later.

## Combine paths

You can combine paths and shapes into a single path.

![Combine paths](../designers/media/2df17a5d-a338-4ef4-96c5-dae51cc1ca8a.png)

|Number|Action|
|-|-|
|![Two shapes before combining](../designers/media/b1_1.png)|Two shapes before combining|
|![Unite](../designers/media/b1_2.png)|Unite|
|![Divide](../designers/media/b1_3.png)|Divide|
|![Intersect](../designers/media/b1_4.png)|Intersect|
|![Exclude overlap](../designers/media/b1_5.png)|Exclude Overlap|
|![Subtract](../designers/media/b1_6.png)|Subtract|

## Create a compound path

When you create a compound path, any intersecting parts of the paths are subtracted from the result, and the resulting path takes on the visual properties of the bottommost path.

You can break apart a compound path any time after you create it.

![Break a compound path](../designers/media/2157a8aa-d9a7-4de4-8de5-b10d28f08a84.png)

## Create a clipping path

A clipping path is a path or shape that is applied to another object, hiding the parts of the masked object that fall outside the clipping path.

![Clipping path](../designers/media/22471e98-a841-4f39-a3ef-36090cf5a625.png)
