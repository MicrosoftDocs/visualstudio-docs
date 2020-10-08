---
title: "Dia2dump.cpp Source File | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Dia2dump sample [DIA SDK], sample source"
ms.assetid: 32fd92f6-3de5-4353-b7cb-66781e03b38f
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Dia2dump.cpp Source File
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The following Dia2dump.cpp source code displays the contents of a .pdb file. This source code is used by [Dia2dump Sample](../../debugger/debug-interface-access/dia2dump-sample.md).  
  
```  
// dia2dump.cpp : Dump contents of a pdb file using DIA.  
//  
//       Copyright (c) Microsoft Corporation. All rights reserved.  
//  
//---------------------------------------------------------------  
//  
  
#include "stdafx.h"  
#include "diacreate.h"  
#include "cvconst.h"  
  
void Fatal( const char *msg )  
{  
    printf( msg );  
    printf( "\n" );  
    exit(-1);  
}  
  
void Error( const char *msg )  
{  
    printf( " **error: %s\n", msg );  
}  
  
class CDiaBSTR   
{  
    BSTR m_bstr;  
public:  
    CDiaBSTR()         { m_bstr = NULL; }  
    ~CDiaBSTR()        { if (m_bstr != NULL) SysFreeString( m_bstr ); }  
    BSTR *operator &() { assert(m_bstr == NULL); return &m_bstr; }  
    operator BSTR()    { assert(m_bstr != NULL); return m_bstr; }  
};  
  
CComPtr<IDiaSession> psession;  
CComPtr<IDiaSymbol> pglobal;  
  
void printVariant( VARIANT& v )  
{  
    switch( v.vt )  
    {  
 //*    LONGLONG       VT_I8  
    case VT_I8:  
        printf( "%ld", v.llVal );  
        break;  
 //*    LONG           VT_I4  
    case VT_I4:  
        printf( "%d", v.lVal );  
        break;  
 //*    BYTE           VT_UI1  
    case VT_UI1:  
        printf( "%d", v.bVal);  
        break;  
 //*    SHORT          VT_I2  
    case VT_I2:  
        printf( "%d", v.iVal);  
        break;  
 //*    CHAR           VT_I1  
    case VT_I1:  
        printf( "%d", v.cVal);  
        break;  
 //*    USHORT         VT_UI2  
    case VT_UI2:  
        printf( "%d", v.uiVal);  
        break;  
//*    ULONG          VT_UI4  
    case VT_UI4:  
        printf( "%d", v.ulVal);  
        break;  
 //*    ULONGLONG      VT_UI8  
    case VT_UI8:  
        printf( "%ld", v.ullVal);  
        break;  
 //*    INT            VT_INT  
    case VT_INT:  
        printf( "%d", v.intVal);  
        break;  
 //*    UINT           VT_UINT  
    case VT_UINT:  
        printf( "%d", v.uintVal);  
        break;  
    default:  
        printf( "<Not implemented>" );  
        break;  
    }  
}  
  
void printBound( IDiaSymbol* pBound )  
{  
    DWORD tag = 0;  
    CDiaBSTR name;  
    DWORD kind;  
    pBound->get_symTag( &tag );  
    pBound->get_locationType( &kind );  
    if ( tag == SymTagData && kind == LocIsConstant ) {  
        CComVariant v;  
        pBound->get_value( &v );  
        printVariant( v );  
    } else if ( pBound->get_name( &name ) == S_OK ) {  
        printf( "%ws", name );  
    }  
}  
  
void printType( IDiaSymbol* pType )  
{  
    DWORD tag = 0;  
    pType->get_symTag( &tag );  
    CDiaBSTR name;  
    if ( pType->get_name( &name ) == S_OK && name != NULL ) {  
        printf( "-%ws", name );  
    } else if ( tag == SymTagPointerType ) {  
        CComPtr<IDiaSymbol> pBaseType;  
        if (  pType->get_type( &pBaseType ) == S_OK ) {  
            printType( pBaseType );  
            printf( "*" );  
        } else {  
            Fatal( "pointer get_type" );  
        }  
    } else if ( tag == SymTagBaseType ) {  
        ULONGLONG size;  
        DWORD bt;  
        if ( pType->get_length( &size ) != S_OK )  
            Fatal( "Internal error, no Length" );  
        if ( pType->get_baseType( &bt ) != S_OK )  
            Fatal( "Internal error, no baseType" );  
         wprintf( L"(base type=%d, len=%ld)  ", bt, size );  
    } else if ( tag == SymTagArrayType ) {  
        CComPtr<IDiaSymbol> pBaseType;  
        if ( pType->get_type( &pBaseType ) == S_OK ) {  
            printType( pBaseType );  
        } else {  
            Fatal( "array get_type" );  
        }  
        DWORD rank;  
        DWORD celt;  
        LONG count;  
        CComPtr< IDiaEnumSymbols > pEnum;  
        if ( pType->get_rank( &rank ) == S_OK ) {  
            if ( pType->findChildren( SymTagDimension, NULL, nsNone, &pEnum ) == S_OK && pEnum != NULL ) {  
                CComPtr< IDiaSymbol > pSym;  
                while ( pEnum->Next( 1, &pSym, &celt ) == S_OK && celt == 1 ) {  
                    CComPtr< IDiaSymbol > pBound;  
                    printf( "[" );  
                    if ( pSym->get_lowerBound( &pBound ) == S_OK ) {  
                        printBound( pBound );  
                        printf("..");  
                    }  
                    pBound = NULL;  
                    if ( pSym->get_upperBound( &pBound ) == S_OK ) {  
                        printBound( pBound );  
                    }  
                    pBound = NULL;  
                    printf( "]" );  
                    pSym = NULL;  
  
                }  
            }   
        } else if ( pType->findChildren( SymTagCustomType, NULL, nsNone, &pEnum ) == S_OK && pEnum != NULL && SUCCEEDED( pEnum->get_Count( &count ) ) && count > 0 ){  
                CComPtr< IDiaSymbol > pSym;  
                while ( pEnum->Next( 1, &pSym, &celt ) == S_OK && celt == 1 ) {  
                    printf( "[" );  
                    printType( pSym );  
                    printf( "]" );  
                    pSym = NULL;  
                }  
        } else {  
            ULONGLONG lenArray;  
            ULONGLONG lenElem;  
            if ( pType->get_length( &lenArray ) != S_OK  
                || pBaseType->get_length( &lenElem ) != S_OK ) {  
                Fatal( "No type length." );  
            }  
            printf( "[%ld]", lenArray/lenElem );  
        }  
    } else if ( tag == SymTagFunctionType ) {  
        printf( "Function Type" );  
    } else if ( tag == SymTagCustomType ) {  
        printf( "Custom Type: " );  
        DWORD id;  
        DWORD rec;  
        GUID guid;  
        if ( pType->get_guid( &guid ) == S_OK ) {  
            wchar_t wszGuid[64];  
            StringFromGUID2(guid, wszGuid, 64);  
            printf( "%ws", wszGuid );  
        } else if ( pType->get_oemId( &id ) == S_OK && pType->get_oemSymbolId( &rec ) == S_OK ) {  
            printf( "%x:%x", id, rec );  
        }  
        DWORD len = 0;  
        if ( pType->get_types( 0, &len, NULL ) == S_OK && len > 0 ) {  
            IDiaSymbol** psyms = new IDiaSymbol*[ len ];  
            if ( psyms == NULL ) {  
                Fatal( "out of memory" );  
            }  
            pType->get_types( len, &len, psyms );  
            for ( DWORD i = 0; i < len; ++i ) {  
                printf( " <" );  
                printType( psyms[i] );  
                printf( ">" );  
                psyms[i]->Release();  
            }  
            delete [] psyms;  
        }  
        len = 0;  
        if ( pType->get_dataBytes( 0, &len, NULL ) == S_OK && len > 0 ) {  
            BYTE* pdata = new BYTE[ len ];  
            if ( pdata == NULL ) {  
                Fatal( "out of memory" );  
            }  
            pType->get_dataBytes( len, &len, pdata );  
            printf( "<data" );  
            for ( DWORD i = 0; i < len; ++i ) {  
                printf( " %02x", pdata[i] );  
            }  
            printf( " data>" );  
            delete [] pdata;  
        }  
    } else {  
        printf( "No Type.");  
    }  
}  
  
void dumpFunctionLines( IDiaSymbol* pSymbol, IDiaSession* pSession )  
{  
    ULONGLONG length = 0;  
    DWORD isect = 0;  
    DWORD offset = 0;  
    pSymbol->get_addressSection( &isect );  
    pSymbol->get_addressOffset( &offset );  
    pSymbol->get_length( &length );  
    if ( isect != 0 && length > 0 ) {  
        CComPtr< IDiaEnumLineNumbers > pLines;  
        if ( SUCCEEDED( pSession->findLinesByAddr( isect, offset, static_cast<DWORD>( length ), &pLines ) ) ) {  
            CComPtr< IDiaLineNumber > pLine;  
            DWORD celt;  
            bool firstLine = true;  
            while ( SUCCEEDED( pLines->Next( 1, &pLine, &celt ) ) && celt == 1 ){  
                DWORD offset;  
                DWORD seg;  
                DWORD linenum;  
                CComPtr< IDiaSymbol > pComp;  
                CComPtr< IDiaSourceFile > pSrc;  
                pLine->get_compiland( &pComp );  
                pLine->get_sourceFile( &pSrc );  
                pLine->get_addressSection( &seg );  
                pLine->get_addressOffset( &offset );  
                pLine->get_lineNumber( &linenum );  
                printf( "\tline %d at 0x%x:0x%x\n", linenum, seg, offset );  
                pLine = NULL;  
                if ( firstLine ) {  
                    // sanity check  
                    CComPtr< IDiaEnumLineNumbers > pLinesByLineNum;  
                    if ( SUCCEEDED( pSession->findLinesByLinenum( pComp, pSrc, linenum, 0, &pLinesByLineNum ) ) ) {  
                        CComPtr< IDiaLineNumber > pLine;  
                        DWORD celt;  
                        while ( SUCCEEDED( pLinesByLineNum->Next( 1, &pLine, &celt ) ) && celt == 1 ){  
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
  
wchar_t* szTags[] = {  
    L"",  
    L"Executable (Global)",  
    L"Compiland",   
    L"CompilandDetails",   
    L"CompilandEnv",  
    L"Function",   
    L"Block",  
    L"Data",  
    L"Unused",   
    L"Label",   
    L"PublicSymbol",   
    L"UDT",   
    L"Enum",   
    L"FunctionType",   
    L"PointerType",   
    L"ArrayType",   
    L"BaseType",   
    L"Typedef",   
    L"BaseClass",  
    L"Friend",  
    L"FunctionArgType",   
    L"FuncDebugStart",   
    L"FuncDebugEnd",  
    L"UsingNamespace",   
    L"VTableShape",  
    L"VTable",  
    L"Custom",  
    L"Thunk",  
    L"CustomType",  
    L""  
};  
  
bool fTagScopes[] = {  
    false,  
    true,  
    true,   
    false,   
    false,  
    true,   
    true,  
    false,  
    false,   
    false,   
    false,   
    false,   
    false,   
    false,   
    false,   
    false,   
    false,   
    false,   
    false,  
    false,  
    false,   
    false,   
    false,  
    false,   
    false,  
    false,  
    false,  
    false,  
    false,  
    false  
};  
  
wchar_t* szDataKinds[] = {  
    L"Unknown",  
    L"Local",  
    L"Static Local",  
    L"Parameter",  
    L"Object Pointer",  
    L"File Static",  
    L"Global",  
    L"Member",  
    L"Static Member",  
    L"Constant"  
};  
  
wchar_t* symbolTagName( DWORD tag )  
{  
    if ( tag > SymTagNull && tag < SymTagMax )  
        return szTags[ tag ];  
    assert( false );  
    return L"Error!";  
}  
  
bool isScopeSym( DWORD tag )  
{  
    if ( tag > SymTagNull && tag < SymTagMax )  
        return fTagScopes[ tag ];  
    assert( false );  
    return false;  
}  
  
void printScopeName( IDiaSymbol* pscope )  
{  
    DWORD tag;  
    CDiaBSTR name;  
    if ( pscope->get_symTag( &tag ) != S_OK )  
        Fatal( "Internal error, getting SymTag" );  
    if ( pscope->get_name( &name ) != S_OK )  
        Fatal( "Internal error, getting name" );  
    if ( name == NULL ) {  
        wprintf( szTags[ tag ] );  
        return;  
    }  
    wprintf( L"%ws (%ws)", name, szTags[ tag ] );  
}  
  
void PrintNameFromScope( wchar_t* name, IDiaSymbol* pscope, IDiaEnumSymbols* pEnum )  
{  
    CComPtr< IDiaSymbol> pSym;  
    DWORD celt;  
    while ( SUCCEEDED( pEnum->Next( 1, &pSym, &celt ) ) && celt == 1 ) {  
        DWORD tag;  
        CDiaBSTR name;  
        if ( pSym->get_symTag( &tag ) != S_OK )  
            Fatal( "Internal error, no SymTag" );  
        if ( pSym->get_name( &name ) != S_OK )  
            Fatal( "Internal error, no name" );  
        // tagtype name found in name or scopeTag  
        wprintf( L"\t%ws %ws found in ", szTags[ tag ], name );  
        printScopeName( pscope );  
        wprintf( L"\n" );  
        pSym = 0;  
    }  
}  
  
void FindNameInNamespace( wchar_t* name, IDiaSymbol* pnamespace )  
{  
    wchar_t *buf = NULL;  
    CDiaBSTR szNamespace;  
    pnamespace->get_name( &szNamespace );  
    buf = new wchar_t[ wcslen( name ) + wcslen( szNamespace ) + 3];  
    if ( buf == NULL ) {  
        Fatal( "out of memory" );  
    }  
    wsprintfW( buf, L"%s::%s", szNamespace, name );  
    CComPtr< IDiaEnumSymbols > pEnum;  
    if ( FAILED( pglobal->findChildren( SymTagNull, name, nsCaseSensitive, &pEnum ) ) )  
        Fatal( "Namespace findChildren failed" );  
    long cnt = 0;  
    if ( pEnum != NULL && SUCCEEDED( pEnum->get_Count(&cnt) ) && cnt > 0 ) {  // found a name!  
        PrintNameFromScope( name, pglobal, pEnum );  
    }  
    delete [] buf;  
}  
  
void FindNameInEnum( wchar_t* name, IDiaSymbol* penumeration )  
{  
    CComPtr< IDiaEnumSymbols > pEnum;  
    if ( FAILED( penumeration->findChildren( SymTagData, name, nsRegularExpression, &pEnum ) ) )  
        Fatal( "Enumeration findChildren failed" );  
    long cnt = 0;  
    if ( pEnum != NULL && SUCCEEDED( pEnum->get_Count(&cnt) ) && cnt > 0 ) {  // found a name!  
        PrintNameFromScope( name, penumeration, pEnum );  
    }  
}  
  
void FindNameInClass( wchar_t* name, IDiaSymbol* pclass )  
{  
    CComPtr< IDiaEnumSymbols > pEnum;  
    if ( FAILED( pclass->findChildren( SymTagNull, name, nsCaseSensitive, &pEnum ) ) )   
        Fatal( "Class findChildren failed" );  
    long cnt = 0;  
    if ( pEnum != NULL && SUCCEEDED( pEnum->get_Count(&cnt) ) && cnt > 0 ) {  // found a name!  
        PrintNameFromScope( name, pclass, pEnum );  
    }  
    pEnum = 0;  
    // check out the enumerations  
    CComPtr< IDiaSymbol > pSym;  
    if ( FAILED( pclass->findChildren( SymTagEnum, NULL, nsNone, &pEnum ) ) )   
        Fatal( "Class findChildren for enums failed" );  
    if ( pEnum != NULL && SUCCEEDED( pEnum->get_Count(&cnt) ) && cnt > 0 ) {  // found an enum!  
        DWORD celt;  
        while ( SUCCEEDED( pEnum->Next( 1, &pSym, &celt ) ) && celt == 1 ) {  
            FindNameInEnum( name, pSym );  
            pSym = 0;  
        }  
    }  
    pEnum = 0;  
    // check out the base classes  
    if ( FAILED( pclass->findChildren( SymTagBaseClass, NULL, nsNone, &pEnum ) ) )   
        Fatal( "Class findChildren for base classes failed" );  
    if ( pEnum != NULL && SUCCEEDED( pEnum->get_Count(&cnt) ) && cnt > 0 ) {  // found a base class!  
        DWORD celt;  
        while ( SUCCEEDED( pEnum->Next( 1, &pSym, &celt ) ) && celt == 1 ) {  
            CComPtr< IDiaSymbol > pClass;  
            if (  pSym->get_type( &pClass ) == S_OK )  
                Fatal( "Getting class for a base type failed" );  
            if ( pClass )  
                FindNameInClass( name, pClass );  
            pSym = 0;  
        }  
    }  
}  
  
void FindCppNameInScope( wchar_t* name, IDiaSymbol* pScope )  
{  
    // while ( scope ) {  
        // Scan the scope for a symbol.  
        // If any namespaces, then scan for name in namespace.  
        // If scope is a member function then   
        //    scan class parent for member with name.  
        // scope = scope.parent;  
    // }  
  
    wprintf( L"Finding name \"%ws\" in ", name );  
    printScopeName( pScope );  
    wprintf( L"\n" );  
  
    DWORD celt;  
    long cnt = 0;  
    CComPtr< IDiaSymbol > pSym;  
    CComPtr< IDiaSymbol > pParent;  
    CComPtr< IDiaSymbol > pscope;  
    for ( pscope = pScope; pscope != NULL; ) {  
        CComPtr< IDiaEnumSymbols > pEnum;  
        // local data search  
        if ( FAILED( pscope->findChildren( SymTagNull, name, nsCaseSensitive, &pEnum ) ) )  
            Fatal( "Local scope findChildren failed" );  
        if ( pEnum != NULL && SUCCEEDED( pEnum->get_Count(&cnt) ) && cnt > 0 ) {  // found a name!  
            PrintNameFromScope( name, pscope, pEnum );  
        }  
        pEnum = 0;  
        // look into any namespaces  
        if ( FAILED( pscope->findChildren( SymTagUsingNamespace, NULL, nsNone, &pEnum ) ) )  
            Fatal( "Namespace findChildren failed" );  
        if ( pEnum != NULL && SUCCEEDED( pEnum->get_Count(&cnt) ) && cnt > 0 ) {  // found a namespace!  
            while ( SUCCEEDED( pEnum->Next( 1, &pSym, &celt ) ) && celt == 1 ) {  
                FindNameInNamespace( name, pSym );  
                pSym = 0;  
            }  
        }  
        pEnum = 0;  
        // is this a member function?  
        DWORD tag = SymTagNull;  
        if ( SUCCEEDED( pscope->get_symTag( &tag ) )   
            && tag == SymTagFunction  
            && SUCCEEDED( pscope->get_classParent( &pParent ) )  
            && pParent != NULL ) {  
            FindNameInClass( name, pParent );  
        }  
        pParent = NULL;  
        // move to lexical parent  
        if ( SUCCEEDED( pscope->get_lexicalParent( &pParent ) )  
            && pParent != NULL ) {  
            pscope = pParent;  
        } else {  
            pscope = NULL;  
        }  
        pParent = NULL;  
    };  
}  
  
void dumpLocalVars( DWORD rva )  
{  
    CComPtr< IDiaSymbol > pBlock;  
    if ( FAILED( psession->findSymbolByRVA( rva, SymTagBlock, &pBlock ) ) ) {  
        Fatal( "Failed to find symbols by RVA" );  
    }  
    CComPtr< IDiaSymbol > pscope;  
    for ( ; pBlock != NULL; ) {  
        CComPtr< IDiaEnumSymbols > pEnum;  
        // local data search  
        if ( FAILED( pBlock->findChildren( SymTagNull, NULL, nsNone, &pEnum ) ) )  
            Fatal( "Local scope findChildren failed" );  
        CComPtr< IDiaSymbol > pSymbol;  
        DWORD tag;  
        DWORD celt;  
        while ( pEnum != NULL && SUCCEEDED( pEnum->Next( 1, &pSymbol, &celt ) ) && celt == 1 ) {  
            pSymbol->get_symTag( &tag );  
            if ( tag == SymTagData ) {  
                CDiaBSTR name;  
                DWORD kind;  
                pSymbol->get_name( &name );  
                pSymbol->get_dataKind( &kind );  
                if ( name != NULL )  
                    wprintf( L"\t%s (%s)\n", name, szDataKinds[ kind ] );  
            } else if ( tag == SymTagAnnotation ) {  
                CComPtr< IDiaEnumSymbols > pValues;  
                // local data search  
                wprintf( L"\tAnnotation:\n" );  
                if ( FAILED( pSymbol->findChildren( SymTagNull, NULL, nsNone, &pValues ) ) )  
                    Fatal( "Annotation findChildren failed" );  
                pSymbol = NULL;  
                while ( pValues != NULL && SUCCEEDED( pValues->Next( 1, &pSymbol, &celt ) ) && celt == 1 ) {  
                    CComVariant value;  
                    if ( pSymbol->get_value( &value ) != S_OK )  
                        Fatal( "No value for annotation data." );  
                    wprintf( L"\t\t%ws\n", value.bstrVal );  
                    pSymbol = NULL;  
                }  
            }  
            pSymbol = NULL;  
        }  
        pBlock->get_symTag( &tag );   
        if ( tag == SymTagFunction )    // stop when at function scope  
            break;  
        // move to lexical parent  
        CComPtr< IDiaSymbol > pParent;  
        if ( SUCCEEDED( pBlock->get_lexicalParent( &pParent ) )  
            && pParent != NULL ) {  
            pBlock = pParent;  
        } else {  
            Fatal( "Finding lexical parent failed." );  
        }  
    };  
}  
  
DWORD PrintNameAddr( IDiaSymbol* pSym )  
{  
    DWORD rva;  
    if ( pSym->get_relativeVirtualAddress( &rva ) != S_OK )  
        rva = 0;    // no rva, must be an absolute value  
    DWORD tag;  
    pSym->get_symTag( &tag );  
    CDiaBSTR name;  
    if ( pSym->get_name( &name ) != S_OK )  
        printf( "\t0x%08X (%ws) <no name>\n", rva, szTags[ tag ] );  
    else {  
        printf( "\t0x%08X (%ws) %ws\n", rva, szTags[ tag ], name );  
    }  
    return rva;  
}  
  
void          
DumpLex( IDiaSymbol* pscope, int tabs )  
{  
    HRESULT hr;  
  
    CComPtr<IDiaEnumSymbols> pSymbols;      
    if ( SUCCEEDED( pscope->findChildren( SymTagNull, NULL, nsNone, &pSymbols ) ) ) {  
        CComPtr<IDiaSymbol> pSymbol;  
        ULONG celt = 0;  
        while ( pSymbols != NULL && SUCCEEDED( hr = pSymbols->Next( 1, &pSymbol, &celt ) ) && celt == 1 ) {  
            for ( int i = 0; i < tabs; ++i )  
                printf( "\t" );  
            CDiaBSTR name;  
            if ( pSymbol->get_name( &name ) == S_OK && name != NULL ) {  
                printf( "%ws", name );  
            }  
            DWORD symTag;  
            pSymbol->get_symTag( &symTag );  
            printf( " : %ws\n", szTags[ symTag ] );  
            switch ( symTag ) {  
            case SymTagExe:  
                assert( false );  
                break;  
            case SymTagCompiland:  
            case SymTagFunction:  
            case SymTagBlock:  
                DumpLex( pSymbol, tabs+1 );  
                break;  
            default:  
                break;  
            }  
            pSymbol = NULL;  
        }  
    }  
}  
  
void          
Dump(  
    char *szFilename,  
    IDiaDataSource* pSource,  
    wchar_t* szLookup  
)  
{  
    HRESULT hr;  
    wchar_t wszFilename[ _MAX_PATH ];  
    mbstowcs( wszFilename, szFilename, sizeof( wszFilename )/sizeof( wszFilename[0] ) );  
    if ( FAILED( pSource->loadDataFromPdb( wszFilename ) ) )   
        if ( FAILED( pSource->loadDataForExe( wszFilename, NULL, NULL ) ) )   
            Fatal( "loadDataFromPdb/Exe" );  
  
    if ( FAILED( pSource->openSession( &psession ) ) )   
        Fatal( "openSession" );  
    if ( FAILED( psession->get_globalScope( &pglobal) ) )  
        Fatal( "get_globalScope" );  
    DWORD id = 0;  
    pglobal->get_symIndexId( &id );  
    if ( id == 0 )  
        Fatal( "get_indexId" );  
  
    ULONG celt = 0;  
  
    CComPtr<IDiaEnumSymbols> pEnum;  
    CComPtr<IDiaSymbol> pSymbol;  
  
    pglobal->findChildren(SymTagUDT,NULL,nsfCaseInsensitive|nsfUndecoratedName,&pEnum);  
    while ( SUCCEEDED( hr = pEnum->Next( 1, &pSymbol, &celt ) ) && celt == 1 ) {  
        CDiaBSTR name;  
        if ( pSymbol->get_name( &name ) != S_OK )  
            Fatal( "get_name" );  
        printf( "Found UDT: %ws\n", name );  
        ULONGLONG len = 0;  
        pSymbol->get_length( &len );  
        if ( len == 0 ) {  
            Error( "could not get length" );  
        }  
        pSymbol = 0;  
    }  
  
    CComPtr<IDiaEnumTables> pTables;  
    if ( FAILED( psession->getEnumTables( &pTables ) ) )  
        Fatal( "getEnumTables" );  
    CComPtr< IDiaTable > pTable;  
    while ( SUCCEEDED( hr = pTables->Next( 1, &pTable, &celt ) ) && celt == 1 ) {  
        CDiaBSTR bstrTableName;  
        if ( pTable->get_name( &bstrTableName ) != 0 )  
            Fatal( "get_name" );  
        printf( "Found table: %ws\n", bstrTableName );  
        CComPtr<IDiaEnumSymbols> pSymbols;  
        CComPtr<IDiaEnumSourceFiles> pSourceFiles;  
        CComPtr<IDiaEnumSegments> pSegments;  
        CComPtr<IDiaEnumSectionContribs> pSecContribs;  
        if ( SUCCEEDED( pTable->QueryInterface( _uuidof( IDiaEnumSymbols ), (void**)&pSymbols ) ) ) {  
            CComPtr<IDiaSymbol> pSymbol;  
            while ( SUCCEEDED( hr = pSymbols->Next( 1, &pSymbol, &celt ) ) && celt == 1 ) {  
                DWORD symIndex;  
                pSymbol->get_symIndexId( &symIndex );  
                DWORD symTag;  
                pSymbol->get_symTag( &symTag );  
                CDiaBSTR name;  
                if ( pSymbol->get_name( &name ) == S_OK && name != NULL ) {  
                    printf( "sym name: %ws", name );  
                    if ( symTag == SymTagPublicSymbol ) {  
                        CDiaBSTR undName;  
                        pSymbol->get_undecoratedName( &undName );  
                        printf( " (%ws)", undName );  
                    }  
                    CComPtr<IDiaSymbol> pType;  
                    if ( pSymbol->get_type( &pType ) == S_OK ) {  
                        printf( " has type " );  
                        printType( pType );  
  
                        DWORD id = 0;  
                        CComPtr< IDiaSymbol > ptypeSym;  
                        pSymbol->get_typeId( &id );  
                        if ( FAILED( psession->symbolById( id, &ptypeSym ) ) ||  
                            psession->symsAreEquiv( pType, ptypeSym ) != S_OK ) {  
                                Fatal( "Sym type equality" );  
                        }  
                    }  
                    printf( "\n" );  
                    if ( symTag == SymTagFunction ) {  
                        dumpFunctionLines( pSymbol, psession );  
                        DWORD loctype;  
                        if ( pSymbol->get_locationType( &loctype ) == S_OK && loctype == LocIsStatic ) {  
                            DWORD rva;  
                            pSymbol->get_relativeVirtualAddress( &rva );  
                            if ( rva != 0 ) {  
                                dumpLocalVars( rva );  
  
                                CComPtr< IDiaSymbol > pfuncSym;  
                                if ( SUCCEEDED( psession->findSymbolByRVA( rva, SymTagNull, &pfuncSym ) ) ) {  
                                    if ( psession->symsAreEquiv( pfuncSym, pSymbol ) != S_OK ) {  
                                        CDiaBSTR name;  
                                        DWORD tag;  
                                        pfuncSym->get_symTag( &tag );  
                                        pfuncSym->get_name( &name );  
                                        printf( "\tfound alt symbol: %ws (%ws)\n", name != NULL ? name : L"", szTags[ tag ] );  
                                    }  
                                } else {  
                                    Fatal( "No function symbol found by rva." );  
                                }  
                            }  
                        }  
                    }   
                }   
                if ( isScopeSym( symTag ) && szLookup ) {  
                    FindCppNameInScope( szLookup, pSymbol );  
                }  
                pSymbol = NULL;  
            }  
        } else if ( SUCCEEDED( pTable->QueryInterface( _uuidof( IDiaEnumSourceFiles ), (void**)&pSourceFiles ) ) ) {  
            CComPtr<IDiaSourceFile> pSourceFile;  
            while ( SUCCEEDED( hr = pSourceFiles->Next( 1, &pSourceFile, &celt ) ) && celt == 1 ) {  
                CDiaBSTR fileName;  
                if ( pSourceFile->get_fileName( &fileName) == S_OK ) {  
                    printf( "file name: %ws\n", fileName );  
                }  
                pSourceFile = NULL;  
            }  
        } else if ( SUCCEEDED( pTable->QueryInterface( _uuidof( IDiaEnumSegments ), (void**)&pSegments ) ) ) {  
            CComPtr<IDiaSegment> pSegment;  
            while ( SUCCEEDED( hr = pSegments->Next( 1, &pSegment, &celt ) ) && celt == 1 ) {  
                DWORD rva;  
                DWORD seg;  
                pSegment->get_addressSection( &seg );  
                if ( pSegment->get_relativeVirtualAddress( &rva ) == S_OK ) {  
                    printf( "Segment %i addr: 0x%.8X\n", seg, rva );  
                    pSegment = NULL;  
                    CComPtr<IDiaSymbol> pSym;  
                    if ( psession->findSymbolByRVA( rva, SymTagNull, &pSym ) == S_OK ) {  
                        CDiaBSTR name;  
                        DWORD tag;  
                        pSym->get_symTag( &tag );  
                        pSym->get_name( &name );  
                        printf( "\tClosest symbol: %ws (%ws)\n", name != NULL ? name : L"", szTags[ tag ] );  
                    }  
                } else {  
                    printf( "Segment %i \n", seg );  
                    pSegment = NULL;  
                    CComPtr<IDiaSymbol> pSym;  
                    if ( SUCCEEDED( psession->findSymbolByAddr( seg, 0, SymTagNull, &pSym ) ) ) {  
                        CDiaBSTR name;  
                        DWORD tag;  
                        pSym->get_symTag( &tag );  
                        pSym->get_name( &name );  
                        printf( "\tClosest symbol: %ws (%ws)\n", name != NULL ? name : L"", szTags[ tag ] );  
                    }  
                }  
            }  
        } else if ( SUCCEEDED( pTable->QueryInterface( _uuidof( IDiaEnumSectionContribs ), (void**)&pSecContribs ) ) ) {  
            printf( "SecContribs\n" );  
            CComPtr<IDiaSectionContrib> pSecContrib;  
            while ( SUCCEEDED( hr = pSecContribs->Next( 1, &pSecContrib, &celt ) ) && celt == 1 ) {  
                DWORD rva;  
                if ( pSecContrib->get_relativeVirtualAddress( &rva ) == S_OK ) {  
                    printf( "\taddr: 0x%.8X", rva );  
                    pSecContrib = NULL;  
                    CComPtr<IDiaSymbol> pSym;  
                    if ( psession->findSymbolByRVA( rva, SymTagNull, &pSym ) == S_OK ) {  
                        CDiaBSTR name;  
                        DWORD tag;  
                        pSym->get_symTag( &tag );  
                        pSym->get_name( &name );  
                        printf( "     symbol: %ws (%ws)\n", name != NULL ? name : L"", szTags[ tag ] );  
                    } else {  
                        printf( "<no symbol found?>\n" );  
                    }  
                } else {  
                    DWORD isect;  
                    DWORD offset;  
                    pSecContrib->get_addressSection( &isect );  
                    pSecContrib->get_addressOffset( &offset );  
                    printf( "\taddr: 0x%.4X:0x%.8X", isect, offset );  
                    pSecContrib = NULL;  
                    CComPtr<IDiaSymbol> pSym;  
                    if ( SUCCEEDED( psession->findSymbolByAddr( isect, offset, SymTagNull, &pSym ) ) ) {  
                        CDiaBSTR name;  
                        DWORD tag;  
                        pSym->get_symTag( &tag );  
                        pSym->get_name( &name );  
                        printf( "     symbol: %ws (%ws)\n", name != NULL ? name : L"", szTags[ tag ] );  
                    } else {  
                        printf( "<no symbol found?>\n" );  
                    }              
                }  
            }  
        }  
  
        pTable = NULL;  
    }  
    CComPtr<IDiaEnumSymbolsByAddr> pEnumByAddr;  
    if ( FAILED( psession->getSymbolsByAddr( &pEnumByAddr ) ) )  
        Fatal( "getSymbolsByAddr" );  
    CComPtr<IDiaSymbol> pSym;  
    if ( FAILED( pEnumByAddr->symbolByAddr( 1, 0, &pSym ) ) )  
        Fatal( "symbolByAddr" );  
    DWORD rvaLast = 0;  
    if ( pSym->get_relativeVirtualAddress( &rvaLast ) == S_OK ) {  
        pSym = 0;  
        if ( FAILED( pEnumByAddr->symbolByRVA( rvaLast, &pSym ) ) )  
            Fatal( "symbolByAddr" );  
        printf( "Symbols in order\n" );  
        do {   
            rvaLast = PrintNameAddr( pSym );  
            pSym = 0;  
            celt = 0;  
            if ( FAILED( hr = pEnumByAddr->Next( 1, &pSym, &celt ) ) )   
                break;  
        } while ( celt == 1 );  
  
        printf( "Symbols in reverse order\n" );  
        pSym = 0;  
        if ( FAILED( pEnumByAddr->symbolByRVA( rvaLast, &pSym ) ) )  
            Fatal( "symbolByRva" );  
        printf( "Symbols in order\n" );  
        do {   
            rvaLast = PrintNameAddr( pSym );  
            pSym = 0;  
            celt = 0;  
            if ( FAILED( hr = pEnumByAddr->Prev( 1, &pSym, &celt ) ) )   
                break;  
        } while ( celt == 1 );  
  
        if ( FAILED( hr ) )  
            Fatal( "Next" );  
    }  
  
}  
  
void usage( int argc, char* argv[] )  
{  
    printf( "usage: %s <pdb-filename>\n", argv[0] );  
    exit( -1 );  
}  
  
const char* diaPaths[] = {  
        "msdia71.dll",  
        "..\\bin\\msdia71.dll",  
        "..\\..\\bin\\msdia71.dll",  
        0  
};  
  
int main(int argc, char* argv[])  
{  
  
    if ( argc < 2 ) {  
        usage(argc, argv);  
    }  
  
    HRESULT hr;  
    hr = CoInitialize(NULL);  
    if (FAILED(hr))  
    {  
        Fatal("CoInitialize failed\n");  
    }  
  
    CComPtr<IDiaDataSource> pSource;  
    // Initialize The Component Object Module Library  
    // Obtain Access To The Provider  
    hr = CoCreateInstance( CLSID_DiaSource, NULL, CLSCTX_INPROC_SERVER,   
        __uuidof( IDiaDataSource ), (void **) &pSource);  
  
    if (FAILED(hr))  
    {     
        Fatal("Could not CoCreate CLSID_DiaSource. Register msdia71.dll." );  
    }  
    if ( argc > 2 ) {  
        wchar_t name[ 256 ];  
        mbstowcs( name, argv[ 2 ], 256 );  
        Dump( argv[ 1 ], pSource, name );  
        DumpLex( pglobal, 0 );  
    } else {  
        Dump( argv[ 1 ], pSource, NULL );  
    }  
  
    pglobal  = 0;  
    psession = 0;  
    pSource  = 0;  
  
    CoUninitialize();  
    return 0;  
}  
  
```
