---
title: "AD_PROCESS_ID_TYPE"
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
  - "AD_PROCESS_ID_TYPE"
helpviewer_keywords: 
  - "AD_PROCESS_ID_TYPE enumeration"
ms.assetid: 0aab80e9-285a-4697-94ac-c864d42a6aaa
caps.latest.revision: 6
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
# AD_PROCESS_ID_TYPE
Specifies how to interpret a process ID in the [AD_PROCESS_ID](../extensibility/ad_process_id.md) structure.  
  
## Syntax  
  
```cpp#  
enum enum_AD_PROCESS_ID {  
   AD_PROCESS_ID_SYSTEM = 0,  
   AD_PROCESS_ID_GUID   = 1  
};  
typedef DWORD AD_PROCESS_ID_TYPE;  
```  
  
```c#  
public enum enum_AD_PROCESS_ID {  
   AD_PROCESS_ID_SYSTEM = 0,  
   AD_PROCESS_ID_GUID   = 1  
};  
```  
  
## Members  
 AD_PROCESS_ID_SYSTEM  
 Process ID is a system identifier. Use the `ProcessId.dwProcessId` field of the [AD_PROCESS_ID](../extensibility/ad_process_id.md) structure.  
  
 AD_PROCESS_ID_GUID  
 Process ID is a GUID. Use the `ProcessId.guidProcessId` field of the `AD_PROCESS_ID` structure.  
  
## Remarks  
 Used for the `ProcessIdType` member of the [AD_PROCESS_ID](../extensibility/ad_process_id.md) structure to identify the type of process ID that is contained in the structure. Determines how to interpret the `ProcessId` union in the structure.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../extensibility/enumerations--visual-studio-debugging-.md)   
 [AD_PROCESS_ID](../extensibility/ad_process_id.md)