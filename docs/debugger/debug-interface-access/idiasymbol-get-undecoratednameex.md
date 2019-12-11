---
title: "IDiaSymbol::get_undecoratedNameEx | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_undecoratedNameEx method"
ms.assetid: 579aed0b-c57d-41a1-a94a-3bf665fd4a9d
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_undecoratedNameEx
Retrieves part or all of an undecorated name for a C++ decorated (linkage) name.

## Syntax

```C++
HRESULT get_undecoratedNameEx( 
   DWORD undecorateOptions,
   BSTR* pRetval
);
```

#### Parameters
 `undecoratedOptions`

[in] Specifies a combination of flags that control what is returned. See the Remarks section for the specific values and what they do.

 `pRetVal`

[out] Returns the undecorated name for a C++ decorated name.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## Remarks
 The `undecorateOptions` can be a combination of the following flags.

> [!NOTE]
> The flag names are not defined in the DIA SDK, so you need to either add the declarations to your code or use the raw values.

|Flag|Value|Description|
|----------|-----------|-----------------|
|UNDNAME_COMPLETE|0x0000|Enables full undecoration.|
|UNDNAME_NO_LEADING_UNDERSCORES|0x0001|Removes leading underscores from Microsoft extended keywords.|
|UNDNAME_NO_MS_KEYWORDS|0x0002|Disables expansion of Microsoft extended keywords.|
|UNDNAME_NO_FUNCTION_RETURNS|0x0004|Disables expansion of return type for primary declaration.|
|UNDNAME_NO_ALLOCATION_MODEL|0x0008|Disables expansion of the declaration model.|
|UNDNAME_NO_ALLOCATION_LANGUAGE|0x0010|Disables expansion of the declaration language specifier.|
|UNDNAME_RESERVED1|0x0020|RESERVED.|
|UNDNAME_RESERVED2|0x0040|RESERVED.|
|UNDNAME_NO_THISTYPE|0x0060|Disables all modifiers on the `this` type.|
|UNDNAME_NO_ACCESS_SPECIFIERS|0x0080|Disables expansion of access specifiers for members.|
|UNDNAME_NO_THROW_SIGNATURES|0x0100|Disables expansion of "throw-signatures" for functions and pointers to functions.|
|UNDNAME_NO_MEMBER_TYPE|0x0200|Disables expansion of `static` or `virtual` members.|
|UNDNAME_NO_RETURN_UDT_MODEL|0x0400|Disables expansion of the Microsoft model for UDT returns.|
|UNDNAME_32_BIT_DECODE|0x0800|Undecorates 32-bit decorated names.|
|UNDNAME_NAME_ONLY|0x1000|Gets only the name for primary declaration; returns just [scope::]name.  Expands template params.|
|UNDNAME_TYPE_ONLY|0x2000|Input is just a type encoding; composes an abstract declarator.|
|UNDNAME_HAVE_PARAMETERS|0x4000|The real template parameters are available.|
|UNDNAME_NO_ECSU|0x8000|Suppresses enum/class/struct/union.|
|UNDNAME_NO_IDENT_CHAR_CHECK|0x10000|Suppresses check for valid identifier characters.|
|UNDNAME_NO_PTR64|0x20000|Does not include ptr64 in output.|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)