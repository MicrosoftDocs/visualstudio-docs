---
title: SGen Task | Microsoft Docs
description: Learn how MSBuild uses the SGen task to create an XML serialization assembly for types, by wrapping the XML Serializer Generator tool Sgen.exe. 
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#SGen
dev_langs:
- VB
- CSharp
- C++
- jsharp
helpviewer_keywords:
- SGen task [MSBuild]
- MSBuild, SGen task
ms.assetid: 22c5ade4-4159-4667-b891-0c1aa06f4df5
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# SGen task

Creates an XML serialization assembly for types in the specified assembly. This task wraps the XML Serializer Generator tool (*Sgen.exe*). For more information, see [XML Serializer Generator tool (Sgen.exe)](/dotnet/framework/serialization/xml-serializer-generator-tool-sgen-exe).

## Parameters

 The following table describes the parameters of the `SGen` task.

| Parameter | Description |
|-----------------------------| - |
| `BuildAssemblyName` | Required `String` parameter.<br /><br /> The assembly to generate serialization code for. |
| `BuildAssemblyPath` | Required `String` parameter.<br /><br /> The path to the assembly to generate serialization code for. |
| `DelaySign` | Optional `Boolean` parameter.<br /><br /> If `true`, specifies that you only want to place the public key in the assembly. If `false`, specifies that you want a fully signed assembly.<br /><br /> This parameter has no effect unless used with either the `KeyFile` or `KeyContainer` parameter. |
| `KeyContainer` | Optional `String` parameter.<br /><br /> Specifies a container that holds a key pair. This will sign the assembly by inserting a public key into the assembly manifest. The task will then sign the final assembly with the private key. |
| `KeyFile` | Optional `String` parameter.<br /><br /> Specifies a key pair or a public key to use to sign an assembly. The compiler inserts the public key in the assembly manifest and then signs the final assembly with the private key. |
| `Platform` | Optional `String` parameter.<br /><br /> Gets or Sets the Compiler Platform used to generate the output assembly. This parameter can have a value of `x86`, `x64`, or `anycpu`. Default is `anycpu`. |
| `References` | Optional `String[]` parameter.<br /><br /> Specifies the assemblies that are referenced by the types requiring XML serialization. |
| `SdkToolsPath` | Optional `String` parameter.<br /><br /> Specifies the path to the SDK tools, such as *resgen.exe*. |
| `SerializationAssembly` | Optional <xref:Microsoft.Build.Framework.ITaskItem>`[]` output parameter.<br /><br /> Contains the generated serialization assembly. |
| `SerializationAssemblyName` | Optional `String` parameter.<br /><br /> Specifies the name of the generated serialization assembly. |
| `ShouldGenerateSerializer` | Required `Boolean` parameter.<br /><br /> If `true`, the SGen task should generate a serialization assembly. |
| `Timeout` | Optional `Int32` parameter.<br /><br /> Specifies the amount of time, in milliseconds, after which the task executable is terminated. The default value is `Int.MaxValue`, indicating that there is no time out period. |
| `ToolPath` | Optional `String` parameter.<br /><br /> Specifies the location from where the task will load the underlying executable file (*sgen.exe*). If this parameter is not specified, the task uses the SDK installation path corresponding to the version of the framework that is running MSBuild. |
| `Types` | Optional `String[]` parameter.<br /><br /> Gets or sets a list of specific Types to generate serialization code for. SGen will generate serialization code only for those types. |
| `UseProxyTypes` | Required `Boolean` parameter.<br /><br /> If `true`, the SGen task generates serialization code only for the XML Web service proxy types. |

[!INCLUDE [ToolTaskExtension arguments](includes/tooltaskextension-base-params.md)]

## See also

- [Task reference](../msbuild/msbuild-task-reference.md)
- [Tasks](../msbuild/msbuild-tasks.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
