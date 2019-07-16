---
title: "IDebugSymbolProvider::GetLanguage | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugSymbolProvider::GetLanguage"
helpviewer_keywords: 
  - "IDebugSymbolProvider::GetLanguage method"
ms.assetid: e4142183-3d8b-418f-907f-4ee4c753d8ce
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugSymbolProvider::GetLanguage
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method gets the language that was used to compile the code at the debug address.  
  
## Syntax  
  
```cpp#  
HRESULT GetLanguage(   
   IDebugAddress* pAddress,  
   GUID*          pguidLanguage,  
   GUID*          pguidLanguageVendor  
);  
```  
  
```csharp  
int GetLanguage(  
   IDebugAddress pAddress,   
   out Guid      pguidLanguage,   
   out Guid      pguidLanguageVendor  
);  
```  
  
#### Parameters  
 `pAddress`  
 [in] An address object represented by an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) interface.  
  
 `pguidLanguage`  
 [out] Returns a `GUID` that specifies the language.  
  
 `pguidLanguageVendor`  
 [out] Returns a `GUID` that specifies the language vendor.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The debug engine calls this method to obtain the information it needs to select the correct expression evaluator.  
  
## See Also  
 [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)   
 [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)
