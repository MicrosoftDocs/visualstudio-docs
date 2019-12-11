---
title: "IDebugBinder3::FindAlias | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugBinder3::FindAlias"
helpviewer_keywords: 
  - "IDebugBinder3::FindAlias method"
ms.assetid: b8333701-2718-4983-8513-0875fb7cb730
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugBinder3::FindAlias
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method locates an alias, given a name. This will search all aliases in the program.  
  
## Syntax  
  
```cpp  
HRESULT FindAlias(  
   LPCOLESTR     pcstrName,  
   IDebugAlias** ppAlias  
);  
```  
  
```csharp  
int FindAlias(  
   string          pcstrName,  
   out IDebugAlias ppAlias  
);  
```  
  
#### Parameters  
 `pcstrName`  
 [in] Name of alias to find.  
  
 `ppAlias`  
 [out] Alias found (if any) represented by the [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md) interface.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` (if alias is not found) or an error code.  
  
## Remarks  
 This method initializes the destination object to null before calling; then it tests for a null value afterward to determine whether or not the alias was found.  
  
## See Also  
 [IDebugBinder3](../../../extensibility/debugger/reference/idebugbinder3.md)   
 [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)
