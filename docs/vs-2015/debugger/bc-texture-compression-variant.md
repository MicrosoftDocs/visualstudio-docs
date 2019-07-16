---
title: "BC Texture Compression Variant | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 2d0f5305-585b-4b01-bc9a-7a32d6e991da
caps.latest.revision: 7
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# BC Texture Compression Variant
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Enables block compression on textures that have a pixel format that's a variation of B8G8R8X8, B8G8R8A8, or R8G8B8A8.  
  
## Interpretation  
 Block-based compression formats like BC1, BC2, and BC3 occupy significantly less memory than uncompressed image formats and therefore consume significantly less memory bandwidth. Compared to an uncompressed format that uses 32 bits per pixel, BC1 (formerly known as DXT1) achieves 8:1 compression and BC3 (formerly known as DXT5) achieves 4:1. The difference between BC1 and BC3 is that BC1 doesn't support an alpha channel, while BC3 supports a block-compressed alpha channel. Despite the high compression ratios, there's only a minor reduction in image quality for typical textures. However, block compression of certain kinds of textures—for example, those that have significant color variation in a small area—can have unacceptable results.  
  
 If your textures are suitable for block-based compression and don't need perfect color fidelity, consider using a block-compressed format to reduce memory usage and consume less bandwidth.  
  
## Remarks  
 You compress textures by using a block-based compression format on every call to `ID3DDevice::CreateTexture2D` that creates a source texture. Specifically, textures are compressed when:  
  
- The `D3D11_TEXTURE2D_DESC` object passed in `pDesc` describes an unchanging shader resource; that is:  
  
  - The BindFlags member has only the D3D11_BIND_SHADER_RESOURCE flag set.  
  
  - The Usage member is set to either D3D11_USAGE_DEFAULT or D3D11_USAGE_IMMUTABLE.  
  
  - The CPUAccessFlags member is set to 0 (no CPU access).  
  
  - The SamplerDesc member has its Count member set to 1 (no Multi-Sample Anti-Aliasing (MSAA)).  
  
- Initial data is provided to the call to `CreateTexture2D`.  
  
  Here are the supported source formats and their block-compressed formats.  
  
|Original format (from)|Compressed format (to)|  
|------------------------------|------------------------------|  
|`DXGI_FORMAT_B8G8R8X8_UNORM`|BC1 (formerly DXT1)|  
|`DXGI_FORMAT_B8G8R8X8_UNORM_SRGB`|BC1|  
|`DXGI_FORMAT_B8G8R8X8_TYPELESS`|BC1|  
|`DXGI_FORMAT_B8G8R8A8_UNORM`|BC3 (formerly DXT5)|  
|`DXGI_FORMAT_B8G8R8A8_UNORM_SRGB`|BC3|  
|`DXGI_FORMAT_B8G8R8A8_TYPELESS`|BC3|  
|`DXGI_FORMAT_R8G8B8A8_UNORM`|BC3|  
|`DXGI_FORMAT_R8G8B8A8_UNORM_SRGB`|BC3|  
|`DXGI_FORMAT_R8G8B8A8_TYPELESS`|BC3|  
  
 If your texture has a format that's not listed, the texture is not modified.  
  
## Restrictions and limitations  
 Sometimes textures that are created with a variation of the B8G8R8A8 or R8G8B8A8 image formats don't actually use the alpha channel, but there's no way for the variant to know whether it's used or not. To maintain correctness in case the alpha channel is used, the variant always encodes these formats into the less-efficient BC3 format. You can help Graphics Frame Analysis better understand your app's potential rendering performance with this variant by using a variation of the B8G8R8X8 image format when you are not using the alpha channel so that the variant can use the more-efficient BC1 format.  
  
## Example  
 This variant block-compresses textures at run time, before the call to `CreateTexture2D`. We recommend against this approach for production code because the uncompressed textures consume more disk space and because the additional step can significantly increase loading times in your app because block-based compression requires significant computational resources to encode. Instead, we recommend that you compress your textures offline by using an image editor or image processor that's part of your build pipeline. These approaches reduce disk-space requirements, eliminate run-time overhead in your app, and afford more processing time so that you can retain the best image quality.  
  
## See Also  
 [Half/Quarter Texture Dimensions Variant](../debugger/half-quarter-texture-dimensions-variant.md)
