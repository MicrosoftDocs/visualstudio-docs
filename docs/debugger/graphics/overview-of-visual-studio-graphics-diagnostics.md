---
title: "Overview of graphics diagnostics | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "02/09/2017"
ms.topic: "conceptual"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Overview of Visual Studio Graphics Diagnostics
Visual Studio *Graphics Diagnostics* is a set of tools for recording and then analyzing rendering and performance problems in Direct3D apps. Graphics Diagnostics can be used on apps that are running locally on your Windows PC or on a remote PC or device.

## Using Graphics Diagnostics to debug rendering problems
 Debugging rendering problems in a graphically-rich app is not as straight-forward as starting a debugger and stepping through some code. In each frame, hundreds of thousands of unique pixels are produced, each according to a complex set of state, data, parameters, and code—of these, perhaps only a few pixels will exhibit the problem you are trying to diagnose. To complicate matters even further, the code that generates each pixel is executed on specialized hardware that processes hundreds of pixels in parallel. Traditional debugging tools and techniques—which are difficult to leverage in even lightly-threaded code—are ineffective when faced with so much data.

 The Graphics Diagnostics tools in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] are designed to help you locate rendering problems by starting with the visual artifacts that indicate the problem and then tracing back to the source of the problem by focusing only on relevant shader code, pipeline stages, draw calls, resources, and device state—in the app's own source code.

## DirectX version compatibility
 Graphics Diagnostics supports apps that use Direct3D 10 or greater, and provides limited support for apps that use Direct2D. It does not support apps that use earlier versions of Direct3D, DirectDraw, or other graphics APIs.

### Windows 10 and Direct3D 12
 Windows 10 introduced *Direct3D 12*, which is substantially different from Direct3D 10 and Direct3D 11. These differences bring DirectX back into alignment with modern graphics hardware and unleashing its full potential, but they also bring big API changes and place greater responsibility on the programmer to manage resource lifetimes and contention. Despite the differences, Graphics Diagnostics with Direct3D 12 maintains feature-parity with Graphics Diagnostics with Direct3D 11.2.

 Windows 10 also maintains support for previous versions of Direct3D and the games and applications that rely on them. Graphics Diagnostics in Visual Studio continues to support Direct3D 10 and Direct3D 11 on Windows 10.

### Limited Direct2D support
 Because Direct2D is a user-mode API that's built on top of Direct3D, you can use Graphics Diagnostics to help debug rendering problems in apps that use Direct2D. However, because only the underlying Direct3D events are recorded instead of the higher-level Direct2D events, Direct2D events won't appear in the Graphics Event List. Also, because the relationship between Direct2D events and the resulting Direct3D events are not always clear, using Graphics Diagnostics to debug rendering problems in apps that use Direct2D is not straight forward. Still, you can use Graphics Diagnostics to get information about low-level rendering problems in apps that use Direct2D.

## Graphics Diagnostics features in Visual Studio
 Graphics Diagnostics has a dedicated interface - the Graphics Analyzer window - for diagnosing rendering problems, but it also adds some tools to the Visual Studio interface.

### The graphics toolbar (Visual Studio)
 The Graphics toolbar provides quick access to Graphics Diagnostics commands.

 The **Start Diagnostics** button runs the app under Graphics Diagnostics. When an app is running under Graphics Diagnostics, the **Capture the next rendered frame** button is enabled.

### Diagnostics capture interface
 When you run your app under Graphics Diagnostics, Visual Studio displays a diagnostics session interface that you can use to capture frames and which also displays the current CPU and GPU load. The CPU and GPU load is displayed to help you identify frames you might want to capture due to their performance characteristics, rather than rendering errors.

 This isn't the only way to capture frames though. You can also capture frames by using the programmatic capture interface, or by using the command-line capture program, dxcap.exe.

 See [Capturing Graphics Information](capturing-graphics-information.md) for more information.

### GPU Usage
 Graphics Diagnostics can also profile the performance of your Direct3D app. Because profiling data would be skewed by recording details of graphics events, this is separate from capturing frames to be used examined with the Graphics Analyzer.

 See [GPU Usage](../../profiling/gpu-usage.md) for more information.

### DirectX control panel
 The DirectX control panel is a component of DirectX that you can use to change the way that DirectX behaves—for example, you can enable the debug version of the DirectX runtime components, select the kind of debug messages that are reported, and disallow certain graphics hardware capabilities from being used to emulate less-capable hardware. This level of control over DirectX can help you debug and test your DirectX app. You can access the DirectX control panel from Visual Studio.

#### To open the DirectX control panel

- On the menu bar, choose **Debug**, **Graphics**, **DirectX Control Panel**.

## Graphics Analyzer
 The Visual Studio Graphics Analyzer is a dedicated interface for examining rendering and performance problems in frames you've already captured. Inside Graphics Analyzer, you'll find several tools to help you explore and understand the rendering behavior of your app. Each tool exposes a different kind of information about the frame that's being inspected, and the tools are designed to be used in concert to intuitively narrow-in on the source of a rendering problem, starting from the its appearance in the framebuffer.

 This illustration shows a typical layout of tools in the Graphics Analyzer.

 ![All of the graphics debugger windows](media/graphicsdebuggerwindows.png "GraphicsDebuggerWindows")

### The graphics toolbar (Graphics Analyzer)
 The Graphics toolbar provides quick access to Graphics Analyzer tool windows.

 ![The Graphics toolbar in graphics diagnostics mode](media/vsg_toolbar.png "vsg_toolbar")

