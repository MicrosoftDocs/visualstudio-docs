---
description: "Sets the service provider."
title: IDebugPortPicker::SetSite | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugPortPicker::SetSite
ms.assetid: 7319e187-adfe-4b3f-aec9-521356fb5a8a
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
# IDebugPortPicker::SetSite

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Sets the service provider.

## Syntax

### [C#](#tab/csharp)
```csharp
public int SetSite(
   IServiceProvider pSP
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetSite(
   IServiceProvider * pSP
);
```
---

## Parameters
`pSP`\
[in] Reference to the interface of the service provider.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method will be called before any other methods are called.

## See also
- [IDebugPortPicker](../../../extensibility/debugger/reference/idebugportpicker.md)
