---
title: "MACHINE_INFO_FLAGS | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "MACHINE_INFO_FLAGS"
helpviewer_keywords: 
  - "MACHINE_INFO_FLAGS enumeration"
ms.assetid: 1482095d-9a2e-4ef1-9e14-362c0b85194e
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# MACHINE_INFO_FLAGS
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [MACHINE_INFO_FLAGS](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/machine-info-flags).  
  
Used to describe a machine.  
  
## Syntax  
  
```cpp#  
enum enum_MACHINE_INFO_FLAGS {   
   MCIFLAG_TERMINAL_SERVICES_AVAILABLE = 0x00000001  
};  
typedef DWORD MACHINE_INFO_FLAGS;  
```  
  
```csharp  
public enum enum_MACHINE_INFO_FLAGS {   
   MCIFLAG_TERMINAL_SERVICES_AVAILABLE = 0x00000001  
};  
```  
  
## Members  
 MCIFLAG_TERMINAL_SERVICES_AVAILABLE  
 Indicates that terminal services are available.  
  
## Remarks  
 Used as the `Flags` member of the [MACHINE_INFO](../../../extensibility/debugger/reference/machine-info.md) structure.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)   
 [MACHINE_INFO_FIELDS](../../../extensibility/debugger/reference/machine-info-fields.md)

