---
title: "IDebugSymbolProviderDirect::GetSymUnmanagedReader | Microsoft Docs"
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
  - "GetSymUnmanagedReader"
  - "IDebugSymbolProviderDirect::GetSymUnmanagedReader"
ms.assetid: 147bacfa-f66c-43e0-8a72-e601058dc57f
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
# IDebugSymbolProviderDirect::GetSymUnmanagedReader
Retrieves a symbol reader for unmanaged code.  
  
## Syntax  
  
```cpp#  
HRESULT GetSymUnmanagedReader (  
   ULONG32    ulAppDomainID,  
   GUID       guidModule,  
   IUnknown** ppSymUnmanagedReader  
);  
```  
  
```c#  
int GetSymUnmanagedReader (  
   uint       ulAppDomainID,  
   Guid       guidModule,  
   out object ppSymUnmanagedReader  
);  
```  
  
#### Parameters  
 `ulAppDomainID`  
 [in] Identifier of the application domain.  
  
 `guidModule`  
 [in] Unique identifier of the module.  
  
 `ppSymUnmanagedReader`  
 [out] Returns an object that represents the symbol reader for unmanaged code.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugSymbolProviderDirect](../../../extensibility/debugger/reference/idebugsymbolproviderdirect.md)