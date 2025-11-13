---
title: Guidelines for Writing T4 Text Templates
description: Review helpful guidelines for generating program code or other application resources in Visual Studio with T4 text templates.
ms.date: 11/04/2016
ms.topic: article
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Guidelines for Writing T4 Text Templates

These general guidelines might be helpful if you are generating program code or other application resources in Visual Studio. They are not fixed rules.

## Guidelines for Design-Time T4 Templates

Design-time T4 templates are templates that generate code in your Visual Studio project at design time. For more information, see [Design-Time Code Generation by using T4 Text Templates](../modeling/design-time-code-generation-by-using-t4-text-templates.md).

Generate variable aspects of the application.

Code generation is most useful for those aspects of the application that might change during the project, or will change between different versions of the application. Separate these variable aspects from the more invariant aspects so that you can more easily determine what has to be generated. For example, if your application provides a website, separate the standard page serving functions from the logic that defines the navigation paths from one page to another.

Encode the variable aspects in one or more source models.

A model is a file or database that each template reads to obtain specific values for variable parts of the code that is to be generated. Models can be databases, XML files of your own design, diagrams, or domain-specific languages. Typically, one model is used to generate many files in a Visual Studio project. Each file is generated from a separate template.

You can use more than one model in a project. For example, you might define a model for navigation between web pages, and a separate model for the layout of the pages.

Focus the model on the users' needs and vocabulary, not on your implementation.

For example, in a website application, you would expect the model to refer to web pages and hyperlinks.

Ideally, choose a form of presentation that suits the kind of information that the model represents. For example, a model of navigation paths through a website could be a diagram of boxes and arrows.

Test the generated code.

Use manual or automated tests to verify that the resulting code works as the users require. Avoid generating tests from the same model from which the code is generated.

In some cases, general tests can be performed on the model directly. For example, you could write a test that ensures that every page in the website can be reached by navigation from any other.

Allow for custom code: generate partial classes.

Allow for code that you write by hand in addition to the generated code. It is unusual for a code generation scheme to be able to account for all possible variations that might arise. Therefore, you should expect to add to or override some of the generated code. Where the generated material is in a .NET language such as C# or Visual Basic, two strategies are especially useful:

- The generated classes should be partial. This lets you to add content to the generated code.

- Classes should be generated in pairs, one inheriting from the other. The base class should contain all the generated methods and properties, and the derived class should contain only the constructors. This allows your hand-written code to override any of the generated methods.

In other generated languages such as XML, use the `<#@include#>` directive to make simple combinations of hand-written and generated content. In more complex cases, you might have to write a post-processing step that combines the generated file with any hand-written files.

Move common material into include files or run-time templates.

To avoid repeating similar blocks of text and code in multiple templates, use the `<#@ include #>` directive. For more information, see [T4 Include Directive](../modeling/t4-include-directive.md).

You can also build run-time text templates in a separate project, and then call them from the design-time template. To do this, use the `<#@ assembly #>` directive to access the separate project.

Consider moving large blocks of code into a separate assembly.

If you have large code blocks and class feature blocks, it might be useful to move some of this code into methods that you compile in a separate project. You can use the `<#@ assembly #>` directive to access the code in the template. For more information, see [T4 Assembly Directive](../modeling/t4-assembly-directive.md).

You can put the methods in an abstract class that the template can inherit. The abstract class must inherit from <xref:Microsoft.VisualStudio.TextTemplating.TextTransformation?displayProperty=fullName>. For more information, see [T4 Template Directive](../modeling/t4-template-directive.md).

Generate code, not configuration files.

One method of writing a variable application is to write generic program code that accepts a configuration file. An application written in this manner is very flexible, and can be reconfigured when the business requirements change, without rebuilding the application. However, a drawback of this approach is that the application will perform less well than a more specific application. Also, its program code will be more difficult to read and maintain, partly because it has always to deal with the most generic types.

By contrast, an application whose variable parts are generated before compilation can be strongly typed. This makes it much easier and more reliable to write hand-written code and integrate it with the generated parts of the software.

