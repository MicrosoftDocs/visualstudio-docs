---
title: "PROCESS_INFO_FLAGS | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "PROCESS_INFO_FLAGS"
helpviewer_keywords: 
  - "PROCESS_INFO_FLAGS enumeration"
ms.assetid: 696951ce-701a-40c2-ac8c-b897f3aae6e2
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
# PROCESS_INFO_FLAGS
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
  
```c#  
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
 Indicates that the process is being debugged by a debugger. It may be a [!INCLUDE[vsprvs](../../../code-quality/includes/vsprvs_md.md)] debugger, or it may be some other debugger, for example, WinDbg.  
  
 PIFLAG_PROCESS_STOPPED  
 Indicates the process is stopped. Valid only if `PIFLAG_DEBUGGER_ATTACHED` is also specified. Available in [!INCLUDE[vsprvslong](../../../code-quality/includes/vsprvslong_md.md)] and later.  
  
 PIFLAG_PROCESS_RUNNING  
 Indicates the process is running. Valid only if `PIFLAG_DEBUGGER_ATTACHED` is also specified. Available in [!INCLUDE[vsprvslong](../../../code-quality/includes/vsprvslong_md.md)] and later.  
  
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