---
title: Customizing T4 Text Transformation
description: Learn how you can extend the default template transformation process by customizing the text template directive processor or the text template host.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- text templates, API
- text templates, custom hosts
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Customize T4 Text Transformation

Text templates are a feature of Visual Studio that allow you to generate program code or other text files through a transformation process. Using Visual Studio SDK, you can extend the default template transformation process by customizing the text template directive processor or the text template host.

## In this section

[The Text Template Transformation Process](../modeling/the-text-template-transformation-process.md): Describes how text transformation works, and explains the role of the template host and the directive processors.

 [Creating Custom T4 Text Template Directive Processors](../modeling/creating-custom-t4-text-template-directive-processors.md): The directive processor deals with directives in your template, such as `<#@template#>.` It runs during the compilation of the template, and can load assemblies and other resources. It can also insert code that will load resources at run time. By defining your own directive processor, you can reduce the complexity of your templates.

 [Invoking Text Transformation in a VS Extension](../modeling/invoking-text-transformation-in-a-vs-extension.md): If you are writing a Visual Studio extension such as a menu command or event handler, your extension can use the Text Templating Service to transform any text template. You can pass parameter data into the template by using the Session object, and get the values from within the template by using the `<#@parameter#>` directive.

 [Processing Text Templates by using a Custom Host](../modeling/processing-text-templates-by-using-a-custom-host.md): When the code of the text template executes, the host provides access to external files and the state of the application. For example, the host that runs text transformations in Visual Studio can provide access to **Solution Explorer**. It also displays errors in the error message window. If you want to run text transformations in a different context, you can define your own host that provides access to the services available in that context.

 If you are writing a Visual Studio extension, consider using the existing text transformation service instead of writing your own host. For more information, see [Invoking Text Transformation in a VS Extension](../modeling/invoking-text-transformation-in-a-vs-extension.md).

## Related content

- [Write a T4 text template](../modeling/writing-a-t4-text-template.md) provides the syntax of text template directives and control blocks.
