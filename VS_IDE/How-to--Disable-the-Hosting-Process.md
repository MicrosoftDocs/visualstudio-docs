---
title: "How to: Disable the Hosting Process"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9157488d-737f-454b-8d8d-36f99de38bb0
caps.latest.revision: 10
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
# How to: Disable the Hosting Process
Calls to certain APIs can be affected when the hosting process is enabled. In these cases, it is necessary to disable the hosting process to return the correct results.  
  
### To disable the hosting process  
  
1.  Open an executable project in Visual Studio. Projects that do not produce executables (for example, class library or service projects) do not have this option.  
  
2.  On the **Project** menu, click **Properties**.  
  
3.  Click the **Debug** tab.  
  
4.  Clear the **Enable the Visual Studio hosting process** check box.  
  
 When the hosting process is disabled, several debugging features are unavailable or experience decreased performance. For more information, see [Debugging and the Hosting Process](../VS_debugger/Debugging-and-the-Hosting-Process.md).  
  
 In general, when the hosting process is disabled:  
  
-   The time needed to begin debugging .NET Framework applications increases.  
  
-   Design-time expression evaluation is unavailable.  
  
-   Partial trust debugging is unavailable.  
  
## See Also  
 [Debugging and the Hosting Process](../VS_debugger/Debugging-and-the-Hosting-Process.md)   
 [Hosting Process (vshost.exe)](../VS_IDE/Hosting-Process--vshost.exe-.md)   
 [Builds During Application Development](assetId:///c9497d62-3b7b-4449-88e8-cf27acc9efe6)