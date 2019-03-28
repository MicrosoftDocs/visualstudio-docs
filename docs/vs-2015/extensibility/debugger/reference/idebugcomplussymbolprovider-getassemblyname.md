---
title: "IDebugComPlusSymbolProvider::GetAssemblyName | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugComPlusSymbolProvider::GetAssemblyName"
  - "GetAssemblyName"
ms.assetid: a08cd609-b9b9-47bd-bf73-cbf851285907
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugComPlusSymbolProvider::GetAssemblyName
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves the name of the assembly given its module and application domain.  
  
## Syntax  
  
```  
[C++]  
HRESULT GetAssemblyName(  
   ULONG32 ulAppDomainID,  
   GUID    guidModule,  
   BSTR*   pbstrName  
);  
```  
  
```  
[C#]  
int GetAssemblyName(  
   uint   ulAppDomainID,  
   Guid   guidModule,  
   string pbstrName  
);  
```  
  
#### Parameters  
 `ulAppDomainID`  
 [in] Identifier for the application domain.  
  
 `guidModule`  
 [in] Unique identifier for the module.  
  
 `pbstrName`  
 [out] Returns the name of the assembly.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a **CDebugSymbolProvider** object that exposes the [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md) interface.  
  
```cpp#  
HRESULT CDebugSymbolProvider::GetAssemblyName(  
    ULONG32 ulAppDomainID,  
    GUID guidModule,  
    BSTR* pbstrName  
)  
{  
    HRESULT hr = S_OK;  
    Module_ID idModule(ulAppDomainID, guidModule);  
    CComPtr<IMetaDataImport> pMetadata;  
  
    METHOD_ENTRY( CDebugSymbolProvider::GetMetadataForModule );  
  
    IfFalseGo( pbstrName, E_INVALIDARG );  
    *pbstrName = NULL;  
  
    IfFailGo( GetMetadata( idModule, &pMetadata ) );  
    IfFailGo( GetAssemblyName( pMetadata, 0, pbstrName ) );  
  
Error:  
  
    METHOD_EXIT( CDebugSymbolProvider::GetMetadataForModule, hr );  
    return hr;  
}  
```  
  
## See Also  
 [IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md)
