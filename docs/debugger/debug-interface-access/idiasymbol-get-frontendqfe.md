---
description: Retrieves the front end QFE number of the compiler.
title: "IDiaSymbol::get_frontEndQFE"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_frontEndQFE method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSymbol::get_frontEndQFE

Retrieves the front end QFE number of the compiler.

## Syntax

```C++
HRESULT get_frontEndQFE ( 
   DWORD* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the front end QFE number. See Remarks.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks

 A compiler is typically composed of two primary elements: the front end (the parser), which handles parsing the source code into an intermediate form, and a back end (code generator), which converts the intermediate form into assembly. It is not uncommon for the front end to have a different version than the back end.

 A front end or back end version number is composed of three parts: \<major>.\<minor>.\<build>.\<qfe>, where \<major> is the major version number, \<minor> is the minor version number, \<build> is the build number, and \<qfe> if the quick-fix engineering (QFE) number. For example, 19.40.33731.1.

## Requirements

|Requirement|Description|
|-----------------|-----------------|
|Header:|dia2.h|
|Version:|DIA SDK v14.0|

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
