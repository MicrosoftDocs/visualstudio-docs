---
title: "IDebugBinder3::GetTypeArgumentCount | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugBinder3::GetTypeArgumentCount"
helpviewer_keywords: 
  - "IDebugBinder3::GetTypeArgumentCount method"
ms.assetid: caf68de6-6f7c-4efd-b803-121347a5032e
caps.latest.revision: 8
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugBinder3::GetTypeArgumentCount
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugBinder3::GetTypeArgumentCount](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugbinder3-gettypeargumentcount).  
  
This method returns the number of argument types associated with this object.  
  
## Syntax  
  
```cpp  
HRESULT GetTypeArgumentCount(  
   UINT* uCount  
);  
```  
  
```csharp  
int GetTypeArgumentCount(  
   out uint uCount  
);  
```  
  
#### Parameters  
 `uCount`  
 [out] Number of argument types associated with this object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The value returned by this method can be used to allocate an array for use with the [GetTypeArguments](../../../extensibility/debugger/reference/idebugbinder3-gettypearguments.md) method.  
  
## See Also  
 [IDebugBinder3](../../../extensibility/debugger/reference/idebugbinder3.md)   
 [GetTypeArguments](../../../extensibility/debugger/reference/idebugbinder3-gettypearguments.md)

