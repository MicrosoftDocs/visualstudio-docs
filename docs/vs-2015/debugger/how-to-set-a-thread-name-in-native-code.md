---
title: "How to: Set a Thread Name in Native Code | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging [C++], threads"
  - "SetThreadName function"
  - "threading [Visual Studio], names"
  - "thread names"
  - "debugging [Visual Studio], threads"
ms.assetid: c85d0968-9f22-4d69-87f4-acca2ae777b8
caps.latest.revision: 40
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Set a Thread Name in Native Code
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To set a thread name in your program, use the `SetThreadName` function, as shown in the following code example. Note that the thread name is copied to the thread so that the memory for the `threadName` parameter can be released.  
  
## Example  
  
```cpp  
//  
// Usage: SetThreadName ((DWORD)-1, "MainThread");  
//  
#include <windows.h>  
const DWORD MS_VC_EXCEPTION = 0x406D1388;  
#pragma pack(push,8)  
typedef struct tagTHREADNAME_INFO  
{  
    DWORD dwType; // Must be 0x1000.  
    LPCSTR szName; // Pointer to name (in user addr space).  
    DWORD dwThreadID; // Thread ID (-1=caller thread).  
    DWORD dwFlags; // Reserved for future use, must be zero.  
 } THREADNAME_INFO;  
#pragma pack(pop)  
void SetThreadName(DWORD dwThreadID, const char* threadName) {  
    THREADNAME_INFO info;  
    info.dwType = 0x1000;  
    info.szName = threadName;  
    info.dwThreadID = dwThreadID;  
    info.dwFlags = 0;  
#pragma warning(push)  
#pragma warning(disable: 6320 6322)  
    __try{  
        RaiseException(MS_VC_EXCEPTION, 0, sizeof(info) / sizeof(ULONG_PTR), (ULONG_PTR*)&info);  
    }  
    __except (EXCEPTION_EXECUTE_HANDLER){  
    }  
#pragma warning(pop)  
}  
  
```  
  
## See Also  
 [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)   
 [Viewing Data in the Debugger](../debugger/viewing-data-in-the-debugger.md)   
 [How to: Set a Thread Name in Managed Code](../debugger/how-to-set-a-thread-name-in-managed-code.md)
