---
title: "IDebugFunctionObject2::CreateStringObjectWithLength | Microsoft Docs"
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
  - "CreateStringObjectWithLength"
  - "IDebugFunctionObject2::CreateStringObjectWithLength"
ms.assetid: 1f43ec66-1615-4a4c-8b9d-e933f549f96d
caps.latest.revision: 9
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
# IDebugFunctionObject2::CreateStringObjectWithLength
Creates a string object that has the specified length.  
  
## Syntax  
  
```cpp#  
HRESULT CreateStringObjectWithLength (  
   LPCOLESTR      pcstrString,  
   UINT           uiLength,  
   IDebugObject** ppObject  
);  
```  
  
```c#  
int CreateStringObjectWithLength (  
   string           pcstrString,  
   uint             uiLength,  
   out IDebugObject ppObject  
);  
```  
  
#### Parameters  
 `pcstrString`  
 [in] The string value for the string object.  
  
 `uiLength`  
 [in] The length of the string in bytes.  
  
 `ppObject`  
 [out] Returns an [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object that represents the newly created string object.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugFunctionObject2](../../../extensibility/debugger/reference/idebugfunctionobject2.md)