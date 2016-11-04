---
title: "IDebugGenericFieldInstance::TypeArgumentCount | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "TypeArgumentCount"
  - "IDebugGenericFieldInstance::TypeArgumentCount"
ms.assetid: e662c5ea-a5c1-478e-a268-5980dadffcd1
caps.latest.revision: 8
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
# IDebugGenericFieldInstance::TypeArgumentCount
Returns the number of type parameter arguments for this instance.  
  
## Syntax  
  
```cpp#  
HRESULT TypeArgumentCount(  
   ULONG32* pcArgs  
);  
```  
  
```c#  
int TypeArgumentCount(  
   ref uint pcArgs  
);  
```  
  
#### Parameters  
 `pcArgs`  
 [in, out] Number of type parameter arguments for this instance.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 For example, if List\<int>, this method returns 1, and, if List\<int,float2> this method returns 2. This method returns 0 if there are no type arguments.  
  
## See Also  
 [IDebugGenericFieldInstance](../../../extensibility/debugger/reference/idebuggenericfieldinstance.md)