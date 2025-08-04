---
title: Create an MSBuild Inline Task with RoslynCodeTaskFactory
description: Learn about MSBuild RoslynCodeTaskFactory, which uses the cross-platform Roslyn compilers to generate in-memory task assemblies for use as inline tasks.
ms.date: 7/15/2025
ms.topic: how-to
helpviewer_keywords:
- MSBuild, tasks
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Create an MSBuild inline task with RoslynCodeTaskFactory

`RoslynCodeTaskFactory` uses the cross-platform Roslyn compilers to generate in-memory task assemblies for use as inline tasks. `RoslynCodeTaskFactory` tasks target .NET Standard and can work on .NET Framework and .NET Core runtimes as well as other platforms such as Linux and macOS.

>[!NOTE]
>The RoslynCodeTaskFactory is available in MSBuild 15.8 and above only. MSBuild versions follow Visual Studio versions, so RoslynCodeTaskFactory is available in Visual Studio 2017 version 15.8 and higher.

## The structure of an inline task with RoslynCodeTaskFactory

 `RoslynCodeTaskFactory` inline tasks are declared by using the `UsingTask` element. The inline task and the `UsingTask` element that contains it are typically included in a `.targets` file and imported into other project files as required. Here's a basic inline task. Notice that it does nothing.

```xml
<Project>
  <!-- This simple inline task does nothing. -->
  <UsingTask
    TaskName="DoNothing"
    TaskFactory="RoslynCodeTaskFactory"
    AssemblyFile="$(MSBuildToolsPath)\Microsoft.Build.Tasks.Core.dll" >
    <ParameterGroup />
    <Task>
      <Reference Include="" />
      <Using Namespace="" />
      <Code Type="Fragment" Language="cs">
      </Code>
    </Task>
  </UsingTask>
</Project>
```

 The `UsingTask` element in the example has three attributes that describe the task and the inline task factory that compiles it.

- The `TaskName` attribute names the task, in this case, `DoNothing`.

- The `TaskFactory` attribute names the class that implements the inline task factory.

- The `AssemblyFile` attribute gives the location of the inline task factory. Alternatively, you can use the `AssemblyName` attribute to specify the fully qualified name of the inline task factory class, which is typically located in the global assembly cache (GAC).

The remaining elements of the `DoNothing` task are empty and are provided to illustrate the order and structure of an inline task. A more robust example is presented later in this article.

