---
title: "Specifying Custom Build Events in Visual Studio"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 69e935a5-e208-4bcd-865c-3e5f9b047ca8
caps.latest.revision: 13
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
# Specifying Custom Build Events in Visual Studio
By specifying a custom build event, you can automatically run commands before a build starts or after it finishes. For example, you can run a .bat file before a build starts or copy new files to a folder after the build is complete. Build events run only if the build successfully reaches those points in the build process.  
  
 For specific information about the programming language that you’re using, see the following topics:  
  
-   Visual Basic--[How to: Specify Build Events (Visual Basic)](../VS_IDE/How-to--Specify-Build-Events--Visual-Basic-.md).  
  
-   Visual C# and F#--[How to: Specify Build Events (C#)](../VS_IDE/How-to--Specify-Build-Events--C#-.md).  
  
-   Visual C++--[Specifying Build Events](../Topic/Specifying%20Build%20Events.md).  
  
## Syntax  
 Build events follow the same syntax as DOS commands, but you can use macros to create build events more easily. For a list of available macros, see [Pre-build Event/Post-build Event Command Line Dialog Box](../VS_IDE/Pre-build-Event-Post-build-Event-Command-Line-Dialog-Box.md).  
  
 For best results, follow these formatting tips:  
  
-   Add a `call` statement before all build events that run .bat files.  
  
     Example: `call C:\MyFile.bat`  
  
     Example: `call C:\MyFile.bat call C:\MyFile2.bat`  
  
-   Enclose file paths in quotation marks.  
  
     Example (for Windows 8): "%ProgramFiles(x86)%\Microsoft SDKs\Windows\v8.0A\Bin\NETFX 4.0 Tools\gacutil.exe" -if "$(TargetPath)"  
  
-   Separate multiple commands by using line breaks.  
  
-   Include wildcards as needed.  
  
     Example: `for %I in (*.txt *.doc *.html) do copy %I c:\`*mydirectory*`\`  
  
    > [!NOTE]
    >  `%I` in the code above should be `%%I` in batch scripts.  
  
## See Also  
 [Compiling and Building](../VS_IDE/Compiling-and-Building-in-Visual-Studio.md)   
 [Pre-build Event/Post-build Event Command Line Dialog Box](../VS_IDE/Pre-build-Event-Post-build-Event-Command-Line-Dialog-Box.md)   
 [MSBuild Special Characters](../VS_IDE/MSBuild-Special-Characters.md)   
 [Walkthrough: Building an Application](../VS_IDE/Walkthrough--Building-an-Application.md)