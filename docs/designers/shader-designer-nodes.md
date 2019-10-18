---
title: Shader Designer Nodes
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: f5192fbd-c78f-40a8-a4d4-443209610268
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Shader Designer nodes
The articles in this section of the documentation contain information about the various Shader Designer nodes that you can use to create graphics effects.

## Nodes and node types
The Shader Designer represents visual effects as a graph. These graphs are built from nodes that are specifically chosen and connected in precise ways to achieve the intended effect. Each node represents either a piece of information or a mathematical function, and the connections between them represent how the information flows through the graph to produce the result. The Shader Designer provides six different node types—filters, texture nodes, parameters, constants, utility nodes, and math nodes—and several individual nodes belong to each type. These nodes and node types are described in the other articles in this section. For more information, see the links at the end of this document.

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

## Related topics

|Title|Description|
|-----------|-----------------|
|[Constant nodes](../designers/constant-nodes.md)|Describes nodes that you can use to represent literal values and interpolated vertex-state information in shader calculations. Because vertex-state is interpolated—and therefore, is different for each pixel—each pixel-shader instance receives a different version of the constant.|
|[Parameter nodes](../designers/parameter-nodes.md)|Describes nodes that you can use to represent camera position, material properties, lighting parameters, time, and other app-state information in shader calculations.|
|[Texture nodes](../designers/texture-nodes.md)|Describes the nodes that you can use to sample various texture types and geometries, and to produce or transform texture coordinates in common ways.|
|[Math nodes](../designers/math-nodes.md)|Describes the nodes that you can use to perform algebraic, logic, trigonometric, and other mathematical operations that map directly to HLSL instructions.|
|[Utility nodes](../designers/utility-nodes.md)|Describes the nodes that you can use to perform common lighting calculations and other common operations that do not map directly to HLSL instructions.|
|[Filter nodes](../designers/filter-nodes.md)|Describes the nodes that you can use to perform texture filtering and color filtering.|
