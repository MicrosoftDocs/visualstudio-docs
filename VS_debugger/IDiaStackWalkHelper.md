---
title: "IDiaStackWalkHelper"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d66e5c84-565d-494e-8486-f91db9a34548
caps.latest.revision: 15
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
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
|[IDiaStackWalkHelper::get_registerValue](../VS_debugger/IDiaStackWalkHelper--get_registerValue.md)|Retrieves the value of a register.|  
|[IDiaStackWalkHelper::put_registerValue](../VS_debugger/IDiaStackWalkHelper--put_registerValue.md)|Sets the value of a register.|  
|[IDiaStackWalkHelper::readMemory](../VS_debugger/IDiaStackWalkHelper--readMemory.md)|Reads a block of data from the executable's image in memory.|  
|[IDiaStackWalkHelper::searchForReturnAddress](../VS_debugger/IDiaStackWalkHelper--searchForReturnAddress.md)|Searches the specified stack frame for the nearest function return address.|  
|[IDiaStackWalkHelper::searchForReturnAddressStart](../VS_debugger/IDiaStackWalkHelper--searchForReturnAddressStart.md)|Searches the specified stack frame for a return address at or near the specified stack address.|  
|[IDiaStackWalkHelper::frameForVA](../VS_debugger/IDiaStackWalkHelper--frameForVA.md)|Retrieves the stack frame that contains the specified virtual address.|  
|[IDiaStackWalkHelper::symbolForVA](../VS_debugger/IDiaStackWalkHelper--symbolForVA.md)|Retrieves the symbol that contains the specified virtual address. **Note:**  Symbol must have the type `SymTagFunctionType` (a value from the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) enumeration).|  
|[IDiaStackWalkHelper::pdataForVA](../VS_debugger/IDiaStackWalkHelper--pdataForVA.md)|Returns the PDATA data block  associated with the specified virtual address.|  
|[IDiaStackWalkHelper::imageForVA](../VS_debugger/IDiaStackWalkHelper--imageForVA.md)|Retrieves the starting virtual address of an executable, given a virtual address somewhere in the executable's memory space.|  
  
## Remarks  
 This interface is called by the DIA code to obtain information about the executable to construct a list of stack frames during program execution.  
  
## Notes for Callers  
 A client application implements this interface to support walking the stack during program execution. An instance of this interface is passed to the [IDiaStackWalker::getEnumFrames](../VS_debugger/IDiaStackWalker--getEnumFrames.md) or [IDiaStackWalker::getEnumFrames2](../VS_debugger/IDiaStackWalker--getEnumFrames2.md) methods.  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [IDiaFrameData](../VS_debugger/IDiaFrameData.md)   
 [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md)   
 [IDiaStackWalker::getEnumFrames](../VS_debugger/IDiaStackWalker--getEnumFrames.md)   
 [IDiaStackWalker::getEnumFrames2](../VS_debugger/IDiaStackWalker--getEnumFrames2.md)