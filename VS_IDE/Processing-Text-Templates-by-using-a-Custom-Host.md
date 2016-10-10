---
title: "Processing Text Templates by using a Custom Host"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: affa3296-854d-47d6-9685-285f6d9ba5dc
caps.latest.revision: 33
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
# Processing Text Templates by using a Custom Host
The *text template transformation* process takes a *text template* file as the input and produces a text file as the output. You can call the text transformation engine from a Visual Studio extension, or from a standalone application running on a machine on which Visual Studio is installed. However, you must provide a *text templating host*. This class connects the template to the environment, finding resources such as assemblies and include files, and dealing with the output and error messages.  
  
> [!TIP]
>  If you are writing a package or extension that will run within Visual Studio, consider using the text templating service, instead of writing your own host. For more information, see [Invoking Text Transformation in a VS Extension](../VS_IDE/Invoking-Text-Transformation-in-a-VS-Extension.md).  
  
> [!NOTE]
>  We do not recommend using text template transformations in server applications. We do not recommend using text template transformations except in a single thread. This is because the text templating Engine re-uses a single AppDomain to translate, compile, and execute templates. The translated code is not designed to be thread-safe. The Engine is designed to process files serially, as they are in a Visual Studio project at design time.  
>   
>  For run-time applications, consider using preprocessed text templates: see [Run-Time Text Generation with T4 Text Templates](../VS_IDE/Run-Time-Text-Generation-with-T4-Text-Templates.md).  
  
 If your application uses a set of templates that are fixed at compile time, it is easier to use Preprocessed Text Templates. You can also use that approach if your application will run on a machine on which Visual Studio is not installed. For more information, see [Run-Time Text Generation with T4 Text Templates](../VS_IDE/Run-Time-Text-Generation-with-T4-Text-Templates.md).  
  
## Executing a Text Template in Your Application  
 To execute a text template, you call the ProcessTemplate method of <xref:Microsoft.VisualStudio.TextTemplating.Engine?qualifyHint=True>:  
  
```  
using Microsoft.VisualStudio.TextTemplating;  
...  
Engine engine = new Engine();  
string output = engine.ProcessTemplate(templateString, host);  
```  
  
 Your application must find and provide the template, and must deal with the output.  
  
 In the `host` parameter, you must provide a class that implements <xref:Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost?qualifyHint=False>. This is called back by the Engine.  
  
 The host must be able to log errors, resolve references to assembly and include files, provide an Application Domain in which the template can execute, and call the appropriate processor for each directive.  
  
 <xref:Microsoft.VisualStudio.TextTemplating.Engine?qualifyHint=True> is defined in **Microsoft.VisualStudio.TextTemplating.\*.0.dll**, and <xref:Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost?qualifyHint=False> is defined in **Microsoft.VisualStudio.TextTemplating.Interfaces.\*.0.dll**.  
  
## In This Section  
 [Walkthrough: Creating a Custom Text Template Host](../VS_IDE/Walkthrough--Creating-a-Custom-Text-Template-Host.md)  
 Shows you how to create a custom text template host that makes the text template functionality available outside Visual Studio.  
  
## Reference  
 <xref:Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost?qualifyHint=False>  
  
## Related Sections  
 [The Text Template Transformation Process](../VS_IDE/The-Text-Template-Transformation-Process.md)  
 Describes how text transformation works, and which parts you can customize.  
  
 [Creating Custom T4 Text Template Directive Processors](../VS_IDE/Creating-Custom-T4-Text-Template-Directive-Processors.md)  
 Provides an overview of text template directive processors.