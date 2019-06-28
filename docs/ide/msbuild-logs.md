---
title: Troubleshoot and create logs for MSBuild problems
ms.date: 06/27/2019
ms.topic: conceptual
helpviewer_keywords:
  - msbuild logs"
author: mikeblome
ms.author: mblome
manager: jillfra
dev_langs:
 - CSharp
 - VB
 - CPP
ms.workload:
  - "multiple"
---

# Troubleshoot and create logs for MSBuild problems

## A project property appears to be set to particular value, but has no effect on build

1. Open the Visual Studio Developer Command Prompt that corresponds to your version of Visual Studio.
1. Run the following command, after substituting the values for your solution path and project name:

    ```cmd
    msbuild /p:SolutionDir="c:\MySolutionDir\";Configuration="MyConfiguration";Platform="Win32" /pp:out.xml MyProject.vcxproj
    ```

    This command produces a "preprocessed" msbuild project (out.xml). You can search that file for a specific property to see where it is defined. 

The last definition of a property is what will be used during the build. Also, msbuild evaluates the project in several passes:

- PropertyGroups and Imports
- IntemDefinitionGroups
- IntemGroups
- Targets 

Therefore, given the following order:

```xml
<PropertyGroup>
   <MyProperty>A</MyProperty>
</PropertyGroup>
<ItemGroup>
   <MyItems Include="MyFile.txt" />
</ItemGroup>
<ItemDefinitionGroup>
  <MyItems>
      <MyMetadata>$(MyProperty) </MyMetadata>
  </MyItems>
</ItemDefinitionGroup>
<PropertyGroup>
   <MyProperty>B</MyProperty>
</PropertyGroup>
```

The value of "MyMetadata" for "MyFile.txt" item will be evaluated to "B" during build (not "A" and not empty)

## Incremental build is building more than it should

To see why msbuild thinks it needs to rebuild something, a detailed or binary build log is needed. When you have the log (see below how to produce it) you can search it for the file which was built unnecessarily (or just "will be compiled" if you don't expect anything to be built)  and see something like this:

```output
Task "CL"

  Using cached input dependency table built from:

  F:\test\Project1\Project1\Debug\Project1.tlog\CL.read.1.tlog

  Outputs for F:\TEST\PROJECT1\PROJECT1\PROJECT1.CPP:
  F:\TEST\PROJECT1\PROJECT1\DEBUG\PROJECT1.OBJ
  Project1.cpp will be compiled because F:\TEST\PROJECT1\PROJECT1\PROJECT1.H was modified at 6/5/2019 12:37:09 PM.

  Outputs for F:\TEST\PROJECT1\PROJECT1\PROJECT1.CPP:
  F:\TEST\PROJECT1\PROJECT1\DEBUG\PROJECT1.OBJ

  Write Tracking Logs:
  Debug\Project1.tlog\CL.write.1.tlog
```

If you are building in VS IDE (with detailed output window verbosity), the reason each project is not Up-To-Date will be printed in the output window:

```output
1>------ Up-To-Date check: Project: Project1, Configuration: Debug Win32 ------

1>Project is not up-to-date: build input 'f:\test\project1\project1\project1.h' was modified after the last build finished.
```

## How to produce a binary msbuild log

1. Go to VS2019 Developer Command Prompt (replace VS2019 with the VS version used) and run there:

    ```cmd
    Msbuild /p:Configuration="MyConfiguration";Platform="x86" /bl MySolution.sln
    ```

    or

    ```cmd
    Msbuild /p:/p:SolutionDir="c:\MySolutionDir\";Configuration="MyConfiguration";Platform="Win32" /bl MyProject.vcxproj
    ```

A Msbuild.binlog file will be created in the directory that you ran msbuild from. You can view and search it by using the [Msbuild Structured Log Viewer](http://www.msbuildlog.com/).

## How to produce a detailed log

In Visual Studio:

1. Go to **Tools** > **Options** > **Projects and Solutions** >**Build and Run**.
1. Set **Msbuild project build verbosity** to **Detailed** in both combo boxes. The top one controls build verbosity in the Output window and the second one controls build verbosity in the \<projectname\>.log file that is created in the each project's Intermediate directory during build.
1. From a Visual Studio developer command prompt, enter these commands, substituting your actual paths:

    ```cmd
    Msbuild /p:Configuration="MyConfiguration";Platform="x86" /fl MySolution.sln 
    ```

    or

    ```cmd
    Msbuild /p:/p:SolutionDir="c:\MySolutionDir\";Configuration="MyConfiguration";Platform="Win32" /fl MyProject.vcxproj
    ```

    Msbuild.log file will be created in the directory that you ran msbuild from.  
