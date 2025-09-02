---
title: Explore MSBuild name-value properties
description: Explore MSBuild name-value properties for the registry, environment, internal settings, and more, and pass values to tasks, evaluate conditions, and store values.
ms.date: 08/15/2023
ms.topic: language-reference
helpviewer_keywords:
- MSBuild, properties
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# MSBuild properties

Properties are name-value pairs that can be used to configure builds. Properties are useful for passing values to tasks, evaluating conditions, and storing values that will be referenced throughout the project file.

## Define and reference properties in a project file

 Properties are declared by creating an element that has the name of the property as a child of a [PropertyGroup](../msbuild/propertygroup-element-msbuild.md) element. For example, the following XML creates a property named `BuildDir` that has a value of `Build`.

```xml
<PropertyGroup>
    <BuildDir>Build</BuildDir>
</PropertyGroup>
```

Valid property names begin with an uppercase or lowercase letter or underscore (`_`); valid subsequent characters include alphanumeric characters (ASCII letters or digits), underscore, and hyphen (`-`).

 Throughout the project file, properties are referenced by using the syntax `$(<PropertyName>)`. For example, the property in the previous example is referenced by using `$(BuildDir)`.

 Property values can be changed by redefining the property. The `BuildDir` property can be given a new value by using this XML:

```xml
<PropertyGroup>
    <BuildDir>Alternate</BuildDir>
</PropertyGroup>
```

 Properties are evaluated in the order in which they appear in the project file. The new value for `BuildDir` must be declared after the old value is assigned.

## Reserved properties

 MSBuild reserves some property names to store information about the project file and the MSBuild binaries. These properties are referenced by using the $ notation, just like any other property. For example, $(MSBuildProjectFile) returns the complete file name of the project file, including the file name extension.

 For more information, see [How to: Reference the name or location of the project file](../msbuild/how-to-reference-the-name-or-location-of-the-project-file.md) and [MSBuild reserved and well-known properties](../msbuild/msbuild-reserved-and-well-known-properties.md).

## MSBuild internal properties

Properties defined in standard import files that begin with an underscore (_) are private to MSBuild and should not be read, reset, or overridden in user code.

## Environment properties

 You can reference environment variables in project files just as you reference reserved properties. For example, to use the `PATH` environment variable in your project file, use $(Path). If the project contains a property definition that has the same name as an environment property, the property in the project overrides the value of the environment variable.

 Each MSBuild project has an isolated environment block: it only sees reads and writes to its own block.  MSBuild only reads environment variables when it initializes the property collection, before the project file is evaluated or built. After that, environment properties are static, that is, each spawned tool starts with the same names and values.

 To get the current value of environment variables from within a spawned tool, use the [Property functions](../msbuild/property-functions.md) System.Environment.GetEnvironmentVariable. The preferred method, however, is to use the task parameter <xref:Microsoft.Build.Utilities.ToolTask.EnvironmentVariables%2A>. Environment properties set in this string array can be passed to the spawned tool without affecting the system environment variables.

> [!TIP]
> Not all environment variables are read in to become initial properties. Any environment variable whose name is not a valid MSBuild property name, such as "386", is ignored.

 For more information, see [How to: Use environment variables in a build](../msbuild/how-to-use-environment-variables-in-a-build.md).

## Registry properties

 You can read system registry values by using the following syntax, where `Hive` is the registry hive (for example, **HKEY_LOCAL_MACHINE**), `MyKey` is the key name, `MySubKey` is the subkey name, and `Value` is the value of the subkey.

```xml
$(registry:Hive\MyKey\MySubKey@Value)
```

 To get the default subkey value, omit the `Value`.

```xml
$(registry:Hive\MyKey\MySubKey)
```

 This registry value can be used to initialize a build property. For example, to create a build property that represents the Visual Studio web browser home page, use this code:

```xml
<PropertyGroup>
  <VisualStudioWebBrowserHomePage>
    $(registry:HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\14.0\WebBrowser@HomePage)
  </VisualStudioWebBrowserHomePage>
<PropertyGroup>
```

