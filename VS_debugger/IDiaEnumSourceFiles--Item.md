---
title: "IDiaEnumSourceFiles::Item"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 3c19d7ed-0232-4b0e-9b10-f33ed9e0c93b
caps.latest.revision: 7
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# IDiaEnumSourceFiles::Item
Retrieves a source file by means of an index.  
  
## Syntax  
  
```cpp#  
HRESULT Item (   
   DWORD            index,  
   IDiaSourceFile** sourceFile  
);  
```  
  
#### Parameters  
 index  
 [in] Index of the [IDiaSourceFile](../VS_debugger/IDiaSourceFile.md) object to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by the [IDiaEnumSourceFiles::get_Count](../VS_debugger/IDiaEnumSourceFiles--get_Count.md) method.  
  
 sourceFile  
 [out] Returns an [IDiaSourceFile](../VS_debugger/IDiaSourceFile.md) object representing the desired source file.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumSourceFiles](../VS_debugger/IDiaEnumSourceFiles.md)   
 [IDiaSourceFile](../VS_debugger/IDiaSourceFile.md)