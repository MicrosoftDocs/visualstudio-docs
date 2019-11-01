---
title: "CommentMarkAtProfile | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "CommentMarkAtProfile"
  - "CommentMarkAtProfileA"
ms.assetid: 04294ca3-bf9c-4c76-86f1-898c2140de27
caps.latest.revision: 16
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# CommentMarkAtProfile
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The `CommentMarkAtProfile` method inserts a timestamp value, a numeric mark, and a comment string in the .vsp file. The timestamp value can be used to synchronize external events. For the mark and comment to be inserted, profiling for the thread that contains the CommentMarkAtProfile function must be ON.  
  
## Syntax  
  
```  
PROFILE_COMMAND_STATUS PROFILERAPI CommentMarkAtProfile (  
                                   __int64 dnTimestamp,  
                                   long lMarker,  
                                   LPCTSTR szComment);  
```  
  
#### Parameters  
 `dnTimestamp`  
  
 A 64-bit integer that represents a timestamp value.  
  
 `lMarker`  
  
 The numeric marker to insert. The marker must greater than or equal to 0 (zero).  
  
 `szComment`  
  
 A pointer to the text string to insert. The string must be less than 256 characters including the NULL terminator.  
  
## Property Value/Return Value  
 The function indicates success or failure by using **PROFILE_COMMAND_STATUS** enumeration. The return value can be one of the following:  
  
|Enumerator|Description|  
|----------------|-----------------|  
|MARK_ERROR_MARKER_RESERVED|The parameter is less than or equal to 0. These values are reserved. The mark and comment are not recorded.|  
|MARK_ERROR_MODE_NEVER|The profiling mode was set to NEVER when the function was called. The mark and comment are not recorded.|  
|MARK_ERROR_MODE_OFF|The profiling mode was set to OFF when the function was called. The mark and comment are not recorded.|  
|MARK_ERROR_NO_SUPPORT|No mark support in this context. The mark and comment are not recorded.|  
|MARK_ERROR_OUTOFMEMORY|Memory was not available to record the event. The mark and comment are not recorded.|  
|MARK_TEXTTOOLONG|The string exceeds the maximum of 256 characters. The comment string is truncated and the mark and comment are recorded.|  
|MARK_OK|MARK_OK is returned to indicate success.|  
  
## Remarks  
 The profiling state for the thread that contains the mark profile function must be on when marks and comments inserted with the Mark command or with API functions (CommentMarkAtProfile, CommentMarkProfile, or MarkProfile). Profile marks are global in scope. For example, a profile mark inserted in one thread can be used to mark the start or end of a data segment in any thread in the .vsp file.  
  
> [!IMPORTANT]
> CommentMarkAtProfile methods should be used with instrumentation only.  
  
## .NET Framework Equivalent  
 Microsoft.VisualStudio.Profiler.dll  
  
## Function Information  
  
|||  
|-|-|  
|**Header**|Include VSPerf.h|  
|**Library**|Use VSPerf.lib|  
|**Unicode**|Implemented as CommentMarkAtProfileW (Unicode) and CommentMarkAtProfileA (ANSI).|  
  
## Example  
 The following code illustrates the use of the CommentMarkAtProfile generic function call. The example assumes the use of Win32 string macros and the compiler settings for ANSI to determine whether the code calls the ANSI enabled function.  
  
```  
void ExerciseCommentMarkAtProfile(void)  
{  
    // Declare and initalize variables to pass to   
    // CommentMarkAtProfile.  The values of these   
    // parameters are assigned based on the needs   
    // of the code; and for the sake of simplicity  
    // in this example, the variables are assigned  
    // arbitrary values.  
    int64 timeStamp = 0x1111;  
    long markId = 01;  
    TCHAR * markText = TEXT("Exercising CommentMarkAtProfile...");  
  
    // Variables used to print output.  
    HRESULT hResult;  
    TCHAR tchBuffer[256];  
  
    // Declare MarkOperationResult Enumerator.    
    // Holds return value from call to CommentMarkAtProfile.  
    PROFILE_COMMAND_STATUS markResult;  
  
    markResult = CommentMarkAtProfile(  
        timeStamp,  
        markId,  
        markText);  
  
    // Format and print result.  
    LPCTSTR pszFormat = TEXT("%s %d.\0");  
    TCHAR* pszTxt = TEXT("CommentMarkAtProfile returned");  
    hResult = StringCchPrintf(tchBuffer, 256, pszFormat,   
    pszTxt, markResult);  
  
#ifdef DEBUG  
    OutputDebugString(tchBuffer);  
#endif  
}  
```  
  
## See Also  
 [Visual Studio Profiler API Reference (Native)](../profiling/visual-studio-profiler-api-reference-native.md)
