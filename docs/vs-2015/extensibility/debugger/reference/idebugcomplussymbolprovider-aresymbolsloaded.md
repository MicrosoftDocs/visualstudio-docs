---
title: "IDebugComPlusSymbolProvider::AreSymbolsLoaded | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "AreSymbolsLoaded"
  - "IDebugComPlusSymbolProvider::AreSymbolsLoaded"
ms.assetid: bbf8707d-f89c-4177-b019-d519f1ec6f4a
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugComPlusSymbolProvider::AreSymbolsLoaded
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Determines if the debug symbols are loaded for the specified module given the application domain identifier.  
  
## Syntax  
  
```cpp#  
HRESULT AreSymbolsLoaded (  
   ULONG32 ulAppDomainID,  
   GUID    guidModule  
);  
```  
  
```csharp  
int AreSymbolsLoaded (  
   uint ulAppDomainID,  
   Guid guidModule  
);  
```  
  
#### Parameters  
 `ulAppDomainID`  
 [in] Identifier for the application domain.  
  
 `guidModule`  
 [in] Unique identifier for the module.  
  
## Return Value  
 If the debug symbols are loaded, returns `S_OK`; otherwise, returns `S_FALSE`.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md) interface.  
  
```cpp#  
HRESULT CDebugSymbolProvider::AreSymbolsLoaded(  
    ULONG32 ulAppDomainID,  
    GUID guidModule  
)  
{  
    HRESULT hr = S_OK;  
    CComPtr<CModule> pModule;  
    Module_ID idModule(ulAppDomainID, guidModule);  
  
    METHOD_ENTRY( CDebugSymbolProvider::AreSymbolsLoaded );  
  
    IfFalseGo( GetModule( idModule, &pModule ) == S_OK, S_FALSE );  
Error:  
  
    METHOD_EXIT( CDebugSymbolProvider::AreSymbolsLoaded, hr );  
    return hr;  
}  
```  
  
## See Also  
 [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md)
