---
description: "Returns all accelerator pointer tag values that correspond to a C++ AMP accelerator stub function."
title: "IDiaSymbol::get_acceleratorPointerTags"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
---
# IDiaSymbol::get_acceleratorPointerTags

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Returns all accelerator pointer tag values that correspond to a C++ AMP accelerator stub function.

## Syntax

```C++
HRESULT get_acceleratorPointerTags(
   DWORD          cnt,
   DWORD*         pcnt,
   DWORD*         pPointerTags);
```

#### Parameters
 `cnt`

[in] The size of the output array `pPointerTags`.

 `pcnt`

[out] The count of accelerator pointer tags in the C++ AMP accelerator stub function.

 `pPointerTags`

[out] A `DWORD` array pointer that is filled with the accelerator pointer tag values in the C++ AMP accelerator stub function.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## Remarks
 This method is called on an `IDiaSymbol` interface that corresponds to a C++ AMP accelerator stub function.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
