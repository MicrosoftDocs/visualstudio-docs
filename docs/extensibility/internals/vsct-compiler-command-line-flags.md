---
title: VSCT Compiler Command-Line Flags
description: The Visual Studio Command Table compiler provides command-line options to ensure successful compilation of .vsct files.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- VSCT files, compiling
- command-table file compilation (VSCT files)
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# VSCT Compiler Command-Line Flags

The Visual Studio Command Table (VSCT) compiler provides command-line switches to ensure successful compilation of .vsct files.

## Command Line Parameters
 To view basic VSCT help from a Visual Studio **Command** window, navigate to the *Visual Studio SDK installation path*\VisualStudioIntegration\Tools\Bin\ folder and type:

```
vsct /?
```

 This returns:

```
Microsoft (R) Visual Studio (R) Command Table Compiler Version 3.00.2000

Syntax: vsct <infile> [<outfile>] [-S[symbols file]] [-D<preprocessor-define>]*
[-I<include-path>]* [-L<language>] [-E[C|H|N]:<name>]

  -D    Specify any additional preprocessor defines
  -I    Indicate what additional include paths to send to the preprocessor
  -L    Specify the language to use when selecting strings
  -E    Emit C# objects in the specified namespace for command items,
        followed by [L|F|H|N]:<value>
        F = Name of the file to emit (used if -EL is provided)
        L = Name of a language providing a CodeDOM provider
        N = namespace (required if -EL is provided)
        H = C++ header
  -c    Clean build skipping dependency checks
  -v    Verbose output
```

> [!NOTE]
> The characters - (dash) and / (forward slash) are both accepted notation for indicating command-line parameters.

 Acceptable flags and what they mean are as follows.

|Switch|Description|
|------------|-----------------|
|-D|Specify any additional defined symbols.|
|-I|Indicate the additional include paths that should be used when resolving file references.|
|-L|Specify the <xref:System.Globalization.CultureInfo> culture name, for example "en-US".|
|-E|Emit C# objects in the specified namespace for command items, followed by [C&#124;H&#124;N]:*filename*where C = C#, H = C++ header, N = namespace. The namespace is required for C#.|
|-v|Verbose output.|

 The -L switch instructs the compiler to select a group of strings to produce the binary .cto file that corresponds to the given <xref:System.Globalization.CultureInfo> culture name. The specified culture name should match the Language attribute of one or more [Strings Element](../../extensibility/strings-element.md) in the .vsct file. If a Strings element has no Language attribute, it is inherited from the containing [CommandTable Element](../../extensibility/commandtable-element.md).

 A .vsct file may have multiple Strings elements, and each may have a different Language attribute. Globalization is achieved by running the VSCT compiler multiple times and changing the -L switch for each culture name.

 If the culture name given by the -L switch does not match the Language attribute of any Strings element, the compiler will try to match the language, and not the region. For example, if "en-US" cannot be found, the compiler will try "en" instead. Failing that, it will try the current culture of the operating system. Failing that, it will compile the first Strings element it finds.

 The -E switch can be used to emit a C-style header file that contains the symbols that are used by the command table, or to emit a C# file that contains objects for the command symbols.

 The -D and -I switches have the syntax of the Cl.exe C preprocessor flags that have the same name. -D definitions that have the format X=Y are used for the expansion of XML-based \<Defined> tests in `Condition` attributes. -I include paths are used to resolve \<Include>, \<Extern> and \<Bitmap> file references. For more information, see the [VSCT XML Schema Reference](../../extensibility/vsct-xml-schema-reference.md).

 The VSCT compiler can also decompile a previously built binary file. To do this, supply a binary file for the \<infile>.   If the binary file was produced by the VSCT compiler, it will have its symbols already embedded and will produce output with the symbolic names in a \<Symbols> section of the output. If the binary was produced by the CTC compiler, the output will contain the actual GUIDs and IDs. If the *.ctsym file that is produced by current versions of Ctc.exe is in the same folder as the binary input file, the symbols will be loaded from that file and used for output.

## See also
- [Visual Studio Command Table (.Vsct) Files](../../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
- [VSCT XML Schema Reference](../../extensibility/vsct-xml-schema-reference.md)
- [How VSPackages Add User Interface Elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md)
