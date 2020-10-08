---
title: "Text Template Utility Methods | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "text templates, utility methods"
ms.assetid: 8c11f9f7-678b-4f0c-b634-dc78fda699d1
caps.latest.revision: 52
author: jillre
ms.author: jillfra
manager: jillfra
---
# Text Template Utility Methods
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

There are several methods that are always available to you when you write code in a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] text template. These methods are defined in <xref:Microsoft.VisualStudio.TextTemplating.TextTransformation>.

> [!TIP]
> You can also use other methods and services provided by the host environment in a regular (not preprocessed) text template. For example, you can resolve file paths, log errors, and get services provided by [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] and any loaded packages.  For more information, see [Accessing Visual Studio from a Text Template](https://msdn.microsoft.com/0556f20c-fef4-41a9-9597-53afab4ab9e4).

## Write methods
 You can use the `Write()` and `WriteLine()` methods to append text inside a standard code block, instead of using an expression code block. The following two code blocks are functionally equivalent.

##### Code block with an expression block

```
<#
int i = 10;
while (i-- > 0)
    { #>
        <#= i #>
    <# }
#>
```

##### Code block using WriteLine()

```
<#
    int i = 10;
    while (i-- > 0)
    {
        WriteLine((i.ToString()));
    }
#>
```

 You may find it helpful to use one of these utility methods instead of an expression block inside a long code block with nested control structures.

 The `Write()` and `WriteLine()` methods have two overloads, one that takes a single string parameter and one that takes a composite format string plus an array of objects to include in the string (like the `Console.WriteLine()` method). The following two uses of `WriteLine()` are functionally equivalent:

```
<#
    string msg = "Say: {0}, {1}, {2}";
    string s1 = "hello";
    string s2 = "goodbye";
    string s3 = "farewell";

    WriteLine(msg, s1, s2, s3);
    WriteLine("Say: hello, goodbye, farewell");
#>
```

## Indentation methods
 You can use indentation methods to format the output of your text template. The <xref:Microsoft.VisualStudio.TextTemplating.TextTransformation> class has a `CurrentIndent` string property that shows the current indentation in the text template and an `indentLengths` field that is a list of the indentations that have been added. You can add an indentation with the `PushIndent()` method and subtract an indentation with the `PopIndent()` method. If you want to remove all indentations, use the `ClearIndent()` method. The following code block shows the use of these methods:

```
<#
    WriteLine(CurrentIndent + "Hello");
    PushIndent("    ");
    WriteLine(CurrentIndent + "Hello");
    PushIndent("    ");
    WriteLine(CurrentIndent + "Hello");
    ClearIndent();
    WriteLine(CurrentIndent + "Hello");
    PushIndent("    ");
    WriteLine(CurrentIndent + "Hello");
#>
```

 This code block produces the following output:

```
Hello
        Hello
                Hello
Hello
        Hello
```

## Error and warning methods
 You can use error and warning utility methods to add messages to the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Error List. For example, the following code will add an error message to the Error List.

```
<#
  try
  {
    string str = null;
    Write(str.Length.ToString());
  }
  catch (Exception e)
  {
    Error(e.Message);
  }
#>
```

## Access to Host and Service Provider
 The property `this.Host` can provide access to properties exposed by the host that is executing the template. To use `this.Host`, you must set `hostspecific` attribute in the `<@template#>` directive:

 `<#@template ... hostspecific="true" #>`

 The type of `this.Host` depends on the type of host in which the template is executing. In a template that is running in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], you can cast `this.Host` to `IServiceProvider` to gain access to services such as the IDE. For example:

```
EnvDTE.DTE dte = (EnvDTE.DTE) ((IServiceProvider) this.Host)
                       .GetService(typeof(EnvDTE.DTE));
```

## Using a different set of utility methods
 As part of the text generation process, your template file is transformed into a class, which is always named `GeneratedTextTransformation`and inherits from <xref:Microsoft.VisualStudio.TextTemplating.TextTransformation>. If you want to use a different set of methods instead, you can write your own class and specify it in the template directive. Your class must inherit from <xref:Microsoft.VisualStudio.TextTemplating.TextTransformation>.

```
<#@ template inherits="MyUtilityClass" #>
```

 Use the `assembly` directive to reference the assembly where the compiled class can be found.
