---
title: "IDiaDataSource::loadDataFromIStream | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaDataSource::loadDataFromIStream method"
ms.assetid: 8fe33eea-1457-4b8c-ae19-f1ede5578483
caps.latest.revision: 7
author: "mikejo5000"
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
 [in] An <xref:IStream> object representing the data stream to use.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. The following table shows the possible return values for this method.  
  
|Value|Description|  
|-----------|-----------------|  
|E_PDB_FORMAT|Attempted to access a file with an obsolete format.|  
|E_INVALIDARG|Invalidparameter.|  
|E_UNEXPECTED|Data source has already been prepared.|  
  
## Remarks  
 This method allows the debug data for an executable to be obtained from memory through an <xref:IStream> object.  
  
 To load a .pdb file without validation, use the [IDiaDataSource::loadDataFromPdb](../../debugger/debug-interface-access/idiadatasource-loaddatafrompdb.md) method.  
  
 To validate the .pdb file against specific criteria, use the [IDiaDataSource::loadAndValidateDataFromPdb](../../debugger/debug-interface-access/idiadatasource-loadandvalidatedatafrompdb.md) method.  
  
 To gain access to the data load process (through a callback mechanism), use the [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md) method.  
  
## See Also  
 [IDiaDataSource](../../debugger/debug-interface-access/idiadatasource.md)   
 [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md)   
 [IDiaDataSource::loadDataFromPdb](../../debugger/debug-interface-access/idiadatasource-loaddatafrompdb.md)   
 [IDiaDataSource::loadAndValidateDataFromPdb](../../debugger/debug-interface-access/idiadatasource-loadandvalidatedatafrompdb.md)