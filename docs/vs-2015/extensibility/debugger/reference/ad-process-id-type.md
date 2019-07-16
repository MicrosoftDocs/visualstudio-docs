---
title: "AD_PROCESS_ID_TYPE | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "AD_PROCESS_ID_TYPE"
helpviewer_keywords: 
  - "AD_PROCESS_ID_TYPE enumeration"
ms.assetid: 0aab80e9-285a-4697-94ac-c864d42a6aaa
caps.latest.revision: 7
ms.author: gregvanl
manager: jillfra
---
# AD_PROCESS_ID_TYPE
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Specifies how to interpret a process ID in the [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure.  
  
## Syntax  
  
```cpp#  
enum enum_AD_PROCESS_ID {  
   AD_PROCESS_ID_SYSTEM = 0,  
   AD_PROCESS_ID_GUID   = 1  
};  
typedef DWORD AD_PROCESS_ID_TYPE;  
```  
  
```csharp  
public enum enum_AD_PROCESS_ID {  
   AD_PROCESS_ID_SYSTEM = 0,  
   AD_PROCESS_ID_GUID   = 1  
};  
```  
  
## Members  
 AD_PROCESS_ID_SYSTEM  
 Process ID is a system identifier. Use the `ProcessId.dwProcessId` field of the [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure.  
  
 AD_PROCESS_ID_GUID  
 Process ID is a GUID. Use the `ProcessId.guidProcessId` field of the `AD_PROCESS_ID` structure.  
  
## Remarks  
 Used for the `ProcessIdType` member of the [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure to identify the type of process ID that is contained in the structure. Determines how to interpret the `ProcessId` union in the structure.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)   
 [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md)
