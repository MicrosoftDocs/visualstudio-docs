---
title: "IDiaSymbol::get_machineType | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_machineType method"
ms.assetid: 30870b10-6f32-45c6-a0d7-020dea707710
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_machineType
Retrieves the type of the target CPU.

## Syntax

```C++
HRESULT get_machineType ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns a value from the [IMAGE_FILE_MACHINE_ Constants](/windows/desktop/SysInfo/image-file-machine-constants) that specifies the target CPU type.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IMAGE_FILE_MACHINE_ Constants](/windows/desktop/SysInfo/image-file-machine-constants) 
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)