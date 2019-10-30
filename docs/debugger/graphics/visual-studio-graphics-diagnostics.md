---
title: "Graphics diagnostics | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.graphics"
ms.assetid: fa69c550-62a7-41b5-bb1f-7eb04af1a6e8
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Visual Studio Graphics Diagnostics
Visual Studio*Graphics Diagnostics* is a set of tools for recording and then analyzing rendering and performance problems in Direct3D apps. Graphics Diagnostics can be used on apps that are running locally on your Windows PC, in a Windows device emulator, or on a remote PC or device.

 The Graphics Diagnostics workflow begins by capturing a record of how your app uses Direct3D—live, as it runs—so that its behavior can be analyzed immediately, shared, or saved for later. Capture sessions can be initiated and controlled manually from Visual Studio or with the command-line capture tool **dxcap.exe**. Capture sessions can also be initiated and controlled programmatically by using the Graphics Diagnostics capture APIs.

 After a capture session has been recorded its contents can be played back by Visual Studio *Graphics Analyzer* at any time, recreating the captured frames by using the exact same resources and rendering commands the app used. Then, using the tools provided in the Graphics Analyzer window, any of the captured frames can be analyzed in detail. These tools can be used to examine any Direct3D API call, resource, pipeline state object, pipeline stage, or even the complete history of any pixel in a captured frame. By using these tools in concert, a rendering problem can be explored intuitively, starting from how it appears in a captured frame and drilling down to its root cause in the app's source code, shaders, or graphics assets.

 To diagnose performance problems, a captured frame can be analyzed by using the *Frame Analysis* tool. This tool explores potential performance optimizations by automatically changing the way the app uses Direct3D and benchmarking all the variations for you. In the past, you might have made and benchmarked these kinds of changes manually just to find out which ones made a difference. With Frame Analysis, you only need to make the changes you already know will pay off.

 Graphics Diagnostics helps your graphically-rich Direct3D app look and run its best.

 Continue to [Overview](overview-of-visual-studio-graphics-diagnostics.md) to learn more about what Visual Studio Graphics Diagnostics offers.

## In This Section
 [Overview](overview-of-visual-studio-graphics-diagnostics.md)
 Introduces the Graphics Diagnostics workflow and tools.

 [Getting Started](getting-started-with-visual-studio-graphics-diagnostics.md)
 In this section, you'll learn how to install Visual Studio Graphics Diagnostics and how to start using Graphics Diagnostics with your Direct3D app.

 [Capturing Graphics Information](capturing-graphics-information.md)
 To use Graphics Diagnostics to examine a rendering problem in your app, you first record information about how the app uses DirectX. During the recording session, as your app runs normally, you *capture* (that is, select) the frames that you're interested in. The captures contain detailed information about how the frames are rendered. You can save the captured information as a graphics log document to examine later or share with other members of your team.

 [GPU Usage](../../profiling/gpu-usage.md)
 To use Graphics Diagnostics to profile your app, use the GPU Usage tool. GPU usage can be used in concert with other profiling tools, such as CPU Usage, to correlate CPU and GPU activity that might contribute to performance problems in your app.

 [Graphics Log Document](graphics-log-document.md)
 To start the examination of a recorded graphics log, you use the Graphics Log document window to select a captured frame—or even a specific pixel—so that you can examine in detail the *events* (that is, the DirectX API calls) that affect it.

 [Frame Analysis](graphics-frame-analysis.md)
 After you select a frame, you use Graphics Frame Analysis to examine and tune your rendering performance.

 [Event List](graphics-event-list.md)
 After you select a frame, you use the **Graphics Event List** to examine its events to determine whether they are related to the rendering problem.

 [State](graphics-state.md)
 The State window helps you understand the graphics state that is active at the time of the current event.

 [Pipeline Stages](graphics-pipeline-stages.md)
 In the **Graphics Pipeline Stages** window, you investigate how the currently selected event is processed by each stage of the graphics pipeline so that you can identify where the rendering problem first appears. Examining the pipeline stages is particularly helpful when an object doesn't appear because of an incorrect transformation, or when one of the stages produces output that doesn't match what the next stage expects.

 [Event Call Stack](graphics-event-call-stack.md)
 You use the **Graphics Event Call Stack** to examine the call stack of the currently selected event so that you can navigate to app code that's related to the rendering problem.

 [Pixel History](graphics-pixel-history.md)
 By using the **Graphics Pixel History** window to analyze how the currently selected pixel is affected by the events that influenced it, you can identify the event or combination of events that cause certain kinds of rendering problems. The pixel history is particularly helpful when an object is rendered incorrectly because pixel shader output is either incorrect or has been combined incorrectly with the frame buffer, or when an object doesn't even appear because its pixels have been discarded before they reach the frame buffer.

 [Object Table](graphics-object-table.md)
 You use the **Graphics Object Table** to examine the properties and contents of specific Direct3D objects and resources that are in effect for the currently selected event. The object table can help you determine the graphics device context that's active during an event, and examine the contents of graphics resources such as constant buffers, vertex buffers, and textures.

 [HLSL Debugger](hlsl-shader-debugger.md)
 To examine how the shader code for the currently selected event and graphics pipeline stage behaves, you use the **HLSL Debugger** to step through code, examine the contents of variables, and perform other typical debugging tasks. You can also use the HLSL debugger to examine compute shader code, regardless of whether the results are further processed by the graphics pipeline or are just read back by your app.

 [Command-Line Capture Tool](command-line-capture-tool.md)
 Use the command-line capture tool to quickly capture and play back graphics information without using Visual Studio or programmatic capture. In particular, you can use the command-line capture tool for automation, or in a test environment.

 [Examples](graphics-diagnostics-examples.md)
 Several examples demonstrate how to use the Graphics Diagnostics tools together to diagnose different kinds of rendering problems.

## Related Sections

| Title | Description |
| - | - |
| [Debugger Feature Tour](../debugger-feature-tour.md) | Introduces the debugging functionality in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]. |
| [DirectX Graphics and Gaming](/windows/win32/directx) | Provides articles that discuss DirectX graphics technologies. |
