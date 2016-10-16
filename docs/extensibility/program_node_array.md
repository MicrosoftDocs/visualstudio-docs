---
title: "PROGRAM_NODE_ARRAY"
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
  - "PROGRAM_NODE_ARRAY"
helpviewer_keywords: 
  - "PROGRAM_NODE_ARRAY structure"
ms.assetid: 8eeea600-eda5-4b7c-868a-0b86d177b0a5
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
# PROGRAM_NODE_ARRAY
Contains an array of objects that describe programs of interest.  
  
## Syntax  
  
```cpp  
typedef struct tagPROGRAM_NODE_ARRAY {  
   DWORD                dwCount;  
   IDebugProgramNode2** Members;  
} PROGRAM_NODE_ARRAY;  
```  
  
```c#  
public struct tagPROGRAM_NODE_ARRAY {  
   public uint                 dwCount;  
   public IDebugProgramNode2[] Members;  
}  
```  
  
## Members  
 dwCount  
 Number of objects in the `Members` array.  
  
 Members  
 An array of [IDebugProgramNode2](../extensibility/idebugprogramnode2.md) objects describing the programs requested.  
  
## Remarks  
 This structure is part of the [PROVIDER_PROCESS_DATA](../extensibility/provider_process_data.md) structure which in turn is filled in by a call to the [GetProviderProcessData](../extensibility/idebugprogramprovider2--getproviderprocessdata.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [PROVIDER_PROCESS_DATA](../extensibility/provider_process_data.md)   
 [IDebugProgramNode2](../extensibility/idebugprogramnode2.md)   
 [GetProviderProcessData](../extensibility/idebugprogramprovider2--getproviderprocessdata.md)