---
title: "IDiaStackWalker | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaStackWalker interface"
ms.assetid: 4a61a22a-9cf8-4ea1-9e6e-b42f96872d40
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaStackWalker
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Provides methods to do a stack walk using information in the .pdb file.  
  
## Syntax  
  
```  
IDiaStackWalker: IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaStackWalker`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaStackWalker::getEnumFrames](../../debugger/debug-interface-access/idiastackwalker-getenumframes.md)|Retrieves a stack frame enumerator for x86 platforms.|  
|[IDiaStackWalker::getEnumFrames2](../../debugger/debug-interface-access/idiastackwalker-getenumframes2.md)|Retrieves a stack frame enumerator for a specific platform type.|  
  
## Remarks  
 This interface is used to obtain a list of stack frames for a loaded module. Each of the methods is passed an [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md) object (implemented by the client application) which provides the necessary information to create the list of stack frames.  
  
## Notes for Callers  
 This interface is obtained by calling the `CoCreateInstance` method with the class identifier `CLSID_DiaStackWalker` and the interface ID of `IID_IDiaStackWalker`. The example shows how this interface is obtained.  
  
## Example  
 This example shows how to obtain the `IDiaStackWalker` interface.  
  
```cpp#  
  
      IDiaStackWalker* pStackWalker;  
HRESULT hr = CoCreateInstance(CLSID_DiaStackWalker,  
                              NULL,  
                              CLSCTX_INPROC_SERVER,  
                              IID_IDiaStackWalker,  
                              (void**) &pStackWalker);  
if (FAILED(hr))  
{  
    // Report error and exit  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)   
 [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)
