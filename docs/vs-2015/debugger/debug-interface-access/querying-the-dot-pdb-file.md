---
title: "Querying the .Pdb File | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PDB files"
  - ".pdb files, querying"
ms.assetid: 8da07d1c-2712-45f9-8fbf-f34040408a8a
caps.latest.revision: 13
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Querying the .Pdb File
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

A program database file (extension .pdb) is a binary file that contains type and symbolic debugging information gathered over the course of compiling and linking the project. A PDB file is created when you compile a C/C++ program with **/ZI** or **/Zi** or a [!INCLUDE[vbprvb](../../includes/vbprvb-md.md)], [!INCLUDE[csprcs](../../includes/csprcs-md.md)], or [!INCLUDE[jsprjscript](../../includes/jsprjscript-md.md)] program with the **/debug** option. Object files contain references into the .pdb file for debugging information. For more information on pdb files, see [PDB Files](https://msdn.microsoft.com/1761c84e-8c2c-4632-9649-b5f99964ed3f). A DIA application can use the following general steps to obtain details about the various symbols, objects, and data elements within an executable image.  
  
### To query the .pdb file  
  
1. Acquire a data source by creating an [IDiaDataSource](../../debugger/debug-interface-access/idiadatasource.md) interface.  
  
    ```cpp#  
    CComPtr<IDiaDataSource> pSource;  
    hr = CoCreateInstance( CLSID_DiaSource,  
                           NULL,  
                           CLSCTX_INPROC_SERVER,  
                           __uuidof( IDiaDataSource ),  
                          (void **) &pSource);  
  
    if (FAILED(hr))  
    {  
        Fatal("Could not CoCreate CLSID_DiaSource. Register msdia80.dll." );  
    }  
    ```  
  
2. Call [IDiaDataSource::loadDataFromPdb](../../debugger/debug-interface-access/idiadatasource-loaddatafrompdb.md) or [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md) to load the debugging information.  
  
    ```cpp#  
    wchar_t wszFilename[ _MAX_PATH ];  
    mbstowcs( wszFilename, szFilename, sizeof( wszFilename )/sizeof( wszFilename[0] ) );  
    if ( FAILED( pSource->loadDataFromPdb( wszFilename ) ) )  
    {  
        if ( FAILED( pSource->loadDataForExe( wszFilename, NULL, NULL ) ) )  
        {  
            Fatal( "loadDataFromPdb/Exe" );  
        }  
    }  
    ```  
  
3. Call [IDiaDataSource::openSession](../../debugger/debug-interface-access/idiadatasource-opensession.md) to open an [IDiaSession](../../debugger/debug-interface-access/idiasession.md) to gain access to the debugging information.  
  
    ```cpp#  
    CComPtr<IDiaSession> psession;  
    if ( FAILED( pSource->openSession( &psession ) ) )   
    {  
        Fatal( "openSession" );  
    }  
    ```  
  
4. Use the methods in `IDiaSession` to query for the symbols in the data source.  
  
    ```cpp#  
    CComPtr<IDiaSymbol> pglobal;  
    if ( FAILED( psession->get_globalScope( &pglobal) ) )  
    {  
        Fatal( "get_globalScope" );  
    }  
    ```  
  
5. Use the `IDiaEnum*` interfaces to enumerate and scan through the symbols or other elements of debug information.  
  
    ```cpp#  
    CComPtr<IDiaEnumTables> pTables;  
    if ( FAILED( psession->getEnumTables( &pTables ) ) )  
    {  
        Fatal( "getEnumTables" );  
    }  
    CComPtr< IDiaTable > pTable;  
    while ( SUCCEEDED( hr = pTables->Next( 1, &pTable, &celt ) ) && celt == 1 )  
    {  
         // Do something with each IDiaTable.  
    }  
    ```  
  
## See Also  
 [IDiaDataSource](../../debugger/debug-interface-access/idiadatasource.md)