> [!WARNING]
> In the .NET SDK version of MSBuild (`dotnet build`), registry properties are not supported.

## Create properties during execution

Properties positioned outside `Target` elements are assigned values during the evaluation phase of a build. During the subsequent execution phase, properties can be created or modified as follows:

- A property can be emitted by any task. To emit a property, the [Task](../msbuild/task-element-msbuild.md) element must have a child [Output](../msbuild/output-element-msbuild.md) element that has a `PropertyName` attribute.

- A property can be emitted by the [CreateProperty](../msbuild/createproperty-task.md) task. This usage is deprecated.

- `Target` elements may contain `PropertyGroup` elements that may contain property declarations.

## Global properties

MSBuild lets you set properties on the command line by using the **-property** (or **-p**) switch. These global property values override property values that are set in the project file. This includes environment properties, but does not include reserved properties, which cannot be changed.

The following example sets the global `Configuration` property to `DEBUG`.

```cmd
msbuild.exe MyProj.proj -p:Configuration=DEBUG
```

Global properties can also be set or modified for child projects in a multi-project build by using the `Properties` attribute of the MSBuild task. Global properties are also forwarded to child projects unless the `RemoveProperties` attribute of the MSBuild task is used to specify the list of properties not to forward. For more information, see [MSBuild task](../msbuild/msbuild-task.md).

## Local properties

Local properties can be reset in a project. Global properties cannot. When a local property is set from the command line with the `-p` option, the setting in the project file takes precedence over the command line.

You specify a local property by using the `TreatAsLocalProperty` attribute in a project tag. 

The following code specifies that two properties are local:

```xml
<Project Sdk="Microsoft.Net.Sdk" TreatAsLocalProperty="Prop1;Prop2">
```

Local properties are not forwarded to child projects in a multi-project build. If you provide a value on the command-line with the `-p` option, child projects are given the value of the global property instead of the local value changed in the parent project, but the child project (or any of its imports) can also change it with their own `TreatAsLocalProperty`.

### Example with local properties

The following code example demonstrates the effect of `TreatAsLocalProperty`:

```xml
<!-- test1.proj -->
<Project TreatAsLocalProperty="TreatedAsLocalProp">
    <PropertyGroup>
        <TreatedAsLocalProp>LocalOverrideValue</TreatedAsLocalProp>
    </PropertyGroup>

    <Target Name="Go">
        <MSBuild Projects="$(MSBuildThisFileDirectory)\test2.proj" Targets="Go2" Properties="Inner=true" />
    </Target>

    <Target Name="Go2" BeforeTargets="Go">
        <Warning Text="TreatedAsLocalProp($(MSBuildThisFileName)): $(TreatedAsLocalProp)" />
    </Target>
</Project>
```

```xml
<!-- test2.proj -->
<Project TreatAsLocalProperty="TreatedAsLocalProp">
    <Target Name="Go2">
        <Warning Text="TreatedAsLocalProp($(MSBuildThisFileName)): $(TreatedAsLocalProp)" />
    </Target>
</Project>
```

Suppose you build *test1.proj* command line, and give `TreatedAsLocalProperty` the global value `GlobalOverrideValue`:

```cmd
dotnet msbuild .\test1.proj -p:TreatedAsLocalProp=GlobalOverrideValue
```

The output is as follows:

```output
test1.proj(11,9): warning : TreatedAsLocalProp(test): LocalOverrideValue
test2.proj(3,9): warning : TreatedAsLocalProp(test2): GlobalOverrideValue
```

The child project inherits the global value, but the parent project uses the locally set property.

### Local properties and imports

When `TreatAsLocalProperty` attribute is used on imported project, order is important when considering which value the property gets.

The following code example shows the effect of `TreatAsLocalProperty` on an imported project:

