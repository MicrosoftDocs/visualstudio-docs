---
title: "IDebugProgram2::Detach | Microsoft Docs"
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
  - "IDebugProgram2::Detach"
helpviewer_keywords: 
  - "IDebugProgram2::Detach"
ms.assetid: 5e8d88b0-a8d4-4746-88c0-ad332ee73f33
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugProgram2::Detach
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugProgram2::Detach](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugprogram2-detach).  
  
Detaches a debug engine from the program.  
  
## Syntax  
  
```cpp#  
HRESULT Detach(   
   void   
);  
```  
  
```csharp  
int Detach();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A detached program continues running, but it is no longer part of the debug session. No more program debug events are sent once the debug engine is detached.  
  
## See Also  
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)

