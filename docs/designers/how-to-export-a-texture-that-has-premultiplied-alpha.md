---
title: "How to: Export a Texture that has Premultiplied Alpha"
description: Learn how the Image Content Pipeline generates premultiplied alpha textures from a source image that can be simpler to use and more robust.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: 05348afa-f079-4f53-a05b-ecd91d13adab
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-designers
ms.workload:
  - "multiple"
---
# How to: Export a texture that has premultiplied alpha

The Image Content Pipeline can generate premultiplied alpha textures from a source image. These can be simpler to use and more robust than textures that do not contain premultiplied alpha.

This document demonstrates these activities:

- Configuring the source image to be processed by the Image Content Pipeline.

- Configuring the Image Content Pipeline to generate premultiplied alpha.

## Premultiplied alpha
Premultiplied alpha offers several advantages over conventional, non-premultiplied alpha, because it better represents the real-world interaction of light with physical materials by separating the texel's color contribution (the color that it adds to the scene) from its translucency (the amount of underlying color that it allows through). Some of the advantages of using premultiplied alpha are:

- Blending with premultiplied alpha is an associative operation; the result of blending multiple translucent textures is the same, regardless of the order in which the textures are blended.

- Because of the associative nature of blending with premultiplied alpha, multi-pass rendering of translucent objects is simplified.

- By using premultiplied alpha, both pure additive blending (by setting alpha to zero) and linearly interpolated blending can be achieved simultaneously. For example, in a particle system, an additively blended fire particle can become a translucent smoke particle that's blended by using linear interpolation. Without premultiplied alpha, you would have to draw the fire particles separately from the smoke particles, and modify the render state between draw calls.

- Textures that use premultiplied alpha compress with higher quality than those that don't, and they don't exhibit the discolored edges—or "halo effect"—that can result when you blend textures that don't use premultiplied alpha.

#### To create a texture that uses premultiplied alpha

1. Begin with a basic texture. Load an existing image file, or create one as described in [How to: Create a basic texture](../designers/how-to-create-a-basic-texture.md).

2. Configure the texture file so that it's processed by the Image Content Pipeline. In **Solution Explorer**, open the shortcut menu for the texture file and then choose **Properties**. On the **Configuration Properties** > **General** page, set the **Item Type** property to **Image Content Pipeline**. Make sure that the **Content** property is set to **Yes** and **Exclude From Build** is set to **No**, and then choose the **Apply** button. The **Image Content Pipeline** configuration property page appears.

3. Configure the Image Content Pipeline to generate premultiplied alpha. On the **Configuration Properties** > **Image Content Pipeline** > **General** page, set the **Convert to pre-multiplied alpha format** property to **Yes (/generatepremultipliedalpha)**.

4. Choose the **OK** button.

   When you build the project, the Image Content Pipeline converts the source image from the working format to the output format that you specified—this includes conversion of the image to premultiplied alpha format—and the result is copied to the project's output directory.