---
title: "IDiaLineNumber::get_length | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaLineNumber::get_length method"
ms.assetid: 2c55a6f7-4ef5-45fb-9fd1-d72deaaa2829
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaLineNumber::get_length
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the number of bytes in a block.  
  
## Syntax  
  
```cpp#  
HRESULT get_length (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the number of bytes in a block.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 The block is the length of source code on the line as represented by the [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md) object.  
  
## See Also  
 [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
