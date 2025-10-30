---
title: Generate a text template from a text template
description: Provides information about how to generate a text template from another text template using escape sequences.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- text templates, generating templates from templates
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Generate Templates from Templates By Using Escape Sequences

You can create a text template that creates another text template as its generated text output. To do this, you must use escape sequences to delineate the text template tags. If you do not use escape sequences, your generated text template will have a pre-defined meaning. For more information about using escape sequences in text templates, see [Using Escape Sequences in Text Templates](../modeling/using-escape-sequences-in-text-templates.md).

### To generate a text template from within a text template

- Use the backslash (\\) as an escape character to produce the necessary markup tags within the text template for directives, statements, expressions, and class features in a separate text template file.

    ```
    \<#@ directive \#>
    \<# statement \#>
    \<#= expression \#>
    \<#+ classfeature \#>
    ```

## Example
 The following example uses escape characters to produce a text template from a text template. The `output` directive sets the destination file type to the text template file type (.tt).

```csharp
\<#@ output extension=".tt" \#>
\<#@ assembly name="System.Xml.dll" \#>
\<#@ import namespace="System.Xml" \#>
\<#
XmlDocument xDoc = new XmlDocument();
//System.Diagnostics.Debugger.Break();
    xDoc.Load(@"E:\CSharp\Overview.xml");
    XmlAttributeCollection attributes = xDoc.Attributes;
    if (attributes != null)
    {
       foreach (XmlAttribute attr in attributes)
       {\#>
           \<#= attr.Name \#>
       \<#}
     }
\#>
```

 The generated text output is a text template.

```
<#@ output extension=".tt" #>
<#@ assembly name="System.Xml.dll" #>
<#@ import namespace="System.Xml" #>
<#
XmlDocument xDoc = new XmlDocument();
//System.Diagnostics.Debugger.Break();
    xDoc.Load(@"E:\CSharp\Overview.xml");
    XmlAttributeCollection attributes = xDoc.Attributes;
    if (attributes != null)
    {
       foreach (XmlAttribute attr in attributes)
       {#>
           <#= attr.Name #>
       <#}
     }
#>
```
