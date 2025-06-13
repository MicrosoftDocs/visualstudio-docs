---
description: "Obtains the custom attributes bytes given the name of the custom attribute."
title: IDebugCustomAttributeQuery2::GetCustomAttributeByName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCustomAttributeQuery2::GetCustomAttributeByName
helpviewer_keywords:
- IDebugCustomAttributeQuery2::GetCustomAttributeByName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCustomAttributeQuery2::GetCustomAttributeByName

Obtains the custom attributes bytes given the name of the custom attribute.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetCustomAttributeByName(
   [In] string        pszCustomAttributeName,
   [In, Out] byte[]   ppBlob,
   [In, Out] ref uint pdwLen
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetCustomAttributeByName( 
   LPCOLESTR pszCustomAttributeName,
   BYTE*     ppBlob,
   DWORD*    pdwLen
);
```
---

## Parameters
`pszCustomAttributeName`\
[in] A string containing the name of the custom attribute to look for.

`ppBlob`\
[in, out] An array that is filled in with the custom attribute bytes.

`pdwLen`\
[in, out] Specifies the maximum number of bytes to return in the `ppBlob` array and returns the number of bytes actually written to the array.

## Return Value
 If successful, returns S_OK or returns S_FALSE if the custom attribute does not exist. Otherwise, returns an error code.

## Remarks
 Set the `ppBlob` parameter to a null value to return the number of attributes bytes available. Then allocate an array and pass that array in for the `ppBlob` parameter.

 The attribute bytes represent the raw data of the custom attribute.

 If the `ppBlob` and `pdwLen` parameters are set to a null value, this method can be used to determine if the custom attribute merely exists. An easier alternative, however, is to call the [IsCustomAttributeDefined](../../../extensibility/debugger/reference/idebugcustomattributequery2-iscustomattributedefined.md) method.

## See also
- [IDebugCustomAttributeQuery2](../../../extensibility/debugger/reference/idebugcustomattributequery2.md)
- [IsCustomAttributeDefined](../../../extensibility/debugger/reference/idebugcustomattributequery2-iscustomattributedefined.md)
