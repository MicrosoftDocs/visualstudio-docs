---
title: "Graphics Diagnostics Examples | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 45dd86b2-801e-4b07-a8c4-7bd25641d7f8
caps.latest.revision: 36
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Graphics Diagnostics Examples
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

These examples show how to debug rendering problems in DirectX-based apps by using [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Graphics Diagnostics.  
  
## Capturing graphics information  
 Before you can use Graphics Diagnostics to diagnose rendering problems in your app, you have to capture graphics information from the app while it's running. Graphics information can be captured from an app that's running locally, or from an app that's running on a remote computer or other device. These walkthroughs demonstrate how you can capture graphics information from an app manually or programmatically:  
  
- [Walkthrough: Capturing Graphics Information](../debugger/walkthrough-capturing-graphics-information.md)  
  
- [Walkthrough: Capturing Graphics Information Programmatically](../debugger/walkthrough-capturing-graphics-information-programmatically.md)  
  
## Use Graphics Diagnostics with an ARM-based device  
 You can use Graphics Diagnostics to debug your Direct3D app on an ARM-based device by using remote debugging. For more information see [How to: Use Graphics Diagnostics with an ARM Device](../debugger/how-to-use-graphics-diagnostics-with-an-arm-device.md).  
  
## Playing back graphics information  
 After you capture graphics information from a running app, you can play back the captured events to diagnose rendering problems. To play back, you can use your development machine, or you can use a remote machine or device that you are connected to. For more information, see [How to: Change the Graphics Diagnostics Playback Machine](../debugger/how-to-change-the-graphics-diagnostics-playback-machine.md).  
  
## Debugging missing objects  
 A missing object (or objects) is one of the most common rendering problems that graphics developers experience. This kind of problem can be difficult to diagnose because several different kinds of errors might cause an object to apparently disappear. Typical causes for missing objects include misconfigured device state, problems in transforming the object's geometry, or a misconfigured graphics pipeline.  
  
 These scenarios demonstrate how you can use Graphics Diagnostics to determine why an object is missing and find the code that’s responsible.  
  
- [Walkthrough: Missing Objects Due to Device State](../debugger/walkthrough-missing-objects-due-to-device-state.md)  
  
- [Walkthrough: Missing Objects Due to Vertex Shading](../debugger/walkthrough-missing-objects-due-to-vertex-shading.md)  
  
- [Walkthrough: Missing Objects Due to Misconfigured Pipeline](../debugger/walkthrough-missing-objects-due-to-misconfigured-pipeline.md)  
  
## Debugging rendering errors  
 An object (or objects) not having the correct appearance is another common problem that graphics developers experience. This kind of problem can be difficult to diagnose because the incorrect appearance, and its cause, can range from very obvious—binding the wrong texture—to very subtle—a bug in the shader code or an unexpected interaction between shaders. Some problems might be caused by a combination of errors.  
  
 Here's a scenario that demonstrates how you can use Graphics Diagnostics to track down a not-so-subtle rendering problem that's caused by a minor shader bug:  
  
- [Walkthrough: Debugging Rendering Errors Due to Shading](../debugger/walkthrough-debugging-rendering-errors-due-to-shading.md)  
  
## Debugging compute shaders  
 You can use Graphics Diagnostics to debug DirectCompute compute-shader kernels that generate incorrect results. With DirectCompute, you can use the computational power of the GPU to perform calculations on a large number of data elements in parallel. For certain kinds of problems, utilizing the GPU can perform many times faster than even well-optimized CPU code. However, traditional debuggers can't detect code that runs on the GPU. Debugging this kind of code requires specialized tools that are often vendor-specific, and might not integrate well with Visual Studio. To make compute-shader debugging more consistent across a range of GPUs, Graphics Diagnostics captures DirectCompute Dispatch events—in addition to Direct3D rendering events—so that you can use familiar tools to debug problems in your compute-shader code.  
  
 For a scenario that demonstrates how to debug a simulation problem that's caused by a bug in a compute shader, see [Walkthrough: Using Graphics Diagnostics to Debug a Compute Shader](../debugger/walkthrough-using-graphics-diagnostics-to-debug-a-compute-shader.md).
