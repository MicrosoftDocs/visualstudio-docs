---
title: "IDebugExpressionContext Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugExpressionContext Interface"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugExpressionContext interface"
ms.assetid: 52af82e8-0dec-49e2-a7f3-d00f66ca1401
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugExpressionContext Interface
Represents a context where expressions can be evaluated. The stack frame object implements this interface.  
  
 In addition to the methods inherited from `IUnknown`, the `IDebugExpressionContext` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugExpressionContext::ParseLanguageText](../../winscript/reference/idebugexpressioncontext-parselanguagetext.md)|Creates a debug expression for the specified text.|  
|[IDebugExpressionContext::GetLanguageInfo](../../winscript/reference/idebugexpressioncontext-getlanguageinfo.md)|Returns a name and GUID for the language that owns this context.|