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
  - "MSBuild (Visual C++), FXC task"
  - "FXC task (MSBuild (Visual C++))"
ms.assetid: b62a482e-8fb5-4999-b50b-6605a078e291
author: mikeblome
ms.author: Michael.Blome
ms.workload:
  - "multiple"
---
# FXC task

Use HLSL shader compilers in the build process.

## Methods

The following tables describe the methods of the **FXC** task.

### Protected Override

All methods as `protected override`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**GenerateCommandLineCommands**|(**string**)|
|**GenerateResponseFileCommands**|(**string**)|
|**StandardErrorEncoding**|Default is Encoding.UTF8. (**Encoding**)|
|**StandardOutputEncoding**|Default is Encoding.UTF8. (**Encoding**)|
|**SwitchOrderList**|(**ArrayList**)|
|**ToolName**|(**string**)|
|**TrackedInputFiles**|(**ITaskItem[]**)|
|**TrackerIntermediateDirectory**|(**string**)|

### Public Virtual

All methods as `public virtual`:

|Method|Description (Return Value)|
|---------------|-----------------|
|**AdditionalIncludeDirectories**|Specifies one or more directories to add to the include path; separate with semi-colons if more than one. (**string[]**)<br/><br/>Use `/I[path]`.|
|**AdditionalOptions**|Additional Options. (**string**)|
|**AllResourcesBound**|Compiler will assume that all resources that a shader may reference are bound and are in good state for the duration of shader execution. Available for Shader Model 5.1 and above. (**bool**)<br/><br/>Use `/all_resources_bound`.|
|**AssemblerOutput**|Specifies the contents of assembly language output file. (**string**)<br/><br/>Use `/Fc, /Fx`.<br/><br/>**NoListing**<br/>**AssemblyCode**, use `Fc`.<br/>**AssemblyCodeAndHex**, use `Fx`.|
|**AssemblerOutputFile**|Specifies file name for assembly code listing file (**string**)|
|**CompileD2DCustomEffect**|Compile a Direct2D custom effect that contains pixel shaders. Do not use for a vertex or compute custom effect.(**bool**)|
|**ConsumeExportFile**|(**string**)|
|**DisableOptimizations**|Disable optimizations. (**bool**)<br/><br/>`/Od` implies `/Gfp` though output may not be identical to `/Od /Gfp`.|
|**EnableDebuggingInformation**|Enable debugging information. (**bool**)|
|**EnableUnboundedDescriptorTables**|Inform the compiler that a shader may contain a declaration of a resource array with unbounded range. Available for Shader Model 5.1 and above. (**bool**)<br/><br/>Use `/enable_unbounded_descriptor_tables`.|
|**EntryPointName**|Specifies the name of the entry point for the shader. (**string**)<br/><br/>Use `/E[name]`.|
|**GenerateExportFile**|(**string**)|
|**GenerateExportShaderProfile**|(**string**)|
|**HeaderFileOutput**|Specifies a name for header file containing object code. (**string**)<br/><br/>Use `/Fh [name]`.|
|**ObjectFileOutput**|Specifies a name for object file. (**string**)<br/><br/>Use `/Fo [name]`.|
|**PreprocessorDefinitions**|Defines preprocessing symbols for your source file. (**string[]**)|
|**SetRootSignature**|Attach root signature to shader bytecode. Available for Shader Model 5.0 and above. (**string**)<br/><br/>Use `/setrootsignature`.|
|**ShaderModel**|Specifies the shader model. Some shader types can only be used with recent shader models. (**string**)<br/><br/>Use `/T [type]_[model]`.|
|**ShaderType**|Specifies the type of shader. (**string**)<br/><br/>Use `/T [type]_[model]`.<br/><br/>**Effect**, use `fx`.<br/>**Vertex**, use `vs`.br/>**Pixel**, use `ps`.<br/>**Geometry**, use `gs`.<br/>**Hull**, use `hs`.<br/>**Domain**, use `ds`.<br/>**Compute**, use `cs`.<br/>**Library**, use `lib`.<br/>**RootSignature**, generate Root Signature Object.|
|**Source**|*required*(**ITaskItem**)|
|**SuppressStartupBanner**|Suppresses the display of the startup banner and information message. (**bool**)<br/><br/>Use `/nologo`.|
|**TrackerLogDirectory**|(**string**)|
|**TreatWarningAsError**|Treats all compiler warnings as errors. (**bool**)<br/><br/>For a new project, it may be best to use `/WX` in all compilations; resolving all warnings will ensure the fewest possible hard-to-find code defects.|
|**VariableName**|Specifies a name for the variable name in the header file (**string**)<br/><br/>Use `/Vn [name]`.|

## See also

[Task reference](../msbuild/msbuild-task-reference.md)