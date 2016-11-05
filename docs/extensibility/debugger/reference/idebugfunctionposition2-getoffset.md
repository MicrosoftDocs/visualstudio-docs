---
title: "IDebugFunctionPosition2::GetOffset | Microsoft Docs"
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
  - "IDebugFunctionPosition2::GetOffset"
helpviewer_keywords: 
  - "IDebugFunctionPosition2::GetOffset"
ms.assetid: 60943782-aec7-4be2-b222-1984ed53a543
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
# IDebugFunctionPosition2::GetOffset
Retrieves the position of the function in the source document.  
  
## Syntax  
  
```cpp#  
HRESULT GetOffset(   
   TEXT_POSITION* pPosition  
);  
```  
  
```c#  
int GetOffset(  
   TEXT_POSITION[] pPosition  
);  
```  
  
#### Parameters  
 `pPosition`  
 [in, out] A [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) structure that is filled in with the position of the function in a document.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugFunctionPosition2](../../../extensibility/debugger/reference/idebugfunctionposition2.md)   
 [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md)