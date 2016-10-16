---
title: "IDiaStackWalkFrame"
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
  - "IDiaStackWalkFrame interface"
ms.assetid: 42d82845-d6f6-4846-9ecd-9dd169216077
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
# IDiaStackWalkFrame
Maintains stack context between invocations of the [IDiaFrameData::execute](../debugger/idiaframedata--execute.md) method.  
  
## Syntax  
  
```  
IDiaStackWalkFrame : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaStackWalkFrame`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaStackWalkFrame::get_registerValue](../debugger/idiastackwalkframe--get_registervalue.md)|Retrieves the value of a register.|  
|[IDiaStackWalkFrame::put_registerValue](../debugger/idiastackwalkframe--put_registervalue.md)|Sets the value of a register.|  
|[IDiaStackWalkFrame::readMemory](../debugger/idiastackwalkframe--readmemory.md)|Reads memory from image.|  
|[IDiaStackWalkFrame::searchForReturnAddress](../debugger/idiastackwalkframe--searchforreturnaddress.md)|Searches the specified stack frame for the nearest function return address.|  
|[IDiaStackWalkFrame::searchForReturnAddressStart](../debugger/idiastackwalkframe--searchforreturnaddressstart.md)|Searches the specified stack frame for a return address at or near the specified address.|  
  
## Remarks  
 This interface is used during program execution to read and write registers as well as access memory and find return addresses.  
  
## Notes for Callers  
 The client application implements this interface and passes an instance of the interface to the [IDiaFrameData::execute](../debugger/idiaframedata--execute.md) method. The same instance of this interface is used again and again to maintain the state of the registers during each invocation of the `execute` method. The `execute` method also uses this interface to determine the return address.  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../debugger/interfaces--debug-interface-access-sdk-.md)   
 [IDiaFrameData::execute](../debugger/idiaframedata--execute.md)