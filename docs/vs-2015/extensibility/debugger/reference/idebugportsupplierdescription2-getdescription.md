---
title: "IDebugPortSupplierDescription2::GetDescription | Microsoft Docs"
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
  - "IDebugPortSupplierDescription2::GetDescription"
ms.assetid: bff5f536-1cd1-4313-8856-db7b05818305
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugPortSupplierDescription2::GetDescription
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

  
Retrieves the description and description metadata for the port supplier.  
  
## Syntax  
  
```cpp#  
HRESULT GetDescription(  
   PORT_SUPPLIER_DESCRIPTION_FLAGS *pdwFlags,  
   BSTR *pbstrText  
);  
```  
  
```csharp  
public int GetDescription(  
   out enum_PORT_SUPPLIER_DESCRIPTION_FLAGS pdwFlags,  
   out string pbstrText  
);  
```  
  
#### Parameters  
 `pdwFlags`  
 [out] Metadata flags for the description.  
  
 `pbstrText`  
 [out] Description of the port supplier.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugPortSupplierDescription2](../../../extensibility/debugger/reference/idebugportsupplierdescription2.md)

