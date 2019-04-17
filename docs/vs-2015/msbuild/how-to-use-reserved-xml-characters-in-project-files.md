---
title: "How to: Use Reserved XML Characters in Project Files | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "MSBuild, using reserved XML characters"
  - "MSBuild, reserved XML characters"
ms.assetid: 1ae37275-96bf-4e6e-897b-6b048e5bbe93
caps.latest.revision: 17
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Use Reserved XML Characters in Project Files
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you author project files, you might need to use reserved XML characters, for example, in property values or in task parameter values. However, some reserved characters must be replaced by a named entity so that the project file can be parsed.  
  
## Using Reserved Characters  
 The following table describes the reserved XML characters that must be replaced by the corresponding named entity so that the project file can be parsed.  
  
|Reserved character|Named entity|  
|------------------------|------------------|  
|\<|&lt;|  
|>|&gt;|  
|&|&amp;|  
|"|&quot;|  
|'|&apos;|  
  
#### To use double quotes in a project file  
  
- Replace the double quotes with the corresponding named entity, &quot;. For example, to place double quotes around the `EXEFile` item list, type:  
  
    ```  
    <Message Text="The output file is "@(EXEFile)"."/>  
    ```  
  
## Example  
 In the following code example, double quotes are used to highlight the file name in the message that is output by the project file.  
  
```  
<Project DefaultTargets="Compile"  
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003" >  
    <!-- Set the application name as a property -->  
    <PropertyGroup>  
        <appname>"HelloWorldCS"</appname>  
    </PropertyGroup>  
    <!-- Specify the inputs -->  
    <ItemGroup>  
        <CSFile Include = "consolehwcs1.cs" />  
    </ItemGroup>  
    <Target Name = "Compile">  
        <!-- Run the Visual C# compilation using input  
        files of type CSFile -->  
        <Csc Sources = "@(CSFile)">  
            <!-- Set the OutputAssembly attribute of the CSC task  
            to the name of the executable file that is created -->  
            <Output  
                TaskParameter = "OutputAssembly"  
                ItemName = "EXEFile"/>  
        </Csc>  
        <!-- Log the file name of the output file -->  
        <Message Text="The output file is "@(EXEFile)"."/>  
    </Target>  
</Project>  
```  
  
## See Also  
 [MSBuild Reference](../msbuild/msbuild-reference.md)
 [MSBuild](msbuild.md)