- The `ParameterGroup` element is optional. When specified, it declares the parameters for the task. For more information about input and output parameters, see [Input and Output Parameters](#input-and-output-parameters) later in this article.

- The `Task` element describes and contains the task source code.

- The `Reference` element specifies references to the .NET assemblies that you're using in your code. This is equivalent to adding a reference to a project in Visual Studio. The `Include` attribute specifies the path of the referenced assembly.

- The `Using` element lists the namespaces that you want to access. This element resembles the `using` directive in Visual C#. The `Namespace` attribute specifies the namespace to include.

`Reference` and `Using` elements are language-agnostic. Inline tasks can be written in any one of the supported .NET CodeDom languages, for example, Visual Basic or Visual C#.

> [!NOTE]
> Elements contained by the `Task` element are specific to the task factory, in this case, the code task factory.

### Code element

The last child element to appear within the `Task` element is the `Code` element. The `Code` element contains or locates the code that you want to be compiled into a task. What you put in the `Code` element depends on how you want to write the task.

The `Language` attribute specifies the language in which your code is written. Acceptable values are `cs` for C#, `vb` for Visual Basic.

The `Type` attribute specifies the type of code that is found in the `Code` element.

- If the value of `Type` is `Class`, then the `Code` element contains code for a class that derives from the <xref:Microsoft.Build.Framework.ITask> interface.

- If the value of `Type` is `Method`, then the code defines an override of the `Execute` method of the <xref:Microsoft.Build.Framework.ITask> interface.

- If the value of `Type` is `Fragment`, then the code defines the contents of the `Execute` method, but not the signature or the `return` statement.

The code itself typically appears between a `<![CDATA[` marker and a `]]>` marker. Because the code is in a CDATA section, you do not have to worry about escaping reserved characters, for example, "\<" or ">".

Alternatively, you can use the `Source` attribute of the `Code` element to specify the location of a file that contains the code for your task. The code in the source file must be of the type that is specified by the `Type` attribute. If the `Source` attribute is present, the default value of `Type` is `Class`. If `Source` is not present, the default value is `Fragment`.

> [!NOTE]
> If you define the task class in a source file, the class name must agree with the `TaskName` attribute of the corresponding [UsingTask](../msbuild/usingtask-element-msbuild.md) element.

## Hello World

 Here is a more robust inline task with `RoslynCodeTaskFactory`. The HelloWorld task displays "Hello, world!" on the default error logging device, which is typically the system console or the Visual Studio **Output** window. The `Reference` element in the example is included just for illustration.

```xml
<Project>
  <!-- This simple inline task displays "Hello, world!" -->
  <UsingTask
    TaskName="HelloWorld"
    TaskFactory="RoslynCodeTaskFactory"
    AssemblyFile="$(MSBuildToolsPath)\Microsoft.Build.Tasks.Core.dll" >
    <ParameterGroup />
    <Task>
      <Reference Include="System.Xml"/>
      <Using Namespace="System"/>
      <Using Namespace="System.IO"/>
      <Code Type="Fragment" Language="cs">
<![CDATA[
// Display "Hello, world!"
Log.LogError("Hello, world!");
]]>
      </Code>
    </Task>
  </UsingTask>
</Project>
```

You could save the `HelloWorld` task in a file that is named *HelloWorld.targets*, and then invoke it from a project as follows.

```xml
<Project>
  <Import Project="HelloWorld.targets" />
  <Target Name="Hello">
    <HelloWorld />
  </Target>
</Project>
```

## Input and output parameters

 Inline task parameters are child elements of a `ParameterGroup` element. Every parameter takes the name of the element that defines it. The following code defines the parameter `Text`.

```xml
<ParameterGroup>
    <Text />
</ParameterGroup>
```

Parameters may have one or more of these attributes:

- `Required` is an optional attribute that is `false` by default. If `true`, then the parameter is required and must be given a value before calling the task.

- `ParameterType` is an optional attribute that is `System.String` by default. It may be set to any fully qualified type that is either an item or a value that can be converted to and from a string by using System.Convert.ChangeType. (In other words, any type that can be passed to and from an external task.)

- `Output` is an optional attribute that is `false` by default. If `true`, then the parameter must be given a value before returning from the Execute method.

For example,

```xml
<ParameterGroup>
    <Expression Required="true" />
    <Files ParameterType="Microsoft.Build.Framework.ITaskItem[]" Required="true" />
    <Tally ParameterType="System.Int32" Output="true" />
</ParameterGroup>
```

defines these three parameters:

- `Expression` is a required input parameter of type System.String.

- `Files` is a required item list input parameter.

- `Tally` is an output parameter of type System.Int32.

If the `Code` element has the `Type` attribute of `Fragment` or `Method`, then properties are automatically created for every parameter. In RoslynCodeTaskFactory, if the `Code` element has the `Type` attribute of `Class`, then you do not have to specify the `ParameterGroup`, since it is inferred from the source code (this is a difference from `CodeTaskFactory`). Otherwise, properties must be explicitly declared in the task source code, and must exactly match their parameter definitions.

## Example

 The following inline task logs some messages and returns a string.

```xml
<Project>

    <UsingTask TaskName="MySample"
               TaskFactory="RoslynCodeTaskFactory"
               AssemblyFile="$(MSBuildBinPath)\Microsoft.Build.Tasks.Core.dll">
        <ParameterGroup>
            <Parameter1 ParameterType="System.String" Required="true" />
            <Parameter2 ParameterType="System.String" />
            <Parameter3 ParameterType="System.String" Output="true" />
        </ParameterGroup>
        <Task>
            <Using Namespace="System" />
            <Code Type="Fragment" Language="cs">
              <![CDATA[
              Log.LogMessage(MessageImportance.High, "Hello from an inline task created by Roslyn!");
              Log.LogMessageFromText($"Parameter1: '{Parameter1}'", MessageImportance.High);
              Log.LogMessageFromText($"Parameter2: '{Parameter2}'", MessageImportance.High);
              Parameter3 = "A value from the Roslyn CodeTaskFactory";
            ]]>
            </Code>
        </Task>
    </UsingTask>

    <Target Name="Demo">
      <MySample Parameter1="A value for parameter 1" Parameter2="A value for parameter 2">
          <Output TaskParameter="Parameter3" PropertyName="NewProperty" />
      </MySample>

      <Message Text="NewProperty: '$(NewProperty)'" />
    </Target>
</Project>
```

These inline tasks can combine paths and get the file name.

```xml
<Project>

    <UsingTask TaskName="PathCombine"
               TaskFactory="RoslynCodeTaskFactory"
               AssemblyFile="$(MSBuildBinPath)\Microsoft.Build.Tasks.Core.dll">
        <ParameterGroup>
            <Paths ParameterType="System.String[]" Required="true" />
            <Combined ParameterType="System.String" Output="true" />
        </ParameterGroup>
        <Task>
            <Using Namespace="System" />
            <Code Type="Fragment" Language="cs">
            <![CDATA[
            Combined = Path.Combine(Paths);
            ]]>
            </Code>
        </Task>
    </UsingTask>

    <UsingTask TaskName="PathGetFileName"
             TaskFactory="RoslynCodeTaskFactory"
             AssemblyFile="$(MSBuildBinPath)\Microsoft.Build.Tasks.Core.dll">
        <ParameterGroup>
            <Path ParameterType="System.String" Required="true" />
            <FileName ParameterType="System.String" Output="true" />
        </ParameterGroup>
        <Task>
            <Using Namespace="System" />
            <Code Type="Fragment" Language="cs">
            <![CDATA[
            FileName = System.IO.Path.GetFileName(Path);
            ]]>
            </Code>
        </Task>
    </UsingTask>

    <Target Name="Demo">
        <PathCombine Paths="$(Temp);MyFolder;$([System.Guid]::NewGuid()).txt">
            <Output TaskParameter="Combined" PropertyName="MyCombinedPaths" />
        </PathCombine>

        <Message Text="Combined Paths: '$(MyCombinedPaths)'" />

        <PathGetFileName Path="$(MyCombinedPaths)">
            <Output TaskParameter="FileName" PropertyName="MyFileName" />
        </PathGetFileName>

        <Message Text="File name: '$(MyFileName)'" />
    </Target>
</Project>
```

## Provide backward compatibility

`RoslynCodeTaskFactory` first became available in MSBuild version 15.8. Suppose you want to support previous versions of Visual Studio and MSBuild, when `RoslynCodeTaskFactory` was not available, but `CodeTaskFactory` was, but you want to use the same build script. You can use a `Choose` construct that uses the `$(MSBuildVersion)` property to decide at build time whether to use the `RoslynCodeTaskFactory` or fall back to `CodeTaskFactory`, as in the following example:

```xml
<Project Sdk="Microsoft.NET.Sdk" DefaultTargets="RunTask">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net8.0</TargetFramework>
  </PropertyGroup>

  <Choose>
    <When Condition=" '$(MSBuildVersion.Substring(0,2))' >= 16 Or
    ('$(MSBuildVersion.Substring(0,2))' == 15 And '$(MSBuildVersion.Substring(3,1))' >= 8)">
      <PropertyGroup>
        <TaskFactory>RoslynCodeTaskFactory</TaskFactory>
      </PropertyGroup>
    </When>
    <Otherwise>
      <PropertyGroup>
        <TaskFactory>CodeTaskFactory</TaskFactory>
      </PropertyGroup>
    </Otherwise>
  </Choose>
  
  <UsingTask
    TaskName="HelloWorld"
    TaskFactory="$(TaskFactory)"
    AssemblyFile="$(MSBuildToolsPath)\Microsoft.Build.Tasks.Core.dll">
    <ParameterGroup />
    <Task>
      <Using Namespace="System"/>
      <Using Namespace="System.IO"/>
      <Code Type="Fragment" Language="cs">
        <![CDATA[
         Log.LogError("Using RoslynCodeTaskFactory");
      ]]>
      </Code>
    </Task>
  </UsingTask>

  <Target Name="RunTask" AfterTargets="Build">
    <Message Text="MSBuildVersion: $(MSBuildVersion)"/>
    <Message Text="TaskFactory: $(TaskFactory)"/>
    <HelloWorld />
  </Target>

</Project>
```

## Related content

- [Tasks](../msbuild/msbuild-tasks.md)
