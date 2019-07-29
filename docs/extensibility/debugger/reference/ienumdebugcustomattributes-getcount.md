---
title: "IEnumDebugCustomAttributes::GetCount | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IEnumCustomAttributes::GetCount"
helpviewer_keywords:
  - "IEnumDebugCustomAttributes::GetCount"
ms.assetid: fafe826f-4ebf-4572-b2a3-d5dd2916c12f
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IEnumDebugCustomAttributes::GetCount
Gets the number of custom attributes in an enumerator.

## Syntax

```cpp
HRESULT GetCount( 
   ULONG* pcelt
);
```

```csharp
int GetCount(
   out uint pcelt
);
```

## Parameters
`pcelt`\
[out] Returns the number of elements in the enumeration.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is not part of the customary COM enumeration interface which specifies that only `Next`, `Clone`, `Skip`, and `Reset` need to be implemented.

## See also
- [IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md)