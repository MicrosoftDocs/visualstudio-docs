---
title: "IDiaSession::findSymbolsForAcceleratorPointerTag | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
ms.assetid: 95fd5e7a-c637-437e-b369-c864eef733c2
caps.latest.revision: 6
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSession::findSymbolsForAcceleratorPointerTag
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Returns an enumeration of symbols for the variable that the specified tag value corresponds to in the parent Accelerator stub function.  
  
## Syntax  
  
```cpp#  
HRESULT findSymbolsForAcceleratorPointerTag (   
   IDiaSymbol*           parent,  
   DWORD                 tagValue,  
   IDiaEnumSymbols**     ppResult  
);  
```  
  
#### Parameters  
 `parent`  
 [in] An IDiaSymbol that corresponds to the Accelerator stub function to be searched.  
  
 `tagValue`  
 [in] The pointer tag value.  
  
 `ppResult`  
 [out] A pointer to an `IDiaEnumSymbols` interface pointer that is initialized with the result.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../../debugger/debug-interface-access/idiasession.md)   
 [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
