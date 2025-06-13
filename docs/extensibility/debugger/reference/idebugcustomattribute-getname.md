---
description: "Gets the name of the custom attribute."
title: IDebugCustomAttribute::GetName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCustomAttribute::GetName
helpviewer_keywords:
- IDebugCustomAttribute::GetName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCustomAttribute::GetName

Gets the name of the custom attribute.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetName(
   out string bstrName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetName( 
   BSTR* bstrName
);
```
---

## Parameters
`bstrName`\
[out] Returns a string containing the name of the custom attribute.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 The named returned by this method corresponds to the name of the class used to declare the attribute. This may not exactly correspond to the name of the custom attribute class itself as C# allows the "Attribute" suffix to be dropped from a custom attribute name when it is used in a declaration.

## See also
- [IDebugCustomAttribute](../../../extensibility/debugger/reference/idebugcustomattribute.md)
