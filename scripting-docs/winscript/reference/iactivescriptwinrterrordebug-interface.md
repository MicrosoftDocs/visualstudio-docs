---
title: "IActiveScriptWinRTErrorDebug Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptWinRTErrorDebug Interface"
ms.assetid: 58b45096-633f-479f-95c4-8eae7376d3a1
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptWinRTErrorDebug Interface
Implemented by the JavaScript engine to provide extended Windows Runtime error information from a [BREAKREASON Enumeration](../../winscript/reference/breakreason-enumeration.md) event. You can do a QueryInterface to get it from an [IActiveScriptError](../../winscript/reference/iactivescripterror.md) object.  
  
> [!IMPORTANT]
> This interface is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Methods  
 The `IActiveScriptWinRTErrorDebug` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptWinRTErrorDebug::GetCapabilitySid](../../winscript/reference/iactivescriptwinrterrordebug-getcapabilitysid.md)|Returns the capability SID for the Windows Runtime error, if available.|  
|[IActiveScriptWinRTErrorDebug::GetRestrictedErrorReference](../../winscript/reference/iactivescriptwinrterrordebug-getrestrictederrorreference.md)|Returns the Windows Runtime restricted error reference string, if available.|  
|[IActiveScriptWinRTErrorDebug::GetRestrictedErrorString](../../winscript/reference/iactivescriptwinrterrordebug-getrestrictederrorstring.md)|Returns the Windows Runtime restricted error string, if available.|