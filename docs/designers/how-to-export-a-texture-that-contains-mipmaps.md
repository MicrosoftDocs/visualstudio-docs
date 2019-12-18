---
title: "How to: Export a Texture that Contains Mipmaps"
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: 3d1ad14b-44fb-4cf0-a995-5e2f60026524
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Export a texture that contains mipmaps

The Image Content Pipeline can generate mipmaps from a source image as part of your project's build phase. To achieve certain effects, sometimes you have to specify the image content of each MIP level manually. When you don't need to specify the image content of each MIP level manually, generating mipmaps at build time ensures that mipmap contents never become out-of-sync. It also eliminates the performance cost of generating mipmaps at run time.

This article covers:

- Configuring the source image to be processed by the Image Content Pipeline.

- Configuring the Image Content Pipeline to generate mipmaps.

## Export mipmaps

Mipmapping provides automatic screen-space Level-of-Detail for textured surfaces in a 3D game or app. It enhances the rendering performance of a game or app by pre-computing down-sampled versions of a texture. Pre-computing down-sampled versions means that the entire texture does not have to be down-sampled each time it's sampled.

### To export a texture that has mipmaps

1. Begin with a basic texture. Load an existing image file, or create one as described in [How to: Create a basic texture](../designers/how-to-create-a-basic-texture.md). To support mipmaps, specify a texture that has a width and height that are both the same power of two in size, for example, 64x64, 256x256, or 512x512.

2. Configure the texture file you just created so that it's processed by the Image Content Pipeline. In **Solution Explorer**, open the shortcut menu for the texture file you created and then choose **Properties**. On the **Configuration Properties** > **General** page, set the **Item Type** property to **Image Content Pipeline**. Make sure that the **Content** property is set to **Yes** and **Exclude From Build** is set to **No**. Select **Apply**.

   The **Image Content Pipeline** configuration property page appears.

3. Configure the Image Content Pipeline to generate mipmaps. On the **Configuration Properties** > **Image Content Pipeline** > **General** page, set the **Generate Mips** property to **Yes (/generatemips)**.

4. Select **OK**.

When you build the project, the Image Content Pipeline converts the source image from the working format to the output format that you specified, including MIP levels. The result is copied to the project's output directory.