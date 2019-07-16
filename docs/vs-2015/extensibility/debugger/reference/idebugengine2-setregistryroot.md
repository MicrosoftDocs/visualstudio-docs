---
title: "IDebugEngine2::SetRegistryRoot | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugEngine2::SetRegistryRoot"
helpviewer_keywords: 
  - "IDebugEngine2::SetRegistryRoot"
ms.assetid: d0d81202-8a4a-4bc3-b297-30a047c5ec60
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugEngine2::SetRegistryRoot
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Sets the registry root for the debug engine (DE).  
  
## Syntax  
  
```cpp#  
HRESULT SetRegistryRoot(   
   LPCOLESTR pszRegistryRoot  
);  
```  
  
```csharp  
int SetRegistryRoot(   
   string pszRegistryRoot  
);  
```  
  
#### Parameters  
 `pszRegistryRoot`  
 [in] The registry root to use.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method allows [!INCLUDE[vsprvs](../../../includes/vsprvs-md.md)] to specify an alternate registry root that the DE should use to obtain registry settings; for example, "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp".  
  
## See Also  
 [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
