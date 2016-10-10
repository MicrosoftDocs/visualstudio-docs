---
title: "MSBuild Error MSB1003"
ms.custom: na
ms.date: 10/02/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: db4aa779-af86-4bb6-b86f-9a31866f70f5
caps.latest.revision: 11
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# MSBuild Error MSB1003
<?xml version="1.0" encoding="utf-8"?>
<developerErrorMessageDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>
      <ui>Specify a project or solution file. The current working directory does not contain a project or solution file.</ui>
    </para>
    <para>If a project or solution file is not specified on the command line, <token>vstecmsbuild</token> searches the current working directory for a file that has a file extension that ends in "proj" or "sln" and uses that file. The current working directory does not contain a file that has a file extension that ends in "proj" or "sln".</para>
  </introduction>
  <procedure>
    <title>To correct this error</title>
    <steps class="bullet">
      <step>
        <content>
          <para>Go to the directory that contains the project file you want to build.</para>
        </content>
      </step>
      <step>
        <content>
          <para>Specify either the full or relative path to the project file. For example, type <codeInline>msbuild c:\myapp\myapp.proj</codeInline> or <codeInline>msbuild ..\..\myapp\myapp.proj</codeInline></para>
        </content>
      </step>
      <step>
        <content>
          <para>If the project or solution file has a file extension that does not end in "proj", change the file extension so that it does end in "proj".</para>
        </content>
      </step>
    </steps>
  </procedure>
  <relatedTopics>
<link xlink:href="edaa65ec-ab8a-42a1-84cb-d76d5b2f4584">MSBuild Command Line Reference</link>
<link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild</link>
<link xlink:href="d9a68146-1f43-4621-ac78-2c8c3f400936">MSBuild Project File Schema Reference</link>
</relatedTopics>
</developerErrorMessageDocument>