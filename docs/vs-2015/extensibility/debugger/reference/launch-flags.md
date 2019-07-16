---
title: "LAUNCH_FLAGS | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "LAUNCH_FLAGS"
helpviewer_keywords: 
  - "LAUNCH_FLAGS enumeration"
ms.assetid: f51aab02-d257-4302-bb79-b7d8ba9ac4e5
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# LAUNCH_FLAGS
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Specifies the debug launch flags.  
  
## Syntax  
  
```cpp#  
enum enum_LAUNCH_FLAGS {   
   LAUNCH_DEBUG      = 0x0000,  
   LAUNCH_NODEBUG    = 0x0001,  
   LAUNCH_ENABLE_ENC = 0x0002,  
   LAUNCH_MERGE_ENV  = 0x0004  
};  
typedef DWORD LAUNCH_FLAGS;  
```  
  
```csharp  
public enum enum_LAUNCH_FLAGS {   
   LAUNCH_DEBUG      = 0x0000,  
   LAUNCH_NODEBUG    = 0x0001,  
   LAUNCH_ENABLE_ENC = 0x0002,  
   LAUNCH_MERGE_ENV  = 0x0004  
};  
```  
  
## Members  
 LAUNCH_DEBUG  
 Launches the process for debugging.  
  
 LAUNCH_NODEBUG  
 Launches the process without debugging it.  
  
 LAUNCH_ENABLE_ENC  
 DEPRECATED, DO NOT USE.  
  
 LAUNCH_MERGE_ENV  
 Launches the process and merges the environment with the launching host.  
  
## Remarks  
 These values are passed as an argument to the [LaunchSuspended](../../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md) method.  
  
 These flags may be combined with a bitwise `OR`.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)   
 [LaunchSuspended](../../../extensibility/debugger/reference/idebugenginelaunch2-launchsuspended.md)
