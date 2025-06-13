---
description: "Sets the value of this property to the value of the given reference."
title: IDebugProperty2::SetValueAsReference
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty2::SetValueAsReference
helpviewer_keywords:
- IDebugProperty2::SetValueAsReference method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProperty2::SetValueAsReference

Sets the value of this property to the value of the given reference.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetValueAsReference(
   IDebugReference2[] rgpArgs,
   uint               dwArgCount,
   IDebugReference2   pValue,
   uint               dwTimeout
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetValueAsReference(
   IDebugReference2** rgpArgs,
   DWORD              dwArgCount,
   IDebugReference2*  pValue,
   DWORD              dwTimeout
);
```
---

## Parameters
`rgpArgs`\
[in] An array of arguments to pass to the managed code property setter. If the property setter does not take arguments or if this [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object does not refer to such a property setter, `rgpArgs` should be a null value. This parameter is typically a null value.

`dwArgCount`\
[in] The number of arguments in the `rgpArgs` array.

`pValue`\
[in] A reference, in the form of an [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) object, to the value to use to set this property.

`dwTimeout`\
[in] How long to take to set the value, in milliseconds. A typical value is `INFINITE`. This affects the length of time that any possible evaluation can take.

## Return Value
 If successful, returns `S_OK`; otherwise returns an error code, typically one of the following:

|Error|Description|
|-----------|-----------------|
|`E_SETVALUEASREFERENCE_NOTSUPPORTED`|Setting the value from a reference is not supported.|
|`E_SETVALUE_VALUE_CANNOT_BE_SET`|The value cannot be set, as this property refers to a method.|
|`E_SETVALUE_VALUE_IS_READONLY`|The value is read-only and cannot be set.|
|`E_NOTIMPL`|The method is not implemented.|

## See also
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)
