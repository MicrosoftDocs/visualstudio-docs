---
title: Create a custom task that does code generation | Microsoft Docs
description: Learn how to use MSBuild to create a custom task that does code generation and properly handles incremental build and clean operations.
ms.date: 02/07/2022
ms.topic: conceptual
helpviewer_keywords:
- tasks
- MSBuild, tasks
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Create a custom task that does code generation

In this tutorial, you'll create a custom Task in MSBuild in C# that handles code generation and then you'll use the a custom task in a build that can run in Visual Studio, from the command-line, or could be used in a build pipeline. This example demonstrates how to use MSBuild to handle the clean, rebuild and incremental build for generated code. The techniques demonstrated are applicable to a wide range of code generation scenarios. The steps show the use of NuGet to package the task for distribution, and the tutorial includes an optional step to use the BinLog viewer to improve the troubleshooting experience.

## Prerequisites

You should have an understanding of MSBuild concepts such as tasks, targets, and properties. See [MSBuild concepts](msbuild-concepts.md).

The examples requires MSBuild, which is installed with Visual Studio, but can also be installed separately.

The example takes an input text file containing values to be set, and creates a C# code file with code that creates these values. While that is a simple example, the same basic techniques can be applied to more complex code generation scenarios. 

We are going to create a MSBuild custom task named AppSettingStronglyTyped. The task is going to read a set of text files, and each file with lines with the following format:

```
propertyName:type:defaultValue
```

Then our code will generate a C# class with all the constants. This simple example demonstrates the mechanism, but the same techniques can be used for more advanced code generation scenarios. A problem should stop the build and give the user enough information to diagnose the problem.

## Create the AppSettingStronglyTyped project

Create a .NET Standard Class Library. The framework should be .NET Standard 2.0.

> [!CAUTION]
> Be sure to understand the difference between full MSBuild (the one that Visual Studio uses) and portable MSBuild, the one bundled in the .NET Core Command Line.

- Full MSBuild: This version of MSBuild usually lives inside Visual Studio. Runs on .NET Framework. Visual Studio uses this when you execute **Build** on your solution or project. This version is also available from a command-line environment, such as the Visual Studio Developer Command Prompt, or PowerShell.
- Dotnet MSBuild: This version of MSBuild is bundled in the .NET Core Command Line. It runs on .NET Core. Visual Studio does not directly invoke this version of MSBuild. It only supports projects that build using Microsoft.NET.Sdk.

if you want to share code between .NET Framework and any other .NET implementation, such as .NET Core, your library should target [.NET Standard 2.0](/dotnet/standard/net-standard), and we want to run inside Visual Studio which runs on .NET Framework. .NET Framework doesn't support .NET Standard 2.1.

## Create the AppSettingStronglyTyped MSBuild custom task

We need to create our MSBuild custom task. Information about how to [write an MSBuild custom task](task-writing.md) might help you understand the following steps.

We need to include _Microsoft.Build.Utilities.Core_ NuGet package, and then create a AppSettingStronglyTyped derived from Microsoft.Build.Utilities.Task.

We are going use three parameters:

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

The task is going to process the _SettingFiles_ and generate a class `SettingNamespaceName.SettingClassName`. The class will have a set of constants based on the text file's content.  
The task output will be:

```csharp
        //The filename where the class was generated
        [Output]
        public string ClassNameFile { get; set; }
```

We need to override the `Execute` method. The `Execute` method returns true if the task succeeds and false otherwise. `Task` implements `ITask` and provides default implementations of some `ITask` members and additionally, logging is easier. It is important the log to know what is going on. And even more important if we are going to return an error result (false). On error, we should use `Log.LogError`.

```csharp
        public override bool Execute()
        {
            //Read the input files and return a IDictionary<string, object> with the properties to be created.
            //Any format error it will return not succeed and Log.LogError properly
            var (success, settings) = ReadProjectSettingFiles();
            if (!success)
            {
                return success;
            }
            //Create the class based on the Dictionary
            return CreateSettingClass(settings);
        }
```

