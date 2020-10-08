---
title: "16bpp Render Target Format Variant | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 24b22ad9-5ad0-4161-809a-9b518eb924bf
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# 16 bpp Render Target Format Variant
Sets the pixel format to DXGI_FORMAT_B5G6R5_UNORM for all render targets and back buffers.

## Interpretation
 A render target or back buffer typically uses a 32 bpp (32 bits per pixel) format such as B8G8R8A8_UNORM. 32-bpp formats can consume a large amount of memory bandwidth. Because the B5G6R5_UNORM format is a 16-bpp format that's half the size of 32-bpp formats, using it can relieve pressure on memory bandwidth, but at the cost of reduced color fidelity.

 If this variant shows a large performance gain, it likely indicates that your app consumes too much memory bandwidth. You can gain significant performance improvement, especially when the profiled frame had a significant amount of overdraw or alpha-blending.

A 16-bpp render target format can reduce memory band with usage when your application has the following conditions:
- Doesn't require high-fidelity color reproduction.
- Doesn't require an alpha channel.
- Doesn't often have smooth gradients (which are susceptible to banding artifacts under reduced color fidelity).

Other strategies to reduce memory bandwidth include:
- Reduce the amount of overdraw or alpha-blending.
- Reduce the dimensions of the frame buffer.
- Reduce dimensions of texture resources.
- Reduce compressions of texture resources.

As usual, you have to consider the image quality trade-offs that come with any of these optimizations.

Applications that are a part of a swap chain have a back buffer format (DXGI_FORMAT_B5G6R5_UNORM) that doesn't support 16 bpp. These swap chains are created by using `D3D11CreateDeviceAndSwapChain` or `IDXGIFactory::CreateSwapChain`. To work around this limitation, do the following steps:
1. Create a B5G6R5_UNORM format render target by using `CreateTexture2D` and render to that target.
2. Copy the render target onto the swap-chain backbuffer by drawing a full-screen quad with the render target as your source texture.
3. Call Present on your swap chain.

   If this strategy saves more bandwidth than is consumed by copying the render target to the swap-chain backbuffer, then rendering performance is improved.

   GPU architectures that use tiled rendering techniques can see significant performance benefits by using a 16 bpp frame buffer format. This improvement is because a larger portion of the frame buffer can fit in each tile's local frame buffer cache. Tiled rendering architectures are sometimes found in GPUs in mobile handsets and tablet computers; they rarely appear outside of this niche.

## Remarks
 The render target format is reset to DXGI_FORMAT_B5G6R5_UNORM on every call to `ID3D11Device::CreateTexture2D` that creates a render target. Specifically, the format is overridden when the D3D11_TEXTURE2D_DESC object passed in pDesc describes a render target; that is:

- The BindFlags member has the D3D11_BIND_REDNER_TARGET flag set.

- The BindFlags member has the D3D11_BIND_DEPTH_STENCIL flag cleared.

- The Usage member is set to D3D11_USAGE_DEFAULT.

## Restrictions and limitations
 Because the B5G6R5 format doesn't have an alpha channel, alpha content is not preserved by this variant. If your app's rendering requires an alpha channel in your render target, you can't just switch to the B5G6R5 format.

## Example
 The **16 bpp Render Target Format** variant can be reproduced for render targets created by using `CreateTexture2D` by using code like this:

```cpp
D3D11_TEXTURE2D_DESC target_description;

target_description.BindFlags = D3D11_BIND_RENDER_TARGET;
target_description.Format = DXGI_FORMAT_B5G6R5_UNORM;
d3d_device->CreateTexture2D(&target_description, nullptr, &render_target);
```
