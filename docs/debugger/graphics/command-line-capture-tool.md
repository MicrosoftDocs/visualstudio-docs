---
title: "Command-Line Capture Tool | Microsoft Docs"
description: Learn about DXCap.exe, a command-line tool for graphics diagnostics capture and playback that supports Direct3D 10 through Direct3D 12 across all feature levels.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
ms.assetid: db75b3a7-80b2-4a74-91d2-fd6e0f73b45d
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Command-Line Capture Tool
DXCap.exe is a command-line tool for graphics diagnostics capture and playback. It supports Direct3D 10 through Direct3D 12 across all feature levels.

## Syntax

```cmd
DXCap.exe [-file filename] [-frame frames | -period periods | -manual] -c app [args...]
DXCap.exe -p [filename] [-debug | -warp | -hw] [-config] [-rawmode]
DXCap.exe -p [filename] -screenshot [-frame frames]
DXCap.exe -p [filename] -toXML [xml_filename]
DXCap.exe -v [-file filename] [-examine events] [-haltonfail | -exitonfail] [-showprogress]
DXCap.exe -e [search_string]
DXCap.exe -info
```

#### Parameters
 `-file` `filename`
 Under capture mode (`-c`), `filename` specifies the name of the graphics log file that graphics information is recorded to. If `filename` isn't specified, graphics information is recorded to a file named `<appname>-<date>-<time>.vsglog` by default.

 Under validation (-v) mode, `filename` specifies the name of the graphics log file to be validated. If `filename` isn't specified, the graphics log that was last validated is used again.

 `-frame` `frames`
 Under capture mode, `frames` specifies the frames that you want to capture. The first frame is 1. You can specify several frames by using commas and ranges. For example, if `frames` is `2, 5, 7-9, 15`, then frames `2`, `5`, `7`, `8`, `9`, and `15` are captured.

> [!TIP]
> Use `-frame` `manual` to specify that frames will be captured manually by pressing the Print Screen key. Frames can be captured when the app starts; to stop capturing frames, return to the command line interface and press enter.

 `-period` `periods`
 Under capture mode, `periods` specifies the ranges of time, in seconds, during which you want to capture frames. You can specify several periods by using commas and ranges. For example if `periods` is `2.1-5, 7.0-9.3`, then frames that are rendered between `2.1` and `5` seconds, and between`7` and `9.3` seconds are captured.

 `-c` `app` [`args...`]
 Capture mode. Under capture mode, `app` specifies the name of the app that you want to capture graphics information from; `args...` specifies additional command-line parameters to that app.

 `-p` [`filename`]
 Playback mode (`-p`). Under playback mode, `filename` specifies the name of the graphics log file to be played back. If `filename` isn't specified, the graphics log that was last played back is used again.

 `-debug`
 Under playback mode, `-debug` specifies that playback should be played with the Direct3D debug layer enabled.

 `-warp`
 Under playback mode, `-warp` specifies that playback should be played using the WARP software renderer.

 `-hw`
 Under playback mode, `-hw` specifies that playback should be played using GPU hardware.

 `-config`
 Under playback mode, `-config` displays any information about the machine that was used to capture the graphics log file.

 `-rawmode`
 Under playback mode, `-rawmode` specifies that playback should be performed without modification to the recorded events. Under normal operation, playback mode might make minor changes to playback to simplify debugging and speed up playback. For example, it may simulate swap chain output rather than executing swap chain commands. Usually this playback is not a problem, but you might need playback to occur in a way that's more faithful to the recorded event. For example, you can use this option to restore full-screen rendering behavior to an app that was captured while running in full-screen mode.

 `-toXML` [`xml_filename`]
 Under playback mode, `xml_filename` specifies the name of the file where an XML representation of playback is written to. If `xml_filename` is not specified, the XML representation is written to a file named the same as the file being played back, but given an `.xml` extension.

 `-v`
 Validation mode. Under validation mode, captured frames are played back on both hardware and WARP, and their results are compared using an image comparison function. You can use this feature to quickly identify driver issues that affect your rendering.

 `-examine` `events`
 Under validation mode, `events` specifies the set of graphics events whose immediate results are compared. For example, `-examine present,draw,copy,clear` limits the comparison to only the events belonging to those categories.

> [!TIP]
> We recommend starting with `-examine present,draw,copy,clear` because this will reveal most issues but take significantly less time than a more extensive set of events. If necessary, you can specify a larger or different set of events to validate those events and reveal other kinds of issues.

 `-haltonfail`
 Under validation mode, `-haltonfail` halts validation when differences are detected between the hardware and WARP renderer. Validation resumes after a key is pressed.

 `-exitonfail`
 Under validation mode, `-exitonfail` exits validation immediately when differences are detected between the hardware and WARP renderer. When the program exits in this way, it returns `0` to the environment; otherwise it returns `1`.

 `-showprogress`
 Under validation mode, `-showprogress` displays progress information about the validation session. WARP progress is displayed on the left; hardware progress is displayed on the right.

 `-e` `search_string`
 Enumerates the UWP apps that are installed. You can use this information to perform command-line captures with UWP apps.

 `-info`
 Displays information about the machine and capture DLLs.

