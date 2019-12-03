---
title: "Using 3-D Assets in Your Game or App | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
f1_keywords:
  - "VC.Project.ImageContentTask.ContentOutput"
  - "VC.Project.MeshContentTask.ContentOutput"
  - "VC.Project.ImageContentTask.GeneratePremultipliedAlpha"
  - "VC.Project.ImageContentTask.Compress"
  - "VC.Project.ShaderGraphContentTask.ContentOutput"
  - "VC.Project.ImageContentTask.GenerateMips"
ms.assetid: ea587909-e434-46a8-abf8-9b3e95a58b4f
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: jillfra
---
# Using 3-D Assets in Your Game or App
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This article describes how you can use [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] to process 3-D assets and include them in your builds.

 After you use the tools in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] to create 3-D assets, the next step is to use them in your app. But before you can use them, your assets have to be transformed into a format that DirectX can understand. To help you transform your assets, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] provides build customizations for each kind of asset that it can produce. To include the assets in your build, all you have to do is configure your project to use the build customizations, add the assets to your project, and configure the assets to use the correct build customization. After that, you can load the assets into your app and use them by creating and filling DirectX resources just like you would in any other DirectX app.

## Configuring your project
 Before you can deploy your 3-D assets as part of your build, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] has to know about the kinds of assets that you want to deploy. [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] already knows about many common file types, but because only certain kinds of apps use 3-D assets, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] doesn't assume that a project will build these kinds of files. You can tell [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] that your app uses these kinds of assets by using the *build customizations*—files that tell [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] how to process different types of files in a useful way—that are provided for each asset type. Because these customizations are applied on a per-project basis, all you have to do is add the appropriate customizations to your project.

#### To add the build customizations to your project

1. In **Solution Explorer**, open the shortcut menu for the project, and then choose **Build Dependencies**, **Build Customizations**. The **Visual C++ Build Customizations Files** dialog box is displayed.

2. Under **Available Build Customization Files**, select the check boxes that correspond to the asset types that you want to use in your project, as described in this table:

    |Asset type|Build customization Name|
    |----------------|------------------------------|
    |Textures and images|**ImageContentTask(.targets, .props)**|
    |3-D Models|**MeshContentTask(.targets, .props)**|
    |Shaders|**ShaderGraphContentTask(.targets, .props)**|

3. Choose the **OK** button.

## Including assets in your build
 Now that your project knows about the different kinds of 3-D assets that you want to use, the next step is to tell it which files are 3-D assets, and which kinds of assets they are.

#### To add an asset to your build

1. In **Solution Explorer**, in your project, open the shortcut menu of an asset, and then choose **Properties**. The asset's **Property Page** dialog box is displayed.

2. Make sure that the **Configuration** and **Platform** properties are set to the values that you want your changes to apply to.

3. Under **Configuration Properties**, choose **General**, and then in the property grid, under **General**, set the **Item Type** property to the appropriate content pipeline item type. For example, for an image or texture file, choose **Image Content Pipeline**.

   > [!IMPORTANT]
   > By default, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] assumes that many kinds of image files should be categorized by using the **Image** item type that's built into [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. Therefore, you have to change the **Item Type** property of each image that you want to be processed by the image content pipeline. Other types of content pipeline source files for 3-D models and visual shader graphics default to the correct **Item Type**.

4. Choose the **OK** button.

   Here are the three content pipeline item types and their associated source and output file types.

|Item Type|Source file types|Output file format|
|---------------|-----------------------|------------------------|
|**Image Content Pipeline**|Portable Network Graphics (.png)<br /><br /> JPEG (.jpg, .jpeg, .jpe, .jfif)<br /><br /> Direct Draw Surface (.dds)<br /><br /> Graphics Interchange Format (.gif)<br /><br /> Bitmap (.bmp, .dib)<br /><br /> Tagged Image File Format (.tif, .tiff)<br /><br /> Targa (.tga)|DirectDraw Surface (.dds)|
|**Mesh Content Pipeline**|AutoDesk FBX Interchange File (.fbx)<br /><br /> Collada DAE File (.dae)<br /><br /> Wavefront OBJ File (.obj)|3-D mesh file (.cmo)|
|**Shader Content Pipeline**|Visual Shader Graph (.dgsl)|Compiled Shader Output (.cso)|

