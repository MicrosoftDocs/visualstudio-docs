---
title: "BP_TYPE"
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
  - "BP_TYPE"
helpviewer_keywords: 
  - "BP_TYPE enumeration"
ms.assetid: ef07191e-7966-43ab-96fb-1a0b1db3115d
caps.latest.revision: 10
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
# BP_TYPE
Specifies whether the breakpoint is at a code location, is a data location, or is another type of breakpoint.  
  
## Syntax  
  
```cpp#  
enum enum_BP_TYPE {   
   BPT_NONE    = 0x0000,  
   BPT_CODE    = 0x0001,  
   BPT_DATA    = 0x0002,  
   BPT_SPECIAL = 0x0003  
};  
typedef DWORD BP_TYPE;  
```  
  
```c#  
public enum enum_BP_TYPE {   
   BPT_NONE    = 0x0000,  
   BPT_CODE    = 0x0001,  
   BPT_DATA    = 0x0002,  
   BPT_SPECIAL = 0x0003  
};  
```  
  
## Members  
 BPT_NONE  
 Specifies no breakpoint type.  
  
 BPT_CODE  
 Specifies a code breakpoint.  
  
 BPT_DATA  
 Specifies a data breakpoint.  
  
 BPT_SPECIAL  
 Specifies a breakpoint that is neither a code nor a data type. This type is deprecated and should not be used.  
  
## Remarks  
 Passed as a parameter to the [GetBreakpointType](../extensibility/idebugbreakpointresolution2--getbreakpointtype.md) and [GetBreakpointType](../extensibility/idebugerrorbreakpointresolution2--getbreakpointtype.md) methods.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../extensibility/enumerations--visual-studio-debugging-.md)   
 [GetBreakpointType](../extensibility/idebugbreakpointresolution2--getbreakpointtype.md)   
 [GetBreakpointType](../extensibility/idebugerrorbreakpointresolution2--getbreakpointtype.md)