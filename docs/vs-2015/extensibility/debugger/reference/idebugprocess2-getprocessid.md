---
title: "IDebugProcess2::GetProcessId | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugProcess2::GetProcessId"
helpviewer_keywords: 
  - "IDebugProcess2::GetProcessId"
ms.assetid: d5b6f03c-d49d-4b83-b072-016ac3124f5f
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugProcess2::GetProcessId
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugProcess2::GetProcessId](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugprocess2-getprocessid).  
  
Gets the GUID for this process.  
  
## Syntax  
  
```cpp#  
HRESULT GetProcessId(  
   GUID* pguidProcessId  
);  
```  
  
```csharp  
int GetProcessId(  
   out Guid pguidProcessId  
);  
```  
  
#### Parameters  
 `pguidProcessId`  
 [out] Returns the GUID for this process.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The Globally Unique IDentifier (GUID) identifies this process from all other processes running in the system.  
  
## See Also  
 [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)

