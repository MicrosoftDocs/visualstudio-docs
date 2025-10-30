---
title: Working with 3D Assets for Games and Apps
description: Learn about the Visual Studio tools that you can use to create or modify 3D models, textures, and shaders for DirectX-based games and apps.
ms.date: 11/04/2016
ms.topic: concept-article
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: ui-designers
---
# Work with 3D assets for games and apps

This article describes the Visual Studio tools that you can use to create or modify 3D models, textures, and shaders for DirectX-based games and apps.

## DirectX app development in Visual Studio

A DirectX app typically combines programming logic, the DirectX API, and High Level Shading Language (HLSL) programs, together with audio and 3D visual assets to present a rich, interactive multimedia experience. Visual Studio includes tools that you can use to work with images and textures, 3D models, and shaders without leaving the IDE to use another tool. The Visual Studio tools are especially suited for creating *placeholder* assets, which you can use to test code or build prototypes before you commission production-ready assets, and for inspecting and modifying production-ready assets when you are debugging your app.

Here's more information about the kinds of assets you can work with in Visual Studio.

### Images and textures

Images and textures provide color and visual detail in games and apps. In 3D graphics, textures come in a variety of formats, types, and geometries to support different uses. For example, normal maps provide per-pixel surface normals for more-detailed lighting of 3D models, and cube maps provide texture in all directions for uses such as sky-boxing, reflections, and spherical texture mapping. Textures can provide mipmaps to support efficient rendering at different levels of detail, and can support different color channels and color orderings. Textures can be stored in a variety of compressed formats that occupy less dedicated graphics memory and help GPUs access textures more efficiently.

You can use the Visual Studio Image Editor to work with images and textures in many common types and formats.

### 3D models

3D models create space and shape in games and apps. Minimally, models encode the position of points in 3D space—which are known as *vertices*—together with indexing data to define lines or triangles that represent the shape of the model. Additional data can be associated with these vertices—for example, color information, normal vectors, or application-specific attributes. Each model can also define object-wide attributes—for example, which shader is used to compute the appearance of the object's surface, or which texture is applied to it.

You can use the Visual Studio Model Editor to work with 3D models in several common formats.

### Shaders

Shaders are small, domain-specific programs that run on the graphics processing unit (GPU). Shaders determine how 3D models are transformed into on-screen shapes and how each pixel in those shapes is colored. By creating a shader and applying it to an object in your game or app, you can give the object a unique appearance.

You can use the Visual Studio Shader Designer, which is a graph-based shader design tool, to create custom visual effects without knowing HLSL programming.

> [!NOTE]
> For more information about how to start with DirectX programming, see [DirectX](/windows/win32/directx). For more information about how to debug a DirectX-based app, see [Graphics diagnostics (debugging DirectX graphics)](../debugger/graphics/visual-studio-graphics-diagnostics.md).

## DirectX version compatibility

Visual Studio uses DirectX to render 2D and 3D assets. You can select either the DirectX 11 renderer, or the Windows Advanced Rasterization Platform (WARP) software renderer. The DirectX 11 renderer provides high-performance, hardware-accelerated rendering on DirectX 11 and DirectX 10 GPUs. The WARP renderer helps make sure that your assets work with a broad range of computers—this includes computers that don't have modern graphics hardware and computers that have integrated graphics hardware. For more information about WARP, see [Windows Advanced Rasterization Platform (WARP) guide](/windows/win32/direct3darticles/directx-warp).

## Related topics

|Title|Description|
|-----------|-----------------|
|[Working with textures and images](../designers/working-with-textures-and-images.md)|Describes how to use Visual Studio to work with images and textures.|
|[Working with 3D models](../designers/working-with-3-d-models.md)|Describes how to use Visual Studio to work with 3D models.|
|[Working with shaders](../designers/working-with-shaders.md)|Describes how to use the Visual Studio Shader Designer to create and modify custom shader effects.|
|[Using 3D assets in your game or app](../designers/using-3-d-assets-in-your-game-or-app.md)|Describes how to use assets, which you created by using the Image Editor, Model Editor, or Shader Designer, in your game or app.|