## Configuring asset content pipeline properties
 You can set the content pipeline properties of each asset file so that it will be built in a specific way.

#### To configure content pipeline properties

1. In **Solution Explorer**, in your project, open the shortcut menu for the asset file, and then choose **Properties**. The asset's **Property Page** dialog box is displayed.

2. Make sure that the **Configuration** and **Platform** properties are set to the values that you want your changes to apply to.

3. Under **Configuration Properties**, choose the content pipeline node—for example, **Image Content Pipeline** for texture and image assets—and then in the property grid, set the properties to the appropriate values. For example, to generate mipmaps for a texture asset at build time, set the **Generate Mips** property to **Yes**.

4. Choose the **OK** button.

### Image content pipeline configuration
 When you use the image content pipeline tool to build a texture asset, you can compress the texture in various ways, indicate whether MIP levels should be generated at build time, and change the name of the output file.

|Property|Description|
|--------------|-----------------|
|**Compress**|Specifies the compression type that's used for the output file.<br /><br /> The available options are:<br /><br /> -   **No Compression**<br />-   **BC1_UNORM compression**<br />-   **BC1_UNORM_SRGB compression**<br />-   **BC2_UNORM compression**<br />-   **BC2_UNORM_SRGB compression**<br />-   **BC3_UNORM compression**<br />-   **BC3_UNORM_SRGB compression**<br />-   **BC4_UNORM compression**<br />-   **BC4_SNORM compression**<br />-   **BC5_UNORM compression**<br />-   **BC5_SNORM compression**<br />-   **BC6H_UF16 compression**<br />-   **BC6H_SF16 compression**<br />-   **BC7_UNORM compression**<br />-   **BC7_UNORM_SRGB compression**<br /><br /> For information about which compression formats are supported in different versions of DirectX, see [Programming Guide for DXGI](https://go.microsoft.com/fwlink/p/?LinkId=246265).|
|Convert to pre-multiplied alpha format|**Yes** to convert the image to pre-multiplied alpha format in the output file; otherwise, **No**. Only the output file is changed, the source image is unchanged.|
|**Generate Mips**|**Yes** to generate a full MIP chain at build time and include it in the output file; otherwise, **No**. If **No**, and the source file already contains a mipmap chain, then the output file will have a MIP chain; otherwise, the output file will have no MIP chain.|
|**Content Output**|Specifies the name of the output file. **Important:**  Changing the file name extension of the output file has no effect on its file format.|

### Mesh content pipeline configuration
 When you use the mesh content pipeline tool to build a mesh asset, you can change the name of the output file.

|Property|Description|
|--------------|-----------------|
|**Content Output**|Specifies the name of the output file. **Important:**  Changing the file name extension of the output file has no effect on its file format.|

### Shader content pipeline configuration
 When you use the shader content pipeline tool to build a shader asset, you can change the name of the output file.

|Property|Description|
|--------------|-----------------|
|**Content Output**|Specifies the name of the output file. **Important:**  Changing the file name extension of the output file has no effect on its file format.|

## Loading and using 3-D assets at run time

