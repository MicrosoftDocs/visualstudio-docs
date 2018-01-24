---
title: "Accessing Visual Studio or other Hosts from a Text Template | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: 
  - "multiple"
---
# Accessing Visual Studio or other Hosts from a Text Template
In a text template, you can use methods and properties exposed by the host that executes the template, such as [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
 This applies to regular text templates, not preprocessed text templates.  
  
## Obtaining access to the host  
 Set `hostspecific="true"` in the `template` directive. This lets you use  `this.Host`, which has type <xref:Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost>. This type has members that you can use, for example, to resolve file names and to log errors.  
  
### Resolving File Names  
 To find the full path of a file relative to the text template, use this.Host.ResolvePath().  
  
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
  
### Displaying Error Messages  
 This example logs messages when you transform the template. If the host is [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], they are added to the error window.  
  
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
  
## Using the Visual Studio API  
 If you are executing a text template in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], you can use `this.Host` to access services provided by [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] and any packages or extensions that are loaded.  
  
 Set hostspecific="true" and cast `this.Host` to <xref:System.IServiceProvider>.  
  
 This example gets the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] API, <xref:EnvDTE.DTE>, as a service:  
  
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
  
## Using hostSpecific with template inheritance  
 Specify `hostspecific="trueFromBase"` if you also use the `inherits` attribute, and if you inherit from a template that specifies `hostspecific="true"`. This avoids a compiler warning to the effect that the property `Host` has been declared twice.