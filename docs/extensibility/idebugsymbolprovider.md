---
title: "IDebugSymbolProvider"
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
  - "IDebugSymbolProvider"
helpviewer_keywords: 
  - "IDebugSymbolProvider interface"
ms.assetid: df5f095f-1dee-46f9-84cf-92417c71d5fb
caps.latest.revision: 14
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
# IDebugSymbolProvider
This interface represents a symbol provider that provides symbols and types, returning them as fields.  
  
## Syntax  
  
```  
IDebugSymbolProvider : IUnknown  
```  
  
## Notes for Implementers  
 A symbol provider must implement this interface to supply symbol and type information to an expression evaluator.  
  
## Notes for Callers  
 This interface is obtained by using COM's `CoCreateInstance` function (for unmanaged symbol providers) or by loading the appropriate managed code assembly and instantiating the symbol provider based on the information found in that assembly. The debug engine instantiates the symbol provider to work in coordination with the expression evaluator. See the Example for one approach to instantiating this interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugSymbolProvider`.  
  
|Method|Description|  
|------------|-----------------|  
|`Initialize`|Deprecated. Do not use.|  
|`Uninitialize`|Deprecated. Do not use.|  
|[GetContainerField](../extensibility/idebugsymbolprovider--getcontainerfield.md)|Gets the field that contains the debug address.|  
|`GetField`|Deprecated. Do not use.|  
|[GetAddressesFromPosition](../extensibility/idebugsymbolprovider--getaddressesfromposition.md)|Maps a document position into an array of debug addresses.|  
|[GetAddressesFromContext](../extensibility/idebugsymbolprovider--getaddressesfromcontext.md)|Maps a document context into an array of debug addresses.|  
|[GetContextFromAddress](../extensibility/idebugsymbolprovider--getcontextfromaddress.md)|Maps a debug address into a document context.|  
|[GetLanguage](../extensibility/idebugsymbolprovider--getlanguage.md)|Gets the language used to compile the code at the debug address.|  
|`GetGlobalContainer`|Deprecated. Do not use.|  
|[GetMethodFieldsByName](../extensibility/idebugsymbolprovider--getmethodfieldsbyname.md)|Gets the field representing a fully qualified method name.|  
|[GetClassTypeByName](../extensibility/idebugsymbolprovider--getclasstypebyname.md)|Gets the class field type representing a fully qualified class name.|  
|[GetNamespacesUsedAtAddress](../extensibility/idebugsymbolprovider--getnamespacesusedataddress.md)|Creates an enumerator for namespaces associated with the debug address.|  
|[GetTypeByName](../extensibility/idebugsymbolprovider--gettypebyname.md)|Maps a symbol name to a symbol type.|  
|[GetNextAddress](../extensibility/idebugsymbolprovider--getnextaddress.md)|Gets the debug address that follows a given debug address in a method.|  
  
## Remarks  
 This interface maps document positions into debug addresses and vice versa.  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## Example  
 This example shows how to instantiate the symbol provider, given its GUID (a debug engine must know this value).  
  
```cpp#  
// A debug engine uses its own symbol provider and would know the GUID  
// of that provider.  
IDebugSymbolProvider *GetSymbolProvider(GUID *pSymbolProviderGuid)  
{  
    // This is typically defined globally.  For this example, it is  
    // defined here.  
    static const WCHAR strRegistrationRoot[] = L"Software\\Microsoft\\VisualStudio\\8.0Exp";  
    IDebugSymbolProvider *pProvider = NULL;  
    if (pSymbolProviderGuid != NULL) {  
        CLSID clsidProvider = { 0 };  
        ::GetSPMetric(*pSymbolProviderGuid,  
                      storetypeFile,  
                      metricCLSID,  
                      &clsidProvider,  
                      strRegistrationRoot);  
        if (IsEqualGUID(clsidProvider,GUID_NULL)) {  
            // No file type provider, try metadata provider.  
            ::GetSPMetric(*pSymbolProviderGuid,  
                          ::storetypeMetadata,  
                          metricCLSID,  
                          &clsidProvider,  
                          strRegistrationRoot);  
        }  
        if (!IsEqualGUID(clsidProvider,GUID_NULL)) {  
            CComPtr<IDebugSymbolProvider> spSymbolProvider;  
            spSymbolProvider.CoCreateInstance(clsidProvider);  
            if (spSymbolProvider != NULL) {  
                pProvider = spSymbolProvider.Detach();  
            }  
        }  
    }  
    return(pProvider);  
}  
```  
  
## See Also  
 [Symbol Provider Interfaces](../extensibility/symbol-provider-interfaces.md)