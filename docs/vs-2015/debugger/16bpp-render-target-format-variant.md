---
title: "16bpp Render Target Format Variant | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 24b22ad9-5ad0-4161-809a-9b518eb924bf
caps.latest.revision: 8
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# 16bpp Render Target Format Variant
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Sets the pixel format to DXGI_FORMAT_B5G6R5_UNORM for all render targets and back buffers.  
  
## Interpretation  
 A render target or back buffer typically uses a 32bpp (32 bits per pixel) format such as B8G8R8A8_UNORM. 32bpp formats can consume a lot of memory bandwidth. Because the B5G6R5_UNORM format is a 16bpp format that's half the size of 32bpp formats, using it can relieve pressure on memory bandwidth, but at the cost of reduced color fidelity.  
  
 If this variant shows a large performance gain, it likely indicates that your app consumes too much memory bandwidth. Performance gains can be especially pronounced when the profiled frame suffers from a significant amount of overdraw or contains a lot of alpha-blending.  
  
 If the kinds of scenes that are rendered by your app don't require high-fidelity color reproduction, don't require the render target to have an alpha channel, and don't often contain smooth gradients—which are susceptible to banding artifacts under reduced color fidelity—consider using a 16bpp render target format to reduce memory bandwidth usage.  
  
 If the scenes that are rendered in your app require high-fidelity color reproduction or an alpha channel, or smooth gradients are common, consider other strategies to reduce memory bandwidth usage—for example, reducing the amount of overdraw or alpha-blending, reducing the dimensions of the framebuffer, or modifying texture resources to consume less memory bandwidth by enabling compression or reducing their dimensions. As usual, you have to consider the image quality trade-offs that come with any of these optimizations.  
  
 If your app would benefit from switching to a 16bpp back buffer but it's a part of your swap chain, you have to take additional steps because DXGI_FORMAT_B5G6R5_UNORM is not a supported back buffer format for swap chains created by using `D3D11CreateDeviceAndSwapChain` or `IDXGIFactory::CreateSwapChain`. Instead, you have to create a B5G6R5_UNORM format render target by using `CreateTexture2D` and render to that instead. Then, before you call Present on your swap chain, copy the render target onto the swap-chain backbuffer by drawing a full-screen quad with the render target as your source texture. Although this is an extra step that will consume some memory bandwidth, most rendering operations will consume less bandwidth because they affect the 16bpp render target; if this saves more bandwidth than is consumed by copying the render target to the swap-chain backbuffer, then rendering performance is improved.  
  
 GPU architectures that use tiled rendering techniques can see significant performance benefits by using a 16bpp framebuffer format because a larger portion of the framebuffer can fit in each tile's local framebuffer cache. Tiled rendering architectures are sometimes found in GPUs in mobile handsets and tablet computers; they rarely appear outside of this niche.  
  
## Remarks  
 The render target format is reset to DXGI_FORMAT_B5G6R5_UNORM on every call to `ID3D11Device::CreateTexture2D` that creates a render target. Specifically, the format is overridden when the D3D11_TEXTURE2D_DESC object passed in pDesc describes a render target; that is:  
  
- The BindFlags member has the D3D11_BIND_REDNER_TARGET flag set.  
  
- The BindFlags member has the D3D11_BIND_DEPTH_STENCIL flag cleared.  
  
- The Usage member is set to D3D11_USAGE_DEFAULT.  
  
## Restrictions and limitations  
 Because the B5G6R5 format doesn't have an alpha channel, alpha content is not preserved by this variant. If your app's rendering requires an alpha channel in your render target, you can't just switch to the B5G6R5 format.  
  
## Example  
 The **16bpp Render Target Format** variant can be reproduced for render targets created by using `CreateTexture2D` by using code like this:  
  
```  
D3D11_TEXTURE2D_DESC target_description;  
  
target_description.BindFlags = D3D11_BIND_RENDER_TARGET;  
target_description.Format = DXGI_FORMAT_B5G6R5_UNORM;  
d3d_device->CreateTexture2D(&target_description, nullptr, &render_target);  
```
