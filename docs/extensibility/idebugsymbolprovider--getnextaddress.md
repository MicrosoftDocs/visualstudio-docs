---
title: "IDebugSymbolProvider::GetNextAddress"
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
  - "IDebugSymbolProvider::GetNextAddress"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetNextAddress method"
ms.assetid: 704eeb94-cb13-49d1-82b6-7d83ed0f19c0
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
# IDebugSymbolProvider::GetNextAddress
Gets the debug address that follows a given debug address in a method.  
  
## Syntax  
  
```cpp#  
HRESULT GetNextAddress(   
   IDebugAddress*  pAddress,  
   BOOL            fStatementOnly,  
   IDebugAddress** ppAddress  
);  
```  
  
```c#  
int GetNextAddress(   
   IDebugAddress     pAddress,  
   bool              fStatementOnly,  
   out IDebugAddress ppAddress  
);  
```  
  
#### Parameters  
 `pAddress`  
 [in] Given debug address.  
  
 `fStatementOnly`  
 [in] If TRUE, limits the debug addresses to a single statement.  
  
 `ppAddress`  
 [out] Returns the next debug address.  
  
## Return Value  
 Returns a valid `HRESULT`, typically S_OK.  
  
## See Also  
 [IDebugSymbolProvider](../extensibility/idebugsymbolprovider.md)