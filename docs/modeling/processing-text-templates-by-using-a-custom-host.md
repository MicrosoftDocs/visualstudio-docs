---
title: "Processing Text Templates by using a Custom Host | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "text templates, in application or VS extension"
  - "text templates, custom directive hosts"
ms.assetid: affa3296-854d-47d6-9685-285f6d9ba5dc
caps.latest.revision: 33
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
# Processing Text Templates by using a Custom Host
The *text template transformation* process takes a *text template* file as the input and produces a text file as the output. You can call the text transformation engine from a [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] extension, or from a standalone application running on a machine on which [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] is installed. However, you must provide a *text templating host*. This class connects the template to the environment, finding resources such as assemblies and include files, and dealing with the output and error messages.  
  
> [!TIP]
>  If you are writing a package or extension that will run within [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], consider using the text templating service, instead of writing your own host. For more information, see [Invoking Text Transformation in a VS Extension](../modeling/invoking-text-transformation-in-a-vs-extension.md).  
  
> [!NOTE]
>  We do not recommend using text template transformations in server applications. We do not recommend using text template transformations except in a single thread. This is because the text templating Engine re-uses a single AppDomain to translate, compile, and execute templates. The translated code is not designed to be thread-safe. The Engine is designed to process files serially, as they are in a [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] project at design time.  
>   
>  For run-time applications, consider using preprocessed text templates: see [Run-Time Text Generation with T4 Text Templates](../modeling/run-time-text-generation-with-t4-text-templates.md).  
  
 If your application uses a set of templates that are fixed at compile time, it is easier to use Preprocessed Text Templates. You can also use that approach if your application will run on a machine on which [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] is not installed. For more information, see [Run-Time Text Generation with T4 Text Templates](../modeling/run-time-text-generation-with-t4-text-templates.md).  
  
## Executing a Text Template in Your Application  
 To execute a text template, you call the ProcessTemplate method of <xref:Microsoft.VisualStudio.TextTemplating.Engine?displayProperty=fullName>:  
  
```  
using Microsoft.VisualStudio.TextTemplating;  
...  
Engine engine = new Engine();  
string output = engine.ProcessTemplate(templateString, host);  
```  
  
 Your application must find and provide the template, and must deal with the output.  
  
 In the `host` parameter, you must provide a class that implements <xref:Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost>. This is called back by the Engine.  
  
 The host must be able to log errors, resolve references to assembly and include files, provide an Application Domain in which the template can execute, and call the appropriate processor for each directive.  
  
 <xref:Microsoft.VisualStudio.TextTemplating.Engine?displayProperty=fullName> is defined in **Microsoft.VisualStudio.TextTemplating.\*.0.dll**, and <xref:Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost> is defined in **Microsoft.VisualStudio.TextTemplating.Interfaces.\*.0.dll**.  
  
## In This Section  
 [Walkthrough: Creating a Custom Text Template Host](../modeling/walkthrough-creating-a-custom-text-template-host.md)  
 Shows you how to create a custom text template host that makes the text template functionality available outside [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)].  
  
## Reference  
 <xref:Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost>  
  
## Related Sections  
 [The Text Template Transformation Process](../modeling/the-text-template-transformation-process.md)  
 Describes how text transformation works, and which parts you can customize.  
  
 [Creating Custom T4 Text Template Directive Processors](../modeling/creating-custom-t4-text-template-directive-processors.md)  
 Provides an overview of text template directive processors.