---
title: "IDiaEnumStackFrames | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumStackFrames interface"
ms.assetid: 3d1e8403-c9fc-42ff-ae35-0ab9a5ed2ad7
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaEnumStackFrames
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Enumerates the various stack frames available.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumStackFrames::Next](../../debugger/debug-interface-access/idiaenumstackframes-next.md)|Retrieves a specified number of stack frame elements from the enumeration sequence.|  
|[IDiaEnumStackFrames::Reset](../../debugger/debug-interface-access/idiaenumstackframes-reset.md)|Resets an enumeration sequence to the beginning.|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaStackWalker::getEnumFrames](../../debugger/debug-interface-access/idiastackwalker-getenumframes.md) or [IDiaStackWalker::getEnumFrames2](../../debugger/debug-interface-access/idiastackwalker-getenumframes2.md) methods.  
  
## Example  
 This example shows how to obtain and use the `IDiaEnumStackFrames` interface. See the [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md) interface for an implementation of the `PrintStackFrame` function.  
  
```cpp#  
void DumpStackFrames(IDiaStackWalker*     pStackWalker,  
                     IDiaStackWalkHelper* pStackWalkHelper,  
                     CV_CPU_TYPE_e        cpuType)  
{  
    if (pStackWalker != NULL && pStackWalkHelper != NULL)  
    {  
        CComPtr<IDiaEnumStackFrames> pEnumsFrames;  
        HRESULT hr;  
        hr = pStackWalker->getEnumFrames2(cpuType, pStackWalkHelper, &pEnumFrames);  
        if (SUCCEEDED(hr) && pEnumFrames != NULL)  
        {  
             CComPtr<IDiaStackFrame> pStackFrame;  
             DWORD celt = 0;  
  
             while (pEnumFrames->Next(1, &pStackFrame, &celt) == S_OK)  
             {  
                 PrintStackFrame(pStackFrame);  
             }  
             pStackFrame = NULL;  
        }  
    }  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)   
 [IDiaStackWalkFrame](../../debugger/debug-interface-access/idiastackwalkframe.md)   
 [IDiaStackWalker::getEnumFrames2](../../debugger/debug-interface-access/idiastackwalker-getenumframes2.md)   
 [IDiaStackWalker::getEnumFrames](../../debugger/debug-interface-access/idiastackwalker-getenumframes.md)
