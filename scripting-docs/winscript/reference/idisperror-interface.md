---
title: "IDispError Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDispError interface"
ms.assetid: 3dc7b55e-94ba-4669-b20a-1e011f2d07cf
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDispError Interface
Provides detailed contextual error information.  
  
> [!NOTE]
> This interface is not implemented.  
  
 In addition to the methods inherited from `IUnknown`, the `IDispError` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDispError::QueryErrorInfo](../../winscript/reference/idisperror-queryerrorinfo.md)|Retrieves a particular type of error information.|  
|[IDispError::GetNext](../../winscript/reference/idisperror-getnext.md)|Retrieves the next `IDispError` object.|  
|[IDispError::GetHresult](../../winscript/reference/idisperror-gethresult.md)|Retrieves the error code from the `IDispError` object.|  
|[IDispError::GetSource](../../winscript/reference/idisperror-getsource.md)|Returns the language-dependent programmatic identifier for the class or application that raised the error.|  
|[IDispError::GetHelpInfo](../../winscript/reference/idisperror-gethelpinfo.md)|Returns the path of the Help file and the context ID of the topic that explains the error, if possible.|  
|[IDispError::GetDescription](../../winscript/reference/idisperror-getdescription.md)|Returns a textual description of the error.|