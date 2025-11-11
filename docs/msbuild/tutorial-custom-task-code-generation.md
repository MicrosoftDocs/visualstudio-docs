---
title: Create a custom task with MSBuild
description: Use MSBuild to create a custom task for code generation that properly handles incremental build and clean operations and supports multitargeting.
ms.date: 3/13/2025
ms.topic: tutorial
helpviewer_keywords:
- tasks
- MSBuild, tasks
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Tutorial: Create a custom task for code generation

In this tutorial, you'll create a custom task in MSBuild in C# that handles code generation, and then you'll use the task in a build. This example demonstrates how to use MSBuild to handle the clean and rebuild operations. The example also shows how to support incremental build, so that the code is generated only when the input files have changed. The techniques demonstrated are applicable to a wide range of code generation scenarios. The steps also show the use of NuGet to package the task for distribution, and the tutorial includes an optional step to use the BinLog viewer to improve the troubleshooting experience.

## Prerequisites

You should have an understanding of MSBuild concepts such as tasks, targets, and properties. See [MSBuild concepts](msbuild-concepts.md).

The examples require MSBuild, which is installed with Visual Studio, but can also be installed separately. See [Download MSBuild without Visual Studio](https://aka.ms/vs/download/?q=build+tools).

## Introduction to the code example

The example takes an input text file containing values to be set, and creates a C# code file with code that creates these values. While that is a simple example, the same basic techniques can be applied to more complex code generation scenarios. 

In this tutorial, you'll create a MSBuild custom task named AppSettingStronglyTyped. The task will read a set of text files, and each file with lines with the following format:

```
propertyName:type:defaultValue
```

The code generates a C# class with all the constants. A problem should stop the build and give the user enough information to diagnose the problem.

The complete sample code for this tutorial is at [Custom task - code generation](https://github.com/dotnet/samples/tree/main/msbuild/custom-task-code-generation) in the .NET samples repo on GitHub.

## Create the AppSettingStronglyTyped project

Create a .NET Standard Class Library. The framework should be .NET Standard 2.0.

Note the difference between full MSBuild (the one that Visual Studio uses) and portable MSBuild, the one bundled in the .NET Core Command Line.

- Full MSBuild: This version of MSBuild usually lives inside Visual Studio. Runs on .NET Framework. Visual Studio uses this when you execute **Build** on your solution or project. This version is also available from a command-line environment, such as the Visual Studio Developer Command Prompt, or PowerShell.
- .NET MSBuild: This version of MSBuild is bundled in the .NET Core Command Line. It runs on .NET Core. Visual Studio doesn't directly invoke this version of MSBuild. It only supports projects that build using Microsoft.NET.Sdk.

if you want to share code between .NET Framework and any other .NET implementation, such as .NET Core, your library should target [.NET Standard 2.0](/dotnet/standard/net-standard), and you want to run inside Visual Studio, which runs on the .NET Framework. .NET Framework doesn't support .NET Standard 2.1.

## Choose the MSBuild API version to reference

When compiling a custom task, you should reference the version of the MSBuild API (`Microsoft.Build.*`) that matches the minimum version of Visual Studio and/or the .NET SDK that you expect to support. For example, to support users on Visual Studio 2019, you should build against MSBuild 16.11.

## Create the AppSettingStronglyTyped MSBuild custom task

The first step is to create the MSBuild custom task. Information about how to [write an MSBuild custom task](task-writing.md) might help you understand the following steps. An MSBuild custom task is a class that implements the <xref:Microsoft.Build.Framework.ITask> interface.

1. Add a reference to the *Microsoft.Build.Utilities.Core* NuGet package, and then create a class named AppSettingStronglyTyped derived from Microsoft.Build.Utilities.Task.

1. Add three properties. These properties define the parameters of the task that users set when they use the task in a client project:

    ```csharp
    //The name of the class which is going to be generated
    [Required]
    public string SettingClassName { get; set; }

    //The name of the namespace where the class is going to be generated
    [Required]
    public string SettingNamespaceName { get; set; }

    //List of files which we need to read with the defined format: 'propertyName:type:defaultValue' per line
    [Required]
    public ITaskItem[] SettingFiles { get; set; }
    ```

	The task processes the *SettingFiles* and generates a class `SettingNamespaceName.SettingClassName`. The generated class will have a set of constants based on the text file's content.

    The task output should be a string that gives the filename of the generated code:

    ```csharp
    // The filename where the class was generated
    [Output]
    public string ClassNameFile { get; set; }
    ```

1. When you create a custom task, you inherit from <xref:Microsoft.Build.Utilities.Task?displayProperty=fullName>. To implement the task, you override the <xref:Microsoft.Build.Utilities.Task.Execute> method. The `Execute` method returns `true` if the task succeeds, and `false` otherwise. `Task` implements <xref:Microsoft.Build.Framework.ITask?displayProperty=nameWithType> and provides default implementations of some `ITask` members and additionally, provides some logging functionality. It's important to output status to the log to diagnose and troubleshoot the task, especially if a problem occurs and the task must return an error result (`false`). On error, the class signals the error by calling <xref:Microsoft.Build.Utilities.TaskLoggingHelper.LogError%2A?displayProperty=nameWithType>.

    ```csharp
    public override bool Execute()
    {
        //Read the input files and return a IDictionary<string, object> with the properties to be created. 
        //Any format error it will return false and log an error
        var (success, settings) = ReadProjectSettingFiles();
        if (!success)
        {
                return !Log.HasLoggedErrors;
        }
        //Create the class based on the Dictionary
        success = CreateSettingClass(settings);

        return !Log.HasLoggedErrors;
    }
    ```

    The Task API allows returning false, indicating failure, without indicating to the user what went wrong. It's best to return `!Log.HasLoggedErrors` instead of a boolean code, and log an error when something goes wrong.

### Log errors

The best practice when logging errors is to provide details such as the line number and a distinct error code when logging an error. The following code parses the text input file and uses the <xref:Microsoft.Build.Utilities.TaskLoggingHelper.LogError%2A?displayProperty=nameWithType> method with the line number in the text file that produced the error.

```csharp
private (bool, IDictionary<string, object>) ReadProjectSettingFiles()
{
    var values = new Dictionary<string, object>();
    foreach (var item in SettingFiles)
    {
        int lineNumber = 0;

        var settingFile = item.GetMetadata("FullPath");
        foreach (string line in File.ReadLines(settingFile))
        {
            lineNumber++;

            var lineParse = line.Split(':');
            if (lineParse.Length != 3)
            {
                Log.LogError(subcategory: null,
                             errorCode: "APPS0001",
                             helpKeyword: null,
                             file: settingFile,
                             lineNumber: lineNumber,
                             columnNumber: 0,
                             endLineNumber: 0,
                             endColumnNumber: 0,
                             message: "Incorrect line format. Valid format prop:type:defaultvalue");
                             return (false, null);
            }
            var value = GetValue(lineParse[1], lineParse[2]);
            if (!value.Item1)
            {
                return (value.Item1, null);
            }

            values[lineParse[0]] = value.Item2;
        }
    }
    return (true, values);
}
```

Using the techniques shown in the previous code, errors in the syntax of the text input file show up as build errors with helpful diagnostic information:

```output
Microsoft (R) Build Engine version 17.2.0 for .NET Framework
Copyright (C) Microsoft Corporation. All rights reserved.

Build started 2/16/2022 10:23:24 AM.
Project "S:\work\msbuild-examples\custom-task-code-generation\AppSettingStronglyTyped\AppSettingStronglyTyped.Test\bin\Debug\net6.0\Resources\testscript-fail.msbuild" on node 1 (default targets).
S:\work\msbuild-examples\custom-task-code-generation\AppSettingStronglyTyped\AppSettingStronglyTyped.Test\bin\Debug\net6.0\Resources\error-prop.setting(1): error APPS0001: Incorrect line format. Valid format prop:type:defaultvalue [S:\work\msbuild-examples\custom-task-code-generation\AppSettingStronglyTyped\AppSettingStronglyTyped.Test\bin\Debug\net6.0\Resources\testscript-fail.msbuild]
Done Building Project "S:\work\msbuild-examples\custom-task-code-generation\AppSettingStronglyTyped\AppSettingStronglyTyped.Test\bin\Debug\net6.0\Resources\testscript-fail.msbuild" (default targets) -- FAILED.

Build FAILED.

"S:\work\msbuild-examples\custom-task-code-generation\AppSettingStronglyTyped\AppSettingStronglyTyped.Test\bin\Debug\net6.0\Resources\testscript-fail.msbuild" (default target) (1) ->
(generateSettingClass target) ->
  S:\work\msbuild-examples\custom-task-code-generation\AppSettingStronglyTyped\AppSettingStronglyTyped.Test\bin\Debug\net6.0\Resources\error-prop.setting(1): error APPS0001: Incorrect line format. Valid format prop:type:defaultvalue [S:\work\msbuild-examples\custom-task-code-generation\AppSettingStronglyTyped\AppSettingStronglyTyped.Test\bin\Debug\net6.0\Resources\testscript-fail.msbuild]

     0 Warning(s)
     1 Error(s)
```

When you catch exceptions in your task, use the <xref:Microsoft.Build.Utilities.TaskLoggingHelper.LogErrorFromException%2A?displayProperty=nameWithType> method. This will improve the error output, for example by obtaining the call stack where the exception was thrown.

```csharp
catch (Exception ex)
{
    // This logging helper method is designed to capture and display information
    // from arbitrary exceptions in a standard way.
    Log.LogErrorFromException(ex, showStackTrace: true);
    return false;
}
```

The implementation of the other methods that use these inputs to build the text for the generated code file isn't shown here; see [AppSettingStronglyTyped.cs](https://github.com/v-fearam/msbuild-examples/blob/main/custom-task-code-generation/AppSettingStronglyTyped/AppSettingStronglyTyped/AppSettingStronglyTyped.cs) in the sample repo.

The example code generates C# code during the build process. The task is like any other C# class, so when you're done with this tutorial, you can customize it and add whatever functionality is necessary for your own scenario.

## Generate a console app and use the custom task

In this section, you'll create a standard .NET Core Console App that uses the task.

> [!IMPORTANT]
> It's important to avoid generating a MSBuild custom task in the same MSBuild process which is going to consume it. The new project should be in a complete different Visual Studio solution, or the new project use a dll pre-generated and re-located from the standard output.

1. Create the .NET Console project MSBuildConsoleExample in a new Visual Studio Solution.

    The normal way to distribute a task is through a NuGet package, but during development and debugging, you can include all the information on `.props` and `.targets` directly in your application's project file and then move to the NuGet format when you distribute the task to others.

1. Modify the project file to consume the code generation task. The code listing in this section shows the modified project file after referencing the task, setting the input parameters for the task, and writing the targets for handling clean and rebuild operations so that the generated code file is removed as you would expect.

    Tasks are registered using the [UsingTask element (MSBuild)](usingtask-element-msbuild.md).  The `UsingTask` element registers the task; it tells MSBuild the name of the task and how to locate and run the assembly that contains the task class. The assembly path is relative to the project file.  

    The `PropertyGroup` contains the property definitions that correspond to the properties defined in the task. These properties are set using attributes, and the task name is used as the element name.

    `TaskName` is the name of the task to reference from the assembly. This attribute should always use fully specified namespaces. `AssemblyFile` is the file path of the assembly.

    To invoke the task, add the task to the appropriate target, in this case `GenerateSetting`.

    The target `ForceGenerateOnRebuild` handles the clean and rebuild operations by deleting the generated file. It's set to run after the `CoreClean` target by setting the `AfterTargets` attribute to `CoreClean`.

    ```xml
    <Project Sdk="Microsoft.NET.Sdk">
        <UsingTask TaskName="AppSettingStronglyTyped.AppSettingStronglyTyped" AssemblyFile="..\..\AppSettingStronglyTyped\AppSettingStronglyTyped\bin\Debug\netstandard2.0\AppSettingStronglyTyped.dll"/>

        <PropertyGroup>
            <OutputType>Exe</OutputType>
            <TargetFramework>net6.0</TargetFramework>
            <RootFolder>$(MSBuildProjectDirectory)</RootFolder>
            <SettingClass>MySetting</SettingClass>
            <SettingNamespace>MSBuildConsoleExample</SettingNamespace>
            <SettingExtensionFile>mysettings</SettingExtensionFile>
        </PropertyGroup>

        <ItemGroup>
            <SettingFiles Include="$(RootFolder)\*.mysettings" />
        </ItemGroup>

        <Target Name="GenerateSetting" BeforeTargets="CoreCompile" Inputs="@(SettingFiles)" Outputs="$(RootFolder)\$(SettingClass).generated.cs">
            <AppSettingStronglyTyped SettingClassName="$(SettingClass)" SettingNamespaceName="$(SettingNamespace)" SettingFiles="@(SettingFiles)">
            <Output TaskParameter="ClassNameFile" PropertyName="SettingClassFileName" />
            </AppSettingStronglyTyped>
            <ItemGroup>
                <Compile Remove="$(SettingClassFileName)" />
                <Compile Include="$(SettingClassFileName)" />
            </ItemGroup>
        </Target>

        <Target Name="ForceReGenerateOnRebuild" AfterTargets="CoreClean">
            <Delete Files="$(RootFolder)\$(SettingClass).generated.cs" />
        </Target>
    </Project>
    ```

    > [!NOTE]
    > Instead of overriding a target such as `CoreClean`, this code uses another way to order the targets [(BeforeTarget and AfterTarget)](target-build-order.md#beforetargets-and-aftertargets). SDK-style projects have an implicit import of targets after the last line of the project file; this means that you can't override default targets unless you specify your imports manually. See [Override predefined targets](how-to-extend-the-visual-studio-build-process.md#override-predefined-targets).

    The `Inputs` and `Outputs` attributes help MSBuild be more efficient by providing information for incremental builds. The dates of the inputs are compared against the outputs to see if the target needs to be run, or if the output of the previous build can be reused.

1. Create the input text file with the extension defined to be discovered. Using the default extension, create `MyValues.mysettings` on the root, with the following content:

    ```
    Greeting:string:Hello World!
    ```

1. Build again, and the generated file should be created and built. Check the project folder for the *MySetting.generated.cs* file.

1. The class *MySetting* is in the wrong namespace, so now make a change to use our app namespace. Open the project file and add the following code:

    ```xml
    <PropertyGroup>
        <SettingNamespace>MSBuildConsoleExample</SettingNamespace>
    </PropertyGroup>
    ```

1. Rebuild again, and observe that the class is in the `MSBuildConsoleExample` namespace. In this way, you can redefine the generated class name (`SettingClass`), the text extension files (`SettingExtensionFile`) to be use as input, and the location (`RootFolder`) of them if you like.

1. Open `Program.cs` and change the hardcoded 'Hello World!!' to the user-defined constant:

    ```csharp
    static void Main(string[] args)
    {
        Console.WriteLine(MySetting.Greeting);
    }
    ```

Execute the program; it will print the greeting from the generated class.

### (Optional) Log events during the build process

It's possible to compile using a command-line command. Navigate to the project folder. You'll use the  `-bl` (binary log) option to generate a binary log. The binary log will have useful information to know what is going on during build process.

```dotnetcli
# Using dotnet MSBuild (run core environment)
dotnet build -bl

# or full MSBuild (run on net framework environment; this is used by Visual Studio)
msbuild -bl
```

Both of the commands generate a log file `msbuild.binlog`, which can be opened with [MSBuild Binary and Structured Log Viewer](https://msbuildlog.com/). The option `/t:rebuild` means run the rebuild target. It will force the regeneration of the generated code file.

Congratulations! You've built a task that generates code, and used it in a build.

## Package the task for distribution

If you only need to use your custom task in a few projects or in a single solution, consuming the task as a raw assembly might be all you need, but the best way to prepare your task to use it elsewhere or share it with others is as a NuGet package.

MSBuild Task packages have a few key differences from library NuGet packages:

- They have to bundle their own assembly dependencies, instead of exposing those dependencies to the consuming project
- They do not package any required assemblies to a `lib/<target framework>` folder, because that would cause NuGet to include the assemblies in any package that consumes the task
- They only need to *compile* against the Microsoft.Build assemblies - at runtime these will be provided by the actual MSBuild engine and so do not need to be included in the package
- They generate a special `.deps.json` file that helps MSBuild to load the Task's dependencies (especially native dependencies) in a consistent fashion

To accomplish all of these goals, you have to make a few changes to the standard project file above and beyond the ones you may be familiar with.

### Create a NuGet package

Creating a NuGet package is the recommended way to distribute your custom task to others.

#### Prepare to generate the package

To prepare to generate a NuGet package, make some changes to the project file to specify the details that describe the package. The initial project file you created resembles the following code:

```xml
<Project Sdk="Microsoft.NET.Sdk">

    <PropertyGroup>
        <TargetFramework>netstandard2.0</TargetFramework>
    </PropertyGroup>

    <ItemGroup>
        <PackageReference Include="Microsoft.Build.Utilities.Core" Version="17.0.0" />
    </ItemGroup>

</Project>
```

To generate a NuGet package, add the following code to set the properties for the package. You can see a full list of supported MSBuild properties in the [Pack documentation](/nuget/reference/msbuild-targets#pack-target):

```xml
<PropertyGroup>
    ... 
    <IsPackable>true</IsPackable>
    <Version>1.0.0</Version>
    <Title>AppSettingStronglyTyped</Title>
    <Authors>Your author name</Authors>
    <Description>Generates a strongly typed setting class base on a text file.</Description>
    <PackageTags>MyTags</PackageTags>
    <Copyright>Copyright ©Contoso 2022</Copyright>
    <CopyLocalLockFileAssemblies>true</CopyLocalLockFileAssemblies>
    ...
</PropertyGroup>
```

The property [CopyLocalLockFileAssemblies](/dotnet/core/project-sdk/msbuild-props#copylocallockfileassemblies) is needed to make sure that dependencies are copied to the output directory.

#### Mark dependencies as private

The dependencies of your MSBuild task must be packaged inside the package; they cannot be expressed as normal package references. The package won't expose any regular dependencies to external users. This takes two steps to accomplish: marking your assemblies as private and actually embedding them in the generated package. For this example, we'll assume that your task depends on `Microsoft.Extensions.DependencyInjection` to work, so add a `PackageReference` to `Microsoft.Extensions.DependencyInjection` at version `6.0.0`.

```xml
<ItemGroup>
    <PackageReference 
        Include="Microsoft.Build.Utilities.Core"
        Version="17.0.0" />
    <PackageReference
        Include="Microsoft.Extensions.DependencyInjection"
        Version="6.0.0" />
</ItemGroup>
```

Now, mark every dependency of this Task project, both `PackageReference` and `ProjectReference` with the `PrivateAssets="all"` attribute. This will tell NuGet not to expose these dependencies to consuming projects at all. You can read more about controlling dependency assets [at the NuGet documentation](/nuget/consume-packages/package-references-in-project-files#controlling-dependency-assets).

```xml
<ItemGroup>
    <PackageReference 
        Include="Microsoft.Build.Utilities.Core"
        Version="17.0.0"
        PrivateAssets="all"
    />
    <PackageReference
        Include="Microsoft.Extensions.DependencyInjection"
        Version="6.0.0"
        PrivateAssets="all"
    />
</ItemGroup>
```

#### Bundle dependencies into the package

You must also embed the runtime assets of our dependencies into the Task package. There are two parts to this: an MSBuild target that adds our dependencies to the `BuildOutputInPackage` ItemGroup, and a few properties that control the layout of those `BuildOutputInPackage` items. You can learn more about this process [in the NuGet documentation](/nuget/reference/msbuild-targets#targetsfortfmspecificbuildoutput).

```xml
<PropertyGroup>
    ...
    <!-- This target will run when MSBuild is collecting the files to be packaged, and we'll implement it below. This property controls the dependency list for this packaging process, so by adding our custom property we hook ourselves into the process in a supported way. -->
    <TargetsForTfmSpecificBuildOutput>
        $(TargetsForTfmSpecificBuildOutput);CopyProjectReferencesToPackage
    </TargetsForTfmSpecificBuildOutput>
    <!-- This property tells MSBuild where the root folder of the package's build assets should be. Because we are not a library package, we should not pack to 'lib'. Instead, we choose 'tasks' by convention. -->
    <BuildOutputTargetFolder>tasks</BuildOutputTargetFolder>
    <!-- NuGet does validation that libraries in a package are exposed as dependencies, but we _explicitly_ do not want that behavior for MSBuild tasks. They are isolated by design. Therefore we ignore this specific warning. -->
    <NoWarn>NU5100</NoWarn>
    <!-- Suppress NuGet warning NU5128. -->
    <SuppressDependenciesWhenPacking>true</SuppressDependenciesWhenPacking>
    ...
</PropertyGroup>

...
<!-- This is the target we defined above. It's purpose is to add all of our PackageReference and ProjectReference's runtime assets to our package output.  -->
<Target
    Name="CopyProjectReferencesToPackage"
    DependsOnTargets="ResolveReferences">
    <ItemGroup>
        <!-- The TargetPath is the path inside the package that the source file will be placed. This is already precomputed in the ReferenceCopyLocalPaths items' DestinationSubPath, so reuse it here. -->
        <BuildOutputInPackage
            Include="@(ReferenceCopyLocalPaths)"
            TargetPath="%(ReferenceCopyLocalPaths.DestinationSubPath)" />
    </ItemGroup>
</Target>
```

#### Don't bundle the Microsoft.Build.Utilities.Core assembly

As discussed above, this dependency will be provided by MSBuild itself at runtime, so we don't need to bundle it into the package. To do so, add the `ExcludeAssets="Runtime"` attribute to the `PackageReference` for it

```xml
...
<PackageReference 
    Include="Microsoft.Build.Utilities.Core"
    Version="17.0.0"
    PrivateAssets="all"
    ExcludeAssets="Runtime"
/>
...
```

#### Generate and embed a deps.json file

The `deps.json` file can be used by MSBuild to ensure the correct versions of your dependencies are loaded. You'll need to add some MSBuild properties to cause the file to be generated, since it is not generated by default for libraries. Then, add a target to include it in our package output, similarly to how you did for our package dependencies.

```xml
<PropertyGroup>
    ...
    <!-- Tell the SDK to generate a deps.json file -->
    <GenerateDependencyFile>true</GenerateDependencyFile>
    ...
</PropertyGroup>

...
<!-- This target adds the generated deps.json file to our package output -->
<Target
        Name="AddBuildDependencyFileToBuiltProjectOutputGroupOutput"
        BeforeTargets="BuiltProjectOutputGroup"
        Condition=" '$(GenerateDependencyFile)' == 'true'">

     <ItemGroup>
        <BuiltProjectOutputGroupOutput
            Include="$(ProjectDepsFilePath)"
            TargetPath="$(ProjectDepsFileName)"
            FinalOutputPath="$(ProjectDepsFilePath)" />
    </ItemGroup>
</Target>
```

### Include MSBuild properties and targets in a package

For background on this section, read about [properties and targets](customize-your-build.md) and then how to [include properties and targets in a NuGet package](/nuget/create-packages/creating-a-package#include-msbuild-props-and-targets-in-a-package).

In some cases, you might want to add custom build targets or properties in projects that consume your package, such as running a custom tool or process during build. You do this by placing files in the form `<package_id>.targets` or `<package_id>.props` within the `build` folder in the project.

Files in the project root *build* folder are considered suitable for all target frameworks.

In this section, you'll wire up the task implementation in `.props` and `.targets` files, which will be included in our NuGet package and automatically loaded from a referencing project.

1. In the task's project file, *AppSettingStronglyTyped.csproj*, add the following code:

    ```xml
    <ItemGroup>
        <!-- these lines pack the build props/targets files to the `build` folder in the generated package.
            by convention, the .NET SDK will look for build\<Package Id>.props and build\<Package Id>.targets
            for automatic inclusion in the build. -->
        <Content Include="build\AppSettingStronglyTyped.props" PackagePath="build\" />
        <Content Include="build\AppSettingStronglyTyped.targets" PackagePath="build\" />
    </ItemGroup>
    ```

1. Create a *build* folder and in that folder, add two text files: `AppSettingStronglyTyped.props` and *AppSettingStronglyTyped.targets*. `AppSettingStronglyTyped.props` is imported  early in *Microsoft.Common.props*, and properties defined later are unavailable to it. So, avoid referring to properties that are not yet defined; they would evaluate to empty.

    *Directory.Build.targets* is imported from *Microsoft.Common.targets* after importing `.targets` files from NuGet packages. So, it can override properties and targets defined in most of the build logic, or set properties for all your projects regardless of what the individual projects set. See [import order](customize-your-build.md#choose-between-adding-properties-to-a-props-or-targets-file).

    *AppSettingStronglyTyped.props* includes the task and defines some properties with default values:

    ```xml
    <?xml version="1.0" encoding="utf-8" ?>
    <Project>
    <!--defining properties interesting for my task-->
    <PropertyGroup>
        <!--The folder where the custom task will be present. It points to inside the nuget package. -->
        <_AppSettingsStronglyTyped_TaskFolder>$(MSBuildThisFileDirectory)..\tasks\netstandard2.0</_AppSettingsStronglyTyped_TaskFolder>
        <!--Reference to the assembly which contains the MSBuild Task-->
        <CustomTasksAssembly>$(_AppSettingsStronglyTyped_TaskFolder)\$(MSBuildThisFileName).dll</CustomTasksAssembly>
    </PropertyGroup>

    <!--Register our custom task-->
    <UsingTask TaskName="$(MSBuildThisFileName).AppSettingStronglyTyped" AssemblyFile="$(CustomTasksAssembly)"/>

    <!--Task parameters default values, this can be overridden-->
    <PropertyGroup>
        <RootFolder Condition="'$(RootFolder)' == ''">$(MSBuildProjectDirectory)</RootFolder>
        <SettingClass Condition="'$(SettingClass)' == ''">MySetting</SettingClass>
        <SettingNamespace Condition="'$(SettingNamespace)' == ''">example</SettingNamespace>
        <SettingExtensionFile Condition="'$(SettingExtensionFile)' == ''">mysettings</SettingExtensionFile>
    </PropertyGroup>
    </Project>
    ```

1. The `AppSettingStronglyTyped.props` file is automatically included when the package is installed. Then, the client has the task available and some default values. However, it's never used. In order to put this code in action, define some targets in the `AppSettingStronglyTyped.targets` file, which also will be also automatically included when the package is installed:

    ```xml
    <?xml version="1.0" encoding="utf-8" ?>
    <Project>

    <!--Defining all the text files input parameters-->
    <ItemGroup>
        <SettingFiles Include="$(RootFolder)\*.$(SettingExtensionFile)" />
    </ItemGroup>

    <!--A target that generates code, which is executed before the compilation-->
    <Target Name="BeforeCompile" Inputs="@(SettingFiles)" Outputs="$(RootFolder)\$(SettingClass).generated.cs">
        <!--Calling our custom task-->
        <AppSettingStronglyTyped SettingClassName="$(SettingClass)" SettingNamespaceName="$(SettingNamespace)" SettingFiles="@(SettingFiles)">
            <Output TaskParameter="ClassNameFile" PropertyName="SettingClassFileName" />
        </AppSettingStronglyTyped>
        <!--Our generated file is included to be compiled-->
        <ItemGroup>
            <Compile Remove="$(SettingClassFileName)" />
            <Compile Include="$(SettingClassFileName)" />
        </ItemGroup>
    </Target>

    <!--The generated file is deleted after a general clean. It will force the regeneration on rebuild-->
    <Target Name="AfterClean">
        <Delete Files="$(RootFolder)\$(SettingClass).generated.cs" />
    </Target>
    </Project>
    ```

    The first step is the creation of an [ItemGroup](msbuild-items.md), which represents the text files (it could be more than one) to read and it will be some of our task parameter. There are default values for the location and the extension where we look for, but you can override the values that define the properties in the client MSBuild project file.

    Then define two [MSBuild targets](msbuild-targets.md). We [extend the MSBuild process](how-to-extend-the-visual-studio-build-process.md), overriding predefined targets:

    - `BeforeCompile`: The goal is to call the custom task to generate the class and include the class to be compiled. Tasks in this target are inserted before core compilation is done. Input and Output fields are related to [incremental build](incremental-builds.md). If all output items are up-to-date, MSBuild skips the target. This incremental build of the target can significantly improve the performance of your builds. An item is considered up-to-date if its output file is the same age or newer than its input file or files.

    - `AfterClean`: The goal is to delete the generated class file after a general clean happens. Tasks in this target are inserted after the core clean functionality is invoked. It forces the code generation step to be repeated when the Rebuild target executes.

### Generate the NuGet package

To generate the NuGet package, you can use Visual Studio (right-click on the project node in **Solution Explorer**, and select **Pack**). You can also do it by using the command line. Navigate to the folder where the task project file `AppSettingStronglyTyped.csproj` is present, and execute the following command:

```dotnetcli
// -o is to define the output; the following command chooses the current folder.
dotnet pack -o .
```

Congratulations! You've generated a NuGet package named *\AppSettingStronglyTyped\AppSettingStronglyTyped\AppSettingStronglyTyped.1.0.0.nupkg*.

The package has an extension `.nupkg` and is a compressed zip file. You can open it with a zip tool. The `.target` and `.props` files are in the `build` folder. The `.dll` file is in the `lib\netstandard2.0\` folder. The `AppSettingStronglyTyped.nuspec` file is at the root level.

## (Optional) Support multitargeting

You should consider supporting both `Full` (.NET Framework) and `Core` (including .NET 5 and later) MSBuild distributions to support the broadest possible user base.

For 'normal' .NET SDK projects, multitargeting means setting multiple TargetFrameworks in your project file. When you do this, builds will be triggered for both TargetFrameworkMonikers, and the overall results can be packaged as a single artifact.

That's not the full story for MSBuild. MSBuild has two primary shipping vehicles: Visual Studio and the .NET SDK. These are very different runtime environments; one runs on the .NET Framework runtime, and other runs on the CoreCLR. What this means is that while your code can target netstandard2.0, your task logic may have differences based on what MSBuild runtime type is currently in use. Practically, since there are so many new APIs in .NET 5.0 and up, it makes sense to both multitarget your MSBuild task source code for multiple TargetFrameworkMonikers as well as multitarget your MSBuild target logic for multiple MSBuild runtime types.

### Changes required to multitarget

To target multiple TargetFrameworkMonikers (TFM):

1. Change your project file to use the `net472` and `net6.0` TFMs (the latter may change based on which SDK level you want to target). You might want to target `netcoreapp3.1` until .NET Core 3.1 goes out of support. When you do this, the package folder structure changes from `tasks/` to `tasks/<TFM>/`.

   ```xml
   <TargetFrameworks>net472;net6.0</TargetFrameworks>
   ```

2. Update your `.targets` files to use the correct TFM to load your tasks. The TFM required will change based on what .NET TFM you chose above, but for a project targeting `net472` and `net6.0`, you would have a property like:

```xml
<AppSettingStronglyTyped_TFM Condition=" '$(MSBuildRuntimeType)' != 'Core' ">net472</AppSettingStronglyTyped_TFM>
<AppSettingStronglyTyped_TFM Condition=" '$(MSBuildRuntimeType)' == 'Core' ">net6.0</AppSettingStronglyTyped_TFM>
```

This code uses the `MSBuildRuntimeType` property as a proxy for the active hosting environment. Once this property is set, you can use it in the `UsingTask` to load the correct `AssemblyFile`:

```xml
<UsingTask
    AssemblyFile="$(MSBuildThisFileDirectory)../tasks/$(AppSettingStronglyTyped_TFM)/AppSettingStronglyTyped.dll"
    TaskName="AppSettingStrongTyped.AppSettingStronglyTyped" />
```

## Next steps

Many tasks involve calling an executable. In some scenarios, you can use the Exec task, but if the limitations of the Exec task are an issue, you can also create a custom task. The following tutorial walks through both options with a more realistic code-generation scenario: creating a custom task to generate client code for a REST API.

> [!div class="nextstepaction"]
> [Use code generation in a build](tutorial-rest-api-client-msbuild.md)

Or, learn how to test a custom task.

> [!div class="nextstepaction"]
> [Test a custom MSBuild task](tutorial-test-custom-task.md)
