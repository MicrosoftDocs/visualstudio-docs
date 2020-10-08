---
title: "IDiaLineNumber::get_columnNumberEnd | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaLineNumber::get_columnNumberEnd method"
ms.assetid: 02fa56c1-87b6-405a-adee-3bb6bc62de2d
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaLineNumber::get_columnNumberEnd
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the one-based source column number where the expression or statement ends.  
  
## Syntax  
  
```cpp#  
HRESULT get_columnNumberEnd (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the column number where the expression or statement ends. If the value is zero, then the column end information is not present.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## Remarks  
 The column value returned by this method is a byte offset into the line to the position after the last character of the statement on the line.  
  
## See Also  
 [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
