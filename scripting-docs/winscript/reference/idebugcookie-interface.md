---
title: "IDebugCookie Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugCookie interface"
ms.assetid: 0dbc75d9-6f33-400f-a5bf-9122cf534082
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugCookie Interface
Allows the debug cookie to be set, for use with the `IMachineDebugManagerCookie` interface. For more information, see [IMachineDebugManagerCookie Interface](../../winscript/reference/imachinedebugmanagercookie-interface.md). This interface is implemented by the Process Debug Manager (PDM) and consumed by script debuggers.  
  
## Methods  
 In addition to the methods inherited from `IUnknown`, the `IDebugCookie` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugCookie::SetDebugCookie](../../winscript/reference/idebugcookie-setdebugcookie.md)|Sets the debug application cookie.|  
  
## See also  
 [IMachineDebugManagerCookie Interface](../../winscript/reference/imachinedebugmanagercookie-interface.md)