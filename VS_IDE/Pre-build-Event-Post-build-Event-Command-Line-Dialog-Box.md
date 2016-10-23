---
title: "Pre-build Event-Post-build Event Command Line Dialog Box"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
H1: Pre-build Event/Post-build Event Command Line Dialog Box
ms.assetid: d49b2c57-24bf-4fb2-8351-5c4b6cca938f
caps.latest.revision: 13
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
# Pre-build Event-Post-build Event Command Line Dialog Box
You can type pre- or post-build events for the [Build Events Page, Project Designer (C#)](../VS_IDE/Build-Events-Page--Project-Designer--C#-.md) directly in the edit box, or you can select pre- and post-build macros from a list of available macros.  
  
> [!NOTE]
>  Pre-build events do not run if the project is up to date and no build is triggered.  
  
## UI Element List  
 **Command line edit box**  
 Contains the events to run either for pre-build or post-build.  
  
> [!NOTE]
>  Add a `call` statement before all post-build commands that run .bat files. For example, `call C:\MyFile.bat` or `call C:\MyFile.bat call C:\MyFile2.bat`.  
  
 **Macros**  
 Expands the edit box to display a list of macros to insert in the command line edit box.  
  
 **Macro table**  
 Lists the available macros and its value. See Macros below for a description of each. You can select only one macro at a time to insert into the command line edit box.  
  
 **Insert**  
 Inserts into the command line edit box the macro selected in the macro table.  
  
### Macros  
 You can use any of these macros to specify locations for files, or to get the actual name of the input file in the case of multiple selections. These macros are not case-sensitive.  
  
|Macro|Description|  
|-----------|-----------------|  
|`$(ConfigurationName)`|The name of the current project configuration, for example, "Debug".|  
|`$(OutDir)`|Path to the output file directory, relative to the project directory. This resolves to the value for the Output Directory property. It includes the trailing backslash '\\'.|  
|`$(DevEnvDir)`|The installation directory of Visual Studio (defined with drive and path); includes the trailing backslash '\\'.|  
|`$(PlatformName)`|The name of the currently targeted platform. For example, "AnyCPU".|  
|`$(ProjectDir)`|The directory of the project (defined with drive and path); includes the trailing backslash '\\'.|  
|`$(ProjectPath)`|The absolute path name of the project (defined with drive, path, base name, and file extension).|  
|`$(ProjectName)`|The base name of the project.|  
|`$(ProjectFileName)`|The file name of the project (defined with base name and file extension).|  
|`$(ProjectExt)`|The file extension of the project. It includes the '.' before the file extension.|  
|`$(SolutionDir)`|The directory of the solution (defined with drive and path); includes the trailing backslash '\\'.|  
|`$(SolutionPath)`|The absolute path name of the solution (defined with drive, path, base name, and file extension).|  
|`$(SolutionName)`|The base name of the solution.|  
|`$(SolutionFileName)`|The file name of the solution (defined with base name and file extension).|  
|`$(SolutionExt)`|The file extension of the solution. It includes the '.' before the file extension.|  
|`$(TargetDir)`|The directory of the primary output file for the build (defined with drive and path). It includes the trailing backslash '\\'.|  
|`$(TargetPath)`|The absolute path name of the primary output file for the build (defined with drive, path, base name, and file extension).|  
|`$(TargetName)`|The base name of the primary output file for the build.|  
|`$(TargetFileName)`|The file name of the primary output file for the build (defined as base name and file extension).|  
|`$(TargetExt)`|The file extension of the primary output file for the build. It includes the '.' before the file extension.|  
  
## See Also  
 [Specifying Custom Build Events in Visual Studio](../VS_IDE/Specifying-Custom-Build-Events-in-Visual-Studio.md)   
 [Build Events Page, Project Designer (C#)](../VS_IDE/Build-Events-Page--Project-Designer--C#-.md)   
 [How to: Specify Build Events (Visual Basic)](../VS_IDE/How-to--Specify-Build-Events--Visual-Basic-.md)   
 [How to: Specify Build Events (C#)](../VS_IDE/How-to--Specify-Build-Events--C#-.md)