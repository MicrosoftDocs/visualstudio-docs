---
title: "BP_RESOLUTION_DATA"
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
  - "BP_RESOLUTION_DATA"
helpviewer_keywords: 
  - "BP_RESOLUTION_DATA structure"
ms.assetid: 9e0b9000-6a84-47b9-b07a-367a75764389
caps.latest.revision: 11
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
# BP_RESOLUTION_DATA
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
  
```c#  
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
 A value from the [BP_RES_DATA_FLAGS](../extensibility/bp_res_data_flags.md) enumeration, describing how the data breakpoint is implemented.  
  
## Remarks  
 This structure is a member of the [BP_RESOLUTION_LOCATION](../extensibility/bp_resolution_location.md) structure, which is in turn a member of the [BP_RESOLUTION_INFO](../extensibility/bp_resolution_info.md) structure returned by the [GetResolutionInfo](../extensibility/idebugbreakpointresolution2--getresolutioninfo.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [BP_RESOLUTION_LOCATION](../extensibility/bp_resolution_location.md)   
 [BP_RESOLUTION_INFO](../extensibility/bp_resolution_info.md)   
 [GetResolutionInfo](../extensibility/idebugbreakpointresolution2--getresolutioninfo.md)