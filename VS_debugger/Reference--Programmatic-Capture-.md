---
title: "Reference (Programmatic Capture)"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ef60eb8d-1ac2-4e3a-9b4b-f6da0bdd9da8
caps.latest.revision: 5
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Reference (Programmatic Capture)
Graphics Diagnostics supports programmatic control over its capture features, through the programmatic capture API. You can use this API to toggle and add messages to the graphics diagnostics HUD (Head-Up Display), initialize and create graphics log files, and capture graphics information.  
  
## Programmatic Capture APIs  
  
### Classes  
  
|Name|Description|  
|----------|-----------------|  
|[VsgDbg Class](../VS_debugger/VsgDbg-Class.md)|Represents the interface through which the in-app component of graphics diagnostics is controlled programmatically.|  
  
### Preprocessor Symbols  
  
|Name|Description|  
|----------|-----------------|  
|[DONT_SAVE_VSGLOG_TO_TEMP](../VS_debugger/DONT_SAVE_VSGLOG_TO_TEMP.md)|Defines by its presence whether the graphics log file is saved to the user's temporary files directory.|  
|[VSG_DEFAULT_RUN_FILENAME](../VS_debugger/VSG_DEFAULT_RUN_FILENAME.md)|Defines the default file name of the graphics log file.|  
|[VSG_NODEFAULT_INSTANCE](../VS_debugger/VSG_NODEFAULT_INSTANCE.md)|Defines by its presence whether a default instance of the `VsgDbg` class is provided.|  
  
## Related Articles  
  
|Title|Description|  
|-----------|-----------------|  
|[Capturing Graphics Information](../VS_debugger/Capturing-Graphics-Information.md)|Shows how to capture graphics information from your DirectX-based app so that you can use Visual Studio Graphics Diagnostics tools to diagnose rendering problems.|  
|[Overview](../VS_debugger/Overview-of-Visual-Studio-Graphics-Diagnostics.md)|Shows how Graphics Diagnostics can help you debug rendering errors in DirectX games and apps.|