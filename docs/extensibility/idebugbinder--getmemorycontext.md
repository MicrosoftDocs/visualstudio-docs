---
title: "IDebugBinder::GetMemoryContext"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugBinder::GetMemoryContext"
helpviewer_keywords: 
  - "IDebugBinder::GetMemoryContext method"
ms.assetid: 801c5b60-acff-4822-b23d-e9c7bbca8a0f
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugBinder::GetMemoryContext
This method converts either an object location or a memory address to a memory context.  
  
## Syntax  
  
```cpp#  
HRESULT GetMemoryContext(   
   IDebugField*           pField,  
   DWORD                  dwConstant,  
   IDebugMemoryContext2** ppMemCxt  
);  
```  
  
```c#  
int GetMemoryContext(  
   IDebugField              pField,   
   uint                     dwConstant,   
   out IDebugMemoryContext2 ppMemCxt  
);  
```  
  
#### Parameters  
 `pField`  
 [in] An [IDebugField](../extensibility/idebugfield.md) describing the object to locate. If `NULL`, then use `dwConstant` instead.  
  
 `dwConstant`  
 [in] A constant memory address, such as 0x5000.  
  
 `ppMemCxt`  
 [out] Returns the [IDebugMemoryContext2](../extensibility/idebugmemorycontext2.md) interface that represents the address of the object, or the address in memory.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugBinder](../extensibility/idebugbinder.md)   
 [IDebugMemoryContext2](../extensibility/idebugmemorycontext2.md)   
 [IDebugField](../extensibility/idebugfield.md)