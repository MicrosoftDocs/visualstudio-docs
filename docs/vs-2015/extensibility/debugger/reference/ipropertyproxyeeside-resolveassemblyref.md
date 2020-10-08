---
title: "IPropertyProxyEESide::ResolveAssemblyRef | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IPropertyProxyEESide::ResolveAssemblyRef"
helpviewer_keywords: 
  - "IPropertyProxyEESide::ResolveAssemblyRef"
ms.assetid: 662ca0a6-dad0-4c00-a718-bb3bbc5bd9da
caps.latest.revision: 13
ms.author: gregvanl
manager: jillfra
---
# IPropertyProxyEESide::ResolveAssemblyRef
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Determines the location of the specified managed assembly reference.  
  
## Syntax  
  
```cpp#  
HRESULT ResolveAssemblyRef(  
   BSTR*                  assemName,  
   IEEDataStorage**       assemBytes,  
   IEEDataStorage**       assemPdb,  
   BSTR*                  assemLocation,  
   ASSEMBLYLOCRESOLUTION* alr  
);  
```  
  
```csharp  
int ResolveAssemblyRef(  
   ref string                     assemName,  
   out IEEDataStorage             assemBytes,  
   out IEEDataStorage             assemPdb,  
   out string                     assemLocation,  
   out enum_ASSEMBLYLOCRESOLUTION alr  
);  
```  
  
#### Parameters  
 `assemName`  
 [in] Name of the assembly to resolve.  
  
 `assemBytes`  
 [out] Returns an [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md) object containing the assembly bytes associated with the reference.  
  
 `assemPdb`  
 [out] Returns an `IEEDataStorage` object containing the symbol store data associated with this reference.  
  
 `assemLocation`  
 [out] Returns the path location of this reference.  
  
 `alr`  
 [out] Returns a value from the [ASSEMBLYLOCRESOLUTION](../../../extensibility/debugger/reference/assemblylocresolution.md) enumeration indicating the location of this reference's assembly.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is not typically implemented by a custom expression evaluator.  
  
## See Also  
 [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md)   
 [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md)   
 [ASSEMBLYLOCRESOLUTION](../../../extensibility/debugger/reference/assemblylocresolution.md)
