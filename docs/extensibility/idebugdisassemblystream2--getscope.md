---
title: "IDebugDisassemblyStream2::GetScope"
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
  - "IDebugDisassemblyStream2::GetScope"
helpviewer_keywords: 
  - "IDebugDisassemblyStream2::GetScope"
ms.assetid: 71c6e632-642a-42d8-a995-77e4ac190a5b
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
# IDebugDisassemblyStream2::GetScope
Gets the scope of the disassembly stream.  
  
## Syntax  
  
```cpp#  
HRESULT GetScope(   
   DISASSEMBLY_STREAM_SCOPE* pdwScope  
);  
```  
  
```c#  
int GetScope(   
   out enum_ DISASSEMBLY_STREAM_SCOPE pdwScope  
);  
```  
  
#### Parameters  
 `pdwScope`  
 [out] Returns a value from the [DISASSEMBLY_STREAM_SCOPE](../extensibility/disassembly_stream_scope.md) enumeration that describes the scope of this disassembly stream.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The scope of a disassembly could be a function or the whole module, for example.  
  
## See Also  
 [IDebugDisassemblyStream2](../extensibility/idebugdisassemblystream2.md)   
 [DISASSEMBLY_STREAM_SCOPE](../extensibility/disassembly_stream_scope.md)