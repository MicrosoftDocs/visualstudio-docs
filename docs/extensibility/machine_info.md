---
title: "MACHINE_INFO"
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
  - "MACHINE_INFO"
helpviewer_keywords: 
  - "MACHINE_INFO structure"
ms.assetid: e7564ff2-00b5-4750-8fd5-dc1029a16912
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
# MACHINE_INFO
Describes a particular machine.  
  
## Syntax  
  
```cpp#  
typedef struct tagMACHINE_INFO {   
   MACHINE_INFO_FIELDS Fields;  
   BSTR                bstrName;  
   MACHINE_INFO_FLAGS  Flags;  
} MACHINE_INFO;  
```  
  
```c#  
public struct MACHINE_INFO {   
   public uint   Fields;  
   public string bstrName;  
   public uint   Flags;  
};  
```  
  
## Members  
 `Fields`  
 A combination of flags from the [MACHINE_INFO_FIELDS](../extensibility/machine_info_fields.md) enumeration that specify which fields of the structure are initialized.  
  
 `bstrName`  
 The machine name. Equivalent to calling [GetMachineName](../extensibility/idebugcoreserver2--getmachinename.md).  
  
 `Flags`  
 A combination of flags from the [MACHINE_INFO_FLAGS](../extensibility/machine_info_flags.md) enumeration describing the machine attributes.  
  
## Remarks  
 This structure is returned by a call to the [GetMachineInfo](../extensibility/idebugcoreserver2--getmachineinfo.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [MACHINE_INFO_FIELDS](../extensibility/machine_info_fields.md)   
 [GetMachineInfo](../extensibility/idebugcoreserver2--getmachineinfo.md)