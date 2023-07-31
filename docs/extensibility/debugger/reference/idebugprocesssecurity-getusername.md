---
description: "Gets the user name from the port supplier."
title: IDebugProcessSecurity::GetUserName | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugProcessSecurity::GetUserName
ms.assetid: c73c60ac-da6e-45ae-8f04-95353a24ca3e
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
# IDebugProcessSecurity::GetUserName

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Gets the user name from the port supplier.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetUserName (
    string pbstrUserName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetUserName(
    BSTR *pbstrUserName
);
```
---

## Parameters
`pbstrUserName`\
[out] A string containing the user name.

## Return Value
 If the method succeeds, it returns `S_OK`. Otherwise it returns an error code.

## Remarks
 `GetUserName` returns the user name that is displayed in the **User Name** column of the **Attach to Process** dialog box. To view the **Attach to Process** dialog box, click **Attach to Process** on the **Tools** menu in the [!INCLUDE[vsprvs](../../../code-quality/includes/vsprvs_md.md)] integrated development environment (IDE).

## See also
- [IDebugProcessSecurity](../../../extensibility/debugger/reference/idebugprocesssecurity.md)
