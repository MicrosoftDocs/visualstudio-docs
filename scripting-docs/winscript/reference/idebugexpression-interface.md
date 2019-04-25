---
title: "IDebugExpression Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugExpression interface"
ms.assetid: 36c00ffb-7160-4c30-a2c9-c9d70c8213cd
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugExpression Interface
Represents an asynchronously evaluated expression. Script engines typically implement this interface. A debugger IDE typically uses this interface to enable an immediate execution window or watch window.  
  
> [!NOTE]
> The `IDebugExpression` interface is available only from a stack frame.  
  
 In addition to the methods inherited from `IUnknown`, the `IDebugExpression` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugExpression::Start](../../winscript/reference/idebugexpression-start.md)|Begins the evaluation of the expression.|  
|[IDebugExpression::Abort](../../winscript/reference/idebugexpression-abort.md)|Aborts the expression.|  
|[IDebugExpression::QueryIsComplete](../../winscript/reference/idebugexpression-queryiscomplete.md)|Determines if the operation is complete.|  
|[IDebugExpression::GetResultAsString](../../winscript/reference/idebugexpression-getresultasstring.md)|Returns the result of the expression evaluation as a string and the operation's return value.|  
|[IDebugExpression::GetResultAsDebugProperty](../../winscript/reference/idebugexpression-getresultasdebugproperty.md)|Returns the result of the expression evaluation as a debug property and the operation's return value.|