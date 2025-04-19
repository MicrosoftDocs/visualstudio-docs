---
description: Determines the line numbers of the compiland that the specified line number in a source file lies within or near.
title: "IDiaSession::findLinesByLinenum"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findLinesByLinenum method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSession::findLinesByLinenum

Determines the line numbers of the compiland that the specified line number in a source file lies within or near.

## Syntax

```C++
HRESULT findLinesByLinenum ( 
    IDiaSymbol*           compiland,
    IDiaSourceFile*       file,
    DWORD                 linenum,
    DWORD                 column,
    IDiaEnumLineNumbers** ppResult
);
```

#### Parameters
`compiland`

[in] An [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that represents the compiland in which to search for the line numbers. This parameter cannot be `NULL`.

`file`

[in] An [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md) object that represents the source file to search in. This parameter cannot be `NULL`.

`linenum`

[in] Specifies a one-based line number.

> [!NOTE]
> You cannot use zero to specify all lines (use the [IDiaSession::findLines](../../debugger/debug-interface-access/idiasession-findlines.md) method to find all lines).

`column`

[in] Specifies the column number. Use zero to specify all columns. A column is a byte offset into a line.

`ppResult`

[out] Returns an [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md) objta that contains a list of the line numbers retrieved.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following example shows how to open a source file, enumerate the compilands contributed by this file, and locate the line numbers in the source file where each compiland starts.

```C++
void ShowLinesInCompilands(IDiaSession *pSession, LPCOLESTR filename)
{
    IDiaEnumSourceFiles* pEnum;
    IDiaSourceFile*      pFile;
    DWORD                celt;

    pSession->findFile ( NULL, filename, nsFNameExt, &pEnum );
    while ( pEnum->Next ( 1, &pFile, &celt ) == S_OK ) // for each file
    {
        IDiaEnumSymbols* pEnumCompilands;
        IDiaSymbol* pCompiland;

        pFile->get_compilands ( &pEnumCompilands );
        // for each compiland
        while ( pEnumCompilands->Next ( 1, &pCompiland, &celt ) == S_OK )
        {
            IDiaEnumLineNumbers* pEnum;
            // Find first compiland closest to line 1 of the file.
            if (pSession->findLinesByLinenum( pCompiland, pFile, 1, 0, &pEnum ) == S_OK)
            {
                IDiaLineNumber *pLineNumber;
                DWORD lineCount;
                while ( pEnum->Next(1,&pLineNumber,&lineCount) == S_OK)
                {
                    DWORD lineNum;
                    if (pLineNumber->get_line(&lineNum) == S_OK)
                    {
                        printf("compiland starts in source at line number = %lu\n",lineNum);
                    }
                }
            }
        }
    }
}
```

## See also
- [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSession::findLinesByAddr](../../debugger/debug-interface-access/idiasession-findlinesbyaddr.md)
- [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
