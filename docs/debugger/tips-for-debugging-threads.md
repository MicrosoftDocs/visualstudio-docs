---
title: "Tips for debugging threads"
description: Read a list of tips for debugging threads in native code if you're debugging multithreaded apps in Visual Studio.
ms.date: "05/06/2024"
ms.topic: article
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "threading [Visual Studio], debugging"
  - "debugging [Visual Studio], threads"
  - debugging [C++], threads
  - SetThreadName function
  - threading [Visual Studio], names
  - thread names
  - Thread.Name property
  - threading [Visual Studio], names
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Tips for debugging threads

This article provides helpful information for debugging threads, including information on setting thread names for native and managed code.

## C/C++ tips 

Here are some tips you can use when debugging threads in native code:

- You can view the contents of the Thread Information Block by typing `@TIB` in the **Watch** window or **QuickWatch** dialog box.

- You can view the last error code for the current thread by entering `@Err` in the **Watch** window or **QuickWatch** dialog box.

- C Run-Time Libraries (CRT) functions can be useful for debugging a multithreaded application. For more information, see [_malloc_dbg](/cpp/c-runtime-library/reference/malloc-dbg).

## Set a thread name in C/C++

Thread naming is possible in any edition of Visual Studio. Thread naming is useful for identifying threads of interest in the **Threads** window when debugging a running process. Having recognizably named threads can also be helpful when performing post-mortem debugging via crash dump inspection and when analyzing performance captures using various tools.

### Ways to set a thread name

There are two ways to set a thread name. The first is via the [SetThreadDescription](/windows/desktop/api/processthreadsapi/nf-processthreadsapi-setthreaddescription) function. The second is by throwing a particular exception while the Visual Studio debugger is attached to the process. Each approach has benefits and caveats. The use of `SetThreadDescription` is supported starting in Windows 10 version 1607 or Windows Server 2016.

It's worth noting that *both* approaches can be used together, if desired, since the mechanisms by which they work are independent of each other.

### Set a thread name by using `SetThreadDescription`

Benefits:
* Thread names are visible when debugging in Visual Studio, regardless of whether or not the debugger was attached to the process at the time that SetThreadDescription is invoked.
* Thread names are visible when performing post-mortem debugging by loading a crash dump in Visual Studio.
* Thread names are also visible when using other tools, such as the [WinDbg](/windows-hardware/drivers/debugger/debugger-download-tools) debugger and the [Windows Performance Analyzer](/windows-hardware/test/wpt/windows-performance-analyzer) performance analyzer.

Caveats:
* Thread names are only visible in Visual Studio 2017 version 15.6 and later versions.
* When post-mortem debugging a crash dump file, thread names are only visible if the crash was created on Windows 10 version 1607, Windows Server 2016 or later versions of Windows.

*Example:*

```cpp
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

Another way to set a thread name in your program is to communicate the desired thread name to the Visual Studio debugger by throwing a specially configured exception.

Benefits:
* Works in all versions of Visual Studio.

Caveats:
* Only works if the debugger is attached at the time the exception-based method is used.
* Thread names set by using this method won't be available in dumps or performance analysis tools.

*Example:*

The `SetThreadName` function shown below demonstrates this exception-based approach. Note that the thread name will be automatically copied to the thread, so that the memory for the `threadName` parameter can be released after the `SetThreadName` call is completed.

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

## Set a thread name in managed code

Thread naming is possible in any edition of Visual Studio. Thread naming is useful for keeping track of threads in the **Threads** window.

 To set a thread name in managed code, use the <xref:System.Threading.Thread.Name%2A> property.

## Example

### [C#](#tab/csharp)
```csharp
public class Needle
{
    // This method will be called when the thread is started.
    public void Baz()
    {
        Console.WriteLine("Needle Baz is running on another thread");
    }
}

public void Main()
{
    Console.WriteLine("Thread Simple Sample");
    Needle oNeedle = new Needle();
    // Create a Thread object.
    System.Threading.Thread oThread = new System.Threading.Thread(oNeedle.Baz);
    // Set the Thread name to "MyThread".
    oThread.Name = "MyThread";
    // Starting the thread invokes the ThreadStart delegate
    oThread.Start();
}
```

### [VB](#tab/vb)
```VB
Public Class Needle
    ' This method will be called when the thread is started.
    Sub Baz()
        Console.WriteLine("Needle Baz is running on another thread")
    End Sub
End Class

Sub Main()
    Console.WriteLine("Thread Simple Sample")
    Dim oNeedle As New Needle()
   ' Create a Thread object.
    Dim oThread As New System.Threading.Thread(AddressOf oNeedle.Baz)
    ' Set the Thread name to "MyThread".
    oThread.Name = "MyThread"
    ' Starting the thread invokes the ThreadStart delegate
    oThread.Start()
End Sub
```
---

## Related content
- [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)
- [Debugging Native Code](../debugger/debugging-native-code.md)
