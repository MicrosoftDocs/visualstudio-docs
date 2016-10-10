---
title: "How to: Reference the Name or Location of the Project File"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c8fcc594-5d37-4e2e-b070-4d9c012043b5
caps.latest.revision: 10
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
# How to: Reference the Name or Location of the Project File
<?xml version="1.0" encoding="utf-8"?>
<developerHowToDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>You can use the name or location of the project in the project file itself without having to create your own property. <token>vstecmsbuild</token> provides reserved properties that reference the project file name and other properties related to the project. For more information on reserved properties, see <link xlink:href="99333e61-83c9-4804-84e3-eda297c2478d">MSBuild Reserved Properties</link>.</para>
  </introduction>
  <section>
    <title>Using the MSBuildProjectName Property</title>
    <content>
      <para>
        <token>vstecmsbuild</token> provides some reserved properties that you can use in your project files without defining them each time. For example, the reserved property <unmanagedCodeEntityReference>MSBuildProjectName</unmanagedCodeEntityReference> provides a reference to the project file name.</para>
      <procedure>
        <title>To use the MSBuildProjectName Property</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Reference the property in the project file with the $() notation, just as you would with any property. For example:</para>
              <code>&lt;CSC Sources = "@(CSFile)" 
    OutputAssembly = "$(MSBuildProjectName).exe"/&gt;
&lt;/CSC&gt;</code>
            </content>
          </step>
        </steps>
      </procedure>
      <para>An advantage of using a reserved property is that any changes to the project file name are incorporated automatically. The next time that you build the project, the output file will have the new name with no further action required on your part.</para>
      <alert class="note">
        <para>Reserved properties cannot be redefined in the project file.</para>
      </alert>
    </content>
  </section>
  <codeExample>
    <description>
      <content>
        <para>The following example project file references the project name as a reserved property to specify the name for the output. </para>
      </content>
    </description>
    <code>&lt;Project xmlns="http://scheams.microsoft.com/developer/msbuild/2003" 
    DefaultTargets = "Compile"&gt;

    &lt;!-- Specify the inputs --&gt;
    &lt;ItemGroup&gt;
        &lt;CSFile Include = "consolehwcs1.cs"/&gt;
    &lt;/ItemGroup&gt;
    &lt;Target Name = "Compile"&gt;
        &lt;!-- Run the Visual C# compilation using
        input files of type CSFile --&gt;
        &lt;CSC Sources = "@(CSFile)"
            OutputAssembly = "$(MSBuildProjectName).exe" &gt;
            &lt;!-- Set the OutputAssembly attribute of the CSC task
            to the name of the project --&gt;
            &lt;Output
                TaskParameter = "OutputAssembly"
                ItemName = "EXEFile" /&gt;
        &lt;/CSC&gt;
        &lt;!-- Log the file name of the output file --&gt;
        &lt;Message Text="The output file is @(EXEFile)"/&gt;
    &lt;/Target&gt;
&lt;/Project&gt;</code>
    <comments>
      <content />
    </comments>
  </codeExample>
  <relatedTopics>

<link xlink:href="99333e61-83c9-4804-84e3-eda297c2478d">MSBuild Reserved Properties</link>
</relatedTopics>
</developerHowToDocument>