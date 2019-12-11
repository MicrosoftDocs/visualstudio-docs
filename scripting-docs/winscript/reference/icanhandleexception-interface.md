---
title: "ICanHandleException Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "ICanHandleException interface"
ms.assetid: 32df7f81-557d-40cf-a844-06a6eaa292f3
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ICanHandleException Interface
Allows the caller of a script engine to specify which exceptions the caller handles.  
  
## Methods  
 In addition to the methods inherited from `IUnknown`, the `ICanHandleException` interface exposes the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[ICanHandleException::CanHandleException](../../winscript/reference/icanhandleexception-canhandleexception.md)|Determines if the caller of the script engine can handle a specified exception.|