## Remarks
 DXCap.exe operates in three modes:

 Capture mode (-c)
 Capture graphics information from a running app and record it to a graphics log file. The capture capabilities and file format are identical to those of Visual Studio.

 Playback mode (-p)
 Playback previously captured graphics events from an existing graphics log file. By default, playback occurs in a window, even when the graphics log file was captured from a fullscreen app. Playback occurs in full-screen only when the graphics log file was captured from a fullscreen app and `-rawmode` is specified.

 Validation mode (`-v`)
 Validates rendering behavior by playing back captured frames on both hardware and WARP, then comparing their results by using an image comparison function. You can use this feature to quickly identify driver issues that affect your rendering.

 In addition to these modes, dxcap.exe performs two other functions that do not perform capture or playback of graphics information.

 Enumeration function (`-e`)
 Displays details about the UWP apps that are installed on the machine. These details include the package name and appid that identify the executable file in a UWP app. To capture graphics information from a windows store app using DXCap.exe, use the package name and appid instead of the executable filename that's used when you capture a desktop app.

 Info function (`-info)`
 Displays details about the machine and capture DLLs.

## Examples

### Capture graphics information from a desktop app
 Use `-c` to specify the app from which you want to capture graphics information.

```cmd
DXCap.exe -c BasicHLSL11.exe
```

 By default, graphics information is recorded to a file named `<appname>-<date>-<time>.vsglog`. Use `-file` to specify a different file to record to.

```cmd
DXCap.exe -file regression_test_12.vsglog -c BasicHLSL11.exe
```

 Specify additional command-line parameters to the app that you're capturing from by including them after the app's filename.

```cmd
DXCap.exe -c "C:\Program Files\Internet Explorer\iexplorer.exe" "www.fishgl.com"
```

 The command in the example above captures graphics information from the desktop version of Internet Explorer while viewing the webpage located at `www.fishgl.com` which uses the WebGL API to render 3-D content.

> [!NOTE]
> Because command line arguments that appear after the app are passed to it, you must specify the arguments intended for DXCap.exe before using the `-c` option.

### Capture graphics information from a UWP app.
 You can capture graphics information from a UWP app.

```cmd
DXCap.exe -c Microsof.BingMaps_2.1.2914.1734_x64__8wekyb3d8bbwe,AppexMaps
```

 Using DXCap.exe to capture from a UWP app is similar to using it to capture from a Windows desktop app, but instead identifying a desktop app by its filename, you identify a UWP app by its package name and the name or ID of the executable inside that package that you want to capture from. To make it easier to find out how to identify the UWP apps that are installed on your machine, use the `-e` option with DXCap.exe to enumerate them:

```cmd
DXCap.exe -e
```

 You can provide an optional search string to help find the app that you're looking for. When the search string is provided, DXCap.exe enumerates the UWP apps whose package name, app name or app IDs match the search string. The search is case-insensitive.

```cmd
DXCap.exe -e map
```

 The command above enumerates UWP apps that match "map"; here is the output:

 **Package "Microsoft.BingMaps":**
 **InstallDirectory : C:\Program Files\WindowsApps\Microsoft.BingMaps_2.1.2914.1734_x64__8wekyb3d8bbwe**
 **FullName         : Microsoft.BingMaps_2.1.2914.1734_x64__8wekyb3d8bbwe**
 **UserSID          : S-1-5-21-2127521184-1604012920-1887927527-5603533**
 **Name             : Microsoft.BingMaps**
 **Publisher        : CN=Microsoft Corporation, O=Microsoft Corporation, L=Redmond, S=Washington, C=US**
 **Version          : 2.1.2914.1734**
 **Launchable Applications:**
 **Id: AppexMaps**
 **Exe: C:\Program Files\WindowsApps\Microsoft.BingMaps_2.1.2914.1734_x64__8wekyb3d8bbwe\Map.exe**
 **IsWWA: No**
 **AppSpec (to launch): DXCap.exe -c Microsoft.BingMaps_2.1.2914.1734_x64__8wekyb3d8bbwe,AppexMaps** The last line of output for each enumerated app displays the command you can use to capture graphics information from it.

### Capture specific frames or frames between specific times.
 Use `-frame` to specify the frames that you want to capture using commas and ranges:

```cmd
DXCap.exe -frame 2,5,7-9,15 -c SimpleBezier11.exe
```

 Or, use `-period` to specify a set of time ranges during which to capture frames. Time ranges are specified in seconds, and multiple ranges can be specified:

```cmd
DXCap.exe -period 2.1-5, 7.0-9.3 -c SimpleBezier11.exe
```

### Capture frames interactively.
 Use `-manual` to capture frames interactively. Press the Enter key to start capture, and press the Enter key again to stop.

```cmd
DXCap.exe -manual -c SimpleBezier11.exe
```

### Play back a graphic log file
 Use `-p` to play back a previously captured graphics log file.

```cmd
DXCap.exe -p regression_test_12.vsglog
```

 Leave out the filename to play back the graphics log that was captured most recently.

```cmd
DXCap.exe -p
```

### Play back in raw mode
 Use `-rawmode` to play back captured commands exactly as they occurred. Under normal playback, certain commands are emulated, for example, a graphics log file captured from a full screen app will play back in a window; with raw mode enabled, the same file will attempt to play back in full screen.

```cmd
DXCap.exe -p regression_test_12.vsglog -rawmode
```

### Play back using WARP or a hardware device
 You might want to force play back of a graphics log file captured on a hardware device to use WARP, or force playback of a log captured on WARP to use a hardware device. Use `-warp` to play back using WARP.

```cmd
DXCap.exe -p regression_test_12.vsglog -warp
```

 Use `-hw` to play back using hardware.

```cmd
DXCap.exe -p regression_test_12.vsglog -hw
```

### Validate a graphics log file against WARP
 Under validation mode, the graphics log file is played back on both hardware and WARP, and their results are compared. This can help you identify rendering errors that are caused by the driver. Use -v to validate correct behavior of graphics hardware against WARP.

```cmd
DXCap.exe -v regression_test_12.vsglog
```

 To reduce the amount of comparisons, you can specify a subset of commands for validation to compare and other commands will be ignored. Use -examine to specify the commands whose results you want to compare.

```cmd
DXCap.exe -v regression_test_12.vsglog -examine present,draw,copy,clear
```

### Convert a Graphics Log file to PNGs
 To view or analyze frames from a graphics log file, DXCap.exe can save captured frames as .png (Portable Network Graphics) image files. Use `-screenshot` to under playback mode to output captured frames as .png files.

```cmd
DXCap.exe -p BasicHLSL11.vsglog -screenshot
```

 Use `-frame` with `-screenshot` to specify the frames that you want to output.

```cmd
DXCap.exe -p BasicHLSL11.vsglog -screenshot -frame 5, 7-9
```

### Convert a Graphics Log file to XML
 To process and analyze graphics logs using familiar tools like FindStr or XSLT, DXCap.exe can convert a graphics log file to XML. Use `-toXML` under playback mode to convert the log to XML instead of playing it back.

```cmd
DXCap.exe -p regression_test_12.vsglog -toXML
```

 By default, the XML output is written to a file with the same name as the graphics log, but which has been given a .xml extension. In the example above, the XML file will be named **regression_test_12.xml**. To give the XML file a different name, specify it after `-toXML`.

```cmd
DXCap.exe -p regression_test_12.vsglog -toXML temp.xml
```

 The resulting file will contain XML that looks similar to this:

```xml
<Moment value="67"/>
<Method name="CreateDXGIFactory1" >
    <Return type="HRESULT" value="S_OK" />
    <Parameter name="riid" type="IID" value="770AAE78-F26F-4DBA-A829-253C83D1B387" />
    <Parameter name="ppFactory" type="void" handle="1" isOutput="true" />
</Method>

<Moment value="167"/>
<Method name="D3D11CreateDevice" >
    <Return type="HRESULT" value="S_OK" />
    <Parameter name="pAdapter" type="IDXGIAdapter" handle="34" />
    <Parameter name="DriverType" type="D3D_DRIVER_TYPE" value="D3D_DRIVER_TYPE_UNKNOWN" />
    <Parameter name="Software" type="HMODULE" value="pointer" />
    <Parameter name="Flags" type="UINT" value="0" />
    <Parameter name="pFeatureLevels" type="D3D_FEATURE_LEVEL" arrSize="1" >
        <Element value="D3D_FEATURE_LEVEL_11_0" />
    </Parameter>
    <Parameter name="FeatureLevels" type="UINT" value="1" />
    <Parameter name="SDKVersion" type="UINT" value="7" />
    <Parameter name="ppDevice" type="ID3D11Device" handle="35" isOutput="true" />
    <Parameter name="pFeatureLevel" type="D3D_FEATURE_LEVEL" value="D3D_FEATURE_LEVEL_11_0" isOutput="true" />
    <Parameter name="ppImmediateContext" type="ID3D11DeviceContext" value="nullptr" isOutput="true" />
</Method>
```

## Requirements