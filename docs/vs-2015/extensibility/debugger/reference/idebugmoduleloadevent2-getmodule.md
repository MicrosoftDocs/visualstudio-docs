---
title: "IDebugModuleLoadEvent2::GetModule | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugModuleLoadEvent2::GetModule"
helpviewer_keywords: 
  - "IDebugModuleLoadEvent2::GetModule"
ms.assetid: c86482bb-9ce5-4e63-bbe0-969b50169424
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugModuleLoadEvent2::GetModule
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the module that is being loaded or unloaded.  
  
## Syntax  
  
```cpp#  
HRESULT GetModule(   
   IDebugModule2** pModule,  
   BSTR*           pbstrDebugMessage,  
   BOOL*           pbLoad  
);  
```  
  
```csharp  
int GetModule(   
   out IDebugModule2 pModule,  
   ref string        pbstrDebugMessage,  
   ref int           pbLoad  
);  
```  
  
#### Parameters  
 `pModule`  
 [out] Returns an [IDebugModule2](../../../extensibility/debugger/reference/idebugmodule2.md) object that represents the module which is loading or unloading.  
  
 `pbstrDebugMessage`  
 [in, out] Returns an optional message describing this event. If this parameter is a null value, no message is requested.  
  
 `pbLoad`  
 [in, out] Nonzero (`TRUE`) if the module is loading and zero (`FALSE`) if the module is unloading. If this parameter is a null value, no status is requested.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugModuleLoadEvent2](../../../extensibility/debugger/reference/idebugmoduleloadevent2.md)   
 [IDebugModule2](../../../extensibility/debugger/reference/idebugmodule2.md)
