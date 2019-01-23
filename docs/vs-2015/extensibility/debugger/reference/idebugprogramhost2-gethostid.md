---
title: "IDebugProgramHost2::GetHostId | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgramHost2::GetHostId"
helpviewer_keywords: 
  - "IDebugProgramHost2::GetHostId"
ms.assetid: 7702e221-feb1-446b-a224-cb46c420987e
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugProgramHost2::GetHostId
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the process identifier of the process hosting this program.  
  
## Syntax  
  
```cpp#  
HRESULT GetHostId(   
   AD_PROCESS_ID* pdwId  
);  
```  
  
```csharp  
int GetHostId(   
   AD_PROCESS_ID[] pdwId  
);  
```  
  
#### Parameters  
 `pdwId`  
 [in, out] An [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure that is filled in with the process identifier information.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProgramHost2](../../../extensibility/debugger/reference/idebugprogramhost2.md)   
 [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md)