Then, the details are really not important for our purpose. You can copy from the source code and improve if you like.

We are generating C# code during the build process as example. The task is like any other C# class, you could do whatever you want. For example sending an email, generating change log, reading github repository. This is the power of MSBuild custom tasks.

### Change the AppSettingStronglyTyped.csproj

We need to do some changes on the project file. Now we have something simple like

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

We are going to generate a NuGet package, so first we need to add some basic information

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>netstandard2.0</TargetFramework>
		<version>1.0.0</version>
		<title>AppSettingStronglyTyped</title>
		<authors>John Doe</authors>
		<description>Generates a strongly typed setting class base on a txt file</description>
		<tags>MyTags</tags>
		<copyright>Copyright ©Microsoft Company 2022</copyright>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.Build.Utilities.Core" Version="17.0.0" />
  </ItemGroup>

</Project>
```

Then, the dependencies of your MSBuild task must be packaged inside the package, they cannot be expressed as normal PackageReferences. We don't expose any regular dependencies to the outside world. It is not need for the current example, because we don't have extra dependencies, but it is important to include this step for real-world projects that have dependencies.

```xml
<Project Sdk="Microsoft.NET.Sdk">

	<PropertyGroup>
		<TargetFramework>netstandard2.0</TargetFramework>
		<version>1.0.0</version>
		<title>AppSettingStronglyTyped</title>
		<authors>John Doe</authors>
		<description>Generates a strongly typed setting class base on a txt file</description>
		<tags>MyTags</tags>
		<copyright>Copyright ©Microsoft Company 2022</copyright>
		<!-- we need the assemblies bundled, so set this so we don't expose any dependencies to the outside world -->
		<CopyLocalLockFileAssemblies>true</CopyLocalLockFileAssemblies>
		<TargetsForTfmSpecificBuildOutput>$(TargetsForTfmSpecificBuildOutput);CopyProjectReferencesToPackage</TargetsForTfmSpecificBuildOutput>
		<DebugType>embedded</DebugType>
		<IsPackable>true</IsPackable>
	</PropertyGroup>

	<ItemGroup>
		<PackageReference Include="Microsoft.Build.Utilities.Core" Version="17.0.0" />
	</ItemGroup>

	<Target Name="CopyProjectReferencesToPackage" DependsOnTargets="ResolveReferences">
		<ItemGroup>
			<!-- the dependencies of your MSBuild task must be packaged inside the package, they cannot be expressed as normal PackageReferences -->

			<!--example: <BuildOutputInPackage Include="$(PkgFParsec)/lib/netstandard2.0/FParsecCS.dll" />-->
		</ItemGroup>
	</Target>

</Project>

```

### Include MSBuild props and targets in a package

For background on this section, read about [props and target](customize-your-build.md) and then how to [include props and targets on a nuget](/nuget/create-packages/creating-a-package#include-msbuild-props-and-targets-in-a-package).

In some cases, you might want to add custom build targets or properties in projects that consume your package, such as running a custom tool or process during build. You do this by placing files in the form <package_id>.targets or <package_id>.props within the \build folder of the project.

Files in the root \build folder are considered suitable for all target frameworks.

In this next step we’ll wire up the task implementation in a .props and .targets file, which will be included in our NuGet package and automatically loaded from a referencing project.

First, we should modify the AppSettingStronglyTyped.csproj, adding

```xml
	<ItemGroup>
		<!-- these lines pack the build props/targets files to the `build` folder in the generated package.
         by convention, the .NET SDK will look for build\<Package Id>.props and build\<Package Id>.targets
         for automatic inclusion in the build. -->
		<Content Include="build\AppSettingStronglyTyped.props" PackagePath="build\" />
		<Content Include="build\AppSettingStronglyTyped.targets" PackagePath="build\" />
	</ItemGroup>
