---
title: The DslTextTransform Command
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "Domain-Specific Language, commands"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# The DslTextTransform Command
DslTextTransform.cmd is a script that calls TextTransform.exe and runs it with common options. You can use DslTextTransformation.cmd to automate a nightly build of your [!INCLUDE[dsl](../modeling/includes/dsl_md.md)] projects. For more information, see [Generating Files with the TextTransform Utility](../modeling/generating-files-with-the-texttransform-utility.md).

 DslTextTransform.cmd is located in the following directory:

 **\<Visual Studio SDK Installation Path>\VisualStudioIntegration\Tools\Bin**

 You can specify the following arguments as input to DslTextTransform.cmd:

- The output directory of the domain model project.

- The output directory of the designer definition project.

- The location of the text template file.

  DslTextTransform.cmd processes the specified text template file using the default directive processors and assemblies. If you create custom directive processors, you can create your own batch file that calls TextTransform.exe. In this batch file, you can specify your assemblies and the associated custom directive processors.