### Graphics log document
 Inside the Graphics Analyzer, the graphics log document is the most prominent tool window. This window represents all of the frames you captured by running your app under Graphics Diagnostics. From here, you can select a different frame to examine or select a specific pixel that you want to examine with the Pixel History tool. The framebuffer image displayed in this document changes to reflect the currently selected Event so that you can see how the framebuffer is affected over time.

 The [Graphics Log Document](graphics-log-document.md) is also the entry point to the Frame Analysis tool, which helps you understand the performance of a frame by changing the way certain aspects of rendering are configured and providing benchmark results to compare with the original.

### Event list
 Graphic events mark each Direct3D API call and user-defined event.

 The [Event List](graphics-event-list.md) shows all of the graphics events that were recorded during the frame you're examining. To help you find what's important, the event list can be viewed hierarchically—with recent state-changes underneath the subsequent draw call—or as a timeline. Additionally, events are color-coded based on the queue they belong to and you can filter the list to only include the events you're interested in.

 When you select an event in the list, the rest of the Graphics Analysis tools reflect the state of the frame at the time of that event. In this way, you can see the effect of any event on the GPU. For example, you can see the immediate effect of any draw call on the framebuffer, even if it becomes obscured by subsequent draw calls. Some events also have hyperlinks you can follow to see more details about its parameters or related resource objects.

### Pipeline stages
 Each draw call in your app goes through the graphics pipeline provided by Direct3D. At each stage in the pipeline, output from the previous stage is transformed by a small program, called a shader, and then passed to the next stage until it is finally rendered to the screen. Many rendering errors occur at the boundary between pipeline stages when the output format is different than the next stage expects, or when any one stage simply produces incorrect results. Normally, you only get the final results as you would see on your screen and you can't easily tell where in the pipeline the error occurred.

 The [Pipeline Stages](graphics-pipeline-stages.md) window visualizes the result of each stage independently, so that you can more easily determine which stage a rendering problem first appears in. Once you've determined which stage that is, you can start debugging its shader right from the Pipeline Stages window.

### Graphics State
 Rendering operations depend on a lot of state that's typically spread across multiple objects. Many kinds of rendering problems are caused by misconfigured state.

 The [State](graphics-state.md) window collects the state information relevant to each draw call together in one place so that it's easier to find, and also highlights the state changes that have occurred since the previous draw call.

### Pixel history
 In complex scenes, it's not uncommon for a pixel to be shaded multiple times in a single frame. Sometimes the earlier color is just overwritten, but other times the colors are combined together to achieve effects such as transparency. When the result of combining them together doesn't have the right appearance you can't easily tell if it's because one of the colors was incorrect, or if there's a problem with the way they were combined. Other times, an object might appear to be missing because its contribution to the pixel was rejected for some reason.

 The [Pixel History](graphics-pixel-history.md) window visualizes the complete shader history of every pixel in the frame, including rejected contributions. For contributions that weren't rejected, it displays the raw shader results and how each new color was combined with the previous one. With this information, it's much easier to locate the source of errors in pixels that blend shader results, or when a rendered object is missing because its contribution to the pixel was incorrectly rejected.

### Event call stack
 Shader code isn't the only source of rendering problems in a Direct3D app, sometimes your app's source code passes the wrong parameter or doesn't configure Direct3D quite right. One kind of error that the previously discussed feature, Pixel History, can help you find is when a rendered object is missing because all its pixels have been rejected. This kind of error usually happens when you misconfigured a setting, such as the one that controls how the depth test is performed, and you can usually find your mistake somewhere in the call stack of the missing object's draw call.

 The [Event Call Stack](graphics-event-call-stack.md) window displays the complete call stack of every graphics event in the Event List, and even lets you jump to your app's source code if debugging information is available. This is a powerful tool for following an error from where it first appears, on the GPU, back to where it originated in your app's source code.

### Object table
 Every frame your app renders is probably backed by hundreds or even thousands of resource objects. These can include back buffers and render targets, textures, vertex buffers, index buffers, general buffers—almost everything Direct3D remembers is an object.

 The [Object Table](graphics-object-table.md) displays all the objects that exist at the time of the graphics event selected in the event list. Since most objects in a typical app are textures, the event list is optimized to show details relevant to images at a glance. The Type column tells you what kind of object is in each row, and the Format column further shows the sub-type or version of the object. Other details are also shown. Some objects also have hyperlinks you can follow to view the object with a more specialized viewer, such as textures (you can view the texture as an image), or buffers (you can choose how the buffer viewer parses and displays the raw buffer bytes by defining the buffer format).

### Frame analysis
 Your app's graphics don't just need to be correct - they need to be fast, too. Even on less-powerful devices like laptops with integrated graphics or mobile phones. And they still need to look great too.

 The [Frame Analysis](graphics-frame-analysis.md) tool explores potential performance optimizations by automatically changing the way the app uses Direct3D and providing benchmark results for comparison. For example, Frame Analysis can enable mip-mapping on every texture, which might reveal textures that could benefit from mip-mapping but don't currently have it enabled. On hardware that supports it, Frame Analysis also presents information collected from the GPU's performance counters—this level of information can identify hardware-level performance issues, such as high numbers of texture fetch stalls or cache misses.

 But Frame Analysis isn't just about going fast - it's about gaining the most performance you can while giving up the least amount of visual quality. Sometimes an expensive effect that looks great on a large display doesn't make the same impact when viewed on the small screen of a phone, where a simpler effect might look just as good without draining the battery. The automatic changes and benchmarks that Graphics Analysis provides can help you find the balance that's right for your app across a range of devices.

## See also
- [Command-Line Capture Tool](command-line-capture-tool.md)
- [HLSL Debugger](hlsl-shader-debugger.md)