---
title: "Using Run-Time Checks Without the C Run-Time Library | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.runtime"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords:
  - "run-time errors, error checks"
  - "CRT, run-time checks"
  - "debugger, native run-time checks"
  - "run-time errors, run-time checks"
  - "run-time checks, /RTC option"
  - "debugging [Visual Studio], run-time routines"
ms.assetid: 30ed90f3-9323-4784-80a4-937449eb54f6
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Using Run-Time Checks Without the C Run-Time Library
If you link your program without the C run-time library, using **/NODEFAULTLIB**, and want to use run-time checks, you must link with RunTmChk.lib.

`_RTC_Initialize` initializes your program for run-time checks. If you do not link with the C run-time library, you must check to see whether your program is compiled with run-time error checks before calling `_RTC_Initialize`, as follows:

```cpp
#ifdef __MSVC_RUNTIME_CHECKS
    _RTC_Initialize();
#endif
```

If you do not link with the C run-time library, you must also define a function called `_CRT_RTC_INITW`. `_CRT_RTC_INITW` installs your user-defined function as the default error reporting function, as follows:

```cpp
// C version:
_RTC_error_fnW __cdecl _CRT_RTC_INITW(
        void *res0, void **res1, int res2, int res3, int res4)
{
    // set the error handler.
    return &MyErrorFunc;
}

// C++ version:
extern "C" _RTC_error_fnW __cdecl _CRT_RTC_INITW(
       void *res0, void **res1, int res2, int res3, int res4)
{
    // set the error handler:
    return &MyErrorFunc;
}
```

After you have installed the default error reporting function, you can install additional error reporting functions with `_RTC_SetErrorFuncW`. For more information, see [_RTC_SetErrorFuncW](/cpp/c-runtime-library/reference/rtc-seterrorfuncw).

## See also
[How to: Use Native Run-Time Checks](../debugger/how-to-use-native-run-time-checks.md)
