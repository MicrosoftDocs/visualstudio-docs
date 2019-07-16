---
title: "IDebugGenericFieldInstance | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugGenericFieldInstance interface"
ms.assetid: f68b4761-be8b-4801-9d4b-cde90e01d95e
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# IDebugGenericFieldInstance
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Represents an instance of a field for a managed code generic type.  
  
## Syntax  
  
```  
IDebugGenericFieldInstance : IUnknown  
```  
  
## Methods  
 This interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[GetTypeArguments](../../../extensibility/debugger/reference/idebuggenericfieldinstance-gettypearguments.md)|Retrieves the type parameter arguments for this instance.|  
|[TypeArgumentCount](../../../extensibility/debugger/reference/idebuggenericfieldinstance-typeargumentcount.md)|Returns the number of type parameter arguments for this instance.|  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
