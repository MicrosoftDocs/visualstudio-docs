---
title: "How to: Troubleshoot Unsuccessful Visual Studio Project Upgrades"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 842fe448-c044-4343-8eae-d81711cf48ba
caps.latest.revision: 30
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# How to: Troubleshoot Unsuccessful Visual Studio Project Upgrades
Sometimes Visual Studio cannot fully convert a project from an earlier version of Visual Studio. If the tips in the following sections do not resolve your specific problem, you might be able to find more information on the TechNet [Wiki: Development Portal](http://go.microsoft.com/fwlink/?LinkId=254808).  
  
## The Project Does Not Run Because Files Are Not Found  
 A project file contains hard-coded file paths that Visual Studio uses to run the project when you press F5. These paths may include the location of devenv.exe and other required files. In an upgraded version of Visual Studio, the paths of these files may have been changed.  
  
#### To resolve incorrect file paths  
  
1.  Open your project file in a text editor.  
  
2.  Scan for file paths that may be incorrect, especially those that contain a Visual Studio version number.  
  
3.  Modify incorrect file paths so that they point to the new targets.  
  
## The Project Does Not Build Because References Are Not Valid  
 When you upgrade Visual Studio, you might also be upgrading the .NET Framework version. If your project contains references that are discontinued in the newer .NET Framework version, they may not resolve correctly. This is especially likely for references that include version numbers, for example, `Microsoft.VisualStudio.Shell.Interop.8.0`.  
  
 If your code has many invalid references, the easiest solution may be to use the multi-targeting feature of Visual Studio to target an earlier version of the .NET Framework.  
  
#### To resolve incorrect references  
  
1.  Open your project file in a text editor.  
  
2.  Open the project properties.  
  
3.  Select the correct **Target Framework** value. Alternatively, you can modify the value of the `<TargetFrameworkVersion>` element directly in the project file.  
  
 If you want your project to run in the upgraded .NET Framework version, you must update the references for the project, and also update any `Imports` or `Using` statements that call the references. If your project loads in the IDE, you can update the references by using **Solution Explorer** or the **Reference Manager** dialog box.  
  
## See Also  
 [/Upgrade (devenv.exe)](../VS_IDE/-Upgrade--devenv.exe-.md)   
 [Converting to ASP.NET 4](../Topic/Converting%20to%20ASP.NET%204.md)