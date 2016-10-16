---
title: "Accessing Visual Studio or other Hosts from a Text Template"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a68886da-7416-4785-8145-3796bb382cba
caps.latest.revision: 5
ms.author: "awills"
manager: "kamrani"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Accessing Visual Studio or other Hosts from a Text Template
In a text template, you can use methods and properties exposed by the host that executes the template, such as [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)].  
  
 This applies to regular text templates, not preprocessed text templates.  
  
## Obtaining access to the host  
 Set `hostspecific="true"` in the `template` directive. This lets you use  `this.Host`, which has type \<xref:Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost>. This type has members that you can use, for example, to resolve file names and to log errors.  
  
### Resolving File Names  
 To find the full path of a file relative to the text template, use this.Host.ResolvePath().  
  
```c#  
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
 This example logs messages when you transform the template. If the host is [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)], they are added to the error window.  
  
```c#  
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
 If you are executing a text template in [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)], you can use `this.Host` to access services provided by [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] and any packages or extensions that are loaded.  
  
 Set hostspecific="true" and cast `this.Host` to \<xref:System.IServiceProvider>.  
  
 This example gets the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] API, \<xref:EnvDTE.DTE>, as a service:  
  
```c#  
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