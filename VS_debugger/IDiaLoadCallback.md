---
title: "IDiaLoadCallback"
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
ms.assetid: 2f18c64c-2cf0-43fc-a447-21e82702ca2a
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
# IDiaLoadCallback
Receives callbacks from the DIA symbol locating procedure, thus enabling a user interface to report on the progress of the location attempt.  
  
## Syntax  
  
```  
IDiaLoadCallback : IUnknown  
```  
  
## Methods in Vtable Order  
 The following methods are exposed by this interface:  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaLoadCallback::NotifyDebugDir](../VS_debugger/IDiaLoadCallback--NotifyDebugDir.md)|Called when a debug directory was found in the .exe file.|  
|[IDiaLoadCallback::NotifyOpenDBG](../VS_debugger/IDiaLoadCallback--NotifyOpenDBG.md)|Called when a candidate .dbg file has been opened.|  
|[IDiaLoadCallback::NotifyOpenPDB](../VS_debugger/IDiaLoadCallback--NotifyOpenPDB.md)|Called when a candidate .pdb file has been opened.|  
|[IDiaLoadCallback::RestrictRegistryAccess](../VS_debugger/IDiaLoadCallback--RestrictRegistryAccess.md)|Determines if registry queries can be used to locate symbol search paths.|  
|[IDiaLoadCallback::RestrictSymbolServerAccess](../VS_debugger/IDiaLoadCallback--RestrictSymbolServerAccess.md)|Determines if access is allowed to a symbol server to resolve symbols.|  
  
## Remarks  
 The client application implements this interface and provides a reference to it in the call to the [IDiaDataSource::loadDataForExe](../VS_debugger/IDiaDataSource--loadDataForExe.md) method.  
  
 For additional restrictions that can be imposed on a load process, see the [IDiaLoadCallback2](../VS_debugger/IDiaLoadCallback2.md) interface.  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [IDiaDataSource::loadDataForExe](../VS_debugger/IDiaDataSource--loadDataForExe.md)   
 [IDiaReadExeAtOffsetCallback](../VS_debugger/IDiaReadExeAtOffsetCallback.md)   
 [IDiaReadExeAtRVACallback](../VS_debugger/IDiaReadExeAtRVACallback.md)   
 [IDiaLoadCallback2](../VS_debugger/IDiaLoadCallback2.md)