To obtain the full benefit of code generation, try to generate program code instead of configuration files.

Use a Generated Code folder.

Place the templates and the generated files in a project folder named **Generated Code**, to make it clear that these are not files that should be edited directly. If you create custom code to override or add to the generated classes, place those classes in a folder that is named **Custom Code**. The structure of a typical project looks like this:

```
MyProject
   Custom Code
      Class1.cs
      Class2.cs
   Generated Code
      Class1.tt
          Class1.cs
      Class2.tt
          Class2.cs
   AnotherClass.cs
```

## Guidelines for Run-Time (Preprocessed) T4 Templates

Move common material into inherited templates.

You can use inheritance to share methods and text blocks between T4 text templates. For more information, see [T4 Template Directive](../modeling/t4-template-directive.md).

You can also use include files that have run-time templates.

Move large bodies of code into a partial class.

Each run-time template generates a partial class definition that has the same name as the template. You can write a code file that contains another partial definition of the same class. You can add methods, fields, and constructors to the class in this manner. These members can be called from the code blocks in the template.

An advantage of doing this is that the code is easier to write, because IntelliSense is available. Also, you can achieve a better separation between the presentation and the underlying logic.

For example, in **MyReportText.tt**:

`The total is: <#= ComputeTotal() #>`

In **MyReportText-Methods.cs**:

`private string ComputeTotal() { ... }`

Allow for custom code: provide extension points.

Consider generating virtual methods in \<#+ class feature blocks #>. This allows a single template to be used in many contexts without modification. Instead of modifying the template, you can construct a derived class which supplies the minimum additional logic. The derived class can be either regular code, or it can be a run-time template.

For example, in MyStandardRunTimeTemplate.tt:

```
This page is copyright <#= CompanyName() #>.
<#+ protected virtual string CompanyName() { return ""; } #>
```

In the code of an application:

```
class FabrikamTemplate : MyStandardRunTimeTemplate
{
  protected override string CompanyName() { return "Fabrikam"; }
}
...
  string PageToDisplay = new FabrikamTemplate().TextTransform();
```

## Guidelines for All T4 Templates

Separate data-gathering from text generation.

Try to avoid mixing computation and text blocks. In each text template, use the first \<# code block #> to set variables and perform complex computations. From the first text block down to the end of the template or the first \<#+ class feature block #>, avoid long expressions, and avoid loops and conditionals unless they contain text blocks. This practice makes the template easier to read and maintain.

Don't use `.tt` for include files.

Use a different file name extension such as `.ttinclude` for include files. Use `.tt` only for files that you want to be processed either as run-time or design-time text templates. In some cases, Visual Studio recognizes `.tt` files and automatically sets their properties for processing.

Start each template as a fixed prototype.

Write an example of the code or text that you want to generate, and make sure that it is correct. Then change its extension to .tt and incrementally insert code that modifies the content by reading the model.

Consider using typed models.

Although you can create an XML or database schema for your models, it might be useful to create a domain specific language (DSL). A DSL has the advantage that it generates a class to represent each node in the schema, and properties to represent the attributes. This means that you can program in terms of the business model. For example:

```
Team Members:
<# foreach (Person p in team.Members)
 { #>
    <#= p.Name #>
<# } #>
```

Consider using diagrams for your models.

Many models are most effectively presented and managed simply as text tables, especially if they are very large.

However, for some kinds of business requirements, it is important to clarify complex sets of relationships and work flows, and diagrams are the best suited medium. An advantage of a diagram is that it is easy to discuss with users and other stakeholders. By generating code from a model at the level of business requirements, you make your code more flexible when the requirements change.

You can also design your own type of diagram as a domain-specific language (DSL). Code can be generated from both UML and DSLs. For more information, see [Analyzing and Modeling Architecture](../modeling/analyze-and-model-your-architecture.md).

## Related content

- [Design-Time Code Generation by using T4 Text Templates](../modeling/design-time-code-generation-by-using-t4-text-templates.md)
- [Run-Time Text Generation with T4 Text Templates](../modeling/run-time-text-generation-with-t4-text-templates.md)
