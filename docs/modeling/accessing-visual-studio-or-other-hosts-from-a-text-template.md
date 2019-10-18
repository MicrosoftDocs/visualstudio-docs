---
title: Accessing Visual Studio or other Hosts from a Text Template
titleSuffix: ""
ms.date: 11/04/2016
ms.topic: conceptual
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Access Visual Studio or other hosts from a text template

In a text template, you can use methods and properties that are exposed by the host that executes the template. Visual Studio is an example of a host.

> [!NOTE]
> You can use host methods and properties in regular text templates, but not in *preprocessed* text templates.

## Obtain access to the host

To access the host, set `hostspecific="true"` in the `template` directive. Now you can use `this.Host`, which has type [ITextTemplatingEngineHost](/previous-versions/visualstudio/visual-studio-2012/bb126505(v=vs.110)). The [ITextTemplatingEngineHost](/previous-versions/visualstudio/visual-studio-2012/bb126505(v=vs.110)) type has members that you can use to resolve file names and log errors, for example.

### Resolve File Names

To find the full path of a file relative to the text template, use `this.Host.ResolvePath()`.

```csharp
<#@ template hostspecific="true" language="C#" #>
<#@ output extension=".txt" #>
<#@ import namespace="System.IO" #>
<#
 // Find a path within the same project as the text template:
 string myFile = File.ReadAllText(this.Host.ResolvePath("MyFile.txt"));
#>
Content of myFile is:
<#= myFile #>
```

### Display Error Messages

This example logs messages when you transform the template. If the host is Visual Studio, the errors are added to the **Error List**.

```csharp
<#@ template hostspecific="true" language="C#" #>
<#@ output extension=".txt" #>
<#@ import namespace="System.CodeDom.Compiler" #>
<#
  string message = "test message";
  this.Host.LogErrors(new CompilerErrorCollection()
    { new CompilerError(
       this.Host.TemplateFile, // Identify the source of the error.
       0, 0, "0",   // Line, column, error ID.
       message) }); // Message displayed in error window.
#>
```

## Use the Visual Studio API

If you're executing a text template in Visual Studio, you can use `this.Host` to access services provided by Visual Studio and any packages or extensions that are loaded.

Set hostspecific="true" and cast `this.Host` to <xref:System.IServiceProvider>.

This example gets the Visual Studio API, <xref:EnvDTE.DTE>, as a service:

```csharp
<#@ template hostspecific="true" language="C#" #>
<#@ output extension=".txt" #>
<#@ assembly name="EnvDTE" #>
<#@ import namespace="EnvDTE" #>
<#
 IServiceProvider serviceProvider = (IServiceProvider)this.Host;
 DTE dte = serviceProvider.GetService(typeof(DTE)) as DTE;
#>
Number of projects in this solution: <#=  dte.Solution.Projects.Count #>
```

## Use hostSpecific with template inheritance

Specify `hostspecific="trueFromBase"` if you also use the `inherits` attribute, and if you inherit from a template that specifies `hostspecific="true"`. If you don't, you might get a compiler warning that the property `Host` has been declared twice.