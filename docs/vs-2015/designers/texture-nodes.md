---
title: "Texture Nodes | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
ms.assetid: b7df5ef3-dd4f-4964-9d96-34e0e180515e
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: jillfra
---
# Texture Nodes
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In the Shader Designer, texture nodes sample various texture types and geometries, and produce or transform texture coordinates. Textures provide color and lighting detail on objects.

## Texture node reference

|Node|Details|Properties|
|----------|-------------|----------------|
|**Cubemap Sample**|Takes a color sample from a cubemap at the specified coordinates.<br /><br /> You can use a cubemap to provide color detail for reflection effects, or to apply to a spherical object a texture that has less distortion than a 2-D texture.<br /><br /> **Input:**<br /><br /> `UVW`: `float3`<br /> A vector that specifies the location on the texture cube where the sample is taken. The sample is taken where this vector intersects the cube.<br /><br /> **Output:**<br /><br /> `Output`: `float4`<br /> The color sample.|**Texture**<br /> The texture register that's associated with the sampler.|
|**Normal Map Sample**|Takes a normal sample from a 2-D normal map at the specified coordinates<br /><br /> You can use a normal map to simulate the appearance of additional geometric detail on the surface of an object. Normal maps contain packed data that represents a unit vector instead of color data<br /><br /> **Input:**<br /><br /> `UV`: `float2`<br /> The coordinates where the sample is taken.<br /><br /> **Output:**<br /><br /> `Output`: `float3`<br /> The normal sample.|**Axis Adjustment**<br /> The factor that's used to adjust the handedness of the normal map sample.<br /><br /> **Texture**<br /> The texture register that's associated with the sampler.|
|**Pan UV**|Pans the specified texture coordinates as a function of time.<br /><br /> You can use this to move a texture or normal map across the surface of an object.<br /><br /> **Input:**<br /><br /> `UV`: `float2`<br /> The coordinates to pan.<br /><br /> `Time`: `float`<br /> The length of time to pan by, in seconds.<br /><br /> **Output:**<br /><br /> `Output`: `float2`<br /> The panned coordinates.|**Speed X**<br /> The number of texels that are panned along the x axis, per second.<br /><br /> **Speed Y**<br /> The number of texels that are panned along the y axis, per second.|
|**Parallax UV**|Displaces the specified texture coordinates as a function of height and viewing angle.<br /><br /> The effect this creates is known as *parallax mapping*, or virtual displacement mapping. You can use it to create an illusion of depth on a flat surface.<br /><br /> **Input:**<br /><br /> `UV`: `float2`<br /> The coordinates to displace.<br /><br /> `Height`: `float`<br /> The heightmap value that's associated with the `UV` coordinates.<br /><br /> **Output:**<br /><br /> `Output`: `float2`<br /> The displaced coordinates.|**Depth Plane**<br /> The reference depth for the parallax effect. By default, the value is 0.5. Smaller values lift the texture; larger values sink it into the surface.<br /><br /> **Depth Scale**<br /> The scale of the parallax effect. This makes the apparent depth more or less pronounced. Typical values range from 0.02 to 0.1.|
|**Rotate UV**|Rotates the specified texture coordinates around a central point as a function of time.<br /><br /> You can use this to spin a texture or normal map on the surface of an object.<br /><br /> **Input:**<br /><br /> `UV`: `float2`<br /> The coordinates to rotate.<br /><br /> `Time`: `float`<br /> The length of time to pan by, in seconds.<br /><br /> **Output:**<br /><br /> `Output`: `float2`<br /> The rotated coordinates.|**Center X**<br /> The x coordinate that defines the center of rotation.<br /><br /> **Center Y**<br /> The y coordinate that defines the center of rotation.<br /><br /> **Speed**<br /> The angle, in radians, by which the texture rotates per second.|
|**Texture Coordinate**|The texture coordinates of the current pixel.<br /><br /> The texture coordinates are determined by interpolating among the texture coordinate attributes of nearby vertices. You can think of this as the position of the current pixel in texture space.<br /><br /> **Output:**<br /><br /> `Output`: `float2`<br /> The texture coordinates.|None|
|**Texture Dimensions**|Outputs the width and height of a 2-D texture map.<br /><br /> You can use the texture dimensions to consider the width and height of the texture in a shader.<br /><br /> **Output:**<br /><br /> `Output`: `float2`<br /> The width and height of the texture, expressed as a vector. The width is stored in the first element of the vector. The height is stored in the second element.|**Texture**<br /> The texture register that's associated with the texture dimensions.|
|**Texel Delta**|Outputs the delta (distance) between the texels of a 2-D texture map.<br /><br /> You can use the texel delta to sample neighboring texel values in a shader.<br /><br /> **Output:**<br /><br /> `Output`: `float2`<br /> The delta (distance) from a texel to the next texel (moving diagonally in the positive direction), expressed as a vector in normalized texture space. You can derive the positions of all neighboring texels by selectively ignoring or negating the U or V coordinates of the delta.|**Texture**<br /> The texture register that's associated with the texel delta.|
|**Texture Sample**|Takes a color sample from a 2-D texture map at the specified coordinates.<br /><br /> You can use a texture map to provide color detail on the surface of an object.<br /><br /> **Input:**<br /><br /> `UV`: `float2`<br /> The coordinates where the sample is taken.<br /><br /> **Output:**<br /><br /> `Output`: `float4`<br /> The color sample.|**Texture**<br /> The texture register that's associated with the sampler.|
