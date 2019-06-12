---
title: "MSBuild Properties1 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
helpviewer_keywords: 
  - "MSBuild, properties"
ms.assetid: 962912ac-8931-49bf-a88c-0200b6e37362
caps.latest.revision: 35
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# MSBuild Properties1
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Properties are name-value pairs that can be used to configure builds. Properties are useful for passing values to tasks, evaluating conditions, and storing values that will be referenced throughout the project file.  
  
## Defining and Referencing Properties in a Project File  
 Properties are declared by creating an element that has the name of the property as a child of a [PropertyGroup](../msbuild/propertygroup-element-msbuild.md) element. For example, the following XML creates a property named `BuildDir` that has a value of `Build`.  
  
```  
<PropertyGroup>  
    <BuildDir>Build</BuildDir>  
</PropertyGroup>  
```  
  
 Throughout the project file, properties are referenced by using the syntax $(`PropertyName`). For example, the property in the previous example is referenced by using $(BuildDir).  
  
 Property values can be changed by redefining the property. The `BuildDir` property can be given a new value by using this XML:  
  
```  
<PropertyGroup>  
    <BuildDir>Alternate</BuildDir>  
</PropertyGroup>  
```  
  
 Properties are evaluated in the order in which they appear in the project file. The new value for `BuildDir` must be declared after the old value is assigned.  
  
## Reserved Properties  
 MSBuild reserves some property names to store information about the project file and the MSBuild binaries. These properties are referenced by using the $ notation, just like any other property. For example, $(MSBuildProjectFile) returns the complete file name of the project file, including the file name extension.  
  
 For more information, see [How to: Reference the Name or Location of the Project File](../msbuild/how-to-reference-the-name-or-location-of-the-project-file.md) and [MSBuild Reserved and Well-Known Properties](../msbuild/msbuild-reserved-and-well-known-properties.md).  
  
## Environment Properties  
 You can reference environment variables in project files just as you reference reserved properties. For example, to use the `PATH` environment variable in your project file, use $(Path). If the project contains a property definition that has the same name as an environment property, the property in the project overrides the value of the environment variable.  
  
 Each MSBuild project has an isolated environment block: it only sees reads and writes to its own block.  MSBuild only reads environment variables when it initializes the property collection, before the project file is evaluated or built. After that, environment properties are static, that is, each spawned tool starts with the same names and values.  
  
 To get the current value of environment variables from within a spawned tool, use the [Property Functions](../msbuild/property-functions.md) System.Environment.GetEnvironmentVariable. The preferred method, however, is to use the task parameter <xref:Microsoft.Build.Utilities.ToolTask.EnvironmentVariables%2A>. Environment properties set in this string array can be passed to the spawned tool without affecting the system environment variables.  
  
> [!TIP]
> Not all environment variables are read in to become initial properties. Any environment variable whose name is not a valid MSBuild property names, such as "386", is ignored.  
  
 For more information, see [How to: Use Environment Variables in a Build](../msbuild/how-to-use-environment-variables-in-a-build.md).  
  
## Registry Properties  
 You can read system registry values by using the following syntax, where `Hive` is the registry hive (for example, HKEY_LOCAL_MACHINE ), `Key` is the key name, `SubKey` is the subkey name, and `Value` is the value of the subkey.  
  
```  
$(registry:Hive\MyKey\MySubKey@Value)  
```  
  
 To get the default subkey value, omit the `Value`.  
  
```  
$(registry:Hive\MyKey\MySubKey)  
```  
  
 This registry value can be used to initialize a build property. For example, to create a build property that represents the Visual Studio web browser home page, use this code:  
  
```  
<PropertyGroup>  
  <VisualStudioWebBrowserHomePage>  
    $(registry:HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\12.0\WebBrowser@HomePage)  
  </VisualStudioWebBrowserHomePage>  
<PropertyGroup>  
```  
  
## Global Properties  
 MSBuild lets you set properties on the command line by using the **/property** (or **/p**) switch. These global property values override property values that are set in the project file. This includes environment properties, but does not include reserved properties, which cannot be changed.  
  
 The following example sets the global `Configuration` property to `DEBUG`.  
  
```  
msbuild.exe MyProj.proj /p:Configuration=DEBUG  
```  
  
 Global properties can also be set or modified for child projects in a multi-project build by using the `Properties` attribute of the MSBuild task. For more information, see [MSBuild Task](../msbuild/msbuild-task.md).  
  
 If you specify a property by using the `TreatAsLocalProperty` attribute in a project tag, that global property value doesn't override the property value that's set in the project file. For more information, see [Project Element (MSBuild)](../msbuild/project-element-msbuild.md) and [How to: Build the Same Source Files with Different Options](../msbuild/how-to-build-the-same-source-files-with-different-options.md).  
  
## Property Functions  
 Starting in .NET Framework version 4, you can use property functions to evaluate your MSBuild scripts. You can read the system time, compare strings, match regular expressions, and perform many other actions within your build script without using MSBuild tasks.  
  
 You can use string (instance) methods to operate on any property value, and you can call the static methods of many system classes. For example, you can set a build property to today's date as follows.  
  
```  
<Today>$([System.DateTime]::Now.ToString("yyyy.MM.dd"))</Today>  
```  
  
 For more information, and a list of property functions, see [Property Functions](../msbuild/property-functions.md).  
  
## Creating Properties During Execution  
 Properties positioned outside `Target` elements are assigned values during the evaluation phase of a build. During the subsequent execution phase, properties can be created or modified as follows:  
  
- A property can be emitted by any task. To emit a property, the [Task](../msbuild/task-element-msbuild.md) element must have a child [Output](../msbuild/output-element-msbuild.md) element that has a `PropertyName` attribute.  
  
- A property can be emitted by the [CreateProperty](../msbuild/createproperty-task.md) task. This usage is deprecated.  
  
- Starting in the .NET Framework 3.5, `Target` elements may contain `PropertyGroup` elements that may contain property declarations.  
  
## Storing XML in Properties  
 Properties can contain arbitrary XML, which can help in passing values to tasks or displaying logging information. The following example shows the `ConfigTemplate` property, which has a value that contains XML and other property references. [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] replaces the property references by using their respective property values. Property values are assigned in the order in which they appear. Therefore, in this example, `$(MySupportedVersion)`, `$(MyRequiredVersion)`, and `$(MySafeMode)` should have already been defined.  
  
```  
  
<PropertyGroup>  
    <ConfigTemplate>  
        <Configuration>  
            <Startup>  
                <SupportedRuntime  
                    ImageVersion="$(MySupportedVersion)"  
                    Version="$(MySupportedVersion)"/>  
                <RequiredRuntime  
                    ImageVersion="$(MyRequiredVersion)  
                    Version="$(MyRequiredVersion)"  
                    SafeMode="$(MySafeMode)"/>  
            </Startup>  
        </Configuration>  
    </ConfigTemplate>  
</PropertyGroup>  
```  
  
## See Also  
 [MSBuild Concepts](../msbuild/msbuild-concepts.md)  
 [MSBuild](msbuild.md)  
 [How to: Use Environment Variables in a Build](../msbuild/how-to-use-environment-variables-in-a-build.md)   
 [How to: Reference the Name or Location of the Project File](../msbuild/how-to-reference-the-name-or-location-of-the-project-file.md)   
 [How to: Build the Same Source Files with Different Options](../msbuild/how-to-build-the-same-source-files-with-different-options.md)   
 [MSBuild Reserved and Well-Known Properties](../msbuild/msbuild-reserved-and-well-known-properties.md)   
 [Property Element (MSBuild)](../msbuild/property-element-msbuild.md)
