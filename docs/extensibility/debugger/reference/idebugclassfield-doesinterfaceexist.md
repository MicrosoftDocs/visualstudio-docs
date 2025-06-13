---
description: "Determines if a specific interface is defined in the class."
title: IDebugClassField::DoesInterfaceExist
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugClassField::DoesInterfaceExist
helpviewer_keywords:
- IDebugClassField::DoesInterfaceExist method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugClassField::DoesInterfaceExist

Determines if a specific interface is defined in the class.

## Syntax

### [C#](#tab/csharp)
```csharp
int DoesInterfaceExist(
   [In] string pszInterfaceName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT DoesInterfaceExist( 
   LPCOLESTR pszInterfaceName
);
```
---

## Parameters
`pszInterfaceName`\
[in] A string containing the interface name to look for.

## Return Value
 If successful, returns S_OK, returns S_FALSE if the interface does not exist; otherwise, returns an error code.

## Remarks
 This method in effect gets an enumeration of all interfaces and searches the list for a matching interface.

## See also
- [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)
