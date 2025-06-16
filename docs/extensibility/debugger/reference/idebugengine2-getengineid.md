---
description: "Gets the GUID of the debug engine (DE)."
title: IDebugEngine2::GetEngineID
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine2::GetEngineID
helpviewer_keywords:
- IDebugEngine2::GetEngineID
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngine2::GetEngineID

Gets the GUID of the debug engine (DE).

## Syntax

### [C#](#tab/csharp)
```csharp
int GetEngineID(
    out Guid pguidEngine
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetEngineID(
    GUID* pguidEngine
);
```
---

## Parameters
`pguidEngine`\
[out] Returns the GUID of the DE.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
Some examples of typical GUIDs are `guidScriptEng`, `guidNativeEng`, or `guidSQLEng`. New debug engines will create their own GUID for identification.

## Example
The following example shows how to implement this method for a simple `CEngine` object that implements the [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md) interface.

```cpp
HRESULT CEngine::GetEngineId(GUID *pguidEngine) {
    if (pguidEngine) {
        // Set pguidEngine to guidBatEng, as defined in the Batdbg.idl file.
        // Other languages would require their own guidDifferentEngine to be
        //defined in the Batdbg.idl file.
        *pguidEngine = guidBatEng;
        return NOERROR; // This is typically S_OK.
    } else {
        return E_INVALIDARG;
    }
}
```

## See also
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
