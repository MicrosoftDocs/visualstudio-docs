---
title: "IDiaReadExeAtRVACallback"
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
ms.assetid: b2892513-3952-4f99-9b98-60cb9b1fdc91
caps.latest.revision: 8
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
# IDiaReadExeAtRVACallback
Enables a client application to supply bytes of an executable file as specified by a relative virtual address.  
  
## Syntax  
  
```  
IDiaReadExeAtRVACallback : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaReadExeAtRVACallback`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaReadExeAtRVACallback::ReadExecutableAtRVA](../VS_debugger/IDiaReadExeAtRVACallback--ReadExecutableAtRVA.md)|Reads the specified number of bytes starting at the specified relative virtual address (RVA) from the executable file.|  
  
## Remarks  
 The client application implements this interface in order to provide the bytes of the executable using a relative virtual address into the executable's file. To use an absolute file offset, implement the [IDiaReadExeAtOffsetCallback](../VS_debugger/IDiaReadExeAtOffsetCallback.md) interface.  
  
## Notes for Callers  
 This method is implemented by the client application and passed to the [IDiaDataSource::loadDataForExe](../VS_debugger/IDiaDataSource--loadDataForExe.md) method as an alternative method for reading the file.  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [IDiaDataSource::loadDataForExe](../VS_debugger/IDiaDataSource--loadDataForExe.md)   
 [IDiaReadExeAtOffsetCallback](../VS_debugger/IDiaReadExeAtOffsetCallback.md)