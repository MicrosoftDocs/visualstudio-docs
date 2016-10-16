---
title: "PROVIDER_PROCESS_DATA"
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
  - "PROVIDER_PROCESS_DATA"
helpviewer_keywords: 
  - "PROVIDER_PROCESS_DATA structure"
ms.assetid: ec2362ed-4a0c-4a09-9d66-8ff04e4f41ee
caps.latest.revision: 9
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
# PROVIDER_PROCESS_DATA
This structure provides information about processes running on a machine.  
  
## Syntax  
  
```cpp#  
typedef struct tagPROVIDER_PROCESS_DATA {  
   PROVIDER_FIELDS    Fields;  
   PROGRAM_NODE_ARRAY ProgramNodes;  
   BOOL               fIsDebuggerPresent;  
} PROVIDER_PROCESS_DATA;  
```  
  
```c#  
public struct PROVIDER_PROCESS_DATA {  
   public uint               Fields;  
   public PROGRAM_NODE_ARRAY ProgramNodes;  
   public int                fIsDebuggerPresent;  
}  
```  
  
## Members  
 Fields  
 A combination of flags from the [PROVIDER_FIELDS](../extensibility/provider_fields.md) enumeration, indicating which fields are filled in.  
  
 ProgramNodes  
 A [PROGRAM_NODE_ARRAY](../extensibility/program_node_array.md) structure that contains an array of program nodes.  
  
 fIsDebuggerPresent  
 Nonzero (`TRUE`) if the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] debugger is running, zero (`FALSE`) if it is not.  
  
## Remarks  
 This structure is passed to the [GetProviderProcessData](../extensibility/idebugprogramprovider2--getproviderprocessdata.md) method where it is filled in.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [PROVIDER_FIELDS](../extensibility/provider_fields.md)   
 [PROGRAM_NODE_ARRAY](../extensibility/program_node_array.md)   
 [GetProviderProcessData](../extensibility/idebugprogramprovider2--getproviderprocessdata.md)