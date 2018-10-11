---
title: "IDebugField::GetInfo | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugField::GetInfo"
helpviewer_keywords: 
  - "IDebugField::GetInfo method"
ms.assetid: 7d508200-89ce-400f-a8ea-f28e7610cb2b
caps.latest.revision: 13
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugField::GetInfo
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugField::GetInfo](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugfield-getinfo).  
  
This method gets displayable information about the field.  
  
## Syntax  
  
```cpp#  
HRESULT GetInfo(   
   FIELD_INFO_FIELDS dwFields,  
   FIELD_INFO* pFieldInfo  
);  
```  
  
```csharp  
int GetInfo(  
   enum_FIELD_INFO_FIELDS dwFields,  
   FIELD_INFO[] pFieldInfo  
);  
```  
  
#### Parameters  
 `dwFields`  
 [in] A combination of [FIELD_INFO_FIELDS](../../../extensibility/debugger/reference/field-info-fields.md) constants that selects the information to be displayed. If the field represents a symbol, this is typically the symbol name and type.  
  
 `pFieldInfo`  
 [out] Returns the information in the supplied [FIELD_INFO](../../../extensibility/debugger/reference/field-info.md) structure.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)   
 [FIELD_INFO](../../../extensibility/debugger/reference/field-info.md)

