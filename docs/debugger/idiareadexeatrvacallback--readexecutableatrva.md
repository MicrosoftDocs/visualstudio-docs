---
title: "IDiaReadExeAtRVACallback::ReadExecutableAtRVA"
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
  - "IDiaReadExeAtRVACallback::ReadExecutableAtRVA method"
ms.assetid: 3c1e965f-8f05-41a8-86d8-01830b2377c9
caps.latest.revision: 8
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
# IDiaReadExeAtRVACallback::ReadExecutableAtRVA
Reads the specified number of bytes starting at the specified relative virtual address (RVA) from the executable file.  
  
## Syntax  
  
```cpp#  
HRESULT ReadExecutableAtRVA (   
   DWORD  relativeVirtualAddress,  
   DWORD  cbData,  
   DWORD* pcbData,  
   BYTE   data[]  
);  
```  
  
#### Parameters  
 `relativeVirtualAddress`  
 [in] The RVA in the executable file to begin reading.  
  
 `cbData`  
 [in] Number of bytes to read.  
  
 `pcbData`  
 [out] Returns the number of bytes read.  
  
 `data[]`  
 [in, out] An array that is filled in with bytes read from the file.  
  
## Remarks  
 This method is called by the DIA support code to load data bytes from an executable using a relative virtual address. This method is called in support of the [IDiaDataSource::loadDataForExe](../debugger/idiadatasource--loaddataforexe.md) method.  
  
## See Also  
 [IDiaReadExeAtRVACallback](../debugger/idiareadexeatrvacallback.md)   
 [IDiaDataSource::loadDataForExe](../debugger/idiadatasource--loaddataforexe.md)