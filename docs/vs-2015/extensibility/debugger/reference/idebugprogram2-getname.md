---
title: "IDebugProgram2::GetName | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugProgram2::GetName"
helpviewer_keywords: 
  - "IDebugProgram2::GetName"
ms.assetid: a54cbf13-b3e3-4c9f-8b8d-13573232dfb0
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugProgram2::GetName
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugProgram2::GetName](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugprogram2-getname).  
  
Gets the name of the program.  
  
## Syntax  
  
```cpp#  
HRESULT GetName(   
   BSTR* pbstrName  
);  
```  
  
```csharp  
int GetName(   
   out string pbstrName  
);  
```  
  
#### Parameters  
 `pbstrName`  
 [out] Returns the name of the program.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The name returned by this method is always a friendly, user-displayable name that describes the program.  
  
## See Also  
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)

