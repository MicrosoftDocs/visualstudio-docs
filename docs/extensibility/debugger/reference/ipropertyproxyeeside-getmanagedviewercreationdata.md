---
title: "IPropertyProxyEESide::GetManagedViewerCreationData | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IPropertyProxyEESide::GetManagedViewerCreationData"
helpviewer_keywords: 
  - "IPropertyProxyEESide::GetManagedViewerCreationData"
ms.assetid: c4eb4d60-8816-4d52-bc8d-dffd4f066499
caps.latest.revision: 12
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
# IPropertyProxyEESide::GetManagedViewerCreationData
Retrieves information about the viewer for this property type in order to instantiate that viewer.  
  
## Syntax  
  
```cpp#  
HRESULT GetManagedViewerCreationData(  
   BSTR*                  assemName,  
   IEEDataStorage**       assemBytes,  
   IEEDataStorage**       assemPdb,  
   BSTR*                  className,  
   ASSEMBLYLOCRESOLUTION* alr,  
   BOOL*                  replacementOk  
);  
```  
  
```c#  
int GetManagedViewerCreationData(  
   out string                     assemName,  
   out IEEDataStorage             assemBytes,  
   out IEEDataStorage             assemPdb,  
   out string                     className,  
   out enum_ASSEMBLYLOCRESOLUTION alr,  
   out int                        replacementOk  
);  
```  
  
#### Parameters  
 `assemName`  
 [out] Returns the name of the assembly holding this object.  
  
 `assemBytes`  
 [out] Returns an [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md) object containing the assembly bytes of this object (this is a null value if no bytes are available).  
  
 `assemPdb`  
 [out] Returns an `IEEDataStorage` object containing the symbol store information for this object (this is a null value if no symbol store is available).  
  
 `className`  
 [out] Returns the class name containing this object.  
  
 `alr`  
 [out] Returns a value from the [ASSEMBLYLOCRESOLUTION](../../../extensibility/debugger/reference/assemblylocresolution.md) enumeration indicating the location of the assembly.  
  
 `replacementOk`  
 [out] Returns nonzero (`TRUE`) if this object's value can be changed; zero (`FALSE`) if the object is read-only.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is used by type visualizers to instantiate a managed viewer.  
  
## See Also  
 [IPropertyProxyEESide](../../../extensibility/debugger/reference/ipropertyproxyeeside.md)   
 [ASSEMBLYLOCRESOLUTION](../../../extensibility/debugger/reference/assemblylocresolution.md)   
 [IEEDataStorage](../../../extensibility/debugger/reference/ieedatastorage.md)