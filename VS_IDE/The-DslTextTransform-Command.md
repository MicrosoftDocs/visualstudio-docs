---
title: "The DslTextTransform Command"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7d025d0b-6543-4a49-9f6b-8b8cfcad77ee
caps.latest.revision: 30
manager: kamrani
---
# The DslTextTransform Command
DslTextTransform.cmd is a script that calls TextTransform.exe and runs it with common options. You can use DslTextTransformation.cmd to automate a nightly build of your Domain-Specific Language Tools projects. For more information, see [Generating Files with the TextTransform Utility](../VS_IDE/Generating-Files-with-the-TextTransform-Utility.md).  
  
 DslTextTransform.cmd is located in the following directory:  
  
 **<Visual Studio SDK Installation Path\>\VisualStudioIntegration\Tools\Bin**  
  
 You can specify the following arguments as input to DslTextTransform.cmd:  
  
-   The output directory of the domain model project.  
  
-   The output directory of the designer definition project.  
  
-   The location of the text template file.  
  
 DslTextTransform.cmd processes the specified text template file using the default directive processors and assemblies. If you create custom directive processors, you can create your own batch file that calls TextTransform.exe. In this batch file, you can specify your assemblies and the associated custom directive processors.