---
title: "IDebugPort2::GetPortRequest | Microsoft Docs"
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
  - "IDebugPort2::GetPortRequest"
helpviewer_keywords: 
  - "IDebugPort2::GetPortRequest"
ms.assetid: 14abf847-0675-4fa8-872e-971e00c84224
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugPort2::GetPortRequest
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the description of a port that was previously used to create the port (if available).  
  
## Syntax  
  
```cpp#  
HRESULT GetPortRequest(   
   IDebugPortRequest2** ppRequest  
);  
```  
  
```csharp  
int GetPortRequest(   
   out IDebugPortRequest2 ppRequest  
);  
```  
  
#### Parameters  
 `ppRequest`  
 [out] Returns an [IDebugPortRequest2](../../../extensibility/debugger/reference/idebugportrequest2.md) object representing the request that was used to create the port.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  Returns `E_PORT_NO_REQUEST` if a port was not created using an [IDebugPortRequest2](../../../extensibility/debugger/reference/idebugportrequest2.md) port request.  
  
## See Also  
 [IDebugPort2](../../../extensibility/debugger/reference/idebugport2.md)   
 [IDebugPortRequest2](../../../extensibility/debugger/reference/idebugportrequest2.md)   
 [AddPort](../../../extensibility/debugger/reference/idebugportsupplier2-addport.md)

