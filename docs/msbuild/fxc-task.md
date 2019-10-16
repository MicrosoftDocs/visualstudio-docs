---
title: "FXC Task | Microsoft Docs"
ms.date: "03/10/2019"
ms.topic: "reference"
f1_keywords:
  - "vc.task.fxc"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "C++"
helpviewer_keywords:
  - "MSBuild (C++), FXC task"
  - "FXC task (MSBuild (C++))"
author: mikeblome
ms.author: mblome
ms.workload:
  - "multiple"
---
# FXC task

Use HLSL shader compilers in the build process.

## Parameters

The following table describes the parameters of the **FXC** task.

|Parameter|Description|
|---------------|-----------------|
|**AdditionalIncludeDirectories**|Optional **string[]** parameter.<br/><br/>Specifies one or more directories to add to the include path; separate with semi-colons if more than one.<br/><br/>Use `/I[path]`.|
|**AdditionalOptions**|Optional **string** parameter.|
|**AllResourcesBound**|Optional **bool** parameter.<br/><br/>Compiler will assume that all resources that a shader may reference are bound and are in good state for the duration of shader execution. Available for Shader Model 5.1 and above.<br/><br/>Use `/all_resources_bound`.|
|**AssemblerOutput**|Optional **string** parameter.<br/><br/>Specifies the contents of assembly language output file.<br/><br/>Use `/Fc, /Fx`.<br/><br/>**NoListing**<br/>**AssemblyCode**, use `Fc`.<br/>**AssemblyCodeAndHex**, use `Fx`.|
|**AssemblerOutputFile**|Optional **string** parameter.<br/><br/>Specifies file name for assembly code listing file.|
|**CompileD2DCustomEffect**|Optional **bool** parameter.<br/><br/>Compile a Direct2D custom effect that contains pixel shaders. Do not use for a vertex or compute custom effect.|
|**ConsumeExportFile**|Optional **string** parameter.|
|**DisableOptimizations**|Optional **bool** parameter.<br/><br/>Disable optimizations.<br/><br/>`/Od` implies `/Gfp` though output may not be identical to `/Od /Gfp`.|
|**EnableDebuggingInformation**|Optional **bool** parameter.<br/><br/>Enable debugging information.|
|**EnableUnboundedDescriptorTables**|Optional **bool** parameter.<br/><br/>Inform the compiler that a shader may contain a declaration of a resource array with unbounded range. Available for Shader Model 5.1 and above.<br/><br/>Use `/enable_unbounded_descriptor_tables`.|
|**EntryPointName**|Optional **string** parameter.<br/><br/>Specifies the name of the entry point for the shader.<br/><br/>Use `/E[name]`.|
|**GenerateExportFile**|Optional **string** parameter.|
|**GenerateExportShaderProfile**|Optional **string** parameter.|
|**HeaderFileOutput**|Optional **string** parameter.<br/><br/>Specifies a name for header file containing object code.<br/><br/>Use `/Fh [name]`.|
|**ObjectFileOutput**|Optional **string** parameter.<br/><br/>Specifies a name for object file.<br/><br/>Use `/Fo [name]`.|
|**PreprocessorDefinitions**|Optional **string[]** parameter.<br/><br/>Defines preprocessing symbols for your source file.|
|**SetRootSignature**|Optional **string** parameter.<br/><br/>Attach root signature to shader bytecode. Available for Shader Model 5.0 and above.<br/><br/>Use `/setrootsignature`.|
|**ShaderModel**|Optional **string** parameter.<br/><br/>Specifies the shader model. Some shader types can only be used with recent shader models.<br/><br/>Use `/T [type]_[model]`.|
|**ShaderType**|Optional **string** parameter.<br/><br/>Specifies the type of shader.<br/><br/>Use `/T [type]_[model]`.<br/><br/>**Effect**, use `fx`.<br/>**Vertex**, use `vs`.<br/>**Pixel**, use `ps`.<br/>**Geometry**, use `gs`.<br/>**Hull**, use `hs`.<br/>**Domain**, use `ds`.<br/>**Compute**, use `cs`.<br/>**Library**, use `lib`.<br/>**RootSignature**, generate Root Signature Object.|
|**Source**|Required **ITaskItem** parameter.|
|**SuppressStartupBanner**|Optional **bool** parameter.<br/><br/>Suppresses the display of the startup banner and information message.<br/><br/>Use `/nologo`.|
|**TrackerLogDirectory**|Optional **string** parameter.|
|**TreatWarningAsError**|Optional **bool** parameter.<br/><br/>Treats all compiler warnings as errors.<br/><br/>For a new project, it may be best to use `/WX` in all compilations; resolving all warnings will ensure the fewest possible hard-to-find code defects.|
|**VariableName**|Optional **string** parameter.<br/><br/>Specifies a name for the variable name in the header file.<br/><br/>Use `/Vn [name]`.|

## See also

[Task reference](../msbuild/msbuild-task-reference.md)