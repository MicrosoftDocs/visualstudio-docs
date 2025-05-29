---
title: Run UWP apps in the simulator
description: Understand how to run Universal Windows Platform (UWP) apps in the Visual Studio simulator, which is a desktop application that simulates a UWP app.
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
monikerRange: '<= vs-2019'
---
# Run UWP apps in the simulator

The Visual Studio simulator for UWP apps is a desktop application that simulates a UWP app. Typically, you will want to debug on the local machine, a connected device, or a remote machine. However, in some scenarios, you may want to use the Visual Studio simulator to emulate a different physical screen size and resolution. You can also simulate common touch and rotation events and simulate network connection properties.

The simulator provides an environment in which you can design, develop, debug, and test UWP apps. However, before you publish your app to Microsoft Store, you should test your app on an actual device.

The Visual Studio simulator for UWP apps does not run in an isolated environment on your local machine. Therefore, errors that occur in the simulator, such as a non-recoverable system-wide error, can also affect the entire machine.

## <a name="BKMK_Set_the_simulator_as_the_target"></a> Set the simulator as the target

To run your UWP app in the simulator, select **Simulator** from the drop-down list next to the **Start Debugging** button on the debugger **Standard** toolbar. This option is only available if your app's **Target Platform Min. Version** is less than or equal to the operating system on your development machine.

![Running in the Simulator](../debugger/media/vsrun_f5_simulator.png "VSRUN_F5_Simulator")

## <a name="BKMK_Choose_an_interaction_mode"></a> Choose an interaction mode

You can choose the following interaction modes:

- ![Mouse mode button](../debugger/media/simulator_mousemodebtn.png "SIMULATOR_MouseModeBtn") Mouse mode: sets the interaction mode to mouse gestures. Mouse gestures include clicks, double-clicks, and drags.

- ![Start touch emulation button](../debugger/media/simulator_starttouchemulationbtn.png "SIMULATOR_StartTouchEmulationBtn") Start touch emulation: sets the interaction mode to touch gestures of a single finger. Single-finger events include tapping, dragging, and swiping.

   ![Simulator one finger target](../debugger/media/simulator_onefinger.png "SIMULATOR_OneFinger")
   
   The single target icon indicates the location of events in the simulator. Use the mouse to position the pointer.

   ![One finger touch target](../debugger/media/simulator_onefingerengaged.png "SIMULATOR_OneFingerEngaged")
   
   Press the left mouse button to activate the touch mode. For example, click the button to simulate a tap, or press and hold the button as you drag or swipe.

## Pinch and Zoom

Sets the interaction mode to pinch and zoom gestures of two fingers.

![Simulator two finger target](../debugger/media/simulator_twofinger.png)

The double target icon indicates the location of two fingers on the device screen.

- Move the mouse to position the icons over the object on the device screen.

- Rotate the mouse wheel backward or forward to change the simulated distance of the two fingers before you pinch or zoom.

![Pinch, zoom, and rotate targets](../debugger/media/simulator_twofingerengaged.png)

- Press the left button and rotate the wheel backward (towards you) to zoom in (pinch).

- Press the left button and rotate the mouse wheel forward (away from you) to zoom out (zoom).

## Object rotation

The **Touch emulation rotate** button sets the interaction mode to rotation gestures using two fingers.

- Move the mouse to position the icons over the object on the device screen. Rotate the mouse wheel backward or forward to change the simulated orientation of the two fingers before you rotate the object.

- Press the left button and rotate the wheel backward (towards you) to rotate the object counter-clockwise. As you rotate the mouse wheel, one of the two target icons rotates around the other to indicate the relative size of the rotation.

- Press the left button and rotate the mouse wheel forward (away from you) to rotate the object clockwise.

## <a name="BKMK_Enable_or_disable_Always_on_top_mode"></a> Enable or disable Always on top mode
 You can set the simulator window to always be on top of other windows. The **Toggle Topmost Window** button enables or disables the **Always on top** mode of the simulator window.

## <a name="BKMK_Change_the_device_orientation"></a> Change the device orientation
 You can switch the device orientation between portrait and landscape by rotating the simulator 90 degrees in any direction.

> [!NOTE]
> The simulator does not respect [DisplayProperties.AutoRotationPreferences](/uwp/api/windows.graphics.display.displayproperties.autorotationpreferences) property of a project. For example, if your project sets the orientation to `Landscape`, and you then rotate the simulator to a portrait orientation, the simulator display image will also be rotated and resized. Test these settings on an actual device.

> [!NOTE]
> If you rotate the simulator so that one edge of the simulator is larger than the screen it is displayed on, the simulator is automatically resized to fit within the screen. The simulator is not resized to its original size if you rotate it again.

