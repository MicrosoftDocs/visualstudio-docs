---
title: "IEnumDebugAddresses::Clone | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IEnumDebugAddresses::Clone"
helpviewer_keywords: 
  - "IEnumDebugAddresses::Clone method"
ms.assetid: 71189a00-34eb-4c71-b96e-8bd6e70c6966
caps.latest.revision: 5
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IEnumDebugAddresses::Clone
This method returns a copy of the current enumeration as a separate object.  
  
## Syntax  
  
```cpp#  
HRESULT Clone(  
   IEnumDebugAddresses** ppEnum  
);  
```  
  
```c#  
int Clone(  
   out IEnumDebugAddresses ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns a copy of this enumeration as a separate object.  
  
## Property Value/Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The copy of the enumeration has the same state as the original at the time this method is called. However, the copy's and the original's states are separate and can be changed individually.  
  
## See Also  
 [IEnumDebugAddresses](../../../extensibility/debugger/reference/ienumdebugaddresses.md)