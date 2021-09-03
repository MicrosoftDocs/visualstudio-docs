---
title: 'How to: Apply a Shader to a 3D Model'
description: Learn how to use the Model Editor to apply a Directed Graph Shader Language shader to a 3D model to give it an interesting appearance.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: a3877bd6-abd8-4a9d-842c-6848b6c2f335
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-designers
ms.workload:
- multiple
---
# How to: Apply a shader to a 3D model

This article demonstrates how to use the Model Editor to apply a Directed Graph Shader Language (DGSL) shader to a 3D model.

## Apply a shader to a 3D model

You can apply a shader effect to a 3D model to give it an interesting appearance.

Before you begin, make sure that the **Properties** window is displayed.

1. Begin with a 3D scene that contains one or more models. If you don't have a suitable 3D scene, create one as described in [How to: Create a basic 3D Model](../designers/how-to-create-a-basic-3-d-model.md). You must also have a DGSL shader that you can apply to the model. If you don't have a suitable shader, create one as described in [How to: Create a basic color shader](../designers/how-to-create-a-basic-color-shader.md) and make sure that you've saved it to a file before you continue.

2. In **Select** mode, select the model to which you want to apply the shader, and then in the **Properties** window, in the **Filename** property of the **Effect** property group, specify the DGSL shader that you want to apply to the model.

Here's a model that has the basic color effect applied to it:

![3&#45;D scene that shows the basic color effect](../designers/media/digit-3d-model-effect.png)

After you apply a shader to a model, you can open it in the Shader Designer by selecting the model, and then in the **Properties** window, in the **(Advanced)** property of the **Effect** property group, choosing the ellipsis (**...**) button.

## See also

- [How to: Create a basic 3D model](../designers/how-to-create-a-basic-3-d-model.md)
- [How to: Create a basic color shader](../designers/how-to-create-a-basic-color-shader.md)
- [Model editor](../designers/model-editor.md)
- [Shader designer](../designers/shader-designer.md)
