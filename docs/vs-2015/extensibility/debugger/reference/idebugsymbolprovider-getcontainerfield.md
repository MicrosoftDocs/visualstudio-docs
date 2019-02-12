---
title: "IDebugSymbolProvider::GetContainerField | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugSymbolProvider::GetContainerField"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetContainerField method"
ms.assetid: d6b56b4f-a96b-4fa7-87c1-bac4e58fa766
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugSymbolProvider::GetContainerField
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method gets the field that contains the debug address.  
  
## Syntax  
  
```cpp#  
HRESULT GetContainerField(   
   IDebugAddress*         pAddress,  
   IDebugContainerField** ppContainerField  
);  
```  
  
```csharp  
int GetContainerField(  
   IDebugAddress            pAddress,   
   out IDebugContainerField ppContainerField  
);  
```  
  
#### Parameters  
 `pAddress`  
 [in] The address as represented by an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface.  
  
 `ppContainerField`  
 [out] Returns a container field represented by an [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md) interface.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)   
 [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)   
 [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md)