```xml
<!-- importer.proj -->
<Project>
    <PropertyGroup>
        <TreatedAsLocalProp>FirstOverrideValue</TreatedAsLocalProp>
    </PropertyGroup>

    <Import Project="import.props" />

    <PropertyGroup>
        <TreatedAsLocalProp Condition=" '$(TrySecondOverride)' == 'true' ">SecondOverrideValue</TreatedAsLocalProp>
    </PropertyGroup>

    <Target Name="Go">
        <Warning Text="TreatedAsLocalProp($(MSBuildThisFileName)): $(TreatedAsLocalProp)" />
    </Target>
</Project>
```

```xml
<!-- import.proj -->
<Project TreatAsLocalProperty="TreatedAsLocalProp">
    <PropertyGroup>
        <TreatedAsLocalProp>ImportOverrideValue</TreatedAsLocalProp>
    </PropertyGroup>

    <!-- Here, TreatedAsLocalProp has the value "ImportOverrideValue"-->
</Project>
```

Suppose you build `importer.proj` and set a global value for `TreatedAsLocalProp` as follows:

```cmd
dotnet msbuild .\importer.proj -p:TreatedAsLocalProp=GlobalOverrideValue
```

The output is:

```output
importer.proj(9,9): warning : TreatedAsLocalProp(importer.proj): GlobalOverrideValue
```

Now suppose you build with the property `TrySecondOverride` to `true`:

```cmd
dotnet msbuild .\importer.proj -p:TreatedAsLocalProp=GlobalOverrideValue -p:TrySecondOverride=true
```

The output is:

```output
importer.proj(13,9): warning : TreatedAsLocalProp(importer.proj): SecondOverrideValue
```

The example shows that the property is treated as local *after* the imported project where the `TreatAsLocalProperty` attribute was used, not just within the imported file. The value of the property is affected by the global override value, but only *before* the imported project where `TreatAsLocalProperty` is used.

For more information, see [Project element (MSBuild)](../msbuild/project-element-msbuild.md) and [How to: Build the same source files with different options](../msbuild/how-to-build-the-same-source-files-with-different-options.md).

## Property functions

 Starting in .NET Framework version 4, you can use property functions to evaluate your MSBuild scripts. You can read the system time, compare strings, match regular expressions, and perform many other actions within your build script without using MSBuild tasks.

 You can use string (instance) methods to operate on any property value, and you can call the static methods of many system classes. For example, you can set a build property to today's date as follows.

```xml
<Today>$([System.DateTime]::Now.ToString("yyyy.MM.dd"))</Today>
```

 For more information, and a list of property functions, see [Property functions](../msbuild/property-functions.md).

## Store XML in properties

 Properties can contain arbitrary XML, which can help in passing values to tasks or displaying logging information. The following example shows the `ConfigTemplate` property, which has a value that contains XML and other property references. MSBuild replaces the property references by using their respective property values. Property values are assigned in the order in which they appear. Therefore, in this example, `$(MySupportedVersion)`, `$(MyRequiredVersion)`, and `$(MySafeMode)` should have already been defined.

```xml
<PropertyGroup>
    <ConfigTemplate>
        <Configuration>
            <Startup>
                <SupportedRuntime
                    ImageVersion="$(MySupportedVersion)"
                    Version="$(MySupportedVersion)"/>
                <RequiredRuntime
                    ImageVersion="$(MyRequiredVersion)"
                    Version="$(MyRequiredVersion)"
                    SafeMode="$(MySafeMode)"/>
            </Startup>
        </Configuration>
    </ConfigTemplate>
</PropertyGroup>
```

## Related content

- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [MSBuild](../msbuild/msbuild.md)
- [How to: Use environment variables in a build](../msbuild/how-to-use-environment-variables-in-a-build.md)
- [How to: Reference the name or location of the project file](../msbuild/how-to-reference-the-name-or-location-of-the-project-file.md)
- [How to: Build the same source files with different options](../msbuild/how-to-build-the-same-source-files-with-different-options.md)
- [MSBuild reserved and well-known properties](../msbuild/msbuild-reserved-and-well-known-properties.md)
- [Property element (MSBuild)](../msbuild/property-element-msbuild.md)
