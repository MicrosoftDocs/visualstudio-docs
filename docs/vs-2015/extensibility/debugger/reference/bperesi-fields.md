---
title: "BPERESI_FIELDS | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "BPERESI_FIELDS"
helpviewer_keywords: 
  - "BPERESI_FIELDS enumeration"
ms.assetid: dd7dd89c-1043-46a1-a929-099cc039c344
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# BPERESI_FIELDS
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Specifies the information to be retrieved about a failed resolution of a breakpoint.  
  
## Syntax  
  
```cpp#  
enum enum_BPERESI_FIELDS {   
   PERESI_BPRESLOCATION = 0x0001,  
   BPERESI_PROGRAM      = 0x0002,  
   BPERESI_THREAD       = 0x0004,  
   BPERESI_MESSAGE      = 0x0008,  
   BPERESI_TYPE         = 0x0010,  
   BPERESI_ALLFIELDS    = 0xffffffff  
};  
typedef DWORD BPERESI_FIELDS;  
```  
  
```csharp  
public enum enum_BPERESI_FIELDS {   
   PERESI_BPRESLOCATION = 0x0001,  
   BPERESI_PROGRAM      = 0x0002,  
   BPERESI_THREAD       = 0x0004,  
   BPERESI_MESSAGE      = 0x0008,  
   BPERESI_TYPE         = 0x0010,  
   BPERESI_ALLFIELDS    = 0xffffffff  
};  
```  
  
## Members  
 PERESI_BPRESLOCATION  
 Initialize/use the `bpResLocation` (breakpoint resolution location) field of the [BP_ERROR_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-error-resolution-info.md) structure.  
  
 BPERESI_PROGRAM  
 Initialize/use the `pProgram` field of the `BP_ERROR_RESOLUTION_INFO` structure.  
  
 BPERESI_THREAD  
 Initialize/use the `pThread` field of the `BP_ERROR_RESOLUTION_INFO` structure.  
  
 BPERESI_MESSAGE  
 Initialize/use the `bstrMessage` field of the `BP_ERROR_RESOLUTION_INFO` structure.  
  
 BPERESI_TYPE  
 Initialize/use the `dwType` (breakpoint type) field of the `BP_ERROR_RESOLUTION_INFO` structure.  
  
 BPERESI_ALLFIELDS  
 Initialize/use all fields of the `BP_ERROR_RESOLUTION_INFO` structure.  
  
## Remarks  
 Passed as a parameter to the [GetResolutionInfo](../../../extensibility/debugger/reference/idebugerrorbreakpointresolution2-getresolutioninfo.md) method to indicate which fields of the [BP_ERROR_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-error-resolution-info.md) structure are to be initialized.  
  
 These values are also used to indicate which fields in the `BP_ERROR_RESOLUTION_INFO` structure are used and valid when that structure is returned.  
  
 These values may be combined with a bitwise `OR`.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)   
 [BP_ERROR_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-error-resolution-info.md)   
 [GetResolutionInfo](../../../extensibility/debugger/reference/idebugerrorbreakpointresolution2-getresolutioninfo.md)
