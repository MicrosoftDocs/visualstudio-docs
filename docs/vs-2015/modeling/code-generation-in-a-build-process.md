---
title: "Code Generation in a Build Process | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "text templates, build tasks"
  - "text templates, transforming by using msbuild"
ms.assetid: 4da43429-2a11-4d7e-b2e0-9e4af7033b5a
caps.latest.revision: 30
author: jillre
ms.author: jillfra
manager: jillfra
---
# Code Generation in a Build Process
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]
Text transformation can be invoked as part of the build process of a Visual Studio solution. There are build tasks that are specialized for text transformation. The T4 build tasks run design-time text templates, and they also compile run-time (preprocessed) text templates.

There are some differences in what the build tasks can do, depending on which build engine you use. When you build the solution in Visual Studio, a text template can access the Visual Studio API (EnvDTE) if the [hostspecific="true"](../modeling/t4-template-directive.md) attribute is set. But that isn’t true when you build the solution from the command line or when you initiate a server build through Visual Studio. In those cases, the build is performed by MSBuild and a different T4 host is used.

This means that you can’t access things like project file names in the same way when you build a text template in MSBuild. However, you can [pass environment information into text templates and directive processors by using build parameters](#parameters).

## <a name="buildserver"></a> Configure your machines

To enable build tasks on your development computer, install [Modeling SDK for Visual Studio](https://www.microsoft.com/download/details.aspx?id=48148).

If [your build server](https://msdn.microsoft.com/library/788443c3-0547-452e-959c-4805573813a9) runs on a computer on which Visual Studio is not installed, copy the following files to the build computer from your development machine. Substitute the most recent version numbers for ‘*’.

- $(ProgramFiles)\MSBuild\Microsoft\VisualStudio\v*.0\TextTemplating

  - Microsoft.VisualStudio.TextTemplating.Sdk.Host.*.0.dll

  - Microsoft.TextTemplating.Build.Tasks.dll

  - Microsoft.TextTemplating.targets

- $(ProgramFiles)\Microsoft Visual Studio *.0\VSSDK\VisualStudioIntegration\Common\Assemblies\v4.0

  - Microsoft.VisualStudio.TextTemplating.*.0.dll

  - Microsoft.VisualStudio.TextTemplating.Interfaces.*.0.dll (several files)

  - Microsoft.VisualStudio.TextTemplating.VSHost.*.0.dll

- $(ProgramFiles)\Microsoft Visual Studio *.0\Common7\IDE\PublicAssemblies\

  - Microsoft.VisualStudio.TextTemplating.Modeling.*.0.dll

## To edit the project file

You’ll have to edit your project file to configure some of the features in MSBuild.

In solution explorer, choose **Unload** from the context menu of your project. That allows you to edit the .csproj or .vbproj file in the XML editor.

When you’ve finished editing, choose **Reload**.

## Import the Text Transformation Targets

In the .vbproj or .csproj file, find a line like this:

`<Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />`

\- or -

`<Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />`

After that line, insert the Text Templating import:

```xml
<!-- Optionally make the import portable across VS versions -->
  <PropertyGroup>
    <!-- Get the Visual Studio version – defaults to 10: -->
    <VisualStudioVersion Condition="'$(VisualStudioVersion)' == ''">10.0</VisualStudioVersion>
    <!-- Keep the next element all on one line: -->
    <VSToolsPath Condition="'$(VSToolsPath)' == ''">$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v$(VisualStudioVersion)</VSToolsPath>
  </PropertyGroup>

<!-- This is the important line: -->
  <Import Project="$(VSToolsPath)\TextTemplating\Microsoft.TextTemplating.targets" />
```

## Transforming templates in a build

There are some properties that you can insert into your project file to control the transformation task:

- Run the Transform task at the start of every build:

    ```xml
    <PropertyGroup>
        <TransformOnBuild>true</TransformOnBuild>
    </PropertyGroup>
    ```

- Overwrite files that are read-only, for example because they are not checked out:

    ```xml
    <PropertyGroup>
        <OverwriteReadOnlyOutputFiles>true</OverwriteReadOnlyOutputFiles>
    </PropertyGroup>
    ```

- Transform every template every time:

    ```xml
    <PropertyGroup>
        <TransformOutOfDateOnly>false</TransformOutOfDateOnly>
    </PropertyGroup>
    ```

     By default, the T4 MSBuild task regenerates an output file if it is older than its template file, or any files that are included, or any files that have previously been read by the template or by a directive processor that it uses. Notice that this is a much more powerful dependency test than is used by the Transform All Templates command in Visual Studio, which only compares the dates of the template and output file.

To perform just the text transformations in your project, invoke the TransformAll task:

`msbuild myProject.csproj /t:TransformAll`

To transform a specific text template:

`msbuild myProject.csproj /t:Transform /p:TransformFile="Template1.tt"`

You can use wildcards in TransformFile:

`msbuild dsl.csproj /t:Transform /p:TransformFile="GeneratedCode\**\*.tt"`

## Source Control

There is no specific built-in integration with a source control system. However, you can add your own extensions, for example to check out and check in a generated file.By default, the text transform task avoids overwriting a file that is marked as read- only, and when such a file is encountered, an error is logged in the Visual Studio error list, and the task fails.

To specify that read-only files should be overwritten, insert this property:

`<OverwriteReadOnlyOutputFiles>true</OverwriteReadOnlyOutputFiles>`

Unless you customize the postprocessing step, a warning will be logged in the error list when a file is overwritten.

## Customizing the build process

Text transformation happens before other tasks in the build process. You can define tasks that are invoked before and after transformation, by setting the properties `$(BeforeTransform)` and `$(AfterTransform)`:

```xml
<PropertyGroup>
    <BeforeTransform>CustomPreTransform</BeforeTransform>
    <AfterTransform>CustomPostTransform</AfterTransform>
  </PropertyGroup>
  <Target Name="CustomPreTransform">
    <Message Text="In CustomPreTransform..." Importance="High" />
  </Target>
  <Target Name="CustomPostTransform">
    <Message Text="In CustomPostTransform..." Importance="High" />
  </Target>
```

In `AfterTransform`, you can reference lists of files:

- GeneratedFiles - a list of files written by the process. For those files that overwrote existing read-only files, %(GeneratedFiles.ReadOnlyFileOverwritten) will be true. These files can be checked out of source control.

- NonGeneratedFiles - a list of read-only files that were not overwritten.

  For example, you define a task to check out GeneratedFiles.

## OutputFilePath and OutputFileName

These properties are used only by MSBuild. They do not affect code generation in Visual Studio. They redirect the generated output file to a different folder or file. The target folder must already exist.

```xml
<ItemGroup>
  <None Include="MyTemplate.tt">
    <Generator>TextTemplatingFileGenerator</Generator>
    <OutputFilePath>MyFolder</OutputFilePath>
    <LastGenOutput>MyTemplate.cs</LastGenOutput>
  </None>
</ItemGroup>
```

A useful folder to redirect to is `$(IntermediateOutputPath).`

If you specify and output filename, it will take precedence over the extension specified in the output directive in the templates.

```xml
<ItemGroup>
  <None Include="MyTemplate.tt">
    <Generator>TextTemplatingFileGenerator</Generator>
    <OutputFileName>MyOutputFileName.cs</OutputFileName>
    <LastGenOutput>MyTemplate.cs</LastGenOutput>
  </None>
</ItemGroup>
```

Specifying an OutputFileName or OutputFilePath isn’t recommended if you are also transforming templates inside VS using Transform All, or running the single file generator. You will end up with different file paths depending on how you triggered the transformation. This can be very confusing.

## Adding reference and include paths

The host has a default set of paths where it searches for assemblies referenced in templates. To add to this set:

```
<ItemGroup>
    <T4ReferencePath Include="$(VsIdePath)PublicAssemblies\" />
    <!-- Add more T4ReferencePath items here -->
</ItemGroup>
```

To set the folders that will be searched for include files, provide a semicolon-separated list. Usually you add to the existing folder list.

```
<PropertyGroup>
    <IncludeFolders>
$(IncludeFolders);$(MSBuildProjectDirectory)\Include;AnotherFolder;And\Another</IncludeFolders>
</PropertyGroup>
```

## <a name="parameters"></a> Pass build context data into the templates

You can set parameter values in the project file. For example, you can pass build properties and [environment variables](../msbuild/how-to-use-environment-variables-in-a-build.md):

```xml
<ItemGroup>
  <T4ParameterValues Include="ProjectFolder">
    <Value>$(ProjectDir)</Value>
    <Visible>false</Visible>
  </T4ParameterValues>
</ItemGroup>
```

In a text template, set `hostspecific` in the template directive. Use the [parameter](../modeling/t4-parameter-directive.md) directive to get values:

```
<#@template language="c#" hostspecific="true"#>
<#@ parameter type="System.String" name="ProjectFolder" #>
The project folder is: <#= ProjectFolder #>
```

## <a name="msbuild"></a> Using project properties in assembly and include directives

Visual Studio macros like $(SolutionDir) don’t work in MSBuild. You can use project properties instead.

Edit your .csproj or .vbproj file to define a project property. This example defines a property named `myLibFolder`:

```xml
<!-- Define a project property, myLibFolder: -->
<PropertyGroup>
    <myLibFolder>$(MSBuildProjectDirectory)\..\libs</myLibFolder>
</PropertyGroup>

<!-- Tell the MSBuild T4 task to make the property available: -->
<ItemGroup>
    <T4ParameterValues Include="myLibFolder">
      <Value>$(myLibFolder)</Value>
    </T4ParameterValues>
  </ItemGroup>
```

Now you can use your project property in assembly and include directives:

```
<#@ assembly name="$(myLibFolder)\MyLib.dll" #>
<#@ include file="$(myLibFolder)\MyIncludeFile.t4" #>
```

 These directives get values from T4parameterValues both in MSBuild and in Visual Studio hosts.

## Q & A

**Why would I want to transform templates in the build server? I already transformed templates in Visual Studio before I checked in my code.**

If you update an included file, or another file read by the template, Visual Studio doesn’t transform the file automatically. Transforming templates as part of the build makes sure that everything’s up to date.

**What other options are there for transforming text templates?**

- The [TextTransform utility](../modeling/generating-files-with-the-texttransform-utility.md) can be used in command scripts. In most cases, it’s easier to use MSBuild.

- [Invoking Text Transformation in a VS Extension](../modeling/invoking-text-transformation-in-a-vs-extension.md)

- [Design-time text templates](../modeling/design-time-code-generation-by-using-t4-text-templates.md) are transformed by Visual Studio.

- [Run time text templates](../modeling/run-time-text-generation-with-t4-text-templates.md) are transformed at run time in your application.

## Read more

There is good guidance in the T4 MSbuild template, $(VSToolsPath)\TextTemplating\Microsoft.TextTemplating.targets

- [Writing a T4 Text Template](../modeling/writing-a-t4-text-template.md)
- [Visual Studio Visualization and Modeling SDK](https://go.microsoft.com/fwlink/?LinkID=185579)
- [Oleg Sych: Understanding T4:MSBuild Integration](https://github.com/olegsych/T4Toolbox)
