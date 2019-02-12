---
title: Build actions for files
ms.date: 11/19/2018
ms.technology: vs-ide-compile
ms.topic: reference
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Build actions

All files in a Visual Studio project have a build action. The build action controls what happens to the file when the project is compiled.

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Build actions in Visual Studio for Mac](/visualstudio/mac/build-actions).

## Set a build action

To set the build action for a file, open the file's properties in the **Properties** window by selecting the file in **Solution Explorer** and pressing **Alt**+**Enter**. Or, right-click on the file in **Solution Explorer** and choose **Properties**. In the **Properties** window, under the **Advanced** section, use the drop-down list next to **Build Action** to set a build action for the file.

![Build actions for a file in Visual Studio](media/build-actions.png)

## Build action values

Some of the build actions for C# and Visual Basic project files are:

* **None** - The file isn't part of the build in any way. This value can be used for documentation files such as "ReadMe" files, for example.
* **Compile** - The file is passed to the compiler as a source file.
* **Content** - A file marked as **Content** can be retrieved as a stream by calling <xref:System.Windows.Application.GetContentStream%2A?displayProperty=nameWithType>. For ASP.NET projects, these files are included as part of the site when it's deployed.
* **Embedded Resource** - The file is passed to the compiler as a resource to be embedded in the assembly. You can call <xref:System.Reflection.Assembly.GetManifestResourceStream%2A?displayProperty=fullName> to read the file from the assembly.
* **AdditionalFiles** - A non-source text file that's passed to the C# or Visual Basic compiler as input. This build action is mainly used to provide inputs to [analyzers](../code-quality/roslyn-analyzers-overview.md) that are referenced by a project to verify code quality. For more information, see [Use additional files](https://github.com/dotnet/roslyn/blob/master/docs/analyzers/Using%20Additional%20Files.md).

## See also

- [C# compiler options](/dotnet/csharp/language-reference/compiler-options/listed-alphabetically)
- [Visual Basic compiler options](/dotnet/visual-basic/reference/command-line-compiler/compiler-options-listed-alphabetically)
- [Build actions (Visual Studio for Mac)](/visualstudio/mac/build-actions)