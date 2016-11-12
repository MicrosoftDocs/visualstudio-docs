---
title: "1x1 Viewport Size Variant | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3dbc3247-00f5-4644-8ff9-72e9febcf09a
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# 1x1 Viewport Size Variant
Reduces the viewport dimensions on all render targets to 1x1 pixels.  
  
## Interpretation  
 A smaller viewport reduces the number of pixels that must be shaded, but doesn't reduce the number of vertices that must be processed. Setting the viewport dimensions to 1x1 pixels effectively eliminates pixel-shading from your app.  
  
 If this variant shows a large performance gain, it might indicate that your app consumes too much fillrate. This can indicate that the resolution you have chosen is too high for the target platform or that your app spends significant time shading pixels that are later overwritten (overdraw). This result suggests that decreasing the size of your framebuffer or reducing the amount of overdraw will improve your app's performance.  
  
## Remarks  
 The viewport dimensions are reset to 1x1 pixels after every call to `ID3D11DeviceContext::OMSetRenderTargets` or `ID3D11DeviceContext::RSSetViewports`.  
  
## Example  
 This variant can be reproduced by using code like this:  
  
```  
D3D11_VIEWPORT viewport;  
viewport.TopLeftX = 0;  
viewport.TopLeftY = 0;  
viewport.Width = 1;  
viewport.Height = 1;  
d3d_context->RSSetViewports(1, &viewport);  
```