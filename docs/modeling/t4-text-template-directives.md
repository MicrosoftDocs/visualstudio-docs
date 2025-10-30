---
title: T4 Text Template Directives
description: Learn about T4 test template directives and how they provide instructions to the text template transformation engine.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- text templates, import directive
- text templates, include directive
- text templates, assembly directive
- text templates, output directive
- text templates, directives
- text templates, template directive
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# T4 Text Template Directives

Directives provide instructions to the text template transformation engine.

The syntax of directives is as follows:

```
<#@ DirectiveName [AttributeName = "AttributeValue"] ... #>
```

All attribute values must be surrounded by double quotation marks. If the value itself contains quotation marks, they must be escaped with the \ character.

Directives are typically the first elements in a template file or an included file. You should not place them inside a code block `<#...#>`, nor after a class feature block `<#+...#>`.

[T4 Template Directive](../modeling/t4-template-directive.md)

```
<#@ template [language="VB"] [hostspecific="true|TrueFromBase"] [debug="true"] [inherits="templateBaseClass"] [culture="code"] [compilerOptions="options"] [visibility="internal"] [linePragmas="false"] #>
```

[T4 Parameter Directive](../modeling/t4-parameter-directive.md)

```
<#@ parameter type="Full.TypeName" name="ParameterName" #>
```

[T4 Output Directive](../modeling/t4-output-directive.md)

```
<#@ output extension=".fileNameExtension" [encoding="encoding"] #>
```

[T4 Assembly Directive](../modeling/t4-assembly-directive.md)

```
<#@ assembly name="[assembly strong name|assembly file name]" #>
```

[T4 Import Directive](../modeling/t4-import-directive.md)

```
<#@ import namespace="namespace" #>
```

[T4 Include Directive](../modeling/t4-include-directive.md)

```
<#@ include file="filePath" #>
```

[T4 CleanUpBehavior directive](../modeling/t4-cleanupbehavior-directive.md)

```
<#@ CleanupBehavior processor="T4VSHost" CleanupAfterProcessingtemplate="true" #>
```

In addition, you can create your own directives. For more information, see [Creating Custom T4 Text Template Directive Processors](../modeling/creating-custom-t4-text-template-directive-processors.md). If you use the Visualization and Modeling SDK to create a domain-specific language (DSL), a directive processor will be generated as part of your DSL.
