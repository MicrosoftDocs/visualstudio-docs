---
description: "Allows the process to be notified of port events."
title: IDebugProgramProvider2::WatchForProviderEvents
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramProvider2::WatchForProviderEvents
helpviewer_keywords:
- IDebugProgramProvider2::WatchForProviderEvents
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramProvider2::WatchForProviderEvents

Allows the process to be notified of port events.

## Syntax

### [C#](#tab/csharp)
```csharp
int WatchForProviderEvents(
   enum_PROVIDER_FLAGS   Flags,
   IDebugDefaultPort2    pPort,
   AD_PROCESS_ID         ProcessId,
   CONST_GUID_ARRAY      EngineFilter,
   ref Guid              guidLaunchingEngine,
   IDebugPortNotify2     pEventCallback
);
```
### [C++](#tab/cpp)
```cpp
HRESULT WatchForProviderEvents(
   PROVIDER_FLAGS       Flags,
   IDebugDefaultPort2*  pPort,
   AD_PROCESS_ID        processId,
   CONST_GUID_ARRAY     EngineFilter,
   REFGUID              guidLaunchingEngine,
   IDebugPortNotify2*   pEventCallback
);
```
---

## Parameters
`Flags`\
[in] A combination of flags from the [PROVIDER_FLAGS](../../../extensibility/debugger/reference/provider-flags.md) enumeration. The following flags are typical for this call:

|Flag|Description|
|----------|-----------------|
|`PFLAG_REMOTE_PORT`|Caller is running on remote machine.|
|`PFLAG_DEBUGGEE`|Caller is currently being debugged (additional information about marshalling is returned for each node).|
|`PFLAG_ATTACHED_TO_DEBUGGEE`|Caller was attached to but not launched by the debugger.|
|`PFLAG_REASON_WATCH`|Caller wants to watch for events. If this flag is not set. then the callback event is removed and the caller no longer receives notifications.|

`pPort`\
[in] The port the calling process is running on.

`processId`\
[in] An [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure holding the ID of the process that contains the program in question.

`EngineFilter`\
[in] An array of GUIDs of debug engines associated with the process.

`guidLaunchingEngine`\
[in] GUID of the debug engine that launched this process (if any).

`pEventCallback`\
[in] An [IDebugPortNotify2](../../../extensibility/debugger/reference/idebugportnotify2.md) object that receives the event notifications.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 When a caller wants to remove an event handler that was established with a previous call to this method, the caller passes the same parameters as it did the first time but leaves off the `PFLAG_REASON_WATCH` flag.

## Example
 The following example shows how to implement this method for a **CDebugEngine** object that exposes the [IDebugProgramProvider2](../../../extensibility/debugger/reference/idebugprogramprovider2.md) interface.

```cpp
STDMETHODIMP CDebugEngine::WatchForProviderEvents(
    PROVIDER_FLAGS Flags,
    IDebugDefaultPort2 *pPort,
    AD_PROCESS_ID processId,
    CONST_GUID_ARRAY EngineFilter,
    REFGUID guidLaunchingEngine,
    IDebugPortNotify2 *pPortNotify)
{
    HRESULT hRes = E_FAIL;

    if (EVAL(pPort != NULL) && EVAL(pPortNotify != NULL))
    {
        // We will only watch/send events about the process if the debugger
        // is actually debugging the process, and only if this is an attach or a LoRIE launch
        if (IsFlagSet(Flags, PFLAG_DEBUGGEE) &&
            guidLaunchingEngine == GUID_NULL &&
            processId.ProcessIdType == AD_PROCESS_ID_SYSTEM)
        {
            // We don't support WatchForProviderEvents when in interop mode
            if (m_fInterop)
            {
                ASSERT(!"Shouldn't ever be called in interop mode");
                hRes = E_FAIL;
            }
            else
            {
                if (IsFlagSet(Flags, PFLAG_REASON_WATCH))
                {
                    // QI to get IDebugEventCallback2 which is required.
                    CComQIPtr<IDebugEventCallback2> pCallback(pPortNotify);

                    ASSERT(pCallback != NULL);
                    if ( pCallback != NULL )
                    {
                        // Register the callback
                        hRes = this->InitDebugSession(pCallback);

                        if ( S_OK == hRes )
                        {
                            // Get the IDebugProcess2 from the port and call AttachImpl
                            CComPtr<IDebugProcess2> spProcess;

                            hRes = pPort->GetProcess(processId, &spProcess);

                            if (HREVAL(S_OK, hRes))
                            {
                                hRes = AttachImpl(spProcess, NULL, NULL, processId.ProcessId.dwProcessId, ATTACH_REASON_USER, NULL);

                                if ( FAILED(hRes) && (!m_pPidList || 0 == m_pPidList->GetCount()) )
                                    this->Cleanup();
                            }
                        }
                        else
                            this->Cleanup();
                    }
                    else
                        hRes = E_FAIL;
                }
                else
                {
                    // Detach will be done by SDM calling on programs directly if there are managed programs.

                    // This handling is the case where no managed code ever ran.
                    if ( this->IsProcessBeingDebugged(processId.ProcessId.dwProcessId) )
                    {
                        ProgramList *pProgList = this->GetProgramListCopy();

                        if ( EVAL(pProgList) )
                        {
                            if ( pProgList->GetCount() == 0)
                            {
                                CComPtr<ICorDebugProcess> pCorProcess;

                                hRes = this->GetCorProcess(processId.ProcessId.dwProcessId, &pCorProcess);

                                if (HREVAL(S_OK, hRes) )
                                {
                                    hRes = pCorProcess->Stop(INFINITE);

                                    if ( HREVAL(S_OK, hRes) )
                                        hRes = pCorProcess->Detach();
                                }

                                // Tell the engine that it should unregister this process from com+
                                this->UnregisterProcess(processId.ProcessId.dwProcessId);

                                // If there are no more pids left then cleanup everything.
                                if ( 0 == m_pPidList->GetCount() )
                                    this->Cleanup();
                            }
                            // This is needed for cases where the SDM has not yet received program create
                            // by the time that we need to detach (example: the managed attach succeeds,
                            // but some other attach step fails).
                            else
                            {
                                PROGNODE *pProgNode = NULL;
                                while ( pProgNode = pProgList->Next(pProgNode) )
                                {
                                    CDebugProgram * pProgram = ((CDebugProgram *)pProgNode->data);
                                    hRes = pProgram->Detach();
                                }
                            }

                            delete pProgList;
                        }
                    }
                    else
                        hRes = S_OK;
                }
            }
        }
        else
        {
            hRes = S_FALSE;
        }
    }
    else
    {
        hRes = E_INVALIDARG;
    }

    return hRes;
}
```

## See also
- [IDebugProgramProvider2](../../../extensibility/debugger/reference/idebugprogramprovider2.md)
- [PROVIDER_FLAGS](../../../extensibility/debugger/reference/provider-flags.md)
- [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md)
- [CONST_GUID_ARRAY](../../../extensibility/debugger/reference/const-guid-array.md)
- [IDebugDefaultPort2](../../../extensibility/debugger/reference/idebugdefaultport2.md)
- [IDebugPortNotify2](../../../extensibility/debugger/reference/idebugportnotify2.md)
