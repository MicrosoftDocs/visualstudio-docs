---
title: "Choose Element (MSBuild)"
ms.custom: na
ms.date: 10/03/2016
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
ms.assetid: 7b8b025a-d944-4f5c-9018-c89fc2ef146d
caps.latest.revision: 8
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
# Choose Element (MSBuild)
Evaluates child elements to select one set of `ItemGroup` elements and/or `PropertyGroup` elements to evaluate.  
  
 <Project\>  
 <Choose\>  
 <When\>  
 <Choose\>  
 ...  
 <Otherwise\>  
 <Choose\>  
 ...  
  
## Syntax  
  
```  
<Choose>  
    <When Condition="'StringA'=='StringB'">... </When>  
    <Otherwise>... </Otherwise>  
</Choose>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Otherwise](../VS_IDE/Otherwise-Element--MSBuild-.md)|Optional element.<br /><br /> Specifies the block of code `PropertyGroup` and `ItemGroup` elements to evaluate if the conditions of all `When` elements evaluate to `false`. There may be zero or one `Otherwise` elements in a `Choose` element, and it must be the last element.|  
|[When](../VS_IDE/When-Element--MSBuild-.md)|Required element.<br /><br /> Specifies a possible block of code for the `Choose` element to select. There may be one or more `When` elements in a `Choose` element.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Otherwise](../VS_IDE/Otherwise-Element--MSBuild-.md)|Specifies the block of code to execute if the conditions of all `When` elements evaluate to `false`.|  
|[Project](../VS_IDE/Project-Element--MSBuild-.md)|Required root element of an MSBuild project file.|  
|[When](../VS_IDE/When-Element--MSBuild-.md)|Specifies a possible block of code for the `Choose` element to select.|  
  
## Remarks  
 The `Choose`, `When`, and `Otherwise` elements are used together to provide a way to select one section of code to execute out of a number of possible alternatives. For more information, see [Conditional Constructs](../VS_IDE/MSBuild-Conditional-Constructs.md).  
  
## Example  
 The following project uses the `Choose` element to select which set of property values in the `When` elements to set. If the `Condition` attributes of both `When` elements evaluate to `false`, the property values in the `Otherwise` element are set.  
  
```  
<Project  
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003" >  
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
  
## See Also  
 [Conditional Constructs](../VS_IDE/MSBuild-Conditional-Constructs.md)   
 [Project File Schema Reference](../VS_IDE/MSBuild-Project-File-Schema-Reference.md)