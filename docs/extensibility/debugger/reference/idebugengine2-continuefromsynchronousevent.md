---
description: "Called by the session debug manager (SDM) to indicate that a synchronous debug event, previously sent by the debug engine (DE) to the SDM, was received and processed."
title: IDebugEngine2::ContinueFromSynchronousEvent
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine2::ContinueFromSynchronousEvent
helpviewer_keywords:
- IDebugEngine2::ContinueFromSynchronousEvent
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngine2::ContinueFromSynchronousEvent

Called by the session debug manager (SDM) to indicate that a synchronous debug event, previously sent by the debug engine (DE) to the SDM, was received and processed.

## Syntax

### [C#](#tab/csharp)
```csharp
HRESULT ContinueFromSynchronousEvent(
    IDebugEvent2 pEvent
);
```
### [C++](#tab/cpp)
```cpp
HRESULT ContinueFromSynchronousEvent(
    IDebugEvent2* pEvent
);
```
---

## Parameters
`pEvent`\
[in] An [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md) object that represents the previously sent synchronous event from which the debugger should now continue.

## Return Value
If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
The DE must verify that it was the source of the event represented by the `pEvent` parameter.

## Example
The following example shows how to implement this method for a simple `CEngine` object that implements the [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md) interface.

```cpp
HRESULT CEngine::ContinueFromSynchronousEvent(IDebugEvent2* pEvent)
{
    HRESULT hr;

    // Create a pointer to a unique event interface defined for batch file
    // breaks.
    IAmABatchFileEvent *pBatEvent;
    // Check for successful query for the unique batch file event
    // interface.
    if (SUCCEEDED(pEvent->QueryInterface(IID_IAmABatchFileEvent,
                                        (void **)&pBatEvent)))
    {
        // Release the result of the QI.
        pBatEvent->Release();
        // Check thread message for notification to continue.
        if (PostThreadMessage(GetCurrentThreadId(),
                              WM_CONTINUE_SYNC_EVENT,
                              0,
                              0))
        {
            hr = S_OK;
        }
        else
        {
            hr = HRESULT_FROM_WIN32(GetLastError());
        }
    }
    else
    {
        hr = E_INVALIDARG;
    }
    return hr;
}
```

## See also
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
- [IDebugEvent2](../../../extensibility/debugger/reference/idebugevent2.md)
