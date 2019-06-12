---
title: "IDebugProcess2::GetPort | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProcess2::GetPort"
helpviewer_keywords: 
  - "IDebugProcess2::GetPort"
ms.assetid: e39b6e5a-64eb-48cf-a53d-da4fdb968e2d
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugProcess2::GetPort
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the port that the process is running on.  
  
## Syntax  
  
```cpp#  
HRESULT GetPort(   
   IDebugPort2** ppPort  
);  
```  
  
```csharp  
int GetPort(   
   out IDebugPort2 ppPort  
);  
```  
  
#### Parameters  
 `ppPort`  
 [out] Returns an [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md) object that represents the port on which the process was launched.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)   
 [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)
