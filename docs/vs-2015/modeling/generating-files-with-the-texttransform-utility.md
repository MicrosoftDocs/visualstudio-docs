---
title: "Generating Files with the TextTransform Utility | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "text templates, TextTransform utility"
  - "TextTransform.exe"
ms.assetid: 06a48235-fe02-403e-a1cf-2ae70b4db62f
caps.latest.revision: 43
author: jillre
ms.author: jillfra
manager: jillfra
---
# Generating Files with the TextTransform Utility
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

TextTransform.exe is a command-line tool that you can use to transform a text template. When you call TextTransform.exe, you specify the name of a text template file as an argument. TextTransform.exe calls the text transformation engine and processes the text template. TextTransform.exe is usually called from scripts. However, it is not usually required, because you can perform text transformation either in Visual Studio or in the build process.

> [!NOTE]
> If you want to perform text transformation as part of a build process, consider using the MSBuild text transformation task. For more information, see [Code Generation in a Build Process](../modeling/code-generation-in-a-build-process.md). In a machine on which [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] is installed, you can also write an application or [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Extension that can transform text templates. For more information, see [Processing Text Templates by using a Custom Host](../modeling/processing-text-templates-by-using-a-custom-host.md).

 TextTransform.exe is located in the following directory:

 **\Program Files\Common Files\Microsoft Shared\TextTemplating\11.0**

## Syntax

```
TextTransform [<options>] <templateName>
```

#### Parameters

|**Argument**|**Description**|
|------------------|---------------------|
|`templateName`|Identifies the name of the template file that you want to transform.|

|**Option**|**Description**|
|----------------|---------------------|
|**-out** \<filename>|The file to which the output of the transform is written.|
|**-r** \<assembly>|An assembly used for compiling and running the text template.|
|**-u** \<namespace>|A namespace that is used for compiling the template.|
|**-I** \<includedirectory>|A directory that contains the text templates included in the specified text template.|
|**-P** \<referencepath>|A directory to search for assemblies specified within the text template or for using the **-r** option.<br /><br /> For example, to include assemblies used for the Visual Studio API, use<br /><br /> `-P "%VSSHELLFOLDER%\Common7\IDE\PublicAssemblies"`|
|**-dp** \<processorName>!\<className>!\<assemblyName&#124;codeBase>|The name, full type name, and assembly of a directive processor that can be used to process custom directives within the text template.|
|**-a** [processorName]![directiveName]!\<parameterName>!\<parameterValue>|Specify a parameter value for a directive processor. If you specify just the parameter name and value, the parameter will be available to all directive processors. If you specify a directive processor, the parameter is available only to the specified processor. If you specify a directive name, the parameter is available only when the specified directive is being processed.<br /><br />  In a text template, include `hostspecific` in the template directive and invoke the message on `this.Host`. For example:<br /><br /> `<#@template language="c#" hostspecific="true"#> [<#= this.Host.ResolveParameterValue("", "", "parameterName") #>]`.<br /><br /> Always type the '!' marks, even if you omit the optional processor and directive names. For example:<br /><br /> `-a !!param!value`|
|**-h**|Provides help.|

## Related topics

|Task|Topic|
|----------|-----------|
|Generate files in a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] solution.|[Design-Time Code Generation by using T4 Text Templates](../modeling/design-time-code-generation-by-using-t4-text-templates.md)|
|Write directive processors to transform your own data sources.|[Customizing T4 Text Transformation](../modeling/customizing-t4-text-transformation.md)|
|Write a text templating host that allows you to invoke text templates from your own application.|[Processing Text Templates by using a Custom Host](../modeling/processing-text-templates-by-using-a-custom-host.md)|
