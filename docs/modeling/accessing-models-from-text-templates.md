---
title: Accessing Models from Text Templates
description: Learn how you can use text templates to create report files, source code files, and other text files that are based on domain-specific language models.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- text templates, accessing models
author: mgoertz-msft
ms.author: mgoertz
manager: jmartens
ms.technology: vs-ide-modeling
ms.workload:
- multiple
---
# Access models from text templates

By using text templates, you can create report files, source code files, and other text files that are based on domain-specific language models. For basic information about text templates, see [Code Generation and T4 Text Templates](../modeling/code-generation-and-t4-text-templates.md). The text templates will work in the experimental mode when you are debugging your DSL, and will also work on a computer on which you have deployed the DSL.

> [!NOTE]
> When you create a DSL solution, sample text template **\*.tt** files are generated in the debugging project. When you change the names of the domain classes, these templates will no longer work. Nevertheless, they include the basic directives that you need, and provide examples that you can update to match your DSL.

 To access a model from a text template:

- Set the inherit property of the template directive to [Microsoft.VisualStudio.TextTemplating.VSHost.ModelingTextTransformation](/previous-versions/bb893209(v=vs.140)). This provides access to the Store.

- Specify directive processors for the DSL that you want to access. This loads the assemblies for your DSL so that you can use its domain classes, properties, and relationships in the code of your text template. It also loads the model file that you specify.

  A `.tt` file similar to the following example is created in the Debugging project when you create a new Visual Studio solution from the DSL Minimal Language template.

```
<#@ template inherits="Microsoft.VisualStudio.TextTemplating.VSHost.ModelingTextTransformation" #>
<#@ output extension=".txt" #>
<#@ MyLanguage processor="MyLanguageDirectiveProcessor" requires="fileName='Sample.myDsl1'" #>

This text will be output directly.

This is the name of the model: <#= this.ModelRoot.Name #>

Here is a list of elements in the model:
<#
  // When you change the DSL Definition, some of the code below may not work.
  foreach (ExampleElement element in this.ExampleModel.Elements)
  {#>
<#= element.Name #>
<#
  }
#>
```

 Notice the following points about this template:

- The template can use the domain classes, properties, and relationships that you defined in the DSL Definition.

- The template loads the model file that you specify in the `requires` property.

- A property in `this` contains the root element. From there, your code can navigate to other elements of the model. The name of the property is usually the same as the root domain class of your DSL. In this example, it is `this.ExampleModel`.

- Although the language in which the code fragments are written is C#, you can generate text of any kind. You can alternatively write the code in [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] by adding the property `language="VB"` to the `template` directive.

- To debug the template, add `debug="true"` to the `template` directive. The template will open in another instance of Visual Studio if an exception occurs. If you want to break into the debugger at a specific point in the code, insert the statement `System.Diagnostics.Debugger.Break();`

   For more information, see [Debugging a T4 Text Template](../modeling/debugging-a-t4-text-template.md).

## About the DSL directive processor
 The template can use the domain classes that you defined in your DSL Definition. This is brought about by a directive that usually appears near the start of the template. In the previous example, it is the following.

```
<#@ MyLanguage processor="MyLanguageDirectiveProcessor" requires="fileName='Sample.myDsl1'" #>
```

 The name of the directive ( `MyLanguage`, in this example) is derived from the name of your DSL. It invokes a *directive processor* that is generated as part of your DSL. You can find its source code in **Dsl\GeneratedCode\DirectiveProcessor.cs**.

 The DSL directive processor performs two principal tasks:

- It effectively inserts assembly and import directives into the template that references your DSL. This lets you use your domain classes in the template code.

- It loads the file that you specify in the `requires` parameter, and sets a property in `this` that refers to the root element of the loaded model.

## Validating the model before running the template
 You can cause the model to be validated before the template is executed.

```
<#@ MyLanguage processor="MyLanguageDirectiveProcessor" requires="fileName='Sample.myDsl1';validation='open|load|save|menu'" #>
```

 Notice that:

1. The `filename` and `validation` parameters are separated with ";" and there must be no other separators or spaces.

2. The list of validation categories determines which validation methods will be executed. Multiple categories should be separated with "&#124;" and there must be no other separators or spaces.

   If an error is found, it will be reported in the errors window, and the result file will contain an error message.

## <a name="Multiple"></a> Accessing multiple models from a text template

> [!NOTE]
> This method lets you read multiple models in the same template but does not support ModelBus references. To read models that are interlinked by ModelBus References, see [Using Visual Studio ModelBus in a Text Template](../modeling/using-visual-studio-modelbus-in-a-text-template.md).

 If you want to access more than one model from the same text template, you must call the generated directive processor one time for each model. You must specify the file name of each model in the `requires` parameter. You must specify the names that you want to use for the root domain class in the `provides` parameter. You must specify different values for the `provides` parameters in each of the directive calls. For example, assume that you have three model files called Library.xyz, School.xyz, and Work.xyz. To access them from the same text template, you must write three directive calls that resemble the following ones.

