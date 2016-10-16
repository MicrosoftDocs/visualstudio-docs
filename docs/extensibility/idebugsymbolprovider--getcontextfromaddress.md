---
title: "IDebugSymbolProvider::GetContextFromAddress"
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
  - "IDebugSymbolProvider::GetContextFromAddress"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetContextFromAddress method"
ms.assetid: 7a27d56f-20d4-4e5c-af7b-7307d3aff0a1
caps.latest.revision: 11
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
# IDebugSymbolProvider::GetContextFromAddress
This method maps a debug address into a document context.  
  
## Syntax  
  
```cpp#  
HRESULT GetContextFromAddress(   
   IDebugAddress*           pAddress,  
   IDebugDocumentContext2** ppDocContext  
);  
```  
  
```c#  
int GetContextFromAddress(  
   IDebugAddress              pAddress,   
   out IDebugDocumentContext2 ppDocContext  
);  
```  
  
#### Parameters  
 `pAddress`  
 [in] The debug address as represented by an [IDebugAddress](../extensibility/idebugaddress.md) interface.  
  
 `ppDocContext`  
 [out] Returns a document context as represented by an [IDebugDocumentContext2](../extensibility/idebugdocumentcontext2.md) interface.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugSymbolProvider](../extensibility/idebugsymbolprovider.md)   
 [IDebugAddress](../extensibility/idebugaddress.md)   
 [IDebugDocumentContext2](../extensibility/idebugdocumentcontext2.md)