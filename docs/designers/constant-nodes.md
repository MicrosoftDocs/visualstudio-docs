---
title: Constant Nodes
description: Learn about constant nodes, which represent literal values and interpolated vertex attributes in pixel-shader calculations, in Shader Designer.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: 2c798a50-a2d7-459b-9879-ad4ad8290c9b
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-designers
ms.workload:
  - "multiple"
---
# Constant nodes

In the Shader Designer, constant nodes represent literal values and interpolated vertex attributes in pixel-shader calculations. Because vertex attributes are interpolated—and so, are different for each pixel—each pixel-shader instance receives a different version of the constant. This gives each pixel a unique appearance.

## Vertex attribute interpolation

The image of a 3D scene in a game or app is made by mathematically transforming a number of objects—which are defined by vertices, vertex attributes, and primitive definitions—into on-screen pixels. All of the information that's required to give a pixel its unique appearance is supplied through vertex attributes, which are blended together according to the pixel's proximity to the different vertices that make up its *primitive*. A primitive is a basic rendering element; that is, a simple shape such as a point, a line, or a triangle. A pixel that's very close to just one of the vertices receives constants that are nearly identical to that vertex, but a pixel that's evenly spaced between all the vertices of a primitive receives constants that are the average of those vertices. In graphics programming, the constants that the pixels receive are said to be *interpolated*. Providing constant data to pixels in this way produces very good visual quality and at the same time reduces memory footprint and bandwidth requirements.

Although each pixel-shader instance receives only one set of constant values and cannot change these values, different pixel-shader instances receive different sets of constant data. This design enables a shader program to produce a different color output for each pixel in the primitive.

## Constant node reference

|Node|Details|Properties|
|----------|-------------|----------------|
|**Camera Vector**|The vector that extends from the current pixel to the camera in world space.<br /><br /> You can use this to calculate reflections in world space.<br /><br /> **Output**<br /><br /> `Output`: `float3`<br /> The vector from the current pixel to the camera.|None|
|**Color Constant**|A constant color value.<br /><br /> **Output**<br /><br /> `Output`: `float4`<br /> The color value.|**Output**<br /> The color value.|
|**Constant**|A constant scalar value.<br /><br /> **Output**<br /><br /> `Output`: `float`<br /> The scalar value.|**Output**<br /> The scalar value.|
|**2D Constant**|A two-component vector constant.<br /><br /> **Output**<br /><br /> `Output`: `float2`<br /> The vector value.|**Output**<br /> The vector value.|
|**3D Constant**|A three-component vector constant.<br /><br /> **Output**<br /><br /> `Output`: `float3`<br /> The vector value.|**Output**<br /> The vector value.|
|**4D Constant**|A four-component vector constant.<br /><br /> **Output**<br /><br /> `Output`: `float4`<br /> The color value.|**Output**<br /> The vector value.|
|**Normalized Position**|The position of the current pixel, expressed in normalized device coordinates.<br /><br /> The x-coordinate and y-coordinate have values in the range of [-1, 1], the z-coordinate has a value in the range of [0, 1], and the w component contains the point depth value in view space; w is not normalized.<br /><br /> **Output**<br /><br /> `Output`: `float4`<br /> The position of the current pixel.|None|
|**Point Color**|The diffuse color of the current pixel, which is a combination of the material diffuse color and vertex color attributes.<br /><br /> **Output**<br /><br /> `Output`: `float4`<br /> The diffuse color of the current pixel.|None|
|**Point Depth**|The depth of the current pixel in view space.<br /><br /> **Output**<br /><br /> `Output`: `float`<br /> The depth of the current pixel.|None|
|**Normalized Point Depth**|The depth of the current pixel, expressed in normalized device coordinates.<br /><br /> The result has a value in the range of [0, 1].<br /><br /> **Output**<br /><br /> `Output`: `float`<br /> The depth of the current pixel.|None|
|**Screen Position**|The position of the current pixel, expressed in screen coordinates.<br /><br /> The screen coordinates are based on the current viewport. The x and y components contain the screen coordinates, the z component contains the depth normalized to a range of [0, 1], and the w component contains the depth value in view space.<br /><br /> **Output**<br /><br /> `Output`: `float4`<br /> The position of the current pixel.|None|
|**Surface Normal**|The surface normal of the current pixel in object space.<br /><br /> You can use this to calculate lighting contributions and reflections in object space.<br /><br /> **Output**<br /><br /> `Output`: `float3`<br /> The surface normal of the current pixel.|None|
|**Tangent Space Camera Vector**|The vector that extends from the current pixel to the camera in tangent space.<br /><br /> You can use this to calculate reflections in tangent space.<br /><br /> **Output**<br /><br /> `Output`: `float3`<br /> The vector from the current pixel to the camera.|None|
|**Tangent Space Light Direction**|The vector that defines the direction in which light is cast from a light source in the tangent space of the current pixel.<br /><br /> You can use this to calculate lighting and specular contributions in tangent space.<br /><br /> **Output:**<br /><br /> `Output`: `float3`<br /> The vector from the current pixel to a light source.|None|
|**World Normal**|The surface normal of the current pixel in world space.<br /><br /> You can use this to calculate lighting contributions and reflections in world space.<br /><br /> **Output**<br /><br /> `Output`: `float3`<br /> The surface normal of the current pixel.|None|
|**World Position**|The position of the current pixel in world space.<br /><br /> **Output**<br /><br /> `Output`: `float4`<br /> The position of the current pixel.|None|