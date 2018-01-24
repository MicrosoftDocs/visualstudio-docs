---
title: "IDebugProcess2::GetAttachedSessionName | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugProcess2::GetAttachedSessionName"
helpviewer_keywords: 
  - "IDebugProcess2::GetAttachedSessionName"
ms.assetid: 7e5e116f-2c0c-4bc8-ad3f-e9fd2318a7e4
caps.latest.revision: 13
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugProcess2::GetAttachedSessionName
Gets the name of the session that is debugging this process. An IDE can display this information to a user who is debugging a particular process on a particular machine.  
  
> [!NOTE]
>  This method is deprecated, and its implementation should always return `E_NOTIMPL`.  
  
## Syntax  
  
```  
HRESULT GetAttachedSessionName(  
   BSTR* pbstrSessionName  
);  
```  
  
#### Parameters  
 `pbstrSessionName`  
  
## Return Value  
 This method should always return `E_NOTIMPL`.  
  
## See Also  
 [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)