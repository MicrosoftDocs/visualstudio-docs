---
title: "IDiaSession::findAcceleratorInlineesByLinenum | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: 386c87aa-f7b2-4d38-9dd6-fffba9ff01f0
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSession::findAcceleratorInlineesByLinenum
Returns an enumeration of symbols for inline frames that correspond to the specified source location.

## Syntax

```C++
HRESULT findAcceleratorInlineeLinesByName ( 
   IDiaSymbol*           parent,
   IDiaSourceFile*       file,
   DWORD                 linenum,
   DWORD                 colnum,
   IDiaEnumLineNumbers** ppResult
);
```

#### Parameters
 `parent`

[in] An `IDiaSymbol` that corresponds to the Accelerator stub function that needs to be searched.

 `file`

[in] The `IDiaSourceFile` of the source location.

 `linenum`

[in] The line number of the source location.

 `colnum`

[in] The column number of the source location.

 `ppResult`

[out] A pointer to an `IDiaEnumLineNumbers` interface pointer that is initialized with the result.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)