---
description: "Contains status information about symbol search paths that have been searched."
title: MODULE_SYMBOL_SEARCH_INFO
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- MODULE_SYMBOL_SEARCH_INFO
helpviewer_keywords:
- MODULE_SYMBOL_SEARCH_INFO structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# MODULE_SYMBOL_SEARCH_INFO

Contains status information about symbol search paths that have been searched.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct MODULE_SYMBOL_SEARCH_INFO {
    public uint   dwValidFields;
    public string bstrVerboseSearchInfo;
}
```
### [C++](#tab/cpp)
```cpp
typedef struct _tagSYMBOL_SEARCH_INFO
{
    SYMBOL_SEARCH_INFO_FIELDS dwValidFields;
    BSTR                      bstrVerboseSearchInfo;
} MODULE_SYMBOL_SEARCH_INFO;
```
---

## Members

`dwValidFields`\
A combination of flags from the [SYMBOL_SEARCH_INFO_FIELDS](../../../extensibility/debugger/reference/symbol-search-info-fields.md) enumeration specifying the kind of search information described in this structure.

`bstrVerboseSearchInfo`\
Search path and results concatenated into a single string.

## Remarks

This structure is returned from a call to the [GetSymbolInfo](../../../extensibility/debugger/reference/idebugmodule3-getsymbolinfo.md) method.

If the `bstrVerboseSearchInfo` field is not empty, then it contains a list of paths searched and the results of that search. The list is formatted with a path, followed by an ellipsis ("..."), followed by the result. If there is more than one path result pair, then each pair is separated by a "\r\n" (carriage-return/linefeed) pair. The pattern looks like this:

\<path>...\<result>\r\n\<path>...\<result>\r\n\<path>...\<result>

Note that the last entry does not have a \r\n sequence.

Here is a possible `bstrVerboseSearchInfo` string that has been sent to standard out.

`c:\symbols\user32.pdb... File not found.`

`c:\winnt\symbols\user32.pdb... Version does not match.`

`\\symbols\symbols\user32.dll\0a8sd0ad8ad\user32.pdb... Symbols loaded.`

## Requirements

Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also

- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [GetSymbolInfo](../../../extensibility/debugger/reference/idebugmodule3-getsymbolinfo.md)
