---
title: "CONST_GUID_ARRAY"
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
  - "CONST_GUID_ARRAY"
helpviewer_keywords: 
  - "CONST_GUID_ARRAY structure"
ms.assetid: bd55e7d8-372c-4c3e-9eed-28f6b415a5db
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
# CONST_GUID_ARRAY
A structure that holds a list of `GUID`s.  
  
## Syntax  
  
```cpp#  
typedef struct tagCONST_GUID_ARRAY {  
   DWORD       dwCount;  
   CONST GUID* Members;  
} CONST_GUID_ARRAY;  
```  
  
```c#  
public struct CONST_GUID_ARRAY {  
   public uint   dwCount;  
   public Guid[] Members;  
}  
```  
  
## Members  
 dwCount  
 Number of `GUID`s in the `Members` array.  
  
 Members  
 Array of `GUID`s.  
  
## Remarks  
 This structure is passed to the [PublishProgram](../extensibility/idebugprogrampublisher2--publishprogram.md) method, and is returned from the [GetProviderProcessData](../extensibility/idebugprogramprovider2--getproviderprocessdata.md) and [WatchForProviderEvents](../extensibility/idebugprogramprovider2--watchforproviderevents.md) methods.  
  
 The owner of an instance of this structure is responsible for freeing any memory allocated.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../extensibility/structures-and-unions.md)   
 [PublishProgram](../extensibility/idebugprogrampublisher2--publishprogram.md)   
 [GetProviderProcessData](../extensibility/idebugprogramprovider2--getproviderprocessdata.md)   
 [WatchForProviderEvents](../extensibility/idebugprogramprovider2--watchforproviderevents.md)