---
title: "IDebugCoreServer3::GetServerFriendlyName | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugCoreServer3::GetServerFriendlyName"
helpviewer_keywords: 
  - "IDebugCoreServer3::GetServerFriendlyName"
ms.assetid: 7035b904-b3d7-4d9b-98d9-65714b8a8b9f
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugCoreServer3::GetServerFriendlyName
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves a friendly name for the server.  
  
## Syntax  
  
```cpp#  
HRESULT GetServerFriendlyName(  
   BSTR* pbstrName  
);  
```  
  
```csharp  
int GetServerFriendlyName(  
   out string pbstrName  
);  
```  
  
#### Parameters  
 `pbstrName`  
 [out] Returns a friendly name for the server.  
  
> [!NOTE]
> The caller is responsible for freeing the string.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
## Remarks  
 For user-launched servers, the name returned by this method is the full name of the server. For auto-launched servers, the name is that of the machine the server is running on.  
  
 For a machine-oriented name, call the [GetServerName](../../../extensibility/debugger/reference/idebugcoreserver3-getservername.md) method.  
  
## See Also  
 [IDebugCoreServer3](../../../extensibility/debugger/reference/idebugcoreserver3.md)   
 [GetServerName](../../../extensibility/debugger/reference/idebugcoreserver3-getservername.md)
