---
title: "IDebugProcess2::GetPhysicalProcessId | Microsoft Docs"
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
  - "IDebugProcess2::GetPhysicalProcessId"
helpviewer_keywords: 
  - "IDebugProcess2::GetPhysicalProcessId"
ms.assetid: 77da6e10-75af-4308-97dd-c44416ca52d7
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugProcess2::GetPhysicalProcessId
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

  
Gets the system process identifier.  
  
## Syntax  
  
```cpp#  
HRESULT GetPhysicalProcessId(  
   AD_PROCESS_ID* pdwProcessId  
);  
```  
  
```csharp  
int GetPhysicalProcessId(  
   AD_PROCESS_ID[] pdwProcessId  
);  
```  
  
#### Parameters  
 `pdwProcessId`  
 [out] An [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure that is filled in with the system process identifier information.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)   
 [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md)

