---
title: Creating Custom T4 Text Template Directive Processors
description: Learn about the text template transformation process and how to create a custom T4 text template directive processor.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- text templates, custom directive processors
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Create Custom T4 Text Template Directive Processors

The *text template transformation process* takes a *text template* file as the input and produces a text file as the output. The *text template transformation engine* controls the process, and the engine interacts with a text template transformation host and one or more text template *directive processors* to complete the process. For more information, see [The Text Template Transformation Process](../modeling/the-text-template-transformation-process.md).

To create a custom directive processor, you create a class that inherits from either <xref:Microsoft.VisualStudio.TextTemplating.DirectiveProcessor> or <xref:Microsoft.VisualStudio.TextTemplating.RequiresProvidesDirectiveProcessor>.

The difference between these two is that <xref:Microsoft.VisualStudio.TextTemplating.DirectiveProcessor> implements the minimum interface that is necessary to get parameters from the user and to generate the code that produces the template output file. <xref:Microsoft.VisualStudio.TextTemplating.RequiresProvidesDirectiveProcessor> implements the requires/provides design pattern. <xref:Microsoft.VisualStudio.TextTemplating.RequiresProvidesDirectiveProcessor> handles two special parameters, `requires` and `provides`.  For example, a custom directive processor might accept a file name from the user, open and read the file, and then store the text of the file in a variable that is named `fileText`. A subclass of the <xref:Microsoft.VisualStudio.TextTemplating.RequiresProvidesDirectiveProcessor> class might take a file name from the user as the value of the `requires` parameter, and the name of the variable in which to store the text as the value of the `provides` parameter. This processor would open and read the file and then store the text of the file in the specified variable.

Before you call a custom directive processor from a text template in Visual Studio, you must register it.

For more information about how to add the registry key, see [Deploying a Custom Directive Processor](../modeling/deploying-a-custom-directive-processor.md).

## Custom Directives

A custom directive looks like this:

`<#@ MyDirective Processor="MyDirectiveProcessor" parameter1="value1" ... #>`

You can use a custom directive processor when you want to access external data or resources from a text template.

Different text templates can share the functionality that a single directive processor provides, so directive processors provide a way to factor code for reuse. The built-in `include` directive is similar, because you can use it to factor out code and share it among different text templates. The difference is that any functionality that the `include` directive provides is fixed and does not accept parameters. If you want to provide common functionality to a text template and allow the template to pass parameters, you must create a custom directive processor.

Some examples of custom directive processors could be:

- A directive processor to return data from a database that accepts a user name and password as parameters.

- A directive processor to open and read a file that accepts the name of the file as a parameter.

### Principal parts of a custom directive processor

To develop a directive processor, you must create a class that inherits from either <xref:Microsoft.VisualStudio.TextTemplating.DirectiveProcessor> or <xref:Microsoft.VisualStudio.TextTemplating.RequiresProvidesDirectiveProcessor>.

The most important `DirectiveProcessor` methods that you must implement are as follows.

- `bool IsDirectiveSupported(string directiveName)` - Return `true` if your directive processor can deal with the named directive.

- `void ProcessDirective (string directiveName, IDictionary<string, string> arguments)` - The template engine calls this method for each occurrence of a directive in the template. Your processor should save the results.

After all calls to ProcessDirective() the templating engine will call these methods:

- `string[] GetReferencesForProcessingRun()` - Return the names of assemblies that the template code requires.

- `string[] GetImportsForProcessingRun()` - Return the namespaces that can be used in the template code.

- `string GetClassCodeForProcessingRun()` - Return the code of methods, properties, and other declarations that the template code can use. The easiest way to do this is to build a string containing the C# or Visual Basic code. To make your directive processor capable of being called from a template that uses any CLR language, you can construct the statements as a CodeDom tree and then return the result of serializing the tree in the language used by the template.

- For more information, see [Walkthrough: Creating a Custom Directive Processor](../modeling/walkthrough-creating-a-custom-directive-processor.md).

## Related content

- [Deploy a Custom Directive Processor](../modeling/deploying-a-custom-directive-processor.md) explains how to register a custom directive processor.
- [Walkthrough: Create a Custom Directive Processor](../modeling/walkthrough-creating-a-custom-directive-processor.md) describes how to create a custom directive processor, how to register and test the directive processor, and how to format the output file as HTML.
