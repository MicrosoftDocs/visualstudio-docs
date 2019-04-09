---
title: "Per-Monitor Awareness support for Visual Studio extenders"
titleSuffix: ""
description: "Learn about the new extender support for per-monitor-awareness available in Visual Studio 2019."
ms.date: 04/09/2019
helpviewer_keywords:
  - "Visual Studio, PMA, per-monitor-awareness, extenders, Windows Forms"
  - "Per-Monitor Awareness support for extenders"
ms.assetid: 
author: rub8n
ms.author: rurios
manager: anthc
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.topic: reference 
ms.workload:
  - "multiple"
---

# Per-Monitor Awareness support for Visual Studio extenders

Versions prior to Visual Studio 2019 had their DPI awareness context set to system aware, rather than a per-monitor DPI aware (PMA). Running in System awareness resulted in a degraded visual experience (e.g. blurry fonts or icons) whenever Visual Studio had to render across monitors with different scale factors or remote into machines with different display configurations (e.g. different Windows scaling).

The DPI awareness context of Visual Studio 2019 is set as per-monitor aware, allowing Visual Studio to render according to the configuration of the display where it's hosted rather than a generic system defined configuration. Ultimately translating into a crisp UI for surface areas that implement PMA support.

Refer to the [High DPI Desktop Application Development on Windows](https://docs.microsoft.com/windows/desktop/hidpi/high-dpi-desktop-application-development-on-windows) documentation for more information about the terms and overall scenario covered in this document.

## Quickstart
- Ensure Visual Studio is running in PMA mode (See **Enabling PMA**)

- Validate your extension works correctly across a set of common scenarios (See **Testing your extensions for PMA issues**)

- If you find issues, you’ll need to add the new PMA nugget package, diagnose, and fix issues using the strategies & recommendations discussed in this document

## Enabling PMA
To enable PMA in Visual Studio, the following requirements need to be met:
1)  Windows 10 April 2018 Update (v1803, RS4) or later
2)  .NET Framework 4.8 RTM or greater (currently ships as standalone preview or bundle with recent Windows Insider builds)
3)  Visual Studio 2019 with the ["Optimize rendering for screens with different pixel densities"](https://docs.microsoft.com/visualstudio/ide/reference/general-environment-options-dialog-box?view=vs-2019) option enabled

Once these requirements are met, Visual Studio will automatically enable PMA across the process.

## Testing your extensions for PMA issues

Visual Studio officially supports the WPF, Windows Forms, Win32, and HTML/JS UI frameworks. When Visual Studio is put into PMA mode, the different UI stacks behave differently. Therefore, regardless of UI framework, it's recommended that a test pass is performed to ensure all UI is compliant with PMA.

Regardless of the UI framework your extension supports, it's recommended you validate the following common scenarios:

1. Changing the scale factor of a single monitor environment while the application is running*
    - This scenario helps test that UI is responding to the dynamic Windows DPI change

2. Docking/undocking a laptop where an attached monitor is set to the primary and the attached monitor has a different scale factor than the primary while the application is running.
    - This scenario helps test that UI is responding to the display DPI change as well as handling displays dynamically being added or removed

3. Having multiple monitors with different scale factors and moving the application between them.
    - This scenario helps test that UI is responding to the display DPI change
    
4. Remoting into a machine when the local and remote machines have different scale factors for the primary monitor.
    - This scenario helps test that UI is responding to the dynamic Windows DPI change

A good preliminary test for whether UI might have problems is whether or not the code utilizes either the *Microsoft.VisualStudio.Utilities.Dpi.DpiHelper* or *Microsoft.VisualStudio.PlatformUI.DpiHelper* classes. These old DpiHelper classes only support System DPI awareness and won’t always function correctly when the process is PMA.

Typical usage of these DpiHelpers will look like:

```cs
Point screenTopRight = logicalBounds.TopRight.LogicalToDeviceUnits();

POINT screenIntTopRight = new POINT
{
    x = (int)screenTopRIght.X,
    y = (int)screenTopRIght.Y
}

IntPtr monitor = NativeMethods.MonitorFromPoint(screenIntTopRight, NativeMethods.Monitor_DEFAULTTONEARST);
```

In the previous example, a rectangle representing the logical bounds of a window is converted to device units so that it can be passed to the native method MonitorFromPoint that expects device coordinates in order to return back an accurate monitor pointer.

### Classes of Issues

When PMA is enabled for Visual Studio, the UI could replicate issues in several common ways. Most, if not all, of these issues can happen in any of Visual Studios supported UI frameworks. Additionally, these issues can happen even when a piece of UI is being hosted in mixed-mode DPI scaling scenarios (refer to the Windows [documentation](https://docs.microsoft.com/windows/desktop/hidpi/high-dpi-desktop-application-development-on-windows) to learn more). 

#### Win32 Window creation
When creating windows with CreateWindow() or CreateWindowEx(), a common pattern is to create the window at coordinates 0,0 (the top/left corner of the primary display), then move it to its final position. However, doing so can cause the window to trigger a DPI changed message or event, which can retrigger other UI messages or events, and eventually lead to undesired behavior or rendering.

#### WPF Element placement
When moving WPF elements using the old Microsoft.VisualStudio.Utilities.Dpi.DpiHelper, top-left coordinates might not be calculated correctly whenever elements are in the non-primary DPI case.

#### Serialization of UI element sizes or positions
Whenever UI size or position is restored at a different DPI context than what it was stored at, it will be positioned and sized incorrectly. This happens because the logical bounds of a window are converted to device units so that it can be passed to the Win32 method MonitorFromPoint that expects device coordinates in order to return back an accurate monitor pointer.

#### Incorrect scaling
UI elements created on the primary DPI will scale correctly, however when moved to a display with a different DPI, they don't rescale and thus, their content ends up being too large or too small.

#### Incorrect bounding
Similarly, to the scaling problem, UI elements will calculate their bounds correctly on their primary DPI context, however when moved to a non-primary DPI, they won't calculate the new bounds correctly. As such, the content window ends up being too small or too large compared to the hosting UI, which results in empty space or clipping.

#### Drag & drop
Whenever inside mixed-mode DPI scenarios (e.g. different UI elements rendering in both primary and non-primary DPI context), drag and drop coordinates could be miscalculated, resulting in the final drop position end up incorrect.

#### Out-of-Process UI
Some UI is created out-of-proc and if the creating external process is in a different DPI awareness mode than Visual Studio, this can introduce any of the previous rendering issues.

#### Windows Forms controls, images, or windows not displaying
One of the main causes for this issue is developers trying to reparent a control or window with one DpiAwarenessContext to a different DpiAwarenessContext window. 

The following pictures show the current Windows Operating system restrictions in parenting windows, unless thread hosting behavior is explicitly changed:

![A screenshot of the correct parenting behavior](media/PMA-parenting-behavior.PNG)

As a result, if you set parent-child relationship between unsupported modes, it will fail, and the control or window may not be rendered as expected.

### Diagnosing Issues
There are many factors to consider when identifying PMA-related issues: 

1. Does the UI or API expected logical or device values.
    - WPF UI and APIs typically use logical values (but not always)
    - Win32 UI and APIs typically use device values

2. Where are the values coming from?
    - If receiving values from other UI or API, is it passing device or logical values.
    - If receiving values from multiple sources, do they all use/expect the same types of values or do conversions need to be mixed and matched?

3. Are UI constants in use and what form are they in?

4. Is the thread in the correct DPI context for the values it's receiving?
    - The changes to enable CLMM should generally put code paths in the right context, however, work done outside the main message loop or event flow might execute in the wrong DPI context.

5. Do values cross DPI context boundaries?
    - Drag & drop is a common situation where coordinates can cross DPI contexts. Window tries to do the right thing, but in some cases, the host UI may need to do conversion work to ensure matching context boundaries.

### PMA Nugget package
The new DpiAwarness libraries can be found on the Microsoft.VisualStudio.DpiAwareness NuGet package.

### Recommended Tools
The following tools can help debug PMA-related issues across some of the different UI stacks supported by Visual Studio.

#### Snoop
Snoop is a XAML debugging tool that has some extra functionality that the built-in Visual Studio XAML tools doesn’t have. Additionally, Snoop doesn’t need to actively debug Visual Studio to be able to view and tweak its WPF UI. The two main ways Snoop can be useful for diagnosing PMA issues is for validating logical placement coordinates or size bounds, and for validating the UI has the right DPI.
 
#### Visual Studio XAML Tools
Like Snoop, the XAML tools in Visual Studio can help diagnose PMA issues. Once a likely culprit is found, you can set breakpoints, and use the Live Visual Tree window as well as the debug windows, to inspect UI bounds and current DPI.

## Strategies for fixing PMA issues

### Replacing DpiHelper Calls
In most cases, fixing UI issues in PMA boils down to replacing calls in managed code to the old:
*Microsoft.VisualStudio.Utilities.Dpi.DpiHelper* and *Microsoft.VisualStudio.PlatformUI.DpiHelper* classes, with calls to the new *Microsoft.VisualStudio.Utilities.DpiAwareness* helper class. 

For native code, it will entail replacing calls to the old *VsUI::CDpiHelper* class with calls to the new *VsUI::CDpiAwareness* class. The new DpiAwareness and CDpiAwareness classes offer the same conversion helpers as the DpiHelper classes but require an additional input parameter: the UI element to use as a reference for the conversion operation. 

The managed DpiAwareness class offers helpers for WPF Visuals, Windows Forms Controls, and Win32 HWNDs and HMONITORs (both in the form of IntPtrs), while the native CDpiAwareness class offers HWND and HMONITOR helpers.

### Windows Forms dialogs, windows, or controls displayed in the wrong DpiAwarenessContext
Even after a successful parenting of windows with different DpiAwarenessContext (because of windows default behavior), users may still see scaling issues as different DpiAwarenessContext windows scale differently. As a result, users may see alignment/blurry text or Image issues on the UI.

The solution is to set the correct DpiAwarenessContext scope for all the windows and controls in the application.

### TLMM Dialogs
When creating top-level windows such as modal dialogs, it’s important to make sure the thread is in the correct state prior to the HWND being created. The thread can be put into System awareness by using the CDpiScope helper in native or the DpiAwareness.EnterDpiScope helper in managed. (TLMM should generally be used on non-WPF dialogs/windows.)

### Child-level mixed mode (CLMM)

By default, child windows receive the same DPI-awareness mode as their parents. However, you can use SetThreadDpiHostingBehavior to override it and have child windows run in a different scaling mode than their parent or host.


#### CLMM Issues
Most of the UI calculation work that happens as part of the main messaging loop or event chain should already be running in the right DPI context. However, if coordinate or sizing calculations are done outside these main workflows (such as during an idle time task, or off the UI thread, then the current DPI context might be incorrect leading to UI misplacement or mis-sizing issues. Putting the thread into the correct state for the UI work generally fixes the problem.
 
#### Opting Out of CLMM
If a non-WPF tool window is being migrated to fully support PMA, it will need to opt out of CLMM. To do so, a new interface needs to be implemented: IVsDpiAware.

C#:
```cs
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface IVsDpiAeware
{
    [ComAliasName("Microsoft.VisualStudio.Shell.Interop.VSDPIMode")]
    uint Mode {get;}
}
```
 
C++:
```cplusplus
IVsDpiAware : public IUnknown
{
    public:
        HRRESULT STDMETHODCALLTYPE get_Mode(__RCP__out VSDPIMODE *dwMode);
};
```
 

For managed languages, the best place to implement this interface is in the same class that derives from *Microsoft.VisualStudio.Shell.ToolWindowPane*. For C++, the best place to implement this interface is in the same class that implements *IVsWindowPane* from vsshell.h.

The value returned by the Mode property on the interface is a __VSDPIMODE (and cast to a uint in managed):

```cs
enum __VSDPIMODE
    {
        VSDM_Unaware    = 0x01,
        VSDM_System     = 0x02,
        VSDM_PerMonitor = 0x03,
    }
```

- Unaware means the tool window needs to handle 96 DPI, Windows will handle scaling it for all other DPIs. Resulting on content being slightly blurry.
- System means the tool window needs to handle the DPI for the primary display DPI. Any display with a matching DPI will look crisp, but if the DPI is different or changes during the session, Windows will handle the scaling and it will be slightly blurry.
- PerMonitor means the tool window needs to handle all DPIs on all displays and whenever the DPI changes.

**NOTE**: Visual Studio only supports PerMonitorV2 awareness, so the PerMonitor enum value translates to the Windows value of DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2.

## Known Issues

### Windows Forms

To optimize for the new mixed-mode scenarios, Windows Forms changed how it creates controls and windows whenever their parent was not explicitly set. Earlier, controls without an explicit parent used an internal "Parking Window" as a temporary parent to the control or window being created. 

The "Parking Window" gets its DpiAwarenessContext from the process the application is running under. The control inherits the same DpiAwarenessContext as the Parking Window and would then be reparented to the original/expected parent by the application developer.  This doesn't work when the intended parent to the control is not the same DpiAwarenessContext as the control being created.

As of .NET 4.8, if the parent is not explicitly set on the control or window, Windows Forms will query for a Parking Window that matches the DpiAwarenessContext of the thread in which the control or window creation is requested and use that as a temporary parent. In other words, upon creation the control is now created with the intended DpiAwarenessContext. The control or window will then be reparented to the expected parent by the application developer.