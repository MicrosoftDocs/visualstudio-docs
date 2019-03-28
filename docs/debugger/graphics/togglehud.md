---
title: "ToggleHUD | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 7261e01d-3c72-46ce-9fb3-5f33b2ddb901
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# ToggleHUD
Toggles the graphics diagnostics *HUD* (Head-Up Display) overlay on or off.

## Syntax

```C++
void ToggleHUD();
```

## Remarks
 The graphics diagnostics HUD is displayed in the upper-left corner of the app that's running under graphics diagnostics. It displays run-time information about the app and about graphics information capture, and messages that are added by calling the [AddMessage](addmessage.md) member function.

 To toggle the HUD, you don't have to be actively capturing graphics information—that is, it can be toggled through an instance of the `VsgDbg` class, but the [Init](init.md) member function doesn't have to be called first.