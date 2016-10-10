---
title: "Client Block Hook Functions"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f21c197e-565d-4e3f-9b27-4c018c9b87fc
caps.latest.revision: 15
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Client Block Hook Functions
If you want to validate or report the contents of the data stored in `_CLIENT_BLOCK` blocks, you can write a function specifically for this purpose. The function that you write must have a prototype similar to the following, as defined in CRTDBG.H:  
  
```  
void YourClientDump(void *, size_t)  
  
```  
  
 In other words, your hook function should accept a **void** pointer to the beginning of the allocation block, together with a **size_t** type value indicating the size of the allocation, and return `void`. Other than that, its contents are up to you.  
  
 Once you have installed your hook function using [_CrtSetDumpClient](../Topic/_CrtSetDumpClient.md), it will be called every time a `_CLIENT_BLOCK` block is dumped. You can then use [_CrtReportBlockType](../Topic/_CrtReportBlockType.md) to get information on the type or subtype of dumped blocks.  
  
 The pointer to your function that you pass to `_CrtSetDumpClient` is of type **_CRT_DUMP_CLIENT**, as defined in CRTDBG.H:  
  
```  
typedef void (__cdecl *_CRT_DUMP_CLIENT)  
   (void *, size_t);  
```  
  
## See Also  
 [Debug Hook Function Writing](../VS_debugger/Debug-Hook-Function-Writing.md)   
 [crt_dbg2 Sample](assetId:///21e1346a-6a17-4f57-b275-c76813089167)   
 [_CrtReportBlockType](../Topic/_CrtReportBlockType.md)