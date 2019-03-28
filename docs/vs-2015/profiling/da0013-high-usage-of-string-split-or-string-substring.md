---
title: "DA0013: High usage of String.Split or String.Substring | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
f1_keywords: 
  - "vs.performance.13"
  - "vs.performance.rules.DAAvoidStringSubstr"
  - "vs.performance.DA0013"
  - "vs.performance.rules.DA0013"
helpviewer_keywords: 
  - "vs.performance.13"
  - "vs.performance.rules.DA0013"
ms.assetid: f501f423-bef9-4e08-bf96-c9ac9957e5a2
caps.latest.revision: 19
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# DA0013: High usage of String.Split or String.Substring
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Rule Id|DA0013|  
|Category|.NET Framework Usage Guidance|  
|Profiling methods|Sampling|  
|Message|Consider reducing use of String.Split and String.Substring functions.|  
|Rule type|Warning|  
  
## Cause  
 Calls to the System.String.Split or System.String.Substring methods are a significant portion of the profiling data. Consider using System.String.IndexOf or System.String.IndexOfAny if you are testing for the existence of a substring in a string.  
  
## Rule Description  
 The Split method operates on a String object and returns a new array of Strings that contains the substrings of the original. The function allocates memory for the returned array object and allocates a new String object for each array element it finds. Similarly, the Substr method operates on a String object and returns a new String that is equivalent to the substring that was requested.  
  
 If managing memory allocations is critical in your application, consider using alternatives to the String.Split and String.Substr methods. For example, you can use either the IndexOf or IndexOfAny method to locate a specific substring within a character String without creating a new instance of the String class.  
  
## How to Investigate a Warning  
 Double-click the message in the Error List window to navigate to the [Function Details View](../profiling/function-details-view.md) of the sampling profile data. Examine the calling functions to find the sections of the program that make the most frequent use of the System.String.Split or System.String.Substr methods. If it is possible, use either the IndexOf or IndexOfAny method to locate a specific substring within a character String without creating a new instance of the String class.
