---
title: "IActiveScriptErrorDebug110 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptErrorDebug110 Interface"
ms.assetid: 5c1a4993-4cad-4ccf-89c2-53abfddfe1f2
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptErrorDebug110 Interface
Adds functionality to the [IActiveScriptDebug Interface](../../winscript/reference/iactivescriptdebug-interface.md). This interface is implemented by the JavaScript engine to determine why a BREAKREASON_ERROR event has occurred.  
  
> [!IMPORTANT]
> This interface is implemented by PDM v11.0 and greater. Found in activdbg100.h.  
  
## Methods  
 The `IActiveScriptErrorDebug110` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptErrorDebug110::GetExceptionThrownKind](../../winscript/reference/iactivescripterrordebug110-getexceptionthrownkind.md)|Returns the exception kind for a thrown exception.|