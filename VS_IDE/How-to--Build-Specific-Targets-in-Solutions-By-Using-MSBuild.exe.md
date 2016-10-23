---
title: "How to: Build Specific Targets in Solutions By Using MSBuild.exe"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f46feb9b-4c16-4fec-b6e1-36a959692ba3
caps.latest.revision: 7
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
# How to: Build Specific Targets in Solutions By Using MSBuild.exe
<?xml version="1.0" encoding="utf-8"?>
<developerHowToDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>You can use MSBuild.exe to build specific targets of specific projects in a solution.</para>
  </introduction>
  <procedure>
    <title>To build a specific target of a specific project in a solution</title>
    <steps class="ordered">
      <step>
        <content>
          <para>At the command line, type <userInput>MSBuild.exe &lt;SolutionName&gt;.sln</userInput>, where <userInput>&lt;SolutionName&gt;</userInput> corresponds to the file name of the solution that contains the target that you want to execute.</para>
        </content>
      </step>
      <step>
        <content>
          <para>Specify the target after the <system>/t</system> switch in the format <placeholder>ProjectName</placeholder>:<placeholder>TargetName</placeholder>.</para>
        </content>
      </step>
    </steps>
  </procedure>
  <codeExample>
    <description>
      <content>
        <para>The following example executes the <codeInline>Rebuild</codeInline> target of the <codeInline>NotInSlnFolder</codeInline> project, and then executes the <codeInline>Clean</codeInline> target of the <codeInline>InSolutionFolder</codeInline> project, which is located in the <codeInline>NewFolder</codeInline> solution folder.</para>
      </content>
    </description>
    <code>msbuild SlnFolders.sln /t:NotInSlnfolder:Rebuild;NewFolder\InSolutionFolder:Clean</code>
  </codeExample>
  <relatedTopics>
<link xlink:href="edaa65ec-ab8a-42a1-84cb-d76d5b2f4584">MSBuild Command Line Reference</link>
<link xlink:href="093395e1-70da-4f74-b34d-046c5e2b32e8">MSBuild Reference</link>
<link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild</link>
<link xlink:href="083b8ba3-e4ad-45af-bb5d-3bc81d406131">MSBuild Concepts</link>
</relatedTopics>
</developerHowToDocument>