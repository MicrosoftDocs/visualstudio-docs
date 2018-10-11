---
title: "IEnumDebugCustomAttributes::Clone | Microsoft Docs"
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
  - "IEnumCustomAttributes::Clone"
helpviewer_keywords: 
  - "IEnumDebugCustomAttributes::Clone"
ms.assetid: e6825000-e195-42b4-b296-bfe1e533d79b
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
---
# IEnumDebugCustomAttributes::Clone
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IEnumDebugCustomAttributes::Clone](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/ienumdebugcustomattributes-clone).  
  
Creates an enumerator that contains the same enumeration state as the current enumerator.  
  
## Syntax  
  
```cpp#  
HRESULT Clone (   
   IEnumCustomAttributes** ppEnum  
);  
```  
  
```csharp  
int Clone(  
   out IEnumDebugCustomAttributes ppEnum  
);  
```  
  
#### Parameters  
 ppEnum  
 [out] Returns a copy of this enumeration as a separate object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The copy of the enumeration has the same state as the original at the time this method is called. However, the copy's and the original's states are separate and can be changed individually.  
  
## See Also  
 [IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md)

