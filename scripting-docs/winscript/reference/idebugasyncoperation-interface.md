---
title: "IDebugAsyncOperation Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugAsyncOperation interface"
ms.assetid: ebb2ea75-1443-4d8a-812d-171a166f5f9d
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugAsyncOperation Interface
The Process Debug Manager implements the `IDebugAsyncOperation` interface. A language engine calls the `IDebugApplication::CreateAsyncDebugOperation` method to obtain a reference to this interface. The language engine can use the `IDebugAsyncOperation` interface to provide asynchronous access to a synchronous debug operation.  
  
 In addition to the methods inherited from `IUnknown`, the `IDebugAsyncOperation` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugAsyncOperation::GetSyncDebugOperation](../../winscript/reference/idebugasyncoperation-getsyncdebugoperation.md)|Returns the synchronous debug operation associated with this object.|  
|[IDebugAsyncOperation::Start](../../winscript/reference/idebugasyncoperation-start.md)|Causes the asynchronous operation to begin.|  
|[IDebugAsyncOperation::Abort](../../winscript/reference/idebugasyncoperation-abort.md)|Cancels an operation.|  
|[IDebugAsyncOperation::QueryIsComplete](../../winscript/reference/idebugasyncoperation-queryiscomplete.md)|Determines if the debug operation has completed.|  
|[IDebugAsyncOperation::GetResult](../../winscript/reference/idebugasyncoperation-getresult.md)|Provides the return value and return object parameter from the synchronous debug operation.|