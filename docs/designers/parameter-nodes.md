---
title: Parameter Nodes
ms.date: 11/04/2016
ms.topic: reference
ms.assetid: da54db0b-3a3d-48dc-858c-7ac43aa04b13
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Parameter nodes

In the Shader Designer, parameter nodes represent inputs to the shader that are under the control of the app on a per-draw basis, for example, material properties, directional lights, camera position, and time. Because you can change these parameters with each draw call, you can use the same shader to give an object different appearances.

## Parameter node reference

|Node|Details|Properties|
|----------|-------------|----------------|
|**Camera World Position**|The position of the camera in world space.<br /><br /> **Output:**<br /><br /> `Output`: `float4`<br /> The position of the camera.|None|
|**Light Direction**|The vector that defines the direction in which light is cast from a light source in world space.<br /><br /> You can use this to calculate lighting and specular contributions in world space.<br /><br /> **Output:**<br /><br /> `Output`: `float3`<br /> The vector from the current pixel to a light source.|None|
|**Material Ambient**|The diffuse color contribution of the current pixel that is attributed to indirect lighting.<br /><br /> The diffuse color of a pixel simulates how lighting interacts with rough surfaces. You can use the Material Ambient parameter to approximate how indirect lighting contributes to the appearance of an object in the real world.<br /><br /> **Output:**<br /><br /> `Output`: `float4`<br /> The diffuse color of the current pixel that's due to indirect—that is, ambient— lighting.|**Access**<br /> **Public** to enable the property to be set from the Model Editor; otherwise, **Private**.<br /><br /> **Value**<br /> The diffuse color of the current pixel that's due to indirect—that is, ambient—lighting.|
|**Material Diffuse**|A color that describes how the current pixel diffuses direct lighting.<br /><br /> The diffuse color of a pixel simulates how lighting interacts with rough surfaces. You can use the Material Diffuse parameter to change how the current pixel diffuses direct lighting—that is, directional, point, and spot lights.<br /><br /> **Output:**<br /><br /> `Output`: `float4`<br /> A color that describes how the current pixel diffuses direct lighting.|**Access**<br /> **Public** to enable the property to be set from the Model Editor; otherwise, **Private**.<br /><br /> **Value**<br /> A color that describes how the current pixel diffuses direct lighting.|
|**Material Emissive**|The color contribution of the current pixel that is attributed to lighting that it supplies to itself.<br /><br /> You can use this to simulate a glowing object; that is, an object that supplies its own light. This light doesn't affect other objects.<br /><br /> **Output:**<br /><br /> `Output`: `float4`<br /> The color contribution of the current pixel that's due to self-provided lighting.|**Access**<br /> **Public** to enable the property to be set from the Model Editor; otherwise, **Private**.<br /><br /> **Value**<br /> The color contribution of the current pixel that's due to self-provided lighting.|
|**Material Specular**|A color that describes how the current pixel reflects direct lighting.<br /><br /> The specular color of a pixel simulates how lighting interacts with smooth, mirror-like surfaces. You can use the Material Specular parameter to change how the current pixel reflects direct lighting—that is, directional, point, and spot lights.<br /><br /> **Output:**<br /><br /> `Output`: `float4`<br /> A color that describes how the current pixel reflects direct lighting.|**Access**<br /> **Public** to allow the property to be set from the Model Editor; otherwise, **Private**.<br /><br /> **Value**<br /> A color that describes how the current pixel reflects direct lighting.|
|**Material Specular Power**|A scalar value that describes the intensity of specular highlights.<br /><br /> The larger the specular power, the more intense and far-reaching the specular highlights become.<br /><br /> **Output:**<br /><br /> `Output`: `float`<br /> An exponential term that describes the intensity of specular highlights on the current pixel.|**Access**<br /> **Public** to enable the property to be set from the Model Editor; otherwise, **Private**.<br /><br /> **Value**<br /> The exponent that defines the intensity of specular highlights on the current pixel.|
|**Normalized Time**|The time in seconds, normalized to the range [0, 1], such that when time reaches 1, it resets to 0.<br /><br /> You can use this as a parameter in shader calculations, for example, to animate texture coordinates, color values, or other attributes.<br /><br /> **Output:**<br /><br /> `Output`: `float`<br /> The normalized time, in seconds.|None|
|**Time**|The time in seconds.<br /><br /> You can use this as a parameter in shader calculations, for example, to animate texture coordinates, color values, or other attributes.<br /><br /> **Output:**<br /><br /> `Output`: `float`<br /> The time, in seconds.|None|