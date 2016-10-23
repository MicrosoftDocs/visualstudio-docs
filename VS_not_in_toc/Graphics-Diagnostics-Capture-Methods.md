---
title: "Graphics Diagnostics Capture Methods"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ea21995d-0241-412e-8f62-600c3794247f
caps.latest.revision: 2
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Graphics Diagnostics Capture Methods
Insert introduction here.  
  
## Capture methods  
 InWindows 8.1, the DirectX 11.2 runtime can capture graphics information internally on behalf of debugging tools like graphics diagnostics—this is known as *robust capture*. Before this support was added to the DirectX runtime, graphics information was captured by intercepting certain DirectX function calls to record arguments and other information before forwarding the calls to DirectX to be completed—this is called *legacy capture*.  
  
 Because the DirectX runtime takes exclusive responsibility for capturing graphics information in Windows 8.1, there is no need to update legacy capture to support DirectX 11.2, and therefore, legacy capture is deprecated. However, because the DirectX 11.2 runtime doesn't support versions of Windows prior to Windows 8.1, Visual Studio 2013 still supports legacy capture for apps that target Windows 8 and Windows 7.  
  
 Both methods record similar information and don't change how you capture graphics information or use the Graphics Diagnostics tools.  
  
### Robust capture  
 Robust capture supports Visual Studio 2013 graphics diagnostics on Windows 8.1, Windows RT 8.1, and Windows Phone 8.1. It supports DirectX 10.0 through DirectX 11.2 and can capture graphics information about new Direct3D 11.2 features—for example, tiled resources. However, it doesn't fully support all Direct3D 11.2 features—for example, you can't debug an HLSL shader that was created by using the HLSL shader linking feature. Robust capture uses a new capture API to support its programmatic capture scenarios.  
  
### Legacy capture  
 Legacy capture supports Visual Studio 2013 and Visual Studio 2012 graphics diagnostics on Windows 8, Windows RT 8, and Windows 7. It supports DirectX 10.0 through DirectX 11.1. Legacy capture doesn't support any Direct3D 11.2 features and is deprecated except for scenarios in which robust capture is not available. Legacy capture uses the capture API defined in the `vsgcapture.h` header file to support its programmatic capture scenarios. This kind of programmatic capture is also deprecated except for scenarios in which robust capture is not available.  
  
## See Also  
 [Capturing Graphics Information](../VS_debugger/Capturing-Graphics-Information.md)   
 [Walkthrough: Capturing Graphics Information](../VS_debugger/Walkthrough--Capturing-Graphics-Information.md)