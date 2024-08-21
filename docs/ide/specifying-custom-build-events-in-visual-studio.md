---
title: Specify custom build events
description: Explore how you can you can automatically run commands in Visual Studio before you start a build of your project or solution or after a build completes.
ms.date: 08/21/2024
ms.subservice: compile-build
ms.topic: concept-article
helpviewer_keywords:
- build events, customizing
author: ghogen
ms.author: ghogen
manager: mijacobs

#customer intent: As a developer, I want to specify build commands in Visual Studio so I can automatically run operations before my build starts or after it completes.
---

# Specify custom build events in Visual Studio

Visual Studio lets you specify custom build commands to run automatically before a build starts or after it finishes. You might create commands to run a *.bat* file before a build starts or copy new files to a folder after the build completes. Custom build events run only when the build successfully reaches the relevant point in the build process.

This article gives an overview of the recommended syntax for custom build commands. If you're looking for information about a specific programming language, see [Visual Basic](how-to-specify-build-events-visual-basic.md), [C# and F#](how-to-specify-build-events-csharp.md), and [Visual C++](/cpp/build/specifying-build-events).

> [!TIP]
> If you want to add complex operations to your build process, explore the [MSBuild customization techniques](../msbuild/customize-your-build.md). For example, you can add build events to generate code files, and properly handle the clean up after a `clean` operation or only run the task when the inputs are out of date.

## Syntax for custom build commands

Build commands follow the same syntax as Windows command prompt commands and you can use macros to easily create the events. For a list of available macros, see [Prebuild event and post-build event command-line dialog](./reference/pre-build-event-post-build-event-command-line-dialog-box.md).

For best results, follow these formatting tips:

- Add a `call` statement before all build events that run *.bat* files.

   Example: `call C:\MyFile.bat`

   Example: `call C:\MyFile.bat call C:\MyFile2.bat`

- Enclose file paths in quotation marks.

   Example: `"%ProgramFiles(x86)%\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\gacutil.exe" -if "$(TargetPath)"`

- Separate multiple commands by using line breaks.

- Include wildcards as needed.

   Example: `for %I in (*.txt *.doc *.html) do copy %I c:\<Directory>\`

  > [!NOTE]
  > For a batch script, replace the variable `%I` in this example with `%%I`.

## Related content

- [Compile and build](compiling-and-building-in-visual-studio.md)
- [MSBuild special characters](../msbuild/msbuild-special-characters.md)
- [Walkthrough: Build an application](walkthrough-building-an-application.md)
