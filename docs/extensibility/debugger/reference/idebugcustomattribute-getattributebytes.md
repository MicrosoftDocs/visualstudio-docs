---
description: "Gets the attribute information as a blob of bytes."
title: IDebugCustomAttribute::GetAttributeBytes | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCustomAttribute::GetAttributeBytes
helpviewer_keywords:
- IDebugCustomAttribute::GetAttributeBytes
ms.assetid: cf34583b-6530-4dcc-89f8-eb27e4e8d594
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugCustomAttribute::GetAttributeBytes

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Gets the attribute information as a blob of bytes.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetAttributeBytes(
   ref byte[] ppBlob,
   ref uint   pdwLen
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetAttributeBytes( 
   BYTE*  ppBlob,
   DWORD* pdwLen
);
```
---

## Parameters
`ppBlob`\
[in, out] An array that is filled in with the attribute bytes.

`pdwLen`\
[in, out] Specifies the maximum number of bytes to return in the `ppBlob` array and returns the number of bytes actually written to the array.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 Set the `ppBlob` parameter to a null value to return the number of attributes bytes available. Then allocate an array and pass that array in for the `ppBlob` parameter.

 The attribute bytes represent the raw data of the custom attribute.

## See also
- [IDebugCustomAttribute](../../../extensibility/debugger/reference/idebugcustomattribute.md)
