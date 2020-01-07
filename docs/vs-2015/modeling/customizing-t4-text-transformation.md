---
title: "Customizing T4 Text Transformation | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "text templates, API"
  - "text templates, custom hosts"
ms.assetid: 62cd9a3c-a6e1-4b29-93f5-f2a0cf47dc92
caps.latest.revision: 30
author: jillre
ms.author: jillfra
manager: jillfra
---
# Customizing T4 Text Transformation
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Text templates are a feature of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] that allow you to generate program code or other text files through a transformation process. Using [!INCLUDE[vssdk_current_short](../includes/vssdk-current-short-md.md)], you can extend the default template transformation process by customizing the text template directive processor or the text template host.

## In This Section
 [The Text Template Transformation Process](../modeling/the-text-template-transformation-process.md)
 Describes how text transformation works, and explains the role of the template host and the directive processors.

 [Creating Custom T4 Text Template Directive Processors](../modeling/creating-custom-t4-text-template-directive-processors.md)
 The directive processor deals with directives in your template, such as `<#@template#>.` It runs during the compilation of the template, and can load assemblies and other resources. It can also insert code that will load resources at runtime. By defining your own directive processor, you can reduce the complexity of your templates.

 [Invoking Text Transformation in a VS Extension](../modeling/invoking-text-transformation-in-a-vs-extension.md)
 If you are writing a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Extension such as a menu command or event handler, your extension can use the Text Templating Service to transform any text template. You can pass parameter data into the template by using the Session object, and get the values from within the template by using the `<#@parameter#>` directive.

 [Processing Text Templates by using a Custom Host](../modeling/processing-text-templates-by-using-a-custom-host.md)
 When the code of the text template executes, the host provides access to external files and the state of the application. For example, the host that runs text transformations in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] can provide access to solution explorer. It also displays errors in the error message window. If you want to run text transformations in a different context, you can define your own host that provides access to the services available in that context.

 If you are writing a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Extension, consider using the existing text transformation service instead of writing your own host. For more information, see [Invoking Text Transformation in a VS Extension](../modeling/invoking-text-transformation-in-a-vs-extension.md).

## Reference
 [Writing a T4 Text Template](../modeling/writing-a-t4-text-template.md)

 Provides the syntax of text template directives and control blocks.
