---
title: "CaptureCurrentFrame | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 4509311d-6fe2-4b65-9b4a-ff0522585d6a
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# CaptureCurrentFrame
Captures the remainder of the current frame to the graphics log file.

## Syntax

```C++
void CaptureCurrentFrame();
```

## Remarks
 If another capture is currently in progress—such as a capture that was started by the `BeginCapture` function—then that capture is completed and recorded to the graphics log as a distinct frame. Immediately afterwards, graphics diagnostics begins capturing the remainder of the current frame, which is also recorded as a distinct frame. The current frame's end is marked by a call to present.

 To capture a frame, you must prepare your app to capture and record graphics information—that is, you must have called [Init](init.md) through an instance of the `VsgDbg` class before you call `CaptureCurrentFrame`.

## See also
- [Init](init.md)
- [BeginCapture](begincapture.md)