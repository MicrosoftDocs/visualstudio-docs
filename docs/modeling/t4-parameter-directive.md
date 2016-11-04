---
title: "T4 Parameter Directive | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 1d590387-1d9d-40a5-a72c-65fae7a8bdf3
caps.latest.revision: 3
author: "alancameronwills"
ms.author: "awills"
manager: "douge"
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
# T4 Parameter Directive
In a [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] text template, the `parameter` directive declares properties in your template code that are initialized from values passed in from the external context. You can set these values if you write code that invokes text transformation.  
  
## Using the Parameter Directive  
  
```  
<#@ parameter type="Full.TypeName" name="ParameterName" #>  
```  
  
 The `parameter` directive declares properties in your template code that are initialized from values passed in from the external context. You can set these values if you write code that invokes text transformation. The values can be passed either in the `Session` dictionary, or in <xref:System.Runtime.Remoting.Messaging.CallContext>.  
  
 You can declare parameters of any remotable type. That is, the type must be declared with <xref:System.SerializableAttribute>, or it must derive from <xref:System.MarshalByRefObject>. This allows parameter values to be passed into the AppDomain in which the template is processed.  
  
 For example, you could write a text template with the following content:  
  
```  
<#@ template language="C#" #>  
  
<#@ parameter type="System.Int32" name="TimesToRepeat" #>  
  
<# for (int i = 0; i < TimesToRepeat; i++) { #>  
Line <#= i #>  
<# } #>  
  
```  
  
## Passing parameter values to a template  
 If you are writing a [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Extension such as a menu command or an event handler, you can process a template by using the text templating service:  
  
```c#  
// Get a service provider – how you do this depends on the context:  
IServiceProvider serviceProvider = dte; // or dslDiagram.Store, for example   
// Get the text template service:  
ITextTemplating t4 = serviceProvider.GetService(typeof(STextTemplating)) as ITextTemplating;  
ITextTemplatingSessionHost host = t4 as ITextTemplatingSessionHost;  
// Create a Session in which to pass parameters:  
host.Session = host.CreateSession();  
// Add parameter values to the Session:  
session["TimesToRepeat"] = 5;  
// Process a text template:  
string result = t4.ProcessTemplate("MyTemplateFile.t4",  
  System.IO.File.ReadAllText("MyTemplateFile.t4"));  
  
```  
  
## Passing values in the Call Context  
 You can alternatively pass values as logical data in <xref:System.Runtime.Remoting.Messaging.CallContext>.  
  
 The following example passes values by using both methods:  
  
```c#  
ITextTemplating t4 = this.Store.GetService(typeof(STextTemplating)) as ITextTemplating;  
ITextTemplatingSessionHost host = t4 as ITextTemplatingSessionHost;  
host.Session = host.CreateSession();  
// Pass a value in Session:  
host.Session["p1"] = 32;  
// Pass another value in CallContext:  
System.Runtime.Remoting.Messaging.CallContext.LogicalSetData("p2", "test");  
  
// Process a small template inline:  
string result = t4.ProcessTemplate("",   
   "<#@parameter type=\"System.Int32\" name=\"p1\"#>"  
 + "<#@parameter type=\"System.String\" name=\"p2\"#>"  
 + "Test <#=p1#> <#=p2#>");  
  
// Result value is:  
//     Test 32 test  
  
```  
  
## Passing values to a Run-Time (Preprocessed) Text Template  
 It is not usually necessary to use the `<#@parameter#>` directive with run-time (preprocessed) text templates. Instead, you can define an additional constructor or a settable property for the generated code, through which you pass parameter values. For more information, see [Run-Time Text Generation with T4 Text Templates](../modeling/run-time-text-generation-with-t4-text-templates.md).  
  
 However, if you want to use `<#@parameter>` in a run-time template, you can pass values to it by using the Session dictionary. As an example, suppose you have created the file as a preprocessed template called `PreTextTemplate1`. You can invoke the template in your program by using the following code.  
  
```c#  
PreTextTemplate1 t = new PreTextTemplate1();  
t.Session = new Microsoft.VisualStudio.TextTemplating.TextTemplatingSession();  
t.Session["TimesToRepeat"] = 5;  
// Add other parameter values to t.Session here.  
t.Initialize(); // Must call this to transfer values.  
string resultText = t.TransformText();  
  
```  
  
## Obtaining arguments from TextTemplate.exe  
  
> [!IMPORTANT]
>  The `parameter` directive does not retrieve values set in the `–a` parameter of the `TextTransform.exe` utility. To get those values, set `hostSpecific="true"` in the `template` directive, and use `this.Host.ResolveParameterValue("","","argName")`.