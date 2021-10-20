---
title: MSBuild Properties | Microsoft Docs
description: Learn how MSBuild name-value property pairs can pass values to tasks, evaluate conditions, and store values.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- MSBuild, properties
ms.assetid: 962912ac-8931-49bf-a88c-0200b6e37362
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
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

 Throughout the project file, properties are referenced by using the syntax $(\<PropertyName>). For example, the property in the previous example is referenced by using $(BuildDir).

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

## Global properties

 MSBuild lets you set properties on the command line by using the **-property** (or **-p**) switch. These global property values override property values that are set in the project file. This includes environment properties, but does not include reserved properties, which cannot be changed.

 The following example sets the global `Configuration` property to `DEBUG`.

```cmd
msbuild.exe MyProj.proj -p:Configuration=DEBUG
```

 Global properties can also be set or modified for child projects in a multi-project build by using the `Properties` attribute of the MSBuild task. Global properties are also forwarded to child projects unless the `RemoveProperties` attribute of the MSBuild task is used to specify the list of properties not to forward. For more information, see [MSBuild task](../msbuild/msbuild-task.md).

 If you specify a property by using the `TreatAsLocalProperty` attribute in a project tag, that global property value doesn't override the property value that's set in the project file. For more information, see [Project element (MSBuild)](../msbuild/project-element-msbuild.md) and [How to: Build the same source files with different options](../msbuild/how-to-build-the-same-source-files-with-different-options.md).

## Property functions

 Starting in .NET Framework version 4, you can use property functions to evaluate your MSBuild scripts. You can read the system time, compare strings, match regular expressions, and perform many other actions within your build script without using MSBuild tasks.

 You can use string (instance) methods to operate on any property value, and you can call the static methods of many system classes. For example, you can set a build property to today's date as follows.

```xml
<Today>$([System.DateTime]::Now.ToString("yyyy.MM.dd"))</Today>
```

 For more information, and a list of property functions, see [Property functions](../msbuild/property-functions.md).

## Create properties during execution

 Properties positioned outside `Target` elements are assigned values during the evaluation phase of a build. During the subsequent execution phase, properties can be created or modified as follows:

- A property can be emitted by any task. To emit a property, the [Task](../msbuild/task-element-msbuild.md) element must have a child [Output](../msbuild/output-element-msbuild.md) element that has a `PropertyName` attribute.

- A property can be emitted by the [CreateProperty](../msbuild/createproperty-task.md) task. This usage is deprecated.

- Starting in the .NET Framework 3.5, `Target` elements may contain `PropertyGroup` elements that may contain property declarations.

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

## See also

- [MSBuild concepts](../msbuild/msbuild-concepts.md)
- [MSBuild](../msbuild/msbuild.md)
- [How to: Use environment variables in a build](../msbuild/how-to-use-environment-variables-in-a-build.md)
- [How to: Reference the name or location of the project file](../msbuild/how-to-reference-the-name-or-location-of-the-project-file.md)
- [How to: Build the same source files with different options](../msbuild/how-to-build-the-same-source-files-with-different-options.md)
- [MSBuild reserved and well-known properties](../msbuild/msbuild-reserved-and-well-known-properties.md)
- [Property element (MSBuild)](../msbuild/property-element-msbuild.md)
