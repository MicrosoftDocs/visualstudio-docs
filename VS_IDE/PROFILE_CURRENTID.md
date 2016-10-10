---
title: "PROFILE_CURRENTID"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 55ccf665-a05e-48c3-adf7-7714c0a9aaef
caps.latest.revision: 6
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
# PROFILE_CURRENTID
The PROFILE_CURRENTID returns the pseudo-token for the thread id or process id, in a call to NameProfile, StartProfile, StopProfile, SuspendProfile, and ResumeProfile functions. Use it to cause the function to operate on the current thread or process, rather than a specifically indicated one.  
  
## Example  
 PROFILE_CURRENTID is defined in VSPerf.h as:  
  
```  
static const unsigned int PROFILE_CURRENTID = (unsigned int)-1;  
```  
  
## Example  
 The following example illustrates PROFILE_CURRENTID. The example uses PROFILE_CURRENTID as a parameter identifying the current thread in a call to the [StartProfile](../VS_IDE/StartProfile.md) function.  
  
```  
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
  
## See Also  
 [Visual Studio Profiler API Reference (Native)](../VS_IDE/Visual-Studio-Profiler-API-Reference--Native-.md)   
 [NameProfile](../VS_IDE/NameProfile.md)   
 [ResumeProfile](../VS_IDE/ResumeProfile.md)   
 [StartProfile](../VS_IDE/StartProfile.md)   
 [StopProfile](../VS_IDE/StopProfile.md)   
 [SuspendProfile](../VS_IDE/SuspendProfile.md)