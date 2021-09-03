---
title: Export a texture for Direct2D and JavaScript apps
description: The Image Content Pipeline generates textures compatible with Direct2D internal rendering for use in Direct2D apps and UWP apps created with JavaScript.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: 241c25fe-764e-4e1b-ad32-b1377dcbb605
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-designers
ms.workload:
  - "multiple"
---
# How to: Export a texture for use with Direct2D or JavaScript apps

The Image Content Pipeline can generate textures that are compatible with Direct2D's internal rendering conventions. Textures of this kind are suitable for use in apps that use Direct2D, and in UWP apps created by using JavaScript.

This document demonstrates these activities:

- Configuring the source image to be processed by the Image Content Pipeline.

- Configuring the Image Content Pipeline to generate a texture that you can use in a Direct2D or JavaScript app.

  - Generate a block-compressed *.dds* file.

  - Generate premultiplied alpha.

  - Disable mipmap generation.

## Rendering conventions in Direct2D

Textures that are used in the context of Direct2D must conform to these Direct2D internal rendering conventions:

- Direct2D implements transparency and translucency by using premultiplied alpha. Textures used with Direct2D must contain premultiplied alpha, even if the texture doesn't use transparency or translucency. For more information about premultiplied alpha, see [How to: Export a texture that has Premultiplied Alpha](../designers/how-to-export-a-texture-that-has-premultiplied-alpha.md).

- The texture must be supplied in *.dds* format, by using one of these block-compression formats:

  - BC1_UNORM compression

  - BC2_UNORM compression

  - BC3_UNORM compression

- Mipmaps are not supported.

### To create a texture that's compatible with Direct2D rendering conventions

1. Begin with a basic texture. Load an existing image, or create a new one as described in [How to: Create a basic texture](../designers/how-to-create-a-basic-texture.md). To support block-compression in *.dds* format, specify a texture that has a width and height that are multiples of four in size, for example, 100x100, 128x128, or 256x192. Because mipmapping is not supported, the texture does not have to be square and does not have to be a power of two in size.

2. Configure the texture file so that it's processed by the Image Content Pipeline. In **Solution Explorer**, open the shortcut menu for the texture file you just created and then choose **Properties**. On the **Configuration Properties** > **General** page, set the **Item Type** property to **Image Content Pipeline**. Make sure that the **Content** property is set to **Yes** and **Exclude From Build** is set to **No**, and then choose the **Apply** button. The **Image Content Pipeline** configuration property page appears.

3. Set the output format to one of the block-compressed formats. On the **Configuration Properties** > **Image Content Pipeline** > **General** page, set the **Compress** property to **BC3_UNORM compression (/compress:BC3_UNORM)**. You could choose any of the other BC1, BC2, or BC3 formats, depending on your requirements. Direct2D doesn't currently support BC4, BC5, BC6, or BC7 textures. For more information about the different BC formats, see [Block compression (Direct3D 10)](/windows/desktop/direct3d10/d3d10-graphics-programming-guide-resources-block-compression).

   > [!NOTE]
   > The compression format that's specified determines the format of the file that's produced by the Image Content Pipeline. This is different than the **Format** property of the source image in the Image Editor, which determines the format of the source image file as stored on disk—that is, the *working format*. Typically, you don't want a working format that's compressed.

4. Configure the Image Content Pipeline to produce output that uses premultiplied alpha. On the **Configuration Properties** > **Image Content Pipeline** > **General** page, set the **Convert to pre-multiplied alpha format** property to **Yes (/generatepremultipliedalpha)**.

5. Configure the image content pipeline so that it doesn't generate mipmaps. On the **Configuration Properties** > **Image Content Pipeline** > **General** page, set the **Generate Mips** property to **No**.

6. Choose the **OK** button.

   When you build the project, the Image Content Pipeline converts the source image from the working format to the output format that you specified—conversion includes generation of premultiplied alpha—and the result is copied to the project's output directory.
