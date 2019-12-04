---
title: "ISimpleConnectionPoint Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "ISimpleConnectionPoint interface"
ms.assetid: f632a82f-942d-4291-963e-e9fa2b162493
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ISimpleConnectionPoint Interface
Provides a simple way for describing and enumerating the events fired on a particular connection point. This interface also makes it easy to hook up an `IDispatch` object to those events. This interface is implemented by the Process Debug Manager (PDM), and consumed by script engines.  
  
 This interface is available from `IDebugHelper::CreateSimpleConnectionPoint`.  
  
 In addition to the methods inherited from `IUnknown`, the `ISimpleConnectionPoint` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[ISimpleConnectionPoint::Advise](../../winscript/reference/isimpleconnectionpoint-advise.md)|Establishes a connection between the simple connection point object and the client's sink.|  
|[ISimpleConnectionPoint::DescribeEvents](../../winscript/reference/isimpleconnectionpoint-describeevents.md)|Returns the DISPID and name for each event in a specified range of events.|  
|[ISimpleConnectionPoint::GetEventCount](../../winscript/reference/isimpleconnectionpoint-geteventcount.md)|Returns the number of events exposed on this interface.|  
|[ISimpleConnectionPoint::Unadvise](../../winscript/reference/isimpleconnectionpoint-unadvise.md)|Terminates an advisory connection previously established through `ISimpleConnectionPoint::Advise`.|  
  
## See also  
 [IDebugProperty Interface](../../winscript/reference/idebugproperty-interface.md)