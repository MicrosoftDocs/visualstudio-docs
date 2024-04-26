---
title: When Element (MSBuild)
description: Learn about the MSBuild When element, which specifies a possible block of code for the Choose element to select.
ms.date: 08/10/2022
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/msbuild/2003#When
dev_langs:
- VB
- CSharp
- C++
helpviewer_keywords:
- <When> Element [MSBuild]
- When Element [MSBuild]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# When element (MSBuild)

Specifies a possible block of code for the `Choose` element to select.

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
<When Condition="'StringA'=='StringB'">
    <PropertyGroup>... </PropertyGroup>
    <ItemGroup>... </ItemGroup>
    <Choose>... </Choose>
</When>
```

## Attributes and elements

 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|Condition|Required attribute.<br /><br /> Condition to evaluate. For more information, see [Conditions](../msbuild/msbuild-conditions.md).|

### Child elements

|Element|Description|
|-------------|-----------------|
|[Choose](../msbuild/choose-element-msbuild.md)|Optional element.<br /><br /> Evaluates child elements to select one section of code to execute. There may be zero or more `Choose` elements in a `When` element.|
|[ItemGroup](../msbuild/itemgroup-element-msbuild.md)|Optional element.<br /><br /> Contains a set of user-defined [Item](../msbuild/item-element-msbuild.md) elements. There may be zero or more `ItemGroup` elements in a `When` element.|
|[PropertyGroup](../msbuild/propertygroup-element-msbuild.md)|Optional element.<br /><br /> Contains a set of user-defined [Property](../msbuild/property-element-msbuild.md) elements. There may be zero or more `PropertyGroup` elements in a `When` element.|

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Choose element (MSBuild)](../msbuild/choose-element-msbuild.md)|Evaluates child elements to select one section of code to execute.|

## Remarks

 If the `Condition` attribute evaluates to true, the child `ItemGroup` and `PropertyGroup` elements of the `When` element are executed and all subsequent `When` elements are skipped.

 The `Choose`, `When`, and `Otherwise` elements are used together to provide a way to select one section of code to execute out of a number of possible alternatives. For more information, see [Conditional constructs](../msbuild/msbuild-conditional-constructs.md).

## Example

 The following project uses the `Choose` element to select which set of property values in the `When` elements to set. If the `Condition` attributes of both `When` elements evaluate to `false`, the property values in the `Otherwise` element are set. When running the example, try passing in various property settings from the command line, such as `msbuild myproj.proj -p:Configuration=Test;Platform=x86`, and see what the output path looks like. The example supposes the requirement is to set certain properties for debug and release builds, including the output folder based on the bitness of the platform rather than the actual platform name, and also support the 'Test' and 'Retail' configurations, but treat 'Retail' as 'Release'.

```xml
<Project>
    <PropertyGroup>
       <Configuration Condition="$(Configuration) == ''">Debug</Configuration>
       <Platform Condition="$(Platform) == ''">x64</Platform>
    </PropertyGroup>

  <Choose>
     <When Condition="$(Configuration)=='Test'">
        <PropertyGroup>
            <DebugSymbols>true</DebugSymbols>
            <DebugType>full</DebugType>
            <Optimize>false</Optimize>
            <DefineConstants>DEBUG;TRACE</DefineConstants>
        </PropertyGroup>
        <Choose>
          <When Condition="$(Platform)=='x86' Or $(Platform) == 'ARM32'">
            <PropertyGroup>
                <OutputPath>.\bin\Test\32-bit\</OutputPath>
            </PropertyGroup>
          </When>
          <When Condition="$(Platform)=='x64' Or $(Platform) == 'ARM64'">
            <PropertyGroup>
                <OutputPath>.\bin\Test\64-bit\</OutputPath>
            </PropertyGroup>
          </When>
          <!-- For any other platform, use the platform name -->
          <Otherwise>
            <PropertyGroup>
              <OutputPath>.\bin\Test\$(Platform)\</OutputPath>
            </PropertyGroup>
          </Otherwise>
        </Choose>
      </When>
      <When Condition="$(Configuration)=='Retail' Or $(Configuration)=='Release'">
        <PropertyGroup>
            <DebugSymbols>false</DebugSymbols>
            <Optimize>true</Optimize>
            <DefineConstants>TRACE</DefineConstants>
        </PropertyGroup>
        <Choose>
          <When Condition="$(Platform)=='x86' Or $(Platform) == 'ARM32'">
             <PropertyGroup>
                <OutputPath>.\bin\Release\32-bit\</OutputPath>
             </PropertyGroup>
          </When>
          <When Condition="$(Platform)=='x64' Or $(Platform) == 'ARM64'">
             <PropertyGroup>
                <OutputPath>.\bin\Release\64-bit\</OutputPath>
             </PropertyGroup>
          </When>
          <!-- For any other platform, use the platform name -->
          <Otherwise>
            <PropertyGroup>
                <OutputPath>.\bin\Release\$(Platform)\</OutputPath>
            </PropertyGroup>
          </Otherwise>
        </Choose>
      </When>
      <!-- For any other configuration, use debug properties-->
      <Otherwise>
        <PropertyGroup>
            <DebugSymbols>true</DebugSymbols>
            <DebugType>full</DebugType>
            <Optimize>false</Optimize>
            <DefineConstants>DEBUG;TRACE</DefineConstants>
        </PropertyGroup>
        <Choose>
          <When Condition="$(Platform)=='x86' Or $(Platform)=='ARM32'">
            <PropertyGroup>
              <OutputPath>.\bin\$(Configuration)\32-bit\</OutputPath>
            </PropertyGroup>
          </When>
          <When Condition="$(Platform)=='x64' Or $(Platform)=='ARM64'">
            <PropertyGroup>
              <OutputPath>.\bin\$(Configuration)\64-bit\</OutputPath>
            </PropertyGroup>
          </When>
        </Choose>
       </Otherwise>
  </Choose>

  <Target Name="ShowProperties">
    <Message Text="DebugSymbols: $(DebugSymbols)"/>
    <Message Text="Optimize: $(Optimize)"/>
    <Message Text="DefineConstants: $(DefineConstants)"/>
    <Message Text="OutputPath: $(OutputPath)"/>
  </Target>
</Project>
```

## See also

- [Conditional constructs](../msbuild/msbuild-conditional-constructs.md)
- [Project file schema reference](../msbuild/msbuild-project-file-schema-reference.md)
