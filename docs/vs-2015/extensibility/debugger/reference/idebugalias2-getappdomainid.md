---
title: "IDebugAlias2::GetAppDomainId | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
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
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugAlias2::GetAppDomainId
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugAlias2::GetAppDomainId](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugalias2-getappdomainid).  
  
Retrieves the identifier for the application domain.  
  
## Syntax  
  
```cpp#  
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

