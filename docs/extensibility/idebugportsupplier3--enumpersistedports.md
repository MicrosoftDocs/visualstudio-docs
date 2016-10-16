---
title: "IDebugPortSupplier3::EnumPersistedPorts"
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
  - "IDebugPortSupplier3::EnumPersistedPorts"
helpviewer_keywords: 
  - "IDebugPortSupplier3::EnumPersistedPorts"
ms.assetid: 1c3dead3-5d6c-4067-8418-4015f0b0dd07
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
# IDebugPortSupplier3::EnumPersistedPorts
This method retrieves an object that allows enumeration of the list of persisted ports.  
  
## Syntax  
  
```cpp  
HRESULT EnumPersistedPorts(  
   BSTR_ARRAY         PortNames,  
   IEnumDebugPorts2** ppEnum  
);  
```  
  
```c#  
int EnumPersistedPorts(  
   BSTR_ARRAY           PortNames,  
   out IEnumDebugPorts2 ppEnum  
);  
```  
  
#### Parameters  
 `PortNames`  
 [in] A [BSTR_ARRAY](../extensibility/bstr_array.md) structure that contains a list of port names to find and return among the persisted ports. Only those persisted ports with these names will be returned.  
  
 `ppEnum`  
 [out] An object that implements the [IEnumDebugPorts2](../extensibility/ienumdebugports2.md) interface.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Persisted ports are loaded when a port supplier is instantiated, and saved when the port supplier is destroyed.  
  
## See Also  
 [IDebugPortSupplier3](../extensibility/idebugportsupplier3.md)   
 [IEnumDebugPorts2](../extensibility/ienumdebugports2.md)   
 [BSTR_ARRAY](../extensibility/bstr_array.md)