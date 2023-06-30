---
title: About Shader Designer nodes
description: Learn about the various Shader Designer nodes that you can use to create graphics effects.
ms.date: 11/04/2016
ms.topic: overview
ms.assetid: f5192fbd-c78f-40a8-a4d4-443209610268
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-designers
ms.workload:
  - "multiple"
---
# What are Shader Designer nodes?

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

The Shader Designer in Visual Studio represents visual effects as a graph. These graphs are built from nodes that are specifically chosen and connected in precise ways to achieve the intended effect. Each node represents either a piece of information or a mathematical function, and the connections between them represent how the information flows through the graph to produce the result. 

## Nodes and node types

The Shader Designer provides six different node types&mdash;filters, texture nodes, parameters, constants, utility nodes, and math nodes&mdash;and several individual nodes belong to each type.

## Node structure

All nodes are made up of a combination of common elements. Every node has at least one output terminal on its right-hand side (except the final color node, which represents the output of the shader). Nodes that represent calculations or texture samplers have input terminals on their left-hand sides, but nodes that represent information have no input terminals. Output terminals are connected to input terminals to move information from one node to another.

### Promotion of inputs

Because the Shader Designer must ultimately generate HLSL source code so that the effect can be used in a game or app, Shader Designer nodes are subject to the type-promotion rules that HLSL uses. Because graphics hardware operates primarily on floating-point values, type promotion between different types—for example, from `int` to `float`, or from `float` to `double`—is uncommon. Instead, because graphics hardware uses the same operation on multiple pieces of information at once, a different kind of promotion can occur in which the shorter of a number of inputs is lengthened to match the size of the longest input. How it is lengthened depends on the type of the input, and also on the operation itself:

- **If the smaller type is a scalar value, then:**

     The value of the scalar is replicated into a vector that is equal in size to the larger input. For example, the scalar input 5.0 becomes the vector (5.0, 5.0, 5.0) when the largest input of the operation is a three-element vector, regardless of what the operation is.

- **If the smaller type is a vector, and the operation is multiplicative (\*, /, %, and so on), then:**

     The value of the vector is copied into the leading elements of a vector that is equal in size to the larger input, and the trailing elements are set to 1.0. For example, the vector input (5.0, 5.0) becomes the vector (5.0, 5.0, 1.0, 1.0) when it's multiplied by a four-element vector. This preserves the third and fourth elements of the output by using the multiplicative identity, 1.0.

- **If the smaller type is a vector, and the operation is additive (+, -, and so on), then:**

     The value of the vector is copied into the leading elements of a vector that is equal in size to the larger input, and the trailing elements are set to 0.0. For example, the vector input (5.0, 5.0) becomes the vector (5.0, 5.0, 0.0, 0.0) when it's added to a four-element vector. This preserves the third and fourth elements of the output by using the additive identity, 0.0.

## Constant nodes

In the Shader Designer, constant nodes represent literal values and interpolated vertex attributes in pixel-shader calculations. Because vertex attributes are interpolated—and so, are different for each pixel—each pixel-shader instance receives a different version of the constant. This gives each pixel a unique appearance.

### Vertex attribute interpolation

The image of a 3D scene in a game or app is made by mathematically transforming a number of objects—which are defined by vertices, vertex attributes, and primitive definitions—into on-screen pixels. All of the information that's required to give a pixel its unique appearance is supplied through vertex attributes, which are blended together according to the pixel's proximity to the different vertices that make up its *primitive*. A primitive is a basic rendering element; that is, a simple shape such as a point, a line, or a triangle. A pixel that's very close to just one of the vertices receives constants that are nearly identical to that vertex, but a pixel that's evenly spaced between all the vertices of a primitive receives constants that are the average of those vertices. In graphics programming, the constants that the pixels receive are said to be *interpolated*. Providing constant data to pixels in this way produces very good visual quality and at the same time reduces memory footprint and bandwidth requirements.

Although each pixel-shader instance receives only one set of constant values and cannot change these values, different pixel-shader instances receive different sets of constant data. This design enables a shader program to produce a different color output for each pixel in the primitive.

### Constant node reference

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

