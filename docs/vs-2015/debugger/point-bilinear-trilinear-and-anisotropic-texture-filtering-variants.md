---
title: "Point, Bilinear, Trilinear, and Anisotropic Texture Filtering Variants | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 57d14fc9-b5f7-45ee-9717-48086886742d
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Point, Bilinear, Trilinear, and Anisotropic Texture Filtering Variants
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Overrides the filtering mode on appropriate texture samplers.  
  
## Interpretation  
 Different methods of texture sampling have different performance costs and image quality. In order of increasing cost—and increasing visual quality—the filter modes are:  
  
1. Point filtering (least expensive, worst visual quality)  
  
2. Bilinear filtering  
  
3. Trilinear filtering  
  
4. Anisotropic filtering (most expensive, best visual quality)  
  
   If the performance cost of each variant is significant or increases with more-intensive filtering modes, you can weigh its cost against its increased image quality. Based on your assessment, you might accept additional performance costs to increase visual quality, or you might accept decreased visual quality to achieve a higher frame-rate or to reclaim performance that you can use in other ways.  
  
   If you find that performance cost is negligible or steady regardless of the filtering mode—for example, when the GPU that you're targeting has an abundance of shader throughput and memory bandwidth—consider using anisotropic filtering to achieve the best image quality in your app.  
  
## Remarks  
 These variants override the sampler states on calls to `ID3D11DeviceContext::PSSetSamplers` in which the application-provided sampler's filter mode is one of these:  
  
- `D3D11_FILTER_MIN_MAG_MIP_POINT`  
  
- `D3D11_FILTER_MIN_MAG_POINT_MIP_LINEAR`  
  
- `D3D11_FILTER_MIN_POINT_MAG_LINEAR_MIP_POINT`  
  
- `D3D11_FILTER_MIN_POINT_MAG_MIP_LINEAR`  
  
- `D3D11_FILTER_MIN_LINEAR_MAG_MIP_POINT`  
  
- `D3D11_FILTER_MIN_LINEAR_MAG_POINT_MIP_LINEAR`  
  
- `D3D11_FILTER_MIN_MAG_LINEAR_MIP_POINT`  
  
- `D3D11_FILTER_MIN_MAG_MIP_LINEAR`  
  
- `D3D11_FILTER_ANISOTROPIC`  
  
  In the **Point Texture Filtering** variant, the application-provided filter mode is replaced with `D3D11_FILTER_MIN_MAG_MIP_POINT`; in the **Bilinear Texture Filtering** variant, it's replaced with `D3D11_FILTER_MIN_MAG_LINEAR_MIP_POINT`; and in the **Trilinear Texture Filtering** variant, it's replaced with `D3D11_FILTER_MIN_MAG_MIP_LINEAR`.  
  
  In the **Anisotropic Texture Filtering** variant, the application-provided filter mode is replaced with `D3D11_FILTER_ANISOTROPIC`, and the Max Anisotropy is set to 16.  
  
## Restrictions and limitations  
 In Direct3D, feature level 9.1 specifies a maximum anisotropy of 2x. Because the **Anisotropic Texture Filtering** variant attempts to use 16x anisotropy exclusively, playback fails when frame analysis is run on a feature-level 9.1 device. Contemporary devices that are affected by this limitation include the ARM-based Surface RT and Surface 2 Windows tablets. Older GPUs that might still be found in some computers can also be affected, but they're widely considered to be obsolete and are increasingly uncommon.  
  
## Example  
 The **Point Texture Filtering** variant can be reproduced by using code like this:  
  
```  
D3D11_SAMPLER_DESC sampler_description;  
  
// ... other sampler description setup ...  
  
sampler_description.Filter = D3D11_FILTER_MIN_MAG_MIP_POINT;  
  
d3d_device->CreateSamplerState(&sampler_desc, &sampler);  
d3d_context->PSSetSamplers(0, 1, &sampler  
```  
  
## Example  
 The **Bilinear Texture Filtering** variant can be reproduced by using code like this:  
  
```  
D3D11_SAMPLER_DESC sampler_description;   
  
// ... other sampler description setup ...  
  
sampler_description.Filter = D3D11_FILTER_MIN_MAG_LINEAR_MIP_POINT;  
  
d3d_device->CreateSamplerState(&sampler_desc, &sampler);  
d3d_context->PSSetSamplers(0, 1, &sampler  
```  
  
## Example  
 The **Trilinear Texture Filtering** variant can be reproduced by using code like this:  
  
```  
D3D11_SAMPLER_DESC sampler_description;   
  
// ... other sampler description setup ...  
  
sampler_description.Filter = D3D11_FILTER_MIN_MAG_MIP_LINEAR;  
  
d3d_device->CreateSamplerState(&sampler_desc, &sampler);  
d3d_context->PSSetSamplers(0, 1, &sampler  
```  
  
## Example  
 The **Anisotropic Texture Filtering** variant can be reproduced by using code like this:  
  
```  
D3D11_SAMPLER_DESC sampler_description;   
  
// ... other sampler description setup ...  
  
sampler_description.Filter = D3D11_FILTER_ANISOTROPIC;  
sampler_description.MaxAnisotropy = 16;  
  
d3d_device->CreateSamplerState(&sampler_desc, &sampler);  
d3d_context->PSSetSamplers(0, 1, &sampler  
```
