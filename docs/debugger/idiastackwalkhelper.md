---
title: "IDiaStackWalkHelper"
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
  - "IDiaStackWalkHelper2 interface"
ms.assetid: d66e5c84-565d-494e-8486-f91db9a34548
caps.latest.revision: 15
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
# IDiaStackWalkHelper
Facilitates walking the stack using the program debug database (.pdb) file.  
  
## Syntax  
  
```  
  
IDiaStackWalkHelper: IUnknown  
  
```  
  
## Methods in VTable Order  
 The table below shows the methods of `IDiaStackWalkHelper`:  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaStackWalkHelper::get_registerValue](../debugger/idiastackwalkhelper--get_registervalue.md)|Retrieves the value of a register.|  
|[IDiaStackWalkHelper::put_registerValue](../debugger/idiastackwalkhelper--put_registervalue.md)|Sets the value of a register.|  
|[IDiaStackWalkHelper::readMemory](../debugger/idiastackwalkhelper--readmemory.md)|Reads a block of data from the executable's image in memory.|  
|[IDiaStackWalkHelper::searchForReturnAddress](../debugger/idiastackwalkhelper--searchforreturnaddress.md)|Searches the specified stack frame for the nearest function return address.|  
|[IDiaStackWalkHelper::searchForReturnAddressStart](../debugger/idiastackwalkhelper--searchforreturnaddressstart.md)|Searches the specified stack frame for a return address at or near the specified stack address.|  
|[IDiaStackWalkHelper::frameForVA](../debugger/idiastackwalkhelper--frameforva.md)|Retrieves the stack frame that contains the specified virtual address.|  
|[IDiaStackWalkHelper::symbolForVA](../debugger/idiastackwalkhelper--symbolforva.md)|Retrieves the symbol that contains the specified virtual address. **Note:**  Symbol must have the type `SymTagFunctionType` (a value from the [SymTagEnum Enumeration](../debugger/symtagenum.md) enumeration).|  
|[IDiaStackWalkHelper::pdataForVA](../debugger/idiastackwalkhelper--pdataforva.md)|Returns the PDATA data block  associated with the specified virtual address.|  
|[IDiaStackWalkHelper::imageForVA](../debugger/idiastackwalkhelper--imageforva.md)|Retrieves the starting virtual address of an executable, given a virtual address somewhere in the executable's memory space.|  
  
## Remarks  
 This interface is called by the DIA code to obtain information about the executable to construct a list of stack frames during program execution.  
  
## Notes for Callers  
 A client application implements this interface to support walking the stack during program execution. An instance of this interface is passed to the [IDiaStackWalker::getEnumFrames](../debugger/idiastackwalker--getenumframes.md) or [IDiaStackWalker::getEnumFrames2](../debugger/idiastackwalker--getenumframes2.md) methods.  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../debugger/interfaces--debug-interface-access-sdk-.md)   
 [IDiaFrameData](../debugger/idiaframedata.md)   
 [SymTagEnum Enumeration](../debugger/symtagenum.md)   
 [IDiaStackWalker::getEnumFrames](../debugger/idiastackwalker--getenumframes.md)   
 [IDiaStackWalker::getEnumFrames2](../debugger/idiastackwalker--getenumframes2.md)