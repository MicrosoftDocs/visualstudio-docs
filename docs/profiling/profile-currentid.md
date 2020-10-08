---
title: "PROFILE_CURRENTID | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "PROFILE_CURRENTID"
ms.assetid: 55ccf665-a05e-48c3-adf7-7714c0a9aaef
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# PROFILE_CURRENTID
The PROFILE_CURRENTID returns the pseudo-token for the thread ID or process ID, in a call to NameProfile, StartProfile, StopProfile, SuspendProfile, and ResumeProfile functions. Use it to cause the function to operate on the current thread or process, rather than a specifically indicated one.

## Example
 PROFILE_CURRENTID is defined in *VSPerf.h* as:

```cpp
static const unsigned int PROFILE_CURRENTID = (unsigned int)-1;
```

## Example
 The following example illustrates PROFILE_CURRENTID. The example uses PROFILE_CURRENTID as a parameter identifying the current thread in a call to the [StartProfile](../profiling/startprofile.md) function.

```cpp
void ExerciseProfileCurrentID()
{
    // Declare ProfileOperationResult enumeration
    // to hold return value of a call to StartProfile.
    PROFILE_COMMAND_STATUS profileResult;

    // Variables used to print output.
    HRESULT hResult;
    TCHAR tchBuffer[256];

    profileResult = StartProfile(
        PROFILE_GLOBALLEVEL,
        PROFILE_CURRENTID);

    // Format and print result.
    LPCTSTR pszFormat = TEXT("%s %d.\0");
    TCHAR* pszTxt = TEXT("StartProfile returned");
    hResult = StringCchPrintf(tchBuffer, 256, pszFormat,
        pszTxt, profileResult);

#ifdef DEBUG
    OutputDebugString(tchBuffer);
#endif
}
```

## See also
- [Visual Studio profiler API reference (native)](../profiling/visual-studio-profiler-api-reference-native.md)
- [NameProfile](../profiling/nameprofile.md)
- [ResumeProfile](../profiling/resumeprofile.md)
- [StartProfile](../profiling/startprofile.md)
- [StopProfile](../profiling/stopprofile.md)
- [SuspendProfile](../profiling/suspendprofile.md)
