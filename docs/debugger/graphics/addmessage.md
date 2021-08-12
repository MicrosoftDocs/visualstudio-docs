---
title: "AddMessage | Microsoft Docs"
description: Use the AddMessage method of the VsgDbg class to add a custom message to the graphics diagnostics Head-Up Display (HUD).
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
ms.assetid: 102a0404-a00c-4566-93f3-01bc8df63280
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# AddMessage
Adds a custom message to the graphics diagnostics *HUD* (Head-Up Display).

## Syntax

```C++
void AddMessage(
  wchar_t const * szMessage
);
```

#### Parameters
 `szMessage`
 The message to be added to the HUD.

## Remarks
 The graphics diagnostics HUD is displayed in the upper-left corner of the app that's running under graphics diagnostics. It displays run-time information about the app and about graphics information capture, and messages that are added by calling this function.

 To add a message to the HUD, you don't have to be actively capturing graphics information—that is, a message can be added through an instance of the `VsgDbg` class, but the [Init](init.md) member function does not to be called first. Messages are only displayed in the HUD, they are not recorded in the graphics log file.