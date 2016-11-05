---
title: "IDebugOutputStringEvent2::GetString | Microsoft Docs"
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
  - "IDebugOutputStringEvent2::GetString"
helpviewer_keywords: 
  - "IDebugOutputStringEvent2::GetString"
ms.assetid: f059f8e0-ad44-49ac-ba90-73576ada5e06
caps.latest.revision: 10
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
# IDebugOutputStringEvent2::GetString
Gets the displayable message.  
  
## Syntax  
  
```cpp#  
HRESULT GetString(   
   BSTR* pbstrString  
);  
```  
  
```c#  
int GetString(   
   out string pbstrString  
);  
```  
  
#### Parameters  
 `pbstrString`  
 [out] Returns the displayable message.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugOutputStringEvent2](../../../extensibility/debugger/reference/idebugoutputstringevent2.md)