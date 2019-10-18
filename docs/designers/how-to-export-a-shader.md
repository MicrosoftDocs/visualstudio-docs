---
title: "How to: Export a Shader"
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: 0bd48bf4-9792-4456-a545-e462a2be668d
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Export a shader

This article demonstrates how to use the **Shader Designer** to export a Directed Graph Shader Language (DGSL) shader so that you can use it in your app.

## Export a shader

After you create a shader by using the Shader Designer and before you can use it in your app, you have to export it in a format that your graphics API understands. You can export a shader in different ways to meet different needs.

1. In Visual Studio, open a **Visual Shader Graph (.dgsl)** file.

     If you don't have a **Visual Shader Graph (.dgsl)** file to open, create one as described in [How to: Create a basic color shader](../designers/how-to-create-a-basic-color-shader.md).

2. On the **Shader Designer** toolbar, choose **Advanced** > **Export** > **Export As**. The **Export Shader** dialog box appears.

3. In the **Save as type** drop-down list, choose the format that you want to export.

     Here are the formats that you can choose:

     **HLSL Pixel Shader (\*.hlsl)**
     Exports the shader as High Level Shader Language (HLSL) source code. This option makes it possible to modify the shader later, even after it's deployed in an app. This can make it easier to debug and patch the code based on end-user problems, but it also makes it easier for a user to modify your shader in unwanted ways—for example, to gain an unfair advantage in a competitive game. It also might increase the load time of the shader.

     **Compiled Pixel Shader (\*.cso)**
     Exports the shader as HLSL bytecode. This option makes it possible to modify the shader later, even after it's deployed in an app. This can make it easier to debug and patch the code based on end-user problems, but because the shader is pre-compiled, it does not incur extra runtime overhead when the shader is loaded by the app. Sufficiently skilled users can still modify the shader in unwanted ways, but compiling the shader makes this significantly more difficult.

     **C++ Header (\*.h)**
     Exports the shader as a C-style header that defines a byte array that contains HLSL bytecode. This option can make it more time-consuming to debug and patch the code based on end-user problems because the app must be recompiled to test the fix. However, because this option makes it difficult, though not impossible, to modify the shader after it's deployed in an app, it presents the most difficulty to a user who wants to modify the shader in unwanted ways.

4. In the **File name** combo box, specify a name for the exported shader, and then choose the **Save** button.

## See also

- [How to: Create a basic color shader](../designers/how-to-create-a-basic-color-shader.md)
- [Shader Designer](../designers/shader-designer.md)