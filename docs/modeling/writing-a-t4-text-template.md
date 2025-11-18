---
title: Writing a T4 Text Template
description: Work with T4 text templates in Visual Studio and how to write a text template that includes directives, text blocks, and control blocks.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- text templates, syntax
- text templates, guide
- text templates, functions that generate text
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Writing a T4 Text Template

A text template contains the text that will be generated from it. For example, a template that creates a web page will contain "\<html>..." and all the other standard parts of an HTML page. Inserted into the template are *control blocks*, which are fragments of program code. Control blocks provide varying values and allow parts of the text to be conditional and repeated.

 This structure makes a template easy to develop, because you can start with a prototype of the generated file, and incrementally insert control blocks that vary the result.

 Text templates are composed of the following parts:

- **Directives** - elements that control how the template is processed.

- **Text blocks** - content that is copied directly to the output.

- **Control blocks** - program code that inserts variable values into the text, and controls conditional or repeated parts of the text.

To try the examples in this topic, copy them into a template file as described in [Design-Time Code Generation by using T4 Text Templates](../modeling/design-time-code-generation-by-using-t4-text-templates.md). After editing the template file, save it, and then inspect the output **.txt** file.

## Directives
 Text template directives provide general instructions to the text templating engine about how to generate the transformation code and the output file.

 For example, the following directive specifies that the output file should have a .txt extension:

```
<#@ output extension=".txt" #>
```

 For more information about directives, see [T4 Text Template Directives](../modeling/t4-text-template-directives.md).

## Text blocks
 A text block inserts text directly into the output file. There is no special formatting for text blocks. For example, the following text template will produce a text file that contains the word "Hello":

```
<#@ output extension=".txt" #>
Hello
```

## Control blocks
 Control blocks are sections of program code that are used to transform the templates. The default language is C#, but to use Visual Basic, you can write this directive at the beginning of the file:

```
<#@ template language="VB" #>
```

 The language in which you write the code in the control blocks is unrelated to the language of the text that is generated.

### Standard control blocks
 A standard control block is a section of program code that generates part of the output file.

 You can mix any number of text blocks and standard control blocks in a template file. However, you cannot place one control block inside another. Each standard control block is delimited by the symbols `<# ... #>`.

 For example, the following control block and text block cause the output file to contain the line "0, 1, 2, 3, 4 Hello!":

```
<#
    for(int i = 0; i < 4; i++)
    {
        Write(i + ", ");
    }
    Write("4");
#> Hello!
```

 Instead of using explicit `Write()` statements, you can interleave text and code. The following example prints "Hello!" four times:

```
<#
    for(int i = 0; i < 4; i++)
    {
#>
Hello!
<#
    }
#>
```

 You can insert a text block wherever a `Write();` statement would be allowed in the code.

> [!NOTE]
> When you embed a text block within a compound statement such as a loop or conditional, always use braces {...} to contain the text block.

### Expression control blocks
 An expression control block evaluates an expression and converts it to a string. This is inserted into the output file.

 Expression control blocks are delimited by the symbols `<#= ... #>`

 For example, the following control block causes the output file to contain "5":

```
<#= 2 + 3 #>
```

 Notice that the opening symbol has three characters "<#=".

 The expression can include any variable that is in scope. For example, this block prints lines with numbers:

```
<#@ output extension=".txt" #>
<#
    for(int i = 0; i < 4; i++)
    {
#>
This is hello number <#= i+1 #>: Hello!
<#
    }
#>
```

