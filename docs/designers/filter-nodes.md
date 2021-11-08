---
title: Filter Nodes
description: Learn about filter nodes, which transform an input like a color or texture sample into a figurative color value, in Shader Designer.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: f7cae2dc-e9a7-49d4-8be5-58b79868624e
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-designers
ms.workload:
  - "multiple"
---
# Filter nodes

In the Shader Designer, filter nodes transform an input—for example, a color or texture sample—into a figurative color value. These figurative color values are commonly used in non-photorealistic rendering or as components in other visual effects.

## Filter node reference

|Node|Details|Properties|
|----------|-------------|----------------|
|**Blur**|Blurs pixels in a texture by using a Gaussian function.<br /><br /> You can use this to reduce color detail or noise in a texture.<br /><br /> **Input:**<br /><br /> `UV`: `float2`<br /> The coordinates of the texel to test.<br /><br /> **Output:**<br /><br /> `Output`: `float4`<br /> The blurred color value.|**Texture**<br /> The texture register that's associated with the sampler that's used during blurring.|
|**Desaturate**|Reduces the amount of color in the specified color.<br /><br /> As color is removed, the color value approaches its gray-scale equivalent.<br /><br /> **Input:**<br /><br /> `RGB`: `float3`<br /> The color to desaturate.<br /><br /> `Percent`: `float`<br /> The percent of color to remove, expressed as a normalized value in the range [0, 1].<br /><br /> **Output:**<br /><br /> `Output`: `float3`<br /> The desaturated color.|**Luminance**<br /> The weights that are given to the red, green, and blue color components.|
|**Edge Detection**|Detects edges in a texture by using a Canny edge detector. Edge pixels are output as white; non-edge pixels are output as black.<br /><br /> You can use this to identify edges in a texture so that you can use additional effects to treat edge pixels.<br /><br /> **Input:**<br /><br /> `UV`: `float2`<br /> The coordinates of the texel to test.<br /><br /> **Output:**<br /><br /> `Output`: `float4`<br /> White if the texel is on an edge; otherwise, black.|**Texture**<br /> The texture register that's associated with the sampler that's used during edge detection.|
|**Sharpen**|Sharpens a texture.<br /><br /> You can use this to highlight fine details in a texture.<br /><br /> **Input:**<br /><br /> `UV`: `float2`<br /> The coordinates of the texel to test.<br /><br /> **Output:**<br /><br /> `Output`: `float4`<br /> The blurred color value.|**Texture**<br /> The texture register that's associated with the sampler that's used during sharpening.|