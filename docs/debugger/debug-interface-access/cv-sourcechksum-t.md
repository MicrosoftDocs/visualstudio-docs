---
title: CV_SourceChksum_t
description: Specifies the type of source code checksum.
ms.date: "07/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "CV_SourceChksum_t enumeration"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# `CV_SourceChksum_t`

Specifies the type of source code checksum.

## Syntax

```c++
enum CV_SourceChksum_t
{
    CHKSUM_TYPE_NONE = 0,
    CHKSUM_TYPE_MD5,
    CHKSUM_TYPE_SHA1,
    CHKSUM_TYPE_SHA_256,
};
```

## Elements

|Checksum Type|Value|CryptoAPI Label|Description|
|-------------|-----|---------------|-----------|
| `CHKSUM_TYPE_NONE` | 0 | <none\> | No checksum present. |
| `CHKSUM_TYPE_MD5` | 1 | `CALG_MD5` | Checksum generated with the MD5 hashing algorithm. |
| `CHKSUM_TYPE_SHA1` | 2 | `CALG_SHA1` | Checksum generated with the SHA1 hashing algorithm. |
| `CHKSUM_TYPE_SHA_256` | 3 |`CALG_SHA_256`| Checksum generated with the 256-bit SHA hashing algorithm.|

## Remarks

The `CryptoAPI` labels are from the [`ALG_ID`](/windows/win32/seccrypto/alg-id) enumeration. For more information on hashing algorithms, consult the `CryptoAPI` section of the Microsoft Windows SDK.

## Requirements

Header: cvconst.h

## See also

- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