### Using textures and images
 Direct3D provides functions for creating texture resources. In Direct3D 11, the D3DX11 utility library provides additional functions for creating texture resources and resource views directly from image files. For more information about how to create a texture resource in Direct3D 11, see [Textures](https://go.microsoft.com/fwlink/p/?LinkID=246267). For more information about how to use the D3DX11 library to create a texture resource or resource view from an image file, see [How to: Initialize a Texture From a File](https://go.microsoft.com/fwlink/p/?LinkId=246268).

### Using 3-D models
 Direct3D 11 does not provide functions for creating resources from 3-D models. Instead, you have to write code that reads the 3-D model file and creates vertex and index buffers that represent the 3-D model and any resources that the model requires—for example, textures or shaders.

### Using shaders
 Direct3D provides functions for creating shader resources and binding them to the programmable graphics pipeline. For more information about how to create a shader resource in Direct3D and bind it to the pipeline, see [Programming Guide for HLSL](https://go.microsoft.com/fwlink/p/?LinkID=261521).

 In the programmable graphics pipeline, each stage of the pipeline must give the next stage of the pipeline a result that's formatted in a way that it can understand. Because the Shader Designer can only create pixel shaders, this means that it's up to your app to ensure that the data that it receives is in the format that it expects. Several programmable shader stages occur before the pixel shader and perform geometric transformations—the vertex shader, the hull shader, the domain shader, and the geometry shader. The non-programmable tessellation stage also occurs before the pixel shader. No matter which of these stages directly precedes the pixel shader, it must give its result in this format:

```hlsl

struct PixelShaderInput
{
    float4 pos : SV_POSITION;
    float4 diffuse : COLOR;
    float2 uv : TEXCOORD0;
    float3 worldNorm : TEXCOORD1;
    float3 worldPos : TEXCOORD2;
    float3 toEye : TEXCOORD3;
    float4 tangent : TEXCOORD4;
    float3 normal : TEXCOORD5;
};
```

 Depending on the Shader Designer nodes that you use in your shader, you might also have to provide additional data in the format according to these definitions:

```

Texture2D Texture1 : register( t0 );
Texture2D Texture2 : register( t1 );
Texture2D Texture3 : register( t2 );
Texture2D Texture4 : register( t3 );
Texture2D Texture5 : register( t4 );
Texture2D Texture6 : register( t5 );
Texture2D Texture7 : register( t6 );
Texture2D Texture8 : register( t7 );

TextureCube CubeTexture1 : register( t8 );
TextureCube CubeTexture2 : register( t9 );
TextureCube CubeTexture3 : register( t10 );
TextureCube CubeTexture4 : register( t11 );
TextureCube CubeTexture5 : register( t12 );
TextureCube CubeTexture6 : register( t13 );
TextureCube CubeTexture7 : register( t14 );
TextureCube CubeTexture8 : register( t15 );

SamplerState TexSampler : register( s0 );

cbuffer MaterialVars : register (b0)
{
    float4 MaterialAmbient;
    float4 MaterialDiffuse;
    float4 MaterialSpecular;
    float4 MaterialEmissive;
    float MaterialSpecularPower;
};

cbuffer LightVars : register (b1)
{
    float4 AmbientLight;
    float4 LightColor[4];
    float4 LightAttenuation[4];
    float3 LightDirection[4];
    float LightSpecularIntensity[4];
    uint IsPointLight[4];
    uint ActiveLights;
}

cbuffer ObjectVars : register(b2)
{
    float4x4 LocalToWorld4x4;
    float4x4 LocalToProjected4x4;
    float4x4 WorldToLocal4x4;
    float4x4 WorldToView4x4;
    float4x4 UVTransform4x4;
    float3 EyePosition;
};

cbuffer MiscVars : register(b3)
{
    float ViewportWidth;
    float ViewportHeight;
    float Time;
};
```

## Related topics

|Title|Description|
|-----------|-----------------|
|[How to: Export a Texture that Contains Mipmaps](../designers/how-to-export-a-texture-that-contains-mipmaps.md)|Describes how to use the Image Content Pipeline to export a texture that contains precomputed mipmaps.|
|[How to: Export a Texture that has Premultiplied Alpha](../designers/how-to-export-a-texture-that-has-premultiplied-alpha.md)|Describes how to use the Image Content Pipeline to export a texture that contains premultiplied alpha values.|
|[How to: Export a Texture for Use with Direct2D or Javascipt Apps](../designers/how-to-export-a-texture-for-use-with-direct2d-or-javascipt-apps.md)|Describes how to use the Image Content Pipeline to export a texture that can be used in a Direct2D or JavaScript app.|
|[Working with 3-D Assets for Games and Apps](../designers/working-with-3-d-assets-for-games-and-apps.md)|Describes the editing tools that Visual Studio provides for creating and manipulating 3-D assets, which include textures and images, 3-D models, and shaders.|
|[How to: Export a Shader](../designers/how-to-export-a-shader.md)|Describes how to export a shader from the Shader Designer.|
