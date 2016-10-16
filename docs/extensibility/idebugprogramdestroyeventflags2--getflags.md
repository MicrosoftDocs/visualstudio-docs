---
title: "IDebugProgramDestroyEventFlags2::GetFlags"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "GetFlags"
  - "IDebugProgramDestroyEventFlags2::GetFlags"
ms.assetid: dd53bd0c-459a-4077-ba81-780defb71e87
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
# IDebugProgramDestroyEventFlags2::GetFlags
Retrieves the program destroy flags.  
  
## Syntax  
  
```cpp#  
HRESULT GetFlags(  
   PROGRAM_DESTROY_FLAGS* pdwFlags  
);  
```  
  
```c#  
public int GetFlags(  
   out enum_PROGRAM_DESTROY_FLAGS pdwFlags  
);  
```  
  
#### Parameters  
 `pdwFlags`  
 [out] Represents the program destroy flags.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProgramDestroyEventFlags2](../extensibility/idebugprogramdestroyeventflags2.md)   
 [PROGRAM_DESTROY_FLAGS](../extensibility/program_destroy_flags.md)