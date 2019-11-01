---
title: "Walkthrough: Capturing Graphics Information Programmatically | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Walkthrough: Capturing Graphics Information Programmatically
You can use [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] Graphics Diagnostics to programmatically capture graphics information from a Direct3D app.

Programmatic capture is useful in scenarios such as:

- Begin capture programmatically when your graphics app doesn't use swapchain present, such as when it renders to a texture.

- Begin capture programmatically when your app doesn't render at all, such as when it uses DirectCompute to perform calculations.

- Call `CaptureCurrentFrame`when a rendering problem is difficult to anticipate and capture in manual testing but can be predicted programmatically by using information about the state of the app at run time.

## <a name="CaptureDX11_2"></a> Programmatic capture in Windows 10
This part of the walkthrough demonstrates programmatic capture in apps that use the DirectX 11.2 API on Windows 10, which uses the robust capture method.

This section shows how to do these tasks:

- Preparing your app to use programmatic capture

- Getting the IDXGraphicsAnalysis interface

- Capturing graphics information

> [!NOTE]
> Previous implementations of programmatic capture relied on Remote Tools for Visual Studio for [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] to provide capture functionality.

### Preparing your app to use programmatic capture
To use programmatic capture in your app, it must include the necessary headers. These headers are part of the Windows 10 SDK.

##### To include programmatic capture headers

- Include these headers in the source file where you will define the IDXGraphicsAnalysis interface:

    ```cpp
    #include <DXGItype.h>
    #include <dxgi1_2.h>
    #include <dxgi1_3.h>
    #include <DXProgrammableCapture.h>
    ```

    > [!IMPORTANT]
    > Do not include the header file vsgcapture.h—which supports programmatic capture on Windows 8.0 and earlier—to perform programmatic capture in your Windows 10 apps. This header is incompatible with DirectX 11.2. If this file is included after the d3d11_2.h header is included, the compiler issues a warning. If vsgcapture.h is included before d3d11_2.h, the app will not start.

    > [!NOTE]
    > If the June 2010 DirectX SDK is installed on your machine and your project's include path contains `%DXSDK_DIR%includex86`, move it to the end of the include path. Do the same for your library path.

### Getting the IDXGraphicsAnalysis interface
Before you can capture graphics information from DirectX 11.2, you have to get the DXGI debug interface.

> [!IMPORTANT]
> When using programmatic capture, you must still run your app under graphics diagnostics (Alt+F5 in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]) or under the [Command-Line Capture Tool](command-line-capture-tool.md).

##### To get the IDXGraphicsAnalysis interface

- Use the following code to hook up the IDXGraphicsAnalysis interface to the DXGI debug interface.

  ```cpp
  IDXGraphicsAnalysis* pGraphicsAnalysis;
  HRESULT getAnalysis = DXGIGetDebugInterface1(0, __uuidof(pGraphicsAnalysis), reinterpret_cast<void**>(&pGraphicsAnalysis));
  ```

  Be sure to check the `HRESULT` returned by [DXGIGetDebugInterface1](/windows/desktop/api/dxgi1_3/nf-dxgi1_3-dxgigetdebuginterface1) to ensure you get a valid interface before you use it:

  ```cpp
  if (FAILED(getAnalysis))
  {
      // Abort program or disable programmatic capture in your app.
  }
  ```

  > [!NOTE]
  > If `DXGIGetDebugInterface1` returns `E_NOINTERFACE` (`error: E_NOINTERFACE No such interface supported`), make sure the app is running under graphics diagnostics (Alt+F5 in [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)]).

### Capturing graphics information
Now that you have a valid `IDXGraphicsAnalysis` interface, you can use `BeginCapture` and `EndCapture` to capture graphics information.

##### To capture graphics information

- To start capturing graphics information, use `BeginCapture`:

    ```cpp
    ...
    pGraphicsAnalysis->BeginCapture();
    ...
    ```

    Capture begins immediately when `BeginCapture` is called; it doesn't wait for the next frame to begin. Capture stops when the current frame is presented, or when you call `EndCapture`:

    ```cpp
    ...
    pGraphicsAnalysis->EndCapture();
    ...
    ```

- After the call to `EndCapture`, release the graphics object.

## Next Steps
This walkthrough demonstrated how to capture graphics information programmatically. As a next step, consider this option:

- Learn how to analyze captured graphics information by using the Graphics Diagnostics tools. See [Overview](overview-of-visual-studio-graphics-diagnostics.md).

## See also
- [Walkthrough: Capturing Graphics Information](walkthrough-capturing-graphics-information.md)
- [Capturing Graphics Information](capturing-graphics-information.md)
- [Command-Line Capture Tool](command-line-capture-tool.md)
