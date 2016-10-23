---
title: "MSBuild Conditional Constructs"
ms.custom: na
ms.date: 10/07/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - jsharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: dd54258e-f4fb-448f-9da4-d1817e0cbaf2
caps.latest.revision: 9
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# MSBuild Conditional Constructs
MSBuild provides a mechanism for either/or processing with the [Choose](../VS_IDE/Choose-Element--MSBuild-.md), [When](../VS_IDE/When-Element--MSBuild-.md), and [Otherwise](../VS_IDE/Otherwise-Element--MSBuild-.md) elements.  
  
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
 [Choose Element (MSBuild)](../VS_IDE/Choose-Element--MSBuild-.md)   
 [When Element (MSBuild)](../VS_IDE/When-Element--MSBuild-.md)   
 [Otherwise Element (MSBuild)](../VS_IDE/Otherwise-Element--MSBuild-.md)   
 [MSBuild Reference](../VS_IDE/MSBuild-Reference.md)