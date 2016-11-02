---
title: "IDiaDataSource::loadDataFromIStream"
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
  - "IDiaDataSource::loadDataFromIStream method"
ms.assetid: 8fe33eea-1457-4b8c-ae19-f1ede5578483
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
# IDiaDataSource::loadDataFromIStream
Prepares the debug data stored in a program database (.pdb) file accessed through an in-memory data stream.  
  
## Syntax  
  
```cpp#  
HRESULT loadDataFromIStream (   
   IStream* pIStream  
);  
```  
  
#### Parameters  
 pIStream  
 [in] An \<xref:IStream> object representing the data stream to use.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. The following table shows the possible return values for this method.  
  
|Value|Description|  
|-----------|-----------------|  
|E_PDB_FORMAT|Attempted to access a file with an obsolete format.|  
|E_INVALIDARG|Invalidparameter.|  
|E_UNEXPECTED|Data source has already been prepared.|  
  
## Remarks  
 This method allows the debug data for an executable to be obtained from memory through an \<xref:IStream> object.  
  
 To load a .pdb file without validation, use the [IDiaDataSource::loadDataFromPdb](../debugger/idiadatasource--loaddatafrompdb.md) method.  
  
 To validate the .pdb file against specific criteria, use the [IDiaDataSource::loadAndValidateDataFromPdb](../debugger/idiadatasource--loadandvalidatedatafrompdb.md) method.  
  
 To gain access to the data load process (through a callback mechanism), use the [IDiaDataSource::loadDataForExe](../debugger/idiadatasource--loaddataforexe.md) method.  
  
## See Also  
 [IDiaDataSource](../debugger/idiadatasource.md)   
 [IDiaDataSource::loadDataForExe](../debugger/idiadatasource--loaddataforexe.md)   
 [IDiaDataSource::loadDataFromPdb](../debugger/idiadatasource--loaddatafrompdb.md)   
 [IDiaDataSource::loadAndValidateDataFromPdb](../debugger/idiadatasource--loadandvalidatedatafrompdb.md)