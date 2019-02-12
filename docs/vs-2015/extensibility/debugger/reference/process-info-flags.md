---
title: "PROCESS_INFO_FLAGS | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "PROCESS_INFO_FLAGS"
helpviewer_keywords: 
  - "PROCESS_INFO_FLAGS enumeration"
ms.assetid: 696951ce-701a-40c2-ac8c-b897f3aae6e2
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# PROCESS_INFO_FLAGS
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Describes or specifies properties of a process.  
  
## Syntax  
  
```cpp#  
enum enum_PROCESS_INFO_FLAGS {   
   PIFLAG_SYSTEM_PROCESS    = 0x00000001,  
   PIFLAG_DEBUGGER_ATTACHED = 0x00000002,  
   PIFLAG_PROCESS_STOPPED   = 0x00000004,  
   PIFLAG_PROCESS_RUNNING   = 0x00000008,  
};  
typedef DWORD PROCESS_INFO_FLAGS;  
```  
  
```csharp  
enum enum_PROCESS_INFO_FLAGS {   
   PIFLAG_SYSTEM_PROCESS    = 0x00000001,  
   PIFLAG_DEBUGGER_ATTACHED = 0x00000002,  
   PIFLAG_PROCESS_STOPPED   = 0x00000004,  
   PIFLAG_PROCESS_RUNNING   = 0x00000008,  
};  
```  
  
## Members  
 PIFLAG_SYSTEM_PROCESS  
 Indicates that the process is a system process.  
  
 PIFLAG_DEBUGGER_ATTACHED  
 Indicates that the process is being debugged by a debugger. It may be a [!INCLUDE[vsprvs](../../../includes/vsprvs-md.md)] debugger, or it may be some other debugger, for example, WinDbg.  
  
 PIFLAG_PROCESS_STOPPED  
 Indicates the process is stopped. Valid only if `PIFLAG_DEBUGGER_ATTACHED` is also specified. Available in [!INCLUDE[vsprvslong](../../../includes/vsprvslong-md.md)] and later.  
  
 PIFLAG_PROCESS_RUNNING  
 Indicates the process is running. Valid only if `PIFLAG_DEBUGGER_ATTACHED` is also specified. Available in [!INCLUDE[vsprvslong](../../../includes/vsprvslong-md.md)] and later.  
  
## Remarks  
 Used for the `Flags` member of the [PROCESS_INFO](../../../extensibility/debugger/reference/process-info.md) structure.  
  
 These flags may be combined with a bitwise `OR`.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)   
 [PROCESS_INFO](../../../extensibility/debugger/reference/process-info.md)
