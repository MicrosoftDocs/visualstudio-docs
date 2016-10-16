---
title: "IDiaLoadCallback"
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
  - "IDiaLoadCallback interface"
ms.assetid: 2f18c64c-2cf0-43fc-a447-21e82702ca2a
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
|[IDiaLoadCallback::NotifyDebugDir](../debugger/idialoadcallback--notifydebugdir.md)|Called when a debug directory was found in the .exe file.|  
|[IDiaLoadCallback::NotifyOpenDBG](../debugger/idialoadcallback--notifyopendbg.md)|Called when a candidate .dbg file has been opened.|  
|[IDiaLoadCallback::NotifyOpenPDB](../debugger/idialoadcallback--notifyopenpdb.md)|Called when a candidate .pdb file has been opened.|  
|[IDiaLoadCallback::RestrictRegistryAccess](../debugger/idialoadcallback--restrictregistryaccess.md)|Determines if registry queries can be used to locate symbol search paths.|  
|[IDiaLoadCallback::RestrictSymbolServerAccess](../debugger/idialoadcallback--restrictsymbolserveraccess.md)|Determines if access is allowed to a symbol server to resolve symbols.|  
  
## Remarks  
 The client application implements this interface and provides a reference to it in the call to the [IDiaDataSource::loadDataForExe](../debugger/idiadatasource--loaddataforexe.md) method.  
  
 For additional restrictions that can be imposed on a load process, see the [IDiaLoadCallback2](../debugger/idialoadcallback2.md) interface.  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../debugger/interfaces--debug-interface-access-sdk-.md)   
 [IDiaDataSource::loadDataForExe](../debugger/idiadatasource--loaddataforexe.md)   
 [IDiaReadExeAtOffsetCallback](../debugger/idiareadexeatoffsetcallback.md)   
 [IDiaReadExeAtRVACallback](../debugger/idiareadexeatrvacallback.md)   
 [IDiaLoadCallback2](../debugger/idialoadcallback2.md)