```

Then we must create a _build_ folder and inside two text files: _AppSettingStronglyTyped.props_ and _AppSettingStronglyTyped.targets_.
AppSettingStronglyTyped.props is imported very early in Microsoft.Common.props, and properties defined later are unavailable to it. So, avoid referring to properties that are not yet defined (and will evaluate to empty).

Directory.Build.targets is imported from Microsoft.Common.targets after importing .targets files from NuGet packages. So, it can override properties and targets defined in most of the build logic, or set properties for all your projects regardless of what the individual projects set. You can see [import order](customize-your-build.md#import-order).

_AppSettingStronglyTyped.props_ includes the task and define some prop with default values:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
	<!--defining properties interesting for my task-->
	<PropertyGroup>
		<!--default directory where the .dll was publich inside a nuget package-->
		<taskForldername>lib</taskForldername>
		<taskFramework>netstandard2.0</taskFramework>
		<!--The folder where the custom task will be present. It points to inside the nuget package. -->
		<CustomTasksFolder>$(MSBuildThisFileDirectory)..\$(taskForldername)\$(taskFramework)</CustomTasksFolder>
		<!--Reference to the assembly which contains the MSBuild Task-->
		<CustomTasksAssembly>$(CustomTasksFolder)\$(MSBuildThisFileName).dll</CustomTasksAssembly>
	</PropertyGroup>

	<!--Register our custom task-->
	<UsingTask TaskName="$(MSBuildThisFileName).$(MSBuildThisFileName)" AssemblyFile="$(CustomTasksAssembly)"/>

	<!--Task parameters default values, this can be overridden-->
	<PropertyGroup>
		<RootFolder Condition="'$(RootFolder)' == ''">$(MSBuildProjectDirectory)</RootFolder>
		<SettingClass Condition="'$(SettingClass)' == ''">MySetting</SettingClass>
		<SettingNamespace Condition="'$(SettingNamespace)' == ''">example</SettingNamespace>
		<SettingExtensionFile Condition="'$(SettingExtensionFile)' == ''">mysettings</SettingExtensionFile>
	</PropertyGroup>
</Project>
```

