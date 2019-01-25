---
title: "IDiaSession::findSymbolsByRVAForAcceleratorPointerTag | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
ms.assetid: a073cc45-0c7b-417e-b5fc-a3b08beccdbc
caps.latest.revision: 6
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSession::findSymbolsByRVAForAcceleratorPointerTag
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Given a corresponding tag value, this method returns an enumeration of symbols that are contained in a specified parent Accelerator stub function at a specified relative virtual address.  
  
## Syntax  
  
```cpp#  
HRESULT findSymbolsByRVAForAcceleratorPointerTag (   
   IDiaSymbol*           parent,  
   DWORD                 tagValue,  
   DWORD                 rva,  
   IDiaEnumSymbols**     ppResult  
);  
```  
  
#### Parameters  
 `parent`  
 [in] An `IDiaSymbol` that corresponds to the Accelerator stub function to be searched.  
  
 `tagValue`  
 [in] The pointer tag value.  
  
 `rva`  
 [in] The relative virtual address.  
  
 `ppResult`  
 [out] A pointer to an `IDiaEnumSymbols` interface pointer that is initialized with the result.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Call this method only on an `IDiaSymbol` interface that corresponds to an Accelerator stub function.  
  
## See Also  
 [IDiaSession](../../debugger/debug-interface-access/idiasession.md)   
 [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)   
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
