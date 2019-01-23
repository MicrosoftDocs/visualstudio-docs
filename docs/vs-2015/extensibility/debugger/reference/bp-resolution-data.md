---
title: "BP_RESOLUTION_DATA | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "BP_RESOLUTION_DATA"
helpviewer_keywords: 
  - "BP_RESOLUTION_DATA structure"
ms.assetid: 9e0b9000-6a84-47b9-b07a-367a75764389
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# BP_RESOLUTION_DATA
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Describes the result of binding a data breakpoint.  
  
## Syntax  
  
```cpp#  
typedef struct _BP_RESOLUTION_DATA {   
   BSTR              bstrDataExpr;  
   BSTR              bstrFunc;  
   BSTR              bstrImage;  
   BP_RES_DATA_FLAGS dwFlags;  
} BP_RESOLUTION_DATA;  
```  
  
```csharp  
public struct BP_RESOLUTION_DATA {   
   public string bstrDataExpr;  
   public string bstrFunc;  
   public string bstrImage;  
   public uint   dwFlags;  
};  
```  
  
## Members  
 `bstrDataExpr`  
 The data expression that has been bound.  
  
 `bstrFunc`  
 The name of the function the data breakpoint has bound in (if any).  
  
 `bstrImage`  
 The name of the module (MyModule.dll, for example) that the data breakpoint has bound in.  
  
 `dwFlags`  
 A value from the [BP_RES_DATA_FLAGS](../../../extensibility/debugger/reference/bp-res-data-flags.md) enumeration, describing how the data breakpoint is implemented.  
  
## Remarks  
 This structure is a member of the [BP_RESOLUTION_LOCATION](../../../extensibility/debugger/reference/bp-resolution-location.md) structure, which is in turn a member of the [BP_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-resolution-info.md) structure returned by the [GetResolutionInfo](../../../extensibility/debugger/reference/idebugbreakpointresolution2-getresolutioninfo.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [BP_RESOLUTION_LOCATION](../../../extensibility/debugger/reference/bp-resolution-location.md)   
 [BP_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-resolution-info.md)   
 [GetResolutionInfo](../../../extensibility/debugger/reference/idebugbreakpointresolution2-getresolutioninfo.md)
