---
title: "IDiaLoadCallback2"
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
  - "IDiaLoadCallback2 interface"
ms.assetid: 9a44277d-cbed-4811-9bad-5a2aa0f09323
caps.latest.revision: 13
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
# IDiaLoadCallback2
Receives callbacks from the DIA symbol locating procedure, allowing restrictions to be imposed on the locating process.  
  
## Syntax  
  
```  
IDiaLoadCallback2 : IDiaLoadCallback  
```  
  
## Methods in Vtable Order  
 In addition to the methods in the [IDiaLoadCallback](../debugger/idialoadcallback.md) interface, this interface exposes the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaLoadCallback2::RestrictOriginalPathAccess](../debugger/idialoadcallback2--restrictoriginalpathaccess.md)|Determines if looking for a .pdb file in the original debug directory.|  
|[IDiaLoadCallback2::RestrictReferencePathAccess](../debugger/idialoadcallback2--restrictreferencepathaccess.md)|Determines if looking for a .pdb file is allowed in the path where the .exe file is located.|  
|[IDiaLoadCallback2::RestrictDBGAccess](../debugger/idialoadcallback2--restrictdbgaccess.md)|Determines if looking for debug information is allowed from .dbg files.|  
|[IDiaLoadCallback2::RestrictSystemRootAccess](../debugger/idialoadcallback2--restrictsystemrootaccess.md)|Determines if searching for .pdb files is allowed in the system root directory.|  
  
## Remarks  
 The client application implements this interface and provides a reference to it in the call to the [IDiaDataSource::loadDataForExe](../debugger/idiadatasource--loaddataforexe.md) method. Remember to implement all of the methods in the [IDiaLoadCallback](../debugger/idialoadcallback.md) interface as well.  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../debugger/interfaces--debug-interface-access-sdk-.md)   
 [IDiaDataSource::loadDataForExe](../debugger/idiadatasource--loaddataforexe.md)   
 [IDiaReadExeAtOffsetCallback](../debugger/idiareadexeatoffsetcallback.md)   
 [IDiaReadExeAtRVACallback](../debugger/idiareadexeatrvacallback.md)   
 [IDiaLoadCallback](../debugger/idialoadcallback.md)