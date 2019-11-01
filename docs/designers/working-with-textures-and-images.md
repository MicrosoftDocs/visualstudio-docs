---
title: Working with Textures and Images
ms.date: 11/04/2016
ms.topic: conceptual
ms.assetid: b9fbc8fa-66d1-4055-8460-24d8b8fbe43e
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Work with textures and images

You can use the Image Editor in Visual Studio to create and modify textures and images. The Image Editor supports rich texture and image formats like those that are used in DirectX app development.

> [!NOTE]
> The Image Editor doesn't support low-color images like icons or cursors. To create or modify those kinds of images, use the [Image Editor for icons (C++)](/cpp/windows/image-editor-for-icons).

## Textures and images

Textures and images are, at a basic level, just tables of data that are used to provide visual detail in graphics apps. The kind of detail that a texture or image provides depends on how it's used, but color samples, alpha (transparency) values, surface normals, and height values are common examples. The primary difference between a texture and an image is that a texture is meant to be used together with a representation of shape—typically a 3D model—to express a complete object or scene, but an image is typically a stand-alone representation of the object or scene.

Any texture can be encoded and compressed in a number of ways that are orthogonal to the type of data that a texture holds, or to the dimensionality or "shape" of the texture. However, different encoding and compression methods yield better results for different kinds of data.

You can use the Image Editor to create and modify textures and images in ways that resemble other image editors. The Image Editor also provides mipmapping and other features for use with 3D graphics, and supports many of the highly-compressed, hardware-accelerated texture formats that DirectX supports.

Common kinds of textures include:

### Texture maps

Texture maps contain color values that are organized as a one-, two-, or three-dimensional matrix. They are used to provide color detail on the affected object. Colors are commonly encoded by using RGB (red, green, blue) color channels, and may include a fourth channel, alpha, that represents transparency. Less commonly, colors could be encoded in another color scheme, or the fourth channel could contain data other than alpha—for example, height.

### Normal maps

Normal maps contain surface normals. They are used to provide lighting detail on the affected object. Normals are commonly encoded by using the red, green, and blue color components to store the x, y, and z dimensions of the vector. However, other encodings exist—for example, encodings that are based on polar coordinates.

### Height maps

Height maps contain height-field data. They are used to provide a form of geometric detail on the affected object—by using shader code to compute the desired effect—or to provide data points for uses like terrain generation. Height values are commonly encoded by using one channel in a texture.

### Cube maps

Cube maps can contain different types of data—for example, colors or normals—but are organized as six textures on the faces of a cube. Because of this, cube maps are not sampled by supplying texture coordinates, but by supplying a vector whose origin is the center of the cube; the sample is taken at the point where the vector intersects the cube. Cube maps are used to provide an approximation of the environment that can be used to calculate reflections—this is known as *environment mapping*—or to provide texture to spherical objects with less distortion than basic, two-dimensional textures can provide.

## Related topics

|Title|Description|
|-----------|-----------------|
|[Image Editor](../designers/image-editor.md)|Describes how to use the Image Editor to work with textures and images.|
|[Image Editor examples](../designers/how-to-create-a-basic-texture.md)|Provides links to topics that demonstrate how to use the Image Editor to perform common image processing tasks.|