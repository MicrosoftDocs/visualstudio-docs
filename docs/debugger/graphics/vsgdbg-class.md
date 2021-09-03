---
description: "Represents an interface for programmatic control of the in-app component of graphics diagnostics."
title: "VsgDbg Class | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
ms.assetid: 6722263c-ccef-40c7-a0ae-87a863fbab00
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# VsgDbg Class
Represents an interface for programmatic control of the in-app component of graphics diagnostics.

## Syntax

```C++
class VsgDbg;
```

## Members
 The `VsgDbg` class supports the following members.

### Public Constructors

|Name|Description|
|----------|-----------------|
|[VsgDbg::VsgDbg (Constructor)](vsgdbg-vsgdbg-constructor.md)|Constructs an instance of the `VsgDbg` class and optionally prepares the in-app component of graphics diagnostics to actively capture and record graphics information.|
|[VsgDbg::~VsgDbg (Destructor)](vsgdbg-tilde-vsgdbg-destructor.md)|Destroys an instance of the `VsgDbg` class.|

### Public Methods

|Name|Description|
|----------|-----------------|
|[AddMessage](addmessage.md)|Adds a custom message to the graphics diagnostics HUD (Head-Up Display).|
|[BeginCapture](begincapture.md)|Begins a capture interval that will end with `EndCapture`.|
|[CaptureCurrentFrame](capturecurrentframe.md)|Captures the remainder of the current frame to the graphics log file.|
|[Copy (Programmatic Capture)](copy-programmatic-capture.md)|Copies the contents of the active graphics log (.vsglog) file into a new file.|
|[EndCapture](endcapture.md)|Ends a capture interval that was started with `BeginCapture`.|
|[Init](init.md)|Prepares the in-app component of graphics diagnostics to actively capture and record graphics information.|
|[ToggleHUD](togglehud.md)|Toggles the graphics diagnostics HUD overlay on or off.|
|[UnInit](uninit.md)|Finalizes the graphics log file, closes it, and frees resources that were used while the app was actively recording graphics information.|

## Remarks
 The `VsgDbg` class represents an interface that you can use to control graphics diagnostics features programmatically. You can use some features even when you're not actively capturing and recording graphics information; this includes the `AddMessage` member function and `ToggleHUD` member function. The other member functions either prepare the in-app component of graphics diagnostics to start or stop the active capture of graphics information, or must be called while the app is actively capturing and recording graphics information to a graphics log file.
