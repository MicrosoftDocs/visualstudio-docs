---
description: "Retrieves a list of paths that are searched for symbols as well as the results of searching each path."
title: IDebugModule3::GetSymbolInfo
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugModule3::GetSymbolInfo
helpviewer_keywords:
- GetSymbolInfo method
- IDebugModule3::GetSymbolInfo method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugModule3::GetSymbolInfo

Retrieves a list of paths that are searched for symbols as well as the results of searching each path.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetSymbolInfo(
    enum_SYMBOL_SEARCH_INFO_FIELDS dwFields,
    MODULE_SYMBOL_SEARCH_INFO[]    pinfo
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetSymbolInfo(
    SYMBOL_SEARCH_INFO_FIELDS  dwFields,
    MODULE_SYMBOL_SEARCH_INFO* pInfo
);
```
---

## Parameters
`dwFields`\
[in] A combination of flags from the [SYMBOL_SEARCH_INFO_FIELDS](../../../extensibility/debugger/reference/symbol-search-info-fields.md) enumeration specifying which fields of `pInfo` are to be filled in.

`pInfo`\
[out] A [MODULE_SYMBOL_SEARCH_INFO](../../../extensibility/debugger/reference/module-symbol-search-info.md) structure whose members are to be filled in with the specified information. If this is a null value, this method returns `E_INVALIDARG`.

## Return Value
If the method succeeds, it returns `S_OK`; otherwise, it returns an error code.

> [!NOTE]
> The returned string (in the `MODULE_SYMBOL_SEARCH_INFO` structure) could be empty even if `S_OK` is returned. In this case, there was no search information to return.

## Remarks
If the `bstrVerboseSearchInfo` field of the `MODULE_SYMBOL_SEARCH_INFO` structure is not empty, then it contains a list of paths searched and the results of that search. The list is formatted with a path, followed by an ellipsis ("..."), followed by the result. If there is more than one path result pair, then each pair is separated by a "\r\n" (carriage-return/linefeed) pair. The pattern looks like this:

\<path>...\<result>\r\n\<path>...\<result>\r\n\<path>...\<result>

Note that the last entry does not have a \r\n sequence.

## Example
In this example, this method returns three paths with three different search results. Each line is terminated with a carriage-return/linefeed pair. The example output just prints the search results as a single string.

> [!NOTE]
> A status result is everything immediately following the "..." up to the end of the line.

```cpp
void ShowSymbolSearchResults(IDebugModule3 *pIDebugModule3)
{
    MODULE_SYMBOL_SEARCH_INFO ssi = { 0 };
    HRESULT hr;
    hr = pIDebugModule3->GetSymbolInfo(SSIF_VERBOSE_SEARCH_INFO,&ssi);
    if (SUCCEEDED(hr)) {
        CComBSTR searchInfo = ssi.bstrVerboseSearchInfo;
        if (searchInfo.Length() != 0) {
            std::wcout << (wchar_t *)(BSTR)searchInfo;
            std::wcout << std::endl;
        }
    }
}
```

**c:\symbols\user32.pdb... File not found.**
**c:\winnt\symbols\user32.pdb... Version does not match.**
**\\\symbols\symbols\user32.dll\0a8sd0ad8ad\user32.pdb... Symbols loaded.**

## See also

- [SYMBOL_SEARCH_INFO_FIELDS](../../../extensibility/debugger/reference/symbol-search-info-fields.md)
- [MODULE_SYMBOL_SEARCH_INFO](../../../extensibility/debugger/reference/module-symbol-search-info.md)
- [IDebugModule3](../../../extensibility/debugger/reference/idebugmodule3.md)
