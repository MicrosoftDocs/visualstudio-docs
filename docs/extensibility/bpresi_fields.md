---
title: "BPRESI_FIELDS"
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
  - "BPRESI_FIELDS"
helpviewer_keywords: 
  - "BPRESI_FIELDS enumeration"
ms.assetid: 99f17b1e-3e67-4f85-89d6-5c6cf45c8008
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
# BPRESI_FIELDS
Specifies the information  to be retrieved about the successful resolution of a breakpoint.  
  
## Syntax  
  
```cpp#  
enum enum_BPRESI_FIELDS {   
   BPRESI_BPRESLOCATION = 0x0001,  
   BPRESI_PROGRAM       = 0x0002,  
   BPRESI_THREAD        = 0x0004,  
   BPRESI_ALLFIELDS     = 0xffffffff  
};  
typedef DWORD BPRESI_FIELDS;  
```  
  
```c#  
public enum enum_BPRESI_FIELDS {   
   BPRESI_BPRESLOCATION = 0x0001,  
   BPRESI_PROGRAM       = 0x0002,  
   BPRESI_THREAD        = 0x0004,  
   BPRESI_ALLFIELDS     = 0xffffffff  
};  
```  
  
## Members  
 BPRESI_BPRESLOCATION  
 Initialize/use the `bpResLocation` (breakpoint resolution location) field of the [BP_RESOLUTION_INFO](../extensibility/bp_resolution_info.md) structure.  
  
 BPRESI_PROGRAM  
 Initialize/use the `pProgram` field of the `BP_RESOLUTION_INFO` structure.  
  
 BPRESI_THREAD  
 Initialize/use the `pThread` field of the `BP_RESOLUTION_INFO` structure.  
  
 BPRESI_ALLFIELDS  
 Specifies all fields.  
  
## Remarks  
 Passed to the [GetResolutionInfo](../extensibility/idebugbreakpointresolution2--getresolutioninfo.md) method to indicate which fields of the [BP_RESOLUTION_INFO](../extensibility/bp_resolution_info.md) structure are to be initialized.  
  
 These flags are also used to indicate which fields of the `BP_RESOLUTION_INFO` structure are used and valid when that structure is returned.  
  
 These values may be combined with a bitwise `OR`.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../extensibility/enumerations--visual-studio-debugging-.md)   
 [BP_RESOLUTION_INFO](../extensibility/bp_resolution_info.md)   
 [GetResolutionInfo](../extensibility/idebugbreakpointresolution2--getresolutioninfo.md)