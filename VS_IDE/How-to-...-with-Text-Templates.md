---
title: "How to ... with Text Templates"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d1ac2509-0479-47eb-809c-1f171245d0b6
caps.latest.revision: 11
manager: kamrani
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to ... with Text Templates
Text templates in Visual Studio provide a useful way of generating text of any kind. You can use text templates to generate text at run time as part of your application and at design time to generate some of your project code. This topic summarizes the most frequently asked "How do I …?" questions.  
  
 In this topic, multiple answers that are preceded by bullets are alternative suggestions.  
  
 For a general introduction to text templates, read [Code Generation and T4 Text Templates](../VS_IDE/Code-Generation-and-T4-Text-Templates.md).  
  
## How to …  
  
### Generate part of my application code  
 I have a configuration or *model* in a file or a database. One or more parts of my code depend on that model.  
  
-   Generate some of your code files from text templates. For more information, see [Design-Time Code Generation by using T4 Text Templates](../VS_IDE/Design-Time-Code-Generation-by-using-T4-Text-Templates.md) and [What is the best way to start writing a template?](#starting).  
  
### Generate files at run time, passing data into the template  
 At run time, my application generates text files, such as reports, that contain a mixture of standard text and data. I want to avoid writing hundreds of `write` statements.  
  
-   Add a runtime text template to your project. This template creates a class in your code, which you can instantiate and use to generate text. You can pass data to it in the constructor parameters. For more information, see [Run-Time Text Generation with T4 Text Templates](../VS_IDE/Run-Time-Text-Generation-with-T4-Text-Templates.md).  
  
-   If you want to generate from templates that are available only at run time, you can use standard text templates. If you are writing a Visual Studio extension, you can invoke the text templating service. For more information, see [Invoking Text Transformation in a VS Extension](../VS_IDE/Invoking-Text-Transformation-in-a-VS-Extension.md). In other contexts, you can use the text templating engine. For more information, see <xref:Microsoft.VisualStudio.TextTemplating.Engine?qualifyHint=True>.  
  
     Use the <#@parameter#> directive to pass parameters to these templates. For more information, see [T4 Parameter Directive](../VS_IDE/T4-Parameter-Directive.md).  
  
### Read another project file from a template  
 To read a file from the same Visual Studio project as the template:  
  
-   Insert `hostSpecific="true"` into the `<#@template#>` directive.  
  
     In your code, use `this.Host.ResolvePath(filename)` to obtain the full path of the file.  
  
### Invoke methods from a template  
 If the methods already exist, for example, in standard .NET Framework classes:  
  
-   Use the <#@assembly#> directive to load the assembly, and use <#@import#> to set the namespace context. For more information, see [T4 Import Directive](../VS_IDE/T4-Import-Directive.md).  
  
     If you frequently use the same set of assembly and import directives, consider writing a directive processor. In each template, you can invoke the directive processor, which can load the assemblies and the model files and set the namespace context. For more information, see [Creating Custom T4 Text Template Directive Processors](../VS_IDE/Creating-Custom-T4-Text-Template-Directive-Processors.md).  
  
 If you are writing the methods yourself:  
  
-   If you are writing a runtime text template, write a partial class definition that has the same name as your runtime text template. Add the additional methods into this class.  
  
-   Write a class feature control block `<#+ ... #>` in which you can declare methods, properties, and private classes. When the text template is compiled, it is transformed to a class. The standard control blocks `<#...#>` and text are transformed to a single method, and class feature blocks are inserted as separate members. For more information, see [Text Template Control Blocks](../VS_IDE/Text-Template-Control-Blocks.md).  
  
     Methods defined as class features can also include embedded text blocks.  
  
     Consider placing class features in a separate file which you can `<#@include#>` into one or more template files.  
  
-   Write the methods in a separate assembly (class library) and call them from your template. Use the `<#@assembly#>` directive to load the assembly, and `<#@import#>` to set the namespace context. Note that in order to rebuild the assembly while you are debugging it, you might have to stop and restart Visual Studio. For more information, see [T4 Text Template Directives](../VS_IDE/T4-Text-Template-Directives.md).  
  
### Generate many files from one model schema  
 If you often generate files from models that have the same XML or database schema:  
  
-   Consider writing a directive processor. This enables you to replace multiple assembly statements and import statements in each template with a single custom directive. The directive processor can also load and parse the model file. For more information, see [Creating Custom T4 Text Template Directive Processors](../VS_IDE/Creating-Custom-T4-Text-Template-Directive-Processors.md).  
  
### Generate files from a complex model  
  
-   Consider creating a domain-specific language (DSL) to represent the model. This makes it much easier to write the templates, because you use types and properties that reflect the names of the elements in your model. You do not have to parse the file or navigate XML nodes. For example:  
  
     `foreach (Book book in this.Library) { ... }`  
  
     For more information, see [Getting Started with Domain-Specific Languages](../VS_IDE/Getting-Started-with-Domain-Specific-Languages.md) and [Generating Code from a Domain-Specific Language](../VS_IDE/Generating-Code-from-a-Domain-Specific-Language.md).  
  
-   Consider generating code from a UML model. The code does not have to reflect the UML directly. For example, you do not have to generate a class for each class in the UML model. Instead, you could use the UML class diagram to represent a web site, and generate a web page from each UML class. Choose the diagram type closest to your needs. For example, choose activity diagrams to represent any type of work flow. You can define stereotypes to add information appropriate to your application to each type of element.  
  
     Generating from a UML model allows you to draw and edit the model in a diagrammatic form, but without having to design your own diagram type, as you would with a DSL.  
  
     For more information, see [Create models for your app](../VS_IDE/Create-models-for-your-app.md) and [Generate files from a UML model](../VS_IDE/Generate-files-from-a-UML-model.md).  
  
### Get data from Visual Studio  
 To use services provided in Visual Studio, by set the `hostSpecific` attribute and load the `EnvDTE` assembly. For example:  
  
```c#  
<#@ template hostspecific="true" language="C#" #>  
<#@ output extension=".txt" #>  
<#@ assembly name="EnvDTE" #>  
<#  
  IServiceProvider serviceProvider = (IServiceProvider)this.Host;  
  EnvDTE.DTE dte = (EnvDTE.DTE) serviceProvider.GetService(typeof(EnvDTE.DTE));  
#>  
  
Number of projects in this VS solution:  <#= dte.Solution.Projects.Count #>  
  
```  
  
### Execute text templates in the build process  
  
-   For more information, see [Code Generation in a Build Process](../VS_IDE/Code-Generation-in-a-Build-Process.md).  
  
## More general questions  
  
###  <a name="starting"></a> What is the best way to start writing a text template?  
  
1.  Write a specific example of the generated file.  
  
2.  Turn it into a text template by inserting the `<#@template #>` directive, and the directives and code that are required to load the input file or model.  
  
3.  Progressively replace parts of the file with expression and code blocks.  
  
### What is a "model"?  
  
-   The input read by your template. It could be in a file or in a database. It might be XML, or a Visio drawing, or a domain-specific language (DSL), or a UML model, or it could be plain text. It could be spread across several files. Typically more than one template reads one model.  
  
     The implication of the term "model" is that it represents some aspect of your business more directly than the generated program code or other files. For example, it might represent the plan of a communications network that your generated software will supervise.  
  
### What is the benefit of using text templates?  
 Typically, you generate multiple code or other files from one model. The model represents the requirements more directly than the generated code. It omits implementation detail and is written in terms of the requirements, rather than the code. When the requirements change – as they usually do – you can update the model more easily and more reliably than the different parts of the program code.  
  
 Code generation is therefore a valuable tool from the perspective of agile development methods.  
  
### What "best practices" are there for text templates?  
  
-   For more information, see [Guidelines for Writing T4 Text Templates](../VS_IDE/Guidelines-for-Writing-T4-Text-Templates.md).  
  
### What is "T4"?  
  
-   Another name for the Visual Studio text template capabilities described here. The previous version, which was not published, was an abbreviation for "Text Template Transformation".