Beyond the [build properties](walkthrough-using-msbuild.md#build-properties) defined, actually, an important part of this file is the task registration, MSBuild must know how to locate and run the assembly that contains the task class. Tasks are registered using the [UsingTask element (MSBuild)](usingtask-element-msbuild.md). `TaskName` is the name of the task to reference from the assembly. This attribute should always specify full namespaces. `AssemblyFile` is the file path of the assembly.

The _AppSettingStronglyTyped.props_ will be automatically included when the package is installed. Then, our client has the task available and some default values. However, it is never used. In order to put this code in action we need to define some targets on _AppSettingStronglyTyped.targets_ file which also will be also automatically included when the package is installed:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

	<!--Defining all the text files input parameters-->
	<ItemGroup>
		<SettingFiles Include="$(RootFolder)\*.$(SettingExtensionFile)" />
	</ItemGroup>

	<!--It is generated a target which is executed before the compilation-->
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

The first step is the creation of an [InputGroup](msbuild-items.md) which represents the text files (it could be more than one) to read and it will be some of our task parameter. There are default for the location and the extension where we look for, but you can override the values defining the properties on the client msbuild project file.

Then we define two [MSBuild targets](msbuild-targets.md). We [extend the MSBuild process](how-to-extend-the-visual-studio-build-process.md) overriding predefined targets:

1. `BeforeCompile`: The goal is to call our custom task to generate the class and include the class to be compiled. Tasks that are inserted before core compilation is done. Input and Output field are related to [incremental build](incremental-builds.md). If all output items are up-to-date, MSBuild skips the target. This incremental build of the target can significantly improve the build speed. An item is considered up-to-date if its output file is the same age or newer than its input file or files.

1. `AfterClean`: The goal is to delete the generated class file after a general clean happens.Tasks that are inserted after the core clean functionality is invoked. It force the generation on MSBuild rebuild target execution.

### Generate the NuGet package

We can use Visual Studio (Right click on the project and select 'pack').
We can also do it by command line. Move to the folder where the AppSettingStronglyTyped.csproj is present, and execute:

```dotnetcli
//-o is to define the output, we are choose the current folder
dotnet pack -o .
```

Congratulations! You have generated a NuGet package named *\AppSettingStronglyTyped\AppSettingStronglyTyped\AppSettingStronglyTyped.1.0.0.nupkg*.

The package has an extension `.nupkg` and is a compressed zip file. You can open it with a zip tool. The `.target` and `.props` files are in the `build` folder. The `.dll` file is in the `lib\netstandard2.0\` folder. The `AppSettingStronglyTyped.nuspec` file is at the root level.

### Generate a console app and use the custom task

Now, we are going to create a standard .NET Core console app for testing the nuget package generated.

> [!CAUTION]
> We need to avoid generating a MSBuild custom task in the same MSBuild process which is going to consume it. The new project should be in a complete different Visual Studio Solution or the new project use a dll pre-generated and re-located from the standard output.

We could called MSBuildConsoleExample the new project on a new Visual Studio Solution.

We must import the AppSettingStronglyTyped NuGet package. We need to define a new package source and define a local folder as package source, [please follow the instructions](https://docs.microsoft.com/nuget/consume-packages/install-use-packages-visual-studio#package-sources). Then copy our nuget on that folder and install on our console app.

Then, we should rebuild to be sure every thing is working as expected.

At this point, we are going to create our text file with the extension defined to be discovered. Using the default extension we are going to create `MyValues.mysettings` on the root, and add the following content:

```
Greeting:string:Hello World!
```

Now, we are going to rebuild again and the magic should happens, the generated file must be there. If you are using the standards you must see _MySetting.generated.cs_ file on your solution.

The class _MySetting_ is in the _example_ namespace, we are going to redefine to use our app namespace. Open the project file and add

```
	<PropertyGroup>
		<SettingNamespace>MSBuildConsoleExample</SettingNamespace>
	</PropertyGroup>
```

Now, we are going to rebuild again and the class is on _MSBuildConsoleExample_ namespace. In this way you can redefine the generated class name (SettingClass), the text extension files(SettingExtensionFile) to be use as input and the location (RootFolder) of them if you like.

Go to Program.cs and change the hardcoded 'Hello Word!!' to our constant

```csharp
        static void Main(string[] args)
        {
            Console.WriteLine(MySetting.Greeting);
        }
```

We can execute the program, it will greet from our generated class.

### (Optional) Check what is going on during build process

It is possible to compile using a command line command. We need to go to MSBuildConsoleExample\MSBuildConsoleExample folder.
We are going to use -bl (binary log) option to generate a binary log. The binary log will have a very useful information to know what is going on during build process.

```dotnetcli
# Using Dotnet MSBuild (run core environment)
dotnet build -bl

# or Full MSBuild (run on net framework environment, this is used by Visual Studio)
msbuild -bl
```

Both of them will generate a log msbuild.binlog, and it can be open with [this tool](https://msbuildlog.com/)
The option `/t:rebuild` means run the rebuild target. It will force the regeneration.

### Development

During development and debugging it could be hard ship your custom task as nuget package.

It could be easier to include all the information on `.props` and `.targets` directly on your MSBuildConsoleExample.csproj and then move to the NuGet format when you distribute the task to others.

For example (Note that the NuGet package is not referenced):

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
> Note that we are using another way to order the targets [(BeforeTarget and AfterTarget)](target-build-order.md#beforetargets-and-aftertargets). The note on [override predefined targets](how-to-extend-the-visual-studio-build-process.md#override-predefined-targets) section on the msbuild extension article on the says: 'SDK-style projects have an implicit import of targets after the last line of the project file. This means that you cannot override default targets unless you specify your imports manually'.
