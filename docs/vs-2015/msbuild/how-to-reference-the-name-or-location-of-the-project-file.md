---
title: "How to: Reference the Name or Location of the Project File | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: conceptual
helpviewer_keywords: 
  - "locations, referencing"
  - "locations"
  - "MSBuildProjectName property"
  - "MSBuild, referencing the project file"
  - "names, referencing"
  - "reserved properties"
  - "project files, referencing"
ms.assetid: c8fcc594-5d37-4e2e-b070-4d9c012043b5
caps.latest.revision: 16
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# How to: Reference the Name or Location of the Project File
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use the name or location of the project in the project file itself without having to create your own property. [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] provides reserved properties that reference the project file name and other properties related to the project. For more information on reserved properties, see [MSBuild Reserved and Well-Known Properties](../msbuild/msbuild-reserved-and-well-known-properties.md).  
  
## Using the MSBuildProjectName Property  
 [!INCLUDE[vstecmsbuild](../includes/vstecmsbuild-md.md)] provides some reserved properties that you can use in your project files without defining them each time. For example, the reserved property `MSBuildProjectName` provides a reference to the project file name.  
  
#### To use the MSBuildProjectName Property  
  
- Reference the property in the project file with the $() notation, just as you would with any property. For example:  
  
  ```  
  <CSC Sources = "@(CSFile)"   
      OutputAssembly = "$(MSBuildProjectName).exe"/>  
  </CSC>  
  ```  
  
  An advantage of using a reserved property is that any changes to the project file name are incorporated automatically. The next time that you build the project, the output file will have the new name with no further action required on your part.  
  
> [!NOTE]
> Reserved properties cannot be redefined in the project file.  
  
## Example  
 The following example project file references the project name as a reserved property to specify the name for the output.  
  
```  
<Project xmlns="http://scheams.microsoft.com/developer/msbuild/2003"   
    DefaultTargets = "Compile">  
  
    <!-- Specify the inputs -->  
    <ItemGroup>  
        <CSFile Include = "consolehwcs1.cs"/>  
    </ItemGroup>  
    <Target Name = "Compile">  
        <!-- Run the Visual C# compilation using  
        input files of type CSFile -->  
        <CSC Sources = "@(CSFile)"  
            OutputAssembly = "$(MSBuildProjectName).exe" >  
            <!-- Set the OutputAssembly attribute of the CSC task  
            to the name of the project -->  
            <Output  
                TaskParameter = "OutputAssembly"  
                ItemName = "EXEFile" />  
        </CSC>  
        <!-- Log the file name of the output file -->  
        <Message Text="The output file is @(EXEFile)"/>  
    </Target>  
</Project>  
```  
  
## See Also  
[MSBuild](msbuild.md)  
 [MSBuild Reserved and Well-Known Properties](../msbuild/msbuild-reserved-and-well-known-properties.md)
