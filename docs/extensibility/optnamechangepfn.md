---
title: OPTNAMECHANGEPFN
description: Learn about the OPTNAMECHANGEPFN callback function, which communicates name changes from the source control plug-in to the Visual Studio IDE.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- OPTNAMECHANGEPFN
helpviewer_keywords:
- OPTNAMECHANGEPFN callback function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# OPTNAMECHANGEPFN

This is a callback function specified in a call to the [SccSetOption](../extensibility/sccsetoption-function.md) (using option `SCC_OPT_NAMECHANGEPFN`) and is used to communicate name changes made by the source control plug-in back to the IDE.

## Signature

```cpp
typedef void (*OPTNAMECHANGEPFN)(
   LPVOID pvCallerData,
   LPCSTR pszOldName,
   LPCSTR pszNewName
);
```

## Parameters
 pvCallerData

[in] User value specified in a previous call to the [SccSetOption](../extensibility/sccsetoption-function.md) (using option `SCC_OPT_USERDATA`).

 pszOldName

[in] The original name of the file.

 pszNewName

[in] The name the file was renamed to.

## Return value
 None.

## Remarks
 If a file is renamed during a source control operation, the source control plug-in can notify the IDE about the name change through this callback.

 If the IDE does not support this callback, it will not call the [SccSetOption](../extensibility/sccsetoption-function.md) to specify it. If the plug-in does not support this callback, it will return `SCC_E_OPNOTSUPPORTED` from the `SccSetOption` function when the IDE attempts to set the callback.

## See also
- [Callback functions implemented by the IDE](../extensibility/callback-functions-implemented-by-the-ide.md)
- [SccSetOption](../extensibility/sccsetoption-function.md)
