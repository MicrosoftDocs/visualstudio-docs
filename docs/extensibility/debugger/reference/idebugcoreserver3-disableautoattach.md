---
title: "IDebugCoreServer3::DisableAutoAttach | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugCoreServer3::DisableAutoAttach"
helpviewer_keywords: 
  - "IDebugCoreServer3::DisableAutoAttach"
ms.assetid: 9d860a20-c154-4df4-ba15-636e0fcd42bf
caps.latest.revision: 6
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugCoreServer3::DisableAutoAttach
Disables automatic attaching for all debug engines associated with this server.  
  
## Syntax  
  
```cpp  
HRESULT DisableAutoAttach(  
   void  
);  
```  
  
```csharp  
int DisableAutoAttach();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
## See Also  
 [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md)