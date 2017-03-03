---
title: "Conditional Compilation Variables (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "conditional compilation, variables"
ms.assetid: d6f9827d-c558-412c-8e68-de04c19c3d9d
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Conditional Compilation Variables (JavaScript)
The following predefined variables are available for conditional compilation. If a variable is not **true**, it is not defined and behaves as `NaN` when accessed.  
  
> [!WARNING]
>  Conditional compilation is supported in all versions of Internet Explorer prior to Internet Explorer 11. Starting with Internet Explorer 11 Standards mode, and in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps, conditional compilation is not supported.  
  
## Variables  
  
|Variable|Description|  
|--------------|-----------------|  
|@_win32|True if running on a Win32 system.|  
|@_win16|True if running on a Win16 system.|  
|@_mac|True if running on an Apple Macintosh system.|  
|@_alpha|True if running on a DEC Alpha processor.|  
|@_x86|True if running on an Intel processor.|  
|@_mc680x0|True if running on a Motorola 680x0 processor.|  
|@_PowerPC|True if running on a Motorola PowerPC processor.|  
|@_jscript|Always true.|  
|@_jscript_build|Contains the build number of the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] scripting engine.|  
|@_jscript_version|Contains the [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] version number in major.minor format.|