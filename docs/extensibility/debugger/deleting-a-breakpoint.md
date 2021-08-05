---
title: Deleting a Breakpoint | Microsoft Docs
description: Learn how the session debug manager removes a pending breakpoint and all bound breakpoints bound from it when a pending breakpoint is deleted.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- breakpoints, deleting
- debugging [Debugging SDK], deleting breakpoints
ms.assetid: 75a046cc-d20a-4c79-ad2d-1f18426ac5d0
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# Deleting a breakpoint
The following describes the process when deleting a pending breakpoint:

## Deletion process
 The session debug manager (SDM) calls the [IDebugPendingBreakpoint2::Delete](../../extensibility/debugger/reference/idebugpendingbreakpoint2-delete.md) method to remove the pending breakpoint and all bound breakpoints bound from it.

> [!NOTE]
> A single bound breakpoint can also be deleted by a call to [IDebugBoundBreakpoint2::Delete](../../extensibility/debugger/reference/idebugboundbreakpoint2-delete.md).

## See also
- [Call debugger events](../../extensibility/debugger/calling-debugger-events.md)
