---
title: "IDiaEnumStackFrames::Next | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumStackFrames::Next method"
ms.assetid: 09378a21-d5e3-4213-b7e2-10f04d85295f
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaEnumStackFrames::Next
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDiaEnumStackFrames::Next](https://docs.microsoft.com/visualstudio/debugger/debug-interface-access/idiaenumstackframes-next).  
  
Retrieves a specified number of stack frame elements from the enumeration sequence.  
  
## Syntax  
  
```cpp#  
HRESULT Next(   
   ULONG             celt,  
   IDiaStackFrame**  rgelt,  
   ULONG*            pceltFetched  
);  
```  
  
#### Parameters  
 celt  
 [in] The number of stackframe elements in the enumerator to be retrieved.  
  
 rgelt  
 [out] An array that is to be filled in with the requested [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md) objects.  
  
 pceltFetched  
 [out] Returns the number of stack frame elements in the fetched enumerator.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more stack frames. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumStackFrames](../../debugger/debug-interface-access/idiaenumstackframes.md)   
 [IDiaStackFrame](../../debugger/debug-interface-access/idiastackframe.md)



