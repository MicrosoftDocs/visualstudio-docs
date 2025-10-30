---
title: Working with Shaders
description: Learn how to design custom shader effects by using the graph-based Shader Designer in Visual Studio. You can use shaders in your DirectX-based game or app.
ms.date: 11/04/2016
ms.topic: concept-article
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: ui-designers
---
# Work with shaders

You can use the graph-based Shader Designer in Visual Studio to design custom shader effects. You can use these shaders in your DirectX-based game or app.

## Shaders

A *shader* is a computer program that performs graphics calculations—for example, vertex transformations or pixel coloring—and typically runs on a graphics processing unit (GPU) instead of the CPU. Because most stages of the traditional, fixed-function graphics pipeline are now performed by shader programs, you can use them to create a pipeline that's specific to the needs of your app.

The most common kinds of shaders are *vertex shaders*, which perform per-vertex calculations and replace the fixed-function transformation and lighting circuitry in non-programmable graphics hardware, and *pixel shaders*, which perform per-pixel calculations that determine the color of a pixel and replace the fixed-function color-combiner circuitry in non-programmable graphics hardware. Modern graphics hardware has made even more kinds of shaders possible—*hull shaders*, *domain shaders*, and *geometry shaders* for graphics calculations, and *compute shaders* for non-graphics computations. None of these stages are even available in non-programmable graphics hardware. Shaders were originally created by using an assembly-like language that provided data-parallel (SIMD) and graphics-centric (dot product) instructions. Now, shaders are typically created by using high-level, C-like languages like HLSL (High Level Shader Language).

You can use the Shader Designer to create pixel shaders interactively instead of by entering and compiling code. In the Shader Designer, a shader is defined by a number of nodes that represent data and operations, and connections between nodes that represent the flow of data values and intermediate results through the shader. By using this approach and the real-time preview in the Shader Designer, you can visualize the execution of the shader more easily, and "discover" interesting shader variations through experimentation.

## DGSL documents

The Shader Designer saves shaders in the Directed Graph Shader Language (DGSL) format, which is an XML format that's based on Directed Graph Markup Language (DGML). You can apply DGSL shaders directly to 3D models in the Model Editor. However, before you can use a DGSL shader in your app, you must export it to a format that DirectX understands—for example, HLSL.

Because DGSL is compatible with DGML, you can use tools that are designed to analyze DGML documents to analyze your DGSL shaders. For information about DGML, see [Understanding Directed Graph Markup Language (DGML)](../modeling/customize-code-maps-by-editing-the-dgml-files.md).

## Related topics

|Title|Description|
|-----------|-----------------|
|[Shader Designer](../designers/shader-designer.md)|Describes how to use the Visual Studio Shader Designer to work with shaders.|
|[Shader Designer nodes](../designers/shader-designer-nodes.md)|Discusses the kinds of Shader Designer nodes that you can use to achieve graphics effects.|
|[Shader Designer examples](../designers/how-to-create-a-basic-color-shader.md)|Provides links to topics that demonstrate how to use the Shader Designer to achieve common graphics effects.|
