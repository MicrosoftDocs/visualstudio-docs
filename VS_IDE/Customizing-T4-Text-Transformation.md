---
title: "Customizing T4 Text Transformation"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 62cd9a3c-a6e1-4b29-93f5-f2a0cf47dc92
caps.latest.revision: 28
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
# Customizing T4 Text Transformation
Text templates are a feature of Visual Studio that allow you to generate program code or other text files through a transformation process. Using Visual Studio SDK, you can extend the default template transformation process by customizing the text template directive processor or the text template host.  
  
## In This Section  
 [The Text Template Transformation Process](../VS_IDE/The-Text-Template-Transformation-Process.md)  
 Describes how text transformation works, and explains the role of the template host and the directive processors.  
  
 [Creating Custom T4 Text Template Directive Processors](../VS_IDE/Creating-Custom-T4-Text-Template-Directive-Processors.md)  
 The directive processor deals with directives in your template, such as `<#@template#>.` It runs during the compilation of the template, and can load assemblies and other resources. It can also insert code that will load resources at runtime. By defining your own directive processor, you can reduce the complexity of your templates.  
  
 [Invoking Text Transformation in a VS Extension](../VS_IDE/Invoking-Text-Transformation-in-a-VS-Extension.md)  
 If you are writing a Visual Studio Extension such as a menu command or event handler, your extension can use the Text Templating Service to transform any text template. You can pass parameter data into the template by using the Session object, and get the values from within the template by using the `<#@parameter#>` directive.  
  
 [Processing Text Templates by using a Custom Host](../VS_IDE/Processing-Text-Templates-by-using-a-Custom-Host.md)  
 When the code of the text template executes, the host provides access to external files and the state of the application. For example, the host that runs text transformations in Visual Studio can provide access to solution explorer. It also displays errors in the error message window. If you want to run text transformations in a different context, you can define your own host that provides access to the services available in that context.  
  
 If you are writing a Visual Studio Extension, consider using the existing text transformation service instead of writing your own host. For more information, see [Invoking Text Transformation in a VS Extension](../VS_IDE/Invoking-Text-Transformation-in-a-VS-Extension.md).  
  
## Reference  
 [Writing a T4 Text Template](../VS_IDE/Writing-a-T4-Text-Template.md)  
  
 Provides the syntax of text template directives and control blocks.