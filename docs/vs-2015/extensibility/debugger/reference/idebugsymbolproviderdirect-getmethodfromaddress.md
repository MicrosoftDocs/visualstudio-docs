---
title: "IDebugSymbolProviderDirect::GetMethodFromAddress | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugSymbolProviderDirect::GetMethodFromAddress"
  - "GetMethodFromAddress"
ms.assetid: 33ffd197-1221-41bc-a9f6-f133ebdcb783
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugSymbolProviderDirect::GetMethodFromAddress
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves information about the method at the specified debug address.  
  
## Syntax  
  
```cpp#  
HRESULT GetMethodFromAddress(  
   IDebugAddress* pAddress,  
   GUID*          pGuid,  
   DWORD*         pAppID,  
   _mdToken*      pTokenClass,  
   _mdToken*      pTokenMethod,  
   DWORD*         pdwOffset,  
   DWORD*         pdwVersion  
);  
```  
  
```csharp  
int GetMethodFromAddress(  
   IDebugAddress pAddress,  
   out Guid      pGuid,  
   out uint      pAppID,  
   out uint      pTokenClass,  
   out uint      pTokenMethod,  
   out uint      pdwOffset,  
   out uint      pdwVersion  
);  
```  
  
#### Parameters  
 `pAddress`  
 [in] Debug address that is represented by the [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface.  
  
 `pGuid`  
 [out] Unique identifier of the module.  
  
 `pAppID`  
 [out] Identifier of the application domain.  
  
 `pTokenClass`  
 [out] Token that represents the containing class.  
  
 `pTokenMethod`  
 [out] Token that represents the module.  
  
 `pdwOffset`  
 [out] An offset in bytes from the start of the `pAddress` parameter.  
  
 `pdwVersion`  
 [out] Version number of the method.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugSymbolProviderDirect](../../../extensibility/debugger/reference/idebugsymbolproviderdirect.md)
