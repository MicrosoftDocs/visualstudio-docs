---
title: "Graphics Pixel History | Microsoft Docs"
description: Troubleshoot rendering problems by seeing the history of a specific pixel. Graphics Pixel History shows the effects of Direct3D events.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.graphics.pixelhistory"
ms.assetid: 0a2cbde5-1ad9-487e-857c-a3664158c268
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Graphics Pixel History
The Graphics Pixel History window in Visual Studio Graphics Analyzer helps you understand how a specific pixel is affected by the Direct3D events that occur during a frame of your game or app.

 This is the Pixel History window:

 ![A pixel with three Direct3D events in its history.](media/gfx_diag_demo_pixel_history_orientation.png "gfx_diag_demo_pixel_history_orientation")

## Understanding the Pixel History window
 By using Pixel History, you can analyze how a specific pixel of the render target is affected by Direct3D events during a frame. You can pinpoint a rendering problem to a specific Direct3D event, even when subsequent events—or subsequent primitives in the same event—continue to change the pixel's final color value. For example, a pixel might be rendered incorrectly and then obscured by another, semi-transparent pixel so that their colors are blended together in the framebuffer. This kind of problem would be difficult to diagnose if you only had the final contents of the render target to guide you.

 The Pixel History window displays the complete history of a pixel over the course of the selected frame. The **Final Frame Buffer** at the top of the window displays the color that's written to the framebuffer at the end of the frame, together with additional information about the pixel such as the frame that it comes from and its screen coordinates. This area also contains the **Render Alpha** check box. When this check box is selected, the **Final Frame Buffer** color and intermediate color values are displayed with transparency over a checkerboard pattern. If the check box is cleared, the alpha channel of the color values is ignored.

 The bottom part of the window displays the events that had a chance to affect the color of the pixel, together with the **Initial** and **Final** pseudo-events that represent the initial and final color values of the pixel in the framebuffer. The initial color value is determined by the first event that changed the color of the pixel (typically a `Clear` event). A pixel always has these two pseudo-events in its history, even when no other events affected it. When other events had a chance to affect the pixel, they are displayed between the **Initial** and **Final** events. The events can be expanded to show their details. For simple events such as those that clear a render target, the effect of the event is just a color value. More complex events such as draw calls generate one or more primitives that might contribute to the color of the pixel.

 Primitives that were drawn by the event are identified by their primitive type and index, along with the total primitive count for the object. For example, an identifier such as **Triangle (1456) of (6214)** means that the primitive corresponds to the 1456th triangle in an object that's made up of 6214 triangles. To the left of each primitive identifier is an icon that summarizes the effect that the primitive had on the pixel. Primitives that affect the pixel color are represented by a rounded rectangle that's filled with the result color. Primitives that are excluded from having an effect on the pixel color are represented by icons that indicate the reason that the pixel was excluded. These icons are described in the section [Primitive exclusion](#exclusion) later in this article.

 You can expand each primitive to examine how the pixel shader output was merged with the existing pixel color to produce the result color. From here you can also examine or debug the pixel shader code that's associated with the primitive, and you can further expand the vertex shader node to examine the vertex shader input.

### <a name="exclusion"></a> Primitive exclusion
 If a primitive is excluded from affecting the pixel color, the exclusion could occur for a variety of reasons. Each reason is represented by an icon that's described in this table:

|Icon|Reason for exclusion|
|----------|--------------------------|
|![Depth test failure icon.](media/vsg_hist_icon_failed_depth.png "vsg_hist_icon_failed_depth")|The pixel was excluded because it failed the depth test.|
|![Scissor test failure icon.](media/vsg_hist_icon_failed_scissor.png "vsg_hist_icon_failed_scissor")|The pixel was excluded because it failed the scissor test.|
|![Stencil test failure icon.](media/vsg_hist_icon_failed_stencil.png "vsg_hist_icon_failed_stencil")|The pixel was excluded because it failed the stencil test.|

### Draw Call Exclusion
 If all of the primitives in a draw call are excluded from affecting the render target because they fail a test, then the draw call cannot be expanded and an icon that corresponds to the reason for exclusion is displayed next to it. The reasons for draw-call exclusion resemble the reasons for primitive exclusion, and their icons are similar.

### Viewing and debugging shader code
 You can examine and debug code for vertex, hull, domain, geometry and pixel shaders by using the controls below the primitive that's associated with the shader.

##### To view a shader's source code

1. In the **Graphics Pixel History** window, locate the draw call that corresponds to the shader you want to examine and expand it.

2. Under the draw call you just expanded, select a primitive that demonstrates the problem you're interested in and expand it.

3. Under the primitive you're interested in, follow the shader title link—for example, follow the link **Vertex Shader obj:30** to view the vertex shader source code.

    > [!TIP]
    > The object number, **obj:30**, identifies this shader throughout the Graphics Analyzer interface such as in the object table and pipeline stages window.

##### To debug a shader

1. In the **Graphics Pixel History** window, locate the draw call that corresponds to the shader you want to examine and expand it.

2. Then, under the draw call you just expanded, select a primitive that demonstrates the problem you're interested in and expand it.

3. Under the primitive you're interested in, choose **Start Debugging**. This entry point into the HLSL debugger defaults to the first invocation of the shader for the corresponding primitive—that is, the first pixel or vertex that's processed by the shader. There's only one pixel associated with the primitive, but there's more than one vertex shader invocations for lines and triangles.

     To debug the vertex shader invocation for a specific vertex, expand the VertexShader title link and locate the vertex you're interested in, then choose **Start Debugging** next to it.

### Links to graphics objects
 To understand the graphics events in the pixel history, you might need information about the device state at the time of the event or about the Direct3D objects that are referenced by the event. For each event in the pixel history, the **Graphics Pixel History** provides links to the then-current device state and to related objects.

## See also
- [Walkthrough: Missing Objects Due to Device State](walkthrough-missing-objects-due-to-device-state.md)
- [Walkthrough: Debugging Rendering Errors Due to Shading](walkthrough-debugging-rendering-errors-due-to-shading.md)