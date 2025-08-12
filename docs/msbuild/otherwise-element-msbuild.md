---
title: Otherwise Element (MSBuild)
description: Learn how MSBuild uses the Otherwise element to specify the block of code to execute if and only if the conditions of all When elements are false.
ms.date: 03/13/2017
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#Otherwise
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- <Otherwise> Element [MSBuild]
- Otherwise Element [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Otherwise element (MSBuild)

Specifies the block of code to execute if and only if the conditions of all `When` elements evaluate to `false`.

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
<Otherwise>
    <PropertyGroup>... </PropertyGroup>
    <ItemGroup>... </ItemGroup>
    <Choose>... </Choose>
</Otherwise>
```

## Attributes and elements

 The following sections describe attributes, child elements, and parent elements.

### Attributes

 None.

### Child elements

|Element|Description|
|-------------|-----------------|
|[Choose](../msbuild/choose-element-msbuild.md)|Optional element.<br /><br /> Evaluates child elements to select one section of code to execute. There may be zero or more `Choose` elements in an `Otherwise` element.|
|[ItemGroup](../msbuild/itemgroup-element-msbuild.md)|Optional element.<br /><br /> Contains a set of user-defined [Item](../msbuild/item-element-msbuild.md) elements. There may be zero or more `ItemGroup` elements in an `Otherwise` element.|
|[PropertyGroup](../msbuild/propertygroup-element-msbuild.md)|Optional element.<br /><br /> Contains a set of user-defined [Property](../msbuild/property-element-msbuild.md) elements. There may be zero or more `PropertyGroup` elements in an `Otherwise` element.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Choose](../msbuild/choose-element-msbuild.md)|Evaluates child elements to select one section of code to execute.|

## Remarks

 There may be only one `Otherwise` element in a `Choose` element, and it must be last element.

 The `Choose`, `When`, and `Otherwise` elements are used together to provide a way to select one section of code to execute out of a number of possible alternatives. For more information, see [Conditional constructs](../msbuild/msbuild-conditional-constructs.md).

## Example

 The following project uses the `Choose` element to select which set of property values in the `When` elements to set. If the `Condition` attributes of both `When` elements evaluate to `false`, the property values in the `Otherwise` element are set.

```xml
<Project>
    <PropertyGroup>
        <Configuration Condition="'$(Configuration)' == ''">Debug</Configuration>
        <OutputType>Exe</OutputType>
        <RootNamespace>ConsoleApplication1</RootNamespace>
        <AssemblyName>ConsoleApplication1</AssemblyName>
        <WarningLevel>4</WarningLevel>
    </PropertyGroup>
    <Choose>
        <When Condition=" '$(Configuration)'=='debug' ">
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
        <When Condition=" '$(Configuration)'=='retail' ">
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
