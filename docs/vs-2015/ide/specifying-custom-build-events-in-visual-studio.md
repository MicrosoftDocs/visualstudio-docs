---
title: "Specifying Custom Build Events"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "build events, customizing"
ms.assetid: 69e935a5-e208-4bcd-865c-3e5f9b047ca8
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: jillfra
---
# Specifying Custom Build Events in Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By specifying a custom build event, you can automatically run commands before a build starts or after it finishes. For example, you can run a .bat file before a build starts or copy new files to a folder after the build is complete. Build events run only if the build successfully reaches those points in the build process.

 For specific information about the programming language that you’re using, see the following topics:

- Visual Basic--[How to: Specify Build Events (Visual Basic)](../ide/how-to-specify-build-events-visual-basic.md).

- Visual C# and F#--[How to: Specify Build Events (C#)](../ide/how-to-specify-build-events-csharp.md).

- Visual C++--[Specifying Build Events](https://msdn.microsoft.com/library/788a6c18-2dbe-4a49-8cd6-86c1ad7a95cc).

## Syntax
 Build events follow the same syntax as DOS commands, but you can use macros to create build events more easily. For a list of available macros, see [Pre-build Event/Post-build Event Command Line Dialog Box](../ide/reference/pre-build-event-post-build-event-command-line-dialog-box.md).

 For best results, follow these formatting tips:

- Add a `call` statement before all build events that run .bat files.

     Example: `call C:\MyFile.bat`

     Example: `call C:\MyFile.bat call C:\MyFile2.bat`

- Enclose file paths in quotation marks.

     Example (for [!INCLUDE[win8](../includes/win8-md.md)]): "%ProgramFiles(x86)%\Microsoft SDKs\Windows\v8.0A\Bin\NETFX 4.0 Tools\gacutil.exe" -if "$(TargetPath)"

- Separate multiple commands by using line breaks.

- Include wildcards as needed.

     Example: `for %I in (*.txt *.doc *.html) do copy %I c:\`*mydirectory*`\`

    > [!NOTE]
    > `%I` in the code above should be `%%I` in batch scripts.

## See Also
 [Compiling and Building](../ide/compiling-and-building-in-visual-studio.md)
 [Pre-build Event/Post-build Event Command Line Dialog Box](../ide/reference/pre-build-event-post-build-event-command-line-dialog-box.md)
 [MSBuild Special Characters](../msbuild/msbuild-special-characters.md)
 [Walkthrough: Building an Application](../ide/walkthrough-building-an-application.md)
