---
title: T4 Import Directive
description: Learn that in a Visual Studio T4 text template, the import directive allows you to refer to elements in another namespace without providing a fully qualified name.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
author: mgoertz-msft
ms.author: mgoertz
manager: jmartens
ms.technology: vs-ide-modeling
ms.workload:
- multiple
---
# T4 Import Directive

In the code blocks of a Visual Studio T4 text template, the `import` directive allows you to refer to elements in another namespace without providing a fully qualified name. It is the equivalent of `using` in C# or `imports` in [!INCLUDE[vb_current_short](../debugger/includes/vb_current_short_md.md)].

For a general overview of writing T4 text templates, see [Writing a T4 Text Template](../modeling/writing-a-t4-text-template.md).

## Using the Import Directive

```
<#@ import namespace="namespace" #>
```

 In this example, template code can omit an explicit namespace for members of System.IO:

```
<#@ import namespace="System.IO" #>
<#
   string fileContent = File.ReadAllText("C:\x.txt"); // System.IO.File
#>
The file contains: <#=  fileContent #>
```

## Standard Imports
 The following namespace is imported automatically, so that you do not need to write an import directive for it:

- `System`

  In addition, if you use a custom directive, the directive processor might import some namespaces automatically.

  For example, if you write templates for a domain-specific language (DSL), you do not need to write import directives for the following namespaces:

- `Microsoft.VisualStudio.Modeling`

- Your DSL's namespace

## See also

- [T4 Assembly Directive](../modeling/t4-assembly-directive.md)
