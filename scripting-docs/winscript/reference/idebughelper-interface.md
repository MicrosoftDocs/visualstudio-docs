---
title: "IDebugHelper Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugHelper interface"
ms.assetid: ef5691e0-1d82-42c2-997c-888e31c478dd
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugHelper Interface
Serves as a factory for object browsers and simple connection points. The process debug manager (PDM) implements this interface, which is consumed by script engines.  
  
 In addition to the methods inherited from `IUnknown`, the `IDebugHelper` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugHelper::CreatePropertyBrowser](../../winscript/reference/idebughelper-createpropertybrowser.md)|Returns a property browser that wraps a VARIANT.|  
|[IDebugHelper::CreatePropertyBrowserEx](../../winscript/reference/idebughelper-createpropertybrowserex.md)|Returns a property browser that wraps a VARIANT, and allows for custom conversion of VARIANT values or VARTYPE types to strings.|  
|[IDebugHelper::CreateSimpleConnectionPoint](../../winscript/reference/idebughelper-createsimpleconnectionpoint.md)|Returns an event interface that wraps a given `IDispatch` object.|