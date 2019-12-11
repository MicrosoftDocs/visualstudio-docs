---
title: "How to: Model 3D Terrain"
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: f779b1fd-82a9-4a11-8ab7-c1c9caabc883
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Model 3D terrain

This article demonstrates how to use the Model Editor to create a 3D terrain model.

## Create a 3D terrain model

You can create a 3D terrain by subdividing a plane to make additional faces, and then manipulating their vertices to create interesting terrain features.

When you're finished, the model should look like this:

![3&#45;D scene that shows a terrain model](../designers/media/digit-terrain-model.png)

Before you begin, make sure that the **Properties** window and **Toolbox** are displayed.

1. Create a 3D model with which to work. For information about how to add a model to your project, see the Getting Started section in [Model editor](../designers/model-editor.md).

2. Add a plane to the scene. In the **Toolbox**, under **Shapes**, select **Plane** and move it to the design surface.

    > [!TIP]
    > To make the plane object easier to work with, you can frame it in the design surface. In **Select** mode, select the plane object, and then on the Model Editor toolbar, choose the **Frame Object** button.

3. Enter face selection mode. On the Model Editor toolbar, choose **Select Face**.

4. Subdivide the plane. In face selection mode, choose the plane once to activate it for selection, and then choose it again to select its only face. On the Model Editor toolbar, choose **Subdivide face**. This adds new vertices to the plane that split it into four equally sized partitions.

5. Create more subdivisions. With the new faces still selected, choose **Subdivide face** two more times. This creates a total of 64 faces. By creating more subdivisions, you can give the terrain even more detail.

6. Enter point selection mode. On the Model Editor toolbar, choose **Select Point**.

7. Modify a point to create a terrain feature. In point selection mode, select one of the points, and then on the Model Editor toolbar, choose the **Translate** tool. A box that represents the point appears on the design surface. Use the green arrow to move the box and thereby modify the height of the point. Repeat this step for different points to create interesting terrain features.

    > [!TIP]
    > You can select several points at once to modify them in a uniform manner.

The terrain model is complete. Here's the final model again, with Phong shading applied:

![3&#45;D scene that shows a terrain model](../designers/media/digit-terrain-model.png)

You can use this terrain model to demonstrate the effect of the gradient shader that's described in [How to: Create a geometry-based gradient shader](../designers/how-to-create-a-geometry-based-gradient-shader.md).

## See also

- [Model editor](../designers/model-editor.md)