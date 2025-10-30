---
title: Processing Text Templates by using a Custom Host
description: Learn that the text template transformation process takes a text template file as the input and produces a text file as the output.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- text templates, in application or VS extension
- text templates, custom directive hosts
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Process Text Templates by using a Custom Host

The *text template transformation* process takes a *text template* file as the input and produces a text file as the output. You can call the text transformation engine from a Visual Studio extension, or from a standalone application running on a machine on which Visual Studio is installed. However, you must provide a *text templating host*. This class connects the template to the environment, finding resources such as assemblies and include files, and dealing with the output and error messages.

> [!TIP]
> If you are writing a package or extension that will run within Visual Studio, consider using the text templating service, instead of writing your own host. For more information, see [Invoking Text Transformation in a VS Extension](../modeling/invoking-text-transformation-in-a-vs-extension.md).

> [!NOTE]
> We do not recommend using text template transformations in server applications. We do not recommend using text template transformations except in a single thread. This is because the text templating Engine re-uses a single AppDomain to translate, compile, and execute templates. The translated code is not designed to be thread-safe. The Engine is designed to process files serially, as they are in a Visual Studio project at design time.
>
> For run-time applications, consider using preprocessed text templates: see [Run-Time Text Generation with T4 Text Templates](../modeling/run-time-text-generation-with-t4-text-templates.md).

If your application uses a set of templates that are fixed at compile time, it is easier to use Preprocessed Text Templates. You can also use that approach if your application will run on a machine on which Visual Studio is not installed. For more information, see [Run-Time Text Generation with T4 Text Templates](../modeling/run-time-text-generation-with-t4-text-templates.md).

## Execute a Text Template in Your Application

To execute a text template, you call the ProcessTemplate method of <xref:Microsoft.VisualStudio.TextTemplating.Engine?displayProperty=fullName>:

```csharp
using Microsoft.VisualStudio.TextTemplating;
...
Engine engine = new Engine();
string output = engine.ProcessTemplate(templateString, host);
```

 Your application must find and provide the template, and must deal with the output.

 In the `host` parameter, you must provide a class that implements [ITextTemplatingEngineHost](/previous-versions/visualstudio/visual-studio-2012/bb126505(v=vs.110)). This is called back by the Engine.

 The host must be able to log errors, resolve references to assembly and include files, provide an Application Domain in which the template can execute, and call the appropriate processor for each directive.

 <xref:Microsoft.VisualStudio.TextTemplating.Engine?displayProperty=fullName> is defined in **Microsoft.VisualStudio.TextTemplating.\*.0.dll**, and [ITextTemplatingEngineHost](/previous-versions/visualstudio/visual-studio-2012/bb126505(v=vs.110)) is defined in **Microsoft.VisualStudio.TextTemplating.Interfaces.\*.0.dll**.

## In this section

[Walkthrough: Creating a Custom Text Template Host](../modeling/walkthrough-creating-a-custom-text-template-host.md) shows you how to create a custom text template host that makes the text template functionality available outside Visual Studio.

## Reference

[ITextTemplatingEngineHost](/previous-versions/visualstudio/visual-studio-2012/bb126505(v=vs.110))

## Related content

- [The Text Template Transformation Process](../modeling/the-text-template-transformation-process.md) describes how text transformation works, and which parts you can customize.
- [Creating Custom T4 Text Template Directive Processors](../modeling/creating-custom-t4-text-template-directive-processors.md) provides an overview of text template directive processors.
