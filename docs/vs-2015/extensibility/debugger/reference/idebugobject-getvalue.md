---
title: "IDebugObject::GetValue | Microsoft Docs"
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
  - "IDebugObject::GetValue"
helpviewer_keywords: 
  - "IDebugObject::GetValue method"
ms.assetid: eec6051e-8ecb-49fa-bdd4-dd786f211692
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugObject::GetValue
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

  
Gets the value of the object as a consecutive series of bytes.  
  
## Syntax  
  
```cpp#  
HRESULT GetValue(   
   BYTE* pValue,  
   UINT  nSize  
);  
```  
  
```csharp  
int GetValue(  
   ref byte[] pValue,   
   uint nSize  
);  
```  
  
#### Parameters  
 `pValue`  
 [in, out] An array that is filled in with a consecutive series of bytes representing the value of the object.  
  
 `nSize`  
 [in] The maximum number of bytes to fetch.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 Get the total number of value bytes that can be fetched by calling the [GetSize](../../../extensibility/debugger/reference/idebugobject-getsize.md) method.  
  
## See Also  
 [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)

