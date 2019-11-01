---
title: "Troubleshooting and known issues (VS Tools for Unity)"
ms.custom: ""
ms.date: "07/03/2018"
ms.technology: vs-unity-tools
ms.topic: "conceptual"
ms.assetid: 8f5db192-8d78-4627-bd07-dbbc803ac554
author: therealjohn
ms.author: johmil
manager: crdun
ms.workload:
  - "unity"
---
# Troubleshooting and known issues (Visual Studio Tools for Unity)

In this section, you'll find solutions to common issues with Visual Studio Tools for Unity, descriptions of known issues, and learn how you can help improve Visual Studio Tools for Unity by reporting errors.

## Troubleshooting the connection between Unity and Visual Studio

### Confirm Editor Attaching is enabled

In the Unity Menu, select **Edit > Preferences** and then select the **External Tools** tab. Confirm that the **Editor Attaching** checkbox is enabled. For more information, see the [Unity Preferences documentation](https://docs.unity3d.com/Manual/Preferences.html).

### Unable to attach

- Try to temporarily disable your antivirus or create exclusion rules for both VS and Unity.
- Try to temporarily disable your firewall or create rules for allowing TCP/UDP networking between VS and Unity.
- Some programs, like Team Viewer, can interfere with process detection. You can try to temporarily stop any extra software to see if it changes something.
- Do not rename the main Unity executable, as VSTU is only monitoring "Unity.exe" processes.

## Visual Studio crashes

This issue can be due to the Visual Studio MEF cache being corrupted.

Try removing the following folder to reset the MEF cache (close Visual Studio before doing this):

```batch
%localappdata%\Microsoft\VisualStudio\<version>\ComponentModelCache
```

This should fix your issue. In case you are still experiencing the problem, run a Developer Command Prompt for Visual Studio as Administrator and use the following command:

```batch
 devenv /setup
```

## Visual Studio hangs

Several Unity plugins like Parse, FMOD, UMP (Universal Media Player), ZFBrowser, or Embedded Browser are using native threads. It’s an issue when a plugin ends up attaching a native thread to the runtime, which then does blocking calls to the OS. This means Unity can't interrupt that thread for the debugger (or domain reload) and hang.

For FMOD, there is a workaround, you can pass `FMOD_STUDIO_INIT_SYNCHRONOUS_UPDATE` initialization [flag](https://www.fmod.com/resources/documentation-studio?version=2.0&page=https://fmod.com/resources/documentation-api?version=2.0&page=studio-api-system.html#fmod_studio_initflags) to disable asynchronous processing and perform all processing on the main thread.

## Incompatible project in Visual Studio

First, check that Visual Studio is set as your external script editor in Unity (Edit/Preferences/External Tools). Then check that the Visual Studio   plugin is installed in Unity (Help/About must display a message like Microsoft Visual Studio Tools for Unity is enabled at the bottom). Then check that the extension is properly installed in Visual Studio (Help/About).

## Extra reloads, or Visual Studio losing all open windows

Be sure to never touch project files directly from an asset processor or any other tool. If you really need to manipulate the project file, we expose an API for that. Please check the [Assembly references issues section](#assembly-reference-issues).

If you experience extra reloads or if Visual Studio is losing all open Windows on reload, make sure that you have proper .NET targeting packs installed. Check the following section about frameworks for more information.

## The debugger does not break on exceptions

When using the legacy Unity runtime (.NET 3.5 equivalent), the debugger will always break when an exception is unhandled (=outside a try/catch block). If the exception is handled, the debugger will use the Exception Settings Window to determine if a break is required or not.

With the new runtime (.NET 4.6 equivalent), Unity introduced a new way for managing user exceptions and as a result, all exceptions are seen as "user-handled" even if they are outside a try/catch block. That's why you now need to explicitly check them in the Exception Settings Window if you want the debugger to break.

In the Exception Settings window (Debug > Windows > Exception Settings), expand the node for a category of exceptions (for example, Common Language Runtime Exceptions, meaning .NET exceptions), and select the check box for the specific exception you want to catch within that category (for example System.NullReferenceException). You can also select an entire category of exceptions.

## On Windows, Visual Studio asks to download the Unity target framework

Visual Studio Tools for Unity requires the .NET framework 3.5, which isn't installed by default on Windows 8 or 10. To fix this issue, follow the instructions to download and install the .NET framework 3.5.

When using the new Unity runtime, .NET targeting packs version 4.6 and 4.7.1 are also required. It is possible to use the VS2017 installer to quickly install them (modify your VS2017 installation, individual components, .NET category, select all 4.x targeting packs).

## Assembly reference issues

If your project is complex reference-wise or if you want to better control this generation step, you can use our [API](../cross-platform/customize-project-files-created-by-vstu.md) for manipulating the generated project or solution content. You can also use [response files](https://docs.unity3d.com/Manual/PlatformDependentCompilation.html) in your Unity project and we'll process them.

## Breakpoints with a warning

If Visual Studio is unable to find a source location for a specific breakpoint you will see a warning around your breakpoint. Check that the script you are using is properly loaded/used in the current Unity scene.

## Breakpoints not hit

Check that the script you are using is properly loaded/used in the current Unity scene. Quit both Visual Studio and Unity then delete all generated files (\*.csproj, \*.sln) and the whole Library folder.

## Unable to debug Android players

We use multicast for player detection (which is the default mechanism used by Unity), but after that we use a regular TCP connection to attach the debugger. The detection phase is the main issue for Android devices.

Wifi is versatile but super slow compared to USB because of latency. We saw a lack of proper multicast support for some routers or devices (Nexus series are well known for this).

USB is super-fast for debugging, and Visual Studio Tools for Unity is now able to detect USB devices, and talk to the adb server to properly forward ports for debugging.

## Issues with Visual Studio 2015 and IntelliSense or code coloration

Try upgrading your Visual Studio 2015 to update 3.

## Known issues

 There are known issues in Visual Studio Tools for Unity that result from how the debugger interacts with Unity's older version of the C# compiler. We're working to help fix these problems, but you might experience the following issues in the meantime:

- When debugging, Unity sometimes crashes.

- When debugging, Unity sometimes freezes.

- Stepping into and out of methods sometimes behaves incorrectly, especially in iterators or within switch statements.

## Report errors

 Please help us improve the quality of Visual Studio Tools for Unity by sending error reports when you experience crashing, freezes, or other errors. This helps us investigate and fix problems in Visual Studio Tools for Unity. Thank you!

### How to report an error when Visual Studio freezes

 There are reports that Visual Studio sometimes freezes when debugging with Visual Studio Tools for Unity, but we need more data to understand this problem. You can help us investigate by following the steps below.

##### To report that Visual Studio freezes while debugging with Visual Studio Tools for Unity

*On Windows:*

1. Open a new instance of Visual Studio.

1. Open the Attach to Process dialog. In the new instance of Visual Studio, on the main menu, choose **Debug**, **Attach to Process**.

1. Attach the debugger to the frozen instance of Visual Studio. In the **Attach to Process** dialog, select the frozen instance of Visual Studio from the **Available Processes** table, then choose the **Attach** button.

1. Pause the Debugger. In the new instance of Visual Studio, on the main menu, choose **Debug**, **Break All**, or just press **Ctrl+Alt+Break**.

1. Create a thread-dump. In the Command window, enter the following command and press **Enter**:

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
