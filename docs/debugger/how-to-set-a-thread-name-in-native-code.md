---
title: Set a Thread Name in Native Code | Microsoft Docs
description: Set a thread name in native code during multithreaded app debugging in Visual Studio. Thread naming is used to keep track of threads in the Threads window.
ms.custom: SEO-VS-2020
ms.date: 12/17/2018
ms.topic: how-to
dev_langs: 
  - C++
helpviewer_keywords: 
  - debugging [C++], threads
  - SetThreadName function
  - threading [Visual Studio], names
  - thread names
  - debugging [Visual Studio], threads
ms.assetid: c85d0968-9f22-4d69-87f4-acca2ae777b8
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - cplusplus
---
# How to: Set a Thread Name in Native Code
Thread naming is possible in any edition of Visual Studio. Thread naming is useful for identifying threads of interest in the **Threads** window when debugging a running process. Having recognizably-named threads can also be helpful when performing post-mortem debugging via crash dump inspection and when analyzing performance captures using various tools.

## Ways to set a thread name

There are two ways to set a thread name. The first is via the [SetThreadDescription](/windows/desktop/api/processthreadsapi/nf-processthreadsapi-setthreaddescription) function. The second is by throwing a particular exception while the Visual Studio debugger is attached to the process. Each approach has benefits and caveats. The use of `SetThreadDescription` is supported starting in Windows 10, version 1607 or Windows Server 2016.

It is worth noting that _both_ approaches can be used together, if desired, since the mechanisms by which they work are independent of each other.

### Set a thread name by using `SetThreadDescription`

Benefits:
* Thread names are visible when debugging in Visual Studio, regardless of whether or not the debugger was attached to the process at the time that SetThreadDescription is invoked.
* Thread names are visible when performing post-mortem debugging by loading a crash dump in Visual Studio.
* Thread names are also visible when using other tools, such as the [WinDbg](/windows-hardware/drivers/debugger/debugger-download-tools) debugger and the [Windows Performance Analyzer](/windows-hardware/test/wpt/windows-performance-analyzer) performance analyzer.

Caveats:
* Thread names are only visible in Visual Studio 2017 version 15.6 and later versions.
* When post-mortem debugging a crash dump file, thread names are only visible if the crash was created on Windows 10 version 1607, Windows Server 2016 or later versions of Windows.

*Example:*

```C++
#include <windows.h>
#include <processthreadsapi.h>

int main()
{
    HRESULT r;
    r = SetThreadDescription(
        GetCurrentThread(),
        L"ThisIsMyThreadName!"
    );

    return 0;
}
```

### Set a thread name by throwing an exception

Another way to set a thread name in your program is to communicate the desired thread name to the Visual Studio debugger by throwing a specially-configured exception.

Benefits:
* Works in all versions of Visual Studio.

Caveats:
* Only works if the debugger is attached at the time the exception-based method is used.
* Thread names set by using this method will not be available in dumps or performance analysis tools.

*Example:*

The `SetThreadName` function shown below demonstrates this exception-based approach. Note that the thread name will be automatically copied to the thread, so that the memory for the `threadName` parameter can be released after the `SetThreadName` call is completed.

```C++
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

## See also
- [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)
- [Viewing Data in the Debugger](../debugger/viewing-data-in-the-debugger.md)
- [How to: Set a Thread Name in Managed Code](../debugger/how-to-set-a-thread-name-in-managed-code.md)
