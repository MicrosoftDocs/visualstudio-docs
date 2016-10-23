---
title: "IDiaDataSource"
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
ms.assetid: 6260ac76-4f9d-4144-ba22-32f8620b32c2
caps.latest.revision: 13
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
# IDiaDataSource
Initiates access to a source of debugging symbols.  
  
## Syntax  
  
```  
IDiaDataSource : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaDataSource`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaDataSource::get_lastError](../VS_debugger/IDiaDataSource--get_lastError.md)|Retrieves the file name for the last load error.|  
|[IDiaDataSource::loadDataFromPdb](../VS_debugger/IDiaDataSource--loadDataFromPdb.md)|Opens and prepares a program database (.pdb) file as a debug data source.|  
|[IDiaDataSource::loadAndValidateDataFromPdb](../VS_debugger/IDiaDataSource--loadAndValidateDataFromPdb.md)|Opens and verifies that the program database (.pdb) file matches the signature information provided; prepares the .pdb file as a debug data source.|  
|[IDiaDataSource::loadDataForExe](../VS_debugger/IDiaDataSource--loadDataForExe.md)|Opens and prepares the debug data associated with the .exe/.dll file.|  
|[IDiaDataSource::loadDataFromIStream](../VS_debugger/IDiaDataSource--loadDataFromIStream.md)|Prepares the debug data stored in a program database (.pdb) file accessed through an in-memory data stream.|  
|[IDiaDataSource::openSession](../VS_debugger/IDiaDataSource--openSession.md)|Opens a session for querying symbols.|  
  
## Remarks  
 A call to one of the load methods of the `IDiaDataSource` interface opens the symbol source. A successful call to the [IDiaDataSource::openSession](../VS_debugger/IDiaDataSource--openSession.md) method returns an [IDiaSession](../VS_debugger/IDiaSession.md) interface that supports querying the data source. If the load method returns a file-related error then the [IDiaDataSource::get_lastError](../VS_debugger/IDiaDataSource--get_lastError.md) method return value contains the file name associated with the error.  
  
## Notes for Callers  
 This interface is obtained by calling the `CoCreateInstance` function with the class identifier `CLSID_DiaSource` and the interface ID of `IID_IDiaDataSource`. The example shows how this interface is obtained.  
  
## Example  
  
```cpp#  
  
      IDiaDataSource* pSource;  
HRESULT hr = CoCreateInstance(CLSID_DiaSource,  
                              NULL,  
                              CLSCTX_INPROC_SERVER,  
                              IID_IDiaDataSource,  
                              (void**) &pSource);  
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
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)