---
title: "Reference (Programmatic Capture) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
ms.assetid: ef60eb8d-1ac2-4e3a-9b4b-f6da0bdd9da8
caps.latest.revision: 8
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Reference (Programmatic Capture)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Graphics Diagnostics supports programmatic control over its capture features, through the programmatic capture API. You can use this API to toggle and add messages to the graphics diagnostics HUD (Head-Up Display), initialize and create graphics log files, and capture graphics information.  
  
## Programmatic Capture APIs  
  
### Classes  
  
|Name|Description|  
|----------|-----------------|  
|[VsgDbg Class](../debugger/vsgdbg-class.md)|Represents the interface through which the in-app component of graphics diagnostics is controlled programmatically.|  
  
### Preprocessor Symbols  
  
|Name|Description|  
|----------|-----------------|  
|[DONT_SAVE_VSGLOG_TO_TEMP](../debugger/dont-save-vsglog-to-temp.md)|Defines by its presence whether the graphics log file is saved to the user's temporary files directory.|  
|[VSG_DEFAULT_RUN_FILENAME](../debugger/vsg-default-run-filename.md)|Defines the default file name of the graphics log file.|  
|[VSG_NODEFAULT_INSTANCE](../debugger/vsg-nodefault-instance.md)|Defines by its presence whether a default instance of the `VsgDbg` class is provided.|  
  
## Related Articles  
  
|Title|Description|  
|-----------|-----------------|  
|[Capturing Graphics Information](../debugger/capturing-graphics-information.md)|Shows how to capture graphics information from your DirectX-based app so that you can use [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Graphics Diagnostics tools to diagnose rendering problems.|  
|[Overview](../debugger/overview-of-visual-studio-graphics-diagnostics.md)|Shows how Graphics Diagnostics can help you debug rendering errors in DirectX games and apps.|
