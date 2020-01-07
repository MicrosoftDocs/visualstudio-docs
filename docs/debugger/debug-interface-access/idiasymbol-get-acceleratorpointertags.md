---
title: "IDiaSymbol::get_acceleratorPointerTags | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
ms.assetid: 30e13cee-e511-49ec-affd-99b0097071b2
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_acceleratorPointerTags
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