---
title: "Half-Quarter Texture Dimensions Variant | Microsoft Docs"
description: If smaller textures show large performance gains, it suggests memory bandwidth pressure or inefficient use of the GPU texture cache. Consider making texture sizes smaller.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
ms.assetid: 282e9bbb-51aa-4cd0-8e5c-0901268c29e5
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Half/Quarter Texture Dimensions Variant
Reduces the texture dimensions on textures that are not render targets.

## Interpretation
 Smaller textures occupy less memory and therefore consume less memory bandwidth and reduce pressure on the GPU's texture cache. However, their lesser detail can cause reduced image quality, especially when they're viewed closely in a 3-D scene or viewed under magnification.

 If this variant shows a large performance gain, it can indicate that your app consumes too much memory bandwidth, uses the texture cache inefficiently, or both. It can also indicate that your textures occupy more GPU memory than is available, which causes textures to be paged to system memory.

 If your app consumes too much memory bandwidth or uses the texture cache inefficiently, consider reducing the size of your textures, but only after you consider enabling mip-maps for appropriate textures. Like smaller textures, mip-mapped textures consume less memory bandwidth—although they occupy more GPU memory—and increase cache utilization, but they don't reduce texture detail. We recommend mip-maps whenever the increased memory usage doesn't cause textures to be paged to system memory.

 If your textures occupy more GPU memory than is available, consider reducing the size of the textures, but only after you consider compressing appropriate textures. Like smaller textures, compressed textures occupy less memory and reduce the need to page to system memory, but their color fidelity is reduced. Compression isn't appropriate for all textures, depending on their content—for example, those that have significant color variation in a small area—but for many textures, compression can retain better overall image quality than reducing their size.

## Remarks
 Texture dimensions are reduced on every call to `ID3D11Device::CreateTexture2D` that creates a source texture. Specifically, texture dimensions are reduced when the D3D11_TEXTURE2D_DESC object passed in `pDesc` describes a texture that's used in rendering; that is:

- The BindFlags member has only the D3D11_BIND_SHADER_RESOURCE flag set.

- The MiscFlags member does not have the D3D11_RESOURCE_MISC_TILE_POOL flag or the D3D11_RESOURCE_MISC_TILED flag set (tiled resources are not resized).

- The texture format is supported as a render target—as determined by D3D11_FORMAT_SUPPORT_RENDER_TARGET—which is required for reducing the texture size. BC1, BC2, and BC3 formats are also supported, even though they're not supported as render targets.

  If initial data is supplied by the application, this variant scales the texture data to the appropriate size before it creates the texture. If initial data is supplied in a block-compressed format such as BC1, BC2, or BC3, it is decoded, scaled, and re-encoded before it's used to create the smaller texture. (The nature of block-based compression means that the extra decode-scale-encode process almost always causes lower image quality than when a block-compressed texture is generated from a scaled version of the texture that had not previously been encoded.)

  If mip-maps are enabled for the texture, the variant reduces the number of mip levels accordingly—one fewer when scaling to half-size or two fewer when scaling to quarter-size.

## Example
 This variant resizes textures at run time before the call to `CreateTexture2D`. We recommend against this approach for production code because the full-size textures consume more disk space and because the additional step can increase loading times in your app—especially for compressed textures, which require significant computational resources to encode. Instead, we recommend that you resize your textures offline by using an image editor or image processor that's part of your build pipeline. These approaches reduce disk-space requirements and eliminate runtime overhead in your app, and afford more processing time so that you can retain the best image quality while shrinking or compressing your textures.

## See also
- [Mip-map Generation Variant](mip-map-generation-variant.md)
- [BC Texture Compression Variant](bc-texture-compression-variant.md)