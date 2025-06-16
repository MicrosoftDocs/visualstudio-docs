---
description: "Converts either an object location or a 64-bit memory address to a memory context."
title: IDebugBinder3::GetMemoryContext64
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- GetMemoryContext64
- IDebugBinder3::GetMemoryContext64
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBinder3::GetMemoryContext64

Converts either an object location or a 64-bit memory address to a memory context.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetMemoryContext64 (
    IDebugField              pField,
    ulong                    uConstant,
    out IDebugMemoryContext2 ppMemCxt
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetMemoryContext64 (
    IDebugField*           pField,
    UINT64                 uConstant,
    IDebugMemoryContext2** ppMemCxt
);
```
---

## Parameters
`pField`\
[in] An [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) that describes the object to locate. If `NULL`, then use `dwConstant` instead.

`uConstant`\
[in] A 64-bit memory address, such as 0x50000000.

`ppMemCxt`\
[out] Returns the [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) interface that represents the address of the object, or the address in memory.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Example
The following examples creates an object that implements the [IDebugBinder3](../../../extensibility/debugger/reference/idebugbinder3.md) interface and uses this method to retrieve the memory context.

```cpp
HRESULT CValueProperty::GetMemoryContext ( IDebugMemoryContext2** out_ppMemoryContext )
{
    // precondition
    REQUIRE( NULL != out_ppMemoryContext );

    if (NULL == out_ppMemoryContext)
        return E_POINTER;

    *out_ppMemoryContext = NULL;

    INVARIANT( this );

    if (!this->ClassInvariant())
        return E_UNEXPECTED;

    if (VT_EMPTY == this->m_VarValue.vt)
    {
        return E_FAIL;
    }

    // function body
    if (NULL != this->m_pBinder)
    {
        UINT64 dwOffset = 0;

        DEBUG_PROPERTY_INFO dpInfo;
        HRESULT HR = this->GetPropertyInfo(DEBUGPROP_INFO_VALUE,
                                           10, // RADIX
                                           DEFAULT_TIMEOUT,
                                           NULL,
                                           0,
                                           &dpInfo);
        if (ENSURE( S_OK == HR ))
        {
            REQUIRE( NULL != dpInfo.bstrValue );
            REQUIRE( NULL == dpInfo.bstrName );
            REQUIRE( NULL == dpInfo.bstrFullName );
            REQUIRE( NULL == dpInfo.bstrType );
            REQUIRE( NULL == dpInfo.pProperty );

            wchar_t * end;
            dwOffset = _wcstoui64(dpInfo.bstrValue, &end, 0); // base 0 to allow 0x if it's ever output
            ::SysFreeString(dpInfo.bstrValue);
        }

        if (CComQIPtr<IDebugBinder3> binder3 = this->m_pBinder)
            HR = binder3->GetMemoryContext64(NULL, dwOffset, out_ppMemoryContext);
        else
            HR = this->m_pBinder->GetMemoryContext(NULL, (DWORD)(__int32)dwOffset, out_ppMemoryContext);

        if (ENSURE( S_OK == HR ))
        {
            REQUIRE( NULL != *out_ppMemoryContext );
        }
    }

    // postcondition
    INVARIANT( this );

    HRESULT HR = E_FAIL;

    if (NULL != *out_ppMemoryContext)
    {
        HR = S_OK;
    }

    return HR;
}
```

## See also
- [IDebugBinder3](../../../extensibility/debugger/reference/idebugbinder3.md)
