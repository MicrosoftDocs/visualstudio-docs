---
title: "IDiaSymbol::get_backEndMajor | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_backEndMajor method"
ms.assetid: 900a05dd-c29b-44ad-b46b-f43bda819a66
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_backEndMajor
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the back-end major version number of the compiler.  
  
## Syntax  
  
```cpp#  
HRESULT get_backEndMajor (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the back-end major version number. See Remarks.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
 A compiler is typically composed of two primary elements: the front end (the parser), which handles parsing the source code into an intermediate form, and a back end (code generator), which converts the intermediate form into assembly. It is not uncommon for the front end to have a different version than the back end.  
  
 A front end or back end version number is composed of three parts: \<major>.\<minor>.\<build>, where \<major> is the major version number, \<minor> is the minor version number, and \<build> is the build number. For example, 13.10.3077.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v7.0|  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
