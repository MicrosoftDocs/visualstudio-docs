---
title: "IDebugGenericFieldInstance::GetTypeArguments | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "GetTypeArguments"
  - "IDebugGenericFieldInstance::GetTypeArguments"
ms.assetid: 6e7e0f95-181a-4805-adb3-c2407de0ab93
caps.latest.revision: 10
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugGenericFieldInstance::GetTypeArguments
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugGenericFieldInstance::GetTypeArguments](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebuggenericfieldinstance-gettypearguments).  
  
Retrieves the type parameter arguments for this instance.  
  
## Syntax  
  
```cpp#  
HRESULT GetTypeArguments(  
   ULONG32       cArgs,  
   IDebugField** ppArgs,  
   ULONG32*      pcArgs  
);  
```  
  
```csharp  
int GetTypeArguments(  
   uint              cArgs,  
   out IDebugField[] ppArgs,  
   ref uint          pcArgs  
);  
```  
  
#### Parameters  
 `cArgs`  
 [in] Number of type parameters.  
  
 `ppArgs`  
 [out] Returns an array of type parameters.  
  
 `pcArgs`  
 [in, out] Number of members in the `ppArgs` array.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugGenericFieldInstance](../../../extensibility/debugger/reference/idebuggenericfieldinstance.md)

