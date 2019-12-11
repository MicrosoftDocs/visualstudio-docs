---
title: "IDebugObject2::IsUserData | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugObject2::IsUserData"
helpviewer_keywords: 
  - "IDebugObject2::IsUserData method"
ms.assetid: 6ffa0d0e-f742-496d-acc7-db74c248bc45
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# IDebugObject2::IsUserData
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Determines whether the object represents user data.  
  
## Syntax  
  
```cpp  
HRESULT IsUserData(  
   BOOL* pfUser  
);  
```  
  
```csharp  
int IsUserData(  
   out int pfUser  
);  
```  
  
#### Parameters  
 `pfUser`  
 [out] Returns nonzero (`TRUE`) if the object represents user data; zero (`FALSE`) if it does not.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 User data is any object that is part of a module designated as JustMyCode (a user-configurable option that marks a module as user code and therefore visible in a stack trace).  
  
## See Also  
 [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)
