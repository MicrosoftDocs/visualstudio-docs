---
title: "Managed Debugging: Recommended Property Settings | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging [Visual Studio], managed"
  - "debugging managed code, recommended property settings"
ms.assetid: 3d14a8d4-2925-44d0-be41-ec546d411db9
caps.latest.revision: 29
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Managed Debugging: Recommended Property Settings
Certain properties should be set the same way for all managed debugging scenarios.  
  
 The following tables display recommended property settings.  
  
 Settings not listed here may vary among the different managed project types. For example, **Start Action** will be set differently in a Windows Forms project than in a [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] project.  
  
### Configuration Properties on the Build (C#) or Compile (Visual Basic) tab  
  
|**Property Name**|**Setting**|  
|-----------------------|-----------------|  
|**Define DEBUG constant**|C# and F#: Set the check box to checked. This enables your application to use the Debug class.|  
|**Define TRACE constant**|C# and F#: Set the check box to checked. This enables your application to use the Trace class.|  
|**Optimize code**|C#, F#, and Visual Basic: Set to false. Optimized code is harder to debug, because the generated instructions do not correspond directly to your source code. If you find your program has a bug that appears only in optimized code, you can turn this setting on, but remember that code shown in the **Disassembly** window is generated from optimized source that might not match what you see in the Code Editor. To debug optimized code, you must turn off Just My Code. (See [Restrict stepping to Just My Code](../debugger/navigating-through-code-with-the-debugger.md#BKMK_Restrict_stepping_to_Just_My_Code)).<br /><br /> For more information, see [Project Settings for  C# Debug Configurations](../debugger/project-settings-for-csharp-debug-configurations.md) or [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md).|  
|**Output path**|Set to bin\Debug\\.|  
|**Advanced Compile Options**|Visual Basic Only. Click **Advanced** to set the advanced properties that are described in the following table.|  
  
### Advanced Compiler Settings dialog box  
  
|**Property Name**|**Setting**|  
|-----------------------|-----------------|  
|**Enable optimizations**|Set to false for the reasons specified in the **Optimize code** option in the preceding table.|  
|**Generate debugging information**|Select this check box to cause the /DEBUG flag to be set when compiling, which will generate information needed to facilitate debugging.|  
|**Define DEBUG constant**|Select this check box to define the `DEBUG` constant, which enables your application to use the <xref:System.Diagnostics.Debug> class.|  
|**Define TRACE constant**|Select this check box to define the `TRACE` constant, which enables your application to use the <xref:System.Diagnostics.Trace> class.|  
  
## See Also  
 [Debugging Managed Code](../debugger/debugging-managed-code.md)   
 [C#, F#, and Visual Basic Project Types](../debugger/debugging-preparation-csharp-f-hash-and-visual-basic-project-types.md)