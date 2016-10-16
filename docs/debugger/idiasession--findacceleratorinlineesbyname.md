---
title: "IDiaSession::findAcceleratorInlineesByName"
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
ms.assetid: e203e5c2-6563-43fa-be56-3063955043ab
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
# IDiaSession::findAcceleratorInlineesByName
Returns an enumeration of symbols for inline frames corresponding to the specified inline function name.  
  
## Syntax  
  
```cpp#  
HRESULT findAcceleratorInlineeLinesByName (   
   LPCOLESTR             name,  
   DWORD                 option,  
   IDiaEnumSymbols**     ppResult  
);  
```  
  
#### Parameters  
 `name`  
 [in] The inlinee function name to be searched.  
  
 `option`  
 [in] The name search options to be used when searching for inline frames that correspond to `name`. For more information, see [NameSearchOptions Enumeration](../debugger/namesearchoptions.md).  
  
 `ppResult`  
 [out] A pointer to an `IDiaEnumSymbols` interface pointer that is initialized with the result.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This function searches for inlinees only within Accelerator stub functions. It ignores native C++ procedure records.  
  
## See Also  
 [IDiaSession](../debugger/idiasession.md)   
 [IDiaEnumSymbols](../debugger/idiaenumsymbols.md)   
 [IDiaSymbol](../debugger/idiasymbol.md)