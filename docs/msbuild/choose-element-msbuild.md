---
title: "Choose Element (MSBuild) | Microsoft Docs"
ms.date: "03/13/2017"
ms.topic: "reference"
f1_keywords:
  - "http://schemas.microsoft.com/developer/msbuild/2003#Choose"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
  - "xml"
helpviewer_keywords:
  - "<Choose> Element [MSBuild]"
  - "Choose Element [MSBuild]"
ms.assetid: 7b8b025a-d944-4f5c-9018-c89fc2ef146d
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Choose element (MSBuild)
Evaluates child elements to select one set of `ItemGroup` elements and/or `PropertyGroup` elements to evaluate.

 \<Project>
 \<Choose>
 \<When>
 \<Choose>
 ...
 \<Otherwise>
 \<Choose>
 ...

## Syntax

```xml
<Choose>
    <When Condition="'StringA'=='StringB'">... </When>
    <Otherwise>... </Otherwise>
</Choose>
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes
 None.

### Child elements

|Element|Description|
|-------------|-----------------|
|[Otherwise](../msbuild/otherwise-element-msbuild.md)|Optional element.<br /><br /> Specifies the block of code `PropertyGroup` and `ItemGroup` elements to evaluate if the conditions of all `When` elements evaluate to `false`. There may be zero or one `Otherwise` elements in a `Choose` element, and it must be the last element.|
|[When](../msbuild/when-element-msbuild.md)|Required element.<br /><br /> Specifies a possible block of code for the `Choose` element to select. There may be one or more `When` elements in a `Choose` element.|

### Parent elements

| Element | Description |
| - | - |
| [Otherwise](../msbuild/otherwise-element-msbuild.md) | Specifies the block of code to execute if the conditions of all `When` elements evaluate to `false`. |
| [Project](../msbuild/project-element-msbuild.md) | Required root element of an [!INCLUDE[vstecmsbuild](../extensibility/internals/includes/vstecmsbuild_md.md)] project file. |
| [When](../msbuild/when-element-msbuild.md) | Specifies a possible block of code for the `Choose` element to select. |

## Remarks
 The `Choose`, `When`, and `Otherwise` elements are used together to provide a way to select one section of code to execute out of a number of possible alternatives. For more information, see [Conditional constructs](../msbuild/msbuild-conditional-constructs.md).

## Example
 The following project uses the `Choose` element to select which set of property values in the `When` elements to set. If the `Condition` attributes of both `When` elements evaluate to `false`, the property values in the `Otherwise` element are set.

```xml
<Project
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003" >
    <PropertyGroup>
        <Configuration Condition="$(Configuration) == ''">Debug</Configuration>
        <OutputType>Exe</OutputType>
        <RootNamespace>ConsoleApplication1</RootNamespace>
        <AssemblyName>ConsoleApplication1</AssemblyName>
        <WarningLevel>4</WarningLevel>
    </PropertyGroup>
    <Choose>
        <When Condition=" $(Configuration)=='debug' ">
            <PropertyGroup>
                <DebugSymbols>true</DebugSymbols>
                <DebugType>full</DebugType>
                <Optimize>false</Optimize>
                <OutputPath>.\bin\Debug\</OutputPath>
                <DefineConstants>DEBUG;TRACE</DefineConstants>
            </PropertyGroup>
            <ItemGroup>
                <Compile Include="UnitTesting\*.cs" />
                <Reference Include="NUnit.dll" />
            </ItemGroup>
        </When>
        <When Condition=" $(Configuration)=='retail' ">
            <PropertyGroup>
                <DebugSymbols>false</DebugSymbols>
                <Optimize>true</Optimize>
                <OutputPath>.\bin\Release\</OutputPath>
                <DefineConstants>TRACE</DefineConstants>
            </PropertyGroup>
        </When>
        <Otherwise>
            <PropertyGroup>
                <DebugSymbols>true</DebugSymbols>
                <Optimize>false</Optimize>
                <OutputPath>.\bin\$(Configuration)\</OutputPath>
                <DefineConstants>DEBUG;TRACE</DefineConstants>
            </PropertyGroup>
        </Otherwise>
    </Choose>
    <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
</Project>
```

## See also
- [Conditional constructs](../msbuild/msbuild-conditional-constructs.md)
- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
