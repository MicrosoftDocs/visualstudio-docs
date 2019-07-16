---
title: "IDebugWindowsComputerPort2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugWindowsComputerPort2 interface"
ms.assetid: 25f327b8-0303-4268-88d1-74df630436aa
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugWindowsComputerPort2
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Allows querying for information about the target computer.  
  
## Syntax  
  
```  
IDebugWindowsComputerPort2 : IUnknown  
```  
  
## Notes for Implementers  
 This interface is implemented by port objects of the session debug manager.  
  
## Methods  
 The following table shows the methods of `IDebugWindowsComputerPort2`.  
  
|Method|Description|  
|------------|-----------------|  
|[GetComputerInfo](../../../extensibility/debugger/reference/idebugwindowscomputerport2-getcomputerinfo.md)|Retrieves information about the computer on which the debugger in running.|  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
