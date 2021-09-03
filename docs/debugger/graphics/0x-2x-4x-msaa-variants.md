---
title: "0x-2x-4x MSAA Variants | Microsoft Docs"
description: Learn how to override multi-sample anti-aliasing (MSAA) settings on all render targets and swap chains by using 0x, 2x, or 4x MSAA variants.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
ms.assetid: 668a6603-5082-4c78-98e6-f3dc871aa55b
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# 0x/2x/4x MSAA Variants
Overrides multi-sample anti-aliasing (MSAA) settings on all render targets and swap chains.

## Interpretation
 Multi-sample anti-aliasing increases visual quality by taking samples at multiple locations in each pixel; greater levels of MSAA take more samples, and without MSAA, only one sample is taken from the pixel's center. Enabling MSAA in your app usually has a modest but noticeable cost in rendering performance, but under certain workloads or on certain GPUs, it can be had with almost no impact.

 If your app already has MSAA enabled, then the lesser MSAA variants indicate the relative performance cost that the existing, higher-level MSAA incurs. In particular, the 0x MSAA variant indicates the relative performance of your app without MSAA.

 If your app doesn't already have MSAA enabled, then the 2x MSAA and 4x MSAA variants indicate the relative performance cost of enabling them in your app. When the cost is acceptably low, consider enabling MSAA to enhance the image quality of your app.

> [!NOTE]
> Your hardware might not fully support MSAA for all formats. If any of these variants encounter a hardware limitation that can't be worked around, its column in the performance summary table is blank and an error message is produced.

## Remarks
 These variants override the sample count and sample-quality arguments on calls to `ID3DDevice::CreateTexture2D` that create render targets. Specifically, these parameters are overridden when:

- The `D3D11_TEXTURE2D_DESC` object passed in `pDesc` describes a render target; that is:

  - The BindFlags member has either the D3D11_BIND_TARGET flag or D3D11_BIND_DEPTH_STENCIL flag set.

  - The Usage member is set to D3D11_USAGE_DEFAULT.

  - The CPUAccessFlags member is set to 0.

  - The MipLevels member is set to 1.

- The device supports the requested sample count (0, 2, or 4) and sample quality (0) for the requested render target format (D3D11_TEXTURE2D_DESC::Format member), as determined by `ID3D11Device::CheckMultisampleQualityLevels`.

  If the D3D11_TEXTURE2D_DESC::BindFlags member has the D3D_BIND_SHADER_RESOURCE or D3D11_BIND_UNORDERED_ACCESS flags set, then two versions of the texture are created; the first has these flags cleared for use as the render target, and the other is a non-MSAA texture that has these flags left intact to act as a resolve buffer for the first version. This is necessary because using an MSAA texture as a shader resource or for unordered access is unlikely to be valid—for example, a shader acting on it would generate incorrect results because it would expect a non-MSAA texture. If the variant has created the secondary non-MSAA texture, then whenever the MSAA render target is unset from the device context, its contents are resolved into the non-MSAA texture. Likewise, whenever the MSAA render target should be bound as a shader resource, or is used in an unordered access view, the resolved non-MSAA texture is bound instead.

  These variants also override MSAA settings on all swap chains created by using `IDXGIFactory::CreateSwapChain`, `IDXGIFactory2::CreateSwapChainForHwnd`, `IDXGIFactory2::CreateSwapChainForCoreWindow`, `IDXGIFactory2::CreateSwapChainForComposition`, and `ID3D11CreateDeviceAndSwapChain`.

  The net effect of these changes is that all rendering is done to an MSAA render target, but if your application uses one of these render targets or swap-chain buffers as a shader resource view or unordered access view, then data is sampled from the resolved, non-MSAA copy of the render target.

## Restrictions and limitations
 In Direct3D11, MSAA textures are more restricted than non-MSAA textures. For example, you can't call `ID3D11DeviceContext::UpdateSubresource` on an MSAA texture, and calling `ID3D11DeviceContext::CopySubresourceRegion` fails if the sample count and sample quality of the source resource and destination resource don't match, which can occur when this variant overrides the MSAA settings of one resource but not the other.

 When playback detects these kinds of conflicts, it makes a best effort to replicate the intended behavior, but it might not be possible to match its results exactly. Although it's uncommon for this to affect the performance of these variants in a way that misrepresents their impact, it is possible—for example, when flow control in a pixel shader is determined by the precise content of a texture—because the replicated texture might not have identical contents.

## Example 1
 These variants can be reproduced for render targets created by using `ID3D11Device::CreateTexture2D` by using code like this:

```cpp
D3D11_TEXTURE2D_DESC target_description;
target_description.BindFlags = D3D11_BIND_RENDER_TARGET;
target_description.SampleDesc.Count = 4; // 4x MSAA, can be 2 or 0 instead
target_description.SampleDesc.Quality = 0;
d3d_device->CreateTexture2D(&target_description, nullptr, &render_target);
```

## Example 2
 Or for swap chains created by using IDXGISwapChain::CreateSwapChain or D3D11CreateDeviceAndSwapChain by using code like this:

```cpp
DXGI_SWAP_CHAIN_DESC chain_description;
chain_description.SampleDesc.Count = 4; // 4x MSAA, can be 2 or 0 instead
chain_description.SampleDesc.Quality = 0;

// Call IDXGISwapChain::CreateSwapChain or D3D11CreateDeviceAndSwapChain, etc.
```
