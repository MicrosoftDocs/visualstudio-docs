---
title: "IDebugPortSupplierLocale2::SetLocale | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugPortSupplierLocale2::SetLocale"
ms.assetid: 21e88510-caac-405e-ba45-cb00e19a28bc
caps.latest.revision: 6
ms.author: gregvanl
manager: jillfra
---
# IDebugPortSupplierLocale2::SetLocale
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Sets the locale for the port supplier.  
  
## Syntax  
  
```cpp#  
HRESULT SetLocale(  
   WORD wLangID  
);  
```  
  
```csharp  
int SetLocale(  
   ushort wLangID  
);  
```  
  
#### Parameters  
 `wLangID`  
 Identifier for the locale to set.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPortSupplierLocale2](../../../extensibility/debugger/reference/idebugportsupplierlocale2.md)
