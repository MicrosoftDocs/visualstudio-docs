---
title: "IEnumDebugCodeContexts2::Reset | Microsoft Docs"
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
  - "IEnumDebugCodeContexts2::Reset"
helpviewer_keywords: 
  - "IEnumDebugCodeContexts2::Reset"
ms.assetid: df6cf1e3-2ef8-4d38-81a0-8e9adf151884
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IEnumDebugCodeContexts2::Reset
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IEnumDebugCodeContexts2::Reset](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/ienumdebugcodecontexts2-reset).  
  
Resets the enumeration to the first element.  
  
## Syntax  
  
```cpp#  
HRESULT Reset(  
   void  
);  
```  
  
```csharp  
int Reset();  
```  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 After this method is called, the next call to the [Next](../../../extensibility/debugger/reference/ienumdebugcodecontexts2-next.md) method returns the first element of the enumeration.  
  
## See Also  
 [IEnumDebugCodeContexts2](../../../extensibility/debugger/reference/ienumdebugcodecontexts2.md)

