---
title: 'Use Environment Variables in a Build'
description: Work with environment variables in MSBuild project files, and use environment variables to set build options without modifying the project file.
ms.date: 8/11/2025
ms.topic: how-to
helpviewer_keywords:
- environment variables, referencing
- projects [.NET Framework], environment variables
- MSBuild, environment variables
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Use environment variables in a build

When you build projects, it's often necessary to set build options using information that isn't in the project file or the files that comprise your project. This information is typically stored in environment variables.

> [!NOTE]
> Environment variables are considered trusted inputs by MSBuild. They can direct the loading of extensibility from non-default locations during a build.

## Reference environment variables

 All environment variables that are valid MSBuild property names are available to the MSBuild project file as properties. Valid property names are described in [MSBuild properties](msbuild-properties.md). For example, environment variables that begin with a number aren't available in MSBuild.

> [!NOTE]
> If the project file contains an explicit definition of a property that has the same name as an environment variable, the property in the project file overrides the value of the environment variable.

#### To use an environment variable in an MSBuild project

- Reference the environment variable the same way you would a variable declared in your project file. For example, the following code references the BIN_PATH environment variable:

   `<FinalOutput>$(BIN_PATH)\MyAssembly.dll</FinalOutput>`

  You can use a `Condition` attribute to provide a default value for a property if the environment variable wasn't set.

#### To provide a default value for a property

- Use a `Condition` attribute on a property to set the value only if the property has no value. For example, the following code sets the `ToolsPath` property to *c:\tools* only if the `ToolsPath` environment variable isn't set:

     `<ToolsPath Condition="'$(TOOLSPATH)' == ''">c:\tools</ToolsPath>`

    > [!NOTE]
    > Property names are not case-sensitive so both `$(ToolsPath)` and `$(TOOLSPATH)` reference the same property or environment variable.

## Example

 The following project file uses environment variables to specify the location of directories.

```xml
<Project DefaultTargets="FakeBuild">
    <PropertyGroup>
        <FinalOutput>$(BIN_PATH)\myassembly.dll</FinalOutput>
        <ToolsPath Condition=" '$(ToolsPath)' == '' ">
            C:\Tools
        </ToolsPath>
    </PropertyGroup>
    <Target Name="FakeBuild">
        <Message Text="Building $(FinalOutput) using the tools at $(ToolsPath)..."/>
    </Target>
</Project>
```

## Related content

- [MSBuild](../msbuild/msbuild.md)
- [MSBuild properties](../msbuild/msbuild-properties.md)
- [How to: Build the same source files with different options](../msbuild/how-to-build-the-same-source-files-with-different-options.md)
