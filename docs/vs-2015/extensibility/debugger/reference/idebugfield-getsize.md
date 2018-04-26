---
title: "IDebugField::GetSize | Microsoft Docs"
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
  - "IDebugField::GetSize"
helpviewer_keywords: 
  - "IDebugField::GetSize method"
ms.assetid: 73329924-3751-4f44-af54-5986b7943374
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugField::GetSize
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugField::GetSize](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugfield-getsize).  
  
This method gets the size of a field, in bytes.  
  
## Syntax  
  
```cpp#  
HRESULT GetSize(   
   DWORD* pdwSize  
);  
```  
  
```csharp  
int GetSize(  
   out uint pdwSize  
);  
```  
  
#### Parameters  
 `pdwSize`  
 [out] Returns the size.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 All fields have a type and all types have a size. For example, a field with a type of byte has a size of 1 byte.  
  
## See Also  
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)

