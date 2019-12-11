---
title: "How to: Create a Basic Color Shader"
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: c301328a-079a-49e8-b688-4749c01657c0
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Create a basic color shader

This article demonstrates how to use the Shader Designer and the Directed Graph Shader Language (DGSL) to create a flat color shader. This shader sets the final color to a constant RGB color value.

## Create a flat color shader

You can implement a flat color shader by writing the color value of an RGB color constant to the final output color.

Before you begin, make sure that the **Properties** window and the **Toolbox** are displayed.

1. Create a DGSL shader to work with. For information about how to add a DGSL shader to your project, see the Getting Started section in [Shader Designer](../designers/shader-designer.md).

2. Delete the **Point Color** node. Use the **Select** tool to select the **Point Color** node, and then on the menu bar, choose **Edit** > **Delete**.

3. Add a **Color Constant** node to the graph. In the **Toolbox**, under **Constants**, select **Color Constant** and move it to the design surface.

4. Specify a color value for the **Color Constant** node. Use the **Select** tool to select the **Color Constant** node, and then, in the **Properties** window, in the **Output** property, specify a color value. For orange, specify a value of (1.0, 0.5, 0.2, 1.0).

5. Connect the color constant to the final color. To create the connections, move the **RGB** terminal of the **Color Constant** node to the **RGB** terminal of the **Final Color** node, and then move the **Alpha** terminal of the **Color Constant** node to the **Alpha** terminal of the **Final Color** node. These connections set the final color to the color constant defined in the previous step.

The following illustration shows the completed shader graph and a preview of the shader applied to a cube.

> [!NOTE]
> In the illustration, an orange color was specified to better demonstrate the effect of the shader.

![Shader graph and its result on a 3&#45;D model](../designers/media/digit-flat-color-effect.png)

Certain shapes might provide better previews for some shaders. For more information about how to preview shaders in the Shader Designer, see [Shader Designer](../designers/shader-designer.md).

## See also

- [How to: Apply a shader to a 3D model](../designers/how-to-apply-a-shader-to-a-3-d-model.md)
- [How to: Export a shader](../designers/how-to-export-a-shader.md)
- [Shader Designer](../designers/shader-designer.md)
- [Shader Designer nodes](../designers/shader-designer-nodes.md)