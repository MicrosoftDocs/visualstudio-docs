---
title: "T4 Assembly Directive | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
ms.assetid: 44949749-ce3c-4fb5-8690-a17f1564ac2f
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# T4 Assembly Directive
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] design-time text template, the `assembly` directive loads an assembly so that your template code can use its types. The effect is similar to adding an assembly reference in a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project.

 For a general overview of writing text templates, see [Writing a T4 Text Template](../modeling/writing-a-t4-text-template.md).

> [!NOTE]
> You do not need the `assembly` directive in a run-time (preprocessed) text template. Instead, add the necessary assemblies to the **References** of your [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project.

## Using the Assembly Directive
 The syntax of the directive is as follows:

```
<#@ assembly name="[assembly strong name|assembly file name]" #>
```

 The assembly name should be one of the following:

- The strong name of an assembly in the GAC, such as `System.Xml.dll`. You can also use the long form, such as `name="System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"`. For more information, see <xref:System.Reflection.AssemblyName>.

- The absolute path of the assembly

  You can use the `$(variableName)` syntax to reference [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] variables such as `$(SolutionDir)`, and `%VariableName%` to reference environment variables. For example:

```
<#@ assembly name="$(SolutionDir)\MyProject\bin\Debug\SomeLibrary.Dll" #>
```

 The assembly directive has no effect in a preprocessed text template. Instead, include the necessary references in the **References** section of your [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project. For more information, see [Run-Time Text Generation with T4 Text Templates](../modeling/run-time-text-generation-with-t4-text-templates.md).

## Standard Assemblies
 The following assemblies are loaded automatically, so that you do not need to write assembly directives for them:

- `Microsoft.VisualStudio.TextTemplating.1*.dll`

- `System.dll`

- `WindowsBase.dll`

  If you use a custom directive, the directive processor might load additional assemblies. For example, if you write templates for a domain-specific language (DSL), you do not need to write assembly directives for the following assemblies:

- `Microsoft.VisualStudio.Modeling.Sdk.1*.dll`

- `Microsoft.VisualStudio.Modeling.Sdk.Diagrams.1*.dsl`

- `Microsoft.VisualStudio.TextTemplating.Modeling.1*.dll`

- The assembly containing your DSL.

## <a name="msbuild"></a> Using project properties in both MSBuild and Visual Studio
 Visual Studio macros like $(SolutionDir) don’t work in MSBuild. If you want to transform templates in your build machine, you have to use project properties instead.

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

 Now you can use your project property in text templates, which transform correctly in both Visual Studio and MSBuild:

```
<#@ assembly name="$(myLibFolder)\MyLib.dll" #>
```

## See Also
 [T4 Include Directive](../modeling/t4-include-directive.md)
