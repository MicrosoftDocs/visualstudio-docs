---
description: "This method evaluates the parsed expression and optionally casts the result to another data type."
title: IDebugParsedExpression::EvaluateSync
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugParsedExpression::EvaluateSync
helpviewer_keywords:
- IDebugParsedExpression::EvaluateSync method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugParsedExpression::EvaluateSync

This method evaluates the parsed expression and optionally casts the result to another data type.

## Syntax

### [C#](#tab/csharp)
```csharp
int EvaluateSync(
   uint                 dwEvalFlags,
   uint                 dwTimeout,
   IDebugSymbolProvider pSymbolProvider,
   IDebugAddress        pAddress,
   IDebugBinder         pBinder,
   string               bstrResultType,
   out IDebugProperty2  ppResult
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EvaluateSync( 
   DWORD                 dwEvalFlags,
   DWORD                 dwTimeout,
   IDebugSymbolProvider* pSymbolProvider,
   IDebugAddress*        pAddress,
   IDebugBinder*         pBinder,
   BSTR                  bstrResultType,
   IDebugProperty2**     ppResult
);
```
---

## Parameters
`dwEvalFlags`\
[in] A combination of [EVALFLAGS](../../../extensibility/debugger/reference/evalflags.md) constants that control how the expression is to be evaluated.

`dwTimeout`\
[in] Specifies the maximum time, in milliseconds, to wait before returning from this method. Use `INFINITE` to wait indefinitely.

`pSymbolProvider`\
[in] The symbol provider, expressed as an [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md) interface.

`pAddress`\
[in] The current execution location within a method, expressed as an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface.

`pBinder`\
[in] The binder, expressed as an [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md) interface.

`bstrResultType`\
[in] The type the result should be cast to. This argument can be a null value.

`ppResult`\
[out] Returns the [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) interface that represents the results of evaluation.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The expression evaluation context is given by `pAddress`, which makes it possible to determine the containing method and then use language scoping rules to determine the value of the symbols in the expression.

## See also
- [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)
- [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)
- [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [IDebugParsedExpression](../../../extensibility/debugger/reference/idebugparsedexpression.md)
