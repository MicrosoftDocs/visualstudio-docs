---
title: Export texture formats with Image Content Pipeline
description: Learn how to export textures, such as those that include mipmaps or premultipled alpha, as part of building your projects.
ms.date: 06/23/2023
ms.topic: how-to
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: ui-designers
---
# Export rich texture formats by using the Image Content Pipeline in Visual Studio 

This article describes how to use the Image Content Pipeline to export textures, such as those that contain [mipmaps](#export-mipmaps), or [premultiplied alpha](#export-a-texture-that-has-premultiplied-alpha), or even those that can be used with [Direct2D or JavaScript apps](#export-a-texture-for-use-with-direct2d-or-javascript-apps).

## Export a texture that contains mipmaps

The Image Content Pipeline can generate mipmaps from a source image as part of your project's build phase. To achieve certain effects, sometimes you have to specify the image content of each MIP level manually. When you don't need to specify the image content of each MIP level manually, generating mipmaps at build time ensures that mipmap contents never become out-of-sync. It also eliminates the performance cost of generating mipmaps at run time.

This article covers:

- Configuring the source image to be processed by the Image Content Pipeline.

- Configuring the Image Content Pipeline to generate mipmaps.

### Export mipmaps

Mipmapping provides automatic screen-space Level-of-Detail for textured surfaces in a 3D game or app. It enhances the rendering performance of a game or app by precomputing down-sampled versions of a texture. Precomputing down-sampled versions means that the entire texture doesn't have to be down-sampled each time it's sampled.

**To export a texture that has mipmaps**

1. Begin with a basic texture. Load an existing image file, or create one. To support mipmaps, specify a texture that has a width and height that are both the same power of two in size, for example, 64x64, 256x256, or 512x512.

1. Configure the texture file you just created so that it's processed by the Image Content Pipeline. In **Solution Explorer**, open the shortcut menu for the texture file you created and then choose **Properties**. On the **Configuration Properties** > **General** page, set the **Item Type** property to **Image Content Pipeline**. Make sure that the **Content** property is set to **Yes** and **Exclude From Build** is set to **No**. Select **Apply**.

   The **Image Content Pipeline** configuration property page appears.

1. Configure the Image Content Pipeline to generate mipmaps. On the **Configuration Properties** > **Image Content Pipeline** > **General** page, set the **Generate Mips** property to **Yes (/generatemips)**.

1. Select **OK**.

When you build the project, the Image Content Pipeline converts the source image from the working format to the output format that you specified, including MIP levels. The result is copied to the project's output directory.

## Export a texture that has premultiplied alpha

The Image Content Pipeline can generate premultiplied alpha textures from a source image. These can be simpler to use and more robust than textures that don't contain premultiplied alpha.

This document demonstrates these activities:

- Configuring the source image to be processed by the Image Content Pipeline.

- Configuring the Image Content Pipeline to generate premultiplied alpha.

### Premultiplied alpha

Premultiplied alpha offers several advantages over conventional, non-premultiplied alpha, because it better represents the real-world interaction of light with physical materials by separating the texel's color contribution (the color that it adds to the scene) from its translucency (the amount of underlying color that it allows through). Some of the advantages of using premultiplied alpha are:

- Blending with premultiplied alpha is an associative operation; the result of blending multiple translucent textures is the same, regardless of the order in which the textures are blended.

- Because of the associative nature of blending with premultiplied alpha, multi-pass rendering of translucent objects is simplified.

- By using premultiplied alpha, both pure additive blending (by setting alpha to zero) and linearly interpolated blending can be achieved simultaneously. For example, in a particle system, an additively blended fire particle can become a translucent smoke particle that's blended by using linear interpolation. Without premultiplied alpha, you would have to draw the fire particles separately from the smoke particles, and modify the render state between draw calls.

- Textures that use premultiplied alpha compress with higher quality than those that don't, and they don't exhibit the discolored edges—or "halo effect"—that can result when you blend textures that don't use premultiplied alpha.

**To create a texture that uses premultiplied alpha**

1. Begin with a basic texture. Load an existing image file, or create one.

1. Configure the texture file so that it's processed by the Image Content Pipeline. In **Solution Explorer**, open the shortcut menu for the texture file and then choose **Properties**. On the **Configuration Properties** > **General** page, set the **Item Type** property to **Image Content Pipeline**. Make sure that the **Content** property is set to **Yes** and **Exclude From Build** is set to **No**, and then choose the **Apply** button. The **Image Content Pipeline** configuration property page appears.

1. Configure the Image Content Pipeline to generate premultiplied alpha. On the **Configuration Properties** > **Image Content Pipeline** > **General** page, set the **Convert to pre-multiplied alpha format** property to **Yes (/generatepremultipliedalpha)**.

1. Choose the **OK** button.

   When you build the project, the Image Content Pipeline converts the source image from the working format to the output format that you specified—this includes conversion of the image to premultiplied alpha format—and the result is copied to the project's output directory.

## Export a texture for use with Direct2D or JavaScript apps

The Image Content Pipeline can generate textures that are compatible with Direct2D's internal rendering conventions. Textures of this kind are suitable for use in apps that use Direct2D, and in UWP apps created by using JavaScript.

This document demonstrates these activities:

- Configuring the source image to be processed by the Image Content Pipeline.

- Configuring the Image Content Pipeline to generate a texture that you can use in a Direct2D or JavaScript app.

  - Generate a block-compressed *.dds* file.

  - Generate premultiplied alpha.

  - Disable mipmap generation.

### Rendering conventions in Direct2D

Textures that are used in the context of Direct2D must conform to these Direct2D internal rendering conventions:

- Direct2D implements transparency and translucency by using premultiplied alpha. Textures used with Direct2D must contain premultiplied alpha, even if the texture doesn't use transparency or translucency. 

- The texture must be supplied in *.dds* format, by using one of these block-compression formats:

  - BC1_UNORM compression

  - BC2_UNORM compression

  - BC3_UNORM compression

- Mipmaps aren't supported.

**To create a texture that's compatible with Direct2D rendering conventions**

1. Begin with a basic texture. Load an existing image, or create a new one. To support block-compression in *.dds* format, specify a texture that has a width and height that are multiples of four in size, for example, 100x100, 128x128, or 256x192. Because mipmapping isn't supported, the texture doesn't have to be square and doesn't have to be a power of two in size.

1. Configure the texture file so that it's processed by the Image Content Pipeline. In **Solution Explorer**, open the shortcut menu for the texture file you created and then choose **Properties**. On the **Configuration Properties** > **General** page, set the **Item Type** property to **Image Content Pipeline**. Make sure that the **Content** property is set to **Yes** and **Exclude From Build** is set to **No**, and then choose the **Apply** button. The **Image Content Pipeline** configuration property page appears.

1. Set the output format to one of the block-compressed formats. On the **Configuration Properties** > **Image Content Pipeline** > **General** page, set the **Compress** property to **BC3_UNORM compression (/compress:BC3_UNORM)**. You could choose any of the other BC1, BC2, or BC3 formats, depending on your requirements. Direct2D doesn't currently support BC4, BC5, BC6, or BC7 textures. For more information about the different BC formats, see [Block compression (Direct3D 10)](/windows/desktop/direct3d10/d3d10-graphics-programming-guide-resources-block-compression).

   > [!NOTE]
   > The compression format that's specified determines the format of the file that's produced by the Image Content Pipeline. This is different than the **Format** property of the source image in the Image Editor, which determines the format of the source image file as stored on disk—that is, the *working format*. Typically, you don't want a working format that's compressed.

1. Configure the Image Content Pipeline to produce output that uses premultiplied alpha. On the **Configuration Properties** > **Image Content Pipeline** > **General** page, set the **Convert to pre-multiplied alpha format** property to **Yes (/generatepremultipliedalpha)**.

1. Configure the image content pipeline so that it doesn't generate mipmaps. On the **Configuration Properties** > **Image Content Pipeline** > **General** page, set the **Generate Mips** property to **No**.

1. Choose the **OK** button.

   When you build the project, the Image Content Pipeline converts the source image from the working format to the output format that you specified—conversion includes generation of premultiplied alpha—and the result is copied to the project's output directory.

## Related content

Visit the [Work with textures and images](working-with-textures-and-images.md) to learn more about how to use the Image Editor in Visual Studio to create or modify textures and images that are used in DirectX app development.