## <a name="BKMK_Change_the_simulated_screen_size_and_resolution"></a> Change the simulated screen size and resolution
 To change the simulated screen size and resolution, choose the **Change Resolution** button  on the palette and choose a new size and resolution from the list.

 The screen size and resolution are listed as *Screen width inches, pixel width X pixel height*. Note that both the screen size and the resolution are simulated. Location coordinates on the simulator are translated to the selected device size and resolution.

> [!NOTE]
> You can save scaled versions of bitmap images in your app and Windows will load the correct image for the current scale. However, if you change the simulator resolution so that Windows picks a different image to fit the resolution, you have to stop and restart your debug session to view the new image.

## <a name="BKMK_Capture_a_screenshot_of_your_app_for_submission_to_the_Microsoft_Store"></a> Capture a screenshot of your app for submission to Microsoft Store
 When you submit an app to Microsoft Store, you must include screenshots of the app.

> [!NOTE]
> The screenshot is saved at the current resolution of the simulator. To change the resolution, choose the **Change Resolution** button.

- To create screenshots of your app from the simulator, choose the **Capture screenshot to clipboard** button.

- To set the location where screenshots are located, choose the **Screenshot settings** button and choose the location from the shortcut menu.

   ![Screenshot settings context menu](../debugger/media/simulator_screenshotsettingscntxmnu.png)

## <a name="BKMK_Simulate_network_connection_properties"></a> Simulate network connection properties

You can help your app's users manage the cost of metered network connections by maintaining awareness of network connection cost or data plan status changes and enabling your app to use this information to avoid incurring additional costs for roaming or exceeding a specified data transfer limit. The [Windows.Networking.Connectivity](/uwp/api/windows.networking.connectivity) APIs lets you respond to [NetworkStatusChanged](/uwp/api/windows.networking.connectivity.networkinformation) and [TriggerType](/uwp/api/windows.applicationmodel.background.systemtrigger) events that sign. See [Quickstart: Managing metered network cost constraints](/previous-versions/windows/apps/hh750310(v=win.10)).

To debug or test your network cost-aware code, the simulator can mimic properties of a network that are exposed through the [ConnectionProfile](/uwp/api/windows.networking.connectivity.connectionprofile) object returned by [GetInternetConnectionProfile](/uwp/api/windows.networking.connectivity.networkinformation).

To simulate network properties:

1. On the simulator toolbar, choose the **Change network properties** button.

2. On the **Set Network Properties** dialog box, select **Use simulated network properties**.

    Clear the check box to remove the simulation and return to the network properties of the currently connected interface.

3. Enter a **Profile Name** for the simulated network. We recommend using a unique name that you can use to identify the simulation in the [ProfileName](/uwp/api/windows.networking.connectivity.connectionprofile) property of the [ConnectionProfile](/uwp/api/windows.networking.connectivity.connectionprofile) object.

4. Select the [NetworkCostType](/uwp/api/windows.networking.connectivity.networkcosttype) value for the profile from the **Network Cost Type** list.

5. From the **Data Limit Status Flag** list, you can set the [ApproachingDataLimit](/uwp/api/windows.networking.connectivity.connectioncost) property or the [OverDataLimit](/uwp/api/windows.networking.connectivity.connectioncost) property to true, or you can choose **Under Data Limit** to set both values to false.

6. From the **Roaming State** list, set the [Roaming](/uwp/api/windows.networking.connectivity.connectioncost) property.

7. Choose **Set Properties** to simulate the network properties by triggering a foreground [NetworkStatusChanged](/uwp/api/windows.networking.connectivity.networkinformation) event and a background [SystemTrigger](/uwp/api/windows.applicationmodel.background.systemtrigger) of type **NetworkStateChange**.

For more information about managing network connections, see:

[Quickstart: Managing metered network cost constraints](/previous-versions/windows/apps/hh750310(v=win.10))

[Network information sample](https://code.msdn.microsoft.com/windowsapps/Network-Information-Sample-63aaa201)

[Windows.Networking.Connectivity](/uwp/api/windows.networking.connectivity)

[How to respond to system events with background tasks](/previous-versions/windows/apps/hh977058(v=win.10))

[How to trigger suspend, resume, and background events in UWP apps](how-to-trigger-suspend-resume-and-background-events-for-windows-store-apps-in-visual-studio.md)

## <a name="BKMK_Navigate_the_simulator_with_the_keyboard"></a> Navigate the simulator with the keyboard

You can navigate the simulator toolbar by pressing **CTRL + ALT + Up Arrow** to switch focus from the simulator window to the simulator toolbar. Use the **Up Arrow** and the **Down Arrow** to move between toolbar buttons.

You can shut down the simulator by pressing **CTRL + ALT + F4**.

## Related content

- [Run apps from Visual Studio](/windows/uwp/debug-test-perf/deploying-and-debugging-uwp-apps)
