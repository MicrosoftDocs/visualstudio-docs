---
title: "Troubleshooting and Known Issues (Visual Studio Tools for Unity) | Microsoft Docs"
ms.custom: ""
ms.date: "10/25/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8f5db192-8d78-4627-bd07-dbbc803ac554
caps.latest.revision: 5
author: "conceptdev"
ms.author: "crdun"
manager: crdun
ms.workload: 
  - "unity"
---
# Troubleshooting and Known Issues (Visual Studio Tools for Unity)
In this section, you'll find solutions to common issues with Visual Studio Tools for Unity, descriptions of known issues, and learn how you can help improve Visual Studio Tools for Unity by reporting errors.  

## Troubleshooting  
To resolve some common issues with Visual Studio Tools for Unity, see the following sections.  

### Visual Studio crashes
This can be due to the Visual Studio MEF cache being corrupted.

You should remove the following folder to reset the MEF cache (please close Visual Studio before doing this):

```batch
%localappdata%\Microsoft\VisualStudio\<version>\ComponentModelCache
```

This should fix your issue. In case you are still experiencing the problem, run a Developer Command Prompt for Visual Studio as Administrator and use the following command:

```batch
 devenv /setup
```

### Issues with VS2015 and Intellisense or code coloration.
You should try to upgrade your Visual Studio 2015 to update 3.

### Visual Studio hangs
Several Unity plugins like Parse, FMOD, UMP (Universal Media Player), ZFBrowser or Embedded Browser are using native threads. It’s an issue when a plugin ends up attaching a native thread to the runtime, which then does blocking calls to the OS. This means Unity can't interrupt that thread for the debugger (or domain reload) and hang.

