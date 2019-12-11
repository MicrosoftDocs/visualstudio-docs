---
title: "IDebugSessionProvider Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugSessionProvider interface"
ms.assetid: 1b898423-7af9-44f5-8dda-987005309c99
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugSessionProvider Interface
The primary interface provided by a debugger IDE to enable host and language initiated debugging. It establishes a debug session for a running application. This interface is implemented by the machine debug manager.  
  
 In addition to the methods inherited from `IUnknown`, the `IDebugSessionProvider` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugSessionProvider::StartDebugSession](../../winscript/reference/idebugsessionprovider-startdebugsession.md)|Initiates a debug session with the specified application.|