---
title: Text Template Control Blocks
description: Learn about text template control blocks and how control blocks let you write code in your text template in order to vary the output.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- text templates, template code
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Text Template Control Blocks

Control blocks let you write code in your text template in order to vary the output. There are three kinds of control blocks, which are distinguished by their opening brackets:

- `<# Standard control blocks #>` can contain statements.

- `<#= Expression control blocks #>` can contain expressions.

- `<#+ Class feature control blocks #>` can contain methods, fields and properties.

## Standard control block
 Standard control blocks contain statements. For example, the following standard block gets the names of all the attributes in the XML document:

```
<#@ assembly name="System.Xml.dll" #>
<#@ import namespace="System.Xml" #>

<#
    List<string> allAttributes = new List<string>();
    XmlDocument xDoc = new XmlDocument();
    xDoc.Load(@"E:\CSharp\Overview.xml");
    XmlAttributeCollection attributes = xDoc.Attributes;
    if (attributes.Count > 0)
    {
       foreach (XmlAttribute attr in attributes)
       {
           allAtributes.Add(attr.Name);
       }
     }
#>
```

 You can embed plain text inside a compound statement such as `if` or `for`. For example, this fragment generates an output line in each loop iteration:

```
<#
       foreach (XmlAttribute attr in attributes)
       {
#>
Found another one!
<#
           allAtributes.Add(attr.Name);
       }
#>
```

> [!WARNING]
> Always use {...} to delimit nested statements that contain embedded plain text. The following example might not work properly:
>
> `<# if (ShouldPrint) #> Some text. -- WRONG`
>
> Instead, you should include {braces}, as follows:

```

<#
 if (ShouldPrint)
 {   //  "{" REQUIRED
#>
Some text.
<#
 }
#>
```

## Expression control block
 Expression control blocks are used for code that provides strings to be written to the output file. For example, with the example above, you can print the names of the attributes to the output file by modifying the code block as follows:

```
<#
    XmlDocument xDoc = new XmlDocument();
    xDoc.Load(@"E:\CSharp\Overview.xml");
    XmlAttributeCollection attributes = xDoc.Attributes;
    if (attributes != null)
    {
       foreach (XmlAttribute attr in attributes)
       {
#><#= attr.Name #><#
       }
    }
#>
```

## Class feature control block
 You can use class feature control blocks to add methods, properties, fields, or even nested classes to your text template. The most common use of class feature blocks is to provide helper functions for code in other parts of the text template. For example, the following class feature block capitalizes the first letter of the attribute name (or, if the name contains whitespace, it capitalizes the first letter of every word):

```
<#@ import namespace="System.Globalization" #>
```

```
<#+
    private string FixAttributeName(string name)
    {
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
    }
#>
```

> [!NOTE]
> A class feature control block must not be followed by standard control blocks in the same template file. However, this restriction does not apply to the result of using `<#@include#>` directives. Each included file can have standard blocks followed by class feature blocks.

 You can create a function that generates output by embedding text and expression blocks inside a class feature control block. For example:

```
<#+
    private void OutputFixedAttributeName(string name)
    {
#>
 Attribute:  <#= CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name) #>
<#+  // <<< Notice that this is also a class feature block.
    }
#>
```

 You could call this function from a standard block or from another class feature block:

```
<# foreach (Attribute attribute in item.Attributes)
{
  OutputFixedAttributeName(attribute.Name);
}
#>
```

## How to use control blocks
 All the code in all the standard and expression control blocks in a single template (including all the code in included templates) is combined to form the `TransformText()` method of the generated code. (For more information about including other text templates with the `include` directive, see [T4 Text Template Directives](../modeling/t4-text-template-directives.md).)

 You should keep in mind the following considerations when you use control blocks:

- **Language.** You can use either C# or Visual Basic code in a text template. The default language is C#, but you can specify Visual Basic with the `language` parameter of the `template` directive. (For more information about the `template` directive, see [T4 Text Template Directives](../modeling/t4-text-template-directives.md).)

     The language you use in control blocks has nothing to do with the language or format of the text you generate in a text template. You can generate C# by using Visual Basic code or vice versa.

     You can use only one language in a given text template, including all the text templates you include with the `include` directive.

- **Local variables.** Since all the code in the standard and expression control blocks in a text template is generated as a single method, you should make certain that there are no conflicts with the names of local variables. If you are including other text templates, you must make sure that variable names are unique across all included templates. One way to ensure this is to add a string to each local variable name identifying the text template in which it was declared.

     It is also a good idea to initialize your local variables to sensible values when you declare them, particularly when you are including multiple text templates.

- **Nesting of control blocks.** Control blocks may not be nested inside each other. You must always terminate a given control block before you open another one. For example, the following shows how to print some text in an expression block as part of a standard control block.

    ```
    <#
    int x = 10;
    while (x-- > 0)
    {
    #>
    <#= x #>
    <# } #>
    ```

- **Refactoring.** In order to keep your text templates short and easy to understand, it is strongly recommended that you avoid repetitive code either by factoring the reusable code into helper functions in class feature blocks or by creating your own text template class that inherits from the Microsoft.VisualStudio.TextTemplating.TextTransformation class.
