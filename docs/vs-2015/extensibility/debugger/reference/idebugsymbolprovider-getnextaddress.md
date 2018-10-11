---
title: "IDebugSymbolProvider::GetNextAddress | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugSymbolProvider::GetNextAddress"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetNextAddress method"
ms.assetid: 704eeb94-cb13-49d1-82b6-7d83ed0f19c0
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugSymbolProvider::GetNextAddress
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

  
Gets the debug address that follows a given debug address in a method.  
  
## Syntax  
  
```cpp#  
HRESULT GetNextAddress(   
   IDebugAddress*  pAddress,  
   BOOL            fStatementOnly,  
   IDebugAddress** ppAddress  
);  
```  
  
```csharp  
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
 [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)

