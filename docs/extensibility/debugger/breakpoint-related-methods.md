---
title: Breakpoint-Related Methods
description: Visual Studio debugging supports bound breakpoints, which are successfully bound to a location in the code, and pending breakpoints, which are not yet bound.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- debugging [Debugging SDK], breakpoint methods
- breakpoints, methods
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Breakpoint-related methods

A debug engine (DE) must support the setting of breakpoints. Visual Studio debugging supports the following types of breakpoints:

- Bound

     Requested through the UI and successfully bound to a specified code location

- Pending

     Requested through the UI but not yet bound to actual instructions

## Discussion
 For example, a pending breakpoint occurs when the instructions are not yet loaded. When the code is loaded, pending breakpoints try to bind to code at the prescribed location, that is, to insert break instructions in the code. Events are sent to the session debug manager (SDM) to indicate successful binding or to notify that there were binding errors.

 A pending breakpoint also manages its own internal list of corresponding bound breakpoints. One pending breakpoint can cause the insertion of many breakpoints in the code. The Visual Studio debugging UI shows a tree view of pending breakpoints and their corresponding bound breakpoints.

 Creation and use of pending breakpoints require implementation of the [IDebugEngine2::CreatePendingBreakpoint](../../extensibility/debugger/reference/idebugengine2-creatependingbreakpoint.md) method as well as the following methods of [IDebugPendingBreakpoint2](../../extensibility/debugger/reference/idebugpendingbreakpoint2.md) interfaces.

|Method|Description|
|------------|-----------------|
|[CanBind](../../extensibility/debugger/reference/idebugpendingbreakpoint2-canbind.md)|Determines whether a specified pending breakpoint can bind to a code location.|
|[Bind](../../extensibility/debugger/reference/idebugpendingbreakpoint2-bind.md)|Binds a specified pending breakpoint to one or more code locations.|
|[GetState](../../extensibility/debugger/reference/idebugpendingbreakpoint2-getstate.md)|Gets the state of a pending breakpoint.|
|[GetBreakpointRequest](../../extensibility/debugger/reference/idebugpendingbreakpoint2-getbreakpointrequest.md)|Gets the breakpoint request used to create a pending breakpoint.|
|[Enable](../../extensibility/debugger/reference/idebugpendingbreakpoint2-enable.md)|Toggles the enabled state of a pending breakpoint.|
|[EnumBoundBreakpoints](../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumboundbreakpoints.md)|Enumerates all breakpoints bound from a pending breakpoint.|
|[EnumErrorBreakpoints](../../extensibility/debugger/reference/idebugpendingbreakpoint2-enumerrorbreakpoints.md)|Enumerates all error breakpoints that result from a pending breakpoint.|
|[Delete](../../extensibility/debugger/reference/idebugpendingbreakpoint2-delete.md)|Deletes a pending breakpoint and all breakpoints bound from it.|

 To enumerate the bound breakpoints and error breakpoints, you must implement all the methods of [IEnumDebugBoundBreakpoints2](../../extensibility/debugger/reference/ienumdebugboundbreakpoints2.md) and of [IEnumDebugErrorBreakpoints2](../../extensibility/debugger/reference/ienumdebugerrorbreakpoints2.md).

 Pending breakpoints that bind to a code location require implementation of the following [IDebugBoundBreakpoint2](../../extensibility/debugger/reference/idebugboundbreakpoint2.md) methods.

|Method|Description|
|------------|-----------------|
|[GetPendingBreakpoint](../../extensibility/debugger/reference/idebugboundbreakpoint2-getpendingbreakpoint.md)|Gets the pending breakpoint that contains a breakpoint.|
|[GetState](../../extensibility/debugger/reference/idebugboundbreakpoint2-getstate.md)|Gets the state of a bound breakpoint.|
|[GetBreakpointResolution](../../extensibility/debugger/reference/idebugboundbreakpoint2-getbreakpointresolution.md)|Gets the breakpoint resolution that describes a breakpoint.|
|[Enable](../../extensibility/debugger/reference/idebugboundbreakpoint2-enable.md)|Enables or disables a breakpoint.|
|[Delete](../../extensibility/debugger/reference/idebugboundbreakpoint2-delete.md)|Deletes a bound breakpoint.|

 Resolution and request information require implementation of the following [IDebugBreakpointResolution2](../../extensibility/debugger/reference/idebugbreakpointresolution2.md) methods.

|Method|Description|
|------------|-----------------|
|[GetBreakpointType](../../extensibility/debugger/reference/idebugbreakpointresolution2-getbreakpointtype.md)|Gets the type of the breakpoint represented by a resolution.|
|[GetResolutionInfo](../../extensibility/debugger/reference/idebugbreakpointresolution2-getresolutioninfo.md)|Gets the breakpoint resolution information that describes a breakpoint.|

 Resolution of errors that might occur during binding requires implementation of the following [IDebugErrorBreakpoint2](../../extensibility/debugger/reference/idebugerrorbreakpoint2.md) methods.

|Method|Description|
|------------|-----------------|
|[GetPendingBreakpoint](../../extensibility/debugger/reference/idebugerrorbreakpoint2-getpendingbreakpoint.md)|Gets the pending breakpoint that contains an error breakpoint.|
|[GetBreakpointResolution](../../extensibility/debugger/reference/idebugerrorbreakpoint2-getbreakpointresolution.md)|Gets the breakpoint error resolution that describes an error breakpoint.|

 Resolution of errors that might occur during binding also requires the following methods of [IDebugErrorBreakpointResolution2](../../extensibility/debugger/reference/idebugerrorbreakpointresolution2.md).

|Method|Description|
|------------|-----------------|
|[GetBreakpointType](../../extensibility/debugger/reference/idebugerrorbreakpointresolution2-getbreakpointtype.md)|Gets the type of a breakpoint.|
|[GetResolutionInfo](../../extensibility/debugger/reference/idebugerrorbreakpointresolution2-getresolutioninfo.md)|Gets the resolution information of a breakpoint.|

 Viewing the source code at a breakpoint requires you to implement the methods of [IDebugStackFrame2::GetDocumentContext](../../extensibility/debugger/reference/idebugstackframe2-getdocumentcontext.md) and/or the methods of [IDebugStackFrame2::GetCodeContext](../../extensibility/debugger/reference/idebugstackframe2-getcodecontext.md).

## See also
- [Execution control and state evaluation](../../extensibility/debugger/execution-control-and-state-evaluation.md)
