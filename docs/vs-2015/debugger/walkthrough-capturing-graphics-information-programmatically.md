---
title: "Walkthrough: Capturing Graphics Information Programmatically | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: a5adeff9-afaf-4047-b5ce-ef0aefe710eb
caps.latest.revision: 24
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Walkthrough: Capturing Graphics Information Programmatically
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Graphics Diagnostics to programmatically capture graphics information from a Direct3D app.  
  
 Programmatic capture is useful in scenarios such as:  
  
- Begin capture programmatically when your graphics app doesn't use swapchain present, such as when it renders to a texture.  
  
- Begin capture programmatically when your app doesn't render at all, such as when it uses DirectCompute to perform calculations.  
  
- Call `CaptureCurrentFrame`when a rendering problem is difficult to anticipate and capture in manual testing but can be predicted programmatically by using information about the state of the app at runtime.  
  
## <a name="CaptureDX11_2"></a> Programmatic capture in Windows 8.1  
 This part of the walkthrough demonstrates programmatic capture in apps that use the DirectX 11.2 API on Windows 8.1, which uses the robust capture method. For information about how to use programmatic capture in apps that use earlier versions of DirectX on Windows 8.0, see [Programmatic capture in Windows 8.0 and earlier](#CaptureDX11_1) later in this walkthrough.  
  
 This section shows how to do these tasks:  
  
- Preparing your app to use programmatic capture  
  
- Getting the IDXGraphicsAnalysis interface  
  
- Capturing graphics information  
  
> [!NOTE]
> Previous implementations of programmatic capture relied on Remote Tools for [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] to provide capture functionality, Windows 8.1 supports capture directly through Direct3D 11.2. As a result, you no longer have to install the Remote Tools for programmatic capture on Windows 8.1.  
  
### Preparing your app to use programmatic capture  
 To use programmatic capture in your app, it must include the necessary headers. These headers are part of the Windows 8.1 SDK.  
  
##### To include programmatic capture headers  
  
- Include these headers in the source file where you will define the IDXGraphicsAnalysis interface:  
  
    ```  
    #include <DXGItype.h>  
    #include <dxgi1_2.h>  
    #include <dxgi1_3.h>  
    #include <DXProgrammableCapture.h>  
    ```  
  
    > [!IMPORTANT]
    > Do not include the header file vsgcapture.h—which supports programmatic capture on Windows 8.0 and earlier—to perform programmatic capture in your Windows 8.1 apps. This header is incompatible with DirectX 11.2. If this file is included after the d3d11_2.h header is included, the compiler issues a warning. If vsgcapture.h is included before d3d11_2.h, the app will not start.  
  
    > [!NOTE]
    > If the June 2010 DirectX SDK is installed on your machine and your project's include path contains `%DXSDK_DIR%includex86`, move it to the end of the include path. Do the same for your library path.  
  
#### Windows Phone 8.1  
 Because the Windows Phone 8.1 SDK doesn't include the DXProgrammableCapture.h header, you'll need to define the `IDXGraphicsAnalysis` interface yourself so that you can use the `BeginCapture()` and `EndCapture()` methods. Include the other headers as described in the previous section.  
  
###### To define the IDXGraphicsAnalysis interface  
  
- Define the IDXGraphicsAnalysis interface in the same file in which you included the header files.  
  
  ```  
  interface DECLSPEC_UUID("9f251514-9d4d-4902-9d60-18988ab7d4b5") DECLSPEC_NOVTABLE  
  IDXGraphicsAnalysis : public IUnknown  
  {  
      STDMETHOD_(void, BeginCapture)() PURE;  
      STDMETHOD_(void, EndCapture)() PURE;  
  };  
  ```  
  
  For convenience, you can perform these steps in a new header file and then include it where it's needed in your app.  
  
### Getting the IDXGraphicsAnalysis interface  
 Before you can capture graphics information from DirectX 11.2, you have to get the DXGI debug interface.  
  
> [!IMPORTANT]
> When using programmatic capture, you must still run your app under graphics diagnostics (Alt+F5 in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]) or under the [Command-Line Capture Tool](../debugger/command-line-capture-tool.md).  
  
##### To get the IDXGraphicsAnalysis interface  
  
- Use the following code to hook up the IDXGraphicsAnalysis interface to the DXGI debug interface.  
  
    ```  
    IDXGraphicsAnalysis* pGraphicsAnalysis;  
    HRESULT getAnalysis = DXGIGetDebugInterface1(0, __uuidof(pGraphicsAnalysis), reinterpret_cast<void**>(&pGraphicsAnalysis));  
    ```  
  
     Be sure to check the `HRESULT` returned by `DXGIGetDebugInterface1` to ensure you get a valid interface before you use it:  
  
    ```  
    if (FAILED(getAnalysis))  
    {  
        // Abort program or disable programmatic capture in your app.  
    }  
    ```  
  
    > [!NOTE]
    > If `DXGIGetDebugInterface1` returns `E_NOINTERFACE` (`error: E_NOINTERFACE No such interface supported`), make sure the app is running under graphics diagnostics (Alt+F5 in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]).  
  
### Capturing graphics information  
 Now that you have a valid `IDXGraphicsAnalysis` interface, you can use `BeginCapture` and `EndCapture` to capture graphics information.  
  
##### To capture graphics information  
  
