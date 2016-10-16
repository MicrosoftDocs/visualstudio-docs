---
title: "IDiaDataSource::loadDataFromPdb"
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
  - "IDiaDataSource::loadDataFromPdb method"
ms.assetid: 02159073-8144-47f8-a0b0-aa0edcb92b5b
caps.latest.revision: 7
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
  
 To validate the .pdb file against specific criteria, use the [IDiaDataSource::loadAndValidateDataFromPdb](../debugger/idiadatasource--loadandvalidatedatafrompdb.md) method.  
  
 To gain access to the data load process (through a callback mechanism), use the [IDiaDataSource::loadDataForExe](../debugger/idiadatasource--loaddataforexe.md) method.  
  
 To load a .pdb file directly from memory, use the [IDiaDataSource::loadDataFromIStream](../debugger/idiadatasource--loaddatafromistream.md) method.  
  
## Example  
  
```cpp#  
HRESULT hr = pSource->loadDataFromPdb( L"myprog.pdb" );  
if (FAILED(hr))  
{  
    // report error  
}  
```  
  
## See Also  
 [IDiaDataSource](../debugger/idiadatasource.md)   
 [IDiaDataSource::loadDataForExe](../debugger/idiadatasource--loaddataforexe.md)   
 [IDiaDataSource::loadAndValidateDataFromPdb](../debugger/idiadatasource--loadandvalidatedatafrompdb.md)   
 [IDiaDataSource::loadDataFromIStream](../debugger/idiadatasource--loaddatafromistream.md)