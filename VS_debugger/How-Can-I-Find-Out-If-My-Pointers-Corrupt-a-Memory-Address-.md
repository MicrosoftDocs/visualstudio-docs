---
title: "How Can I Find Out If My Pointers Corrupt a Memory Address?"
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
ms.assetid: a147c939-4fb1-415c-8410-cf303781e9e8
caps.latest.revision: 19
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
# How Can I Find Out If My Pointers Corrupt a Memory Address?
## Problem Description  
 I think that one of my pointers may be corrupting memory at address 0x00408000. How can I find out what is happening there?  
  
## Solution  
  
#### Check for heap corruption  
  
-   Most memory corruption is actually due to heap corruption. Try using the Global Flags Utility (gflags.exe) or pageheap.exe. See [http://support.microsoft.com/default.aspx?scid=kb;en-us;286470](http://support.microsoft.com/default.aspx?scid=kb;en-us;286470).  
  
#### To find where the memory address is modified  
  
1.  Set a data breakpoint at 0x00408000. See [Set a data change breakpoint (native C++ only)](../VS_debugger/Using-Breakpoints.md#BKMK_Set_a_data_change_breakpoint__native_C___only_).  
  
2.  When you hit the breakpoint, use the **Memory** window to view memory contents starting at 0x00408000. For more information, see [Memory Windows](../VS_debugger/Memory-Windows.md).  
  
## See Also  
 [Debugging Native Code FAQs](../VS_debugger/Debugging-Native-Code-FAQs.md)   
 [Debugging Native Code](../VS_debugger/Debugging-Native-Code.md)