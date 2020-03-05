---
title: "IDiaLineNumber::get_length | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_length method"
ms.assetid: 2c55a6f7-4ef5-45fb-9fd1-d72deaaa2829
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaLineNumber::get_length
Retrieves the number of bytes in a block.

## Syntax

```C++
HRESULT get_length ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the number of bytes in a block.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## Remarks
 The block is the length of source code on the line as represented by the [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md) object.

## See also
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)