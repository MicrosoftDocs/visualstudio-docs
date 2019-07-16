---
title: "IDebugCoreServer3::GetServerName | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugCoreServer3::GetServerName"
helpviewer_keywords: 
  - "IDebugCoreServer3::GetServerName"
ms.assetid: 0fc3fcf5-d6a3-4a00-bf14-458b8645714e
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugCoreServer3::GetServerName
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves the name of the server.  
  
## Syntax  
  
```cpp#  
HRESULT GetServerName(  
   BSTR* pbstrName  
);  
```  
  
```csharp  
int GetServerName(  
   out string pbstrName  
);  
```  
  
#### Parameters  
 `pbstrName`  
 [out] Returns the name of the server.  
  
> [!NOTE]
> The caller is responsible for freeing the string.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
## Remarks  
 For a friendly server name, call the [GetServerFriendlyName](../../../extensibility/debugger/reference/idebugcoreserver3-getserverfriendlyname.md) method.  
  
## See Also  
 [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md)   
 [GetServerFriendlyName](../../../extensibility/debugger/reference/idebugcoreserver3-getserverfriendlyname.md)
