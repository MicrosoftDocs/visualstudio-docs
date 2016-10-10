---
title: "IDiaDataSource::loadDataFromPdb"
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
ms.assetid: 02159073-8144-47f8-a0b0-aa0edcb92b5b
caps.latest.revision: 7
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
# IDiaDataSource::loadDataFromPdb
Opens and prepares a program database (.pdb) file as a debug data source.  
  
## Syntax  
  
```cpp#  
HRESULT loadDataFromPdb (  
   LPCOLESTR pdbPath  
);  
```  
  
#### Parameters  
 pdbPath  
 [in] The path to the .pdb file.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. The following table shows the possible return values for this method.  
  
|Value|Description|  
|-----------|-----------------|  
|E_PDB_NOT_FOUND|Failed to open the file, or determined that the file has an invalid format.|  
|E_PDB_FORMAT|Attempted to access a file with an obsolete format.|  
|E_INVALIDARG|Invalid parameter.|  
|E_UNEXPECTED|Data source has already been prepared.|  
  
## Remarks  
 This method loads the debug data directly from a .pdb file.  
  
 To validate the .pdb file against specific criteria, use the [IDiaDataSource::loadAndValidateDataFromPdb](../VS_debugger/IDiaDataSource--loadAndValidateDataFromPdb.md) method.  
  
 To gain access to the data load process (through a callback mechanism), use the [IDiaDataSource::loadDataForExe](../VS_debugger/IDiaDataSource--loadDataForExe.md) method.  
  
 To load a .pdb file directly from memory, use the [IDiaDataSource::loadDataFromIStream](../VS_debugger/IDiaDataSource--loadDataFromIStream.md) method.  
  
## Example  
  
```cpp#  
HRESULT hr = pSource->loadDataFromPdb( L"myprog.pdb" );  
if (FAILED(hr))  
{  
    // report error  
}  
```  
  
## See Also  
 [IDiaDataSource](../VS_debugger/IDiaDataSource.md)   
 [IDiaDataSource::loadDataForExe](../VS_debugger/IDiaDataSource--loadDataForExe.md)   
 [IDiaDataSource::loadAndValidateDataFromPdb](../VS_debugger/IDiaDataSource--loadAndValidateDataFromPdb.md)   
 [IDiaDataSource::loadDataFromIStream](../VS_debugger/IDiaDataSource--loadDataFromIStream.md)