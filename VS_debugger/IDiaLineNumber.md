---
title: "IDiaLineNumber"
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
ms.assetid: 1071f7d0-1f8c-4384-933f-c49c7eb930bd
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
# IDiaLineNumber
Accesses information that describes the process of mapping from a block of bytes of image text to a source file line number.  
  
## Syntax  
  
```  
IDiaLineNumber : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaLineNumber`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaLineNumber::get_compiland](../VS_debugger/IDiaLineNumber--get_compiland.md)|Retrieves a reference to the symbol for the compiland that contributed the bytes of image text.|  
|[IDiaLineNumber::get_sourceFile](../VS_debugger/IDiaLineNumber--get_sourceFile.md)|Retrieves a reference to the source file object.|  
|[IDiaLineNumber::get_lineNumber](../VS_debugger/IDiaLineNumber--get_lineNumber.md)|Retrieves the line number in the source file.|  
|[IDiaLineNumber::get_lineNumberEnd](../VS_debugger/IDiaLineNumber--get_lineNumberEnd.md)|Retrieves the one-based source line number where the statement or expression ends.|  
|[IDiaLineNumber::get_columnNumber](../VS_debugger/IDiaLineNumber--get_columnNumber.md)|Retrieves the column number where the expression or statement begins.|  
|[IDiaLineNumber::get_columnNumberEnd](../VS_debugger/IDiaLineNumber--get_columnNumberEnd.md)|Retrieves the column number where the expression or statement ends.|  
|[IDiaLineNumber::get_addressSection](../VS_debugger/IDiaLineNumber--get_addressSection.md)|Retrieves the section part of the memory address where a block begins.|  
|[IDiaLineNumber::get_addressOffset](../VS_debugger/IDiaLineNumber--get_addressOffset.md)|Retrieves the offset part of the memory address where a block begins.|  
|[IDiaLineNumber::get_relativeVirtualAddress](../VS_debugger/IDiaLineNumber--get_relativeVirtualAddress.md)|Retrieves the image relative virtual address (RVA) of a block.|  
|[IDiaLineNumber::get_virtualAddress](../VS_debugger/IDiaLineNumber--get_virtualAddress.md)|Retrieves the virtual address (VA) of a block.|  
|[IDiaLineNumber::get_length](../VS_debugger/IDiaLineNumber--get_length.md)|Retrieves the number of bytes in a block.|  
|[IDiaLineNumber::get_sourceFileId](../VS_debugger/IDiaLineNumber--get_sourceFileId.md)|Retrieves a unique source file identifier for the source file that contributed this line.|  
|[IDiaLineNumber::get_statement](../VS_debugger/IDiaLineNumber--get_statement.md)|Retrieves a flag indicating that this line information describes the beginning of a statement in the program source.|  
|[IDiaLineNumber::get_compilandId](../VS_debugger/IDiaLineNumber--get_compilandId.md)|Retrieves the unique identifier for the compiland that contributed this line.|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaEnumLineNumbers::Item](../VS_debugger/IDiaEnumLineNumbers--Item.md) or [IDiaEnumLineNumbers::Next](../VS_debugger/IDiaEnumLineNumbers--Next.md) methods.  
  
## Example  
 The following function displays line numbers used in a function (represented by `pSymbol`).  
  
```cpp#  
void dumpFunctionLines( IDiaSymbol* pSymbol, IDiaSession* pSession )  
{  
    ULONGLONG length = 0;  
    DWORD     isect  = 0;  
    DWORD     offset = 0;  
  
    pSymbol->get_addressSection( &isect );  
    pSymbol->get_addressOffset( &offset );  
    pSymbol->get_length( &length );  
    if ( isect != 0 && length > 0 )  
    {  
        CComPtr< IDiaEnumLineNumbers > pLines;  
        if ( SUCCEEDED( pSession->findLinesByAddr(  
                                      isect,  
                                      offset,  
                                      static_cast<DWORD>( length ),  
                                      &pLines)  
                      )  
           )  
        {  
            CComPtr< IDiaLineNumber > pLine;  
            DWORD celt      = 0;  
            bool  firstLine = true;  
  
            while ( SUCCEEDED( pLines->Next( 1, &pLine, &celt ) ) &&  
                    celt == 1 )  
            {  
                DWORD offset;  
                DWORD seg;  
                DWORD linenum;  
                CComPtr< IDiaSymbol >     pComp;  
                CComPtr< IDiaSourceFile > pSrc;  
  
                pLine->get_compiland( &pComp );  
                pLine->get_sourceFile( &pSrc );  
                pLine->get_addressSection( &seg );  
                pLine->get_addressOffset( &offset );  
                pLine->get_lineNumber( &linenum );  
                printf( "\tline %d at 0x%x:0x%x\n", linenum, seg, offset );  
                pLine = NULL;  
                if ( firstLine )  
                {  
                    // sanity check  
                    CComPtr< IDiaEnumLineNumbers > pLinesByLineNum;  
                    if ( SUCCEEDED( pSession->findLinesByLinenum(  
                                                  pComp,  
                                                  pSrc,  
                                                  linenum,  
                                                  0,  
                                                  &pLinesByLineNum)  
                                  )  
                       )  
                    {  
                        CComPtr< IDiaLineNumber > pLine;  
                        DWORD celt;  
                        while ( SUCCEEDED( pLinesByLineNum->Next( 1, &pLine, &celt ) ) &&  
                                celt == 1 )  
                        {  
                            DWORD offset;  
                            DWORD seg;  
                            DWORD linenum;  
  
                            pLine->get_addressSection( &seg );  
                            pLine->get_addressOffset( &offset );  
                            pLine->get_lineNumber( &linenum );  
                            printf( "\t\tfound line %d at 0x%x:0x%x\n", linenum, seg, offset );  
                            pLine = NULL;  
                       }  
                    }  
                    firstLine = false;  
                }  
            }  
        }  
    }  
}  
```  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [IDiaEnumLineNumbers](../VS_debugger/IDiaEnumLineNumbers.md)   
 [IDiaEnumLineNumbers::Item](../VS_debugger/IDiaEnumLineNumbers--Item.md)   
 [IDiaEnumLineNumbers::Next](../VS_debugger/IDiaEnumLineNumbers--Next.md)