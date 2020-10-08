---
title: "IDiaDataSource::get_lastError | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaDataSource::get_lastError method"
ms.assetid: cf08850b-8b75-4e8c-90bd-bd0214756f99
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaDataSource::get_lastError
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the file name for the last load error.  
  
## Syntax  
  
```cpp#  
HRESULT get_lastError (  
   BSTR* pRetVal  
);  
```  
  
#### Parameters  
 pRetVal  
 [out] Returns a string that contains the .pdb file name associated with the last load error.  
  
## Return Value  
 Returns the last error code caused by a load operation. Returns `E_INVALIDARG` if the `pRetVal` parameter is `NULL`.  
  
## Example  
  
```cpp#  
BSTR    fileName;  
HRESULT errorCode = pSource->get_lastError( &fileName );  
```  
  
## See Also  
 [IDiaDataSource](../../debugger/debug-interface-access/idiadatasource.md)
