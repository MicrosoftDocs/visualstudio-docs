---
title: "Reference (Programmatic Capture) | Microsoft Docs"
description: Use the programmatic capture API to exert programmatic control over the capture features of Graphics Diagnostics. 
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
ms.assetid: ef60eb8d-1ac2-4e3a-9b4b-f6da0bdd9da8
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Reference (Programmatic Capture)
Graphics Diagnostics supports programmatic control over its capture features, through the programmatic capture API. You can use this API to toggle and add messages to the graphics diagnostics HUD (Head-Up Display), initialize and create graphics log files, and capture graphics information.

## Programmatic Capture APIs

### Classes

|Name|Description|
|----------|-----------------|
|[VsgDbg Class](vsgdbg-class.md)|Represents the interface through which the in-app component of graphics diagnostics is controlled programmatically.|

### Preprocessor Symbols

|Name|Description|
|----------|-----------------|
|[DONT_SAVE_VSGLOG_TO_TEMP](dont-save-vsglog-to-temp.md)|Defines by its presence whether the graphics log file is saved to the user's temporary files directory.|
|[VSG_DEFAULT_RUN_FILENAME](vsg-default-run-filename.md)|Defines the default file name of the graphics log file.|
|[VSG_NODEFAULT_INSTANCE](vsg-nodefault-instance.md)|Defines by its presence whether a default instance of the `VsgDbg` class is provided.|

## Related Articles

| Title | Description |
| - | - |
| [Capturing Graphics Information](capturing-graphics-information.md) | Shows how to capture graphics information from your DirectX-based app so that you can use [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] Graphics Diagnostics tools to diagnose rendering problems. |
| [Overview](overview-of-visual-studio-graphics-diagnostics.md) | Shows how Graphics Diagnostics can help you debug rendering errors in DirectX games and apps. |
