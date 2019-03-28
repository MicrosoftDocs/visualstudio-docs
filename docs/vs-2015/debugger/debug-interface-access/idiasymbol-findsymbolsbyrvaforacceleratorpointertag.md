---
title: "IDiaSymbol::findSymbolsByRVAForAcceleratorPointerTag | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
ms.assetid: 024ccd78-5867-4ca7-bc26-548758e9ac53
caps.latest.revision: 6
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::findSymbolsByRVAForAcceleratorPointerTag
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

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
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)   
 [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
