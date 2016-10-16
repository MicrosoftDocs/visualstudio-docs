---
title: "IDiaReadExeAtOffsetCallback::ReadExecutableAt"
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
  - "IDiaReadExeAtOffsetCallback::ReadExecutableAt method"
ms.assetid: 30b1cef0-b366-4712-8e89-d21f640964f8
caps.latest.revision: 7
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
# IDiaReadExeAtOffsetCallback::ReadExecutableAt
Reads the specified number of bytes starting at the specified offset from an executable file.  
  
## Syntax  
  
```cpp#  
HRESULT ReadExecutableAt (   
   DWORDLONG fileOffset,  
   DWORD     cbData,  
   DWORD*    pcbData,  
   BYTE      data[]  
);  
```  
  
#### Parameters  
 fileOffset  
 [in] The offset in the executable file to begin reading.  
  
 cbData  
 [in] Number of bytes to read.  
  
 pcbData  
 [out] Returns the number of bytes read.  
  
 data[]  
 [in, out] An array that is filled in with bytes read from file.  
  
## Remarks  
 This method is called by the DIA support code to load data bytes from an executable using an absolute file offset. This method is called in support of the [IDiaDataSource::loadDataForExe](../debugger/idiadatasource--loaddataforexe.md) method.  
  
## See Also  
 [IDiaReadExeAtOffsetCallback](../debugger/idiareadexeatoffsetcallback.md)   
 [IDiaDataSource::loadDataForExe](../debugger/idiadatasource--loaddataforexe.md)