- To start capturing graphics information, use `BeginCapture`:  
  
    ```  
    ...  
    pGraphicsAnalysis->BeginCapture();  
    ...  
    ```  
  
     Capture begins immediately when `BeginCapture` is called; it doesn't wait for the next frame to begin. Capture stops when the current frame is presented, or when you call `EndCapture`:  
  
    ```  
    ...  
    pGraphicsAnalysis->EndCapture();  
    ...  
    ```  
  
## <a name="CaptureDX11_1"></a> Programmatic capture in Windows 8.0 and earlier  
 This part of the walkthrough demonstrates programmatic capture in apps for Windows 8.0 and earlier that use the DirectX 11.1 API, which uses the legacy capture method. For information about how to use programmatic capture in apps that use DirectX 11.2 on Windows 8.1, see [Programmatic capture in Windows 8.1](#CaptureDX11_2) earlier in this walkthrough.  
  
 This part shows these tasks:  
  
- Preparing your computer to use programmatic capture  
  
- Preparing your app to use programmatic capture  
  
- Configuring the name and location of the graphics log file  
  
- Using the `CaptureCurrentFrame` API  
  
### Preparing your computer to use programmatic capture  
 The programmatic capture API uses Remote Tools for [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] to provide capture functionality. The computer where the app will run must have the remote tools installed, even when you are using programmatic capture on your local computer. [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] doesn't have to be running when you perform programmatic capture on a local computer.  
  
 To use the remote capture APIs in an app that's running on a computer, you first have to install the Remote Tools for [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] on that computer. Different versions of the remote tools support different hardware platforms. For information about how to install the remote tools, see the [Remote Tools download page](https://go.microsoft.com/fwlink/p/?LinkId=246691) on the Microsoft downloads website.  
  
 Alternatively, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] installs the necessary components to perform remote capture for 32-bit apps.  
  
> [!NOTE]
> Because most Windows desktop apps—including [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]—are not supported on [!INCLUDE[win8](../includes/win8-md.md)] for ARM devices, using Remote Tools for [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] together with the programmatic capture API is the only way to capture graphics diagnostics on ARM devices.  
  
### Preparing your app to use programmatic capture  
 To use the Graphics Diagnostics tools, you first have to capture the graphics information that it relies on. You can programmatically capture the information by using the `CaptureCurrentFrame` API.  
  
##### To prepare your app to capture graphics information programmatically  
  
1. Make sure that the `vsgcapture.h` header is included in the source code for the app. It can be included in just one location—for example, in the source code file where you will call the programmatic capture API—or in a precompiled header file to call the API from multiple source code files.  
  
2. In the source code for the app, whenever you want to capture the remainder of the current frame, call `g_pVsgDbg->CaptureCurrentFrame()`. This method takes no parameters and doesn't return a value.  
  
### Configuring the name and location of the graphics log file  
 The graphics log is created in the location that's defined by the `DONT_SAVE_VSGLOG_TO_TEMP` and `VSG_DEFAULT_RUN_FILENAME` macros.  
  
##### To configure the name and location of the graphics log file  
  
- To prevent the graphics log from being written to the temp directory, before the `#include <vsgcapture.h>` line, add this:  
  
  ```  
  #define DONT_SAVE_VSGLOG_TO_TEMP  
  ```  
  
   You can define this value to write the graphics log to a location that's relative to the working directory, or to an absolute path if the definition of `VSG_DEFAULT_RUN_FILENAME` is an absolute path.  
  
- To save the graphics log to a different location, or give it a different file name, before the `#include <vsgcapture.h>` line, add this:  
  
  ```  
  #define VSG_DEFAULT_RUN_FILENAME <filename>  
  ```  
  
   If you don't perform this step, the file name is default.vsglog. If you didn't define `DONT_SAVE_VSGLOG_TO_TEMP`, then the location of the file is relative to the temp directory; otherwise, it's relative to the working directory or in another location if you specified an absolute file name.  
  
  For [!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] apps, the location of the temp directory is specific to each user and app, and is typically found in a location such as C:\users\\*username*\AppData\Local\Packages\\*package family name*\TempState\\. For desktop apps, the location of the temp directory is specific to each user and is typically found in a location such as C:\Users\\*username*\AppData\Local\Temp\\.  
  
> [!NOTE]
> To write to a specific location, you must have permissions to write to that location; otherwise, an error occurs. Keep in mind that [!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] apps are more restricted than desktop apps about where they can write data, and might require additional configuration to write to certain locations.  
  
### Capturing the graphics information  
 After you have prepared the app for programmatic capture and optionally configured the location and name of the graphics log file, build the app and then run or debug it to capture data; do not start graphics diagnostics from [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] when you use the programmatic capture API. The graphics log is written to the location that you specified. If you want to keep this version of the log, move it to another location; otherwise, it will be overwritten when you run the app again.  
  
> [!TIP]
> You can still capture graphics information manually while you're using programmatic capture— with the app in focus, just press **Print Screen**. You can use this technique to capture additional graphics information that's not captured by the programmatic capture API.  
  
## Next Steps  
 This walkthrough demonstrated how to capture graphics information programmatically. As a next step, consider this option:  
  
- Learn how to analyze captured graphics information by using the Graphics Diagnostics tools. See [Overview](../debugger/overview-of-visual-studio-graphics-diagnostics.md).  
  
## See Also  
 [Walkthrough: Capturing Graphics Information](../debugger/walkthrough-capturing-graphics-information.md)   
 [Capturing Graphics Information](../debugger/capturing-graphics-information.md)   
 [Command-Line Capture Tool](../debugger/command-line-capture-tool.md)
