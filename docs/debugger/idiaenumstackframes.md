---
title: "IDiaEnumStackFrames"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumStackFrames interface"
ms.assetid: 3d1e8403-c9fc-42ff-ae35-0ab9a5ed2ad7
caps.latest.revision: 8
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# IDiaEnumStackFrames
Enumerates the various stack frames available.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaEnumStackFrames::Next](../debugger/idiaenumstackframes--next.md)|Retrieves a specified number of stack frame elements from the enumeration sequence.|  
|[IDiaEnumStackFrames::Reset](../debugger/idiaenumstackframes--reset.md)|Resets an enumeration sequence to the beginning.|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaStackWalker::getEnumFrames](../debugger/idiastackwalker--getenumframes.md) or [IDiaStackWalker::getEnumFrames2](../debugger/idiastackwalker--getenumframes2.md) methods.  
  
## Example  
 This example shows how to obtain and use the `IDiaEnumStackFrames` interface. See the [IDiaStackFrame](../debugger/idiastackframe.md) interface for an implementation of the `PrintStackFrame` function.  
  
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
 [Interfaces (Debug Interface Access SDK)](../debugger/interfaces--debug-interface-access-sdk-.md)   
 [IDiaStackWalkFrame](../debugger/idiastackwalkframe.md)   
 [IDiaStackWalker::getEnumFrames2](../debugger/idiastackwalker--getenumframes2.md)   
 [IDiaStackWalker::getEnumFrames](../debugger/idiastackwalker--getenumframes.md)