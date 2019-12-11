---
title: "IDebugSessionProviderEx Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 26c5da2d-8c93-4d2b-94d2-97aaa377dcfe
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugSessionProviderEx Interface
The primary interface provided by a debugger IDE to enable host- and language-initiated debugging. It establishes a debug session for a running application. This interface is implemented by the Machine Debug Manager.  
  
 In addition to the methods inherited from `IUnknown`, the `IDebugSessionProviderEx` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugSessionProviderEx:CanJITDebug](../../winscript/reference/idebugsessionproviderex-canjitdebug.md)|Determines whether Just In Time debugging is possible with the specified application.|  
|[IDebugSessionProviderEx:StartDebugSession](../../winscript/reference/idebugsessionproviderex-startdebugsession.md)|Initiates a debug session with the specified application.|