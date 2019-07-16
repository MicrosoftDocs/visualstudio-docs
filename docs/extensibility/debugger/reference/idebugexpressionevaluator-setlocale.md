---
title: "IDebugExpressionEvaluator::SetLocale | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugExpressionEvaluator::SetLocale"
helpviewer_keywords:
  - "IDebugExpressionEvaluator::SetLocale method"
ms.assetid: d3d2027d-74e2-4ae6-bcc7-59d12f873b7c
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugExpressionEvaluator::SetLocale
This method sets the language to use to create printable results.

## Syntax

```cpp
HRESULT SetLocale( 
   WORD wLangID
);
```

```csharp
int SetLocale(
   ushort wLangID
);
```

## Parameters
`wLangID`\
[in] The language identifier.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method may be called many times while the expression evaluator (EE) is loaded, so the EE must be able to switch languages on the fly. The EE uses this locale to return error messages and strings in the appropriate language.

## See also
- [IDebugExpressionEvaluator](../../../extensibility/debugger/reference/idebugexpressionevaluator.md)