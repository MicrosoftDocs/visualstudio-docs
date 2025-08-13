---
title: Overriding ToolsVersion Settings
description: Explore ways to change or override the value of the MSBuild Toolset for projects and solutions, including the ToolsVersion parameter and precedence order.
ms.date: 11/11/2022
ms.topic: how-to
helpviewer_keywords:
- MSBuild, overriding ToolsVersion setting
- MSBuild, building solutions with
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Override ToolsVersion settings

The `ToolsVersion` attribute on the Project element in Visual Studio and MSBuild project files is considered obsolete in Visual Studio 2019 and later; you can safely delete it. This article describes its use in older versions of MSBuild, or for custom toolsets. See [Standard and custom Toolset configurations](../msbuild/standard-and-custom-toolset-configurations.md).

You can change the toolset for projects and solutions in one of three ways:

1. By using the `-ToolsVersion` switch (or `-tv`, for short) when you build the project or solution from the command line.

2. By setting the `ToolsVersion` parameter on the MSBuild task.

3. By setting the `$(ProjectToolsVersion)` property on a project within a solution. This lets you build a project in a solution with a Toolset version that differs from that of the other projects.

## Override the ToolsVersion settings of projects and solutions on command line builds

 Although Visual Studio projects typically build with the ToolsVersion specified in the project file, you can use the `-ToolsVersion` (or `-tv`) switch on the command line to override that value and build all of the projects and their project-to-project dependencies with a different Toolset. For example:

```cmd
msbuild.exe someproj.proj -tv:12.0 -p:Configuration=Debug
```

 In this example, all projects are built using ToolsVersion 12.0. (However, see the section [Order of precedence](#order-of-precedence) later in this topic.)

 When using the `-tv` switch on the command line, you can optionally use the `$(ProjectToolsVersion)` property in individual projects to build them with a different ToolsVersion value than the other projects in the solution.

## Override the ToolsVersion settings using the ToolsVersion parameter of the MSBuild task

 The MSBuild task is the primary means for one project to build another. To enable the MSBuild task to build a project with a different ToolsVersion than the one specified in the project, it provides an optional task parameter named `ToolsVersion`. The following example demonstrates how to use this parameter:

1. Create a file that's named *projectA.proj* and that contains the following code:

    ```xml
    <Project>
        <Target Name="go" >
            <Message Text="projectA.proj" />
            <Message Text="MSBuildToolsVersion: $(MSBuildToolsVersion)" />
            <Message Text="MSBuildToolsPath:    $(MSBuildToolsPath)" />

            <MSBuild Projects="projectB.proj"
                ToolsVersion="2.0"
                Targets="go" />
        </Target>
    </Project>
    ```

2. Create another file that's named *projectB.proj* and that contains the following code:

    ```xml
    <Project>

        <Target Name="go">
            <Message Text="projectB.proj" />
            <Message Text="MSBuildToolsVersion: $(MSBuildToolsVersion)" />
            <Message Text="MSBuildToolsPath:    $(MSBuildToolsPath)" />
        </Target>
    </Project>
    ```

3. Enter the following command at a command prompt:

    ```cmd
    msbuild projectA.proj -t:go -toolsversion:3.5
    ```

4. The following output appears. For `projectA`, the `-toolsversion:3.5` setting on the command line overrides the `ToolsVersion=12.0` setting in the `Project` tag.

     `ProjectB` is called by a task in `projectA`. That task has `ToolsVersion=2.0`, which overrides the other `ToolsVersion` settings for `projectB`.

    ```
    Output:
      projectA.proj
      MSBuildToolsVersion: 3.5
      MSBuildToolsPath:    C:\Windows\Microsoft.NET\Framework\v3.5

      projectB.proj
      MSBuildToolsVersion: 2.0
      MSBuildToolsPath:    C:\Windows\Microsoft.NET\Framework\v2.0.50727
    ```

## Order of precedence

 The order of precedence, from highest to lowest, used to determine the `ToolsVersion` is:

1. The `ToolsVersion` attribute on the MSBuild task used to build the project, if any.

2. The `-toolsversion` (or `-tv`) switch that's used in the msbuild.exe command, if any.

3. If the environment variable `MSBUILDTREATALLTOOLSVERSIONSASCURRENT` is set, then use the current `ToolsVersion`.

4. If the environment variable `MSBUILDTREATHIGHERTOOLSVERSIONASCURRENT` is set and the `ToolsVersion` defined in the project file is greater than the current `ToolsVersion`, use the current `ToolsVersion`.

5. If the environment variable `MSBUILDLEGACYDEFAULTTOOLSVERSION` is set, or if `ToolsVersion` is not set, then the following steps are used:

    1. The `ToolsVersion` attribute of the [Project](../msbuild/project-element-msbuild.md) element of the project file. If this attribute doesn't exist, it is assumed to be the current version.

    2. The default tools version in the *MSBuild.exe.config* file.

    3. The default tools version in the registry. For more information, see [Standard and custom Toolset configurations](../msbuild/standard-and-custom-toolset-configurations.md).

6. If the environment variable `MSBUILDLEGACYDEFAULTTOOLSVERSION` is not set, then the following steps are used:

    1. If the environment variable `MSBUILDDEFAULTTOOLSVERSION` is set to a `ToolsVersion` that exists, use it.

    2. If `DefaultOverrideToolsVersion` is set in *MSBuild.exe.config*, use it.

    3. If `DefaultOverrideToolsVersion` is set in the registry, use it.

    4. Otherwise, use the current `ToolsVersion`.

## Related content

- [Multitargeting](../msbuild/msbuild-multitargeting-overview.md)
- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [Toolset (ToolsVersion)](../msbuild/msbuild-toolset-toolsversion.md)
- [Standard and custom Toolset configurations](../msbuild/standard-and-custom-toolset-configurations.md)
