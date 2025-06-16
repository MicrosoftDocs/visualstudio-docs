---
description: "Gets the user name from the port supplier."
title: IDebugProcessSecurity::GetUserName
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugProcessSecurity::GetUserName
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcessSecurity::GetUserName

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
 `GetUserName` returns the user name that is displayed in the **User Name** column of the **Attach to Process** dialog box. To view the **Attach to Process** dialog box, click **Attach to Process** on the **Tools** menu in the Visual Studio integrated development environment (IDE).

## See also
- [IDebugProcessSecurity](../../../extensibility/debugger/reference/idebugprocesssecurity.md)
