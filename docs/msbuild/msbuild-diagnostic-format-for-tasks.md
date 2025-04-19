---
title: MSBuild and Visual Studio diagnostic message formats
description: Learn the format for diagnostic messages used in Visual Studio tools, which is relevant when writing MSBuild tasks that use these tools, or when creating custom tools that follow the same patterns.
ms.date: 07/05/2022
ms.topic: error-reference
dev_langs:
- VB
- CSharp
- C++
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---

# MSBuild and Visual Studio format for diagnostic messages

When a tool is executed that outputs some text, MSBuild examines the text for errors and warnings. Many tools use a known format to report these messages. By default, MSBuild examines the text and reports errors and/or warnings based on the output. This behavior can be augmented or disabled by using these parameters on the `Exec` task: `IgnoreStandardErrorWarningFormat`, `CustomErrorRegularExpression`, and `CustomWarningRegularExpression`.

> [!NOTE]
> If you do decide to use your own regular expression to detect error and warnings, then you should know that MSBuild will look at the result one line at a time. Even if your custom regex would match something across multiple lines, it will not behave that way because of how MSBuild processes that text.

Take a look at the following four messages, which are all properly formatted and will be recognized by MSBuild and Microsoft Visual Studio:

```output
Main.cs(17,20): warning CS0168: The variable 'x' is declared but never used
C:\dir1\strings.resx(2) : error BC30188: Declaration expected.
cl : Command line warning D4024 : unrecognized source file type 'file1.cs', object . . .
error CS0006: Metadata file 'System.dll' could not be found.
```

These messages conform to the special five-part format shown here. The order of these parts is important and should not change.

`Origin` : `Subcategory` `Category` `Code` : `Text`

For example,

```output
c1 : Command line warning D4024 : unrecognized source file type 'test.xyz'

Origin: c1
Subcategory: Command line
Category: warning
Code: D4024
Text: unrecognized source file type 'test.zyz'
```

Each of the components of this format are described as follows:

- **Origin (Required)** Origin can be blank. If present, the origin is usually a tool name, such as `cl` in one of the examples. But it could also be a file name, such as “Main.cs,” shown in another example. If it is a file name, then it must be an absolute or a relative file name, followed by an optional parenthesized line/column information in one of the following forms:

   ```output
   (line) or (line-line) or (line-col) or (line,col-col) or (line,col,line,col)
   ```

   Lines and columns start at 1 in a file; that is, the beginning of a file is 1, and the leftmost column is 1. If the Origin is a tool name, then it must not change based on locale; that is, it needs to be locale-neutral.

- **Subcategory (Optional)** Subcategory is used to classify the category itself further; it should not be localized.

- **Category (Required)** Category must be either “error” or “warning”. Case does not matter. As with origin, category must not be localized.

- **Code (Optional)** Code identifies an application-specific error code/warning code. Code must not be localized and it must not contain spaces.

- **Text** User-friendly text that explains the error, and it must be localized if you cater to multiple locales.

When MSBuild calls command-line tools (for instance, `csc.exe` or `vbc.exe`), it looks at the output emitted by the tool to the standard out and standard error streams. Any lines that match the error format that I just described will be treated specially; that is, lines that are recognized as errors or warnings will be turned into build errors and warnings, respectively. To see the real benefit of this, you have to be building from within a development tool like Visual Studio or VS Code. Because MSBuild treats these messages specially, they get logged as first-class warnings and errors in the Visual Studio task list. If the Origin specifies line/column information, then double-clicking the message will take you to the source of the error in the offending file.

## Related content

- [Diagnosing task failures](./diagnosing-task-failures.md)
- [Exec task](./exec-task.md)