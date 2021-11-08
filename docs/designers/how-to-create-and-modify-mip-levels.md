---
title: 'How to: Create and Modify MIP Levels'
description: Learn how to use the Image Editor to generate and modify MIP levels for texture-space Level-of-Detail.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: f64d4369-2307-4175-a39a-2e45506f7fa1
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-designers
ms.workload:
- multiple
---
# How to: Create and modify MIP levels
This document demonstrates how to use the **Image Editor** to generate and modify *MIP levels* for texture-space Level-of-Detail (LoD).

## Generating MIP levels
*Mipmapping* is a technique that's used to increase rendering speed and reduce aliasing artifacts on textured objects by pre-calculating and storing several copies of a texture in different sizes. Each copy, which is known as a MIP level, is half the width and height of the previous copy. When a texture is rendered on the surface of an object, the MIP level that corresponds most closely to the screen-space area of the textured surface is automatically chosen. This means that the graphics hardware doesn't have to filter oversized textures to maintain consistent visual quality. Although the memory cost of storing the MIP levels is about 33 percent more than that of the original texture alone, the performance and image-quality gains justify it.

#### To generate MIP levels

1. Begin with a basic texture, as described in [How to: Create a basic texture](../designers/how-to-create-a-basic-texture.md). For best results, specify a texture that has a width and height that are a power of two in size, for example, 256, 512, 1024, and so on.

2. Generate the MIP levels. On the **Image Editor Mode** toolbar, choose **Advanced** > **Tools** > **Generate Mips**.

     Notice that the **Go to Next Mip Level** and **Go to Previous Mip Level** buttons now appear on the **Image Editor Mode** toolbar. If the **Properties** window is displayed, also notice that the read-only properties **Mip Level** and **Mip Level Count** now appear in the image properties.

## Modifying MIP levels
To achieve special effects or increase image quality at specific levels of detail, you can modify each MIP level individually. For example, you can give a textured object a different appearance at a distance (greater distance corresponds to smaller MIP levels), or you can ensure that textures that contain text or symbols remain legible even at smaller MIP levels.

#### To modify an individual MIP level

1. Select the MIP level that you want to modify. On the **Image Editor Mode** toolbar, use the **Go to Next MIP Level** and **Go to Previous MIP Level** buttons to move between MIP levels.

2. After you select the MIP level that you want to modify, you can use the drawing tools to modify it without changing the contents of other MIP levels. The drawing tools are available on the **Image Editor** toolbar. After you select a tool, you can change its properties in the **Properties** window. For information about the drawing tools and their properties, see [Image Editor](../designers/image-editor.md).

> [!NOTE]
> If you do not need to modify the contents of individual MIP levels—as you might do to achieve certain effects—we recommend that you generate mipmaps from the source texture at build time. This helps to ensure that MIP levels stay in sync with the source texture because modifications to a MIP level are not propagated to other levels automatically. For more information on how to generate mipmaps at build time, see [How to: Export a texture that contains mipmaps](../designers/how-to-export-a-texture-that-contains-mipmaps.md).

## See also

- [How to: Create a basic texture](../designers/how-to-create-a-basic-texture.md)
