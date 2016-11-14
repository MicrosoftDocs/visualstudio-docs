---
title: "IDebugFunctionPosition2::GetFunctionName | Microsoft Docs"
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
  - "IDebugFunctionPosition2::GetFunctionName"
helpviewer_keywords: 
  - "IDebugFunctionPosition2::GetFunctionName"
ms.assetid: eb7a348e-a7f5-4f25-be68-80482d5482a8
caps.latest.revision: 13
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
# IDebugFunctionPosition2::GetFunctionName
Gets the name of the function to which this position points.  
  
## Syntax  
  
```cpp#  
HRESULT GetFunctionName(   
   BSTR* pbstrFunctionName  
);  
```  
  
```c#  
int GetFunctionName(  
   out string pbstrFunctionName  
);  
```  
  
#### Parameters  
 `pbstrFunctionName`  
 [out] Returns the name of the function.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugFunctionPosition2](../../../extensibility/debugger/reference/idebugfunctionposition2.md)