```
<#@ ExampleModel processor="<YourLanguageName>DirectiveProcessor" requires="fileName='Library.xyz'" provides="ExampleModel=LibraryModel" #>
<#@ ExampleModel processor="<YourLanguageName>DirectiveProcessor" requires="fileName='School.xyz'" provides="ExampleModel=SchoolModel" #>
<#@ ExampleModel processor="<YourLanguageName>DirectiveProcessor" requires="fileName='Work.xyz'" provides="ExampleModel=WorkModel" #>
```

> [!NOTE]
> This example code is for a language that is based on the Minimal Language solution template.

 To access the models in your text template, you can now write code similar to the code in the following example.

```csharp
<#
foreach (ExampleElement element in this.LibraryModel.Elements)
...
foreach (ExampleElement element in this.SchoolModel.Elements)
...
foreach (ExampleElement element in this.WorkModel.Elements)
...
#>
```

```vb
<#
For Each element As ExampleElement In Me.LibraryModel.Elements
...
For Each element As ExampleElement In Me.SchoolModel.Elements
...
For Each element As ExampleElement In Me.WorkModel.Elements
...
#>
```

## Loading models dynamically
 If you want to determine at run time which models to load, you can load a model file dynamically in your program code, instead of using the DSL-specific directive.

 However, one of the functions of the DSL-specific directive is to import the DSL namespace, so that the template code can use the domain classes defined in that DSL. Because you are not using the directive, you must add **\<assembly>** and **\<import>** directives for all the models that you might load. This is easy if the different models that you might load are all instances of the same DSL.

 To load the file, the most effective method is by using Visual Studio ModelBus. In a typical scenario, your text template will use a DSL-specific directive to load the first model in the usual way. That model would contain ModelBus References to another model. You can use ModelBus to open the referenced model and access a particular element. For more information, see [Using Visual Studio ModelBus in a Text Template](../modeling/using-visual-studio-modelbus-in-a-text-template.md).

 In a less usual scenario, you might want to open a model file for which you have only a filename, and which might not be in the current Visual Studio project. In this case, you can open the file by using the technique described in [How to: Open a Model from File in Program Code](../modeling/how-to-open-a-model-from-file-in-program-code.md).

## Generating multiple files from a template
 If you want to generate a several files - for example, to generate a separate file for each element in a model, there are several possible approaches. By default, only one file is produced from each template file.

### Splitting a long file
 In this method, you use a template to generate a single file, separated by a delimiter. Then you split the file into its parts. There are two templates, one to generate the single file, and the other to split it.

 **LoopTemplate.t4** generates the long single file. Notice that its file extension is ".t4", because it should not be processed directly when you click **Transform All Templates**. This template takes a parameter, which specifies the delimiter string that separates the segments:

```
<#@ template ninherits="Microsoft.VisualStudio.TextTemplating.VSHost.ModelingTextTransformation" #>
<#@ parameter name="delimiter" type="System.String" #>
<#@ output extension=".txt" #>
<#@ MyDSL processor="MyDSLDirectiveProcessor" requires="fileName='SampleModel.mydsl1';validation='open|load|save|menu'" #>
<#
  // Create a file segment for each element:
  foreach (ExampleElement element in this.ExampleModel.Elements)
  {
    // First item is the delimiter:
#>
<#= string.Format(delimiter, element.Id) #>

   Element: <#= element.Name #>
<#
   // Here you generate more content derived from the element.
  }
#>
```

 `LoopSplitter.tt` invokes `LoopTemplate.t4`, and then splits the resulting file into its segments. Notice that this template does not have to be a modeling template, because it does not read the model.

```
<#@ template hostspecific="true" language="C#" #>
<#@ output extension=".txt" #>
<#@ import namespace="Microsoft.VisualStudio.TextTemplating" #>
<#@ import namespace="System.Runtime.Remoting.Messaging" #>
<#@ import namespace="System.IO" #>

<#
  // Get the local path:
  string itemTemplatePath = this.Host.ResolvePath("LoopTemplate.t4");
  string dir = Path.GetDirectoryName(itemTemplatePath);

  // Get the template for generating each file:
  string loopTemplate = File.ReadAllText(itemTemplatePath);

  Engine engine = new Engine();

  // Pass parameter to new template:
  string delimiterGuid = Guid.NewGuid().ToString();
  string delimiter = "::::" + delimiterGuid + ":::";
  CallContext.LogicalSetData("delimiter", delimiter + "{0}:::");
  string joinedFiles = engine.ProcessTemplate(loopTemplate, this.Host);

  string [] separateFiles = joinedFiles.Split(new string [] {delimiter}, StringSplitOptions.None);

  foreach (string nameAndFile in separateFiles)
  {
     if (string.IsNullOrWhiteSpace(nameAndFile)) continue;
     string[] parts = nameAndFile.Split(new string[]{":::"}, 2, StringSplitOptions.None);
     if (parts.Length < 2) continue;
#>
 Generate: [<#= dir #>] [<#= parts[0] #>]
<#
     // Generate a file from this item:
     File.WriteAllText(Path.Combine(dir, parts[0] + ".txt"), parts[1]);
  }
#>
```
