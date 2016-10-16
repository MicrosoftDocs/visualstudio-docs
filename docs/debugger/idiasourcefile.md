---
title: "IDiaSourceFile"
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
  - "IDiaSourceFile interface"
ms.assetid: 6e9be757-797f-4960-ba62-c14092620bbd
caps.latest.revision: 10
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
# IDiaSourceFile
Represents a source file.  
  
## Syntax  
  
```  
IDiaSourceFile : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaSourceFile`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaSourceFile::get_uniqueId](../debugger/idiasourcefile--get_uniqueid.md)|Retrieves a simple integer key value that is unique for this image.|  
|[IDiaSourceFile::get_fileName](../debugger/idiasourcefile--get_filename.md)|Retrieves the source file name.|  
|[IDiaSourceFile::get_checksumType](../debugger/idiasourcefile--get_checksumtype.md)|Retrieves the checksum type.|  
|[IDiaSourceFile::get_compilands](../debugger/idiasourcefile--get_compilands.md)|Retrieves an enumerator of the compilands with line numbers referencing this file.|  
|[IDiaSourceFile::get_checksum](../debugger/idiasourcefile--get_checksum.md)|Retrieves the checksum bytes.|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaEnumSourceFiles::Item](../debugger/idiaenumsourcefiles--item.md) or [IDiaEnumSourceFiles::Next](../debugger/idiaenumsourcefiles--next.md) methods. See the example for details.  
  
## Example  
 This function displays the names of all source files contributing to the specified table.  
  
```cpp#  
void ShowSourceFiles(IDiaTable *pTable)  
{  
    CComPtr<IDiaEnumSourceFiles> pSourceFiles;  
    if ( SUCCEEDED( pTable->QueryInterface(  
                                _uuidof( IDiaEnumSourceFiles ),  
                               (void**)&pSourceFiles )  
                  )  
       )  
    {  
        CComPtr<IDiaSourceFile> pSourceFile;  
        while ( SUCCEEDED( hr = pSourceFiles->Next( 1, &pSourceFile, &celt ) ) &&  
                celt == 1 )  
        {  
            CDiaBSTR fileName;  
            if ( pSourceFile->get_fileName( &fileName) == S_OK )  
            {  
                printf( "file name: %ws\n", fileName );  
            }  
            pSourceFile = NULL;  
        }  
    }  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../debugger/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumSourceFiles::Item](../debugger/idiaenumsourcefiles--item.md)   
 [IDiaEnumSourceFiles::Next](../debugger/idiaenumsourcefiles--next.md)   
 [IDiaLineNumber::get_sourceFile](../debugger/idialinenumber--get_sourcefile.md)   
 [IDiaSession::findFileById](../debugger/idiasession--findfilebyid.md)   
 [IDiaSession::findLines](../debugger/idiasession--findlines.md)   
 [IDiaSession::findLinesByLinenum](../debugger/idiasession--findlinesbylinenum.md)