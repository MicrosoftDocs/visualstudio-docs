---
description: "This method converts a method location and offset into a memory address."
title: IDebugExpressionEvaluator::GetMethodLocationProperty
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugExpressionEvaluator::GetMethodLocationProperty
helpviewer_keywords:
- IDebugExpressionEvaluator::GetMethodLocationProperty method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExpressionEvaluator::GetMethodLocationProperty

This method converts a method location and offset into a memory address.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetMethodLocationProperty(
   string               upstrFullyQualifiedMethodPlusOffset,
   IDebugSymbolProvider pSymbolProvider,
   IDebugAddress        pAddress,
   IDebugBinder         pBinder,
   out IDebugProperty2  ppProperty
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetMethodLocationProperty( 
   LPCOLESTR             upstrFullyQualifiedMethodPlusOffset,
   IDebugSymbolProvider* pSymbolProvider,
   IDebugAddress*        pAddress,
   IDebugBinder*         pBinder,
   IDebugProperty2**     ppProperty
);
```
---

## Parameters
`upstrFullyQualifiedMethodPlusOffset`\
[in] The method location and offset, expressed as a string.

`pSymbolProvider`\
[in] The symbol provider expressed as an [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md) object.

`pAddress`\
[in] An address within the method, expressed as an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) object.

`pBinder`\
[in] The binder expressed as an [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md) object.

`ppProperty`\
[out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) interface that represents the memory address.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The returned address can be used to set a breakpoint, for example.

 Despite the name `upstrFullyQualifiedMethodPlusOffset`, this parameter can be passed a partially qualified method name. In that case, the selected method is the one that encloses `pAddress`. How this parameter is interpreted is up to the implementation of the expression evaluator and the language it supports.

## See also
- [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)
- [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [IDebugExpressionEvaluator](../../../extensibility/debugger/reference/idebugexpressionevaluator.md)