For FMOD, there is a workaround, you can pass FMOD_STUDIO_INIT_SYNCHRONOUS_UPDATE initialization [flag](https://www.fmod.org/docs/content/generated/FMOD_STUDIO_INITFLAGS.html) to disable asynchronous processing and perform all processing on the main thread.

### Incompatible project in Visual Studio
First, check that Visual Studio is set as your external script editor in Unity (Edit/Preferences/External Tools). Then check that the Visual Studio   plugin is installed in Unity (Help/About must display a message like Microsoft Visual Studio Tools for Unity is enabled at the bottom). Then check that the extension is properly installed in Visual Studio (Help/About).

### Assembly reference issues
If your project is complex reference-wise or if you want to better control this generation step, you can use our [API](../cross-platform/customize-project-files-created-by-vstu.md) for manipulating the generated project or solution content. You can also use [response files](https://docs.unity3d.com/Manual/PlatformDependentCompilation.html) in your Unity project and we'll process them.

### Breakpoints with a warning
If Visual Studio is unable to find a source location for a specific breakpoint you will see a warning around your breakpoint. Check that the behaviour you are using is properly loaded/used in the current Unity scene.

### Breakpoints not hit
 Check that the behaviour you are using is properly loaded/used in the current Unity scene. Quit both Visual Studio and Unity then delete all generated files (*.csproj, *.sln) and the whole Library folder.

### Unable to attach
-	Try to temporarily disable your antivirus or create exclusion rules for both VS and Unity.
-	Try to temporarily disable your firewall or create rules for allowing TCP/UDP networking between VS and Unity.
-	We identified that programs like Team Viewer are interfering with process detection; perhaps you can try to stop temporarily any extra software to see if it changes something.
-	Do not rename the main Unity executable, as VSTU is only monitoring "Unity.exe" processes.

### Unable to debug Android players
We use multicast for player detection (which is the default mechanism used by Unity), but after that we use a regular TCP connection to attach the debugger. The detection phase is the main issue for Android devices.

USB is super-fast for debugging, but not compatible with the Unity player discovery mechanism.
Wifi is more versatile but super slow compared to USB because of latency. We saw a lack of proper multicast support for some routers or devices (Nexus series are well known for this).

You could try the following using USB to see opened ports on the connected device (with the player up and running so that you can see the debugging port, always in the form 56xxx):

```shell  
adb shell netstat
```  

Forward the port to the local pc:

```shell  
adb forward tcp:56xxx tcp:56xxx
```  

Then, connect VSTU using the forwarded port 127.0.0.1:56xxx.

### Migrating from UnityVS to Visual Studio Tools for Unity  
 If you're migrating from UnityVS to Visual Studio Tools for Unity, you'll need to generate new Visual Studio solutions for your Unity projects.  

##### To migrate your Unity project from UnityVS 1.8 to Visual Studio Tools for Unity 1.9  

1.  Delete the old solution and project files from your Unity project. In the root directory of your Unity project, locate the Visual Studio .sln and .*proj files and delete them all.  

2.  Import the Visual Studio Tools for Unity package into your Unity project. For information on how to import the VSTU package, see Configure Visual Studio Tools for Unity on the [Getting Started](../cross-platform/getting-started-with-visual-studio-tools-for-unity.md) page.  

3.  Generate the new solution and project files. If you want to generate them now, in the Unity Editor, on the main menu, choose **Visual Studio Tools**, **Generate Project Files**. Otherwise, you can skip this step if you want; Visual Studio Tools for Unity will generate the new files automatically when you choose **Visual Studio Tools**, **Open in Visual Studio**.  

### On Windows, Visual Studio asks to download the Unity target framework  
 Visual Studio Tools for Unity requires the .net framework 3.5, which isn't installed by default on Windows 8 or 10. To fix this issue, follow the instructions to download and install the .net framework 3.5.  

## Known Issues  
 There are known issues in Visual Studio Tools for Unity that result from how the debugger interacts with Unity's older version of the C# compiler. We're working to help fix these problems, but you might experience the following issues in the meantime:  

-   When debugging, Unity sometimes crashes.  

-   When debugging, Unity sometimes freezes.  

-   Stepping into and out of methods sometimes behaves incorrectly, especially in iterators or within switch statements.  

## Reporting Errors  
 Please help us improve the quality of Visual Studio Tools for Unity by sending error reports when you experience crashing, freezes, or other errors. This helps us investigate and fix problems in Visual Studio Tools for Unity. Thank you!  

### How to report an error when Visual Studio freezes  
 There are reports that Visual Studio sometimes freezes when debugging with Visual Studio Tools for Unity, but we need more data to understand this problem. You can help us investigate by following the steps below.  

##### To report that Visual Studio freezes while debugging with Visual Studio Tools for Unity

*On Windows:*  

1.  Open a new instance of Visual Studio.

2.  Open the Attach to Process dialog. In the new instance of Visual Studio, on the main menu, choose **Debug**, **Attach to Process**.  

3.  Attach the debugger to the frozen instance of Visual Studio. In the **Attach to Process** dialog, select the frozen instance of Visual Studio from the **Available Processes** table, then choose the **Attach** button.  

4.  Pause the Debugger. In the new instance of Visual Studio, on the main menu, choose **Debug**, **Break All**, or just press **Ctrl+Alt+Break**.  

5.  Create a thread-dump. In the Command window, enter the following command and press **Enter**:  

    ```powershell  
    Debug.ListCallStack /AllThreads /ShowExternalCode  
    ```  

    You might need to make the **Command** window visible first. In Visual Studio, on the main menu, choose **View**, **Other Windows**, **Command Window**.  

*On Mac:*

1. Open a terminal and get the PID of Visual Studio for Mac:

    ```shell  
    ps aux | grep "[V]isual Studio.app"
    ```

1. Launch the lldb debugger:

    ```shell  
    lldb
    ```

1. Attach to the Visual Studio for Mac instance using the PID:

    ```shell  
    process attach --pid THE_PID_OF_THE_VSFM_PROCESS
    ```

1. Retrieve the stacktrace for all the threads:

    ```shell  
    bt all
    ```

Finally, send the thread-dump to [vstusp@microsoft.com](mailto:vstusp@microsoft.com), along with a description of what you were doing when Visual Studio became frozen.