### Class feature control blocks
 A class feature control block defines properties, methods, or any other code that should not be included in the main transform. Class feature blocks are frequently used for helper functions.  Typically, class feature blocks are placed in separate files so that they can be [included](#Include) by more than one text template.

 Class feature control blocks are delimited by the symbols `<#+ ... #>`

 For example, the following template file declares and uses a method:

```
<#@ output extension=".txt" #>
Squares:
<#
    for(int i = 0; i < 4; i++)
    {
#>
    The square of <#= i #> is <#= Square(i+1) #>.
<#
    }
#>
That is the end of the list.
<#+   // Start of class feature block
private int Square(int i)
{
    return i*i;
}
#>
```

 Class features must be placed at the end of the file in which they are written. However, you can `<#@include#>` a file that contains a class feature, even if the `include` directive is followed by standard blocks and text.

 For more information about control blocks, see [Text Template Control Blocks](../modeling/text-template-control-blocks.md).

### Class feature blocks can contain text blocks
 You can write a method that generates text. For example:

```
List of Squares:
<#
   for(int i = 0; i < 4; i++)
   {  WriteSquareLine(i); }
#>
End of list.
<#+   // Class feature block
private void WriteSquareLine(int i)
{
#>
   The square of <#= i #> is <#= i*i #>.
<#+
}
#>
```

 It is particularly useful to place a method that generates text in a separate file that can be included by more than one template.

## Using external definitions

### Assemblies
 The code blocks of your template can use types that are defined the most frequently used .NET assemblies such as System.dll. In addition, you can reference other .NET assemblies or your own assemblies. You can provide a pathname, or the strong name of an assembly:

```
<#@ assembly name="System.Xml" #>
```

 You should use absolute path names, or use standard macro names in the path name. For example:

```
<#@ assembly name="$(SolutionDir)library\MyAssembly.dll" #>
```

 The assembly directive has no effect in a [preprocessed text template](../modeling/run-time-text-generation-with-t4-text-templates.md).

 For more information, see [T4 Assembly Directive](../modeling/t4-assembly-directive.md).

### Namespaces
 The import directive is the same as the `using` clause in C# or the `imports` clause in Visual Basic. It allows you to refer to types in your code without using a fully qualified name:

```
<#@ import namespace="System.Xml" #>
```

 You can use as many `assembly` and `import` directives as you want. You must place them before text and control blocks.

 For more information, see [T4 Import Directive](../modeling/t4-import-directive.md).

### <a name="Include"></a> Including code and text
 The `include` directive inserts text from another template file. For example, this directive inserts the content of `test.txt`.

```
<#@ include file="c:\test.txt" #>
```

 The included content is processed almost as if it were part of the including text template. However, you can include a file that contains a class feature block `<#+...#>` even if the include directive is followed by ordinary text and standard control blocks.

 For more information, see [T4 Include Directive](../modeling/t4-include-directive.md).

### Utility methods
 There are several methods such as `Write()` that are always available to you in a control block. They include methods for helping you indent the output, and for reporting errors.

 You can also write your own set of utility methods.

 For more information, see [Text Template Utility Methods](../modeling/text-template-utility-methods.md).

## Transforming Data and Models
 The most useful application for a text template is to generate material based on the content of a source such as a model, database, or data file. Your template extracts and reformats the data. A collection of templates can transform such a source into multiple files.

 There are several approaches to reading the source file.

 **Read a file in the text template**. This is simplest way to get data into the template:

```
<#@ import namespace="System.IO" #>
<# string fileContent = File.ReadAllText(@"C:\myData.txt"); ...
```

 **Load a file as a navigable model**. A more powerful method is to read the data as a model, which your text template code can navigate. For example, you can load an XML file and navigate it with XPath expressions. You could also use [xsd.exe](/dotnet/standard/serialization/xml-schema-definition-tool-xsd-exe) to create a set of classes with which you can read the XML data.

 **Edit the model file in a diagram or form.** Domain-Specific Language Tools provides tools that let you edit a model as a diagram or Windows form. This makes it easier to discuss the model with users of the generated application. Domain-Specific Language Tools also creates a set of strongly-typed classes that reflect the structure of the model. For more information, see [Generating Code from a Domain-Specific Language](../modeling/generating-code-from-a-domain-specific-language.md).

### Relative file paths in design-time templates
 In a [design-time text template](../modeling/design-time-code-generation-by-using-t4-text-templates.md), if you want to reference a file in a location relative to the text template, use `this.Host.ResolvePath()`. You must also set `hostspecific="true"` in the `template` directive:

```
<#@ template hostspecific="true" language="C#" #>
<#@ output extension=".txt" #>
<#@ import namespace="System.IO" #>
<#
 // Find a path within the same project as the text template:
 string myFile = File.ReadAllText(this.Host.ResolvePath("MyFile.txt"));
#>
Content of MyFile.txt is:
<#= myFile #>
```

You can also obtain other services that are provided by the host. For more information, see [Accessing Visual Studio or other Hosts from a Template](/previous-versions/visualstudio/visual-studio-2010/gg604090\(v\=vs.100\)).

### Design-time Text Templates run in a separate AppDomain

 You should be aware that a [design-time text template](../modeling/design-time-code-generation-by-using-t4-text-templates.md) runs in an AppDomain that is separate from the main application. In most cases this is not important, but you might discover restrictions in certain complex cases. For example, if you want to pass data in or out of the template from a separate service, then the service must provide a serializable API.

 (This isn't true of a [run-time text template](../modeling/run-time-text-generation-with-t4-text-templates.md), which provides code that is compiled along with the rest of your code.)

## Editing Templates
 Specialized text template editors can be downloaded from the Extension Manager Online Gallery. On the **Tools** menu, click **Extension Manager**. Click **Online Gallery**, and then use the search tool.

## Related content

- [Guidelines for Writing T4 Text Templates](../modeling/guidelines-for-writing-t4-text-templates.md)
- [Text Template Structure](../modeling/writing-a-t4-text-template.md)
- [Design-Time Code Generation by using T4 Text Templates](../modeling/design-time-code-generation-by-using-t4-text-templates.md)
- [Generating Files with the TextTransform Utility](../modeling/generating-files-with-the-texttransform-utility.md)
- [Generating Code from a Domain-Specific Language](../modeling/generating-code-from-a-domain-specific-language.md)
- [Customizing T4 Text Transformation](../modeling/customizing-t4-text-transformation.md)
