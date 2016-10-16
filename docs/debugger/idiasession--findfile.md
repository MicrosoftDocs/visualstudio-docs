---
title: "IDiaSession::findFile"
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
helpviewer_keywords: 
  - "IDiaSession::findFile method"
ms.assetid: a215dc21-b316-40d7-9923-55bfa014976b
caps.latest.revision: 9
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
# IDiaSession::findFile
Retrieves source files by compiland and name.  
  
## Syntax  
  
```cpp#  
HRESULT findFile (   
   IDiaSymbol*           pCompiland,  
   LPCOLESTR             name,  
   DWORD                 option,  
   IDiaEnumSourceFiles** ppResult  
);  
```  
  
#### Parameters  
 `pCompiland`  
 [in] An [IDiaSymbol](../debugger/idiasymbol.md) object representing the compiland to be used as a context for the search. Set this parameter to `NULL` to find source files in all compilands.  
  
 `name`  
 [in] Specifies the name of the source file to be retrieved. Set this parameter to `NULL` for all source files to be retrieved.  
  
 `option`  
 [in] Specifies the comparison options applied to name searching. Values from the [NameSearchOptions Enumeration](../debugger/namesearchoptions.md) enumeration can be used alone or in combination.  
  
 `ppResult`  
 [out] Returns an [IDiaEnumSourceFiles](../debugger/idiaenumsourcefiles.md) object that contains a list of the source files retrieved.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Example  
  
```cpp#  
IDiaEnumSourceFiles* pEnum;  
pSession->findFile( NULL, L"sourcefile.cpp", nsFNameExt, &pEnum );  
```  
  
## See Also  
 [IDiaEnumSourceFiles](../debugger/idiaenumsourcefiles.md)   
 [IDiaSession](../debugger/idiasession.md)   
 [IDiaSymbol](../debugger/idiasymbol.md)   
 [NameSearchOptions Enumeration](../debugger/namesearchoptions.md)