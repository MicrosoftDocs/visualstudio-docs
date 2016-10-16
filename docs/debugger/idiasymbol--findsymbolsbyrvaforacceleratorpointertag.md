---
title: "IDiaSymbol::findSymbolsByRVAForAcceleratorPointerTag"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 024ccd78-5867-4ca7-bc26-548758e9ac53
caps.latest.revision: 3
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# IDiaSymbol::findSymbolsByRVAForAcceleratorPointerTag
Given a corresponding tag value, this method returns an enumeration of symbols that are contained in this stub function at a specified relative virtual address.  
  
## Syntax  
  
```cpp  
HRESULT findSymbolsByRVAForAcceleratorPointerTag (   
   DWORD             tagValue,  
   DWORD             rva,  
   IDiaEnumSymbols** ppResult);  
```  
  
#### Parameters  
 `tagValue`  
 [in] The pointer tag value for which the pointee symbol records are found.  
  
 `rva`  
 [in] The rva that is used to filter the symbols that correspond to the pointee variable with the specified tag value.  
  
 `ppResult`  
 [out] A pointer to an `IDiaEnumSymbols` interface pointer which is initialized with the result.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
## Remarks  
 Call this method only on an `IDiaSymbol` interface that corresponds to an Accelerator stub function.  
  
## See Also  
 [IDiaSymbol](../debugger/idiasymbol.md)   
 [IDiaEnumSymbols](../debugger/idiaenumsymbols.md)