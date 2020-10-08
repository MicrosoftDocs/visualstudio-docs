---
title: "IDebugProgramDestroyEvent2::GetExitCode | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgramDestroyEvent2::GetExitCode"
helpviewer_keywords: 
  - "IDebugProgramDestroyEvent2::GetExitCode"
ms.assetid: 7f540cf6-e2d1-42b0-913e-a26d654b7659
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugProgramDestroyEvent2::GetExitCode
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the program's exit code.  
  
## Syntax  
  
```cpp#  
HRESULT GetExitCode(   
   DWORD* pdwExit  
);  
```  
  
```csharp  
int GetExitCode(   
   out uint pdwExit  
);  
```  
  
#### Parameters  
 `pdwExit`  
 [out] Returns the program's exit code.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProgramDestroyEvent2](../../../extensibility/debugger/reference/idebugprogramdestroyevent2.md)
