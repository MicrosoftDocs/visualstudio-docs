---
title: MSBuild Tasks Specific to C++
description: See MSBuild tasks that are available when C++ is installed, which MSBuild uses when building C++ code.
ms.date: 03/10/2019
ms.topic: reference
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- MSBuild, tasks specific to C++
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# MSBuild tasks specific to C++

Tasks provide the code that runs during the build process. When C++ is installed, the following tasks are available, in addition to those that are installed with MSBuild. For more information, see [MSBuild (C++) overview](/cpp/build/msbuild-visual-cpp-overview).

 In addition to the parameters for each task, every task also has the following parameters.

| Parameter | Description |
|-------------------| - |
| `Condition` | Optional `String` parameter.<br /><br /> A `Boolean` expression that the MSBuild engine uses to determine whether this task will be executed. For information about the conditions that are supported by MSBuild, see [Conditions](../msbuild/msbuild-conditions.md). |
| `ContinueOnError` | Optional parameter. Can contain one of the following values:<br /><br /> -   **WarnAndContinue** or **true**. When a task fails, subsequent tasks in the [Target](../msbuild/target-element-msbuild.md) element and the build continue to execute, and all errors from the task are treated as warnings<br />-   **ErrorAndContinue**. When a task fails, subsequent tasks in the `Target` element and the build continue to execute, and all errors from the task are treated as errors.<br />-   **ErrorAndStop** or **false** (default). When a task fails, the remaining tasks in the `Target` element and the build aren't executed, and the entire `Target` element and the build are considered to have failed.<br /><br /> Versions of the .NET Framework before 4.5 supported only the `true` and `false` values.<br /><br /> For more information, see [How to: Ignore errors in tasks](../msbuild/how-to-ignore-errors-in-tasks.md). |

### Related topics

|Title|Description|
|-----------|-----------------|
|[BscMake task](../msbuild/bscmake-task.md)|Wraps the Microsoft Browse Information Maintenance Utility tool (*bscmake.exe*).|
|[CL task](../msbuild/cl-task.md)|Wraps the Microsoft C++ Compiler tool (*cl.exe*).|
|[CPPClean task](../msbuild/cppclean-task.md)|Deletes the temporary files that MSBuild creates when a C++ project is built.|
|[ClangCompile task](../msbuild/clangcompile-task.md)|Wraps the C++ compiler tool (*clang.exe*).|
|[CustomBuild task](../msbuild/custombuild-task.md)|Wraps the C++ compiler tool (*cmd.exe*).|
|[FXC task](../msbuild/fxc-task.md)|Use HLSL shader compilers in the build process.|
|[GetOutOfDateItems](../msbuild/getoutofdateitems-task.md)|Reads old tlogs, writes new tlogs and returns set of items which are not up-to-date. (helper task)|
|[GetOutputFileName](../msbuild/getoutputfilename-task.md)|Gets output file name for cl and other tools, which allow specifying only output directory or full file name or nothing. (helper task)|
|[LIB task](../msbuild/lib-task.md)|Wraps the Microsoft 32-Bit Library Manager tool (*lib.exe*).|
|[Link task](../msbuild/link-task.md)|Wraps the Microsoft C++ Linker tool (*link.exe*).|
|[MIDL task](../msbuild/midl-task.md)|Wraps the Microsoft Interface Definition Language (MIDL) compiler tool (*midl.exe*).|
|[MT task](../msbuild/mt-task.md)|Wraps the Microsoft Manifest Tool (*mt.exe*).|
|[MultiToolTask task](../msbuild/multitooltask-task.md)|No description.|
|[ParallelCustomBuild task](../msbuild/parallelcustombuild-task.md)|Run parallel instances of the [CustomBuild task](../msbuild/custombuild-task.md).|
|[RC task](../msbuild/rc-task.md)|Wraps the Microsoft Windows Resource Compiler tool (*rc.exe*).|
|[SetEnv task](../msbuild/setenv-task.md)|Sets or deletes the value of a specified environment variable.|
|[TrackedVCToolTask base class](../msbuild/trackedvctooltask-base-class.md)|Inherits from [VCToolTask](../msbuild/vctooltask-base-class.md).|
|[VCMessage task](../msbuild/vcmessage-task.md)|Logs warning messages and error messages during a build. (Not extendable. Internal use only.)|
|[VCToolTask base class](../msbuild/vctooltask-base-class.md)|Inherits from [ToolTask](/dotnet/api/microsoft.build.utilities.tooltask).|
|[XDCMake task](../msbuild/xdcmake-task.md)|Wraps the XML Documentation tool (*xdcmake.exe*), which merges XML document comment (*.xdc*) files into an *.xml* file.|
|[XSD task](../msbuild/xsd-task.md)|Wraps the XML Schema Definition tool (*xsd.exe*), which generates schema or class files from a source. *See note below.*|
|[MSBuild reference](../msbuild/msbuild-reference.md)|Describes the elements of the MSBuild system.|
|[Tasks](../msbuild/msbuild-tasks.md)|Describes tasks, which are units of code that can be combined to produce a build.|
|[Task writing](../msbuild/task-writing.md)|Describes how to create a task.|

> [!NOTE]
> Starting in Visual Studio 2017, C++ project support for *xsd.exe* is deprecated. You can still use the **Microsoft.VisualC.CppCodeProvider** APIs by manually adding *CppCodeProvider.dll* to the GAC.
