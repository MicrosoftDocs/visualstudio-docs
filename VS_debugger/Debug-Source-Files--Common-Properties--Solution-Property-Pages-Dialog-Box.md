---
title: "Debug Source Files, Common Properties, Solution Property Pages Dialog Box"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
  - JScript
  - SQL
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0af11464-eeb1-4d0b-87a6-0cc96779afb1
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
# Debug Source Files, Common Properties, Solution Property Pages Dialog Box
This property page specifies where the debugger will look for source files when debugging the solution.  
  
 To access the **Debug Source Files** property page, right-click on your Solution in **Solution Explorer** and select **Properties** from the shortcut menu. Expand the **Common Properties** folder, and click the **Debug Source Files** page.  
  
 **Directories containing source code**  
 Contains a list of directories in which the debugger searches for source files when debugging the solution. Subdirectories of the specified directories are also searched.  
  
 **Do not look for these source files**  
 Enter the names of any files that you do not want the debugger to read. If the debugger finds one of these files in one of the directories specified above, it will ignore it. If the **Find Source** dialog box comes up while you are debugging and , you click **Cancel**, the file you were searching for gets added to this list so that the debugger will not continue searching for that file.  
  
## See Also  
 [Debugger Security](../VS_debugger/Debugger-Security.md)   
 [Debugger Settings and Preparation](../VS_debugger/Debugger-Settings-and-Preparation.md)