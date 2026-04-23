---
title: Working with 3D Models
description: Learn about creating 3D models by using the Model Editor in Visual Studio, which you can use in your DirectX-based game or app.
ms.date: 11/04/2016
ms.topic: concept-article
author: Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: ui-designers
---
# Work with 3D models

You can use the Model Editor in Visual Studio to create 3D models. You can use the models in your DirectX-based game or app.

> [!NOTE]
> Visual Studio 2022 17.9.3 removed support for the Model Editor and MeshContentTask due to security concerns in the Autodesk FBX SDK. See [CVE-2023-27911](https://msrc.microsoft.com/update-guide/vulnerability/CVE-2023-27911).

## 3D models

3D models define the shape of objects as they exist in a 3D scene. Models can be basic solitary objects, complex objects that are formed from hierarchies of basic objects, or even entire 3D scenes. A 3D object is made up of points in 3D space (known as *vertices*), indices that define triangles, lines, or other primitives that are made up of those points, and attributes that might apply on a per-vertex or per-primitive basis—for example, surface normals. Additionally, some information might apply on a per-object basis—for example, which shader and textures will give the object its unique appearance.

The Model Editor is the only tool you need to create basic 3D models—complete with material properties, textures, and pixel shaders—that you can use in your game or app. Or, you can create placeholder models to use for prototyping and testing before you engage artists to finalize the models.

You can also use the Model Editor to view existing 3D models that have been created by using full-featured tools, and to modify them if you observe problems in the art assets.

## Related topics

|Title|Description|
|-----------|-----------------|
|[Model Editor](../designers/model-editor.md)|Describes how to use the Model Editor to work with 3D models.|
|[Model Editor examples](../designers/how-to-create-a-basic-3-d-model.md)|Provides links to topics that demonstrate how to use the Model Editor to perform common 3D modeling tasks.|
