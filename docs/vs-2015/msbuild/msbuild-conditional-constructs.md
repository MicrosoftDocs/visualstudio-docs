---
title: "MSBuild Conditional Constructs | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "<Choose> Element [MSBuild]"
  - "Choose Element [MSBuild]"
  - "conditional constructs [MSBuild]"
  - "MSBuild, conditional constructs"
  - "<When> Element [MSBuild]"
  - "<Otherwise> Element [MSBuild]"
  - "Otherwise Element [MSBuild]"
  - "When Element [MSBuild]"
ms.assetid: dd54258e-f4fb-448f-9da4-d1817e0cbaf2
caps.latest.revision: 12
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# MSBuild Conditional Constructs
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

[!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] provides a mechanism for either/or processing with the [Choose](../msbuild/choose-element-msbuild.md), [When](../msbuild/when-element-msbuild.md), and [Otherwise](../msbuild/otherwise-element-msbuild.md) elements.  
  
## Using the Choose Element  
 The `Choose` element contains a series of `When` elements with `Condition` attributes that are tested in order from top to bottom until one evaluates to `true`. If more than one `When` element evaluates to `true`, only the first one is used. An `Otherwise` element, if present, will be evaluated if no condition on a `When` element evaluates to `true`.  
  
 `Choose` elements can be used as child elements of `Project`, `When` and `Otherwise` elements. `When` and `Otherwise` elements can have `ItemGroup`, `PropertyGroup`, or `Choose` child elements.  
  
## Example  
 The following example uses the `Choose` and `When` elements for either/or processing. The properties and items for the project are set depending on the value of the `Configuration` property.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" >  
    <PropertyGroup>  
        <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>  
        <OutputType>Exe</OutputType>  
        <RootNamespace>ConsoleApplication1</RootNamespace>  
        <AssemblyName>ConsoleApplication1</AssemblyName>  
        <WarningLevel>4</WarningLevel>  
    </PropertyGroup>  
    <Choose>  
        <When Condition=" '$(Configuration)'=='Debug' ">  
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
    </Choose>  
    <!-- Rest of Project -->  
</Project>  
```  
  
## See Also  
 [Choose Element (MSBuild)](../msbuild/choose-element-msbuild.md)   
 [When Element (MSBuild)](../msbuild/when-element-msbuild.md)   
 [Otherwise Element (MSBuild)](../msbuild/otherwise-element-msbuild.md)   
 [MSBuild Reference](../msbuild/msbuild-reference.md)
