---
title: "IProvideExpressionContexts Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IProvideExpressionContexts interface"
ms.assetid: e4c70f2c-7d86-4fdc-a1cb-f5a0bb8ed037
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IProvideExpressionContexts Interface
Provides a way to enumerate expression contexts known by a certain component. Script engines typically implement this interface.  
  
 The process debug manager uses this interface to find all global expression contexts associated with a given thread.  
  
> [!NOTE]
> This interface is called from within the thread of interest. It is up to the implementer to identify the current thread and return an appropriate enumerator.  
  
## Methods  
 In addition to the methods inherited from `IUnknown`, the `IProvideExpressionContexts` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IProvideExpressionContexts::EnumExpressionContexts](../../winscript/reference/iprovideexpressioncontexts-enumexpressioncontexts.md)|Returns an enumerator of expression contexts known by this component.|