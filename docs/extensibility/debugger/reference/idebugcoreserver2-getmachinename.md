---
title: "IDebugCoreServer2::GetMachineName | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugCoreServer2::GetName"
helpviewer_keywords: 
  - "IDebugCoreServer2::GetName"
ms.assetid: 693bd794-7215-4f07-8651-b57366d39953
caps.latest.revision: 11
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugCoreServer2::GetMachineName
Gets the name of the machine the core server is running on.  
  
## Syntax  
  
```cpp  
HRESULT GetName(   
   BSTR* pbstrName  
);  
```  
  
```csharp  
int GetName(   
   out string pbstrName  
);  
```  
  
#### Parameters  
 `pbstrName`  
 [out] Returns a string containing the name of the machine.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugCoreServer2](../../../extensibility/debugger/reference/idebugcoreserver2.md)