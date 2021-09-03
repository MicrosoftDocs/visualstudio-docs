---
title: Decompile .NET code while debugging | Microsoft Docs
description: Generate and embed source code from .NET assemblies while debugging in Visual Studio. Extract and view the embedded source code.
ms.custom: SEO-VS-2020
ms.date: 2/2/2020
ms.topic: how-to
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - decompilation, debugger, exception
  - debugging [Visual Studio], decompilation, source not found
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
monikerRange: '>= vs-2019'
---

# Generate source code from .NET assemblies while debugging

When debugging a .NET application, you may find that you want to view source code that you don't have. For example, breaking on an exception or using the call stack to navigate to a source location.

> [!NOTE]
> * Source code generation (decompilation) is only available for .NET applications and is based on the open source [ILSpy](https://github.com/icsharpcode/ILSpy) project.
> * Decompilation is only available in Visual Studio 2019 16.5 and later.
> * Applying the [SuppressIldasmAttribute](/dotnet/api/system.runtime.compilerservices.suppressildasmattribute) attribute to an assembly or module prevents Visual Studio from attempting decompilation.

## Generate source code

When you're debugging and no source code is available, Visual Studio shows the **Source Not Found** document, or if you don’t have symbols for the assembly, the **No Symbols Loaded** document. Both documents have a **Decompile source code** option that generates C# code for the current location. The generated C# code can then be used just like any other source code. You can view the code, inspect variables,  set breakpoints, and so on.

### No symbols loaded

The following illustration shows the **No Symbols Loaded** message.

![Screenshot of no symbol loaded document](media/decompilation-no-symbol-found.png)

### Source not found

The following illustration shows the **Source Not Found** message.

![Screenshot of source not found document](media/decompilation-no-source-found.png)

## Generate and embed sources for an assembly

In addition to generating source code for a specific location, you can generate all the source code for a given .NET assembly. To do this, go to the **Modules** window and from the context menu of a .NET assembly, and then select the **Decompile source code** command. Visual Studio generates a symbol file for the assembly and then embeds the source into the symbol file. In a later step, you can [extract](#extract-and-view-the-embedded-source-code) the embedded source code.

![Screenshot of assembly context menu in modules window with decompile source command.](media/decompilation-decompile-source-code.png)

## Extract and view the embedded source code

You can extract source files that are embedded in a symbol file using the **Extract Source Code** command in the context menu of the **Modules** window.

![Screenshot of assembly context menu in modules window with extract sources command.](media/decompilation-extract-source-code.png)

The extracted source files are added to the solution as [miscellaneous files](../ide/reference/miscellaneous-files.md). The miscellaneous files feature is off by default in Visual Studio. You can enable this feature from the **Tools** > **Options** > **Environment** > **Documents** > **Show Miscellaneous files in Solution Explorer** checkbox. Without enabling this feature, you won't be able to open the extracted source code.

![Screenshot of tools option page with miscellaneous files option enabled.](media/decompilation-tools-options-misc-files.png)

Extracted source files appear in the miscellaneous files in **Solution Explorer**.

![Screenshot of solution explorer with miscellaneous files.](media/decompilation-solution-explorer.png)

## Known limitations

### Requires break mode

Generating source code using decompilation is only possible when the debugger is in break mode and the application is paused. For example, Visual Studio enters break mode when it hits a breakpoint or an exception. You can easily trigger Visual Studio to break the next time your code runs by using the **Break All** command (![Break all icon](media/decompilation-break-all.png)).

### Decompilation limitations

Generating source code from the intermediate format (IL) that is used in .NET assemblies has some inherent limitations. As such, the generated source code doesn't look like the original source code. Most of the differences are in places where the information in the original source code isn't needed at runtime. For example, information such as whitespace, comments, and the names of local variables aren't needed at runtime. We recommend that you use the generated source to understand how the program is executing and not as a replacement for the original source code.

### Debug optimized or release assemblies

When debugging code that was decompiled from an assembly that was compiled using compiler optimizations, you may come across the following issues:
- Breakpoints may not always bind to the matching sourcing location.
- Stepping may not always step to the correct location.
- Local variables may not have accurate names.
- Some variables may not be available for evaluation.

More details can be found in the GitHub issue: [ICSharpCode.Decompiler integration into VS Debugger](https://github.com/icsharpcode/ILSpy/issues/1901).

### Decompilation reliability

A relatively small percentage of decompilation attempts may result in failure. This is due to a sequence point null-reference error in ILSpy.  We have mitigated the failure by catching these issues and gracefully failing the decompilation attempt.

More details can be found in the GitHub issue: [ICSharpCode.Decompiler integration into VS Debugger](https://github.com/icsharpcode/ILSpy/issues/1901).

### Limitations with async code

The results from decompiling modules with async/await code patterns may be incomplete or fail entirely. The ILSpy implementation of async/await and yield state-machines is only partially implemented. 

More details can be found in the GitHub issue: [PDB Generator Status](https://github.com/icsharpcode/ILSpy/issues/1422).

### Just My Code

The [Just My Code (JMC)](./just-my-code.md) settings allows Visual Studio to step over system, framework, library, and other non-user calls. During a debugging session, the **Modules** window shows which code modules the debugger is treating as My Code (user code).

Decompilation of optimized or release modules produces non-user code. If the debugger breaks in your decompiled non-user code, for example, the **No Source** window appears. To disable Just My Code, navigate to **Tools** > **Options** (or **Debug** > **Options**) > **Debugging** > **General**, and then deselect **Enable Just My Code**.

### Extracted sources

Source code extracted from an assembly has the following limitations:
- The name and location of the generated files isn't configurable.
- The files are temporary and will be deleted by Visual Studio.
- The files are placed in a single folder and any folder hierarchy that the original sources had isn't used.
- The file name for each file contains a checksum hash of the file.

### Generated code is C# only
Decompilation only generates source code files in C#. There is no option to generate files in any other language.