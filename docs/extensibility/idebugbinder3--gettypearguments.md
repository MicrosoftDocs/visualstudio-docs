---
title: "IDebugBinder3::GetTypeArguments"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugBinder3::GetTypeArguments"
helpviewer_keywords: 
  - "IDebugBinder3::GetTypeArguments method"
ms.assetid: fa0c37a7-327f-463e-9a9d-bb3f534584cb
caps.latest.revision: 7
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
# IDebugBinder3::GetTypeArguments
This method retrieves a list of argument types associated with this object.  
  
## Syntax  
  
```cpp  
HRESULT GetTypeArguments(  
   UINT          skip,  
   UINT          count,  
   IDebugField** ppFields,  
   UINT*         pFetched  
);  
```  
  
```c#  
int GetTypeArguments(  
   uint          skip,  
   uint          count,  
   IDebugField[] ppFields,  
   out uint      pFetched  
);  
```  
  
#### Parameters  
 `skip`  
 [in]Number of fields to skip before getting argument types.  
  
 `count`  
 [in] The number of argument fields to return (also specifies the size of the `ppFields` array).  
  
 `ppFields`  
 [in, out] An array of fields that will be filled in on return of this method.  
  
 `pFetched`  
 [out] (optional) The number of argument type fields actually returned.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The number of argument types can be obtained beforehand with [GetTypeArgumentCount](../extensibility/idebugbinder3--gettypeargumentcount.md).  
  
## See Also  
 [IDebugBinder3](../extensibility/idebugbinder3.md)   
 [GetTypeArgumentCount](../extensibility/idebugbinder3--gettypeargumentcount.md)