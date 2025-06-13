---
description: "Retrieves the string associated with this property and stores it in a user-supplied buffer."
title: IDebugProperty3::GetStringChars
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty3::GetStringChars
helpviewer_keywords:
- IDebugProperty3::GetStringChars
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProperty3::GetStringChars

Retrieves the string associated with this property and stores it in a user-supplied buffer.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetStringChars(
    uint       buflen,
    out string rgString,
    out uint   pceltFetched
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetStringChars(
    ULONG  buflen,
    WCHAR* rgString,
    ULONG* pceltFetched
);
```
---

## Parameters
`buflen`\
[in] Maximum number of characters the user-supplied buffer can hold.

`rgString`\
[out] Returns the string.

 [C++ only], `rgString` is a pointer to a buffer that receives the Unicode characters of the string. This buffer must be at least `buflen` characters (not bytes) in size.

`pceltFetched`\
[out] Where the number of characters actually stored in the buffer is returned. (Can be `NULL` in C++.)

## Return Value
If successful, returns `S_OK`; otherwise returns an error code.

## Remarks
In C++, care must be taken to insure that the buffer is at least `buflen` Unicode characters long. Note that a Unicode character is 2 bytes long.

> [!NOTE]
> In C++, the returned string does not include a terminating null character. If given, `pceltFetched` will specify the number of characters in the string.

## Example

```cpp
CStringW RetrievePropertyString(IDebugProperty2 *pPropInfo)
{
    CStringW returnString = L"";
    CComQIPtr<IDebugProperty3> pProp3 = pPropInfo->pProperty;
    If (pProp3 != NULL) {
        ULONG dwStrLen = 0;
        HRESULT hr;
        hr = pProp3->GetStringCharLength(&dwStrLen);
        if (SUCCEEDED(hr) && dwStrLen > 0) {
            ULONG dwRead;
            CStrBufW buf(returnString,dwStrLen,CStrBuf::SET_LENGTH);
            hr = pProp3->GetStringChars(dwStrLen,
                                        reinterpret_cast<WCHAR*>(static_cast<CStringW::PXSTR>(buf)),
                                        &dwRead);
        }
    }
    return(returnString);
}
```

## See also
- [GetStringCharLength](../../../extensibility/debugger/reference/idebugproperty3-getstringcharlength.md)
- [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
