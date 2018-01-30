---
title: "IDebugAlias2::GetAppDomainId | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "GetAppDomainId"
  - "IDebugAlias2::GetAppDomainId"
ms.assetid: 23581aaa-5a53-4859-b264-eca49fc44bcd
caps.latest.revision: 8
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugAlias2::GetAppDomainId
Retrieves the identifier for the application domain.  
  
## Syntax  
  
```cpp  
HRESULT GetAppDomainId (  
   ULONG32* pappDomainId  
);  
```  
  
```csharp  
int GetAppDomainId (  
   out uint pappDomainId  
);  
```  
  
#### Parameters  
 `pappDomainId`  
 [out] Returns the application domain identifier.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The application domain identifier changes whenever the application is restarted and a new application domain is created.  
  
## See Also  
 [IDebugAlias2](../../../extensibility/debugger/reference/idebugalias2.md)