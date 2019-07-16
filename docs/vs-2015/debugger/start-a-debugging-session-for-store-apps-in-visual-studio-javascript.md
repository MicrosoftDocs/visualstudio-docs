---
title: "Start a debugging session for Store Apps (JavaScript) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords:
  - "vs.debug.installedapppackagelauncher"
  - "vs.debug.error.wwahost_scriptdebuggingdisabled"
dev_langs:
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: fb91203f-2cf4-44d3-8ed9-93bc5aaa50b8
caps.latest.revision: 27
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Start a debugging session for Store Apps in Visual Studio (JavaScript)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Applies to Windows and Windows Phone](../Image/windows_and_phone_content.png "windows_and_phone_content")

 This topic describes how to start a debugging session for Windows Store apps written in JavaScript and HTML5. You can start debugging with a single keystroke, or you can configure the debugging session for specific scenarios and then choose the way to start the app.

> [!NOTE]
> For apps written in XAML and Visual C#, Visual C++, or Visual Basic, see [Start a debug session (VB, C#, C++ and XAML)](../debugger/start-a-debugging-session-for-a-store-app-in-visual-studio-vb-csharp-cpp-and-xaml.md)

## <a name="BKMK_In_this_topic"></a> In this topic
 [In this topic](#BKMK_In_this_topic)

 [The easy way to start debugging](#BKMK_The_easy_way_to_start_debugging)

 [Configure the debugging session](#BKMK_Configure_the_debugging_session)

- [Open the debugging property page for the project](#BKMK_Open_the_debugging_property_page_for_the_project)

- [Choose the build configuration options](#BKMK_Choose_the_build_configuration_options)

- [Choose the deployment target](#BKMK_Choose_the_deployment_target)

- [Choose the debugger to use](#BKMK_Choose_the_debugger_to_use)

- [(Optional) Delay starting the app in the debug session](#BKMK__Optional__Delay_starting_app_in_the_debug_session)

- [(Optional) Disable network loopbacks](#BKMK__Optional__Disable_network_loopbacks)

  [Start the debugging session](#BKMK_Start_the_debugging_session)

- [Start debugging (F5)](#BKMK_Start_debugging__F5_)

- [Start debugging (F5) but delay the app start](#BKMK_Start_debugging__F5__but_delay_the_app_start)

  [Start an installed app in the debugger](#BKMK_Start_an_installed_app_in_the_debugger)

  [Attach the debugger to a running app](#BKMK_Attach_the_debugger_to_a_running_app_)

- [Set the app to run in debug mode](#BKMK_Set_the_app_to_run_in_debug_mode)

- [Attach the debugger](#BKMK_Attach_the_debugger)

## <a name="BKMK_The_easy_way_to_start_debugging"></a> The easy way to start debugging
 ![Applies to Windows only](../debugger/media/windows-only-content.png "windows_only_content")

1. Open the app solution in Visual Studio.

2. If the solution contains projects for both Windows Store and Windows Store Phone apps, make sure that the project you want to debug is the start-up project. In Solution Explore, select the project and then choose **Set as StartUp Project** from the context menu.

3. Press F5.

   ![Applies to Windows Phone only](../debugger/media/phone-only-content.png "phone_only_content")

   Visual Studio builds and starts the app with the debugger attached. Execution continues until a breakpoint is reached, you manually suspend execution, an unhandled exception occurs, or the app ends. For more information, see [Quickstart: Debug HTML and CSS](../debugger/quickstart-debug-html-and-css.md).

## <a name="BKMK_Configure_the_debugging_session"></a> Configure the debugging session
 Because script is not compiled, the build configuration and platform settings don't apply. If you are debugging a C++ or managed component, set the **Configuration** to **Debug** and choose your target platform from the **Configuration** dialog.

### <a name="BKMK_Open_the_debugging_property_page_for_the_project"></a> Open the debugging property page for the project

1. In Solution Explorer, select the project. On the shortcut menu, choose **Properties**.

2. Expand the **Configuration Properties**  node and then choose **Debugging**

### <a name="BKMK_Choose_the_build_configuration_options"></a> Choose the build configuration options

1. From the **Configuration** list, choose **Debug** or **(Active) Debug**.

2. From the **Platform** list choose the target platform to build for. In most cases, **Any CPU** is the best choice.

### <a name="BKMK_Choose_the_deployment_target"></a> Choose the deployment target
 You can deploy and debug an app on the Visual Studio machine, in the Visual Studio simulator on the local machine, or on a remote machine. You choose the target from the **Debugger to launch** list on the **Debugging** property page for the project.

 ![Applies to Windows only](../debugger/media/windows-only-content.png "windows_only_content")

 For a Windows Store app, choose one of these options from the **Target device** list:

|||
|-|-|
|**Local Machine**|Debug the app in the current session on your local machine. See [Run Windows Store apps on the local machine](../debugger/run-windows-store-apps-on-the-local-machine.md).|
|**Simulator**|Debug the app in the Visual Studio simulator for [!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] apps. The simulator is a Desktop window that enables you to debug device functionality—such as touch gestures and device rotation—that are not available on the local machine. See [Run Windows Store apps in the simulator](../debugger/run-windows-store-apps-in-the-simulator.md).|
|**Remote Machine**|Debug the app on a device that is connected to the local machine over an intranet or directly connected by using an Ethernet cable. To debug remotely, the Visual Studio Remote Tools must be installed and running on the remote device. See [Run Windows Store apps on a remote machine](../debugger/run-windows-store-apps-on-a-remote-machine.md).|

 If you choose **Remote Machine**, specify the name or IP address of the remote machine in one of these ways:

- Enter the name or IP address of the remote machine in the **Machine Name** box.

- Choose the down arrow in the **Machine Name** box and choose **\<Locate...>**. Then choose the remote machine from **Select Remote Debugger Connection** dialog box.

   ![Select Remote Debugger Connection](../debugger/media/vsrun-pro-selectremotedebuggerdlg.png "VSRUN_PRO_SelectRemoteDebuggerDlg")

  > [!NOTE]
  > The Select Remote Debugger Connection dialog box displays machines that are on the local sub-net and machines that are directly connected to the Visual Studio machine by an Ethernet cable. To specify another machine, enter the name in the **Machine Name** box.

  ![Applies to Windows Phone only](../debugger/media/phone-only-content.png "phone_only_content")

  For a Windows Store Phone app, choose **Device** or one of the emulators from the **Target device** list.

### <a name="BKMK_Choose_the_debugger_to_use"></a> Choose the debugger to use
 By default, the debugger attaches to the JavaScript code in your app. You can choose to debug the native C++ and managed code of components of your app instead of the JavaScript code. You specify the code to debug in the **Debugger Type** list on the **Debugging** property page of the app project.

 Choose one of these debuggers from the **Debugger Type** list:

|||
|-|-|
|**Script Only**|Debug JavaScript code in your app. Managed code and native code are ignored.|
|**Native Only**|Debug native C/C++ code in your app. Managed code and JavaScript code are ignored.|
|**Native with Script**|Debug native C++ code and JavaScript code in your app.|
|**Managed Only**|Debug managed code in your app. JavaScript code and native C/C++ code are ignored.|
|**Mixed (Managed and Native)**|Debug native C/C++ code and managed code in your app. JavaScript code is ignored.|

### <a name="BKMK__Optional__Delay_starting_app_in_the_debug_session"></a> (Optional) Delay starting the app in the debug session
 By default, Visual Studio immediately starts the app when you start debugging. You can also start a debug session but delay the start of your app. The app is launched in the debugger when it is launched from the Start menu or by an activation contract, or when it is started by another process or method. You can also use delayed start to debug background events in your app that you want to occur when the app is not running.

 You specify whether to delay the launch of your app in the **Launch Application** list on the **Debugging** property page of the app project. Choose one of these options:

- Choose **No** to delay the launch of your app.

- Choose **Yes** to launch the app immediately.

### <a name="BKMK__Optional__Disable_network_loopbacks"></a> (Optional) Disable network loopbacks
 ![Applies to Windows only](../debugger/media/windows-only-content.png "windows_only_content")

 For security reasons, a Windows Store app that is installed in the standard manner is not allowed to make network calls to the device it is installed on. By default, Visual Studio deployment creates an exemption from this rule for the deployed app. This exemption allows you to test communication procedures on a single machine. Before you submit your app to the Windows Store, you should test your app without the exemption.

 To remove the network loopback exemption, choose **No** from the **Allow Network Loopback** list on the **Debugging** property page.

## <a name="BKMK_Start_the_debugging_session"></a> Start the debugging session

### <a name="BKMK_Start_debugging__F5_"></a> Start debugging (F5)
 When you choose **Start Debugging** on the **Debug** menu (Keyboard: F5), Visual Studio launches the app with the debugger attached. Execution continues until a breakpoint is reached, you manually suspend execution, an unhandled exception occurs, or the app ends.

### <a name="BKMK_Start_debugging__F5__but_delay_the_app_start"></a> Start debugging (F5) but delay the app start
 You can set the app to run in debug mode, but let it be started by a method other than the debugger. For example, you might want to debug the launch of your app from the Start menu, or to debug a background process in the app without starting the app.To delay the app start, do this:

1. On the **Debug** page of the app project properties, choose **No** from the **Launch Application** list.

2. Choose **Start Debugging** on the **Debug** menu (Keyboard: F5).

3. Start your app from the Start menu, an execution contract, or by another procedure.

   The app starts in debug mode. Execution continues until a breakpoint is reached, you manually suspend execution, an unhandled exception occurs, or the app ends.

   . For more information about debugging background tasks, see [Trigger suspend, resume, and background events for Windows Store)](../debugger/how-to-trigger-suspend-resume-and-background-events-for-windows-store-apps-in-visual-studio.md).

## <a name="BKMK_Start_an_installed_app_in_the_debugger"></a> Start an installed app in the debugger
 When you start debugging by using F5, Visual Studio builds and deploys the app, sets the app to run in debug mode, and then starts it. To start an app that is already installed on a device, use the Debug Installed App Package dialog box. This procedure is useful when you need to debug an app that was installed from the Windows store, or when you have the source files for the app, but you do not have a Visual Studio project for the app. For example, you might have a custom build system that does not use Visual Studio projects or solutions.

 The app can be installed on the local device, or it can be on a remote device.  You can start the app immediately, or you can set it to run in the debugger when it is started by another process or method, such as from the Start menu or by an activation contract, You can also set the app to run in debug mode when you want to debug a background process without starting the app. For more information, see [Trigger suspend, resume, and background events for Windows Store)](../debugger/how-to-trigger-suspend-resume-and-background-events-for-windows-store-apps-in-visual-studio.md).

 To set an installed app to run in debug mode, do this:

> [!NOTE]
> The app must not be running when you start this procedure.

1. On the **Debug** menu, choose **Debug Installed App Package**

2. Choose one of the following options from the list:

   |                    |                                                                                                                                                                                                                                                                                                                                                                                                           |
   |--------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   | **Local Machine**  |                                                                                                                Debug the app in the current session on your local machine. See [Run Windows Store apps on the local machine](../debugger/run-windows-store-apps-on-the-local-machine.md).                                                                                                                 |
   |   **Simulator**    | Debug the app in the Visual Studio simulator for [!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] apps. The simulator is a Desktop window that enables you to debug device functionality—such as touch gestures and device rotation—that are not available on the local machine. See [Run Windows Store apps in the simulator](../debugger/run-windows-store-apps-in-the-simulator.md). |
   | **Remote Machine** |                          Debug the app on a device that is connected to the local machine over an intranet or directly connected by using an Ethernet cable. To debug remotely, the Visual Studio Remote Tools must be installed and running on the remote device. See [Run Windows Store apps on a remote machine](../debugger/run-windows-store-apps-on-a-remote-machine.md).                           |

3. Choose the app from the **Installed App Packages** list.

4. Choose the debug engine to use from the **Debug this code type** list.

5. (Optional). Choose **Do not launch, but debug my code when it starts** to debug the app when it is started by some other method, or to debug a background process.

   When you click **Start**, the app is launched or is set to run in debug mode.

## <a name="BKMK_Attach_the_debugger_to_a_running_app_"></a> Attach the debugger to a running app
 To attach the debugger to a [!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] app, you must use the Debuggable Package Manager to set the app to run in debug mode. The Debuggable Package Manager is installed with the Visual Studio Remote Tools.

 Attaching the debugger to an app is useful when you need to debug an already-installed app, such as an app that was installed from the Windows store. Attaching is required when you have the source files for the app, but you do not have a Visual Studio project for the app. For example, you might have a custom build system that does not use Visual Studio projects or solutions.

 To attach to an app:

1. Set the app to run in debug mode. This must be done when the app is not running.

2. Start the app. You can start the app from the Start menu, an execution contract, or some other method.

3. Attach the debugger to the running app.

### <a name="BKMK_Set_the_app_to_run_in_debug_mode"></a> Set the app to run in debug mode

1. Install the Visual Studio Remote Tools on the device where the app is installed. See [Installing the remote tools](https://msdn.microsoft.com/library/windows/apps/hh441469.aspx#BKMK_Installing_the_Remote_Tools).

2. On the Start menu, search for `Debuggable Package Manager` and then start it.

     A PowerShell window properly configured for the AppxDebug cmdlet appears.

3. To enable debugging of an app, you must specify the PackageFullName identifier of the app. To view a list all apps that includes the PackageFullName, type `Get-AppxPackage` at the PowerShell prompt.

4. At the PowerShell prompt, enter `Enable-AppxDebug` *PackageFullName* where *PackageFullName* is the PackageFullName identifier of the app.

### <a name="BKMK_Attach_the_debugger"></a> Attach the debugger

> [!TIP]
> JavaScript apps run in an instance of the wwahost.exe process. If other JavaScript apps are running when you attach to the app, you will need to know the numeric process id (PID) of the wwahost.exe that the app is running in.
>
> The easiest way to deal with this situation is to close all of the other JavaScript apps. Otherwise, you can open Windows Task Manager before you start the app and note the ids of the wwahost.exe processes. When you specify the process to attach to in the **Available Processes**  dialog box, the wwahost.exe of the app will have an id that is different than the ones that you have noted.

 To attach the debugger:

1. On the **Debug** menu, choose **Attach to Process**.

    The **Attach to Process** dialog box appears.

2. To attach to an app on a remote device, specify the remote device in the **Qualifier** box. You can:

   - Enter the name in the **Qualifier** box.

   - Choose the down-arrow in the **Qualifier** box and choose the device from a list of devices that you have attached to before.

   - Choose **Find** to choose the device from a list of devices on your local subnet.

3. Specify the type of code that you want to debug in the **Attach to** box.

    Choose **Select** and then do one of the following:

   - Choose **Automatically determine the type of code to debug**

   - Choose **Debug these code types** and then choose one or more types from the list.

4. In the **Available Processes**  list, choose the appropriate **wwahost.exe** process. Use the **Title** column to identify your app.

5. Choose **Attach**.

   Visual Studio attaches the debugger to the process. Execution continues until a breakpoint is reached, you manually suspend execution, an unhandled exception occurs, or the app ends.

## See Also
 [Control execution in a debug session (JavaScript)](../debugger/control-execution-of-a-store-app-in-a-visual-studio-debug-session-for-windows-store-apps-javascript.md)
 [Quickstart: Debug HTML and CSS](../debugger/quickstart-debug-html-and-css.md)
 [Trigger suspend, resume, and background events for Windows Store)](../debugger/how-to-trigger-suspend-resume-and-background-events-for-windows-store-apps-in-visual-studio.md)
 [Debug apps in Visual Studio](../debugger/debug-store-apps-in-visual-studio.md)
