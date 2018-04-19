---
title: "IDebugField::GetAddress | Microsoft Docs"
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
  - "IDebugField::GetAddress"
helpviewer_keywords: 
  - "IDebugField::GetAddress method"
ms.assetid: 6981bf03-66ef-4bf9-87ea-f6c9624486cb
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugField::GetAddress
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugField::GetAddress](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugfield-getaddress).  
  
This method gets the debug address of a field.  
  
## Syntax  
  
```cpp#  
HRESULT GetAddress(   
   IDebugAddress** ppAddress  
);  
```  
  
```csharp  
int GetAddress(  
   out IDebugAddress ppAddress  
);  
```  
  
#### Parameters  
 `ppAddress`  
 [out] Returns the address as an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, return an error code.  
  
## See Also  
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)   
 [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)

