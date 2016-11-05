---
title: "IDebugReference2::SetValueAsString | Microsoft Docs"
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
  - "IDebugReference2::SetValueAsString"
helpviewer_keywords: 
  - "IDebugReference2::SetValueAsString"
ms.assetid: 9a508ced-fd54-44f5-bb42-ec15c80384d7
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
# IDebugReference2::SetValueAsString
Sets the value of a reference from a string. Reserved for future use.  
  
## Syntax  
  
```cpp#  
HRESULT SetValueAsString (   
   LPCOLESTR pszValue,  
   DWORD     dwRadix,  
   DWORD     dwTimeout  
);  
```  
  
```c#  
int SetValueAsString (   
   string pszValue,  
   uint   dwRadix,  
   uint   dwTimeout  
);  
```  
  
#### Parameters  
 `pszValue`  
 [in] The value as a string.  
  
 `dwRadix`  
 [in] The radix to be used in formatting any numerical information.  
  
 `dwTimeout`  
 [in] Maximum time, in milliseconds, to wait before returning from this method. Use `INFINITE` to wait indefinitely.  
  
## Return Value  
 Always returns `E_NOTIMPL`.  
  
## See Also  
 [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)