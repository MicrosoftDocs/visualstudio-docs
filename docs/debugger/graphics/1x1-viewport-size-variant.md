---
title: "1x1 Viewport Size Variant | Microsoft Docs"
description: Apply the 1x1 viewport size variant to reduce the viewport dimensions on all render targets to 1x1 pixels.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
ms.assetid: 3dbc3247-00f5-4644-8ff9-72e9febcf09a
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# 1x1 Viewport Size Variant
Reduces the viewport dimensions on all render targets to 1x1 pixels.

## Interpretation
 A smaller viewport reduces the number of pixels that you have to shade. But, a smaller viewport doesn't reduce the number of vertices that you have to process. Setting the viewport dimensions to 1x1 pixels effectively eliminates pixel-shading from your app.

 If this variant shows a large performance gain, it might indicate that your app consumes too much fill rate. In addition, your resolution could be too high for the target platform or  your app could spend significant time shading pixels that are later overwritten, also know as *overdraw*. A smaller frame buffer or reducing the amount of overdraw will improve your app's performance.

## Remarks
 The viewport dimensions are reset to 1x1 pixels after every call to `ID3D11DeviceContext::OMSetRenderTargets` or `ID3D11DeviceContext::RSSetViewports`.

## Example
 This variant can be reproduced with the following code:

```cpp
D3D11_VIEWPORT viewport;
viewport.TopLeftX = 0;
viewport.TopLeftY = 0;
viewport.Width = 1;
viewport.Height = 1;
d3d_context->RSSetViewports(1, &viewport);
```
