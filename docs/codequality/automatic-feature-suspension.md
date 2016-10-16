---
title: "Automatic feature suspension"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "full solution analysis"
  - "performance"
  - "low-memory"
ms.assetid: 572c15aa-1fd0-468c-b6be-9fa50e170914
caps.latest.revision: 6
ms.author: "kempb"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Automatic feature suspension
If your available system memory falls to 200MB or less, Visual Studio displays the following message in the code editor.  
  
 ![Alert text suspending full solution analysis](../codequality/media/fsa_alert.png "FSA_Alert")  
  
 When Visual Studio detects a low memory condition, it automatically suspends certain advanced features to help it remain stable. When this advanced feature suspension warning appears, Visual Studio will continue to work as before, but its performance will be slightly degraded.  
  
 In a low memory condition, the following occurs:  
  
-   Full solution analysis for Visual C# and Visual Basic is disabled.  
  
-   [Garbage Collection](../Topic/Garbage%20Collection.md) (GC) low-latency mode for Visual C# and Visual Basic are disabled.  
  
-   Visual Studio caches are flushed.  
  
## Improve Visual Studio performance  
 For tips and tricks on how to improve Visual Studio performance when dealing with large solutions or low-memory conditions, see [Performance considerations for large solutions](https://github.com/dotnet/roslyn/wiki/Performance-considerations-for-large-solutions).  
  
## Full solution analysis suspended  
 By default, full solution analysis is enabled for Visual Basic and disabled for Visual C#. However, in a low memory condition, full solution analysis is automatically disabled for both Visual Basic and Visual C#, regardless of their settings in the Options dialog box. However, you can re-enable full solution analysis by choosing the **Re-enable** button in the info bar when it appears, by selecting the **Enable full solution analysis** check box in the Options dialog, or by restarting Visual Studio. The Options dialog box always shows the current full solution analysis settings. For more information, see [How to: Enable and Disable Full Solution Analysis](../codequality/how-to--enable-and-disable-full-solution-analysis-for-managed-code.md).  
  
## GC low-latency disabled  
 To re-enable GC low-latency mode, restart Visual Studio.  By default, Visual Studio enables GC  low-latency mode whenever you are typing to ensure that your typing doesn't block any GC operations. However, if a low memory condition causes Visual Studio to display the automatic suspension warning, GC low-latency mode is disabled for that session. Restarting Visual Studio will re-enable the default GC behavior. For more information, see [GCLatencyMode Enumeration](../Topic/GCLatencyMode%20Enumeration.md).  
  
## Visual Studio caches flushed  
 All Visual Studio caches are immediately emptied, but will begin to repopulate if you continue your current development session or restart Visual Studio. The caches flushed include caches for the following features.  
  
-   Find all references  
  
-   Navigate To  
  
-   Add Using  
  
 In addition, caches used for internal Visual Studio operations are also cleared.  
  
> [!NOTE]
>  The automatic feature suspension warning occurs only once on a per-solution basis, not on a per-session basis. This means that if you switch from Visual Basic to Visual C# (or vice-versa) and run into another low memory condition, you can possibly get another automatic feature suspension warning.  
  
## See Also  
 [How to: Enable and Disable Full Solution Analysis](../codequality/how-to--enable-and-disable-full-solution-analysis-for-managed-code.md)   
 [Fundamentals of Garbage Collection](../Topic/Fundamentals%20of%20Garbage%20Collection.md)   
 [Performance considerations for large solutions](https://github.com/dotnet/roslyn/wiki/Performance-considerations-for-large-solutions)