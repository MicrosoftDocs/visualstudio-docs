---
title: "IDebugProcessSecurity::QueryCanSafelyAttach | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugProcessSecurity::QueryCanSafelyAttach"
ms.assetid: 63ec1ae8-27da-4574-aa15-1c986fe9fe58
caps.latest.revision: 5
ms.author: gregvanl
manager: jillfra
---
# IDebugProcessSecurity::QueryCanSafelyAttach
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method allows the port supplier to display a warning before the user attaches to an unsafe process.  
  
## Syntax  
  
```cpp#  
HRESULT QueryCanSafelyAttach();  
```  
  
```csharp  
int QueryCanSafelyAttach();  
```  
  
## Return Value  
 The return values are as follows:  
  
- `S_OK`: Attaching to process is safe and no warning dialog box is shown.  
  
- `S_FALSE`: Attaching could be a security problem and a dialog box with a warning is shown.  
  
- `FAILURE`: Attaching to process fails.  
  
## See Also  
 [IDebugProcessSecurity](../../../extensibility/debugger/reference/idebugprocesssecurity.md)
