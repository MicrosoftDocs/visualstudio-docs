---
title: "How to: Build a Project That Has Resources"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d07ac73f-2c2d-4e9a-812a-6dcb632bafe2
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
# How to: Build a Project That Has Resources
<?xml version="1.0" encoding="utf-8"?>
<developerHowToDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>If you are building localized versions of a project, all user interface elements must be separated into resource files for the different languages. If the project uses only strings, the resource files can use text files. Alternatively, you can use .resx files as the resource files.</para>
  </introduction>
  <section>
    <title>Compiling Resources with MSBuild</title>
    <content>
      <para>The library of common tasks that is provided with <token>vstecmsbuild</token> includes a <unmanagedCodeEntityReference>GenerateResource</unmanagedCodeEntityReference> task that you can use to compile resources in either .resx or text files. This task includes the <codeInline>Sources</codeInline> parameter to specify which resource files to compile and the <codeInline>OutputResources</codeInline> parameter to specify names for the output resource files. For more information on the <unmanagedCodeEntityReference>GenerateResource</unmanagedCodeEntityReference> task, see <link xlink:href="c0aff32f-f2cc-46f6-9c3e-a5c9f8f912b1">GenerateResource Task</link>.</para>
      <procedure>
        <title>To compile resources with MSBuild</title>
        <steps class="ordered">
          <step>
            <content>
              <para>Identify the project's resource files and pass them to the <unmanagedCodeEntityReference>GenerateResource</unmanagedCodeEntityReference> task, either as item lists, or as file names.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Specify the <unmanagedCodeEntityReference>OutputResources</unmanagedCodeEntityReference> parameter of the <unmanagedCodeEntityReference>GenerateResource</unmanagedCodeEntityReference> task, which allows you to set the names for the output resource files.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Use the <unmanagedCodeEntityReference>Output</unmanagedCodeEntityReference> element of the task to store the value of the <unmanagedCodeEntityReference>OutputResources</unmanagedCodeEntityReference> parameter in an item.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Use the item created from the <unmanagedCodeEntityReference>Output</unmanagedCodeEntityReference> element as an input into another task.</para>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <codeExample>
    <description>
      <content>
        <para>The following code example shows how the <unmanagedCodeEntityReference>Output</unmanagedCodeEntityReference> element specifies that the <unmanagedCodeEntityReference>OutputResources</unmanagedCodeEntityReference> attribute of the <unmanagedCodeEntityReference>GenerateResource</unmanagedCodeEntityReference> task will contain the compiled resource files <codeInline>alpha.resources</codeInline> and <codeInline>beta.resources</codeInline> and that those two files will be placed inside the <codeInline>Resources</codeInline> item list. By identifying those .resources files as a collection of items of the same name, you can easily use them as inputs for another task, such as the <legacyLink xlink:href="d8c19b36-f5ca-484b-afa6-8ff3b90e103a">Csc</legacyLink> task.</para>
        <para>This task is equivalent to using the <system>/compile</system> switch for <legacyLink xlink:href="8ef159de-b660-4bec-9213-c3fbc4d1c6f4">Resgen.exe</legacyLink>:</para>
        <para>
          <codeInline>Resgen.exe /compile alpha.resx,alpha.resources /compile beta.txt,beta.resources</codeInline>
        </para>
      </content>
    </description>
    <code>&lt;GenerateResource
    Sources="alpha.resx; beta.txt"
    OutputResources="alpha.resources; beta.resources"&gt;
    &lt;Output TaskParameter="OutputResources"
        ItemName="Resources"/&gt;
&lt;/GenerateResource&gt;</code>
    <comments>
      <content />
    </comments>
  </codeExample>
  <codeExample>
    <description>
      <content>
        <para>The following example project contains two tasks: the <unmanagedCodeEntityReference>GenerateResource</unmanagedCodeEntityReference> task to compile resources and the <unmanagedCodeEntityReference>Csc</unmanagedCodeEntityReference> task to compile both the source code files and the compiled resources files. The resource files compiled by the <unmanagedCodeEntityReference>GenerateResource</unmanagedCodeEntityReference> task are stored in the <codeInline>Resources</codeInline> item and passed to the <unmanagedCodeEntityReference>Csc</unmanagedCodeEntityReference> task.</para>
      </content>
    </description>
    <code>&lt;Project DefaultTargets = "Build"
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003" &gt;

    &lt;Target Name="Resources"&gt;
        &lt;GenerateResource
            Sources="alpha.resx; beta.txt"
            OutputResources="alpha.resources; beta.resources"&gt;
            &lt;Output TaskParameter="OutputResources"
                ItemName="Resources"/&gt;
        &lt;/GenerateResource&gt;
    &lt;/Target&gt;

    &lt;Target Name="Build" DependsOnTargets="Resources"&gt;
        &lt;Csc Sources="hello.cs"
                Resources="@(Resources)"
                OutputAssembly="hello.exe"/&gt;
    &lt;/Target&gt;
&lt;/Project&gt;</code>
    <comments>
      <content />
    </comments>
  </codeExample>
  <relatedTopics>
<link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild</link>
<link xlink:href="c0aff32f-f2cc-46f6-9c3e-a5c9f8f912b1">GenerateResource Task</link>
<link xlink:href="d8c19b36-f5ca-484b-afa6-8ff3b90e103a">Csc Task</link>
<link xlink:href="8ef159de-b660-4bec-9213-c3fbc4d1c6f4">Resource File Generator (Resgen.exe)</link>
</relatedTopics>
</developerHowToDocument>