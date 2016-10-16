---
title: "IDebugSymbolProvider::GetAddressesFromContext"
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
  - "IDebugSymbolProvider::GetAddressesFromContext"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetAddressesFromContext method"
ms.assetid: a3124883-a255-4543-a5ec-e1c7a97beb69
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
# IDebugSymbolProvider::GetAddressesFromContext
This method maps a document context into an array of debug addresses.  
  
## Syntax  
  
```cpp#  
HRESULT GetAddressesFromContext(   
   IDebugDocumentContext2* pDocContext,  
   BOOL                    fStatmentOnly,  
   IEnumDebugAddresses**   ppEnumBegAddresses,  
   IEnumDebugAddresses**   ppEnumEndAddresses  
);  
```  
  
```c#  
int GetAddressesFromContext(  
   IDebugDocumentContext2  pDocContext,  
   bool                    fStatmentOnly,  
   out IEnumDebugAddresses ppEnumBegAddresses,  
   out IEnumDebugAddresses ppEnumEndAddresses  
);  
```  
  
#### Parameters  
 `pDocContext`  
 [in] The document context.  
  
 `fStatmentOnly`  
 [in] If TRUE, limits the debug addresses to a single statement.  
  
 `ppEnumBegAddresses`  
 [out] Returns an enumerator for the starting debug addresses associated with this statement or line.  
  
 `ppEnumEndAddresses`  
 [out] Returns an [IEnumDebugAddresses](../extensibility/ienumdebugaddresses.md) enumerator for the ending debug addresses associated with this statement or line.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A document context typically indicates a range of source lines. This method provides the starting and ending debug addresses associated with these lines. Some languages allow statements that span multiple lines, or lines that contains more than one statement. This method provides a flag to limit the debug addresses to a single statement.  
  
 It is possible for a single statement to have multiple debug addresses, as in the case of templates.  
  
## See Also  
 [IDebugSymbolProvider](../extensibility/idebugsymbolprovider.md)   
 [GetAddressesFromPosition](../extensibility/idebugsymbolprovider--getaddressesfromposition.md)   
 [IEnumDebugAddresses](../extensibility/ienumdebugaddresses.md)