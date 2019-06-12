---
title: "IDebugAlias::GetName | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugAlias::GetName"
helpviewer_keywords: 
  - "IDebugAlias::GetName method"
ms.assetid: ac2d8891-56b5-40ef-9866-ed74f18bb043
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugAlias::GetName
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the name of this alias.  
  
## Syntax  
  
```cpp  
HRESULT GetName(  
   BSTR* pbstrName  
);  
```  
  
```csharp  
int GetName(  
   out string pbstrName  
);  
```  
  
#### Parameters  
 `pbstrName`  
 [out] Name of the alias.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## See Also  
 [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)
