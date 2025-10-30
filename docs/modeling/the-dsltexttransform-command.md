---
title: The DslTextTransform Command
description: Learn that DslTextTransform.cmd is a script that calls TextTransform.exe and runs it with common options.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- Domain-Specific Language, commands
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# The DslTextTransform Command

DslTextTransform.cmd is a script that calls TextTransform.exe and runs it with common options. You can use DslTextTransformation.cmd to automate a nightly build of your Domain-Specific Language Tools projects. For more information, see [Generating Files with the TextTransform Utility](../modeling/generating-files-with-the-texttransform-utility.md).

 DslTextTransform.cmd is located in the following directory:

 **\<Visual Studio SDK Installation Path>\VisualStudioIntegration\Tools\Bin**

 You can specify the following arguments as input to DslTextTransform.cmd:

- The output directory of the domain model project.

- The output directory of the designer definition project.

- The location of the text template file.

  DslTextTransform.cmd processes the specified text template file using the default directive processors and assemblies. If you create custom directive processors, you can create your own batch file that calls TextTransform.exe. In this batch file, you can specify your assemblies and the associated custom directive processors.
