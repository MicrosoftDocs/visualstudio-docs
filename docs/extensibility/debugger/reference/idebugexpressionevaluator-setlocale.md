---
description: "This method sets the language to use to create printable results."
title: IDebugExpressionEvaluator::SetLocale
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugExpressionEvaluator::SetLocale
helpviewer_keywords:
- IDebugExpressionEvaluator::SetLocale method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugExpressionEvaluator::SetLocale

This method sets the language to use to create printable results.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetLocale(
   ushort wLangID
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetLocale( 
   WORD wLangID
);
```
---

## Parameters
`wLangID`\
[in] The language identifier.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method may be called many times while the expression evaluator (EE) is loaded, so the EE must be able to switch languages on the fly. The EE uses this locale to return error messages and strings in the appropriate language.

## See also
- [IDebugExpressionEvaluator](../../../extensibility/debugger/reference/idebugexpressionevaluator.md)
