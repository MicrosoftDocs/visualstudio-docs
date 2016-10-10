---
title: "How to: Use Reserved XML Characters in Project Files"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1ae37275-96bf-4e6e-897b-6b048e5bbe93
caps.latest.revision: 12
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
# How to: Use Reserved XML Characters in Project Files
<?xml version="1.0" encoding="utf-8"?>
<developerHowToDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>When you author project files, you might need to use reserved XML characters, for example, in property values or in task parameter values. However, some reserved characters must be replaced by a named entity so that the project file can be parsed.</para>
  </introduction>
  <section>
    <title>Using Reserved Characters</title>
    <content>
      <para>The following table describes the reserved XML characters that must be replaced by the corresponding named entity so that the project file can be parsed.</para>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>Reserved character</para>
            </TD>
            <TD>
              <para>Named entity</para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>&lt;</para>
            </TD>
            <TD>
              <para>&amp;lt;</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>&gt;</para>
            </TD>
            <TD>
              <para>&amp;gt;</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>&amp;</para>
            </TD>
            <TD>
              <para>&amp;amp;</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>"</para>
            </TD>
            <TD>
              <para>&amp;quot;</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>'</para>
            </TD>
            <TD>
              <para>&amp;apos;</para>
            </TD>
          </tr>
        </tbody>
      </table>
      <procedure>
        <title>To use double quotes in a project file</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Replace the double quotes with the corresponding named entity, &amp;quot;. For example, to place double quotes around the <codeInline>EXEFile</codeInline> item list, type:</para>
              <code>&lt;Message Text="The output file is &amp;quot;@(EXEFile)&amp;quot;."/&gt;</code>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <codeExample>
    <description>
      <content>
        <para>In the following code example, double quotes are used to highlight the file name in the message that is output by the project file.</para>
      </content>
    </description>
    <code>&lt;Project DefaultTargets="Compile"
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003" &gt;
    &lt;!-- Set the application name as a property --&gt;
    &lt;PropertyGroup&gt;
        &lt;appname&gt;"HelloWorldCS"&lt;/appname&gt;
    &lt;/PropertyGroup&gt;
    &lt;!-- Specify the inputs --&gt;
    &lt;ItemGroup&gt;
        &lt;CSFile Include = "consolehwcs1.cs" /&gt;
    &lt;/ItemGroup&gt;
    &lt;Target Name = "Compile"&gt;
        &lt;!-- Run the Visual C# compilation using input
        files of type CSFile --&gt;
        &lt;Csc Sources = "@(CSFile)"&gt;
            &lt;!-- Set the OutputAssembly attribute of the CSC task
            to the name of the executable file that is created --&gt;
            &lt;Output
                TaskParameter = "OutputAssembly"
                ItemName = "EXEFile"/&gt;
        &lt;/Csc&gt;
        &lt;!-- Log the file name of the output file --&gt;
        &lt;Message Text="The output file is &amp;quot;@(EXEFile)&amp;quot;."/&gt;
    &lt;/Target&gt;
&lt;/Project&gt;</code>
    <comments>
      <content />
    </comments>
  </codeExample>
  <relatedTopics>
<link xlink:href="093395e1-70da-4f74-b34d-046c5e2b32e8">MSBuild Reference</link>

</relatedTopics>
</developerHowToDocument>