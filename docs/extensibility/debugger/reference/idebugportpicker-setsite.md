---
title: "IDebugPortPicker::SetSite | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "IDebugPortPicker::SetSite"
ms.assetid: 7319e187-adfe-4b3f-aec9-521356fb5a8a
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugPortPicker::SetSite
Sets the service provider.

## Syntax

```cpp
HRESULT SetSite(
   IServiceProvider * pSP
);
```

```csharp
public int SetSite(
   IServiceProvider pSP
);
```

## Parameters
`pSP`\
[in] Reference to the interface of the service provider.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method will be called before any other methods are called.

## See also
- [IDebugPortPicker](../../../extensibility/debugger/reference/idebugportpicker.md)